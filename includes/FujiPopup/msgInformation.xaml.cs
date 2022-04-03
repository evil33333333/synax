using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace Synax.Includes.FujiPopup
{
	// Token: 0x0200002B RID: 43
	public partial class msgInformation : UserControl
	{
		// Token: 0x060001A1 RID: 417 RVA: 0x000085C0 File Offset: 0x000085C0
		public msgInformation(string Title, string Message, int Timeout)
		{
			msgInformation.<>c__DisplayClass0_0 CS$<>8__locals1 = new msgInformation.<>c__DisplayClass0_0();
			CS$<>8__locals1.Timeout = Timeout;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.InitializeComponent();
			this.lbTitle.Content = Title;
			this.tbMessage.Text = Message;
			Task.Run(delegate()
			{
				msgInformation.<>c__DisplayClass0_0.<<-ctor>b__0>d <<-ctor>b__0>d;
				<<-ctor>b__0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<-ctor>b__0>d.<>4__this = CS$<>8__locals1;
				<<-ctor>b__0>d.<>1__state = -1;
				<<-ctor>b__0>d.<>t__builder.Start<msgInformation.<>c__DisplayClass0_0.<<-ctor>b__0>d>(ref <<-ctor>b__0>d);
				return <<-ctor>b__0>d.<>t__builder.Task;
			});
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00008615 File Offset: 0x00008615
		private void close(object sender, RoutedEventArgs e)
		{
			((Panel)base.Parent).Children.Remove(this);
		}
	}
}
