using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using SafeGuard;
using Synax.Includes;
using Synax.Includes.FujiPopup;

namespace Synax.User_Controls
{
	// Token: 0x0200001D RID: 29
	public class ucAttackHub : UserControl, IComponentConnector
	{
		// Token: 0x060000D8 RID: 216 RVA: 0x00003BC8 File Offset: 0x00003BC8
		public ucAttackHub()
		{
			this.InitializeComponent();
			List<Functions.LocalLogs> list = Functions.ReadFile("AttackLogs", SafeGuardTitle.safeguardtitle);
			if (list != null)
			{
				this.dgAttackLogs.Items.Clear();
				foreach (Functions.LocalLogs insertItem in list)
				{
					this.dgAttackLogs.Items.Insert(0, insertItem);
				}
			}
			this.LoadData(this.cbServer, (from s in ResponseInformation.UpdatedMethods
			select s.Title).ToList<string>());
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00003C8C File Offset: 0x00003C8C
		public void LoadData(ComboBox content, List<string> Titles)
		{
			ucAttackHub.<LoadData>d__1 <LoadData>d__;
			<LoadData>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<LoadData>d__.content = content;
			<LoadData>d__.Titles = Titles;
			<LoadData>d__.<>1__state = -1;
			<LoadData>d__.<>t__builder.Start<ucAttackHub.<LoadData>d__1>(ref <LoadData>d__);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00003CCC File Offset: 0x00003CCC
		private void cbServer_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			this.cbMethod.Items.Clear();
			try
			{
				this.LoadData(this.cbMethod, (from s in (from w in ResponseInformation.UpdatedMethods
				where w.Title == this.cbServer.SelectedItem.ToString()
				select w).First<MethodInfo2>().Methods
				select s.MethodName).ToList<string>());
			}
			catch
			{
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00003D54 File Offset: 0x00003D54
		private void btnLaunch_Click(object sender, RoutedEventArgs e)
		{
			ucAttackHub.<btnLaunch_Click>d__3 <btnLaunch_Click>d__;
			<btnLaunch_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<btnLaunch_Click>d__.<>4__this = this;
			<btnLaunch_Click>d__.<>1__state = -1;
			<btnLaunch_Click>d__.<>t__builder.Start<ucAttackHub.<btnLaunch_Click>d__3>(ref <btnLaunch_Click>d__);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00003D8C File Offset: 0x00003D8C
		private void btnAttack_Click(object sender, RoutedEventArgs e)
		{
			ucAttackHub.<btnAttack_Click>d__4 <btnAttack_Click>d__;
			<btnAttack_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<btnAttack_Click>d__.<>4__this = this;
			<btnAttack_Click>d__.<>1__state = -1;
			<btnAttack_Click>d__.<>t__builder.Start<ucAttackHub.<btnAttack_Click>d__4>(ref <btnAttack_Click>d__);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00003DC4 File Offset: 0x00003DC4
		private void tbPing_Click(object sender, RoutedEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(this.tbTarget.Text))
			{
				msgHost.dangerBox("Invalid IP", "Target is null or whitespace", 5);
				return;
			}
			Process.Start(new ProcessStartInfo
			{
				FileName = "ping.exe",
				Arguments = this.tbTarget.Text + " -t"
			});
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00003E28 File Offset: 0x00003E28
		private void tbTcpPing_Click(object sender, RoutedEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(this.tbTarget.Text) || string.IsNullOrWhiteSpace(this.tbPort.Text))
			{
				msgHost.dangerBox("Invalid Arguments", "Missing target or port!", 5);
				return;
			}
			try
			{
				Process.GetProcessesByName("paping");
				new Process
				{
					StartInfo = 
					{
						UseShellExecute = false,
						FileName = "paping.exe",
						Arguments = this.tbTarget.Text + " -p " + this.tbPort.Text
					}
				}.Start();
			}
			catch
			{
				msgHost.dangerBox("Erorr", "paping not found", 5);
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00003EF0 File Offset: 0x00003EF0
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri uri = new Uri("/Synax;component/user%20controls/ucattackhub.xaml", UriKind.Relative);
			Application.LoadComponent(this, uri);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00003F20 File Offset: 0x00003F20
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.tabLaunch = (Grid)target;
				return;
			case 2:
				this.tbTarget = (TextBox)target;
				return;
			case 3:
				this.tbPort = (TextBox)target;
				return;
			case 4:
				this.tbTime = (TextBox)target;
				return;
			case 5:
				this.cbServer = (ComboBox)target;
				this.cbServer.SelectionChanged += this.cbServer_SelectionChanged;
				return;
			case 6:
				this.cbMethod = (ComboBox)target;
				return;
			case 7:
				this.tbPing = (Button)target;
				this.tbPing.Click += this.tbPing_Click;
				return;
			case 8:
				this.tbTcpPing = (Button)target;
				this.tbTcpPing.Click += this.tbTcpPing_Click;
				return;
			case 9:
				this.btnLaunch = (Button)target;
				this.btnLaunch.Click += this.btnLaunch_Click;
				return;
			case 10:
				this.dgAttackLogs = (DataGrid)target;
				return;
			default:
				this._contentLoaded = true;
				return;
			}
		}

		// Token: 0x04000086 RID: 134
		internal Grid tabLaunch;

		// Token: 0x04000087 RID: 135
		internal TextBox tbTarget;

		// Token: 0x04000088 RID: 136
		internal TextBox tbPort;

		// Token: 0x04000089 RID: 137
		internal TextBox tbTime;

		// Token: 0x0400008A RID: 138
		internal ComboBox cbServer;

		// Token: 0x0400008B RID: 139
		internal ComboBox cbMethod;

		// Token: 0x0400008C RID: 140
		internal Button tbPing;

		// Token: 0x0400008D RID: 141
		internal Button tbTcpPing;

		// Token: 0x0400008E RID: 142
		internal Button btnLaunch;

		// Token: 0x0400008F RID: 143
		internal DataGrid dgAttackLogs;

		// Token: 0x04000090 RID: 144
		private bool _contentLoaded;
	}
}
