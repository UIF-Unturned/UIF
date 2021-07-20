using System;
using System.Resources;
using System.Windows.Forms;

namespace UIF
{
	public partial class ItemsCategories : Form
	{
		public ItemsCategories()
		{
			InitializeComponent();

			_UpdateLocalization();
		}

		void OnLocalizationChange(ResourceManager RM)
		{

		}

		private void _UpdateLocalization() => Localization.UpdateLocalization("ItemsCategories", this);

		private void AllItemsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath);

			new ItemList(items).ShowDialog();
		}

		private void AllArmorBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i => i.itemType.TryContains("Clothing"));

			new ItemList(items).ShowDialog();
		}

		private void BackpacksBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i => i.itemType2.TryContains("Backpack"));
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.ClothingStorage));

			new ItemList(items).ShowDialog();
		}

		private void PantsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i => i.itemType2.TryContains("Pants"));
			items.Sort((a, b) => b.CompareTo(a, Core.CompareModes.ClothingProtection));

			new ItemList(items).ShowDialog();
		}

		private void ShirtsBtn_Click(object sender, EventArgs e)
		{

			var items = Core.ParseAll(Main.CurrentFolderPath, i => i.itemType2.TryContains("Shirt"));
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.ClothingProtection));

			new ItemList(items).ShowDialog();
		}

		private void HelmetsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i => i.itemType2.TryContains("Hat"));
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.ClothingProtection));
			
			new ItemList(items).ShowDialog();
		}

		private void VestsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i => i.itemType2.TryContains("Vest"));
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.ClothingProtection));

			new ItemList(items).ShowDialog();
		}

		private void HealAndFoodBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i => i.itemType.TryContains("Consumeable"));

			new ItemList(items).ShowDialog();
		}

		private void StructuresAndBarricadesBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i => i.itemType.TryContains("Barricade") || i.itemType2.TryContains("Barricade") ||
				i.itemType.TryContains("Structure") || i.itemType2.TryContains("Structure"));
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.BuildingHealth));

			new ItemList(items).ShowDialog();
		}

		private void HelicoptersBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i => i.engine.TryContains("Helicopter") && i.itemType2.TryContains("Vehicle"));
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.VehicleHealth));

			new ItemList(items).ShowDialog();
		}

		private void PlanesBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i => i.engine.TryContains("Plane") && i.itemType2.TryContains("Vehicle"));
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.VehicleHealth));

			new ItemList(items).ShowDialog();
		}

		private void AllVehiclesBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i => i.itemType2.TryContains("Vehicle"));
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.VehicleHealth));

			new ItemList(items).ShowDialog();
		}

		private void BoatsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i => i.engine.TryContains("Boat") && i.itemType2.TryContains("Vehicle"));
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.VehicleHealth));

			new ItemList(items).ShowDialog();
		}

		private void CarsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i => i.itemType2.TryContains("Vehicle"));
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.VehicleHealth));

			new ItemList(items).ShowDialog();
		}

		private void AllGunsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i => i.itemType.TryContains("Gun"));
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.Damage));

			new ItemList(items).ShowDialog();
		}

		private void GripsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i => i.itemType2.TryContains("Grip"));

			new ItemList(items).ShowDialog();
		}

		private void SuppressorsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i => i.itemType2.TryContains("Barrel"));

			new ItemList(items).ShowDialog();
		}

		private void AllCustomizeBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i => i.itemType2 != null
				&& (i.itemType2.Contains("Barrel") || i.itemType2.Contains("Grip") || i.itemType2.Contains("Tactical")));
			new ItemList(items).ShowDialog();
		}

		private void AutomaticWeaponsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i => i.itemType.TryContains("Gun") && i.modes.TryContains("Auto"));
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.Damage));

			new ItemList(items).ShowDialog();
		}

		private void SemiGunsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i => i.itemType != null
				&& i.itemType.Contains("Gun") && !i.modes.Contains("Auto") && !i.modes.Contains("Burst") && i.modes.Contains("Semi"));
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.Damage));

			new ItemList(items).ShowDialog();
		}

		private void SecondaryItemsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i => i.slot.TryContains("Secondary"));
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.Damage));

			new ItemList(items).ShowDialog();
		}

		private void TacticalsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i => i.itemType2.TryContains("Tactical"));
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.Damage));

			new ItemList(items).ShowDialog();
		}

		private void SightsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i => i.itemType2.TryContains("Sight"));
			items.Sort((a, b) => b.bodyDamage.CompareTo(a.bodyDamage));

			new ItemList(items).ShowDialog();
		}

		private void RaidItemsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i =>
			(i.itemType.TryContains("Gun") && i.invulnerable && i.structureDamage != null && i.structureDamage != 0) || i.itemType.TryContains("Charge"));
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.StructureDamage));

			new ItemList(items).ShowDialog();
		}
	}
}
