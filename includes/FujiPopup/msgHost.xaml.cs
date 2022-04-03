using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace Synax.Includes.FujiPopup
{
	// Token: 0x0200002D RID: 45
	public partial class msgHost : Window
	{
		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x000087B8 File Offset: 0x000087B8
		// (set) Token: 0x060001AA RID: 426 RVA: 0x000087BF File Offset: 0x000087BF
		public static msgHost Instance { get; private set; }

		// Token: 0x060001AB RID: 427 RVA: 0x000087C7 File Offset: 0x000087C7
		public msgHost()
		{
			this.InitializeComponent();
			msgHost.Instance = this;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x000087DB File Offset: 0x000087DB
		public static void infoBox(string Title, string Message, int Timeout = 5)
		{
			msgHost.Instance.spNotifications.Children.Add(new msgInformation(Title, Message, Timeout));
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000087FA File Offset: 0x000087FA
		public static void successBox(string Title, string Message, int Timeout = 5)
		{
			msgHost.Instance.spNotifications.Children.Add(new msgSuccess(Title, Message, Timeout));
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00008819 File Offset: 0x00008819
		public static void warningBox(string Title, string Message, int Timeout = 5)
		{
			msgHost.Instance.spNotifications.Children.Add(new msgWarning(Title, Message, Timeout));
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00008838 File Offset: 0x00008838
		public static void dangerBox(string Title, string Message, int Timeout = 5)
		{
			msgHost.Instance.spNotifications.Children.Add(new msgDanger(Title, Message, Timeout));
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00008858 File Offset: 0x00008858
		private void wdFuji_Loaded(object sender, RoutedEventArgs e)
		{
			Rect workArea = SystemParameters.WorkArea;
			base.Left = workArea.Right - base.Width;
			base.Top = workArea.Bottom - base.Height;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00008893 File Offset: 0x00008893
		private void wdFuji_Deactivated(object sender, EventArgs e)
		{
			((Window)sender).Topmost = true;
		}
	}
}
