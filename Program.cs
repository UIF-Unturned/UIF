using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace UIF
{
	public static class Program
	{
		public readonly static Assembly ExeAssembly = Assembly.GetExecutingAssembly();
		public readonly static string ProjectNamespace = ExeAssembly.EntryPoint.DeclaringType.Namespace;

		[STAThread]
		static void Main()
		{
			if (string.IsNullOrEmpty(Properties.Settings.Default.Locale)) {
				Properties.Settings.Default.Locale = Properties.Settings.Default.DefaultUILocale;
			}

			if (Properties.Settings.Default.Folders == null) {
				Properties.Settings.Default.Folders = new List<string>();
			}

			if (Properties.Settings.Default.CheckedFolders == null) {
				Properties.Settings.Default.CheckedFolders = new List<int>();

			}

			Properties.Settings.Default.Save();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Main());
		}
	}
}
