using System;
using System.Windows.Forms;

namespace BengZhan.icSal
{
	/// <summary>
	/// CGetPwd µÄÕªÒªËµÃ÷¡£
	/// </summary>
	public class CGetPwd
	{
		public CGetPwd()
		{			
		}
		public static  byte[] getPwd()
		{
			try
			{
				byte[] bt=new byte[16];

				bt[0]=0x10;
				bt[1]=0x11;
				bt[2]=0x12;
				bt[3]=0x13;
				bt[4]=0x14;
				bt[5]=0x15;

				bt[6]=0x08;
				bt[7]=0x77;
				bt[8]=0x8f;
				bt[9]=0x69;

				bt[10]=0x10;
				bt[11]=0x11;
				bt[12]=0x12;
				bt[13]=0x13;
				bt[14]=0x14;
				bt[15]=0x15;

				return bt;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return null;
			}
		}
		//0ÉÈ
		public static byte[] getPwd0()
		{
			byte[] bt=new byte[16];

			bt[0]=0x00;
			bt[1]=0x01;
			bt[2]=0x02;
			bt[3]=0x03;
			bt[4]=0x04;
			bt[5]=0x05;

			bt[6]=0x08;
			bt[7]=0x77;
			bt[8]=0x8f;
			bt[9]=0x69;

			bt[10]=0x00;
			bt[11]=0x01;
			bt[12]=0x02;
			bt[13]=0x03;
			bt[14]=0x04;
			bt[15]=0x05;

			return bt;
		}
		//1ÉÈ
		public static byte[] getPwd1()
		{
			byte[] bt=new byte[16];

			bt[0]=0x10;
			bt[1]=0x11;
			bt[2]=0x12;
			bt[3]=0x13;
			bt[4]=0x14;
			bt[5]=0x15;

			bt[6]=0x08;
			bt[7]=0x77;
			bt[8]=0x8f;
			bt[9]=0x69;

			bt[10]=0x10;
			bt[11]=0x11;
			bt[12]=0x12;
			bt[13]=0x13;
			bt[14]=0x14;
			bt[15]=0x15;

			return bt;
		}
		//2ÉÈ
		public static byte[] getPwd2()
		{
			byte[] bt=new byte[16];

			bt[0]=0xaa;
			bt[1]=0xaa;
			bt[2]=0xaa;
			bt[3]=0xaa;
			bt[4]=0xaa;
			bt[5]=0xaa;

			bt[6]=0x08;
			bt[7]=0x77;
			bt[8]=0x8f;
			bt[9]=0x69;

			bt[10]=0xaa;
			bt[11]=0xaa;
			bt[12]=0xaa;
			bt[13]=0xaa;
			bt[14]=0xaa;
			bt[15]=0xaa;

			return bt;
		}
		//3ÉÈ
		public static byte[] getPwd3()
		{
			byte[] bt=new byte[16];

			bt[0]=0x20;
			bt[1]=0x21;
			bt[2]=0x22;
			bt[3]=0x23;
			bt[4]=0x24;
			bt[5]=0x25;

			bt[6]=0x08;
			bt[7]=0x77;
			bt[8]=0x8f;
			bt[9]=0x69;

			bt[10]=0x20;
			bt[11]=0x21;
			bt[12]=0x22;
			bt[13]=0x23;
			bt[14]=0x24;
			bt[15]=0x25;

			return bt;
		}
		//4ÉÈ
		public static byte[] getPwd4()
		{
			byte[] bt=new byte[16];

			bt[0]=0x30;
			bt[1]=0x31;
			bt[2]=0x32;
			bt[3]=0x33;
			bt[4]=0x34;
			bt[5]=0x35;

			bt[6]=0x08;
			bt[7]=0x77;
			bt[8]=0x8f;
			bt[9]=0x69;

			bt[10]=0x30;
			bt[11]=0x31;
			bt[12]=0x32;
			bt[13]=0x33;
			bt[14]=0x34;
			bt[15]=0x35;

			return bt;
		}
		//5ÉÈ
		public static byte[] getPwd5()
		{
			byte[] bt=new byte[16];

			bt[0]=0x40;
			bt[1]=0x41;
			bt[2]=0x42;
			bt[3]=0x43;
			bt[4]=0x44;
			bt[5]=0x45;

			bt[6]=0x08;
			bt[7]=0x77;
			bt[8]=0x8f;
			bt[9]=0x69;

			bt[10]=0x40;
			bt[11]=0x41;
			bt[12]=0x42;
			bt[13]=0x43;
			bt[14]=0x44;
			bt[15]=0x45;

			return bt;

		}




	}
}
