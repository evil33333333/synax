using System;

namespace Synax.Models
{
	// Token: 0x02000024 RID: 36
	public struct UserLogger
	{
		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000146 RID: 326 RVA: 0x00007809 File Offset: 0x00007809
		// (set) Token: 0x06000147 RID: 327 RVA: 0x00007811 File Offset: 0x00007811
		public string Username { get; set; }

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000148 RID: 328 RVA: 0x0000781A File Offset: 0x0000781A
		// (set) Token: 0x06000149 RID: 329 RVA: 0x00007822 File Offset: 0x00007822
		public string IP { get; set; }

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600014A RID: 330 RVA: 0x0000782B File Offset: 0x0000782B
		// (set) Token: 0x0600014B RID: 331 RVA: 0x00007833 File Offset: 0x00007833
		public string Note { get; set; }
	}
}
