using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using WebChart;
using ZedGraph;
using Xdgk.UI.Z;

namespace YongShuiGuanLiV2.UC
{
    public partial class UCZedChart : System.Web.UI.UserControl
    {
        ZedGraphHelper _helper = new ZedGraphHelper();
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            //this.Visible = false;
            //this.ZedGraphWeb1.RenderGraph += new ZedGraph.Web.ZedGraphWebControlEventHandler(ZedGraphWeb1_RenderGraph);
            _helper.ZedGraphWeb = this.ZedGraphWeb1;
            if (this.DataSource == null)
            {
                this.ZedGraphWeb1.Visible = false;
            }
            else
            {
                this.ZedGraphWeb1.Visible = true;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        public GraphPaneConfig GraphPaneConfig
        {
            get
            {
                return _helper.GraphPaneConfig;
            }
            set
            {
                _helper.GraphPaneConfig = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public object DataSource
        {
            get
            {
                return _helper.DataSource;
            }
            set
            {
                _helper.DataSource = value;
                if (value != null)
                {
                    this.ZedGraphWeb1.Visible = true;
                }
            }
        }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="webObject"></param>
        ///// <param name="g"></param>
        ///// <param name="pane"></param>
        //void ZedGraphWeb1_RenderGraph(
        //    ZedGraph.Web.ZedGraphWeb webObject, System.Drawing.Graphics g, MasterPane pane)
        //{
        //    ZedConfig.Default.InitGraphPane(pane[0], "title");
        //    ZedConfig.Default.ConfigLineGraphPane(pane[0], "时间", "水位");
        //    //    throw new NotImplementedException();
        //    //}



        //    foreach (DataRow row in _tbl.Rows)
        //    {
        //        string name = row["StationName"].ToString();
        //        double wl = Convert.ToDouble(row["Wl1"]);
        //        DateTime dt = Convert.ToDateTime(row["dt"]);
        //        XDate xdt = new XDate(dt);

        //        LineHelper lh = GetLineHelper(name);

        //        lh.PointList.Add(xdt, wl);
        //    }


        //    foreach (object obj in this._hashTable.Values)
        //    {
        //        LineHelper lh = obj as LineHelper;
        //        pane[0].AddCurve(lh.Text, lh.PointList, lh.Color);
        //    }
        //    //this.ZedGraphWeb1.Title
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="name"></param>
        ///// <returns></returns>
        //private LineHelper GetLineHelper(string name)
        //{
        //    if (_hashTable[name] != null)
        //    {
        //        return _hashTable[name] as LineHelper;
        //    }

        //    else
        //    {
        //        _hashTable[name] = new LineHelper(name, ColorProvider.GetNextColor());
        //        return _hashTable[name] as LineHelper;
        //    }
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        //private ColorProvider ColorProvider
        //{

        //    get
        //    {
        //        if (_cp == null)
        //        {
        //            _cp = new ColorProvider();
        //        }
        //        return _cp;
        //    }

        //} private ColorProvider _cp;

        ///// <summary>
        ///// 
        ///// </summary>
        //private Hashtable _hashTable = new Hashtable();
    }
}
