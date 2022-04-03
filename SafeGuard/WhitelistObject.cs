using System;

namespace SafeGuard
{
	// Token: 0x02000007 RID: 7
	public class WhitelistObject
	{
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000044 RID: 68 RVA: 0x000022DA File Offset: 0x000022DA
		// (set) Token: 0x06000045 RID: 69 RVA: 0x000022E2 File Offset: 0x000022E2
		public string Contact { get; set; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000046 RID: 70 RVA: 0x000022EB File Offset: 0x000022EB
		// (set) Token: 0x06000047 RID: 71 RVA: 0x000022F3 File Offset: 0x000022F3
		public string IP { get; set; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000048 RID: 72 RVA: 0x000022FC File Offset: 0x000022FC
		// (set) Token: 0x06000049 RID: 73 RVA: 0x00002304 File Offset: 0x00002304
		public DateTime ExpirationDate { get; set; }
	}
}
