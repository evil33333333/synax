using System;

namespace SafeGuard
{
	// Token: 0x02000003 RID: 3
	public class VPNObject
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00002113 File Offset: 0x00002113
		// (set) Token: 0x06000019 RID: 25 RVA: 0x0000211B File Offset: 0x0000211B
		public string VPNServerName { get; set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002124 File Offset: 0x00002124
		// (set) Token: 0x0600001B RID: 27 RVA: 0x0000212C File Offset: 0x0000212C
		public string Location { get; set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00002135 File Offset: 0x00002135
		// (set) Token: 0x0600001D RID: 29 RVA: 0x0000213D File Offset: 0x0000213D
		public string Speed { get; set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002146 File Offset: 0x00002146
		// (set) Token: 0x0600001F RID: 31 RVA: 0x0000214E File Offset: 0x0000214E
		public bool Protected { get; set; }
	}
}
