using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIF
{
	public partial class itemList : Form
	{
		List<item> items;

		public itemList(List<item> _items)
		{
			if (_items == null)
			{
				MessageBox.Show("Error in Item List.", "Error!");
				return;
			}

			InitializeComponent();

			for (int i = 0; i < _items.Count; i++)
				ResultsListBox.Items.Add(_items[i].name + " (" + _items[i].id + ")");

			items = _items;
		}

		private void updateItemList()
		{
			ResultsListBox.Items.Clear();

			for (int i = 0; i < items.Count; i++)
				ResultsListBox.Items.Add(items[i].name + " (" + items[i].id + ")");
		}
		private void clearTextBoxes()
		{
			ClothingCapacityTextBox.Clear();
			DamageHeadTextBox.Clear();
			BodyDamageTextBox.Clear();
			ProtectionTextBox.Clear();
			ItemTypeTextBox.Clear();
			ItemType2TextBox.Clear();
			RangeTextBox.Clear();
			StructureDamageTextBox.Clear();
			PlayerDamageTextBox.Clear();
			EngineTextBox.Clear();
			VehicleHealthTextBox.Clear();
			BarricadeCapacityTextBox.Clear();
			BuildingHealthTextBox.Clear();
		}

		private void ResultsListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (ResultsListBox.SelectedIndex == -1)
			{
				NameTextBox.Clear();
				IdTextBox.Clear();

				clearTextBoxes();
			}
			else
			{
				clearTextBoxes();

				var currentItem = items[ResultsListBox.SelectedIndex];
				
				IdTextBox.Text = currentItem.id.ToString();
				NameTextBox.Text = ResultsListBox.SelectedItem.ToString().Replace(" (" + currentItem.id.ToString() + ")", "");

				if (currentItem.armor != null && currentItem.itemType.TryContains("Clothing"))
					ProtectionTextBox.Text = ((float)currentItem.armor).toPercentage()
						.ToString();

				if (currentItem.clothStorageHeight != null && currentItem.clothStorageWidth != null)
					ClothingCapacityTextBox.Text = (currentItem.clothStorageHeight * currentItem.clothStorageWidth)
						.ToString();

				if (currentItem.headDamage != null && (currentItem.itemType.TryContains("Melee") || currentItem.itemType.TryContains("Gun")))
					DamageHeadTextBox.Text = (currentItem.headDamage != null ? "" : "~") +
						((currentItem.headDamage != null ? currentItem.headDamage : 1) *
						(currentItem.playerDamage != null ? currentItem.playerDamage : 1)).ToString();

				if (currentItem.bodyDamage != null && (currentItem.itemType.TryContains("Melee") || currentItem.itemType.TryContains("Gun")))
					BodyDamageTextBox.Text = (currentItem.bodyDamage != null ? "" : "~") +
						((currentItem.bodyDamage != null ? currentItem.bodyDamage : 1) *
						(currentItem.playerDamage != null ? currentItem.playerDamage : 1)).ToString();

				if (currentItem.range != null && (currentItem.itemType.TryContains("Melee") || currentItem.itemType.TryContains("Gun")))
					RangeTextBox.Text = currentItem.range.ToString();

				if (currentItem.playerDamage != null && (currentItem.itemType.TryContains("Gun") || currentItem.itemType.TryContains("Melee")))
					PlayerDamageTextBox.Text = currentItem.playerDamage.ToString();

				if (currentItem.structureDamage != null && (currentItem.itemType.TryContains("Gun") ||
					currentItem.itemType2.TryContains("Charge") || currentItem.itemType.TryContains("Melee")))
					StructureDamageTextBox.Text = (currentItem.explosive ? "~" : "") + currentItem.structureDamage.ToString();

				if (currentItem.itemType != null)
					ItemTypeTextBox.Text = currentItem.itemType;

				if (currentItem.itemType2 != null)
					ItemType2TextBox.Text = currentItem.itemType2;

				if (currentItem.itemType2.TryContains("Vehicle"))
					EngineTextBox.Text = currentItem.engine != null ? currentItem.engine.ToString() : "Car";

				if (currentItem.itemType2.TryContains("Vehicle"))
					VehicleHealthTextBox.Text = currentItem.vehicleHealth != null ? currentItem.vehicleHealth.ToString() : "";

				if (currentItem.itemType.TryContains("Barricade") || currentItem.itemType.TryContains("Structure"))
					BuildingHealthTextBox.Text = currentItem.buildingHealth != null ? currentItem.buildingHealth.ToString() : "";

				if (currentItem.itemType2.TryContains("Storage"))
					BarricadeCapacityTextBox.Text =
						currentItem.barricadeStorageHeight != null && currentItem.barricadeStorageWidth != null ?
						(currentItem.barricadeStorageHeight * currentItem.barricadeStorageWidth).ToString() : "";
			}
		}

		private void IdToClipboard_Click(object sender, EventArgs e)
		{
			if (ResultsListBox.SelectedIndex != -1)
				Clipboard.SetText(items[ResultsListBox.SelectedIndex].id.ToString());
		}

		private void SortCapacityBtn_Click(object sender, EventArgs e)
		{
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.ClothingStorage));

			updateItemList();
		}

		private void SortProtectionBtn_Click(object sender, EventArgs e)
		{
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.ClothingProtection));

			updateItemList();
		}

		private void SortDamagePlayersBtn_Click(object sender, EventArgs e)
		{
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.Damage));

			updateItemList();
		}

		private void MixBtn_Click(object sender, EventArgs e)
		{
			Random random = new Random();
			items.Sort((a, b) => random.Next(int.MinValue, int.MaxValue));

			updateItemList();
		}

		private void SortDamageBuildingsBtn_Click(object sender, EventArgs e)
		{
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.StructureDamage));

			updateItemList();
		}

		private void NameLabel_Click(object sender, EventArgs e) => NameTextBox.Focus();

		private void IdLabel_Click(object sender, EventArgs e) => IdTextBox.Focus();

		private void SortVehicleHealthBtn_Click(object sender, EventArgs e)
		{
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.VehicleHealth));

			updateItemList();
		}

		private void SortBarricadeCapacityBtn_Click(object sender, EventArgs e)
		{
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.StructureStorage));

			updateItemList();
		}

		private void SortByBuildingHealthBtn_Click(object sender, EventArgs e)
		{
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.BuildingHealth));

			updateItemList();
		}
	}
}
