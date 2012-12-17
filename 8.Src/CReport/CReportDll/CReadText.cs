using System;
using System.Windows;
using System.Windows.Forms;

namespace CReportDll
{
	/// <summary>
	/// CReadText 的摘要说明。
	/// </summary>
	public class CReadText:TextBox
	{
		public CReadText()
		{			
		}
		protected override void OnKeyPress(
			KeyPressEventArgs e
			)
		{
			e.Handled=true;
		}


	}
}
