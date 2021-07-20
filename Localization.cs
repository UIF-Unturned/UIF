using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;

namespace UIF
{
    public static class Localization
	{
		public static readonly string[] Locales = new string[] { "en-US", "ru-RU" };

		public static readonly ResourceManager RM_Additional = new ResourceManager(Program.ProjectNamespace + ".Properties.Additional", Program.ExeAssembly);
		private static ResourceManager RM;

		public static string GetStringSafety(this ResourceManager RM, string name)
		{
			try {
				return RM.GetString(name);
			} catch {
				return null;
			}
		}

		public static ResourceManager UpdateLocalization(string resource_name, object class_obj)
		{
			string CurrentLocale = Properties.Settings.Default.Locale;
			CultureInfo CurrentCulture = CultureInfo.GetCultureInfo(CurrentLocale);
			System.Threading.Thread.CurrentThread.CurrentUICulture =
			System.Threading.Thread.CurrentThread.CurrentCulture =
				Application.CurrentCulture = CurrentCulture;
			RM = new ResourceManager(Program.ProjectNamespace + ".Properties." + resource_name, Program.ExeAssembly);

			foreach (Control control in Misc.GetAllControls((Control)class_obj, c => c.GetType() != typeof(TextBox) && c.GetType() != typeof(ComboBox)))
			{
				control.Text = RM.GetStringSafety(control.Name);
			}

			MethodInfo method = class_obj.GetType().GetMethod("OnLocalizationChange");
			if (method != null)
				method.Invoke(class_obj, new object[] { RM });

			return RM;
		}
	}
}
