using System;
using System.Collections.Generic;

namespace SafeGuard
{
	// Token: 0x02000006 RID: 6
	public class LoadObject
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00002217 File Offset: 0x00002217
		// (set) Token: 0x0600002E RID: 46 RVA: 0x0000221F File Offset: 0x0000221F
		public string TOS { get; set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00002228 File Offset: 0x00002228
		// (set) Token: 0x06000030 RID: 48 RVA: 0x00002230 File Offset: 0x00002230
		public string SafeGuardSite { get; set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00002239 File Offset: 0x00002239
		// (set) Token: 0x06000032 RID: 50 RVA: 0x00002241 File Offset: 0x00002241
		public string DiscordInvite { get; set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000033 RID: 51 RVA: 0x0000224A File Offset: 0x0000224A
		// (set) Token: 0x06000034 RID: 52 RVA: 0x00002252 File Offset: 0x00002252
		public string SynaxWebSite { get; set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000035 RID: 53 RVA: 0x0000225B File Offset: 0x0000225B
		// (set) Token: 0x06000036 RID: 54 RVA: 0x00002263 File Offset: 0x00002263
		public string InstaGramLink { get; set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000037 RID: 55 RVA: 0x0000226C File Offset: 0x0000226C
		// (set) Token: 0x06000038 RID: 56 RVA: 0x00002274 File Offset: 0x00002274
		public string BotNetURL { get; set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000039 RID: 57 RVA: 0x0000227D File Offset: 0x0000227D
		// (set) Token: 0x0600003A RID: 58 RVA: 0x00002285 File Offset: 0x00002285
		public string Notify { get; set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600003B RID: 59 RVA: 0x0000228E File Offset: 0x0000228E
		// (set) Token: 0x0600003C RID: 60 RVA: 0x00002296 File Offset: 0x00002296
		public bool StopEnabled { get; set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600003D RID: 61 RVA: 0x0000229F File Offset: 0x0000229F
		// (set) Token: 0x0600003E RID: 62 RVA: 0x000022A7 File Offset: 0x000022A7
		public List<string> Ports { get; set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600003F RID: 63 RVA: 0x000022B0 File Offset: 0x000022B0
		// (set) Token: 0x06000040 RID: 64 RVA: 0x000022B8 File Offset: 0x000022B8
		public List<WhitelistObject> whitelistObject { get; set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000041 RID: 65 RVA: 0x000022C1 File Offset: 0x000022C1
		// (set) Token: 0x06000042 RID: 66 RVA: 0x000022C9 File Offset: 0x000022C9
		public List<LevelInformation> levelInformation { get; set; }
	}
}
