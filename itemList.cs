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

		private float floatToPercentage(float f)
		{
			return (1 - f) * 100;
		}

		private void ResultsListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (ResultsListBox.SelectedIndex == -1)
			{
				NameTextBox.Clear();
				IdTextBox.Clear();

				CapacityTextBox.Clear();
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
			}
			else
			{
				var currentItem = items[ResultsListBox.SelectedIndex];
				
				IdTextBox.Text = currentItem.id.ToString();
				NameTextBox.Text = ResultsListBox.SelectedItem.ToString().Replace(" (" + currentItem.id.ToString() + ")", "");

				CapacityTextBox.Clear();
				DamageHeadTextBox.Clear();
				BodyDamageTextBox.Clear();
				ProtectionTextBox.Clear();
				ItemTypeTextBox.Clear();
				ItemType2TextBox.Clear();
				RangeTextBox.Clear();
				StructureDamageTextBox.Clear();
				PlayerDamageTextBox.Clear();

				if (currentItem.armor != null && currentItem.itemType.TryContains("Clothing"))
					ProtectionTextBox.Text = floatToPercentage((float)currentItem.armor)
						.ToString();

				if (currentItem.height != null && currentItem.width != null)
					CapacityTextBox.Text = (currentItem.height * currentItem.width)
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

				if (currentItem.itemType2 != null)
					if (currentItem.itemType2.Contains("Vehicle"))
						EngineTextBox.Text = currentItem.engine.ToString();

				if (currentItem.itemType2 != null)
					if (currentItem.itemType2.Contains("Vehicle"))
						VehicleHealthTextBox.Text = currentItem.vehicleHealth.ToString();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (ResultsListBox.SelectedIndex != -1)
				Clipboard.SetText(items[ResultsListBox.SelectedIndex].id.ToString());
		}

		private void SortCapacityBtn_Click(object sender, EventArgs e)
		{
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.ArmorStorage));

			ResultsListBox.Items.Clear();

			for (int i = 0; i < items.Count; i++)
				ResultsListBox.Items.Add(items[i].name + " (" + items[i].id + ")");
		}

		private void SortProtectionBtn_Click(object sender, EventArgs e)
		{
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.ArmorProtection));

			ResultsListBox.Items.Clear();

			for (int i = 0; i < items.Count; i++)
				ResultsListBox.Items.Add(items[i].name + " (" + items[i].id + ")");
		}

		private void SortDamagePlayersBtn_Click(object sender, EventArgs e)
		{
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.Damage));

			ResultsListBox.Items.Clear();

			for (int i = 0; i < items.Count; i++)
				ResultsListBox.Items.Add(items[i].name + " (" + items[i].id + ")");
		}

		private void MixBtn_Click(object sender, EventArgs e)
		{
			//this.Controls.OfType<Button>();
			Random random = new Random();
			items.Sort((a, b) => random.Next(int.MinValue, int.MaxValue));

			ResultsListBox.Items.Clear();

			for (int i = 0; i < items.Count; i++)
				ResultsListBox.Items.Add(items[i].name + " (" + items[i].id + ")");
		}

		private void SortDamageBuildingsBtn_Click(object sender, EventArgs e)
		{
			items.Sort((a, b) => a.CompareTo(b, Core.CompareModes.StructureDamage));

			ResultsListBox.Items.Clear();

			for (int i = 0; i < items.Count; i++)
				ResultsListBox.Items.Add(items[i].name + " (" + items[i].id + ")");
		}

		private void NameLabel_Click(object sender, EventArgs e) => NameTextBox.Focus();

		private void IdLabel_Click(object sender, EventArgs e) => IdTextBox.Focus();
	}
}
