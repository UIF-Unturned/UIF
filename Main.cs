using System;
using System.Resources;
using System.Windows.Forms;

namespace UIF
{
    public partial class Main : Form
	{
		private string ModsTip;
		private ToolTip Tip = new ToolTip();
		private string FolderErrorText { 
			get {
				return Localization.CurrentAdditional.GetStringSafety("FolderErrorText");
			}
		}

		private ResourceManager CurrentMainRM, CurrentAdditionalRM;

		public Main()
		{
			InitializeComponent();

			VersionLabel.Text += Properties.Settings.Default.Version;
			this.Text += " | Ver. " + Properties.Settings.Default.Version;

			for (int i = 0; i < Localization.AllLocales.Length; i++) {
				string locale = Localization.AllLocales[i];
				LocalizationComboBox.Items.Add(locale);

				if (locale == Properties.Settings.Default.Locale)
					LocalizationComboBox.SelectedIndex = i;
			}

			Tip.SetToolTip(DiscordLink, Properties.Settings.Default.DiscordURL);
			Tip.SetToolTip(GitHubLink, Properties.Settings.Default.GitHubURL);
		}
		
		private void _UpdateLocalization() => Localization.UpdateLocalization(this);

		public void OnLocalizationChange(ResourceManager MainRM, ResourceManager AdditionalRM)
		{
			CurrentMainRM = MainRM;
			CurrentAdditionalRM = AdditionalRM;

			ModsTip = MainRM.GetStringSafety("ModsTip");

			Tip.SetToolTip(InfoBtn, ModsTip);
			Tip.SetToolTip(SelectFldrLabel, ModsTip);

			if (Core.loadedItems == null)
				LoadModsToRamBtn.Text = MainRM.GetStringSafety("LoadModsToRamBtn");
			else
				LoadModsToRamBtn.Text = MainRM.GetStringSafety("UnloadMods");
		}
		
		private void EnterNameLabel_Click(object sender, EventArgs e) => NameTextBox.Focus();
		
		private void EnterIdLabel_Click(object sender, EventArgs e) => IDBox.Focus();

		private void SearchNameBtn_Click(object sender, EventArgs e)
		{
			if (Folders.CheckedFoldersCount == 0) {
				MessageBox.Show(FolderErrorText);
			} else {
				var items = Core.ParseAll(Folders.CheckedFolders, i => i.GetValue("name").ToLower().Contains(NameTextBox.Text.ToLower()));

				new ItemList(items).ShowDialog();
			}
		}

		private void AllItemsBtn_Click(object sender, EventArgs e)
		{
			if (Folders.CheckedFoldersCount == 0)
				MessageBox.Show(FolderErrorText);
			else
				new ItemsCategories().ShowDialog();
		}

		private void SearchIDButton_Click(object sender, EventArgs e)
		{
			if (Folders.CheckedFoldersCount == 0) {
				MessageBox.Show(FolderErrorText);
			} else {
				var items = Core.ParseAll(Folders.CheckedFolders, i => i.GetValue("id") == IDBox.Text);

				new ItemList(items).ShowDialog();
			}
		}

		private void GitHubLink_Click(object sender, EventArgs e) => Misc.OpenUrl(Properties.Settings.Default.GitHubURL);

		private void DiscordLink_Click(object sender, EventArgs e) => Misc.OpenUrl(Properties.Settings.Default.DiscordURL);

		private void InfoBtn_Click(object sender, EventArgs e) => Tip.Show(ModsTip, InfoBtn);

		private void SelectFldrLabel_Click(object sender, EventArgs e) => Tip.Show(ModsTip, SelectFldrLabel);

		private void LoadModsToRamBtn_Click(object sender, EventArgs e)
		{
			if (Folders.CheckedFoldersCount == 0) {
				MessageBox.Show(FolderErrorText);
			} else {
				if (Core.loadedItems != null) {
					Core.loadedItems = null;
					GC.Collect();
					SelectedFldrsBtn.Enabled = true;
					LoadModsToRamBtn.Text = CurrentMainRM.GetStringSafety("LoadModsToRamBtn");
				} else {
					Core.loadedItems = Core.ParseAll(Folders.CheckedFolders);
					SelectedFldrsBtn.Enabled = false;
					LoadModsToRamBtn.Text = CurrentMainRM.GetStringSafety("UnloadMods");
				}
			}
		}

		private void LocalizationComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.Locale = LocalizationComboBox.Text;
			Properties.Settings.Default.Save();

			_UpdateLocalization();
		}

        private void SelectedFldrsBtn_Click(object sender, EventArgs e)
        {
			new Folders().ShowDialog();
        }

        private void LocalizationComboBox_TextUpdate(object sender, EventArgs e) => LocalizationComboBox.Text = Properties.Settings.Default.Locale;
	}
}
