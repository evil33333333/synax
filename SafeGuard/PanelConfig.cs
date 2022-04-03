using System;
using System.Collections.Generic;

namespace SafeGuard
{
	// Token: 0x02000002 RID: 2
	public class PanelConfig
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00002050
		// (set) Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00002058
		public string TOS { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002061 File Offset: 0x00002061
		// (set) Token: 0x06000004 RID: 4 RVA: 0x00002069 File Offset: 0x00002069
		public string SafeGuardSite { get; set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002072 File Offset: 0x00002072
		// (set) Token: 0x06000006 RID: 6 RVA: 0x0000207A File Offset: 0x0000207A
		public string SafeGuardDiscord { get; set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002083 File Offset: 0x00002083
		// (set) Token: 0x06000008 RID: 8 RVA: 0x0000208B File Offset: 0x0000208B
		public string Website { get; set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002094 File Offset: 0x00002094
		// (set) Token: 0x0600000A RID: 10 RVA: 0x0000209C File Offset: 0x0000209C
		public string Discord { get; set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000020A5 File Offset: 0x000020A5
		// (set) Token: 0x0600000C RID: 12 RVA: 0x000020AD File Offset: 0x000020AD
		public string DiscordToken { get; set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000D RID: 13 RVA: 0x000020B6 File Offset: 0x000020B6
		// (set) Token: 0x0600000E RID: 14 RVA: 0x000020BE File Offset: 0x000020BE
		public string DiscordLink { get; set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000F RID: 15 RVA: 0x000020C7 File Offset: 0x000020C7
		// (set) Token: 0x06000010 RID: 16 RVA: 0x000020CF File Offset: 0x000020CF
		public string DiscordC99 { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000011 RID: 17 RVA: 0x000020D8 File Offset: 0x000020D8
		// (set) Token: 0x06000012 RID: 18 RVA: 0x000020E0 File Offset: 0x000020E0
		public string AutoBuy { get; set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000013 RID: 19 RVA: 0x000020E9 File Offset: 0x000020E9
		// (set) Token: 0x06000014 RID: 20 RVA: 0x000020F1 File Offset: 0x000020F1
		public List<NewsObject> News { get; set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000015 RID: 21 RVA: 0x000020FA File Offset: 0x000020FA
		// (set) Token: 0x06000016 RID: 22 RVA: 0x00002102 File Offset: 0x00002102
		public List<VPNObject> VPNs { get; set; }
	}
}
