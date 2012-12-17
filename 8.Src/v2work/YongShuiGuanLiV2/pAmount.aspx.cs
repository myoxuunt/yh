using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using YongShuiGuanLiDBI;
using Xdgk.UI;

namespace YongShuiGuanLiV2
{
    public partial class pAmount : System.Web.UI.Page
    {

        Xdgk.UI.GridViewHelper h;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            h = new Xdgk.UI.GridViewHelper(this.GridView1);
            h.DataSourceDelegate = this.GetDataSource;

            if (!IsPostBack)
            {
                h.GridViewConfig = GetGridViewConfig();
            }
            this.UCWaterUserListDTTwo1.QueryEvent += new EventHandler(UCWaterUserListDTTwo1_QueryEvent);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        object GetDataSource()
        {
            Trace.Warn("selected wateruser list");
            foreach (WaterUserClass w in this.UCWaterUserListDTTwo1.WaterUserCollection)
            {
                Trace.Warn(w.Name);
            }

            DateTime begin = this.UCWaterUserListDTTwo1.Begin;
            DateTime end = this.UCWaterUserListDTTwo1.End;
            WaterUserCollection wuc = this.UCWaterUserListDTTwo1.WaterUserCollection;

            // used amount list 
            //
            StageAmountCollection list = new StageAmountCollection();
            foreach (WaterUserClass w in wuc)
            {
                double amount = w.CalcUsedAmount(begin, end);
                StageAmount a = new StageAmount();
                a.WaterUserID  = w.WaterUserID;
                a.WaterUserName = w.Name;
                a.Amount = amount;
                a.Begin = begin;
                a.End = end;

                list.Add(a);
            }
            return list;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void UCWaterUserListDTTwo1_QueryEvent(object sender, EventArgs e)
        {
            //Trace.Warn("selected wateruser list");
            //foreach (WaterUserClass w in this.UCWaterUserListDTTwo1.WaterUserCollection)
            //{
            //    Trace.Warn(w.Name);
            //}

            //DateTime begin = this.UCWaterUserListDTTwo1.Begin;
            //DateTime end = this.UCWaterUserListDTTwo1.End;
            //WaterUserCollection wuc = this.UCWaterUserListDTTwo1.WaterUserCollection;

            //// used amount list 
            ////
            //StageAmountCollection list = new StageAmountCollection();
            //foreach (WaterUserClass w in wuc)
            //{
            //    double amount = w.CalcUsedAmount(begin, end);
            //    StageAmount a = new StageAmount();
            //    a.WaterUserID  = w.WaterUserID;
            //    a.WaterUserName = w.Name;
            //    a.Amount = amount;
            //    a.Begin = begin;
            //    a.End = end;

            //    list.Add(a);
            //}


            //this.GridView1.Columns.Clear();
            //this.GridView1.Columns.Add(CreateHyperLinkField());
            //// bind
            ////
            //this.GridView1.DataSource = list;
            //this.GridView1.DataBind();

            //h.DataSource = list;


            h.GridView.Columns.Add(CreateHyperLinkField());
            h.Bind();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private GridViewConfig GetGridViewConfig()
        {
            GridViewConfig cfg = new GridViewConfig();
            cfg.AllowSorting = true;
            cfg.Caption = "Amount caption";

            //GridViewColumnConfig c1 = new GridViewColumnConfig();
            //c1.DataTextField = "Amount";
            //c1.HeaderText = "h-Amount";
            //c1.SortExpression = "Amount";
            //c1.GridViewColumnTypeEnum = GridViewColumnTypeEnum.BoundField;
            cfg.GridViewColumnConfigCollection.AddBoundField("a", "Amount");

            GridViewColumnConfig c2 = new GridViewColumnConfig();
            c2.DataTextField = "WaterUserName";
            c2.HeaderText = "名称";
            c2.SortExpression = "WaterUserName";
            cfg.GridViewColumnConfigCollection.Add(c2);

            return cfg;
        }

        /// <summary>
        /// 
        /// </summary>
        private HyperLinkField CreateHyperLinkField()
        {
            HyperLinkField hlField = new HyperLinkField();
            hlField.Text = "详细";
            hlField.DataNavigateUrlFields = new string[] { "WaterUserID" };

            // url format string 
            //
            string urlFormatString = string.Format("{0}?WaterUserID={{0}}&Begin={1}&End={2}",
                "pDataHistory.aspx",
                Server.UrlEncode(this.UCWaterUserListDTTwo1.Begin.ToString()),
                Server.UrlEncode(this.UCWaterUserListDTTwo1.End.ToString()));

            hlField.DataNavigateUrlFormatString = urlFormatString;
            return hlField;
        }
    }
}
