using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using Newtonsoft.Json;
using SafeGuard;

namespace Synax.Includes
{
	// Token: 0x02000026 RID: 38
	internal class Functions
	{
		// Token: 0x06000151 RID: 337 RVA: 0x000078F4 File Offset: 0x000078F4
		public static bool ValidateUrl(string value)
		{
			value = value.Trim();
			Match match = new Regex("^(?:http(s)?:\\/\\/)?[\\w.-]+(?:\\.[\\w\\.-]+)+[\\w\\-\\._~:/?#[\\]@!\\$&'\\(\\)\\*\\+,;=.]+$").Match(value);
			return value.StartsWith("http") && match.Success;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000792F File Offset: 0x0000792F
		public static bool ValidateIP(string value)
		{
			value = value.Trim();
			return new Regex("^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$").Match(value).Success;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00007954 File Offset: 0x00007954
		public static Task<string> TrackHost(string value)
		{
			Functions.<TrackHost>d__2 <TrackHost>d__;
			<TrackHost>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<TrackHost>d__.value = value;
			<TrackHost>d__.<>1__state = -1;
			<TrackHost>d__.<>t__builder.Start<Functions.<TrackHost>d__2>(ref <TrackHost>d__);
			return <TrackHost>d__.<>t__builder.Task;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00007998 File Offset: 0x00007998
		public static Task<bool> GetAppInfo()
		{
			Functions.<GetAppInfo>d__7 <GetAppInfo>d__;
			<GetAppInfo>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<GetAppInfo>d__.<>1__state = -1;
			<GetAppInfo>d__.<>t__builder.Start<Functions.<GetAppInfo>d__7>(ref <GetAppInfo>d__);
			return <GetAppInfo>d__.<>t__builder.Task;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000079D4 File Offset: 0x000079D4
		public static Task LoadServers(ComboBox serverBox, string appVar)
		{
			Functions.<LoadServers>d__13 <LoadServers>d__;
			<LoadServers>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<LoadServers>d__.<>1__state = -1;
			<LoadServers>d__.<>t__builder.Start<Functions.<LoadServers>d__13>(ref <LoadServers>d__);
			return <LoadServers>d__.<>t__builder.Task;
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00007A10 File Offset: 0x00007A10
		public static Task FetchServerMethods(ComboBox methodBox, string id, string appVar)
		{
			Functions.<FetchServerMethods>d__14 <FetchServerMethods>d__;
			<FetchServerMethods>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<FetchServerMethods>d__.<>1__state = -1;
			<FetchServerMethods>d__.<>t__builder.Start<Functions.<FetchServerMethods>d__14>(ref <FetchServerMethods>d__);
			return <FetchServerMethods>d__.<>t__builder.Task;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00007A4C File Offset: 0x00007A4C
		public static Task FetchServerInfo(string id, string appVar)
		{
			Functions.<FetchServerInfo>d__15 <FetchServerInfo>d__;
			<FetchServerInfo>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<FetchServerInfo>d__.<>1__state = -1;
			<FetchServerInfo>d__.<>t__builder.Start<Functions.<FetchServerInfo>d__15>(ref <FetchServerInfo>d__);
			return <FetchServerInfo>d__.<>t__builder.Task;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00007A88 File Offset: 0x00007A88
		public static bool WriteToFile(Functions.LocalLogs UserObject, string FileName, string Location)
		{
			List<Functions.LocalLogs> list = new List<Functions.LocalLogs>();
			list.Add(UserObject);
			string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), Location);
			string text2 = text + "\\" + FileName + ".json";
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			if (!File.Exists(text2))
			{
				File.Create(text2).Close();
				File.WriteAllText(text2, JsonConvert.SerializeObject(list));
				return true;
			}
			bool result;
			try
			{
				list = JsonConvert.DeserializeObject<List<Functions.LocalLogs>>(File.ReadAllText(text2));
				list.Add(UserObject);
				File.WriteAllText(text2, JsonConvert.SerializeObject(list));
				result = true;
			}
			catch
			{
				File.Move(text2, text + "\\Old" + FileName + ".json");
				result = false;
			}
			return result;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00007B44 File Offset: 0x00007B44
		public static List<Functions.LocalLogs> ReadFile(string FileName, string Location)
		{
			List<Functions.LocalLogs> list = new List<Functions.LocalLogs>();
			string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), Location);
			string path = text + "\\" + FileName + ".json";
			if (!Directory.Exists(text))
			{
				return null;
			}
			if (!File.Exists(path))
			{
				return null;
			}
			list = JsonConvert.DeserializeObject<List<Functions.LocalLogs>>(File.ReadAllText(path));
			if (list != null)
			{
				return list;
			}
			return null;
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00007B9C File Offset: 0x00007B9C
		public static bool IsAttackOnSameIP(string ip)
		{
			return SafeGuardAttackInfo.GetRunningAttacks().Any((AttackLog x) => x.AttkIp == ip);
		}

		// Token: 0x0400010B RID: 267
		public static string userRank;

		// Token: 0x0400010C RID: 268
		public static string maxTime;

		// Token: 0x0400010D RID: 269
		public static string concurrents;

		// Token: 0x0400010E RID: 270
		public static string meme;

		// Token: 0x0400010F RID: 271
		public static string serverID;

		// Token: 0x04000110 RID: 272
		public static string hostField;

		// Token: 0x04000111 RID: 273
		public static string portField;

		// Token: 0x04000112 RID: 274
		public static string timeField;

		// Token: 0x04000113 RID: 275
		public static string methodField;

		// Token: 0x02000049 RID: 73
		public class LocalLogs
		{
			// Token: 0x17000084 RID: 132
			// (get) Token: 0x06000200 RID: 512 RVA: 0x0000A5F6 File Offset: 0x0000A5F6
			// (set) Token: 0x06000201 RID: 513 RVA: 0x0000A5FE File Offset: 0x0000A5FE
			public string AdvHL_Host { get; set; }

			// Token: 0x17000085 RID: 133
			// (get) Token: 0x06000202 RID: 514 RVA: 0x0000A607 File Offset: 0x0000A607
			// (set) Token: 0x06000203 RID: 515 RVA: 0x0000A60F File Offset: 0x0000A60F
			public string AdvHL_Port { get; set; }

			// Token: 0x17000086 RID: 134
			// (get) Token: 0x06000204 RID: 516 RVA: 0x0000A618 File Offset: 0x0000A618
			// (set) Token: 0x06000205 RID: 517 RVA: 0x0000A620 File Offset: 0x0000A620
			public string AdvHL_Time { get; set; }

			// Token: 0x17000087 RID: 135
			// (get) Token: 0x06000206 RID: 518 RVA: 0x0000A629 File Offset: 0x0000A629
			// (set) Token: 0x06000207 RID: 519 RVA: 0x0000A631 File Offset: 0x0000A631
			public string AdvHL_Method { get; set; }

			// Token: 0x17000088 RID: 136
			// (get) Token: 0x06000208 RID: 520 RVA: 0x0000A63A File Offset: 0x0000A63A
			// (set) Token: 0x06000209 RID: 521 RVA: 0x0000A642 File Offset: 0x0000A642
			public string AdvHL_Server { get; set; }

			// Token: 0x17000089 RID: 137
			// (get) Token: 0x0600020A RID: 522 RVA: 0x0000A64B File Offset: 0x0000A64B
			// (set) Token: 0x0600020B RID: 523 RVA: 0x0000A653 File Offset: 0x0000A653
			public string AdvHL_ID { get; set; }
		}
	}
}
