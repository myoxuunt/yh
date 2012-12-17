using System;
using System.Windows.Forms;

namespace BengZhan.controls
{
	/// <summary>
	/// myCmb 的摘要说明。
	/// </summary>
	public class myCmb:System.Windows.Forms.ComboBox
	{
		public myCmb():base()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}
		protected override void OnKeyDown(KeyEventArgs e)
		{
			e.Handled=true;
		}
		protected override void OnKeyPress(
			KeyPressEventArgs e
			)
		{
			Byte[] bt=System.Text.Encoding.ASCII.GetBytes(e.KeyChar.ToString());
			if(bt.Length<1)
			{
				e.Handled=true;
				return;
			}
			if(bt[0]!=8)
			{
				//删除键
				e.Handled=true;
				return;
			}		
		}
		
	}
}
