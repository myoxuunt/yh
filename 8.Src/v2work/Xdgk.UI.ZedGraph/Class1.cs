using System;
using System.Drawing;
using ZedGraph;
using System.Data;
using System.Collections;

namespace Xdgk.UI.Z
{

    /// <summary>
    /// 
    /// </summary>
    public enum CurveItemType
    {
        Line,
        Bar,
        Pie
    }

    /// <summary>
    /// 
    /// </summary>
    public class GraphPaneConfig
    {
        /// <summary>
        /// 
        /// </summary>
        public GraphPaneConfig()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="gp"></param>
        //public void ConfigGraphPane(GraphPane gp, GRStationCurveInfo info)
        public void ConfigGraphPane(GraphPane gp)
        {
            //if (info == null)
            //{
            //    throw new ArgumentNullException("info");
            //}

            //gp.Title.Text = string.Format(this.TitleFormat, info.StationName,
            //    info.Begin, info.End);
            gp.Title.Text = this.Title;
            gp.Title.FontSpec.Size = TitleFontSize;
            gp.Legend.FontSpec.Size = OtherFontSize;
            gp.XAxis.Title.FontSpec.Size = OtherFontSize;
            gp.YAxis.Title.FontSpec.Size = OtherFontSize;
            gp.IsFontsScaled = this.IsFontsScaled;

            gp.XAxis.Title.Text = XTitle;
            gp.YAxis.Title.Text = YTitle;
            //gp.XAxis.Scale.Min = XMin;
            //gp.XAxis.Scale.Max = XMax;
            gp.XAxis.Type = this.XAxisType;
            gp.XAxis.Scale.Format = XAxisScaleFormat;
            gp.XAxis.MajorGrid.IsVisible = XMajorGridVisible;
            gp.XAxis.MinorGrid.IsVisible = XMinorGridVisible;

            gp.YAxis.Scale.Min = YMin;
            //gp.YAxis.Scale.Max = YMax;

            gp.YAxis.MajorGrid.IsZeroLine = true;
            gp.YAxis.Scale.MaxAuto = YAxisAuto;
            //gp.YAxis.Scale.MinAuto = YAxisAuto;
            gp.YAxis.Scale.MajorStepAuto = YAxisAuto;
            gp.YAxis.Scale.MinorStepAuto = YAxisAuto;

            //
            //
            gp.XAxis.Scale.MaxAuto = XAxisAuto;
            gp.XAxis.Scale.MinAuto = XAxisAuto;
            gp.XAxis.Scale.MajorStepAuto = XAxisAuto;
            gp.XAxis.Scale.MinorStepAuto = XAxisAuto;

            //gp.XAxis.Scale.MajorStep = XMajorStep;
            //gp.XAxis.Scale.MinorStep = XMinorStep;
            //gp.YAxis.Scale.MajorStep = YMajorStep;
            //gp.YAxis.Scale.MinorStep = YMinorStep;
            gp.YAxis.Scale.Format = YAxisScaleFormat;
            gp.YAxis.MajorGrid.IsVisible = YMajorGridVisible;
            gp.YAxis.MinorGrid.IsVisible = YMinorGridVisible;


            gp.XAxis.MajorGrid.IsVisible = XMajorGridVisible;
            gp.XAxis.MinorGrid.IsVisible = XMinorGridVisible;


            // minor tic
            //
            SetMinorTic(gp.XAxis.MinorTic);
            SetMinorTic(gp.YAxis.MinorTic);

            // major tic
            //
            SetMajorTic(gp.XAxis.MajorTic);
            SetMajorTic(gp.YAxis.MajorTic);

            gp.Border.IsVisible = false;
            gp.Chart.Fill = new Fill(Color.LightGoldenrodYellow);
            //Color.

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="tic"></param>
        private void SetMajorTic(MajorTic tic)
        {
            tic.IsCrossInside = false;
            tic.IsCrossOutside = false;
            tic.IsInside = true;
            tic.IsOpposite = false;
            tic.IsOutside = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tic"></param>
        private void SetMinorTic(MinorTic tic)
        {
            tic.PenWidth = 0f;
            tic.Size = 0f;
        }
        #region XAxisAuto
        /// <summary>
        /// 
        /// </summary>
        public bool XAxisAuto
        {
            get
            {
                return _xAxisAuto;
            }
            set
            {
                _xAxisAuto = value;
            }
        } private bool _xAxisAuto = true;
        #endregion //XAxisAuto

        #region YAxisAuto
        /// <summary>
        /// 
        /// </summary>
        public bool YAxisAuto
        {
            get
            {
                return _yAxisAuto;
            }
            set
            {
                _yAxisAuto = value;
            }
        } private bool _yAxisAuto = true;
        #endregion //YAxisAuto

        #region Title
        /// <summary>
        /// graphpane title format string
        /// </summary>
        public string TitleFormat
        {
            get { return _titleFormat; }
            set { _titleFormat = value; }
        } private string _titleFormat = "Title";
        #endregion //Title

        #region XTitle
        /// <summary>
        /// 
        /// </summary>
        public string XTitle
        {
            get { return _xTitle; }
            set { _xTitle = value; }
        } private string _xTitle = "XTitle";
        #endregion //XTitle

        #region YTitle
        /// <summary>
        /// 
        /// </summary>
        public string YTitle
        {
            get { return _yTitle; }
            set { _yTitle = value; }
        } private string _yTitle = "YTitle";
        #endregion //YTitle

        #region XMin
        /// <summary>
        /// 
        /// </summary>
        public double XMin
        {
            get { return _xMin; }
            set { _xMin = value; }
        } private double _xMin = 0;
        #endregion //XMin

        #region XMax
        /// <summary>
        /// 
        /// </summary>
        public double XMax
        {
            get { return _xMax; }
            set { _xMax = value; }
        } private double _xMax = 100;
        #endregion //XMax

        #region YMin
        /// <summary>
        /// 
        /// </summary>
        public double YMin
        {
            get { return _yMin; }
            set { _yMin = value; }
        } private double _yMin = 0;
        #endregion //YMin

        #region YMax
        /// <summary>
        /// 
        /// </summary>
        public double YMax
        {
            get { return _yMax; }
            set { _yMax = value; }
        } private double _yMax = 100;
        #endregion //YMax

        #region Title
        /// <summary>
        /// 
        /// </summary>
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        } private string _title = string.Empty;
        #endregion //

        #region TitleFontSize
        /// <summary>
        /// 
        /// </summary>
        public int TitleFontSize
        {
            get { return _titleFontSize; }
            set { _titleFontSize = value; }
        } private int _titleFontSize = 18;
        #endregion //TitleFontSize

        #region OtherFontSize
        /// <summary>
        /// 
        /// </summary>
        public int OtherFontSize
        {
            get { return _otherFontSize; }
            set { _otherFontSize = value; }
        } private int _otherFontSize = 14;
        #endregion //OtherFontSize

        #region IsFontsScaled
        /// <summary>
        /// 
        /// </summary>
        public bool IsFontsScaled
        {
            get { return _isFontsScaled; }
            set { _isFontsScaled = value; }
        } private bool _isFontsScaled = false;
        #endregion //IsFontsScaled

        #region XAxisType
        /// <summary>
        /// 
        /// </summary>
        public AxisType XAxisType
        {
            get { return _xAxisType; }
            set { _xAxisType = value; }
        } private AxisType _xAxisType = AxisType.Date;
        #endregion //XAxisType

        #region XAxisScaleFormat
        /// <summary>
        /// 
        /// </summary>
        public string XAxisScaleFormat
        {
            get { return _xAxisScaleFormat; }
            set { _xAxisScaleFormat = value; }
        } private string _xAxisScaleFormat = "yyyy-MM-dd\r\nHH:mm:ss";
        #endregion //XAxisScaleFormat

        #region XMajorStep
        /// <summary>
        /// 
        /// </summary>
        public double XMajorStep
        {
            get { return _xMajorStep; }
            set { _xMajorStep = value; }
        } private double _xMajorStep;
        #endregion //XMajorStep

        #region XMinorStep
        /// <summary>
        /// 
        /// </summary>
        public double XMinorStep
        {
            get { return _xMinorStep; }
            set { _xMinorStep = value; }
        } private double _xMinorStep;
        #endregion //XMinorStep

        #region YMajorStep
        /// <summary>
        /// 
        /// </summary>
        public double YMajorStep
        {
            get { return _yMajorStep; }
            set { _yMajorStep = value; }
        } private double _yMajorStep = 10;
        #endregion //YMajorStep

        #region YMinorStep
        /// <summary>
        /// 
        /// </summary>
        public double YMinorStep
        {
            get { return _yMinorStep; }
            set { _yMinorStep = value; }
        } private double _yMinorStep = 5;
        #endregion //YMinorStep

        #region XMajorGridVisible
        /// <summary>
        /// 
        /// </summary>
        public bool XMajorGridVisible
        {
            get { return _xMajorGridVisible; }
            set { _xMajorGridVisible = value; }
        } private bool _xMajorGridVisible = true;
        #endregion //XMajorGridVisible

        #region XMinorGridVisible
        /// <summary>
        /// 
        /// </summary>
        public bool XMinorGridVisible
        {
            get { return _xMinorGridVisible; }
            set { _xMinorGridVisible = value; }
        } private bool _xMinorGridVisible = false;
        #endregion //XMinorGridVisible

        #region YMajorGridVisible
        /// <summary>
        /// 
        /// </summary>
        public bool YMajorGridVisible
        {
            get { return _yMajorGridVisible; }
            set { _yMajorGridVisible = value; }
        } private bool _yMajorGridVisible = true;
        #endregion //YMajorGridVisible

        #region YMinorGridVisible
        /// <summary>
        /// 
        /// </summary>
        public bool YMinorGridVisible
        {
            get { return _yMinorGridVisible; }
            set { _yMinorGridVisible = value; }
        } private bool _yMinorGridVisible = false;
        #endregion //YMinorGridVisible

        #region YAxisScaleFormat
        /// <summary>
        /// 
        /// </summary>
        public string YAxisScaleFormat
        {
            get { return _yAxisScaleFormat; }
            set { _yAxisScaleFormat = value; }
        } private string _yAxisScaleFormat = "G";
        #endregion //YAxisScaleFormat

        #region CurveConfigCollection
        /// <summary>
        /// 
        /// </summary>
        //public CurveConfigCollection CurveConfigCollection
        public CurveConfigBaseCollection CurveConfigBaseCollection
        {
            get
            {
                if (_curveConfigCollection == null)
                {
                    _curveConfigCollection = new CurveConfigBaseCollection(this);
                }
                return _curveConfigCollection;
            }
            set
            {
                _curveConfigCollection = value;
            }
        } private CurveConfigBaseCollection _curveConfigCollection;
        #endregion //CurveConfigCollection

        #region CurItemType
        /// <summary>
        /// 
        /// </summary>
        public CurveItemType CurItemType
        {
            get
            {
                return _curItemType;
            }
            set
            {
                _curItemType = value;
            }
        } private CurveItemType _curItemType;
        #endregion //CurItemType
    }

