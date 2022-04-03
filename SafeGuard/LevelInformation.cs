using System;

namespace SafeGuard
{
	// Token: 0x02000008 RID: 8
	public class LevelInformation
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00002315 File Offset: 0x00002315
		// (set) Token: 0x0600004C RID: 76 RVA: 0x0000231D File Offset: 0x0000231D
		public string Membership { get; set; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00002326 File Offset: 0x00002326
		// (set) Token: 0x0600004E RID: 78 RVA: 0x0000232E File Offset: 0x0000232E
		public int Level { get; set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00002337 File Offset: 0x00002337
		// (set) Token: 0x06000050 RID: 80 RVA: 0x0000233F File Offset: 0x0000233F
		public string[] AttackTimes { get; set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00002348 File Offset: 0x00002348
		// (set) Token: 0x06000052 RID: 82 RVA: 0x00002350 File Offset: 0x00002350
		public string[] Methods { get; set; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00002359 File Offset: 0x00002359
		// (set) Token: 0x06000054 RID: 84 RVA: 0x00002361 File Offset: 0x00002361
		public int Cooldown { get; set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000055 RID: 85 RVA: 0x0000236A File Offset: 0x0000236A
		// (set) Token: 0x06000056 RID: 86 RVA: 0x00002372 File Offset: 0x00002372
		public int MaxTime { get; set; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000057 RID: 87 RVA: 0x0000237B File Offset: 0x0000237B
		// (set) Token: 0x06000058 RID: 88 RVA: 0x00002383 File Offset: 0x00002383
		public int Concurrents { get; set; }
	}
}
