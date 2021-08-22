using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace UIF
{
	public static class Program
	{
		public readonly static string Version = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;
		public const string DiscordUrl = "https://discord.gg/VhpM2ex";
		public const string GithubUrl = "https://github.com/uif-unturned/UIF";

		public readonly static Assembly ExeAssembly = Assembly.GetExecutingAssembly();
		public readonly static string ProjectNamespace = ExeAssembly.EntryPoint.DeclaringType.Namespace;

		[STAThread]
		static void Main()
		{
			if (string.IsNullOrEmpty(Properties.Settings.Default.Locale)) {
				Properties.Settings.Default.Locale = Properties.Settings.Default.DefaultUILocale;
				Properties.Settings.Default.Save();
			}

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Main());
		}
	}
}
