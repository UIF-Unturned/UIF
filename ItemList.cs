using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Windows.Forms;

namespace UIF
{
	public partial class ItemList : Form
	{
		private List<Item> items;
		private Control[] paramsBoxes;

		private ResourceManager CurrentMainRM, CurrentAdditionalRM;

		public ItemList(List<Item> _items)
		{
			if (_items == null) {
				throw new ArgumentNullException("List<Item> is null");
			} else {
				InitializeComponent();

				for (int i = 0; i < _items.Count; i++)
					ResultsListBox.Items.Add(_items[i].GetKeyValue("name") + " (" + _items[i].GetKeyValue("id") + ")");

				items = _items;

				paramsBoxes = Misc.GetAllControls(ItemStatsGroupBox, c => c.GetType() == typeof(TextBox)).ToArray();
			}

			_UpdateLocalization();
		}

		public void OnLocalizationChange(ResourceManager MainRM, ResourceManager AdditionalRM)
		{
			CurrentMainRM = MainRM;
			CurrentAdditionalRM = AdditionalRM;
		}

		private void _UpdateLocalization() => Localization.UpdateLocalization(this);

		private void UpdateItemList()
		{
			ResultsListBox.Items.Clear();

			for (int i = 0; i < items.Count; i++)
				ResultsListBox.Items.Add(items[i].GetKeyValue("name") + " (" + items[i].GetKeyValue("id") + ")");
		}

		private void ClearTextBoxes() {
			foreach (Control control in paramsBoxes)
				((TextBox)control).Clear();
		}

		private void ResultsListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (ResultsListBox.SelectedIndex == -1) {
				NameTextBox.Clear();
				IdTextBox.Clear();

				ClearTextBoxes();
			} else {			
				ClearTextBoxes();

				Item currentItem = items[ResultsListBox.SelectedIndex];
				
				IdTextBox.Text = currentItem.GetKeyValue("id");
				NameTextBox.Text = currentItem.GetKeyValue("name");

				foreach (TextBox control in paramsBoxes)
					control.Text = currentItem.FormatKey(control.Name);
			}
		}

		private void IdToClipboard_Click(object sender, EventArgs e)
		{
			if (ResultsListBox.SelectedIndex != -1)
				Clipboard.SetText(
					((IdPrefixTextBox.Text != string.Empty ? IdPrefixTextBox.Text + " " : string.Empty)
					+ items[ResultsListBox.SelectedIndex].GetKeyValue("id")).Replace("\n", "\r", string.Empty)
					);
		}

		private void NameIdToClipboard_Click(object sender, EventArgs e)
		{
			if (ResultsListBox.SelectedIndex != -1)
				Clipboard.SetText(
						(
							items[ResultsListBox.SelectedIndex].GetKeyValue("name")
							+ " - "
							+ (IdPrefixTextBox.Text != string.Empty ? IdPrefixTextBox.Text + " " : string.Empty)
							+ items[ResultsListBox.SelectedIndex].GetKeyValue("id")
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
						items[i].GetKeyValue("name")
						+ " - "
						+ (IdPrefixTextBox.Text != string.Empty ? IdPrefixTextBox.Text + " " : string.Empty)
						+ items[i].GetKeyValue("id")
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
