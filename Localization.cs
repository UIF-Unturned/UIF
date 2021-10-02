using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;

namespace UIF
{
	public static class Localization
	{
		public static readonly string[] AllLocales = new string[] { Properties.Settings.Default.DefaultUILocale }
			.Concat(Properties.Settings.Default.AdditionalLocales.Cast<string>()).ToArray();

		private static string CurrentLocale;
		public static ResourceManager CurrentAdditional = new ResourceManager(Program.ProjectNamespace + ".Properties.Additional", Program.ExeAssembly);

		private static Dictionary<string, Dictionary<string, string>> DefaultLocaleValues = new Dictionary<string, Dictionary<string, string>>();

		public static string GetStringSafety(this ResourceManager RM, string name)
		{
			try {
				return RM.GetString(name);
			} catch {
				return null;
			}
		}

		public static void UpdateLocalization(object class_obj)
		{
			Control[] controls = Misc.GetAllControls((Control)class_obj, c => c.GetType() != typeof(TextBox) && c.GetType() != typeof(ComboBox)).ToArray();
			string resource_name = ((Form)class_obj).Name;

			// Save default control strings to DefaultLocaleDict if UpdateLocalization called first time from form
			if (!DefaultLocaleValues.ContainsKey(resource_name)) {
				Dictionary<string, string> currentLocaleValues = new Dictionary<string, string>();
				foreach (Control control in controls) {
					currentLocaleValues.Add(control.Name, control.Text);
				}
				DefaultLocaleValues.Add(resource_name, currentLocaleValues);
			}

			CurrentLocale = Properties.Settings.Default.Locale;
			CultureInfo CurrentCulture = CultureInfo.GetCultureInfo(CurrentLocale);
			System.Threading.Thread.CurrentThread.CurrentUICulture =
			System.Threading.Thread.CurrentThread.CurrentCulture =
				Application.CurrentCulture = CurrentCulture;

			ResourceManager RM = new ResourceManager(Program.ProjectNamespace + ".Properties." + resource_name, Program.ExeAssembly);
			CurrentAdditional = new ResourceManager(Program.ProjectNamespace + ".Properties.Additional", Program.ExeAssembly);

			if (CurrentLocale == Properties.Settings.Default.DefaultUILocale) {
				foreach (Control control in controls) {
					string RM_string = RM.GetStringSafety(control.Name);
					if (RM_string != null) {
						control.Text = RM_string;
					} else if (DefaultLocaleValues.ContainsKey(resource_name)) {
						if (DefaultLocaleValues[resource_name].ContainsKey(control.Name))
							control.Text = DefaultLocaleValues[resource_name][control.Name];
					}
				}
			} else { 
				foreach (Control control in controls) {
					control.Text = RM.GetStringSafety(control.Name);
				}
			}

			MethodInfo method = class_obj.GetType().GetMethod("OnLocalizationChange");
			if (method != null)
				method.Invoke(class_obj, new object[] { RM, CurrentAdditional });
		}
	}
}
