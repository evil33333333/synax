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
	// Token: 0x0200002E RID: 46
	public partial class msgWarning : UserControl
	{
		// Token: 0x060001B4 RID: 436 RVA: 0x00008930 File Offset: 0x00008930
		public msgWarning(string Title, string Message, int Timeout)
		{
			msgWarning.<>c__DisplayClass0_0 CS$<>8__locals1 = new msgWarning.<>c__DisplayClass0_0();
			CS$<>8__locals1.Timeout = Timeout;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.InitializeComponent();
			this.lbTitle.Content = Title;
			this.tbMessage.Text = Message;
			Task.Run(delegate()
			{
				msgWarning.<>c__DisplayClass0_0.<<-ctor>b__0>d <<-ctor>b__0>d;
				<<-ctor>b__0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<-ctor>b__0>d.<>4__this = CS$<>8__locals1;
				<<-ctor>b__0>d.<>1__state = -1;
				<<-ctor>b__0>d.<>t__builder.Start<msgWarning.<>c__DisplayClass0_0.<<-ctor>b__0>d>(ref <<-ctor>b__0>d);
				return <<-ctor>b__0>d.<>t__builder.Task;
			});
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00008985 File Offset: 0x00008985
		private void close(object sender, RoutedEventArgs e)
		{
			((Panel)base.Parent).Children.Remove(this);
		}
	}
}
