using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace Xdgk.UI
{

    /// <summary>
    /// 
    /// </summary>
    public class GridViewColumnFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cfg"></param>
        /// <returns></returns>
        static public DataControlField Create(GridViewColumnConfig cfg)
        {
            if (cfg == null)
            {
                throw new ArgumentNullException("cfg");
            }

            DataControlField dcf = null;
            switch (cfg.GridViewColumnTypeEnum)
            {
                case GridViewColumnTypeEnum.BoundField :
                    dcf = CreateBoundField(cfg);
                    break;

                case GridViewColumnTypeEnum.HyperLinkField :
                    dcf = CreateHyperLinkField(cfg);
                    break;

                case GridViewColumnTypeEnum.CommandField:
                    dcf = CreateCommandField(cfg);
                    break;

                case GridViewColumnTypeEnum .TemplateField :
                    dcf = CreateTemplateField ( cfg);
                    break;

            }

            //DataControlField dcf = Create(cfg.GridViewColumnTypeEnum);
            //dcf.Visible = cfg.Visible;
            //dcf.HeaderText = cfg.HeaderText;
            //dcf.SortExpression = cfg.SortExpression;


            dcf.HeaderText = cfg.HeaderText;
            dcf.Visible = cfg.Visible;
            dcf.SortExpression = cfg.SortExpression;
            return dcf;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cfg"></param>
        /// <returns></returns>
        private static DataControlField CreateTemplateField(GridViewColumnConfig cfg)
        {
            TemplateField field = new TemplateField();
            // 170 = 160(textbox width) + 10
            //
            field.ItemStyle.Width = 170;
            field.HeaderText = cfg.HeaderText;
            field.ItemTemplate = cfg.ItemTemplate;

            return field ;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cfg"></param>
        /// <returns></returns>
        private static DataControlField CreateCommandField(GridViewColumnConfig cfg)
        {
            CommandField cmd = new CommandField();

            if (cfg.ShowInsertButton)
            {
                cmd.ShowInsertButton = true;
            }
            if (cfg.ShowEditButton)
            {
                cmd.ShowEditButton = true;
            }
            if (cfg.ShowDeleteButton)
            {
                cmd.ShowDeleteButton = true;
            }
            return cmd;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cfg"></param>
        /// <returns></returns>
        private static DataControlField CreateHyperLinkField(GridViewColumnConfig cfg)
        {
            //throw new NotImplementedException();
            HyperLinkField hlf = new HyperLinkField();
            hlf.HeaderText = cfg.HeaderText;
            hlf.Text = cfg.HyperLinkText;
            hlf.DataNavigateUrlFields = cfg.DataNavigateUrlFields;
            hlf.DataNavigateUrlFormatString = cfg.DataNavigateUrlFormatString;
            return hlf;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cfg"></param>
        /// <returns></returns>
        private static DataControlField CreateBoundField(GridViewColumnConfig cfg)
        {
            BoundField bf = new BoundField();
            bf.DataField = cfg.DataTextField;
            bf.DataFormatString = cfg.DataFormatString;
            return bf;
        }



        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="typeEnum"></param>
        ///// <returns></returns>
        //static private DataControlField Create(GridViewColumnConfig cfg)
        //{
        //    GridViewColumnTypeEnum typeEnum = cfg.GridViewColumnTypeEnum;
        //    Type[] types = new Type[] { typeof(BoundField), typeof(HyperLinkField) };
        //    Type type = types[(int)typeEnum];
        //    return Create(cfg,type);
        //}

        //private static DataControlField Create(GridViewColumnConfig cfg, Type type)
        //{
        //     DataControlField dcf= (DataControlField)Activator.CreateInstance(type);
                
        //    if( type == typeof(BoundField ))
        //    {
        //        BoundField ( cfg, dcf );
        //    }
        //     return dcf;
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="cfg"></param>
        ///// <param name="dcf"></param>
        //static private void BoundField(GridViewColumnConfig cfg, DataControlField dcf)
        //{
        //    BoundField bf = dcf as BoundColumn;
        //    bf.DataField = cfg.DataTextField;
        //}
    }
    
}
