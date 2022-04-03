using System;
using System.IO;
using Newtonsoft.Json;

namespace Synax
{
	// Token: 0x02000017 RID: 23
	public static class SettingsManager
	{
		// Token: 0x060000AB RID: 171 RVA: 0x00003410 File Offset: 0x00003410
		public static void Save(this SettingsModel model)
		{
			if (!Directory.Exists(SettingsManager.datapath))
			{
				Directory.CreateDirectory(SettingsManager.datapath);
			}
			SettingsManager.settings = model;
			string contents = JsonConvert.SerializeObject(model, Formatting.Indented);
			File.WriteAllText(SettingsManager.jsonpath, contents);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00003450 File Offset: 0x00003450
		public static SettingsModel Load()
		{
			if (SettingsManager.settings != null)
			{
				return SettingsManager.settings;
			}
			if (!Directory.Exists(SettingsManager.datapath))
			{
				Directory.CreateDirectory(SettingsManager.datapath);
			}
			if (!File.Exists(SettingsManager.jsonpath))
			{
				new SettingsModel().Save();
			}
			return SettingsManager.settings = JsonConvert.DeserializeObject<SettingsModel>(File.ReadAllText(SettingsManager.jsonpath));
		}

		// Token: 0x0400006B RID: 107
		private static string datapath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Synax");

		// Token: 0x0400006C RID: 108
		private static string jsonpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Synax", "settings.json");

		// Token: 0x0400006D RID: 109
		private static SettingsModel settings = null;
	}
}
