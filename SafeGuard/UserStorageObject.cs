using System;
using System.Collections.Generic;

namespace SafeGuard
{
	// Token: 0x0200000A RID: 10
	public class UserStorageObject
	{
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000063 RID: 99 RVA: 0x000023E0 File Offset: 0x000023E0
		// (set) Token: 0x06000064 RID: 100 RVA: 0x000023E8 File Offset: 0x000023E8
		public string UserName { get; set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000065 RID: 101 RVA: 0x000023F1 File Offset: 0x000023F1
		// (set) Token: 0x06000066 RID: 102 RVA: 0x000023F9 File Offset: 0x000023F9
		public string Password { get; set; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00002402 File Offset: 0x00002402
		// (set) Token: 0x06000068 RID: 104 RVA: 0x0000240A File Offset: 0x0000240A
		public string Version { get; set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00002413 File Offset: 0x00002413
		// (set) Token: 0x0600006A RID: 106 RVA: 0x0000241B File Offset: 0x0000241B
		public bool AutoLogin { get; set; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00002424 File Offset: 0x00002424
		// (set) Token: 0x0600006C RID: 108 RVA: 0x0000242C File Offset: 0x0000242C
		public bool JoinedDiscord { get; set; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00002435 File Offset: 0x00002435
		// (set) Token: 0x0600006E RID: 110 RVA: 0x0000243D File Offset: 0x0000243D
		public List<string> Ips { get; set; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00002446 File Offset: 0x00002446
		// (set) Token: 0x06000070 RID: 112 RVA: 0x0000244E File Offset: 0x0000244E
		public string Message { get; set; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00002457 File Offset: 0x00002457
		// (set) Token: 0x06000072 RID: 114 RVA: 0x0000245F File Offset: 0x0000245F
		public DateTime LastLogin { get; set; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00002468 File Offset: 0x00002468
		// (set) Token: 0x06000074 RID: 116 RVA: 0x00002470 File Offset: 0x00002470
		public List<ColorRelationShip> colorRelationShips { get; set; }
	}
}
