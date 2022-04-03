using System;
using System.Collections.Generic;

namespace SafeGuard
{
	// Token: 0x0200000E RID: 14
	public class MethodInfo2
	{
		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600007B RID: 123 RVA: 0x000024B7 File Offset: 0x000024B7
		// (set) Token: 0x0600007C RID: 124 RVA: 0x000024BF File Offset: 0x000024BF
		public string Title { get; set; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600007D RID: 125 RVA: 0x000024C8 File Offset: 0x000024C8
		// (set) Token: 0x0600007E RID: 126 RVA: 0x000024D0 File Offset: 0x000024D0
		public int RequiredLevel { get; set; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600007F RID: 127 RVA: 0x000024D9 File Offset: 0x000024D9
		// (set) Token: 0x06000080 RID: 128 RVA: 0x000024E1 File Offset: 0x000024E1
		public List<Method> Methods { get; set; }
	}
}
