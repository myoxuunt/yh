using System;
using System.Windows;
using System.Windows.Forms;
using System.Collections;
using System.Data;

namespace BengZhan.sysWarn
{
	/// <summary>
	/// CSysWarn 的摘要说明。
	/// </summary>
	public class CSysWarn
	{
		public CSysWarn()
		{			
		}

		private System.Timers.Timer m_timeSelect;
		private string m_strWarnTime="";		

		public delegate void warnData();
		public event warnData OnWarn;

		private System.Windows.Forms.Timer m_timeWarn;

		public void iniWarn()
		{
			try
			{
				m_dtWarn=new  DataTable();
				m_dtWarn.Columns.Add("sysWarnT");
				m_dtWarn.Columns.Add("comWarnT");


				this.m_timeSelect=new System.Timers.Timer();
				this.m_timeSelect.Interval=2000;
				this.m_timeSelect.Elapsed+=new System.Timers.ElapsedEventHandler(m_timeSelect_Elapsed);
				this.m_timeSelect.Start();

				this.m_timeWarn=new Timer();
				this.m_timeWarn.Interval=2000;
				this.m_timeWarn.Tick+=new EventHandler(m_timeWarn_Tick);
				this.m_timeWarn.Start();
			
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private string m_strWarnTimeN="";

		private void m_timeSelect_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			try
			{
				this.m_timeSelect.Stop();

				if(this.bComWarn())
				{
					addWarn();
				}

				string strFrom=System.DateTime.Now.ToShortDateString()+" 00:00:00";
				string strTo=System.DateTime.Now.ToShortDateString()+" 23:00:00";

				string strSql=string.Format("select time from tbWarnTime where time between '{0}' and '{1}'",strFrom,strTo);
				string strWarnTime=BengZhan.CDBConnection.ExecuteScalar(strSql);

				if(strWarnTime.Trim()=="")
				{
					this.m_timeSelect.Start();
					return;
				}

				if(this.m_strWarnTime.Trim()=="")
				{				
					this.m_strWarnTimeN=strWarnTime;
					addWarn();			 
					this.m_timeSelect.Start();
					return;
				}		
		
				if(this.m_strWarnTime.Trim()!=strWarnTime.Trim())				
				{
					this.m_strWarnTimeN=strWarnTime;
					addWarn()	;		
					this.m_timeSelect.Start();
					return;
				}
			
				//没有新报警
				this.m_timeSelect.Start();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}	

		private void addWarn()
		{
			if(this.m_strWarnTimeN!=this.m_strWarnTime)
			{
				DataRow dr=m_dtWarn.NewRow();
				dr["sysWarnT"]=this.m_strWarnTimeN;
				m_dtWarn.Rows.Add(dr);
				this.m_strWarnTime=this.m_strWarnTimeN;
			}

			if(this.m_strComWarnTime!=this.m_strComWarnTimeN)			
			{
				DataRow dr=m_dtWarn.NewRow();
				dr["comWarnT"]=this.m_strComWarnTimeN;
				m_dtWarn.Rows.Add(dr);
				this.m_strComWarnTime=this.m_strComWarnTimeN;			
			}			
		}

		private string m_strComWarnTime="";

		private string m_strComWarnTimeN="";

		private bool bComWarn()
		{
			try
			{
				string strFrom=System.DateTime.Now.ToShortDateString()+" 00:00:00";
				string strTo=System.DateTime.Now.ToShortDateString()+" 23:00:00";

				string strSql=string.Format("select time1 from tbWarnTime where time1 between '{0}' and '{1}'",strFrom,strTo);
				string strComWarnTime=BengZhan.CDBConnection.ExecuteScalar(strSql);

				if(strComWarnTime.Trim()=="")
				{
					return false;
				}

				if(this.m_strWarnTime.Trim()=="")
				{
					this.m_strComWarnTimeN=strComWarnTime;
					return true;
				}
				if(this.m_strWarnTime.Trim()!=strComWarnTime.Trim())
				{
					this.m_strComWarnTimeN=strComWarnTime;
					return true;					
				}
				return false;				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;			
			}
		}

		#region"获得报警时间"

		public DataTable getWarnTime()
		{
			try
			{
				DataTable dtWarnTime=m_dtWarn.Clone();
				for(int i=0;i<m_dtWarn.Rows.Count;i++)
				{
					dtWarnTime.ImportRow(m_dtWarn.Rows[i]);
					m_dtWarn.Rows.RemoveAt(i);
					i--;
				}
				return dtWarnTime;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return null;
			}
		}

		#endregion

		private static DataTable m_dtWarn;

		private void m_timeWarn_Tick(object sender, EventArgs e)
		{
			try
			{
				this.m_timeWarn.Stop();

				if(m_dtWarn.Rows.Count>0)
				{
					this.OnWarn();					
				}

				this.m_timeWarn.Start();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
	}
}
