using System;
using System.IO;

namespace Synax.Includes
{
	// Token: 0x02000025 RID: 37
	internal class FileHelper
	{
		// Token: 0x0600014C RID: 332 RVA: 0x0000783C File Offset: 0x0000783C
		public static bool CheckDirectory(string dir, bool create = false)
		{
			if (!Directory.Exists(dir))
			{
				if (create)
				{
					try
					{
						Directory.CreateDirectory(dir);
						return true;
					}
					catch
					{
						return false;
					}
					return false;
				}
				return false;
			}
			return true;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000787C File Offset: 0x0000787C
		public static bool CheckFile(string path)
		{
			return File.Exists(path);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0000788C File Offset: 0x0000788C
		public static bool WriteFile(string path, string data)
		{
			bool result;
			try
			{
				File.WriteAllText(path, data);
				result = true;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000078BC File Offset: 0x000078BC
		public static bool CopyFile(string path, string dest)
		{
			bool result;
			try
			{
				File.Copy(path, dest, true);
				result = true;
			}
			catch
			{
				result = false;
			}
			return result;
		}
	}
}
