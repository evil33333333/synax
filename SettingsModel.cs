using System;
using System.Collections.Generic;
using Synax.Models;

namespace Synax
{
	// Token: 0x02000018 RID: 24
	public class SettingsModel
	{
		// Token: 0x060000AE RID: 174 RVA: 0x000034E5 File Offset: 0x000034E5
		public SettingsModel()
		{
			this.UserLoggerList = new List<UserLogger>();
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000AF RID: 175 RVA: 0x000034F8 File Offset: 0x000034F8
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x00003500 File Offset: 0x00003500
		public bool AutoLogin { get; set; }

		// Token: 0x0400006E RID: 110
		public List<UserLogger> UserLoggerList;
	}
}
