using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace UIF
{
	public class Item : Dictionary<string, string> {
		// мб сделать его public
		private Dictionary<string, List<Item>> linked = new Dictionary<string, List<Item>>();

		public void AddLink(string param, Item link_item)
		{
			if (!linked.ContainsKey(param))
				linked.Add(param, new List<Item>());

			linked[param].Add(link_item);
		}

		public List<Item> GetLinked(string param)
		{
			if (linked.ContainsKey(param))
				return linked[param].Count > 0 ? linked[param] : null;
			else
				return null;
		}

		public List<Item> GetAllLinked()
		{
			List<Item> rtn = new List<Item>();

			foreach (var item in linked)
			{
				rtn.AddRange(this.GetLinked(item.Key));
			}

			return rtn;
		}

		public string GetKeyValue(string key, string standartReturn = "") 
		{
			if (this.ContainsKey(key))
				return this[key];
			else
				return standartReturn;
		}

		// Return string array with values or empty array
		public string[] GetKeyValue(string[] keys)
		{
			string[] ret = new string[] { };
			foreach (string key in keys) {
				string a = this.GetKeyValue(key, null);
				if (a != null)
					ret.Append(a);
			}
			return ret;
		}

		public float GetAverageDamage()
		{
			float bodyDmgMultiplier = this.GetKeyValue("player_spine_multiplier", "1").ToFloat(),
				headDmgMultiplier = this.GetKeyValue("player_skull_multiplier", "1").ToFloat(),
				playerDamageMultiplier = this.GetKeyValue("player_damage", "0").ToFloat();

			float ret = (bodyDmgMultiplier * playerDamageMultiplier) + (headDmgMultiplier * playerDamageMultiplier);
			return ret != 0 ? ret / 2 : ret;
		}

		public int GetClothingCapacity() => this.GetKeyValue("storage_y", "0").ToInt() * this.GetKeyValue("storage_x", "0").ToInt();

		public List<string> GetCalibers()
		{
			List<string> list = new List<string>();

			string gunCaliber = this.GetKeyValue("caliber", null);
			if (gunCaliber != null) {
				list.Add(gunCaliber);
			}

			string calibers = this.GetKeyValue("calibers", null);
			if (calibers != null)
				for (int i = 0; i < calibers.ToInt(); i++) {
					string caliber_ = this.GetKeyValue("caliber_" + i.ToString(), null);

					if (caliber_ != null)
						list.Add(caliber_);
				}

			return list;
		}

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

			string value = this.GetKeyValue(key, errReturn);
			switch (key)
			{
				case "item_capacity":
					string storagex = this.GetKeyValue("storage_x", null), storagey = this.GetKeyValue("storage_y", null),
						width = this.GetKeyValue("width", null), height = this.GetKeyValue("height", null);

					if (storagex != null && storagey != null && this.GetKeyValue("type").TryContains("Storage"))
						return (storagex.ToInt() * storagey.ToInt()).ToString();
					else if (width != null && height != null && this.GetKeyValue("useable").TryContains("Clothing"))
						return (width.ToInt() * height.ToInt()).ToString();

					return errReturn;
				case "armor":
					if (value != errReturn && this.GetKeyValue("useable").TryContains("Clothing"))
						return value.ToFloat().ToPercentage().ToString();

					return errReturn;
				//case "player_skull_multiplier":
				//case "player_spine_multiplier":
				case "player_skull_damage":
					string playerDmg_h = this.GetKeyValue("player_damage", null),
						multiplier_h = this.GetKeyValue("player_skull_multiplier", null);
					
					if (playerDmg_h != null && this.GetKeyValue("useable").TryContains("Melee", "Gun") ||
						this.GetKeyValue("type").TryContains("Throwable") || this.GetKeyValue("useable").TryContains("Throwable"))
						return multiplier_h != null ? (multiplier_h.ToFloat() * playerDmg_h.ToFloat()).ToString() : "~" + playerDmg_h;

					return errReturn;
				case "player_spine_damage":
					string playerDmg_b = this.GetKeyValue("player_damage", null),
						multiplier_b = this.GetKeyValue("player_spine_multiplier", null);

					if (playerDmg_b != null && this.GetKeyValue("useable").TryContains("Melee", "Gun") ||
						this.GetKeyValue("type").TryContains("Throwable") || this.GetKeyValue("useable").TryContains("Throwable"))
						return multiplier_b != null ? (multiplier_b.ToFloat() * playerDmg_b.ToFloat()).ToString() : "~" + playerDmg_b;

					return errReturn;
				case "player_damage":
					if (this.GetKeyValue("useable").TryContains("Gun", "Melee") ||
						this.GetKeyValue("type").TryContains("Throwable") || this.GetKeyValue("useable").TryContains("Throwable"))
						return value;

					return errReturn;
				case "structure_damage":
					if (value != errReturn && (this.GetKeyValue("useable").TryContains("Gun", "Melee") || this.GetKeyValue("type").TryContains("Charge") ||
						this.GetKeyValue("type").TryContains("Throwable") || this.GetKeyValue("useable").TryContains("Throwable")))
						return (this.ContainsKeys("explosion", "explosive") ? "~" : string.Empty) + value;

					return errReturn;
				case "range":
					if (this.GetKeyValue("useable").TryContains("Melee", "Gun"))
						return value;

					return errReturn;
				//case "useable":
				//case "type":
				case "engine":
					if (this.GetKeyValue("useable").TryContains("Vehicle") || this.GetKeyValue("type").TryContains("Vehicle"))
						return value;

					return errReturn;
				case "health":
					string type = this.GetKeyValue("type"),
						useable = this.GetKeyValue("useable");

					// Костыль?
					if (type.TryContains("Vehicle") || useable.TryContains("Vehicle") ||
						type.TryContains("Barricade", "Structure") || useable.TryContains("Barricade", "Structure"))
						return value;

					return errReturn;
				case "shake":
					if (this.GetKeyValue("type").TryContains("Grip", "Barrel", "Tactical"))
						return value;

					return errReturn;
				case "volume":
					if (this.GetKeyValue("type").TryContains("Barrel"))
						return value;

					return errReturn;
				case "damage":
					if (this.GetKeyValue("type").TryContains("Barrel"))
						return value;

					return errReturn;
				case "amount":
					if (this.GetKeyValue("type").TryContains("Magazine"))
						return value;

					return errReturn;

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
			BarrelVolume,
			AmmoAmount
		}

		public static int CompareTo(this Item a, Item val, CompareModes mode)
		{
			switch (mode)
			{
				case CompareModes.StructureDamage:
					return ((val.GetKeyValue("type").TryContains("Charge") || val.GetKeyValue("useable").TryContains("Gun")) ? val.GetKeyValue("structure_damage", "0").ToFloat() : 0)
						.CompareTo((a.GetKeyValue("type").TryContains("Charge") || a.GetKeyValue("useable").TryContains("Gun")) ? a.GetKeyValue("structure_damage", "0").ToFloat() : 0);
				case CompareModes.Damage:
					return (val.GetKeyValue("useable").TryContains("Gun") ? val.GetAverageDamage() : 0)
						.CompareTo(a.GetKeyValue("useable").TryContains("Gun") ? a.GetAverageDamage() : 0);
				case CompareModes.ClothingProtection:
					return (a.GetKeyValue("useable").TryContains("Clothing") ? a.GetKeyValue("armor", "1").ToFloat() : 1)
						.CompareTo(val.GetKeyValue("useable").TryContains("Clothing") ? val.GetKeyValue("armor", "1").ToFloat() : 1);
				case CompareModes.ClothingStorage:
					return (val.GetKeyValue("useable").TryContains("Clothing") ? (val.GetKeyValue("height", "0").ToInt() * val.GetKeyValue("width", "0").ToInt()) : 0)
						.CompareTo(a.GetKeyValue("useable").TryContains("Clothing") ? (a.GetKeyValue("height", "0").ToInt() * a.GetKeyValue("width", "0").ToInt()) : 0);
				case CompareModes.VehicleHealth:
					return (val.GetKeyValue("type").TryContains("Vehicle") ? val.GetKeyValue("health", "0").ToFloat() : 0)
						.CompareTo(a.GetKeyValue("type").TryContains("Vehicle") ? a.GetKeyValue("health", "0").ToFloat() : 0);
				case CompareModes.Shake:
					return (a.GetKeyValue("type").TryContains("Grip", "Barrel", "Tactical") ? a.GetKeyValue("shake", "1").ToFloat() : 1)
						.CompareTo(val.GetKeyValue("type").TryContains("Grip", "Barrel", "Tactical") ? val.GetKeyValue("shake", "1").ToFloat() : 1);
				case CompareModes.BarrelDamage:
					return (val.GetKeyValue("type").TryContains("Barrel") ? val.GetKeyValue("damage", "1").ToFloat() : 1)
						.CompareTo(a.GetKeyValue("type").TryContains("Barrel") ? a.GetKeyValue("damage", "1").ToFloat() : 1);
				case CompareModes.BarrelVolume:
					return (a.GetKeyValue("type").TryContains("Barrel") ? a.GetKeyValue("volume", "1").ToFloat() : 1)
						.CompareTo(val.GetKeyValue("type").TryContains("Barrel") ? val.GetKeyValue("volume", "1").ToFloat() : 1);
				case CompareModes.StructureCapacity:
					return (val.GetKeyValue("type").TryContains("Storage") ? val.GetClothingCapacity() : 0)
						.CompareTo(a.GetKeyValue("type").TryContains("Storage") ? a.GetClothingCapacity() : 0);
				case CompareModes.BuildingHealth:
					return (val.GetKeyValue("useable").TryContains("Barricade", "Structure")
						|| val.GetKeyValue("type").TryContains("Structure", "Barricade") ? val.GetKeyValue("health", "0") .ToFloat() : 0).

						CompareTo(a.GetKeyValue("useable").TryContains("Barricade", "Structure")
						|| a.GetKeyValue("type").TryContains("Structure", "Barricade") ? a.GetKeyValue("health", "0").ToFloat() : 0);
				case CompareModes.AmmoAmount:
					return (val.GetKeyValue("type").TryContains("Magazine") ? val.GetKeyValue("amount", "0").ToInt() : 0)
						.CompareTo(a.GetKeyValue("type").TryContains("Magazine") ? a.GetKeyValue("amount", "0").ToInt() : 0);

				default:
					throw new Exception("Invalid sort mode");
			}
		}

		public static void ItemsPreprocessor(ref List<Item> items)
		{
			for (int i = 0; i < items.Count; i++)
			{
				if (items[i].GetKeyValue("type") == "Gun")
					for (int a = 0; a < items.Count; a++)
					{
						if (i != a)
						{
							string type = items[a].GetKeyValue("type");
							List<string> calibersa = items[a].GetCalibers();
							string linkParam = null;
							if (calibersa.Count > 0)
							{
								if (calibersa.Contains(items[i].GetKeyValue("caliber")))
								{
									if (type == "Magazine")
										linkParam = "ammo";
									else if (type == "Gun")
										linkParam = "guns";
								}
							}
							else
							{
								if (type == "Grip" && items[i].ContainsKey("hook_grip"))
									linkParam = "modules";
								else if (type == "Barrel" && items[i].ContainsKey("hook_barrel"))
									linkParam = "modules";
								else if (type == "Sight" && items[i].ContainsKey("hook_sight"))
									linkParam = "modules";
								else if (type == "Tactical" && items[i].ContainsKey("hook_tactical"))
									linkParam = "modules";
								else if (type == "Magazine")
									linkParam = "ammo";
							}

							if (linkParam != null)
							{
								List<Item> linkedGuns_a = items[a].GetLinked("guns");
								List<Item> linkedParam_i = items[i].GetLinked(linkParam);

								if (linkedGuns_a == null || (linkedGuns_a != null && !linkedGuns_a.Contains(items[i])))
									items[a].AddLink("guns", items[i]);
								if (linkedParam_i == null || (linkedParam_i != null && !linkedParam_i.Contains(items[a])))
									items[i].AddLink(linkParam, items[a]);
							}
						}
					}
			}
		}

		public static void ItemsPostprocessor(ref List<Item> items)
		{

		}

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
						if (item != null && item.GetKeyValue("id", null) != null)
							items.Add(item);
					}
				}

				ItemsPreprocessor(ref items);

				// filter
				if (filter != null)
					for (int i = 0; i < items.Count; i++) {
						if (!filter(items[i])) {
							items.RemoveAt(i);
							i -= 1;  // Так как мы удаляем элемент, то следующий стает на его место, таким образом, если не сделать i -= 1,
							// то мы оставим след. элемент в списке без проверки
						}
					}

				ItemsPostprocessor(ref items);

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
				List<string> fileLines;
				try { fileLines = File.ReadAllText(file).Split('\n').ToList(); } catch { return null; }
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
			string type = item.GetKeyValue("type", null),
				useable = item.GetKeyValue("useable", null);

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