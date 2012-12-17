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

namespace YongShuiGuanLiV2.UC
{
    public partial class UCNavigation : System.Web.UI.UserControl
    {

        public event EventHandler ForwardEvent;
        public event EventHandler BackwardEvent;
        public event EventHandler IncreaseEvent;
        public event EventHandler DecreaseEvent;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Init(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // bind step unit
                //
                ListItemCollection list = new ListItemCollection();

                list.Add(new ListItem("天", StepUnit.Day.ToString()));
                list.Add(new ListItem("周", StepUnit.Week.ToString ()));
                list.Add(new ListItem("月", StepUnit.Month.ToString ()));

                this.ddlStepUnit.DataTextField = "Text";
                this.ddlStepUnit.DataValueField = "Value";
                this.ddlStepUnit.DataSource = list;
                this.ddlStepUnit.DataBind();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public StepUnit StepUnit
        {
            get 
            {
                StepUnit su = StepUnit.Day ;
                if (!string.IsNullOrEmpty ( ddlStepUnit.SelectedValue))
                {
                    object obj = Enum.Parse(typeof(StepUnit), ddlStepUnit.SelectedValue);
                    if (obj != null)
                    {
                        su = (StepUnit)obj;
                    }
                }
                return su;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Step
        {
            get
            {
                return 1;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public StepUnit IncreaseDecreaseStepUnit
        {
            get
            {
                return StepUnit.Day;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int IncreaseDecreaseStep
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbForwar_Click(object sender, EventArgs e)
        {
            if (ForwardEvent != null)
            {
                ForwardEvent(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbBackward_Click(object sender, EventArgs e)
        {
            if (BackwardEvent != null)
            {
                BackwardEvent(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbIncrease_Click(object sender, EventArgs e)
        {
            if (IncreaseEvent!=null)
            {
                IncreaseEvent(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbDecrease_Click(object sender, EventArgs e)
        {
            if (DecreaseEvent!=null)
            {
                DecreaseEvent(this, EventArgs.Empty);
            }
        }
    }
}