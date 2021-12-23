using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Resources;
using System.Windows.Forms;

namespace UIF
{
    public partial class Folders : Form
    {
		private ToolTip Tip = new ToolTip();
		private ResourceManager CurrentMainRM, CurrentAdditionalRM;

		private void _UpdateLocalization() => Localization.UpdateLocalization(this);

		public Folders()
        {
            InitializeComponent();
        }

		public static List<string> CheckedFolders
        {
			get {
				List<string> ret = new List<string>();

				foreach (int iFolder in Properties.Settings.Default.CheckedFolders) {
					ret.Add(Properties.Settings.Default.Folders[iFolder]);
                }

				return ret;
            }
		}

		public static int CheckedFoldersCount
        {
			get { return Properties.Settings.Default.CheckedFolders.Count; }
        }

		private void UpdateFoldersProp()
        {
			Properties.Settings.Default.Folders			= FoldersListBox.Items.Cast<string>().ToList();
			Properties.Settings.Default.CheckedFolders	= FoldersListBox.CheckedIndices.Cast<int>().ToList();

			Properties.Settings.Default.Save();
		}

        private void Folders_Load(object sender, EventArgs e)
        {
			_UpdateLocalization();

			for (int i = 0; i < Properties.Settings.Default.Folders.Count; i++) {
				FoldersListBox.Items.Insert(i, Properties.Settings.Default.Folders[i]);
            }

			foreach (int checked_index in Properties.Settings.Default.CheckedFolders) {
				FoldersListBox.SetItemChecked(checked_index, true);
			}
		}

		public void OnLocalizationChange(ResourceManager MainRM, ResourceManager AdditionalRM)
		{
			CurrentMainRM = MainRM;
			CurrentAdditionalRM = AdditionalRM;

			Tip.SetToolTip(MinusFldrBtn, MainRM.GetStringSafety("MinusFldrBtnTip")); // Delete selected folder
			Tip.SetToolTip(PlusFldrBtn, MainRM.GetStringSafety("PlusFldrBtnTip")); // Add selected folder
			Tip.SetToolTip(OpenFldrBtn, MainRM.GetStringSafety("OpenFldrBtnTip")); // Open selected folder
		}

		private void PlusFldrBtn_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();

			if (fbd.ShowDialog() == DialogResult.OK) {
				if (fbd.SelectedPath != null) {
					FoldersListBox.Items.Insert(0, fbd.SelectedPath);
				}
			}
		}

		private void MinusFldrBtn_Click(object sender, EventArgs e)
		{
			if (FoldersListBox.SelectedIndex != -1) {
				FoldersListBox.Items.RemoveAt(FoldersListBox.SelectedIndex);
            } else {
				MessageBox.Show("Please, select folder");   // TRANSLATE!
			}
		}

		private void OpenFldrBtn_Click(object sender, EventArgs e)
		{
			if (FoldersListBox.SelectedIndex != -1) {
				string SelectedPath	= FoldersListBox.SelectedItem.ToString();
				int SelectedItem	= FoldersListBox.SelectedIndex;
				if (Directory.Exists(SelectedPath)) {
					Process.Start("explorer.exe", SelectedPath);
				} else {
					MessageBox.Show(CurrentMainRM.GetStringSafety("FolderDoesntExists") + "\n\n(" + SelectedPath + ")");
					FoldersListBox.Items.RemoveAt(SelectedItem);
				}
			} else {
				MessageBox.Show(CurrentAdditionalRM.GetStringSafety("FolderNotSelected"));
			}
		}

        private void Folders_FormClosing(object sender, FormClosingEventArgs e)
        {
			UpdateFoldersProp();
		}
    }
}
