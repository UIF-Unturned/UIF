using System;
using System.Resources;
using System.Windows.Forms;

namespace UIF
{
	public partial class ItemsCategories : Form
	{
		private ResourceManager CurrentMainRM, CurrentAdditionalRM;

		public ItemsCategories()
		{
			InitializeComponent();

			_UpdateLocalization();
		}

		public void OnLocalizationChange(ResourceManager MainRM, ResourceManager AdditionalRM)
		{
			CurrentMainRM = MainRM;
			CurrentAdditionalRM = AdditionalRM;
		}

		private void _UpdateLocalization() => Localization.UpdateLocalization(this);

		private void AllItemsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath);

			new ItemList(items).ShowDialog();
		}

		private void AllArmorBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i => i.GetValue("useable").TryContains("Clothing"));

			new ItemList(items).ShowDialog();
		}

		private void BackpacksBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i => i.GetValue("type").TryContains("Backpack"));
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.ClothingStorage));

			new ItemList(items).ShowDialog();
		}

		private void PantsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i => i.GetValue("type").TryContains("Pants"));
			items.Sort((a, b) => b.CompareTo(a, Core.CompareModes.ClothingProtection));

			new ItemList(items).ShowDialog();
		}

		private void ShirtsBtn_Click(object sender, EventArgs e)
		{

			var items = Core.ParseAll(Main.CurrentFolderPath, i => i.GetValue("type").TryContains("Shirt"));
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.ClothingProtection));

			new ItemList(items).ShowDialog();
		}

		private void HelmetsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i => i.GetValue("type").TryContains("Hat"));
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.ClothingProtection));
			
			new ItemList(items).ShowDialog();
		}

		private void VestsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i => i.GetValue("type").TryContains("Vest"));
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.ClothingProtection));

			new ItemList(items).ShowDialog();
		}

		private void HealAndFoodBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i => i.GetValue("useable").TryContains("Consumeable"));

			new ItemList(items).ShowDialog();
		}

		private void StructuresAndBarricadesBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i => i.GetValue("useable").TryContains("Barricade") || i.GetValue("type").TryContains("Barricade") ||
				i.GetValue("useable").TryContains("Structure") || i.GetValue("type").TryContains("Structure"));
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.BuildingHealth));

			new ItemList(items).ShowDialog();
		}

		private void HelicoptersBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i => i.GetValue("engine").TryContains("Helicopter") && i.GetValue("type").TryContains("Vehicle"));
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.VehicleHealth));

			new ItemList(items).ShowDialog();
		}

		private void PlanesBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i => i.GetValue("engine").TryContains("Plane") && i.GetValue("type").TryContains("Vehicle"));
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.VehicleHealth));

			new ItemList(items).ShowDialog();
		}

		private void AllVehiclesBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i => i.GetValue("type").TryContains("Vehicle"));
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.VehicleHealth));

			new ItemList(items).ShowDialog();
		}

		private void BoatsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i => i.GetValue("engine").TryContains("Boat") && i.GetValue("type").TryContains("Vehicle"));
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.VehicleHealth));

			new ItemList(items).ShowDialog();
		}

		private void CarsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i => !i.ContainsKey("engine") && i.GetValue("type").TryContains("Vehicle"));
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.VehicleHealth));

			new ItemList(items).ShowDialog();
		}

		private void AllGunsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i => i.GetValue("useable").TryContains("Gun"));
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.Damage));

			new ItemList(items).ShowDialog();
		}

		private void GripsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i => i.GetValue("type").TryContains("Grip"));

			new ItemList(items).ShowDialog();
		}

		private void SuppressorsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i => i.GetValue("type").TryContains("Barrel"));

			new ItemList(items).ShowDialog();
		}

		private void AllCustomizeBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i =>
			i.GetValue("type").Contains("Barrel") || i.GetValue("type").Contains("Grip") || i.GetValue("type").Contains("Tactical"));
			new ItemList(items).ShowDialog();
		}

		private void AutomaticWeaponsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i => i.GetValue("useable").TryContains("Gun") && i.ContainsKey("auto"));
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.Damage));

			new ItemList(items).ShowDialog();
		}

		private void SemiGunsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i => i.GetValue("useable").Contains("Gun") && !i.ContainsKeys("auto", "burst") && i.ContainsKey("semi"));
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.Damage));

			new ItemList(items).ShowDialog();
		}

		private void SecondaryItemsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i => i.GetValue("slot").TryContains("Secondary"));
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.Damage));

			new ItemList(items).ShowDialog();
		}

		private void TacticalsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i => i.GetValue("type").TryContains("Tactical"));
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.Damage));

			new ItemList(items).ShowDialog();
		}

		private void SightsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i => i.GetValue("type").TryContains("Sight"));
			//items.Sort((a, b) => b.bodyDamage.CompareTo(a.bodyDamage));

			new ItemList(items).ShowDialog();
		}

		private void GrenadesBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i => i.GetValue("type").TryContains("Throwable") || i.GetValue("useable").TryContains("Throwable"));
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.Damage));

			new ItemList(items).ShowDialog();
		}

        private void AmmoBtn_Click(object sender, EventArgs e)
        {
			var items = Core.ParseAll(Main.CurrentFolderPath, i => i.GetValue("type").TryContains("Magazine"));
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.AmmoAmount));

			new ItemList(items).ShowDialog();
		}

        private void RaidItemsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Main.CurrentFolderPath, i => (
				i.GetValue("useable").TryContains("Gun") && i.ContainsKey("invulnerable") && i.GetValue("structure_damage", "0").ToFloat() != 0) ||	// Guns
				(i.GetValue("structure_damage", "0").ToFloat() != 0 && (i.GetValue("type").TryContains("Throwable") || i.GetValue("useable").TryContains("Throwable"))) ||	// Grenades
				i.GetValue("useable").TryContains("Charge")	// Or any useable == Charge
			);
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.StructureDamage));

			new ItemList(items).ShowDialog();
		}
	}
}
