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

		public string GetValue(string key, string standartReturn = "") 
		{
			if (this.ContainsKey(key))
				return this[key];
			else
				return standartReturn;
		}

		// Return string array with values or empty array
		public string[] GetValue(string[] keys)
		{
			string[] ret = new string[] { };
			foreach (string key in keys) {
				string a = this.GetValue(key, null);
				if (a != null)
					ret.Append(a);
			}
			return ret;
		}

		public float GetAverageDamage()
		{
			float bodyDmgMultiplier = this.GetValue("player_spine_multiplier", "1").ToFloat(),
				headDmgMultiplier = this.GetValue("player_skull_multiplier", "1").ToFloat(),
				playerDamageMultiplier = this.GetValue("player_damage", "0").ToFloat();

			float ret = (bodyDmgMultiplier * playerDamageMultiplier) + (headDmgMultiplier * playerDamageMultiplier);
			return ret != 0 ? ret / 2 : ret;
		}

		public int GetClothingCapacity() => this.GetValue("storage_y", "0").ToInt() * this.GetValue("storage_x", "0").ToInt();

		public List<string> GetCalibers()
		{
			List<string> list = new List<string>();

			string gunCaliber = this.GetValue("caliber", null);
			if (gunCaliber != null) {
				list.Add(gunCaliber);
			}

			string calibers = this.GetValue("calibers", null);
			if (calibers != null)
				for (int i = 0; i < calibers.ToInt(); i++) {
					string caliber_ = this.GetValue("caliber_" + i.ToString(), null);

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

			string value = this.GetValue(key, errReturn);
			switch (key)
			{
				case "item_capacity":
					string storagex = this.GetValue("storage_x", null), storagey = this.GetValue("storage_y", null),
						width = this.GetValue("width", null), height = this.GetValue("height", null);

					if (storagex != null && storagey != null && this.GetValue("type") == "Storage")
						return (storagex.ToInt() * storagey.ToInt()).ToString();
					else if (width != null && height != null && this.GetValue("useable") == "Clothing")
						return (width.ToInt() * height.ToInt()).ToString();

					return errReturn;
				case "armor":
					if (value != errReturn && this.GetValue("useable") == "Clothing")
						return value.ToFloat().Unturned_ToPercentage().ToString();

					return errReturn;
				//case "player_skull_multiplier":
				//case "player_spine_multiplier":
				case "player_skull_damage":
					string playerDmg_h = this.GetValue("player_damage", null),
						multiplier_h = this.GetValue("player_skull_multiplier", null);

					string skull_useable = this.GetValue("useable");

					if (playerDmg_h != null && (skull_useable == "Melee" || skull_useable == "Gun" ||
						this.GetValue("type") == "Throwable" || skull_useable == "Throwable"))
						return multiplier_h != null ? (multiplier_h.ToFloat() * playerDmg_h.ToFloat()).ToString() : "~" + playerDmg_h;

					return errReturn;
				case "player_spine_damage":
					string playerDmg_b = this.GetValue("player_damage", null),
						multiplier_b = this.GetValue("player_spine_multiplier", null);

					string spine_useable = this.GetValue("useable");

					if (playerDmg_b != null && (spine_useable == "Melee" || spine_useable == "Gun" ||
						this.GetValue("type") == "Throwable" || spine_useable == "Throwable"))
						return multiplier_b != null ? (multiplier_b.ToFloat() * playerDmg_b.ToFloat()).ToString() : "~" + playerDmg_b;

					return errReturn;
				case "player_damage":
					string dmg_useable = this.GetValue("useable");

					if (dmg_useable == "Gun" || dmg_useable == "Melee" ||
						this.GetValue("type") == "Throwable" || dmg_useable == "Throwable")
						return value;

					return errReturn;
				case "structure_damage":
					string structureDmg_useable = this.GetValue("useable"),
						structureDmg_type = this.GetValue("type");

					if (value != errReturn && (structureDmg_useable == "Gun" || structureDmg_useable == "Melee" || structureDmg_type == "Charge" ||
						structureDmg_type == "Throwable" || structureDmg_useable == "Throwable"))
						return (this.ContainsKeys("explosion", "explosive") ? "~" : string.Empty) + value;

					return errReturn;
				case "range":
					string range_useable = this.GetValue("useable");

					if (range_useable == "Melee" || range_useable == "Gun")
						return value;

					return errReturn;
				//case "useable":
				//case "type":
				case "engine":
					if (this.GetValue("useable") == "Vehicle" || this.GetValue("type") == "Vehicle")
						return value;

					return errReturn;
				case "health":
					string type = this.GetValue("type"),
						useable = this.GetValue("useable");

					// Костыль?
					if (type == "Vehicle" || useable == "Vehicle" ||
						type == "Barricade" || type == "Structure" ||
						useable == "Barricade" || useable == "Structure")
						return value;

					return errReturn;
				case "shake":
					string shake_type = this.GetValue("type");

					if (shake_type == "Grip" ||
						shake_type == "Barrel" ||
						shake_type == "Tactical")
						return value;

					return errReturn;
				case "volume":
					if (this.GetValue("type") == "Barrel")
						return value;

					return errReturn;
				case "damage":
					if (this.GetValue("type") == "Barrel")
						return value;

					return errReturn;
				case "amount":
					if (this.GetValue("type") == "Magazine" || this.GetValue("type") == "Supply")
						return value;

					return errReturn;
				case "pellets":
					if (this.GetValue("type") == "Magazine")
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
					return ((val.GetValue("type") == "Charge" || val.GetValue("useable") == "Gun") ? val.GetValue("structure_damage", "0").ToFloat() : 0)
						.CompareTo((a.GetValue("type") == "Charge" || a.GetValue("useable") == "Gun") ? a.GetValue("structure_damage", "0").ToFloat() : 0);
				case CompareModes.Damage:
					return (val.GetValue("useable") == "Gun" ? val.GetAverageDamage() : 0)
						.CompareTo(a.GetValue("useable") == "Gun" ? a.GetAverageDamage() : 0);
				case CompareModes.ClothingProtection:
					return (a.GetValue("useable") == "Clothing" ? a.GetValue("armor", "1").ToFloat() : 1)
						.CompareTo(val.GetValue("useable") == "Clothing" ? val.GetValue("armor", "1").ToFloat() : 1);
				case CompareModes.ClothingStorage:
					return (val.GetValue("useable") == "Clothing" ? (val.GetValue("height", "0").ToInt() * val.GetValue("width", "0").ToInt()) : 0)
						.CompareTo(a.GetValue("useable") == "Clothing" ? (a.GetValue("height", "0").ToInt() * a.GetValue("width", "0").ToInt()) : 0);
				case CompareModes.VehicleHealth:
					return (val.GetValue("type") == "Vehicle" ? val.GetValue("health", "0").ToFloat() : 0)
						.CompareTo(a.GetValue("type") == "Vehicle" ? a.GetValue("health", "0").ToFloat() : 0);
				case CompareModes.Shake:
					string shake_type_a = a.GetValue("type"),
						shake_type_val = val.GetValue("type");

					return (shake_type_a == "Grip" || shake_type_a == "Barrel" || shake_type_a == "Tactical" ? a.GetValue("shake", "1").ToFloat() : 1)
						.CompareTo(shake_type_val == "Grip" || shake_type_val == "Barrel" || shake_type_val == "Tactical" ? val.GetValue("shake", "1").ToFloat() : 1);
				case CompareModes.BarrelDamage:
					return (a.GetValue("type") == "Barrel" ? a.GetValue("damage", "0").ToFloat() : 0)
						.CompareTo(val.GetValue("type") == "Barrel" ? val.GetValue("damage", "0").ToFloat() : 0);
				case CompareModes.BarrelVolume:
					return (a.GetValue("type") == "Barrel" ? a.GetValue("volume", "1").ToFloat() : 1)
						.CompareTo(val.GetValue("type") == "Barrel" ? val.GetValue("volume", "1").ToFloat() : 1);
				case CompareModes.StructureCapacity:
					return (val.GetValue("type") == "Storage" ? val.GetClothingCapacity() : 0)
						.CompareTo(a.GetValue("type") == "Storage" ? a.GetClothingCapacity() : 0);
				case CompareModes.BuildingHealth:
					string buildingH_type_a = a.GetValue("type"),
						buildingH_type_val = val.GetValue("type");

					string buildingH_useable_a = a.GetValue("useable"),
						buildingH_useable_val = val.GetValue("useable");

					return (buildingH_useable_val == "Barricade" || buildingH_useable_val == "Structure"
						|| buildingH_type_val == "Structure" || buildingH_type_val == "Barricade" ? val.GetValue("health", "0") .ToFloat() : 0)

						.CompareTo(buildingH_useable_a == "Barricade" || buildingH_useable_a == "Structure"
						|| buildingH_type_a == "Structure" || buildingH_type_a == "Barricade" ? a.GetValue("health", "0").ToFloat() : 0);
				case CompareModes.AmmoAmount:
					string typea = a.GetValue("type"),
						typeval = val.GetValue("type");

					return (typeval == "Magazine" ? val.GetValue("amount", "0").ToInt() * val.GetValue("pellets", "1").ToInt() : (typeval == "Supply" ? 1 : 0))
						.CompareTo(typea == "Magazine" ? a.GetValue("amount", "0").ToInt() * a.GetValue("pellets", "1").ToInt() : (typea == "Supply" ? 1 : 0));

				default:
					throw new Exception(Localization.CurrentAdditional.GetStringSafety("InvalidCompareMode") +
						Localization.CurrentAdditional.GetStringSafety("ErrorDiscordSuffix"));
			}
		}

		public static void ItemsPreprocessor(ref List<Item> items)
		{
			for (int i = 0; i < items.Count; i++)
			{
				if (items[i].GetValue("type") == "Gun")
					for (int a = 0; a < items.Count; a++)
					{
						if (i != a)
						{
							string type = items[a].GetValue("type");
							List<string> calibersa = items[a].GetCalibers();
							string linkParam = null;
							if (calibersa.Count > 0)
							{
								if (calibersa.Contains(items[i].GetValue("caliber")))
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

		public static void ItemsFilter(Func<Item, bool> filter, ref List<Item> items)
		{
			for (int i = 0; i < items.Count; i++) {
				if (!filter(items[i])) {
					items.RemoveAt(i);
					i -= 1;  // Так как мы удаляем элемент, то следующий стает на его место, таким образом, если не сделать i -= 1,
							 // то мы оставим след. элемент в списке без проверки
				}
			}
		}

		public static List<Item> ParseAll(List<string> folders, Func<Item, bool> filter = null, bool enableProcessors = true)
		{
			if (loadedItems != null) {
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

			List<Item> ret = new List<Item>();

			foreach (string folder in folders) {
				ret.AddRange(ParseAll(folder, null, false));
			}

			if (enableProcessors)
				ItemsPreprocessor(ref ret);

			if (filter != null)
				ItemsFilter(filter, ref ret);

			if (enableProcessors)
				ItemsPostprocessor(ref ret);

			return ret;
		}

		public static List<Item> ParseAll(string folderPath, Func<Item, bool> filter = null, bool enableProcessors = true)
		{
			if (loadedItems == null)
			{
				if (!Directory.Exists(folderPath))
					throw new FileNotFoundException(Localization.CurrentAdditional.GetStringSafety("FolderDoesntExists") + "\n\n(" + folderPath + ")");

				List<Item> items = new List<Item>();

				IEnumerable<string> dirs = Directory.EnumerateDirectories(folderPath, "*", SearchOption.AllDirectories);
				foreach (string dir in dirs) {
					if (File.Exists(dir + "\\English.dat")) {
						Item item = ParseDir(dir, null);
						if (item != null && item.GetValue("id", null) != null)
							items.Add(item);
					}
				}

				if (enableProcessors)
					ItemsPreprocessor(ref items);

				if (filter != null)
					ItemsFilter(filter, ref items);

				if (enableProcessors)
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
				return null;

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
			string type = item.GetValue("type", null),
				useable = item.GetValue("useable", null);

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