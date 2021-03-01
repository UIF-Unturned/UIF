using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIF
{
	public partial class VehicleCategories : Form
	{
		string folderPath;

		public VehicleCategories(string _path)
		{
			folderPath = _path;

			InitializeComponent();
		}

		private void HelicoptersBtn_Click(object sender, EventArgs e)
		{
			var items = Core.parseAll(folderPath, i =>
			{
				if (i.engine != null)
					if (i.engine.Contains("Helicopter"))
						return true;
				return false;
			});

			new itemList(items).ShowDialog();
		}

		private void PlanesBtn_Click(object sender, EventArgs e)
		{
			var items = Core.parseAll(folderPath, i =>
			{
				if (i.engine != null)
					if (i.engine.Contains("Plane"))
						return true;
				return false;
			});

			new itemList(items).ShowDialog();
		}

		private void AllVehiclesBtn_Click(object sender, EventArgs e)
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

        private void BoatsBtn_Click(object sender, EventArgs e)
        {
			var items = Core.parseAll(folderPath, i =>
			{
				if (i.engine != null)
					if (i.engine.Contains("Boat"))
						return true;
				return false;
			});

			new itemList(items).ShowDialog();
		}

        private void Cars_Click(object sender, EventArgs e)
        {
			var items = Core.parseAll(folderPath, i =>
			{
				if (i.engine == null && i.itemType2 != null)
					if (i.itemType2.Contains("Vehicle"))
						return true;
				return false;
			});

			new itemList(items).ShowDialog();
		}
    }
}