    /// <summary>
    /// 
    /// </summary>
    public class GraphPaneConfigCollection : Xdgk.Common.Collection<GraphPaneConfig>
    {
    }





    ///// <summary>
    ///// 
    ///// </summary>
    //public class CurveFactory
    //{
    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    /// <param name="dataSource"></param>
    //    /// <param name="cfg"></param>
    //    /// <returns></returns>
    //    public static IPointList CreatePointList(object dataSource, CurveConfig cfg)
    //    {
    //        DataTable tbl = dataSource as DataTable;

    //        PointPairList  list = new PointPairList();
    //        // TODO: is line
    //        //
    //        foreach( DataRow row in tbl.Rows )
    //        {
    //            object obj = row[cfg.XDataField];
    //            DateTime dt = Convert.ToDateTime(obj);
    //            XDate xdate = new XDate(dt);

    //            obj = row[cfg.YDataField];
    //            double y = Convert.ToDouble(obj);
    //            list.Add(xdate.XLDate, y);
    //        }

    //        return list;
    //    }
    //}

    ////public 
    ///// <summary>
    ///// 
    ///// </summary>
    ////public class GRStationCurveInfo
    //public class CurveConfig
    //{
    //    ///// <summary>
    //    ///// 
    //    ///// </summary>
    //    //public string Display
    //    //{
    //    //    get
    //    //    {
    //    //        return this.StationName + " - " + this.GRCurveType.Text;
    //    //    }
    //    //}
    //    #region Color
    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    public Color Color
    //    {
    //        get
    //        {
    //            return _color;
    //        }
    //        set
    //        {
    //            _color = value;
    //        }
    //    } private Color _color;
    //    #endregion //Color

