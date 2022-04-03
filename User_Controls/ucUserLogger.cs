using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Synax.Includes.FujiPopup;
using Synax.Models;

namespace Synax.User_Controls
{
	// Token: 0x02000022 RID: 34
	public class ucUserLogger : UserControl, IComponentConnector, IStyleConnector
	{
		// Token: 0x06000102 RID: 258 RVA: 0x000071BA File Offset: 0x000071BA
		public ucUserLogger()
		{
			this.InitializeComponent();
			this.OnLoad();
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000071D0 File Offset: 0x000071D0
		private void OnLoad()
		{
			SettingsModel settingsModel = SettingsManager.Load();
			this.dgUserLog.Items.Clear();
			foreach (UserLogger userLogger in settingsModel.UserLoggerList)
			{
				UserLogger userLogger2 = new UserLogger
				{
					Username = userLogger.Username,
					IP = userLogger.IP,
					Note = userLogger.Note
				};
				this.dgUserLog.Items.Add(userLogger2);
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000727C File Offset: 0x0000727C
		private void btnCopy_Click(object sender, RoutedEventArgs e)
		{
			string text = (this.dgUserLog.SelectedCells[0].Column.GetCellContent(this.dgUserLog.SelectedCells[0].Item) as TextBlock).Text;
			string text2 = (this.dgUserLog.SelectedCells[1].Column.GetCellContent(this.dgUserLog.SelectedCells[1].Item) as TextBlock).Text;
			Clipboard.SetText(text + ":" + text2);
			msgHost.infoBox("Info...", "User copied to your clipboard", 5);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000732C File Offset: 0x0000732C
		private void btnDelete_Click(object sender, RoutedEventArgs e)
		{
			string user = (this.dgUserLog.SelectedCells[0].Column.GetCellContent(this.dgUserLog.SelectedCells[0].Item) as TextBlock).Text;
			SettingsModel settingsModel = SettingsManager.Load();
			settingsModel.UserLoggerList.Remove(settingsModel.UserLoggerList.First((UserLogger x) => x.Username == user));
			settingsModel.Save();
			msgHost.infoBox("Enemy Logger", "User removed from logs", 5);
			this.OnLoad();
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000073CC File Offset: 0x000073CC
		private void tbnApply_Click(object sender, RoutedEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(this.tbUser.Text) || string.IsNullOrWhiteSpace(this.tbIP.Text))
			{
				msgHost.dangerBox("ERROR", "User or IP is null or whitespace", 5);
				return;
			}
			SettingsModel settingsModel = SettingsManager.Load();
			settingsModel.UserLoggerList.Add(new UserLogger
			{
				Username = this.tbUser.Text,
				IP = this.tbIP.Text,
				Note = (string.IsNullOrWhiteSpace(this.tbNote.Text) ? "Unknow" : this.tbNote.Text)
			});
			settingsModel.Save();
			msgHost.infoBox("INFO", "User has been added to your list", 5);
			this.OnLoad();
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00007494 File Offset: 0x00007494
		private void tbnDeleteAll_Click(object sender, RoutedEventArgs e)
		{
			SettingsModel settingsModel = SettingsManager.Load();
			if (settingsModel.UserLoggerList.Count != 0)
			{
				settingsModel.UserLoggerList.Clear();
				settingsModel.Save();
				this.OnLoad();
				msgHost.infoBox("User Logger", "List cleared successfully", 5);
				return;
			}
			msgHost.warningBox("User Logger", "List is already empty", 5);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000074EC File Offset: 0x000074EC
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri uri = new Uri("/Synax;component/user%20controls/ucuserlogger.xaml", UriKind.Relative);
			Application.LoadComponent(this, uri);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0000751C File Offset: 0x0000751C
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
				this.dgUserLog = (DataGrid)target;
				return;
			case 4:
				this.tabLaunch = (Grid)target;
				return;
			case 5:
				this.tbUser = (TextBox)target;
				return;
			case 6:
				this.tbIP = (TextBox)target;
				return;
			case 7:
				this.tbNote = (TextBox)target;
				return;
			case 8:
				this.tbnApply = (Button)target;
				this.tbnApply.Click += this.tbnApply_Click;
				return;
			case 9:
				this.tbnDeleteAll = (Button)target;
				this.tbnDeleteAll.Click += this.tbnDeleteAll_Click;
				return;
			}
			this._contentLoaded = true;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000075F7 File Offset: 0x000075F7
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IStyleConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 3)
			{
				((Button)target).Click += this.btnCopy_Click;
			}
		}

		// Token: 0x040000E2 RID: 226
		internal Grid tabPort;

		// Token: 0x040000E3 RID: 227
		internal DataGrid dgUserLog;

		// Token: 0x040000E4 RID: 228
		internal Grid tabLaunch;

		// Token: 0x040000E5 RID: 229
		internal TextBox tbUser;

		// Token: 0x040000E6 RID: 230
		internal TextBox tbIP;

		// Token: 0x040000E7 RID: 231
		internal TextBox tbNote;

		// Token: 0x040000E8 RID: 232
		internal Button tbnApply;

		// Token: 0x040000E9 RID: 233
		internal Button tbnDeleteAll;

		// Token: 0x040000EA RID: 234
		private bool _contentLoaded;
	}
}
