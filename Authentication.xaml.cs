using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Shapes;
using System.Windows.Threading;
using Newtonsoft.Json;
using SafeGuard;
using Synax.Includes;
using Synax.Includes.FujiPopup;
using Synax.Properties;

namespace Synax
{
	// Token: 0x02000016 RID: 22
	public partial class Authentication : Window
	{
		// Token: 0x06000095 RID: 149 RVA: 0x00002BA0 File Offset: 0x00002BA0
		public Authentication()
		{
			this.InitializeComponent();
			this.GetCount();
			if (!FileHelper.CheckDirectory(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Synax"), true))
			{
				msgHost.dangerBox("Could not locate file!", "The directory for this application doesn't exist or couldn't be created, please relaunch!", 5);
			}
			string path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Synax") + "\\ThemeInformation.json";
			if (FileHelper.CheckFile(path))
			{
				ThemeChanger.UpdateTheme(File.ReadAllText(path));
			}
			this.tbUsername.Focus();
			new msgHost().Show();
			if (SettingsManager.Load().AutoLogin)
			{
				this.btnAuthenticate.IsEnabled = false;
				msgHost.infoBox("Logging in...", "Logging you in now " + Settings.Default.Username, 6);
				this.tbUsername.Text = Settings.Default.Username;
				this.tbPassword.Password = Settings.Default.Password;
				this.loginAsync(Settings.Default.Username, Settings.Default.Password);
			}
			if (Settings.Default.RememberUser)
			{
				this.tbUsername.Text = Settings.Default.Username;
				this.tbPassword.Password = Settings.Default.Password;
				this.tgRemember.IsChecked = new bool?(true);
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002CF0 File Offset: 0x00002CF0
		public static void LoadLevelInfo(int level)
		{
			ResponseInformation.UserLoadObject = new LoadObject();
			try
			{
				ResponseInformation.UserLoadObject = JsonConvert.DeserializeObject<LoadObject>(Tools.getRequest("https://pastebin.com/raw/cQbeVB59"));
				ResponseInformation.LevelInfo = ResponseInformation.UserLoadObject.levelInformation.Find((LevelInformation w) => w.Level == level);
				ResponseInformation.SynaxMethods = JsonConvert.DeserializeObject<SynaxMethods>(Tools.getRequest("https://pastebin.com/raw/10ikWCA8"));
				ResponseInformation.UpdatedMethods = (from w in ResponseInformation.SynaxMethods.AllMethods
				where w.RequiredLevel <= ResponseInformation.loginresponse.Level
				select w).ToList<MethodInfo2>();
			}
			catch
			{
				MessageBox.Show("Unable to read or write json from api, contact admin team", "API Erorr");
				Environment.Exit(0);
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002DC0 File Offset: 0x00002DC0
		private void GetCount()
		{
			Authentication.<GetCount>d__2 <GetCount>d__;
			<GetCount>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<GetCount>d__.<>1__state = -1;
			<GetCount>d__.<>t__builder.Start<Authentication.<GetCount>d__2>(ref <GetCount>d__);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002DF0 File Offset: 0x00002DF0
		private void menu_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			try
			{
				base.DragMove();
			}
			catch
			{
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002E18 File Offset: 0x00002E18
		private void btnSignUp_Click(object sender, RoutedEventArgs e)
		{
			this.pgLogin.Visibility = Visibility.Hidden;
			this.pgRegister.Visibility = Visibility.Visible;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002E32 File Offset: 0x00002E32
		private void btnLogin_Click(object sender, RoutedEventArgs e)
		{
			this.pgLogin.Visibility = Visibility.Visible;
			this.pgRegister.Visibility = Visibility.Hidden;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002E4C File Offset: 0x00002E4C
		private void btnExit_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002E58 File Offset: 0x00002E58
		private void btnRegister_Click(object sender, RoutedEventArgs e)
		{
			Authentication.<btnRegister_Click>d__7 <btnRegister_Click>d__;
			<btnRegister_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<btnRegister_Click>d__.<>4__this = this;
			<btnRegister_Click>d__.<>1__state = -1;
			<btnRegister_Click>d__.<>t__builder.Start<Authentication.<btnRegister_Click>d__7>(ref <btnRegister_Click>d__);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002E90 File Offset: 0x00002E90
		private void btnAuthenticate_Click(object sender, RoutedEventArgs e)
		{
			this.btnAuthenticate.IsEnabled = false;
			if (string.IsNullOrWhiteSpace(this.tbUsername.Text))
			{
				msgHost.dangerBox("Login Failed!", "Username is empty!", 5);
				return;
			}
			if (string.IsNullOrWhiteSpace(this.tbPassword.Password))
			{
				msgHost.dangerBox("Login Failed!", "Password is empty!", 5);
				return;
			}
			try
			{
				this.loginAsync(this.tbUsername.Text, this.tbPassword.Password);
			}
			catch (Exception)
			{
				throw;
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002F24 File Offset: 0x00002F24
		private void btnDiscord_Click(object sender, RoutedEventArgs e)
		{
			Process.Start("https://discord.gg/kK64AgDpZ5");
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002F31 File Offset: 0x00002F31
		private void tbUsername_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.Return)
			{
				if (string.IsNullOrWhiteSpace(this.tbUsername.Text))
				{
					msgHost.dangerBox("Empty Field!", "Username is empty!", 5);
					return;
				}
				this.tbPassword.Focus();
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002F6C File Offset: 0x00002F6C
		private void tbPassword_KeyDown(object sender, KeyEventArgs e)
		{
			Authentication.<tbPassword_KeyDown>d__11 <tbPassword_KeyDown>d__;
			<tbPassword_KeyDown>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<tbPassword_KeyDown>d__.<>4__this = this;
			<tbPassword_KeyDown>d__.e = e;
			<tbPassword_KeyDown>d__.<>1__state = -1;
			<tbPassword_KeyDown>d__.<>t__builder.Start<Authentication.<tbPassword_KeyDown>d__11>(ref <tbPassword_KeyDown>d__);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002FAC File Offset: 0x00002FAC
		public void LoadingDotDot()
		{
			this.btnAuthenticate.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate()
			{
				this.btnAuthenticate.IsEnabled = false;
			}));
			while (ResponseInformation.loginresponse == null)
			{
				this.btnAuthenticate.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate()
				{
					this.btnAuthenticate.Content = "Loading.";
				}));
				Thread.Sleep(1000);
				this.btnAuthenticate.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate()
				{
					this.btnAuthenticate.Content = "Loading..";
				}));
				Thread.Sleep(1000);
				this.btnAuthenticate.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate()
				{
					this.btnAuthenticate.Content = "Loading...";
				}));
				Thread.Sleep(1000);
			}
			if (ResponseInformation.loginresponse.Failure)
			{
				this.btnAuthenticate.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate()
				{
					this.btnAuthenticate.Content = "Login";
				}));
				this.btnAuthenticate.Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate()
				{
					this.btnAuthenticate.IsEnabled = true;
				}));
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000030AC File Offset: 0x000030AC
		private Task loginAsync(string username, string password)
		{
			Authentication.<loginAsync>d__13 <loginAsync>d__;
			<loginAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<loginAsync>d__.<>4__this = this;
			<loginAsync>d__.username = username;
			<loginAsync>d__.password = password;
			<loginAsync>d__.<>1__state = -1;
			<loginAsync>d__.<>t__builder.Start<Authentication.<loginAsync>d__13>(ref <loginAsync>d__);
			return <loginAsync>d__.<>t__builder.Task;
		}
	}
}
