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
		public string folderPath = (string)Core.GetRegistryParam(Program.Version+"\\Settings\\modsPath");
		private string ModsTip = "Path to folder with mods.\nExample: " +
			@"C:\Program Files (x86)\Steam\steamapps\workshop\content\304930" +
			"\n\nBefore using it, you need to delete all the downloaded mods and log in to the server.";
		private ToolTip Tip = new ToolTip();

		public Main()
		{
			InitializeComponent();
			VersionLabel.Text += Program.Version;
			this.Text += " | Ver. " + Program.Version;
			FldrTextBox.Text = folderPath;

			Tip.SetToolTip(InfoBtn, ModsTip);
			Tip.SetToolTip(SelectFldrLabel, ModsTip);
			Tip.SetToolTip(SelectFldrBtn, ModsTip);

			Tip.SetToolTip(DiscordLink, Program.DiscordUrl);
			Tip.SetToolTip(GitHubLink, Program.GithubUrl);
		}

		private void EnterNameLabel_Click(object sender, EventArgs e) => NameTextBox.Focus();
		
		private void EnterIdLabel_Click(object sender, EventArgs e) => this.IDBox.Focus();

		private void SearchNameBtn_Click(object sender, EventArgs e)
		{
			if (folderPath == null)
				MessageBox.Show("Папка с модами не указана!");
			else
			{
				var items = Core.parseAll(folderPath, i => i.name.ToLower().Contains(NameTextBox.Text.ToLower()));
				
				new itemList(items).ShowDialog();
			}
		}

		private void AllItemsBtn_Click(object sender, EventArgs e)
		{
			if (folderPath == null)
				MessageBox.Show("Папка с модами не указана!");
			else
			{
				new ItemsCategories(folderPath).ShowDialog();
			}
		}

		private void SelectFldrBtn_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			
			if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				folderPath = fbd.SelectedPath;
				if (folderPath != null)
				{
					FldrTextBox.Text = folderPath;
					Core.SetRegistryParam(Program.Version + "\\Settings\\modsPath", folderPath);
				}
			}
		}

		private void SearchIDButton_Click(object sender, EventArgs e)
		{
			if (folderPath == null)
				MessageBox.Show("Папка с модами не указана!");
			else
			{
				var items = Core.parseAll(folderPath, i => i.id == int.Parse(IDBox.Text));

				new itemList(items).ShowDialog();
			}
		}

		private void GitHubLink_Click(object sender, EventArgs e) => Misc.OpenUrl(Program.GithubUrl);

		private void DiscordLink_Click(object sender, EventArgs e) => Misc.OpenUrl(Program.DiscordUrl);

		private void InfoBtn_Click(object sender, EventArgs e) => Tip.Show(ModsTip, InfoBtn);

		private void SelectFldrLabel_Click(object sender, EventArgs e) => Tip.Show(ModsTip, SelectFldrLabel);
	}
}
