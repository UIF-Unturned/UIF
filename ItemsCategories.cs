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
			if (path == null)
			{
				MessageBox.Show("folderPath is null!", "Error!");
				return;
			}

			folderPath = path;

			InitializeComponent();
		}
		
		private void AllItemsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.parseAll(folderPath, i => true);

			new itemList(items).ShowDialog();
		}

		private void AllArmorBtn_Click(object sender, EventArgs e)
		{
			var items = Core.parseAll(folderPath, i => i.itemType.TryContains("Clothing"));

			new itemList(items).ShowDialog();
		}

		private void BackpacksBtn_Click(object sender, EventArgs e)
		{
			var items = Core.parseAll(folderPath, i => i.itemType2.TryContains("Backpack"));

			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.ClothingStorage));
			new itemList(items).ShowDialog();
		}

		private void PantsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.parseAll(folderPath, i => i.itemType2.TryContains("Pants"));

			items.Sort((a, b) => b.CompareTo(a, Core.CompareModes.ClothingProtection));
			new itemList(items).ShowDialog();
		}

		private void ShirtsBtn_Click(object sender, EventArgs e)
		{

			var items = Core.parseAll(folderPath, i => i.itemType2.TryContains("Shirt"));

			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.ClothingProtection));
			new itemList(items).ShowDialog();
		}

		private void HelmetsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.parseAll(folderPath, i => i.itemType2.TryContains("Hat"));

			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.ClothingProtection));
			new itemList(items).ShowDialog();
		}

		private void VestsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.parseAll(folderPath, i => i.itemType2.TryContains("Vest"));

			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.ClothingProtection));
			new itemList(items).ShowDialog();
		}

		private void HealAndFoodBtn_Click(object sender, EventArgs e)
		{
			var items = Core.parseAll(folderPath, i => i.itemType.TryContains("Consumeable"));

			new itemList(items).ShowDialog();
		}

		private void StructuresAndBarricadesBtn_Click(object sender, EventArgs e)
		{
			var items = Core.parseAll(folderPath, i => i.itemType.TryContains("Barricade") || i.itemType2.TryContains("Barricade") ||
				i.itemType.TryContains("Structure") || i.itemType2.TryContains("Structure"));

			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.BuildingHealth));

			new itemList(items).ShowDialog();
		}

		private void HelicoptersBtn_Click(object sender, EventArgs e)
		{
			var items = Core.parseAll(folderPath, i => i.engine.TryContains("Helicopter") && i.itemType2.TryContains("Vehicle"));

			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.VehicleHealth));

			new itemList(items).ShowDialog();
		}

		private void PlanesBtn_Click(object sender, EventArgs e)
		{
			var items = Core.parseAll(folderPath, i => i.engine.TryContains("Plane") && i.itemType2.TryContains("Vehicle"));

			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.VehicleHealth));

			new itemList(items).ShowDialog();
		}

		private void AllVehiclesBtn_Click(object sender, EventArgs e)
		{
			var items = Core.parseAll(folderPath, i => i.itemType2.TryContains("Vehicle"));

			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.VehicleHealth));

			new itemList(items).ShowDialog();
		}

		private void BoatsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.parseAll(folderPath, i => i.engine.TryContains("Boat") && i.itemType2.TryContains("Vehicle"));

			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.VehicleHealth));

			new itemList(items).ShowDialog();
		}

		private void CarsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.parseAll(folderPath, i => i.itemType2.TryContains("Vehicle"));

			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.VehicleHealth));

			new itemList(items).ShowDialog();
		}

		private void AllGunsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.parseAll(folderPath, i => i.itemType.TryContains("Gun"));

			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.Damage));

			new itemList(items).ShowDialog();
		}

		private void GripsBtn_Click(object sender, EventArgs e)
		{
			var list = Core.parseAll(folderPath, i => i.itemType2.TryContains("Grip"));

			new itemList(list).ShowDialog();
		}

		private void SuppressorsBtn_Click(object sender, EventArgs e)
		{
			var list = Core.parseAll(folderPath, i => i.itemType2.TryContains("Barrel"));

			new itemList(list).ShowDialog();
		}

		private void AllCustomizeBtn_Click(object sender, EventArgs e)
		{
			var list = Core.parseAll(folderPath, i => i.itemType2 != null ? i.itemType2.Contains("Barrel") || i.itemType2.Contains("Grip") || i.itemType2.Contains("Tactical") : false);

			new itemList(list).ShowDialog();
		}

		private void AutomaticWeaponsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.parseAll(folderPath, i => i.itemType.TryContains("Gun") && i.modes.TryContains("Auto"));

			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.Damage));

			new itemList(items).ShowDialog();
		}

		private void SemiGunsBtn_Click(object sender, EventArgs e)
		{
			var list = Core.parseAll(folderPath, i => i.itemType != null
			? i.itemType.Contains("Gun") && !i.modes.Contains("Auto") && !i.modes.Contains("Burst") && i.modes.Contains("Semi")
			: false);

			list.Sort((a, b) => a.CompareTo(b, Core.CompareModes.Damage));

			new itemList(list).ShowDialog();
		}

		private void SecondaryItemsBtn_Click(object sender, EventArgs e)
		{
			var list = Core.parseAll(folderPath, i => i.slot.TryContains("Secondary"));

			list.Sort((a, b) => a.CompareTo(b, Core.CompareModes.Damage));

			new itemList(list).ShowDialog();
		}

		private void TacticalsBtn_Click(object sender, EventArgs e)
		{
			var list = Core.parseAll(folderPath, i => i.itemType2.TryContains("Tactical"));

			list.Sort((a, b) => a.CompareTo(b, Core.CompareModes.Damage));

			new itemList(list).ShowDialog();
		}

		private void SightsBtn_Click(object sender, EventArgs e)
		{
			var list = Core.parseAll(folderPath, i => i.itemType2.TryContains("Sight"));

			list.Sort((a, b) => b.bodyDamage.CompareTo(a.bodyDamage));

			new itemList(list).ShowDialog();
		}

		private void RaidItemsBtn_Click(object sender, EventArgs e)
		{
			var list = Core.parseAll(folderPath, i =>
			(i.itemType.TryContains("Gun") && i.invulnerable && i.structureDamage != null && i.structureDamage != 0) || i.itemType.TryContains("Charge"));

			list.Sort((a, b) => a.CompareTo(b, Core.CompareModes.StructureDamage));

			new itemList(list).ShowDialog();
		}
	}
}
