using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Threading;
using Newtonsoft.Json;
using SafeGuard;
using Synax.User_Controls;

namespace Synax
{
	// Token: 0x0200001A RID: 26
	public partial class MainWindow : Window
	{
		// Token: 0x060000B4 RID: 180 RVA: 0x00003568 File Offset: 0x00003568
		public MainWindow()
		{
			this.InitializeComponent();
			this.TabDisplay.Children.Add(new ucDashboard());
			Task.Run(delegate()
			{
				this.LoadRunningAttacks();
			});
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000035A0 File Offset: 0x000035A0
		private void LoadRunningAttacks()
		{
			while (ResponseInformation.loginresponse != null)
			{
				try
				{
					this.lblYourAttacks.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate()
					{
						this.lblYourAttacks.Content = AppUtils.UsersOnline.Count<string>() + 1;
					}));
					SafeGuardAttackInfo.RunningAttacks = JsonConvert.DeserializeObject<List<AttackLog>>(Tools.getRequest("https://safeguardauth.us/GetOnGoingAttacks?programid=" + ProgramInformation.ProgramId + "&username=" + ResponseInformation.loginresponse.UserName));
					SafeGuardAttackInfo.MethodInformation = (from o in SafeGuardAttackInfo.GetMethodInformation()
					orderby o.Count descending
					select o).ToList<MethodStats>();
				}
				catch
				{
				}
				this.lblRunningAttacks.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate()
				{
					this.lblRunningAttacks.Content = SafeGuardAttackInfo.RunningAttacks.Count<AttackLog>();
				}));
				Thread.Sleep(3000);
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000367C File Offset: 0x0000367C
		private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			base.DragMove();
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00003684 File Offset: 0x00003684
		private void btnChat_Click(object sender, RoutedEventArgs e)
		{
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00003688 File Offset: 0x00003688
		private void Window_Initialized(object sender, EventArgs e)
		{
			MainWindow.<Window_Initialized>d__4 <Window_Initialized>d__;
			<Window_Initialized>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Window_Initialized>d__.<>4__this = this;
			<Window_Initialized>d__.<>1__state = -1;
			<Window_Initialized>d__.<>t__builder.Start<MainWindow.<Window_Initialized>d__4>(ref <Window_Initialized>d__);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000036BF File Offset: 0x000036BF
		private void btnAttack_Click(object sender, RoutedEventArgs e)
		{
			this.TabDisplay.Children.Clear();
			this.TabDisplay.Children.Add(new ucAttackHub());
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000036E7 File Offset: 0x000036E7
		private void Border_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
		{
			base.DragMove();
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000036EF File Offset: 0x000036EF
		private void btnTools_Click(object sender, RoutedEventArgs e)
		{
			this.TabDisplay.Children.Clear();
			this.TabDisplay.Children.Add(new ucTools());
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00003717 File Offset: 0x00003717
		private void btnSettings_Click(object sender, RoutedEventArgs e)
		{
			this.TabDisplay.Children.Clear();
			this.TabDisplay.Children.Add(new ucSettings());
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000373F File Offset: 0x0000373F
		private void btnExit_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000374B File Offset: 0x0000374B
		private void btnMin_Click(object sender, RoutedEventArgs e)
		{
			base.WindowState = WindowState.Minimized;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00003754 File Offset: 0x00003754
		private void btnDiscord_Click(object sender, RoutedEventArgs e)
		{
			Process.Start("https://discord.gg/TKD92mZvej");
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00003761 File Offset: 0x00003761
		private void btnInstagram_Click(object sender, RoutedEventArgs e)
		{
			Process.Start("https://www.instagram.com/exkazer/");
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000376E File Offset: 0x0000376E
		private void btnLogger_Click(object sender, RoutedEventArgs e)
		{
			this.TabDisplay.Children.Clear();
			this.TabDisplay.Children.Add(new ucUserLogger());
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00003796 File Offset: 0x00003796
		private void btnDashboard_Click(object sender, RoutedEventArgs e)
		{
			this.TabDisplay.Children.Clear();
			this.TabDisplay.Children.Add(new ucDashboard());
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000037BE File Offset: 0x000037BE
		private void btnLogger_Click_1(object sender, RoutedEventArgs e)
		{
			this.TabDisplay.Children.Clear();
			this.TabDisplay.Children.Add(new ucUserLogger());
		}
	}
}
