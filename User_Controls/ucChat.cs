using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;

namespace Synax.User_Controls
{
	// Token: 0x0200001E RID: 30
	public class ucChat : UserControl, IComponentConnector
	{
		// Token: 0x060000E2 RID: 226 RVA: 0x00004064 File Offset: 0x00004064
		public ucChat()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000407D File Offset: 0x0000407D
		public void timer_Elapsed(object sender, ElapsedEventArgs e)
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00004080 File Offset: 0x00004080
		private void UpdateChat()
		{
			ucChat.<UpdateChat>d__4 <UpdateChat>d__;
			<UpdateChat>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<UpdateChat>d__.<>1__state = -1;
			<UpdateChat>d__.<>t__builder.Start<ucChat.<UpdateChat>d__4>(ref <UpdateChat>d__);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000040B0 File Offset: 0x000040B0
		private void tbMessage_KeyDown(object sender, KeyEventArgs e)
		{
			ucChat.<tbMessage_KeyDown>d__5 <tbMessage_KeyDown>d__;
			<tbMessage_KeyDown>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<tbMessage_KeyDown>d__.<>1__state = -1;
			<tbMessage_KeyDown>d__.<>t__builder.Start<ucChat.<tbMessage_KeyDown>d__5>(ref <tbMessage_KeyDown>d__);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000040DF File Offset: 0x000040DF
		private void control_Unloaded(object sender, RoutedEventArgs e)
		{
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000040E4 File Offset: 0x000040E4
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri uri = new Uri("/Synax;component/user%20controls/ucchat.xaml", UriKind.Relative);
			Application.LoadComponent(this, uri);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00004114 File Offset: 0x00004114
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.control = (ucChat)target;
				this.control.Unloaded += this.control_Unloaded;
				return;
			case 2:
				this.spMessages = (StackPanel)target;
				return;
			case 3:
				this.tbMessage = (TextBox)target;
				this.tbMessage.KeyDown += this.tbMessage_KeyDown;
				return;
			default:
				this._contentLoaded = true;
				return;
			}
		}

		// Token: 0x04000091 RID: 145
		public Timer timer = new Timer();

		// Token: 0x04000092 RID: 146
		public static bool editing;

		// Token: 0x04000093 RID: 147
		internal ucChat control;

		// Token: 0x04000094 RID: 148
		internal StackPanel spMessages;

		// Token: 0x04000095 RID: 149
		internal TextBox tbMessage;

		// Token: 0x04000096 RID: 150
		private bool _contentLoaded;
	}
}
