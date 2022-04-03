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
	// Token: 0x0200002A RID: 42
	public partial class msgDanger : UserControl
	{
		// Token: 0x0600019D RID: 413 RVA: 0x000084B0 File Offset: 0x000084B0
		public msgDanger(string Title, string Message, int Timeout)
		{
			msgDanger.<>c__DisplayClass0_0 CS$<>8__locals1 = new msgDanger.<>c__DisplayClass0_0();
			CS$<>8__locals1.Timeout = Timeout;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.InitializeComponent();
			this.lbTitle.Content = Title;
			this.tbMessage.Text = Message;
			try
			{
				Task.Run(delegate()
				{
					msgDanger.<>c__DisplayClass0_0.<<-ctor>b__0>d <<-ctor>b__0>d;
					<<-ctor>b__0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
					<<-ctor>b__0>d.<>4__this = CS$<>8__locals1;
					<<-ctor>b__0>d.<>1__state = -1;
					<<-ctor>b__0>d.<>t__builder.Start<msgDanger.<>c__DisplayClass0_0.<<-ctor>b__0>d>(ref <<-ctor>b__0>d);
					return <<-ctor>b__0>d.<>t__builder.Task;
				});
			}
			catch
			{
			}
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0000851C File Offset: 0x0000851C
		private void close(object sender, RoutedEventArgs e)
		{
			((Panel)base.Parent).Children.Remove(this);
		}
	}
}
