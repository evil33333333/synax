using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Synax.User_Controls;

namespace Synax.Includes.Chat_Handler
{
	// Token: 0x02000030 RID: 48
	public class ucSentChatBubble : UserControl, IComponentConnector
	{
		// Token: 0x060001BB RID: 443 RVA: 0x00008A99 File Offset: 0x00008A99
		public ucSentChatBubble()
		{
			this.InitializeComponent();
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00008AA7 File Offset: 0x00008AA7
		private void btnEdit_Click(object sender, RoutedEventArgs e)
		{
			this.rtbEdit.Visibility = Visibility.Visible;
			this.btnEditConfirm.Visibility = Visibility.Visible;
			ucChat.editing = true;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00008AC8 File Offset: 0x00008AC8
		private void btnEditConfirm_Click(object sender, RoutedEventArgs e)
		{
			ucSentChatBubble.<btnEditConfirm_Click>d__2 <btnEditConfirm_Click>d__;
			<btnEditConfirm_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<btnEditConfirm_Click>d__.<>1__state = -1;
			<btnEditConfirm_Click>d__.<>t__builder.Start<ucSentChatBubble.<btnEditConfirm_Click>d__2>(ref <btnEditConfirm_Click>d__);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00008AF8 File Offset: 0x00008AF8
		private void btnDelete_Click(object sender, RoutedEventArgs e)
		{
			ucSentChatBubble.<btnDelete_Click>d__3 <btnDelete_Click>d__;
			<btnDelete_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<btnDelete_Click>d__.<>1__state = -1;
			<btnDelete_Click>d__.<>t__builder.Start<ucSentChatBubble.<btnDelete_Click>d__3>(ref <btnDelete_Click>d__);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00008B28 File Offset: 0x00008B28
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri uri = new Uri("/Synax;component/includes/chat%20handler/ucsentchatbubble.xaml", UriKind.Relative);
			Application.LoadComponent(this, uri);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00008B58 File Offset: 0x00008B58
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.lblSender = (Label)target;
				return;
			case 2:
				this.tbMessage = (TextBlock)target;
				return;
			case 3:
				this.rtbEdit = (RichTextBox)target;
				return;
			case 4:
				this.btnEdit = (Button)target;
				this.btnEdit.Click += this.btnEdit_Click;
				return;
			case 5:
				this.btnDelete = (Button)target;
				this.btnDelete.Click += this.btnDelete_Click;
				return;
			case 6:
				this.btnEditConfirm = (Button)target;
				this.btnEditConfirm.Click += this.btnEditConfirm_Click;
				return;
			default:
				this._contentLoaded = true;
				return;
			}
		}

		// Token: 0x04000142 RID: 322
		internal Label lblSender;

		// Token: 0x04000143 RID: 323
		internal TextBlock tbMessage;

		// Token: 0x04000144 RID: 324
		internal RichTextBox rtbEdit;

		// Token: 0x04000145 RID: 325
		internal Button btnEdit;

		// Token: 0x04000146 RID: 326
		internal Button btnDelete;

		// Token: 0x04000147 RID: 327
		internal Button btnEditConfirm;

		// Token: 0x04000148 RID: 328
		private bool _contentLoaded;
	}
}
