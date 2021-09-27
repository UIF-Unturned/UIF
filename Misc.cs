using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace UIF
{
	public static class Misc
	{
		public static IEnumerable<Control> GetAllControls(Control control, Func<Control, bool> filter = null)
		{
			IEnumerable<Control> controls = control.Controls.Cast<Control>();

			IEnumerable<Control> a = controls.SelectMany(ctrl => GetAllControls(ctrl, filter)).Concat(controls);

			if (filter == null)
				return a;
			else
				return a.Where(filter);
		}

		public static string Replace(this string replace_str, params string[] parameters)
		{
			string new_str = replace_str;

			for (int i = 0; i < parameters.Length - 1; i++)
				new_str = replace_str.Replace(parameters[i], parameters.Last());

			return new_str;
		}

		public static float Unturned_ToPercentage(this float f)
		{
			return (1 - f) * 100;
		}

		public static void OpenUrl(string url)
		{
			if (Process.Start(url) == null)
				throw new Exception("Url open failed");
		}

		public static int ToInt(this string str)
		{
			return int.Parse(str);
		}

		public static float ToFloat(this string str)
		{
			return float.Parse(str);
		}
	}
}
