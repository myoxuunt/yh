using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;
using System.Threading;

namespace XDYHZKWeb
{
    public class SqlUpDateTable
    {
        private DataTable Recdt;
		private string RecName;
		private Thread RecordThread;

        public SqlUpDateTable(DataTable dt, string TableName)
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
			Recdt = dt;
			RecName = TableName;
		}
		public void SqlStart()
		{
            RecordThread = new Thread(new ThreadStart(SqlRecord));
            //SqlRecord();
		}

		private void SqlRecord()
		{
			try
			{
				switch (RecName)
				{
					case "Fx":
						RecordFxDatas(Recdt);
						break;
					case "Wl":
						RecordWlDatas(Recdt);
						break;
					case "Zm":
						RecordZmDatas(Recdt);
						break;
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.ToString());
			}
		}

		private void RecordFxDatas(DataTable dt)
		{
			   
		}

		private void RecordWlDatas(DataTable dt)
		{
			try
			{
				int deviceID=0;
				for (int i = 0; i < dt.Rows.Count; i++)
				{
					deviceID=GetDeviceID(dt.Rows[i]["Name"].ToString());
                    string str = string.Format("insert into tblWaterLevel(DeviceID,DT,BeforeWL,BehindWL,SluiceDataID) values ('{0}','{1}','{2}','{3}','{4}')", 
                        deviceID.ToString(), dt.Rows[i]["DT"].ToString(), dt.Rows[i]["BeforeWL"].ToString(), dt.Rows[i]["BehindWL"].ToString(), dt.Rows[i]["SluiceDataID"].ToString());
					bool re=DBcon.Instance.ExecuteNonQuery(str);   
				}      
			}
			catch (Exception ex)
			{
				throw new Exception(ex.ToString());
			}
            
		}

		private void RecordZmDatas(DataTable dt)
		{
			try
			{
				int deviceID=0;
				for (int i = 0; i < dt.Rows.Count; i++)
				{
					deviceID=GetDeviceID(dt.Rows[i]["Name"].ToString());
                    string str = string.Format("insert into tblSluiceData(DeviceID,DT,Height,BeforeWL,BehindWL,SluiceDataID) values ({0},'{1}',{2},{3},{4},{5})", 
                        deviceID, dt.Rows[i]["DT"].ToString(), int.Parse(dt.Rows[i]["Height"].ToString()), int.Parse(dt.Rows[i]["BeforeWL"].ToString()), int.Parse(dt.Rows[i]["BehindWL"].ToString()), int.Parse(dt.Rows[i]["SluiceDataID"].ToString()));
					bool re=DBcon.Instance.ExecuteNonQuery(str);
				}
                
			}
			catch (Exception ex)
			{
				throw new Exception(ex.ToString());
			}
            
		}

		private int GetDeviceID(string name)
		{
			string str=string.Format("select DeviceID from vStationDevice where Name= '{0}'",name);
			DataTable dt=DBcon.Instance.GetDataTable(str);
			return int.Parse(dt.Rows[0][0].ToString());
		}
    }
}
