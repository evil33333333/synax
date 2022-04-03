using System;

namespace SafeGuard
{
	// Token: 0x02000004 RID: 4
	public class NewsObject
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000021 RID: 33 RVA: 0x0000215F File Offset: 0x0000215F
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00002167 File Offset: 0x00002167
		public int Type { get; set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00002170 File Offset: 0x00002170
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00002178 File Offset: 0x00002178
		public string Title { get; set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00002181 File Offset: 0x00002181
		// (set) Token: 0x06000026 RID: 38 RVA: 0x00002189 File Offset: 0x00002189
		public string Content { get; set; }
	}
}
