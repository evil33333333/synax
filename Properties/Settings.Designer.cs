using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Synax.Properties
{
	// Token: 0x0200001C RID: 28
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00003B19 File Offset: 0x00003B19
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00003B20 File Offset: 0x00003B20
		// (set) Token: 0x060000CF RID: 207 RVA: 0x00003B32 File Offset: 0x00003B32
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Username
		{
			get
			{
				return (string)this["Username"];
			}
			set
			{
				this["Username"] = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00003B40 File Offset: 0x00003B40
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x00003B52 File Offset: 0x00003B52
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Password
		{
			get
			{
				return (string)this["Password"];
			}
			set
			{
				this["Password"] = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00003B60 File Offset: 0x00003B60
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x00003B72 File Offset: 0x00003B72
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool RememberUser
		{
			get
			{
				return (bool)this["RememberUser"];
			}
			set
			{
				this["RememberUser"] = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00003B85 File Offset: 0x00003B85
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x00003B97 File Offset: 0x00003B97
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool AutoLogin
		{
			get
			{
				return (bool)this["AutoLogin"];
			}
			set
			{
				this["AutoLogin"] = value;
			}
		}

		// Token: 0x04000085 RID: 133
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
