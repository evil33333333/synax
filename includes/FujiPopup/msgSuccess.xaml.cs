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
	// Token: 0x0200002C RID: 44
	public partial class msgSuccess : UserControl
	{
		// Token: 0x060001A5 RID: 421 RVA: 0x000086BC File Offset: 0x000086BC
		public msgSuccess(string Title, string Message, int Timeout)
		{
			msgSuccess.<>c__DisplayClass0_0 CS$<>8__locals1 = new msgSuccess.<>c__DisplayClass0_0();
			CS$<>8__locals1.Timeout = Timeout;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.InitializeComponent();
			this.lbTitle.Content = Title;
			this.tbMessage.Text = Message;
			Task.Run(delegate()
			{
				msgSuccess.<>c__DisplayClass0_0.<<-ctor>b__0>d <<-ctor>b__0>d;
				<<-ctor>b__0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<-ctor>b__0>d.<>4__this = CS$<>8__locals1;
				<<-ctor>b__0>d.<>1__state = -1;
				<<-ctor>b__0>d.<>t__builder.Start<msgSuccess.<>c__DisplayClass0_0.<<-ctor>b__0>d>(ref <<-ctor>b__0>d);
				return <<-ctor>b__0>d.<>t__builder.Task;
			});
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00008711 File Offset: 0x00008711
		private void close(object sender, RoutedEventArgs e)
		{
			((Panel)base.Parent).Children.Remove(this);
		}
	}
}
