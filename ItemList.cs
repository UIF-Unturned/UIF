using System;
using System.Collections.Generic;
using System.Resources;
using System.Windows.Forms;

namespace UIF
{
	public partial class ItemList : Form
	{
		private List<Item> items;

		public ItemList(List<Item> _items)
		{
			if (_items == null) {
				throw new ArgumentNullException("List<Item> is null");
			} else {
				InitializeComponent();

				for (int i = 0; i < _items.Count; i++)
					ResultsListBox.Items.Add(_items[i].name + " (" + _items[i].id + ")");

				items = _items;
			}

			_UpdateLocalization();
		}

		void OnLocalizationChange(ResourceManager RM)
		{

		}

		private void _UpdateLocalization() => Localization.UpdateLocalization("ItemList", this);

		private void UpdateItemList()
		{
			ResultsListBox.Items.Clear();

			for (int i = 0; i < items.Count; i++)
				ResultsListBox.Items.Add(items[i].name + " (" + items[i].id + ")");
		}

		private void ClearTextBoxes() {
			foreach (Control control in Misc.GetAllControls(ItemStatsGroupBox, c => c.GetType() == typeof(TextBox)))
				((TextBox)control).Clear();
		}

		private void ResultsListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (ResultsListBox.SelectedIndex == -1)
			{
				NameTextBox.Clear();
				IdTextBox.Clear();

				ClearTextBoxes();
			}
			else
			{
				ClearTextBoxes();

				Item currentItem = items[ResultsListBox.SelectedIndex];
				
				IdTextBox.Text = currentItem.id.ToString();
				NameTextBox.Text = ResultsListBox.SelectedItem.ToString().Replace(" (" + currentItem.id.ToString() + ")", string.Empty);

				if (currentItem.armor != null && currentItem.itemType.TryContains("Clothing"))
					ProtectionTextBox.Text = ((float)currentItem.armor).ToPercentage()
						.ToString();

				if (currentItem.clothStorageHeight != null && currentItem.clothStorageWidth != null && currentItem.itemType.TryContains("Clothing"))
					ItemCapacityTextBox.Text = (currentItem.clothStorageHeight * currentItem.clothStorageWidth)
						.ToString();
				else if (currentItem.barricadeStorageHeight != null && currentItem.barricadeStorageWidth != null && currentItem.itemType2.TryContains("Storage"))
					ItemCapacityTextBox.Text = (currentItem.barricadeStorageHeight * currentItem.barricadeStorageWidth)
						.ToString();

				if (currentItem.headDamage != null && currentItem.itemType.TryContains("Melee", "Gun"))
					DamageHeadTextBox.Text = (currentItem.headDamage != null ? string.Empty : "~") +
						((currentItem.headDamage != null ? currentItem.headDamage : 1) *
						(currentItem.playerDamage != null ? currentItem.playerDamage : 1)).ToString();

				if (currentItem.bodyDamage != null && currentItem.itemType.TryContains("Melee", "Gun"))
					BodyDamageTextBox.Text = (currentItem.bodyDamage != null ? string.Empty : "~") +
						((currentItem.bodyDamage != null ? currentItem.bodyDamage : 1) *
						(currentItem.playerDamage != null ? currentItem.playerDamage : 1)).ToString();

				if (currentItem.range != null && currentItem.itemType.TryContains("Melee", "Gun"))
					RangeTextBox.Text = currentItem.range.ToString();

				if (currentItem.playerDamage != null && currentItem.itemType.TryContains("Gun", "Melee"))
					PlayerDamageTextBox.Text = currentItem.playerDamage.ToString();

				if (currentItem.structureDamage != null && (currentItem.itemType.TryContains("Gun", "Melee") ||
					currentItem.itemType2.TryContains("Charge")))
					StructureDamageTextBox.Text = (currentItem.explosive ? "~" : string.Empty) + currentItem.structureDamage.ToString();

				if (currentItem.itemType != null)
					ItemTypeTextBox.Text = currentItem.itemType;

				if (currentItem.itemType2 != null)
					ItemType2TextBox.Text = currentItem.itemType2;

				if (currentItem.itemType2.TryContains("Vehicle") || currentItem.itemType.TryContains("Vehicle"))
				{
					EngineTextBox.Text = currentItem.engine != null ? currentItem.engine.ToString() : "Car";

					ItemHealthTextBox.Text = currentItem.vehicleHealth != null ? currentItem.vehicleHealth.ToString() : string.Empty;
				}
				else if (currentItem.itemType.TryContains("Barricade", "Structure") ||
					currentItem.itemType2.TryContains("Barricade", "Structure"))
					ItemHealthTextBox.Text = currentItem.buildingHealth != null ? currentItem.buildingHealth.ToString() : string.Empty;

				if (currentItem.itemType2.TryContains("Grip", "Barrel", "Tactical"))
					ShakeTextBox.Text = currentItem.shake != null ? currentItem.shake.ToString() : string.Empty;

				if (currentItem.itemType2.TryContains("Barrel"))
					VolumeTextBox.Text = currentItem.barrelVolume != null ? currentItem.barrelVolume.ToString() : string.Empty;

				if ( currentItem.itemType2.TryContains("Barrel"))
					BarrelDamageTextBox.Text = currentItem.barrelDamage != null ? currentItem.barrelDamage.ToString() : "1";
			}
		}