    //    #region Name
    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    public string Name
    //    {
    //        get { return _name; }
    //        set { _name = value; }
    //    } private string _name;
    //    #endregion //Name

    //    #region XDataField
    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    public string XDataField
    //    {
    //        get
    //        {
    //            if (_xDataField == null)
    //            {
    //                _xDataField = string.Empty;
    //            }
    //            return _xDataField;
    //        }
    //        set
    //        {
    //            _xDataField = value;
    //        }
    //    } private string _xDataField;
    //    #endregion //XDataField

    //    #region YDataField
    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    public string YDataField
    //    {
    //        get
    //        {
    //            if (_yDataField == null)
    //            {
    //                _yDataField = string.Empty;
    //            }
    //            return _yDataField;
    //        }
    //        set
    //        {
    //            _yDataField = value;
    //        }
    //    } private string _yDataField;
    //    #endregion //YDataField


    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    /// <param name="datasource"></param>
    //    /// <returns></returns>
    //    public IPointList CreatePointList(object dataSource)
    //    {
    //        return CurveFactory.CreatePointList(dataSource, this);
    //    }
    //    // TODO: XType, line, pie ...
    //    // 

    //    //#region GRCurve
    //    ///// <summary>
    //    ///// 
    //    ///// </summary>
    //    //public GRCurveType GRCurveType
    //    //{
    //    //    get { return _grCurveType; }
    //    //    set { _grCurveType = value; }
    //    //} private GRCurveType _grCurveType;
    //    //#endregion //GRCurve

