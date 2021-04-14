using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace UIF
{
	public static class Program
	{
		public const string Version = "0.4.2";
		public const string DiscordUrl = "https://discord.gg/VhpM2ex";
		public const string GithubUrl = "https://github.com/ymo4-dev/UIF";

		[STAThread]
		static void Main()
		{
				
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Main());
		}
	}

	public class item
	{
		public int? id = null;
		public string name = null;

		public int? clothStorageWidth = null, clothStorageHeight = null;

		public int? barricadeStorageWidth = null, barricadeStorageHeight = null;

		public float? buildingHealth = null;

		public string engine = null;

		public float? vehicleHealth = null;

		public float? armor = null;

		public float? range = null;

		public float? headDamage = null, bodyDamage = null;
		public int? playerDamage = null;

		public bool explosive = false, invulnerable = false;

		public float? structureDamage = null;

		public string itemType = null, itemType2 = null;

		public List<string> modes = new List<string>();

		public string slot = null;

		public float? shake = null;
	}

	public static class Core
	{
		public enum CompareModes
		{
			Damage,
			StructureDamage,
			ClothingProtection,
			ClothingStorage,
			VehicleHealth,
			StructureStorage,
			BuildingHealth,
			Shake
		}
		public static int CompareTo(this item a, item val, CompareModes mode)
		{
			switch (mode)
			{
				case CompareModes.StructureDamage:
					return (((val.itemType2.TryContains("Charge") || val.itemType.TryContains("Gun")) && val.structureDamage != null) ? val.structureDamage : 1)
						.CompareTo(((a.itemType2.TryContains("Charge") || a.itemType.TryContains("Gun")) && a.structureDamage != null) ? a.structureDamage : 1);
				case CompareModes.Damage:
					return (val.itemType.TryContains("Gun") ? val.getAverageDamage() : 1)
						.CompareTo(a.itemType.TryContains("Gun") ? a.getAverageDamage() : 1);
				case CompareModes.ClothingProtection:
					return (a.itemType.TryContains("Clothing") ? a.armor : 1)
						.CompareTo(val.itemType.TryContains("Clothing") ? val.armor : 1);
				case CompareModes.ClothingStorage:
					return (val.itemType.TryContains("Clothing") ? (val.clothStorageHeight * val.clothStorageWidth) : 1)
						.CompareTo(a.itemType.TryContains("Clothing") ? (a.clothStorageHeight * a.clothStorageWidth) : 1);
				case CompareModes.VehicleHealth:
					return (val.itemType2.TryContains("Vehicle") ? val.vehicleHealth : 1)
						.CompareTo(a.itemType2.TryContains("Vehicle") ? a.vehicleHealth : 1);
				case CompareModes.Shake:
					return (a.itemType2.TryContains("Grip", "Barrel") ? a.shake : 1)
						.CompareTo(val.itemType2.TryContains("Grip", "Barrel") ? val.shake: 1);
				case CompareModes.StructureStorage:
					return (val.itemType2.TryContains("Storage") ? (val.barricadeStorageHeight * val.barricadeStorageWidth) : 1)
						.CompareTo(a.itemType2.TryContains("Storage") ? (a.barricadeStorageHeight * a.barricadeStorageWidth) : 1);
				case CompareModes.BuildingHealth:
					return (val.itemType.TryContains("Barricade", "Structure")
						|| val.itemType2.TryContains("Structure", "Barricade") ? val.buildingHealth : 1).

						CompareTo(a.itemType.TryContains("Barricade", "Structure")
						|| a.itemType2.TryContains("Structure", "Barricade") ? a.buildingHealth : 1);
				default:
					throw new Errors.InvalidMode();
			}
		}

		public static List<item> parseAll(string folderPath, Func<item, bool> filter)
		{
			if (!Directory.Exists(folderPath))
			{
				MessageBox.Show("Folder doesn't exist", "Error!");
				throw new Errors.FolderDoesntExist();
				return null;
			}

			List<string> dirs = Directory.EnumerateDirectories(folderPath, "*", SearchOption.AllDirectories).ToList();
			List<item> items = new List<item>();

			for (int i = 0; i < dirs.Count; i++)
			{
				string EnglishDat = dirs[i] + "\\\\English.dat";

				if (File.Exists(EnglishDat))
				{
					var files = Directory.EnumerateFiles(dirs[i], "*.dat")
						.ToList();

					var item = parseDat(files, EnglishDat, filter);
					if (item.id != null)
					{
						items.Add(item);
					}
				}
			}

			return items;
		}
		public static item parseDat(List<string> files, string EnglishDat, Func<item, bool> filter)
		{
			if (!File.Exists(EnglishDat))
			{
				MessageBox.Show("Folder doesn't exist", "Error!");
				throw new Errors.FolderDoesntExist();
				return null;
			}

			foreach (string a in files)
				if (!a.EndsWith("English.dat"))
				{
					string[] linesModDat = File.ReadAllText(a).Split('\n');
					var item = new UIF.item() { name = File.ReadAllText(EnglishDat).Split('\n')[0].Replace("Name ", "") };

					foreach (string line in linesModDat)
					{
						try
						{
							if (line.StartsWith("ID "))
								item.id = line.Replace("ID ", "").ToInt();
							else if (line.StartsWith("Width "))
								item.clothStorageWidth = line.Replace("Width ", "").ToInt();
							else if (line.StartsWith("Height "))
								item.clothStorageHeight = line.Replace("Height ", "").ToInt();
							else if (line.StartsWith("Storage_X "))
								item.barricadeStorageWidth = line.Replace("Storage_X ", "").ToInt();
							else if (line.StartsWith("Storage_Y "))
								item.barricadeStorageHeight = line.Replace("Storage_Y ", "").ToInt();
							else if (line.StartsWith("Health "))
								item.buildingHealth = line.Replace("Health ", "").Replace(".", ",").ToFloat();
							else if (line.StartsWith("Useable "))
								item.itemType = line.Replace("Useable ", "");
							else if (line.StartsWith("Engine "))
								item.engine = line.Replace("Engine ", "");
							else if (line.StartsWith("Health "))
								item.vehicleHealth = line.Replace("Health ", "").Replace(".", ",").ToFloat();
							else if (line.StartsWith("Armor "))
								item.armor = line.Replace("Armor ", "").Replace(".", ",").ToFloat();
							else if (line.StartsWith("Player_Spine_Multiplier "))
								item.bodyDamage = line.Replace("Player_Spine_Multiplier ", "").Replace(".", ",").ToFloat();
							else if (line.StartsWith("Player_Skull_Multiplier "))
								item.headDamage = line.Replace("Player_Skull_Multiplier ", "").Replace(".", ",").ToFloat();
							else if (line.StartsWith("Type "))
								item.itemType2 = line.Replace("Type ", "");
							else if (line.StartsWith("Auto"))
								item.modes.Add("Auto");
							else if (line.StartsWith("Semi"))
								item.modes.Add("Semi");
							else if (line.StartsWith("Burst"))
								item.modes.Add("Burst");
							else if (line.StartsWith("Slot "))
								item.slot = line.Replace("Slot ", "");
							else if (line.StartsWith("Player_Damage "))
								item.playerDamage = line.Replace("Player_Damage ", "").Replace(".", ",").ToInt();
							else if (line.StartsWith("Structure_Damage "))
								item.structureDamage = line.Replace("Structure_Damage ", "").Replace(".", ",").ToFloat();
							else if (line.StartsWith("Explosive") || line.StartsWith("Explosion"))
								item.explosive = true;
							else if (line.StartsWith("Range "))
								item.range = line.Replace("Range ", "").Replace(".", ",").ToFloat();
							else if (line.StartsWith("Invulnerable"))
								item.invulnerable = true;
							else if (line.StartsWith("Shake"))
								item.shake = line.Replace("Shake ", "").Replace(".", ",").ToFloat();
						} catch { }
					}

					try
					{
						if (filter(item))
							return item;
					} catch { }
				}

			return new UIF.item();
		}

		public static object GetRegistryParam(string paramPath)
		{
			RegistryKey key = null;
			object ret = null;

			try
			{
				key = Registry.CurrentUser.OpenSubKey("Software");
				if ((key = key.OpenSubKey("UIF")) == null)
				{
					return null;
				}

				if (paramPath.StartsWith("\\")) paramPath = paramPath.Remove(0, 1);
				if (paramPath.EndsWith("\\")) paramPath = paramPath.Remove(paramPath.Length - 1, 1);

				string[] splittedPath = paramPath.Split('\\');

				for (int i = 0; i < splittedPath.Length - 1; i++)
				{
					if ((key = key.OpenSubKey(splittedPath[i])) == null)
					{
						return null;
					}
				}

				ret = key.GetValue(splittedPath[splittedPath.Length-1]);
			}
			catch
			{
				MessageBox.Show("Error when getting the parameter in the registry.", "Error");
				return null;
			}

			if (key != null) {
				key.Close();
				return ret;
			} else {
				return null;
			}
		}

		public static bool SetRegistryParam(string paramPath, string paramValue)
		{
			RegistryKey key = null;

			try
			{
				key = Registry.CurrentUser.OpenSubKey("Software", true);

				key.CreateSubKey("UIF");
				key = key.OpenSubKey("UIF", true);

				if (paramPath.StartsWith("\\")) paramPath = paramPath.Remove(0, 1);
				if (paramPath.EndsWith("\\")) paramPath = paramPath.Remove(paramPath.Length - 1, 1);

				string[] splittedPath = paramPath.Split('\\');

				for (int i = 0; i < splittedPath.Length - 1; i++)
				{
					key.CreateSubKey(splittedPath[i]);
					key = key.OpenSubKey(splittedPath[i], true);
				}

				key.SetValue(splittedPath[splittedPath.Length-1], paramValue);
			}
			catch
			{
				MessageBox.Show("Error when setting the parameter in the registry.", "Error");
				return false;
			}

			if (key != null) {
				key.Close();
				return true;
			} else {
				return false;
			}
		}
	}

	public static class Misc
	{
		public static float? getAverageDamage(this UIF.item item)
		{
			return (((item.bodyDamage != 0 && item.bodyDamage != null) ? item.bodyDamage : 1) * (item.playerDamage != null ? item.playerDamage : 1)
				+ ((item.headDamage != 0 && item.headDamage != null) ? item.headDamage : 1) * (item.playerDamage != null ? item.playerDamage : 1))
				/ 2;
		}

		public static float toPercentage(this float f)
		{
			return (1 - f) * 100;
		}

		public static void OpenUrl(string url)
		{
			try
			{
				Process.Start(url);
			}
			catch
			{
				MessageBox.Show("Error");
			}
		}

		public static float ToFloat(this string str)
		{
			return float.Parse(str);
		}

		public static bool TryContains(this string var, string a)
		{
			try
			{
				if (var != null)
					return var.Contains(a);
			}
			catch { }
			return false;
		}
		public static bool TryContains(this string var, params string[] a)
		{
			foreach (string b in a)
				if (TryContains(b))
					return true;

			return false;
		}

		public static bool TryContains(this List<string> ts, object a)
		{
			try
			{
				return ts.Contains(a);
			}
			catch { }
			return false;
		}

		public static int ToInt(this string str)
		{
			return int.Parse(str);
		}

		public static int CompareTo(this int? a, object val)
		{
			if (val == null)
				val = 1;

			if (a == null)
				a = 1;

			return ((int)a).CompareTo(val);
		}

		public static int CompareTo(this float? a, object val)
		{
			if (val == null)
				val = 1f;

			if (a == null)
				a = 1f;

			return ((float)a).CompareTo(val);
		}
	}
}

namespace UIF.Errors
{
	public class InvalidMode : Exception { }
	public class YouInvalid : Exception { }
	public class CursedCreator : Exception { }
	public class FolderDoesntExist : Exception { }
}