using System;
using System.Drawing;

namespace SafeGuard
{
	// Token: 0x02000009 RID: 9
	public class ColorRelationShip
	{
		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00002394 File Offset: 0x00002394
		// (set) Token: 0x0600005B RID: 91 RVA: 0x0000239C File Offset: 0x0000239C
		public string ObjectName { get; set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600005C RID: 92 RVA: 0x000023A5 File Offset: 0x000023A5
		// (set) Token: 0x0600005D RID: 93 RVA: 0x000023AD File Offset: 0x000023AD
		public Color BackGroundColor { get; set; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600005E RID: 94 RVA: 0x000023B6 File Offset: 0x000023B6
		// (set) Token: 0x0600005F RID: 95 RVA: 0x000023BE File Offset: 0x000023BE
		public Color TextColor { get; set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000060 RID: 96 RVA: 0x000023C7 File Offset: 0x000023C7
		// (set) Token: 0x06000061 RID: 97 RVA: 0x000023CF File Offset: 0x000023CF
		public Color BorderColor { get; set; }
	}
}
