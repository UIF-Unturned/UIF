using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace UIF
{
	public class Item : Dictionary<string, object> {
		public string GetKeyValueStr(string key, string standartReturn = "") 
		{
			return (string)GetKeyValueObj(key, standartReturn);
		}

		// Return string array with values or empty array
		public List<string> GetKeyValueStr(string[] keys)
		{
			List<string> ret = new List<string>();
			foreach (string key in keys) {
				string a = this.GetKeyValueStr(key, null);
				if (a != null)
					ret.Add(a);
			}
			return ret;
		}

		public object GetKeyValueObj(string key, object standartReturn = null)
		{
			if (this.ContainsKey(key))
				return this[key];
			else
				return standartReturn;
		}

		public float GetAverageDamage()
		{
			float bodyDmgMultiplier = this.GetKeyValueStr("player_spine_multiplier", "1").ToFloat(),
				headDmgMultiplier = this.GetKeyValueStr("player_skull_multiplier", "1").ToFloat(),
				playerDamageMultiplier = this.GetKeyValueStr("player_damage", "0").ToFloat();

			float ret = (bodyDmgMultiplier * playerDamageMultiplier) + (headDmgMultiplier * playerDamageMultiplier);
			return ret != 0 ? ret / 2 : ret;
		}

		public List<string> GetCalibers()
		{
			List<string> list = new List<string>();

			string calibers = this.GetKeyValueStr("calibers", "1");
			if (calibers != null)
				for (int i = 0; i < calibers.ToInt(); i++) {
					list.Add(this.GetKeyValueStr("caliber_" + i.ToString()));
				}

			return list;
		}

		private const string linked_prefix = "linked_";

		public Item LinkWith(Item item, string parameter)
		{
			parameter = linked_prefix + parameter;
			if (this.ContainsKey(parameter)) {
				List<Item> linked = (List<Item>)(this[parameter]);
				if (linked.Where(i => i.ContainsValue(item)).Count() == 0) {
					linked.Add(item);
					this[parameter] = linked;
				}
			} else {
				List<Item> linked = new List<Item> { item };
				if (linked.Where(i => i.ContainsValue(item)).Count() == 0) {
					this.Add(parameter, linked);
				}
			}
			return item;
		}

		public List<Item> GetLinked(string parameter)
		{
			return (List<Item>)this.GetKeyValueObj(linked_prefix + parameter);
		}

		public int GetClothingCapacity() => this.GetKeyValueStr("storage_y", "0").ToInt() * this.GetKeyValueStr("storage_x", "0").ToInt();

		public bool ContainsKeys(params string[] keys)
		{
			foreach (string key in keys)
				if (this.ContainsKey(key))
					return true;

			return false;
		}

		public string FormatKey(string key)
		{
			string errReturn = null;

			if (key == null && key == string.Empty) {
				return errReturn;
			}

			string value = this.GetKeyValueStr(key, errReturn);
			switch (key)
			{
				case "item_capacity":
					string storagex = this.GetKeyValueStr("storage_x", null), storagey = this.GetKeyValueStr("storage_y", null),
						width = this.GetKeyValueStr("width", null), height = this.GetKeyValueStr("height", null);

					if (storagex != null && storagey != null && this.GetKeyValueStr("type").TryContains("Storage"))
						return (storagex.ToInt() * storagey.ToInt()).ToString();
					else if (width != null && height != null && this.GetKeyValueStr("useable").TryContains("Clothing"))
						return (width.ToInt() * height.ToInt()).ToString();

					return errReturn;
				case "armor":
					if (value != errReturn && this.GetKeyValueStr("useable").TryContains("Clothing"))
						return value.ToFloat().ToPercentage().ToString();

					return errReturn;
				//case "player_skull_multiplier":
				//case "player_spine_multiplier":
				case "player_skull_damage":
					string playerDmg_h = this.GetKeyValueStr("player_damage", null),
						multiplier_h = this.GetKeyValueStr("player_skull_multiplier", null);
					
					if (playerDmg_h != null && this.GetKeyValueStr("useable").TryContains("Melee", "Gun") ||
						this.GetKeyValueStr("type").TryContains("Throwable") || this.GetKeyValueStr("useable").TryContains("Throwable"))
						return multiplier_h != null ? (multiplier_h.ToFloat() * playerDmg_h.ToFloat()).ToString() : "~" + playerDmg_h;

					return errReturn;
				case "player_spine_damage":
					string playerDmg_b = this.GetKeyValueStr("player_damage", null),
						multiplier_b = this.GetKeyValueStr("player_spine_multiplier", null);

					if (playerDmg_b != null && this.GetKeyValueStr("useable").TryContains("Melee", "Gun") ||
						this.GetKeyValueStr("type").TryContains("Throwable") || this.GetKeyValueStr("useable").TryContains("Throwable"))
						return multiplier_b != null ? (multiplier_b.ToFloat() * playerDmg_b.ToFloat()).ToString() : "~" + playerDmg_b;

					return errReturn;
				case "player_damage":
					if (this.GetKeyValueStr("useable").TryContains("Gun", "Melee") ||
						this.GetKeyValueStr("type").TryContains("Throwable") || this.GetKeyValueStr("useable").TryContains("Throwable"))
						return value;

					return errReturn;
				case "structure_damage":
					if (value != errReturn && (this.GetKeyValueStr("useable").TryContains("Gun", "Melee") || this.GetKeyValueStr("type").TryContains("Charge") ||
						this.GetKeyValueStr("type").TryContains("Throwable") || this.GetKeyValueStr("useable").TryContains("Throwable")))
						return (this.ContainsKeys("explosion", "explosive") ? "~" : string.Empty) + value;

					return errReturn;
				case "range":
					if (this.GetKeyValueStr("useable").TryContains("Melee", "Gun"))
						return value;

					return errReturn;
				//case "useable":
				//case "type":
				case "engine":
					if (this.GetKeyValueStr("useable").TryContains("Vehicle") || this.GetKeyValueStr("type").TryContains("Vehicle"))
						return value;

					return errReturn;
				case "health":
					string type = this.GetKeyValueStr("type"),
						useable = this.GetKeyValueStr("useable");

					// Костыль?
					if (type.TryContains("Vehicle") || useable.TryContains("Vehicle") ||
						type.TryContains("Barricade", "Structure") || useable.TryContains("Barricade", "Structure"))
						return value;

					return errReturn;
				case "shake":
					if (this.GetKeyValueStr("type").TryContains("Grip", "Barrel", "Tactical"))
						return value;

					return errReturn;
				case "volume":
					if (this.GetKeyValueStr("type").TryContains("Barrel"))
						return value;

					return errReturn;
				case "damage":
					if (this.GetKeyValueStr("type").TryContains("Barrel"))
						return value;

					return errReturn;
				case "CalibersTextBox":
					string _b = "Amount: " + this.GetKeyValueStr("amount") + "\r\n";
					_b += "Magazine: " + this.GetKeyValueStr("magazine") + "\r\n";
					foreach (string i in this.Keys)
					{
						if (i.StartsWith("caliber"))
						{
							_b += i + " " + this.GetKeyValueStr(i) + "\r\n";
						}
					}
					return _b;

				default:
					return value;
			}
		}
	}

	public static class Core
	{
		public static List<Item> loadedItems;

		public enum CompareModes
		{
			Damage,
			StructureDamage,
			ClothingProtection,
			ClothingStorage,
			VehicleHealth,
			StructureCapacity,
			BuildingHealth,
			Shake,
			BarrelDamage,
			BarrelVolume
		}

		public static int CompareTo(this Item a, Item val, CompareModes mode)
		{
			switch (mode)
			{
				case CompareModes.StructureDamage:
					return ((val.GetKeyValueStr("type").TryContains("Charge") || val.GetKeyValueStr("useable").TryContains("Gun")) ? val.GetKeyValueStr("structure_damage", "0").ToFloat() : 0)
						.CompareTo((a.GetKeyValueStr("type").TryContains("Charge") || a.GetKeyValueStr("useable").TryContains("Gun")) ? a.GetKeyValueStr("structure_damage", "0").ToFloat() : 0);
				case CompareModes.Damage:
					return (val.GetKeyValueStr("useable").TryContains("Gun") ? val.GetAverageDamage() : 0)
						.CompareTo(a.GetKeyValueStr("useable").TryContains("Gun") ? a.GetAverageDamage() : 0);
				case CompareModes.ClothingProtection:
					return (a.GetKeyValueStr("useable").TryContains("Clothing") ? a.GetKeyValueStr("armor", "1").ToFloat() : 1)
						.CompareTo(val.GetKeyValueStr("useable").TryContains("Clothing") ? val.GetKeyValueStr("armor", "1").ToFloat() : 1);
				case CompareModes.ClothingStorage:
					return (val.GetKeyValueStr("useable").TryContains("Clothing") ? (val.GetKeyValueStr("height", "0").ToInt() * val.GetKeyValueStr("width", "0").ToInt()) : 0)
						.CompareTo(a.GetKeyValueStr("useable").TryContains("Clothing") ? (a.GetKeyValueStr("height", "0").ToInt() * a.GetKeyValueStr("width", "0").ToInt()) : 0);
				case CompareModes.VehicleHealth:
					return (val.GetKeyValueStr("type").TryContains("Vehicle") ? val.GetKeyValueStr("health", "0").ToFloat() : 0)
						.CompareTo(a.GetKeyValueStr("type").TryContains("Vehicle") ? a.GetKeyValueStr("health", "0").ToFloat() : 0);
				case CompareModes.Shake:
					return (a.GetKeyValueStr("type").TryContains("Grip", "Barrel", "Tactical") ? a.GetKeyValueStr("shake", "1").ToFloat() : 1)
						.CompareTo(val.GetKeyValueStr("type").TryContains("Grip", "Barrel", "Tactical") ? val.GetKeyValueStr("shake", "1").ToFloat() : 1);
				case CompareModes.BarrelDamage:
					return (val.GetKeyValueStr("type").TryContains("Barrel") ? val.GetKeyValueStr("damage", "1").ToFloat() : 1)
						.CompareTo(a.GetKeyValueStr("type").TryContains("Barrel") ? a.GetKeyValueStr("damage", "1").ToFloat() : 1);
				case CompareModes.BarrelVolume:
					return (a.GetKeyValueStr("type").TryContains("Barrel") ? a.GetKeyValueStr("volume", "1").ToFloat() : 1)
						.CompareTo(val.GetKeyValueStr("type").TryContains("Barrel") ? val.GetKeyValueStr("volume", "1").ToFloat() : 1);
				case CompareModes.StructureCapacity:
					return (val.GetKeyValueStr("type").TryContains("Storage") ? val.GetClothingCapacity() : 0)
						.CompareTo(a.GetKeyValueStr("type").TryContains("Storage") ? a.GetClothingCapacity() : 0);
				case CompareModes.BuildingHealth:
					return (val.GetKeyValueStr("useable").TryContains("Barricade", "Structure")
						|| val.GetKeyValueStr("type").TryContains("Structure", "Barricade") ? val.GetKeyValueStr("health", "0") .ToFloat() : 0).

						CompareTo(a.GetKeyValueStr("useable").TryContains("Barricade", "Structure")
						|| a.GetKeyValueStr("type").TryContains("Structure", "Barricade") ? a.GetKeyValueStr("health", "0").ToFloat() : 0);
				default:
					throw new Exception("Invalid sort mode");
			}
		}

		public static void ItemsPostprocessor(ref List<Item> _items, Func<Item, bool> filter)
		{
			//foreach (Item i in items) {
			//             List<string> calibers = i.GetCalibers();
			//	foreach (string caliber in calibers) {
			//		foreach (Item _i in items.Where(item => {
			//                     List<string> __calibers = item.GetCalibers();
			//			foreach (string __caliber in __calibers) {
			//				if (__caliber == caliber) {
			//					return true;
			//				}
			//			}
			//			return false;
			//		})) {
			//                     Item _a = _i.LinkWith(i, "caliber");
			//			items.RemoveAll(_g => _g.Equals(_i));
			//			items.Add(_a);
			//		}
			//	}
			//}


			List<Item> items = new List<Item>(_items);

			for (int i = 0; i < items.Count; i++)
			{
				if (items[i].GetKeyValueStr("type") == "Gun")
					for (int a = 0; a < items.Count; a++)
					{
						if (items[a].GetKeyValueStr("type") == "Magazine")
						{
							var calibersa = items[a].GetCalibers();
							if (calibersa.Count > 0)
								if (!items[a].Equals(items[i]) && calibersa.Contains(items[i].GetKeyValueStr("caliber")))
								{
									items[a] = items[i].LinkWith(items[a], "caliber");
									items[i] = items[a].LinkWith(items[i], "caliber");
								}
						}
					}
			}

			List<Item> filtered = new List<Item>();

			foreach (Item i in items)
            {
				if (filter == null || filter(i))
					filtered.Add(i);
            }

			_items = filtered;




			return;
			List<Item> gitems = new List<Item>(_items);

			foreach (Item i in gitems)
			{
				foreach (string caliber in i.GetCalibers())
				{
					//foreach (Item item in items.Where(__item => !__item.Equals(i) && __item.GetCalibers().Contains(caliber)))
					//{
					//    Item linkedItem = item.LinkWith(item, "caliber");
					//    items.Remove(item);
					//    items.Add(linkedItem);
					//}

					gitems.Where((__item, pos) =>
					{
						if (!__item.Equals(i) && __item.GetCalibers().Contains(caliber))
						{
							Item linkedItem = __item.LinkWith(i, "caliber");
							items[pos] = linkedItem;
						}

						return false;
					});
				}
			}

			_items = gitems;
		}


		//public static void ItemsPostprocessor(ref List<Item> items)
		//{
		//	List<Item> _items = new List<Item>(items);

		//	foreach (Item i in items)
		//	{
		//		List<string> calibers = i.GetCalibers();
		//		foreach (string caliber in calibers)
		//		{

		//			foreach (Item _i in items.Where(item => i.Equals(item) && item.GetKeyValueStr("caliber_" + caliber) == caliber))
		//			{
		//				Item _a = _i.LinkWith(i, "caliber");
		//				_items.RemoveAll(_g => _g.Equals(_i));
		//				_items.Add(_a);
		//			}
		//		}
		//	}

		//	items = _items;
		//}


		public static List<Item> ParseAll(string folderPath, Func<Item, bool> filter = null)
		{
			if (loadedItems == null)
			{
				if (!Directory.Exists(folderPath))
					throw new FileNotFoundException("Folder doesn't exist");

				List<Item> items = new List<Item>();

				IEnumerable<string> dirs = Directory.EnumerateDirectories(folderPath, "*", SearchOption.AllDirectories);
				foreach (string dir in dirs) {
					if (File.Exists(dir + "\\English.dat")) {
						Item item = ParseDir(dir, null);
						if (item != null && item.GetKeyValueStr("id", null) != null)
							items.Add(item);
					}
				}

				ItemsPostprocessor(ref items, filter);

				return items;
			} else {
				if (filter != null) {
					List<Item> items = new List<Item>();
					foreach (Item item in loadedItems) {
						if (filter(item))
							items.Add(item);
					}

					return items;
				} else {
					return loadedItems;
				}
			}
		}

		// Don't forget that this method doesn't call `ItemsPreprocessor` and `ItemsPostprocessor` methods
		public static Item ParseDir(string dir, Func<Item, bool> filter)
		{
			if (!File.Exists(dir + "\\English.dat"))
				throw new FileNotFoundException("File doesn't exist");

			Item item = new Item();

			List<string> files = Directory.EnumerateFiles(dir, "*.dat").ToList();
			foreach (string file in files) {
				List<string> fileLines = File.ReadAllText(file).Split('\n').ToList();
				bool bEnglishDat = file.ToLower().EndsWith("english.dat");
				foreach (string line in fileLines) {
					if (!string.IsNullOrWhiteSpace(line)) {
						int spaceIndex = line.IndexOf(' ');
						string lineToken, lineValue;
						if (spaceIndex != -1) {
							lineToken = line.Substring(0, spaceIndex);
							lineValue = line.Substring(spaceIndex + 1);
						} else {
							lineToken = line;
							lineValue = line;
						}

						lineToken = lineToken.Trim().ToLower();
						lineValue = lineValue.Trim();

						if (!item.ContainsKey(lineToken))
							item.Add(lineToken, lineValue);
					}
				}
			}

			// UseableIgnore, TypeIgnore
			string type = item.GetKeyValueStr("type", null),
				useable = item.GetKeyValueStr("useable", null);

			if (useable != null && Properties.Settings.Default.UseableIgnore != null)
				if (Properties.Settings.Default.UseableIgnore.Contains(useable))
					return null;
			if (type != null && Properties.Settings.Default.TypeIgnore != null)
				if (Properties.Settings.Default.TypeIgnore.Contains(type))
					return null;

			// filter
			if (filter == null || filter(item))
				return item;
			else
				return null;
		}
	}
}