    //    ///// <summary>
    //    ///// 
    //    ///// </summary>
    //    ///// <returns></returns>
    //    //public string GetDetail()
    //    //{
    //    //    StringBuilder sb = new StringBuilder();
    //    //    sb.AppendLine(string.Format("站名: {0}", this.StationName));
    //    //    sb.AppendLine(string.Format("曲线: {0}", this.GRCurveType.Text));
    //    //    sb.AppendLine(string.Format("开始: {0}", this.Begin));
    //    //    sb.AppendLine(string.Format("结束: {0}", this.End));

    //    //    return sb.ToString();
    //    //}
    //}

    ///// <summary>
    ///// 
    ///// </summary>
    //public class CurveConfigCollection : Xdgk.Common.Collection<CurveConfig>
    //{
    //}


    //
    //
    //
    #region CurveData

    /// <summary>
    /// 
    /// </summary>
    public class CurveData
    {
        #region Name
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get
            {
                if (_name == null)
                {
                    _name = string.Empty;
                }
                return _name;
            }
            set
            {
                _name = value;
            }
        } private string _name;
        #endregion //Name

        #region Color
        /// <summary>
        /// 
        /// </summary>
        public Color Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        } private Color _color;
        #endregion //Color

        #region PointList
        /// <summary>
        /// 
        /// </summary>
        public IPointList PointList
        {
            get
            {
                return _pointList;
            }
            set
            {
                _pointList = value;
            }
        } private IPointList _pointList;
        #endregion //PointList

        /// <summary>
        /// 获取或设置X轴数据标签数组
        /// </summary>
        public string[] XAxisLabels
        {
            get { return _xAxisLabels; }
            set { _xAxisLabels = value; }
        } private string[] _xAxisLabels;

