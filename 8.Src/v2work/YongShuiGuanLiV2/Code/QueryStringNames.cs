using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace YongShuiGuanLiV2
{
    /// <summary>
    /// 
    /// </summary>
    public class QueryStringNames
    {
        public const string ADEState = "ADEState";
        public const string ID = "id";
        public const string DataEnum = "DataEnum";

        public const string WaterUserID = "WaterUserID",
            Begin = "Begin",
            End = "End",
            StationID = "StationID",
            FormulaID = "FormulaID",
            DeviceDI = "DeviceID"
            ;

    }

    /// <summary>
    /// 
    /// </summary>
    public class SessionNames
    {
        /// <summary>
        /// 
        /// </summary>
        public const string SelectedStationIDs = "SelectedStationIDs";
    }
}
