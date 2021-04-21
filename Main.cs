using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIF
{
	public partial class Main : Form
	{
		public string RegistryFolderPath = (string)Core.GetRegistryParam(Program.Version+"\\Settings\\modsPath");
		public string CurrentFolderPath = null;
		private string ModsTip = "Path to folder with mods.\nExample: " +
			@"C:\Program Files (x86)\Steam\steamapps\workshop\content\304930" +
			"\n\nBefore using it, you need to delete all the downloaded mods and log in to the server.";
		private ToolTip Tip = new ToolTip();

		private void updateRegistry()
		{
			RegistryFolderPath = String.Empty;
			for (int i = 0; i < FldrComboBox.Items.Count; i++)
			{
				RegistryFolderPath += FldrComboBox.Items[i].ToString();
				if (i < FldrComboBox.Items.Count - 1) RegistryFolderPath += '\n';
			}
			Core.SetRegistryParam(Program.Version + "\\Settings\\modsPath", RegistryFolderPath);
		}

		public Main()
		{
			InitializeComponent();
			VersionLabel.Text += Program.Version;
			this.Text += " | Ver. " + Program.Version;

			FldrComboBox.Items.Clear();
			if (RegistryFolderPath != null)
			{
				FldrComboBox.Items.AddRange(RegistryFolderPath.Split('\n'));

				FldrComboBox.SelectedIndex = 0;
			}

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
			if (CurrentFolderPath == null)
				MessageBox.Show("Folder is not specified!");
			else
			{
				var items = Core.parseAll(CurrentFolderPath, i => i.name.ToLower().Contains(NameTextBox.Text.ToLower()));
				
				new itemList(items).ShowDialog();
			}
		}

		private void AllItemsBtn_Click(object sender, EventArgs e)
		{
			if (CurrentFolderPath == null)
				MessageBox.Show("Folder is not specified!");
			else
			{
				new ItemsCategories(CurrentFolderPath).ShowDialog();
			}
		}

		private void PlusFldrBtn_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			
			if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				if (fbd.SelectedPath != null)
				{
					int newFolderIndex = FldrComboBox.Items.Add(fbd.SelectedPath);
					FldrComboBox.SelectedIndex = newFolderIndex;

					updateRegistry();
				}
			}
		}

		private void MinusFldrBtn_Click(object sender, EventArgs e)
		{
			if (FldrComboBox.SelectedIndex != -1)
			{
				FldrComboBox.Items.RemoveAt(FldrComboBox.SelectedIndex);

				updateRegistry();
			} else
				MessageBox.Show("Folder isn't selected");
		}

		private void OpenFldrBtn_Click(object sender, EventArgs e)
		{
			if (Directory.Exists(CurrentFolderPath))
				Process.Start("explorer.exe", CurrentFolderPath);
			else
				MessageBox.Show("Folder isn't selected");
		}

		private void SearchIDButton_Click(object sender, EventArgs e)
		{
			if (CurrentFolderPath == null)
				MessageBox.Show("Folder is not specified!");
			else
			{
				var items = Core.parseAll(CurrentFolderPath, i => i.id == int.Parse(IDBox.Text));

				new itemList(items).ShowDialog();
			}
		}

		private void GitHubLink_Click(object sender, EventArgs e) => Misc.OpenUrl(Program.GithubUrl);

		private void DiscordLink_Click(object sender, EventArgs e) => Misc.OpenUrl(Program.DiscordUrl);

		private void InfoBtn_Click(object sender, EventArgs e) => Tip.Show(ModsTip, InfoBtn);

		private void SelectFldrLabel_Click(object sender, EventArgs e) => Tip.Show(ModsTip, SelectFldrLabel);

		private void FldrComboBox_SelectedIndexChanged(object sender, EventArgs e) => CurrentFolderPath = FldrComboBox.Text;

		private void FldrComboBox_TextUpdate(object sender, EventArgs e)
		{
			FldrComboBox.Text = "Input disabled! [Choose variant or create one more]";
			FldrComboBox.SelectedIndex = -1;
			CurrentFolderPath = null;
		}
	}
}