        /// <summary>
        /// 获取或设置y轴数据, x轴为text时使用
        /// </summary>
        public double[] YValues
        {
            get { return _yValues; }
            set { _yValues = value; }
        } private double[] _yValues;

        #region CurveItemType
        /// <summary>
        /// 
        /// </summary>
        public CurveItemType CurveItemType
        {
            get
            {
                return _curveItemType;
            }
            set
            {
                _curveItemType = value;
            }
        } private CurveItemType _curveItemType;
        #endregion //CurveItemType

    }
    #endregion //

    /// <summary>
    /// 
    /// </summary>
    public class CurveDataCollection : Xdgk.Common.Collection<CurveData>
    {

    }

    /// <summary>
    /// 
    /// </summary>
    abstract public class CurveConfigBase
    {
        #region XDataField
        /// <summary>
        /// 
        /// </summary>
        public string XDataField
        {
            get
            {
                if (_xDataField == null)
                {
                    _xDataField = string.Empty;
                }
                return _xDataField;
            }
            set
            {
                _xDataField = value;
            }
        } private string _xDataField;
        #endregion //XDataField

        #region YDataField
        /// <summary>
        /// 
        /// </summary>
        public string YDataField
        {
            get
            {
                if (_yDataField == null)
                {
                    _yDataField = string.Empty;
                }
                return _yDataField;
            }
            set
            {
                _yDataField = value;
            }
        } private string _yDataField;
        #endregion //YDataField


        /// <summary>
        /// 
        /// </summary>
        public CurveConfigBaseCollection CurveConfigBaseCollection
        {
            get { return _curveConfigBaseCollection; }
            set { _curveConfigBaseCollection = value; }
        } private CurveConfigBaseCollection _curveConfigBaseCollection;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataSource"></param>
        /// <returns></returns>
        public abstract CurveDataCollection Create(object dataSource);
    }

    /// <summary>
    /// 
    /// </summary>
    public class CurveConfigBaseCollection : Xdgk.Common.Collection<CurveConfigBase>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cfg"></param>
        public CurveConfigBaseCollection(GraphPaneConfig cfg)
        {
            if (cfg == null)
            {
                throw new ArgumentNullException("cfg");
            }

            this._gpCfg = cfg;
        }
        /// <summary>
        /// 
        /// </summary>
        public GraphPaneConfig GraphPaneConfig
        {
            get { return _gpCfg; }
        } private GraphPaneConfig _gpCfg;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="item"></param>
        protected override void InsertItem(int index, CurveConfigBase item)
        {
            item.CurveConfigBaseCollection = this;
            base.InsertItem(index, item);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        protected override void RemoveItem(int index)
        {
            CurveConfigBase c = this[index];
            c.CurveConfigBaseCollection = null;
            base.RemoveItem(index);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class SingleCurveConfig : CurveConfigBase
    {
        #region Name
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get
            {
                if (_name == null)
                {
                    _name = string.Empty;
                }
                return _name;
            }
            set
            {
                _name = value;
            }
        } private string _name;
        #endregion //Name

        #region Color
        /// <summary>
        /// 
        /// </summary>
        public Color Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        } private Color _color;
        #endregion //Color

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataSource"></param>
        /// <returns></returns>
        public override CurveDataCollection Create(object dataSource)
        {
            
            //DataTable tbl = dataSource as DataTable;
            //foreach (DataRow row in tbl.Rows)
            //{
            //    object objX = row[XDataField];
            //    object objY = row[YDataField];
            //}
            if (this.CurveConfigBaseCollection == null)
            {
                throw new InvalidOperationException("sineleCurveConfig.CurveConfigBaseCollection == null");
            }

            if (this.CurveConfigBaseCollection.GraphPaneConfig == null)
            {
                throw new InvalidOperationException("sineleCurveConfig.CurveConfigBaseCollection.GraphPaneConfig == null");
            }
            AxisType axisType = this.CurveConfigBaseCollection.GraphPaneConfig.XAxisType;

            DataTable tbl = dataSource as DataTable;

            if (axisType == AxisType.Date)
            {
                PointPairList list = new PointPairList();
                // TODO: is line
                //
                foreach (DataRow row in tbl.Rows)
                {
                    object obj = row[XDataField];

                    // TODO: 2011-06-13 not datetime data
                    //
                    DateTime dt = Convert.ToDateTime(obj);
                    XDate xdate = new XDate(dt);

                    obj = row[YDataField];
                    double y = Convert.ToDouble(obj);
                    list.Add(xdate.XLDate, y);
                }

                CurveData cd = new CurveData();
                cd.Name = this.Name;
                cd.Color = this.Color;
                cd.PointList = list;

                CurveDataCollection cds = new CurveDataCollection();
                cds.Add(cd);
                return cds;
            }
            else if (axisType == AxisType.Text)
            {
                string[] labels = new string[tbl.Rows.Count];
                double[] yvalues = new double[tbl.Rows.Count];

                for (int i = 0; i < tbl.Rows.Count; i++)
                {
                    DataRow row = tbl.Rows[i];
                    string lbl = row[XDataField].ToString();
                    labels[i] = lbl;
                    yvalues[i] = Convert.ToDouble(row[YDataField]);
                }

                CurveData cd = new CurveData();
                cd.Name = this.Name;
                cd.Color = this.Color;
                cd.XAxisLabels = labels;
                cd.YValues = yvalues;

                CurveDataCollection cds = new CurveDataCollection();
                cds.Add(cd);
                return cds;
            }
            else
            {
                throw new NotImplementedException("not support AxisType: " + axisType);
            }
        }

    }


    /// <summary>
    /// 
    /// </summary>
    public class MultiCurveConfig : CurveConfigBase 
    {
        #region NameField
        /// <summary>
        /// 
        /// </summary>
        public string NameField
        {
            get
            {
                if (_nameField == null)
                {
                    _nameField = string.Empty;
                }
                return _nameField;
            }
            set
            {
                _nameField = value;
            }
        } private string _nameField;
        #endregion //NameField

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataSource"></param>
        /// <returns></returns>
        public override CurveDataCollection Create(object dataSource)
        {
            if (dataSource == null)
            {
                throw new ArgumentNullException("dataSource");
            }

            this.CurveDataMap.Clear ();

            ColorProvider cp = new ColorProvider();
            DataTable tbl = dataSource as DataTable;

            foreach (DataRow row in tbl.Rows)
            {
                CurveData cd = null;
                string name = row[NameField].ToString();
                if (HasCurveData(name))
                {
                    cd = GetCurveData(name);
                }
                else
                {
                    cd = CreateAndAddCurveData(name, cp.GetNextColor());

                    PointPairList list = new PointPairList();
                    cd.PointList = list;
                }


                object obj = row[XDataField];
                DateTime dt = Convert.ToDateTime(obj);
                XDate xdate = new XDate(dt);

                obj = row[YDataField];
                double y = Convert.ToDouble(obj);
                ((PointPairList)cd.PointList).Add(xdate.XLDate, y);
            }

            CurveDataCollection cds = new CurveDataCollection();
            foreach ( object cdObj in this.CurveDataMap.Values )
            {
                cds.Add ( cdObj as CurveData );
            }
            return cds;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private bool HasCurveData(string name)
        {
            return this.CurveDataMap[name] != null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="color"></param>
        private CurveData CreateAndAddCurveData(string name, Color color)
        {
            CurveData cd = new CurveData();
            cd.Name = name;
            cd.Color = color;

            this.CurveDataMap.Add(name, cd);
            return cd;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private CurveData GetCurveData(string name)
        {
            object obj = CurveDataMap[name];
            if (obj == null)
            {
                //CurveData newcd = new CurveData();
                //newcd.Name = name;
                //CurveDataMap[name] = newcd;
                //return newcd;
                throw new InvalidOperationException("get curvedata");
            }
            else
            {
                return obj as CurveData;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private Hashtable CurveDataMap
        {
            get
            {
                if (_hashTable == null)
                {
                    _hashTable = new Hashtable();
                }
                return _hashTable;
            }
        } private Hashtable _hashTable;
    }
}
