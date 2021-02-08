using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIF
{
	public partial class GunsCategories : Form
	{
		public string folderPath;

		public GunsCategories(string path)
		{
			folderPath = path;

			InitializeComponent();
		}

		private void AllGunsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.parseAll(folderPath, i =>
			{
				if (i.itemType != null)
					if (i.itemType.Contains("Gun"))
						return true;
				return false;
			});

			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.Damage));
			new itemList(items).ShowDialog();
		}

		private void GripsBtn_Click(object sender, EventArgs e)
		{
			var list = Core.parseAll(folderPath, i => i.itemType2.Contains("Grip"));

			new itemList(list).ShowDialog();
		}

		private void SuppressorsBtn_Click(object sender, EventArgs e)
		{
			var list = Core.parseAll(folderPath, i => i.itemType2.Contains("Barrel"));

			new itemList(list).ShowDialog();
		}

		private void CustomizeBtn_Click(object sender, EventArgs e)
		{
			var list = Core.parseAll(folderPath, i => i.itemType2.Contains("Barrel") || i.itemType2.Contains("Grip") || i.itemType2.Contains("Tactical"));

			new itemList(list).ShowDialog();
		}

		private void AutomaticWeaponsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.parseAll(folderPath, i =>
			{
				if (i.itemType != null)
					if (i.itemType.Contains("Gun") && i.modes.Contains("Auto"))
						return true;
				return false;
			});

			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.Damage));
			new itemList(items).ShowDialog();
		}

		private void SemiGunsBtn_Click(object sender, EventArgs e)
		{
			var list = Core.parseAll(folderPath, i =>
			{
				if (i.itemType != null)
					if (i.itemType.Contains("Gun") && !i.modes.Contains("Auto") && !i.modes.Contains("Burst") && i.modes.Contains("Semi"))
						return true;

				return false;
			});

			list.Sort((a, b) => a.CompareTo(b, Core.CompareModes.Damage));
			new itemList(list).ShowDialog();
		}

		private void SecondaryItemsBtn_Click(object sender, EventArgs e)
		{
			var list = Core.parseAll(folderPath, i =>
			{
				if (i.slot != null)
					if (i.slot.Contains("Secondary"))
						return true;

				return false;
			});

			list.Sort((a, b) => a.CompareTo(b, Core.CompareModes.Damage));
			new itemList(list).ShowDialog();
		}

		private void TacticsBtn_Click(object sender, EventArgs e)
		{
			var list = Core.parseAll(folderPath, i =>
			{
				if (i.itemType2 != null)
					if (i.itemType2.Contains("Tactical"))
						return true;

				return false;
			});

			list.Sort((a, b) => a.CompareTo(b, Core.CompareModes.Damage));
			new itemList(list).ShowDialog();
		}

		private void SightsBtn_Click(object sender, EventArgs e)
		{
			var list = Core.parseAll(folderPath, i =>
			{
				if (i.itemType2 != null)
					if (i.itemType2.Contains("Sight"))
						return true;

				return false;
			});

			list.Sort((a, b) => b.bodyDamage.CompareTo(a.bodyDamage));
			new itemList(list).ShowDialog();
		}

		private void RaidItemsBtn_Click(object sender, EventArgs e)
		{
			var list = Core.parseAll(folderPath, i =>
			{
				if ((i.itemType.TryContains("Gun") && i.invulnerable && i.structureDamage != null && i.structureDamage != 0) || i.itemType.TryContains("Charge"))
					return true;

				return false;
			});

			list.Sort((a, b) => a.CompareTo(b, Core.CompareModes.StructureDamage));
			new itemList(list).ShowDialog();
		}
	}
}
