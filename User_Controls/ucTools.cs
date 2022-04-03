using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace Synax.User_Controls
{
	// Token: 0x02000021 RID: 33
	public class ucTools : UserControl, IComponentConnector
	{
		// Token: 0x060000FC RID: 252 RVA: 0x00006F7B File Offset: 0x00006F7B
		public ucTools()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00006F8C File Offset: 0x00006F8C
		private void btnScan_Click(object sender, RoutedEventArgs e)
		{
			ucTools.<btnScan_Click>d__5 <btnScan_Click>d__;
			<btnScan_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<btnScan_Click>d__.<>4__this = this;
			<btnScan_Click>d__.<>1__state = -1;
			<btnScan_Click>d__.<>t__builder.Start<ucTools.<btnScan_Click>d__5>(ref <btnScan_Click>d__);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00006FC4 File Offset: 0x00006FC4
		private void btnTrack_Click(object sender, RoutedEventArgs e)
		{
			ucTools.<btnTrack_Click>d__6 <btnTrack_Click>d__;
			<btnTrack_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<btnTrack_Click>d__.<>4__this = this;
			<btnTrack_Click>d__.<>1__state = -1;
			<btnTrack_Click>d__.<>t__builder.Start<ucTools.<btnTrack_Click>d__6>(ref <btnTrack_Click>d__);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00006FFC File Offset: 0x00006FFC
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri uri = new Uri("/Synax;component/user%20controls/uctools.xaml", UriKind.Relative);
			Application.LoadComponent(this, uri);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000702C File Offset: 0x0000702C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.tabPort = (Grid)target;
				return;
			case 2:
				this.lblOpen = (Label)target;
				return;
			case 3:
				this.lblClosed = (Label)target;
				return;
			case 4:
				this.lblWaitTime = (Label)target;
				return;
			case 5:
				this.tbStartPort = (TextBox)target;
				return;
			case 6:
				this.tbEndPort = (TextBox)target;
				return;
			case 7:
				this.dgOpenPorts = (DataGrid)target;
				return;
			case 8:
				this.tbWaitTime = (TextBox)target;
				return;
			case 9:
				this.btnScan = (Button)target;
				this.btnScan.Click += this.btnScan_Click;
				return;
			case 10:
				this.tbTarget = (TextBox)target;
				return;
			case 11:
				this.tabPort1 = (Grid)target;
				return;
			case 12:
				this.tbGeoTarget = (TextBox)target;
				return;
			case 13:
				this.btnTrack = (Button)target;
				this.btnTrack.Click += this.btnTrack_Click;
				return;
			case 14:
				this.lblProvider = (Label)target;
				return;
			case 15:
				this.lblCountry = (Label)target;
				return;
			case 16:
				this.lblProxy = (Label)target;
				return;
			case 17:
				this.lblCoordinates = (Label)target;
				return;
			case 18:
				this.lblRisk = (Label)target;
				return;
			default:
				this._contentLoaded = true;
				return;
			}
		}

		// Token: 0x040000CC RID: 204
		private static int openPorts;

		// Token: 0x040000CD RID: 205
		private static int closedPorts;

		// Token: 0x040000CE RID: 206
		private bool IsScanningPorts;

		// Token: 0x040000CF RID: 207
		internal Grid tabPort;

		// Token: 0x040000D0 RID: 208
		internal Label lblOpen;

		// Token: 0x040000D1 RID: 209
		internal Label lblClosed;

		// Token: 0x040000D2 RID: 210
		internal Label lblWaitTime;

		// Token: 0x040000D3 RID: 211
		internal TextBox tbStartPort;

		// Token: 0x040000D4 RID: 212
		internal TextBox tbEndPort;

		// Token: 0x040000D5 RID: 213
		internal DataGrid dgOpenPorts;

		// Token: 0x040000D6 RID: 214
		internal TextBox tbWaitTime;

		// Token: 0x040000D7 RID: 215
		internal Button btnScan;

		// Token: 0x040000D8 RID: 216
		internal TextBox tbTarget;

		// Token: 0x040000D9 RID: 217
		internal Grid tabPort1;

		// Token: 0x040000DA RID: 218
		internal TextBox tbGeoTarget;

		// Token: 0x040000DB RID: 219
		internal Button btnTrack;

		// Token: 0x040000DC RID: 220
		internal Label lblProvider;

		// Token: 0x040000DD RID: 221
		internal Label lblCountry;

		// Token: 0x040000DE RID: 222
		internal Label lblProxy;

		// Token: 0x040000DF RID: 223
		internal Label lblCoordinates;

		// Token: 0x040000E0 RID: 224
		internal Label lblRisk;

		// Token: 0x040000E1 RID: 225
		private bool _contentLoaded;

		// Token: 0x02000043 RID: 67
		public class Ports
		{
			// Token: 0x17000083 RID: 131
			// (get) Token: 0x060001F2 RID: 498 RVA: 0x00009FD3 File Offset: 0x00009FD3
			// (set) Token: 0x060001F3 RID: 499 RVA: 0x00009FDB File Offset: 0x00009FDB
			public string Port { get; set; }
		}
	}
}
