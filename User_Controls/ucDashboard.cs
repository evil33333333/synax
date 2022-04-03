using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media.Imaging;
using SafeGuard;

namespace Synax.User_Controls
{
	// Token: 0x0200001F RID: 31
	public class ucDashboard : UserControl, IComponentConnector
	{
		// Token: 0x060000E9 RID: 233 RVA: 0x00004194 File Offset: 0x00004194
		public ucDashboard()
		{
			this.InitializeComponent();
			try
			{
				SafeGuardAttackInfo.MethodInformation = (from o in SafeGuardAttackInfo.GetMethodInformation()
				orderby o.Count descending
				select o).ToList<MethodStats>();
				int num = ResponseInformation.UpdatedMethods.Sum((MethodInfo2 x) => x.Methods.Count);
				this.methodcount.Content = num;
				this.appversion.Content = Update.version;
				this.serverinfo.Content = ResponseInformation.UserLoadObject.Ports.First<string>();
				this.topmethodname.Content = SafeGuardAttackInfo.MethodInformation.First<MethodStats>().Method;
				WebClient webClient = new WebClient();
				string uriString = webClient.DownloadString("https://pastebin.com/raw/4Wb85iCN");
				BitmapImage bitmapImage = new BitmapImage();
				bitmapImage.BeginInit();
				bitmapImage.UriSource = new Uri(uriString, UriKind.Absolute);
				bitmapImage.EndInit();
				this.discordBanner.Source = bitmapImage;
				webClient.Dispose();
				this.maxtime.Content = ResponseInformation.LevelInfo.MaxTime.ToString() + " Seconds";
				this.appversionss.Content = ResponseInformation.LevelInfo.Concurrents;
			}
			catch
			{
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00004304 File Offset: 0x00004304
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri uri = new Uri("/Synax;component/user%20controls/ucdashboard.xaml", UriKind.Relative);
			Application.LoadComponent(this, uri);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00004334 File Offset: 0x00004334
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.serversound = (Label)target;
				return;
			case 2:
				this.serverinfo = (Label)target;
				return;
			case 3:
				this.topmethodname = (Label)target;
				return;
			case 4:
				this.appversion = (Label)target;
				return;
			case 5:
				this.methodcount = (Label)target;
				return;
			case 6:
				this.discordBanner = (Image)target;
				return;
			case 7:
				this.appversionss = (Label)target;
				return;
			case 8:
				this.dsafdfdsfsd = (Label)target;
				return;
			case 9:
				this.maxtime = (Label)target;
				return;
			case 10:
				this.appversionkkk = (Label)target;
				return;
			default:
				this._contentLoaded = true;
				return;
			}
		}

		// Token: 0x04000097 RID: 151
		internal Label serversound;

		// Token: 0x04000098 RID: 152
		internal Label serverinfo;

		// Token: 0x04000099 RID: 153
		internal Label topmethodname;

		// Token: 0x0400009A RID: 154
		internal Label appversion;

		// Token: 0x0400009B RID: 155
		internal Label methodcount;

		// Token: 0x0400009C RID: 156
		internal Image discordBanner;

		// Token: 0x0400009D RID: 157
		internal Label appversionss;

		// Token: 0x0400009E RID: 158
		internal Label dsafdfdsfsd;

		// Token: 0x0400009F RID: 159
		internal Label maxtime;

		// Token: 0x040000A0 RID: 160
		internal Label appversionkkk;

		// Token: 0x040000A1 RID: 161
		private bool _contentLoaded;
	}
}
