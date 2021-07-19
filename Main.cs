using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace UIF
{
	public partial class Main : Form
	{
		public static string CurrentFolderPath = null;
		private readonly string ModsTip = "Path to folder with mods.\nExample: " +
			@"C:\Program Files (x86)\Steam\steamapps\workshop\content\304930" +
			"\n\nBefore using it, you need to delete all the downloaded mods and log in to the server.";
		private ToolTip Tip = new ToolTip();
		private readonly string FolderErrorText = "Folder is not specified!";

		private void UpdateFoldersPaths()
		{
			Properties.Settings.Default.FoldersPaths = string.Empty;
			for (int i = 0; i < FldrComboBox.Items.Count; i++) {
				string fldrString = FldrComboBox.Items[i].ToString();
				if (FldrComboBox.Items[i] != null &&
					fldrString != "" &&
					fldrString != "\n") {
					Properties.Settings.Default.FoldersPaths += FldrComboBox.Items[i].ToString();
					if (i < FldrComboBox.Items.Count - 1) Properties.Settings.Default.FoldersPaths += '\n';
				}
			}
			Properties.Settings.Default.Save();
		}

		public Main()
		{
			InitializeComponent();
			VersionLabel.Text += Program.Version;
			this.Text += " | Ver. " + Program.Version;

			FldrComboBox.Items.Clear();
			foreach (string path in Properties.Settings.Default.FoldersPaths.Split('\n')) {
				if (path != string.Empty)
					FldrComboBox.Items.Add(path);
			}

			if (FldrComboBox.Items.Count > 0)
				FldrComboBox.SelectedIndex = 0;

			Tip.SetToolTip(InfoBtn, ModsTip);
			Tip.SetToolTip(SelectFldrLabel, ModsTip);

			Tip.SetToolTip(MinusFldrBtn, "Delete selected folder");
			Tip.SetToolTip(PlusFldrBtn, "Add selected folder");
			Tip.SetToolTip(OpenFldrBtn, "Open selected folder");

			Tip.SetToolTip(DiscordLink, Program.DiscordUrl);
			Tip.SetToolTip(GitHubLink, Program.GithubUrl);
		}

		private void EnterNameLabel_Click(object sender, EventArgs e) => NameTextBox.Focus();
		
		private void EnterIdLabel_Click(object sender, EventArgs e) => this.IDBox.Focus();

		private void SearchNameBtn_Click(object sender, EventArgs e)
		{
			if (CurrentFolderPath == null) {
				throw new ArgumentNullException(FolderErrorText);
			} else {
				var items = Core.ParseAll(CurrentFolderPath, i => i.name.ToLower().Contains(NameTextBox.Text.ToLower()));

				new ItemList(items).ShowDialog();
			}
		}

		private void AllItemsBtn_Click(object sender, EventArgs e)
		{
			if (CurrentFolderPath == null)
				throw new ArgumentNullException(FolderErrorText);
			else
				new ItemsCategories().ShowDialog();
		}

		private void PlusFldrBtn_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			
			if (fbd.ShowDialog() == DialogResult.OK) {
				if (fbd.SelectedPath != null) {
					int newFolderIndex = FldrComboBox.Items.Add(fbd.SelectedPath);
					FldrComboBox.SelectedIndex = newFolderIndex;

					UpdateFoldersPaths();
				}
			}
		}

		private void MinusFldrBtn_Click(object sender, EventArgs e)
		{
			if (FldrComboBox.SelectedIndex != -1) {
				FldrComboBox.Items.RemoveAt(FldrComboBox.SelectedIndex);
				FldrComboBox.Text = string.Empty;
				FldrComboBox.SelectedIndex = FldrComboBox.Items.Count > 0 ? 0 : -1;

				UpdateFoldersPaths();
			} else {
				throw new ArgumentNullException(FolderErrorText);
			}
		}

		private void OpenFldrBtn_Click(object sender, EventArgs e)
		{
			if (Directory.Exists(CurrentFolderPath))
				Process.Start("explorer.exe", CurrentFolderPath);
			else
				throw new ArgumentNullException(FolderErrorText);
		}

		private void SearchIDButton_Click(object sender, EventArgs e)
		{
			if (CurrentFolderPath == null) {
				throw new ArgumentNullException(FolderErrorText);
			} else {
				var items = Core.ParseAll(CurrentFolderPath, i => i.id == int.Parse(IDBox.Text));

				new ItemList(items).ShowDialog();
			}
		}

		private void GitHubLink_Click(object sender, EventArgs e) => Misc.OpenUrl(Program.GithubUrl);

		private void DiscordLink_Click(object sender, EventArgs e) => Misc.OpenUrl(Program.DiscordUrl);

		private void InfoBtn_Click(object sender, EventArgs e) => Tip.Show(ModsTip, InfoBtn);

		private void SelectFldrLabel_Click(object sender, EventArgs e) => Tip.Show(ModsTip, SelectFldrLabel);

		private void FldrComboBox_SelectedIndexChanged(object sender, EventArgs e) => CurrentFolderPath = FldrComboBox.Text;

		private void FldrComboBox_TextUpdate(object sender, EventArgs e) => FldrComboBox.Text = CurrentFolderPath;

		private void LoadModsToRamBtn_Click(object sender, EventArgs e)
		{
			if (CurrentFolderPath != null)
				if (Core.loadedItems != null) {
					Core.loadedItems = null;
					GC.Collect();
					FldrComboBox.Enabled = true;
					LoadModsToRamBtn.Text = "Load mods";
				} else {
					Core.loadedItems = Core.ParseAll(CurrentFolderPath);
					FldrComboBox.Enabled = false;
					LoadModsToRamBtn.Text = "Unload mods";
				}
			else
				throw new ArgumentNullException(FolderErrorText);
		}
	}
}
