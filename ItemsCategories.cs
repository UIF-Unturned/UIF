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
			var items = Core.ParseAll(Folders.CheckedFolders);

			new ItemList(items).ShowDialog();
		}

		private void AllArmorBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Folders.CheckedFolders, i => i.GetValue("useable") == "Clothing");

			new ItemList(items).ShowDialog();
		}

		private void BackpacksBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Folders.CheckedFolders, i => i.GetValue("type") == "Backpack");
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.ClothingStorage));

			new ItemList(items).ShowDialog();
		}

		private void PantsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Folders.CheckedFolders, i => i.GetValue("type") == "Pants");
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.ClothingProtection));

			new ItemList(items).ShowDialog();
		}

		private void ShirtsBtn_Click(object sender, EventArgs e)
		{

			var items = Core.ParseAll(Folders.CheckedFolders, i => i.GetValue("type") == "Shirt");
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.ClothingProtection));

			new ItemList(items).ShowDialog();
		}

		private void HelmetsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Folders.CheckedFolders, i => i.GetValue("type") == "Hat");
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.ClothingProtection));
			
			new ItemList(items).ShowDialog();
		}

		private void VestsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Folders.CheckedFolders, i => i.GetValue("type") == "Vest");
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.ClothingProtection));

			new ItemList(items).ShowDialog();
		}

		private void HealAndFoodBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Folders.CheckedFolders, i => i.GetValue("useable") == "Consumeable");

			new ItemList(items).ShowDialog();
		}

		private void StructuresAndBarricadesBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Folders.CheckedFolders, i => i.GetValue("useable") == "Barricade" || i.GetValue("type") == "Barricade" ||
				i.GetValue("useable") == "Structure" || i.GetValue("type") == "Structure");
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.BuildingHealth));

			new ItemList(items).ShowDialog();
		}

		private void HelicoptersBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Folders.CheckedFolders, i => i.GetValue("engine") == "Helicopter" && i.GetValue("type") == "Vehicle");
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.VehicleHealth));

			new ItemList(items).ShowDialog();
		}

		private void PlanesBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Folders.CheckedFolders, i => i.GetValue("engine") == "Plane" && i.GetValue("type") == "Vehicle");
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.VehicleHealth));

			new ItemList(items).ShowDialog();
		}

		private void AllVehiclesBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Folders.CheckedFolders, i => i.GetValue("type") == "Vehicle");
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.VehicleHealth));

			new ItemList(items).ShowDialog();
		}

		private void BoatsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Folders.CheckedFolders, i => i.GetValue("engine") == "Boat" && i.GetValue("type") == "Vehicle");
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.VehicleHealth));

			new ItemList(items).ShowDialog();
		}

		private void CarsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Folders.CheckedFolders, i => !i.ContainsKey("engine") && i.GetValue("type") == "Vehicle");
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.VehicleHealth));

			new ItemList(items).ShowDialog();
		}

		private void AllGunsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Folders.CheckedFolders, i => i.GetValue("useable") == "Gun");
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.Damage));

			new ItemList(items).ShowDialog();
		}

		private void GripsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Folders.CheckedFolders, i => i.GetValue("type") == "Grip");

			new ItemList(items).ShowDialog();
		}

		private void SuppressorsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Folders.CheckedFolders, i => i.GetValue("type") == "Barrel");

			new ItemList(items).ShowDialog();
		}

		private void AllCustomizeBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Folders.CheckedFolders, i =>
				i.GetValue("type") == "Barrel" || i.GetValue("type") == "Grip" || i.GetValue("type") == "Tactical" || i.GetValue("type") == "Sight");
			new ItemList(items).ShowDialog();
		}

		private void AutomaticWeaponsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Folders.CheckedFolders, i => i.GetValue("useable") == "Gun" && i.ContainsKey("auto"));
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.Damage));

			new ItemList(items).ShowDialog();
		}

		private void SemiGunsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Folders.CheckedFolders, i => i.GetValue("useable") == "Gun" && !i.ContainsKeys("auto", "burst") && i.ContainsKey("semi"));
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.Damage));

			new ItemList(items).ShowDialog();
		}

		private void SecondaryItemsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Folders.CheckedFolders, i => i.GetValue("slot") == "Secondary");
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.Damage));

			new ItemList(items).ShowDialog();
		}

		private void TacticalsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Folders.CheckedFolders, i => i.GetValue("type") == "Tactical");
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.Damage));

			new ItemList(items).ShowDialog();
		}

		private void SightsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Folders.CheckedFolders, i => i.GetValue("type") == "Sight");
			//items.Sort((a, b) => b.bodyDamage.CompareTo(a.bodyDamage));

			new ItemList(items).ShowDialog();
		}

		private void GrenadesBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Folders.CheckedFolders, i => i.GetValue("type") == "Throwable" || i.GetValue("useable") == "Throwable");
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.Damage));

			new ItemList(items).ShowDialog();
		}

		private void AmmoBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Folders.CheckedFolders, i => i.GetValue("type") == "Magazine");
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.AmmoAmount));

			new ItemList(items).ShowDialog();
		}

		private void SupplyBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Folders.CheckedFolders, i => i.GetValue("type") == "Supply");

			new ItemList(items).ShowDialog();
		}

		private void MeleeBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Folders.CheckedFolders, i => i.GetValue("type") == "Melee");

			new ItemList(items).ShowDialog();
		}

        private void MasksBtn_Click(object sender, EventArgs e)
        {
            var items = Core.ParseAll(Folders.CheckedFolders, i => i.GetValue("type") == "Mask");
            items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.ClothingProtection));

            new ItemList(items).ShowDialog();
        }

        private void GlassesBtn_Click(object sender, EventArgs e)
        {
            var items = Core.ParseAll(Folders.CheckedFolders, i => i.GetValue("type") == "Glasses");
            items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.ClothingProtection));

			new ItemList(items).ShowDialog();
		}

        private void ChargesBtn_Click(object sender, EventArgs e)
        {
            var items = Core.ParseAll(Folders.CheckedFolders, i => i.GetValue("type") == "Charge");
            items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.StructureDamage));

            new ItemList(items).ShowDialog();
		}

        private void DetonatorsBtn_Click(object sender, EventArgs e)
        {
            var items = Core.ParseAll(Folders.CheckedFolders, i => i.GetValue("type") == "Detonator");

            new ItemList(items).ShowDialog();
		}

        private void RaidItemsBtn_Click(object sender, EventArgs e)
		{
			var items = Core.ParseAll(Folders.CheckedFolders, i => (
				i.GetValue("useable") == "Gun" && i.ContainsKey("invulnerable") && i.GetValue("structure_damage", "0").ToFloat() != 0) ||	// Guns
				(i.GetValue("structure_damage", "0").ToFloat() != 0 && (i.GetValue("type") == "Throwable" || i.GetValue("useable") == "Throwable")) ||	// Grenades
				i.GetValue("useable") == "Charge"	// Or any useable == Charge
			);
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.StructureDamage));

			new ItemList(items).ShowDialog();
		}
	}
}
