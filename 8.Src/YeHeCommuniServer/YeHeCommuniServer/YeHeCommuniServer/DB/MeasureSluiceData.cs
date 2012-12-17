using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace YeHeCommuniServer.DB
{
    /// <summary>
    /// 
    /// </summary>
    public class MeasureSluiceData
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="device"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        static public object Insert(XD202Device device, XD202Data data)
        {
            string sql = "insert into tblMeasureSluiceData(DeviceID, DT, BeforeWL, BehindWL, InstantFlux, Height, UsedAmount, RemainedAmount) " +
                "values(@DeviceID, @DT, @BeforeWL, @BehindWL, @InstantFlux, @Height, @UsedAmount, @RemainedAmount)";
            
            SqlCommand cmd = new SqlCommand(sql);
            SqlParameter p = null;

            p = new SqlParameter("@DeviceID", device.ID);
            cmd.Parameters.Add(p);

            p = new SqlParameter("@DT", data.DT);
            cmd.Parameters.Add(p);

            AddParameter(cmd, "@BeforeWL", data.BeforeWaterLevel);
            AddParameter(cmd, "@BehindWL", data.BehindWaterLevel );
            AddParameter(cmd, "@InstantFlux", data.InstantFlux);
            AddParameter(cmd, "@Height", data.Height);
            AddParameter(cmd, "@RemainedAmount", data.RemainAmount);
            AddParameter(cmd, "@UsedAmount", 0);
            return CSDBI.Instance.ExecuteScalar(cmd);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="ParameterName"></param>
        /// <param name="value"></param>
        static private void AddParameter(SqlCommand cmd, string ParameterName, object value)
        {
            SqlParameter p = new SqlParameter(ParameterName, value);
            cmd.Parameters.Add(p);
        }
    }
}