		private void IdToClipboard_Click(object sender, EventArgs e)
		{
			if (ResultsListBox.SelectedIndex != -1)
				Clipboard.SetText(
					((IdPrefixTextBox.Text != string.Empty ? IdPrefixTextBox.Text + " " : string.Empty)
					+ items[ResultsListBox.SelectedIndex].id.ToString()).Replace("\n", "\r", string.Empty)
					);
		}

		private void NameIdToClipboard_Click(object sender, EventArgs e)
		{
			if (ResultsListBox.SelectedIndex != -1)
				Clipboard.SetText(
						(
							items[ResultsListBox.SelectedIndex].name
							+ " - "
							+ (IdPrefixTextBox.Text != string.Empty ? IdPrefixTextBox.Text + " " : string.Empty)
							+ items[ResultsListBox.SelectedIndex].id.ToString()
						)
						.Replace("\n", "\r", string.Empty)
					);
		}

		private void AllNameIdToClipboard_Click(object sender, EventArgs e)
		{
			string copyStr = string.Empty;

			for (int i = 0; i < items.Count; i++)
			{
				copyStr +=
					(
						items[i].name
						+ " - "
						+ (IdPrefixTextBox.Text != string.Empty ? IdPrefixTextBox.Text + " " : string.Empty)
						+ items[i].id.ToString()
					)
					.Replace("\n", "\r", string.Empty) +
					(
						i < items.Count ? "\n" : string.Empty
					);
			}

			Clipboard.SetText(copyStr);
		}

		private void SortCapacityBtn_Click(object sender, EventArgs e)
		{
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.ClothingStorage));

			UpdateItemList();
		}

		private void SortProtectionBtn_Click(object sender, EventArgs e)
		{
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.ClothingProtection));

			UpdateItemList();
		}

		private void SortDamagePlayersBtn_Click(object sender, EventArgs e)
		{
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.Damage));

			UpdateItemList();
		}

		private void MixBtn_Click(object sender, EventArgs e)
		{
			Random random = new Random();
			items.Sort((a, b) => random.Next(int.MinValue, int.MaxValue));

			UpdateItemList();
		}

		private void SortDamageBuildingsBtn_Click(object sender, EventArgs e)
		{
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.StructureDamage));

			UpdateItemList();
		}

		private void NameLabel_Click(object sender, EventArgs e) => NameTextBox.Focus();

		private void IdLabel_Click(object sender, EventArgs e) => IdTextBox.Focus();

		private void SortVehicleHealthBtn_Click(object sender, EventArgs e)
		{
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.VehicleHealth));

			UpdateItemList();
		}

		private void SortBarricadeCapacityBtn_Click(object sender, EventArgs e)
		{
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.StructureCapacity));

			UpdateItemList();
		}

		private void SortByBuildingHealthBtn_Click(object sender, EventArgs e)
		{
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.BuildingHealth));

			UpdateItemList();
		}

		private void SortByShakeBtn_Click(object sender, EventArgs e)
		{
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.Shake));

			UpdateItemList();
		}

		private void SortByBarrelDamageBtn_Click(object sender, EventArgs e)
		{
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.BarrelDamage));

			UpdateItemList();
		}

		private void SortByVolumeBtn_Click(object sender, EventArgs e)
		{
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.BarrelVolume));

			UpdateItemList();
		}
	}
}
