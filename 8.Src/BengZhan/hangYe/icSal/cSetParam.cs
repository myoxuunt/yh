using System;
using System.Windows;
using System.Windows.Forms;

namespace icSal
{
	/// <summary>
	/// cSetParam 的摘要说明。
	/// </summary>
	public class cSetParam
	{
		public AxMSCommLib.AxMSComm axMSComm1;	

		public cSetParam(AxMSCommLib.AxMSComm axMSCommEx)
		{
			axMSComm1=axMSCommEx;
		}
		//发出指令(主要用于设参)
		public bool setParams(string strCmd)
		{
			try
			{

				strCmd=strCmd.Trim();
				string[] strCmds=strCmd.Split(' ');
				for(int i=0;i<strCmds.Length;i++)
				{
					if(strCmds[i].Length==1)
					{
						strCmds[i]="0"+strCmds[i];
					}
				}				
				
				byte[] btWatCmd=new byte[strCmds.Length];

				for(int i=0;i<btWatCmd.Length;i++)				
				{
					btWatCmd[i]=Convert.ToByte(strCmds[i],16);
				}
				this.axMSComm1.Output=btWatCmd;
				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}


	}
}
