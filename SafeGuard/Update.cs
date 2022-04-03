using System;

namespace SafeGuard
{
	// Token: 0x0200000C RID: 12
	internal static class Update
	{
		// Token: 0x06000076 RID: 118 RVA: 0x00002481 File Offset: 0x00002481
		internal static void update()
		{
			ClientFunctions.AutoUpdate(Update.version, ProgramInformation.ProgramId);
		}

		// Token: 0x04000039 RID: 57
		internal static string version = "1";
	}
}
