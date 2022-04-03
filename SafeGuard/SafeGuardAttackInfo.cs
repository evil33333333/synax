using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SafeGuard
{
	// Token: 0x02000011 RID: 17
	internal static class SafeGuardAttackInfo
	{
		// Token: 0x0600008C RID: 140 RVA: 0x00002548 File Offset: 0x00002548
		public static List<AttackLog> GetRunningAttacks()
		{
			try
			{
				SafeGuardAttackInfo.RunningAttacks = JsonConvert.DeserializeObject<List<AttackLog>>(Tools.getRequest("https://safeguardauth.us/GetOnGoingAttacks?programid=" + ProgramInformation.ProgramId + "&username=" + ResponseInformation.loginresponse.UserName));
			}
			catch
			{
				SafeGuardAttackInfo.RunningAttacks = new List<AttackLog>();
			}
			return SafeGuardAttackInfo.RunningAttacks;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000025A8 File Offset: 0x000025A8
		public static List<AttackLog> GetAmountOfAttacks(int num)
		{
			try
			{
				SafeGuardAttackInfo.PastAttacks = JsonConvert.DeserializeObject<List<AttackLog>>(Tools.getRequest(string.Format("https://safeguardauth.us/GetPassedAttacks?programid={0}&username={1}&num={2}", ProgramInformation.ProgramId, ResponseInformation.loginresponse.UserName, num)));
			}
			catch
			{
				SafeGuardAttackInfo.PastAttacks = new List<AttackLog>();
			}
			return SafeGuardAttackInfo.PastAttacks;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002608 File Offset: 0x00002608
		public static List<MethodStats> GetMethodInformation()
		{
			try
			{
				SafeGuardAttackInfo.MethodInformation = JsonConvert.DeserializeObject<List<MethodStats>>(Tools.getRequest("https://safeguardauth.us/GetMethodStats?programid=" + ProgramInformation.ProgramId + "&username=" + ResponseInformation.loginresponse.UserName));
			}
			catch
			{
				SafeGuardAttackInfo.MethodInformation = new List<MethodStats>();
			}
			return SafeGuardAttackInfo.MethodInformation;
		}

		// Token: 0x04000042 RID: 66
		internal static List<AttackLog> RunningAttacks;

		// Token: 0x04000043 RID: 67
		internal static List<AttackLog> PastAttacks;

		// Token: 0x04000044 RID: 68
		internal static List<MethodStats> MethodInformation;
	}
}
