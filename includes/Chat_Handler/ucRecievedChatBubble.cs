using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace Synax.Includes.Chat_Handler
{
	// Token: 0x0200002F RID: 47
	public class ucRecievedChatBubble : UserControl, IComponentConnector
	{
		// Token: 0x060001B8 RID: 440 RVA: 0x00008A2C File Offset: 0x00008A2C
		public ucRecievedChatBubble()
		{
			this.InitializeComponent();
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00008A3C File Offset: 0x00008A3C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri uri = new Uri("/Synax;component/includes/chat%20handler/ucrecievedchatbubble.xaml", UriKind.Relative);
			Application.LoadComponent(this, uri);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00008A6C File Offset: 0x00008A6C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				this.lblSender = (Label)target;
				return;
			}
			if (connectionId != 2)
			{
				this._contentLoaded = true;
				return;
			}
			this.tbMessage = (TextBlock)target;
		}

		// Token: 0x0400013F RID: 319
		internal Label lblSender;

		// Token: 0x04000140 RID: 320
		internal TextBlock tbMessage;

		// Token: 0x04000141 RID: 321
		private bool _contentLoaded;
	}
}
