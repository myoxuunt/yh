using System;
using Xdgk.UI;
using YongShuiGuanLiDBI;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace YongShuiGuanLiV2
{
    public partial class pZM : System.Web.UI.Page
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Init(object sender, EventArgs e)
        {
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            string t = "闸门信息";
            MasterPageHelper.SetTitle(this, t);

            this.UCCompareAmount1.QueryEvent += new EventHandler(UCCompareAmount1_QueryEvent);
            //if (!IsPostBack)
            //{
            //    //this.UCCompareAmount1.BindStationCheckBoxList(new string[] { "XD221" });
            //    ////this.UCCompareAmount1.DeviceTypes = new string[] { "XD221", "xd221modbus" };
            //    //this.UCCompareAmount1.BindStationCheckBoxList(new string[] { "XD221", "xd221modbus" });
            //}
        }
        
        #region GetSelectedChannelName
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string GetSelectedChannelName()
        {
            string channelNames = string.Empty;
            foreach( ChannelClass c in this.UCCompareAmount1.SelectedChannelCollection)
            {
                channelNames += c.ChannelName + " ";
            }
            return channelNames;
        }
        #endregion //GetSelectedChannelName

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void UCCompareAmount1_QueryEvent(object sender, EventArgs e)
        {
            StationCollection stations = this.UCCompareAmount1.SelectedStationCollection;
            if (stations.Count > 0)
            {
                DateTime begin = this.UCCompareAmount1.Begin;
                DateTime end = this.UCCompareAmount1.End ;
                DataTable tbl = stations.GetSluiceDataTable ( begin,end);

                //
                //
                string title = string.Format("{0} ~ {1} {2}闸位曲线", begin, end, this.GetSelectedChannelName());
                string yTitle = "闸位(cm)";

                this.UCAMChart1.SetLineChartInfo(tbl,
                    "StationName", 
                    "DT", 
                    "Height", 
                    title, 
                    yTitle);

                //
                //
                H.DataSource = tbl;
                H.Bind();
            }
        }

        #region H
        /// <summary>
        ///
        /// 
        /// </summary>
        private Xdgk.UI.GridViewHelper H
        {
            get
            {
                if (_h == null)
                {
                    _h = new Xdgk.UI.GridViewHelper(this.GridView1);
                    if (!_h.IsSetGridViewConfig())
                    {
                        _h.GridViewConfig = GetGridViewConfig();
                    }
                }
                return _h;
            }
        } Xdgk.UI.GridViewHelper _h;
        #endregion //H



        #region GetGridViewConfig
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private GridViewConfig GetGridViewConfig()
        {
            GridViewConfig c = new GridViewConfig();
            c.AutoGenerateColumns = false;
            c.GridViewColumnConfigCollection.AddBoundField("站名", "StationName");
            c.GridViewColumnConfigCollection.AddBoundField("时间", "DT");
            c.GridViewColumnConfigCollection.AddBoundField(strings.GateHeightWithUnit, "height");
            c.GridViewColumnConfigCollection.AddBoundField(strings.GateBeforeWLWithUnit , "beforeWL");
            c.GridViewColumnConfigCollection.AddBoundField(strings.GateBehindWLWithUnit , "BehindWL");
            return c;
        }
        #endregion //GetGridViewConfig

        /// <summary>
        /// 
        /// </summary>
        public string[] DeviceTypeFilter
        {
            get
            {
                return ZMDeviceTypes;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string[] ZMDeviceTypes
        {
            get 
            {
                return new string[]
                {
                    "XD202"
                };
            }
        }
    }
}
