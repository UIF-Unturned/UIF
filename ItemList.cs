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

		Item selectedItem = null;
		List<List<Item>> blueprints = new List<List<Item>>();

		public ItemList(List<Item> _items)
		{
			if (_items == null) {
				MessageBox.Show(Localization.CurrentAdditional.GetStringSafety("ItemListIsNull") +
					Localization.CurrentAdditional.GetStringSafety("ErrorDiscordSuffix"));
			} else {
				InitializeComponent();

				for (int i = 0; i < _items.Count; i++)
					ResultsListBox.Items.Add(_items[i].GetValue("name") + " (" + _items[i].GetValue("id") + ")");

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
				ResultsListBox.Items.Add(items[i].GetValue("name") + " (" + items[i].GetValue("id") + ")");
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

				selectedItem = items[ResultsListBox.SelectedIndex];
				
				IdTextBox.Text = selectedItem.GetValue("id");
				NameTextBox.Text = selectedItem.GetValue("name");

				foreach (TextBox control in paramsBoxes)
					control.Text = selectedItem.FormatKey(control.Name);

				// blueprints
				{
					blueprints_listbox.Items.Clear();
					blueprints_listbox.SelectedIndex = -1;
					blueprints.Clear();

					string _blueprints_cnt = selectedItem.GetValue("blueprints", null);
					if (_blueprints_cnt != null) {
						int blueprints_cnt = _blueprints_cnt.ToInt();
						for (int i = 0; i < blueprints_cnt; i++) {
							List<Item> __items = new List<Item>();
							string i_str = i.ToString();
							int supplies_cnt = selectedItem.GetValue("blueprint_" + i_str + "_supplies", "1").ToInt();
							for (int supply = 0; supply < supplies_cnt; supply++) {
								string supply_str = supply.ToString();

								string supply_id = selectedItem.GetValue("blueprint_" + i_str + "_supply_" + supply_str + "_id");
								string supply_cnt = selectedItem.GetValue("blueprint_" + i_str + "_supply_" + supply_str + "_amount", "1");

								List<Item> _items = Core.ParseAll(
									Folders.CheckedFolders,
									c => c.GetValue("id") == supply_id && c.GetValue("type") != "Vehicle",
									false
								);
								List<Item> items = new List<Item>();
								foreach (Item item in _items) {
									items.Add((Item)item.Clone());
								}
								
								foreach (Item item in items) {
									item["name"] += " (x" + supply_cnt + ")";
								}
								__items.AddRange(items);
							}
							blueprints.Add(__items);

							blueprints_listbox.Items.Add("Blueprint " + i_str);
						}
					}
				}
			}
		}

		private void IdToClipboard_Click(object sender, EventArgs e)
		{
			if (ResultsListBox.SelectedIndex != -1)
				Clipboard.SetText(
					((IdPrefixTextBox.Text != string.Empty ? IdPrefixTextBox.Text + " " : string.Empty)
					+ items[ResultsListBox.SelectedIndex].GetValue("id")).Trim()
				);
		}

		private void NameIdToClipboard_Click(object sender, EventArgs e)
		{
			if (ResultsListBox.SelectedIndex != -1)
				Clipboard.SetText(
					(
						items[ResultsListBox.SelectedIndex].GetValue("name")
						+ " - "
						+ (IdPrefixTextBox.Text != string.Empty ? IdPrefixTextBox.Text + " " : string.Empty)
						+ items[ResultsListBox.SelectedIndex].GetValue("id")
					)
					.Trim()
				);
		}

		private void AllNameIdToClipboard_Click(object sender, EventArgs e)
		{
			string copyStr = string.Empty;

			for (int i = 0; i < items.Count; i++)
			{
				copyStr += (
					items[i].GetValue("name")
					+ " - "
					+ (IdPrefixTextBox.Text != string.Empty ? IdPrefixTextBox.Text + " " : string.Empty)
					+ items[i].GetValue("id")
				)
				.Trim() + (i < items.Count ? "\n" : string.Empty);
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

		private void LinkedAmmoBtn_Click(object sender, EventArgs e)
		{
			if (selectedItem != null) {
				List<Item> linked = selectedItem.GetLinked("ammo");
				if (linked != null && linked.Count > 0) {
					linked.Sort((a, b) => a.CompareTo(b, Core.CompareModes.AmmoAmount));
					new ItemList(linked).Show();
				} else {
					MessageBox.Show("This item doesn't have linked");
				}
			}
		}

		private void LinkedModulesBtn_Click(object sender, EventArgs e)
		{
			if (selectedItem != null)
			{
				List<Item> linked = selectedItem.GetLinked("modules");
				if (linked != null && linked.Count > 0)
					new ItemList(linked).Show();
				else
					MessageBox.Show("This item doesn't have linked");
			}
		}

		private void LinkedGunsBtn_Click(object sender, EventArgs e)
		{
			if (selectedItem != null)
			{
				List<Item> linked = selectedItem.GetLinked("guns");
				if (linked != null && linked.Count > 0) {
					linked.Sort((a, b) => a.CompareTo(b, Core.CompareModes.Damage));
					new ItemList(linked).Show();
				} else {
					MessageBox.Show("This item doesn't have linked");
				}
			}
		}

		private void SortByAmmoAmountBtn_Click(object sender, EventArgs e)
		{
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.AmmoAmount));

			UpdateItemList();
		}

		private void SortByPelletsBtn_Click(object sender, EventArgs e)
		{
			items.Sort((a, b) => (b.GetValue("type") == "Magazine" ? b.GetValue("pellets", "1").ToInt() : 1)
			.CompareTo(a.GetValue("type") == "Magazine" ? a.GetValue("pellets", "1").ToInt() : 1));

			UpdateItemList();
		}

		private void blueprints_listbox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (blueprints_listbox.SelectedIndex == -1) return;
			
			new ItemList(blueprints[blueprints_listbox.SelectedIndex]).Show();

			blueprints_listbox.SelectedIndex = -1;
		}

		private void SortByVolumeBtn_Click(object sender, EventArgs e)
		{
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.BarrelVolume));

			UpdateItemList();
		}
	}
}
