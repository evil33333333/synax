using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace SafeGuard
{
	// Token: 0x02000005 RID: 5
	internal static class AppUtils
	{
		// Token: 0x06000028 RID: 40 RVA: 0x0000219C File Offset: 0x0000219C
		public static int GetPingAverage(string ip, int amount)
		{
			Ping ping = new Ping();
			long num = 0L;
			for (int i = 0; i < amount; i++)
			{
				try
				{
					PingReply pingReply = ping.Send(ip, 1000);
					num += pingReply.RoundtripTime;
				}
				catch
				{
				}
			}
			return (int)num / amount;
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000029 RID: 41 RVA: 0x000021F0 File Offset: 0x000021F0
		// (set) Token: 0x0600002A RID: 42 RVA: 0x000021F7 File Offset: 0x000021F7
		public static VPNServers ConnectedServer { get; set; }

		// Token: 0x0600002B RID: 43 RVA: 0x000021FF File Offset: 0x000021FF
		public static void Connect(RichTextBox richBox, List<string> comboBox, Form form)
		{
		}

		// Token: 0x04000014 RID: 20
		public static string ConnectionStatus = "N/A";

		// Token: 0x04000015 RID: 21
		public static List<string> UsersOnline = new List<string>();
	}
}
