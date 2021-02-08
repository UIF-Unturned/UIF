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
	public partial class ItemsCategories : Form
	{
		string folderPath = null;

		public ItemsCategories(string path)
		{
			folderPath = path;

			InitializeComponent();
		}
		
		private void AllItemsBtn_Click(object sender, EventArgs e)
		{
			if (folderPath == null)
				MessageBox.Show("Папка с модами не указана!");
			else
			{
				var items = Core.parseAll(folderPath, i => true);

				new itemList(items).ShowDialog();
			}
		}

		private void AllArmorBtn_Click(object sender, EventArgs e)
		{
			var items = Core.parseAll(folderPath, i =>
			{
				if (i.itemType != null)
					if (i.itemType.Contains("Clothing"))
						return true;
				return false;
			});

			new itemList(items).ShowDialog();
		}

		private void BackpacksBtn_Click(object sender, EventArgs e)
		{
			var items = Core.parseAll(folderPath, i =>
			{
				if (i.itemType2 != null)
					if (i.itemType2.Contains("Backpack"))
						return true;
				return false;
			});

			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.ArmorStorage));
			new itemList(items).ShowDialog();
		}

		private void PantsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.parseAll(folderPath, i =>
			{
				if (i.itemType2 != null)
					if (i.itemType2.Contains("Pants"))
						return true;
				return false;
			});

			items.Sort((a, b) => b.CompareTo(a, Core.CompareModes.ArmorProtection));
			new itemList(items).ShowDialog();
		}

		private void ShirtsBtn_Click(object sender, EventArgs e)
		{

			var items = Core.parseAll(folderPath, i =>
			{
				if (i.itemType2 != null)
					if (i.itemType2.Contains("Shirt"))
						return true;
				return false;
			});

			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.ArmorProtection));
			new itemList(items).ShowDialog();
		}

		private void HelmetsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.parseAll(folderPath, i =>
			{
				if (i.itemType2 != null)
					if (i.itemType2.Contains("Hat"))
						return true;
				return false;
			});

			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.ArmorProtection));
			new itemList(items).ShowDialog();
		}

		private void VestsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.parseAll(folderPath, i =>
			{
				if (i.itemType2 != null)
					if (i.itemType2.Contains("Vest"))
						return true;
				return false;
			});

			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.ArmorProtection));
			new itemList(items).ShowDialog();
		}

		private void GunsAndAmmoBtn_Click(object sender, EventArgs e)
		{
			new GunsCategories(folderPath).ShowDialog();
		}

		private void HealAndFoodBtn_Click(object sender, EventArgs e)
		{
			var items = Core.parseAll(folderPath, i =>
			{
				if (i.itemType != null)
					if (i.itemType.Contains("Consumeable"))
						return true;
				return false;
			});

			new itemList(items).ShowDialog();
		}

		private void StructuresAndBarricadesBtn_Click(object sender, EventArgs e)
		{
			var items = Core.parseAll(folderPath, i =>
			{
				if (i.itemType != null)
				{
					if (i.itemType.Contains("Barricade"))
						return true;
				}
				else if (i.itemType2 != null)
				{
					if (i.itemType2.Contains("Barricade"))
						return true;
				}

				return false;
			});

			new itemList(items).ShowDialog();
		}

		private void VehiclesBtn_Click(object sender, EventArgs e)
		{
			var items = Core.parseAll(folderPath, i =>
			{
				if (i.itemType2 != null)
					if (i.itemType2.Contains("Vehicle"))
						return true;
				return false;
			});

			new itemList(items).ShowDialog();
		}
	}
}
