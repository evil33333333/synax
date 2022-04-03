using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SafeGuard
{
	// Token: 0x02000015 RID: 21
	internal class SafeCheck
	{
		// Token: 0x06000091 RID: 145 RVA: 0x00002680 File Offset: 0x00002680
		internal static void Md5Check()
		{
			if (SafeCheck.ComputeHash(AppDomain.CurrentDomain.BaseDirectory + "SafeGuard.dll", "MD5") != SafeCheck.CurrentDllMD5)
			{
				MessageBox.Show("Invalid SafeGuard.dll. Exiting Program.", SafeGuardTitle.safeguardtitle);
				Environment.Exit(2134);
			}
			if (SafeCheck.ComputeHash(AppDomain.CurrentDomain.BaseDirectory + "SafeGuard.dll", "SHA1") != SafeCheck.CurrentDllSHA1)
			{
				MessageBox.Show("Invalid SafeGuard.dll. Exiting Program.", SafeGuardTitle.safeguardtitle);
				Environment.Exit(2134);
			}
			if (SafeCheck.ComputeHash(AppDomain.CurrentDomain.BaseDirectory + "SafeGuard.dll", "SHA256") != SafeCheck.CurrentDllSHA256)
			{
				MessageBox.Show("Invalid SafeGuard.dll. Exiting Program.", SafeGuardTitle.safeguardtitle);
				Environment.Exit(2134);
			}
			if (SafeCheck.ComputeHash(AppDomain.CurrentDomain.BaseDirectory + "SafeGuard.dll", "SIZE") != SafeCheck.CurrentDllSize)
			{
				MessageBox.Show("Invalid SafeGuard.dll. Exiting Program.", SafeGuardTitle.safeguardtitle);
				Environment.Exit(2134);
			}
			if (SafeCheck.ComputeHash(AppDomain.CurrentDomain.BaseDirectory + "Newtonsoft.Json.dll", "MD5") != SafeCheck.CurrentNewtonSoftMD5)
			{
				MessageBox.Show("Invalid Newtonsoft.Json.dll. Exiting Program.", SafeGuardTitle.safeguardtitle);
				Environment.Exit(2134);
			}
			if (SafeCheck.ComputeHash(AppDomain.CurrentDomain.BaseDirectory + "Newtonsoft.Json.dll", "SHA1") != SafeCheck.CurrentNewtonSoftSHA1)
			{
				MessageBox.Show("Invalid Newtonsoft.Json.dll. Exiting Program.", SafeGuardTitle.safeguardtitle);
				Environment.Exit(2134);
			}
			if (SafeCheck.ComputeHash(AppDomain.CurrentDomain.BaseDirectory + "Newtonsoft.Json.dll", "SHA256") != SafeCheck.CurrentNewtonSoftSHA256)
			{
				MessageBox.Show("Invalid Newtonsoft.Json.dll. Exiting Program.", SafeGuardTitle.safeguardtitle);
				Environment.Exit(2134);
			}
			if (SafeCheck.ComputeHash(AppDomain.CurrentDomain.BaseDirectory + "Newtonsoft.Json.dll", "SIZE") != SafeCheck.CurrentNewtonSoftSize)
			{
				MessageBox.Show("Invalid Newtonsoft.Json.dll. Exiting Program.", SafeGuardTitle.safeguardtitle);
				Environment.Exit(2134);
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000028B0 File Offset: 0x000028B0
		internal static string ComputeHash(string s, string hashtype)
		{
			if (!(hashtype == "MD5"))
			{
				if (!(hashtype == "SHA1"))
				{
					if (hashtype == "SHA256")
					{
						goto IL_138;
					}
					if (!(hashtype == "SIZE"))
					{
						goto IL_1EB;
					}
					goto IL_1B4;
				}
			}
			else
			{
				using (MD5 md = MD5.Create())
				{
					try
					{
						using (FileStream fileStream = File.OpenRead(s))
						{
							byte[] array = md.ComputeHash(fileStream);
							StringBuilder stringBuilder = new StringBuilder();
							for (int i = 0; i < array.Length; i++)
							{
								stringBuilder.Append(array[i].ToString("X2"));
							}
							return stringBuilder.ToString();
						}
					}
					catch
					{
						return "MD5 Error";
					}
				}
			}
			using (SHA1 sha = SHA1.Create())
			{
				try
				{
					using (FileStream fileStream2 = File.OpenRead(s))
					{
						byte[] array2 = sha.ComputeHash(fileStream2);
						StringBuilder stringBuilder2 = new StringBuilder();
						for (int j = 0; j < array2.Length; j++)
						{
							stringBuilder2.Append(array2[j].ToString("X2"));
						}
						return stringBuilder2.ToString();
					}
				}
				catch
				{
					return "SHA1 Error";
				}
			}
			IL_138:
			using (SHA256 sha2 = SHA256.Create())
			{
				try
				{
					using (FileStream fileStream3 = File.OpenRead(s))
					{
						byte[] array3 = sha2.ComputeHash(fileStream3);
						StringBuilder stringBuilder3 = new StringBuilder();
						for (int k = 0; k < array3.Length; k++)
						{
							stringBuilder3.Append(array3[k].ToString("X2"));
						}
						return stringBuilder3.ToString();
					}
				}
				catch
				{
					return "SHA256 Error";
				}
			}
			IL_1B4:
			try
			{
				using (File.OpenRead(s))
				{
					return new FileInfo(s).Length.ToString();
				}
			}
			catch
			{
				return "File Size Error";
			}
			IL_1EB:
			return "Invalid Type";
		}

		// Token: 0x04000051 RID: 81
		internal static string CurrentDllMD5 = "AA88E613FFA57DD5361032348DC4AF9A";

		// Token: 0x04000052 RID: 82
		internal static string CurrentDllSHA1 = "F4652E18B2B5CA43B45580F71AC7A298AA5D831E";

		// Token: 0x04000053 RID: 83
		internal static string CurrentDllSHA256 = "5DF82BA08026D3C13F5D04999C6738D90A3CF68215F88F34D9C27CABAA06E3B4";

		// Token: 0x04000054 RID: 84
		internal static string CurrentDllSize = "5838336";

		// Token: 0x04000055 RID: 85
		internal static string CurrentNewtonSoftMD5 = "6815034209687816D8CF401877EC8133";

		// Token: 0x04000056 RID: 86
		internal static string CurrentNewtonSoftSHA1 = "1248142EB45EED3BEB0D9A2D3B8BED5FE2569B10";

		// Token: 0x04000057 RID: 87
		internal static string CurrentNewtonSoftSHA256 = "7F912B28A07C226E0BE3ACFB2F57F050538ABA0100FA1F0BF2C39F1A1F1DA814";

		// Token: 0x04000058 RID: 88
		internal static string CurrentNewtonSoftSize = "700336";
	}
}
