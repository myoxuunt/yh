using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Common;
using System.Data;
using System.Collections;

namespace YongShuiGuanLiDBI
{
    /// <summary>
    /// 
    /// </summary>
    public class WaterUserClass
    {

        #region Constructor
        /// <summary>
        /// 
        /// </summary>
        internal WaterUserClass()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public WaterUserClass(WaterUserLevel waterUserLevel)
        {
            // TODO:
            //
            //this.WaterUserLevelEnum = waterUserLevel;
        }
        #endregion //

        #region WaterUserID
        /// <summary>
        /// 
        /// </summary>
        public int WaterUserID
        {
            get
            {
                return _waterUserID;
            }
            set
            {
                _waterUserID = value;
            }
        } private int _waterUserID;
        #endregion //WaterUserID

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

        #region Remark
        /// <summary>
        /// 
        /// </summary>
        public string Remark
        {
            get
            {
                if (_remark == null)
                {
                    _remark = string.Empty;
                }
                return _remark;
            }
            set
            {
                _remark = value;
            }
        } private string _remark;
        #endregion //Remark

        #region 水费单价
        /// <summary>
        /// 水费单价
        /// </summary>
        public float UnitPrice
        {
            get
            {
                return _unitPrice;
            }
            set
            {
                _unitPrice = value;
            }

        } private float _unitPrice;
        #endregion //

        #region ChannelCollection
        /// <summary>
        /// 
        /// </summary>
        public ChannelCollection ChannelCollection
        {
            get
            {
                if (_channelCollection == null)
                {
                    // TODO: water user 's channel
                    //
                    //_channelCollection = new ChannelCollection();
                    _channelCollection = ChannelFactory.CreateChannelCollection(this.WaterUserID);
                }
                return _channelCollection;
            }
            set
            {
                _channelCollection = value;
            }
        } private ChannelCollection _channelCollection;
        #endregion //ChannelCollection

        #region ParentWaterUser
        /// <summary>
        /// 
        /// </summary>
        public WaterUserClass ParentWaterUser
        {
            get
            {
                if (_parentWaterUser == null)
                {
                    int parentWaterUserID = WaterUserDBI.GetParentWaterUserID(this.WaterUserID);
                    if (parentWaterUserID != 0)
                    {
                        _parentWaterUser = WaterUserFactory.CreateWaterUserByID(parentWaterUserID);
                    }
                    else
                    {
                        // TODO: 2011-05-20 replace null with noneWaterUser ?
                        //
                    }
                }
                return _parentWaterUser; 
            }
            set 
            {
                _parentWaterUser = value; 
            }
        } private WaterUserClass _parentWaterUser;
        #endregion //ParentWaterUser

        #region WaterUserLevel
        /// <summary>
        /// 
        /// </summary>
        public WaterUserLevel WaterUserLevel
        {
            get
            {
                return _waterUserLevel;
            }
            set
            {
                _waterUserLevel = value;
            }
        } private WaterUserLevel _waterUserLevel;
        #endregion //WaterUserLevel

        #region WaterUserType
        /// <summary>
        /// 
        /// </summary>
        public WaterUserType WaterUserType
        {
            get
            {
                if (_waterUserType == null)
                {
                    // TODO:
                    //
                    //_waterUserType = WaterUserTypeFactory.CreateManagerWaterUserType();
                    _waterUserType = WaterUserTypeFactory.CreateDefaultWaterUserType();
                }
                return _waterUserType;
            }
            set
            {
                _waterUserType = value;
            }
        } private WaterUserType _waterUserType;
        #endregion //WaterUserType

        #region InDeviceCollection
        /// <summary>
        /// 
        /// </summary>
        public DeviceCollection InDeviceCollection
        {
            get
            {
                if (_inDeviceCollection == null)
                {
                    _inDeviceCollection = DeviceFactory.CreateInDeviceCollection(this.WaterUserID);
                }
                return _inDeviceCollection;
            }
            set
            {
                _inDeviceCollection = value;
            }
        } private DeviceCollection _inDeviceCollection;
        #endregion //InDeviceCollection

        #region OutDeviceCollection
        /// <summary>
        /// 
        /// </summary>
        public DeviceCollection OutDeviceCollection
        {
            get
            {
                if (_outDeviceCollection == null)
                {
                    _outDeviceCollection = DeviceFactory.CreateOutDeviceCollection(this.WaterUserID);
                }
                return _outDeviceCollection;
            }
            set
            {
                _outDeviceCollection = value;
            }
        } private DeviceCollection _outDeviceCollection;
        #endregion //OutDeviceCollection

        #region LowLevelWaterUserCollection
        /// <summary>
        /// 
        /// </summary>
        public WaterUserCollection LowLevelWaterUserCollection
        {
            get
            {
                if (_lowLevelWaterUserCollection == null)
                {
                    _lowLevelWaterUserCollection = WaterUserFactory.CreateLowLevelWaterUserCollection(this.WaterUserID);
                }
                return _lowLevelWaterUserCollection;
            }
        } private WaterUserCollection _lowLevelWaterUserCollection;
        #endregion //LowLevelWaterUserCollection

        #region Clear
        /// <summary>
        /// 
        /// </summary>
        internal void Clear()
        {
            // TODO:
            //
        }
        #endregion //Clear

        #region OutStationCollection
        /// <summary>
        /// 
        /// </summary>
        public StationCollection OutStationCollection
        {
            get
            {
                if (_outStationCollection == null)
                {
                    //_outStationCollection = new StationCollection();
                    return this.OutDeviceCollection.StationCollection;
                }
                return _outStationCollection;
            }
            set
            {
                _outStationCollection = value;
            }
        } private StationCollection _outStationCollection;
        #endregion //

        #region InStationCollection
        /// <summary>
        /// 
        /// </summary>
        public StationCollection InStationCollection
        {
            get
            {

                if (_inStationCollection == null)
                {
                    //_inStationCollection = new StationCollection();
                    return this.InDeviceCollection.StationCollection;
                }
                return _inStationCollection;
            }
            set
            {
                _inStationCollection = value;
            }
        }private StationCollection _inStationCollection;
        #endregion //

        #region IsAdd
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsAdd()
        {
            return this.WaterUserID == 0;
        }
        #endregion //IsAdd

        #region IsEdit
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsEdit()
        {
            return this.WaterUserID > 0;
        }
        #endregion //IsEdit

        #region GetParentID
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hasParent"></param>
        /// <param name="parentID"></param>
        private void GetParentID(out bool hasParent, out int parentID)
        {
            hasParent = this.ParentWaterUser != null;
            parentID = 0;
            if (this.ParentWaterUser != null)
            {
                parentID = this.ParentWaterUser.WaterUserID;
            }
        }
        #endregion //GetParentID

        #region Save
        /// <summary>
        /// 
        /// </summary>
        public void Save()
        {
            bool hasParent;
            int parentID;
            GetParentID(out hasParent, out parentID);

            if (IsAdd())
            {
                WaterUserDBI.InsertWaterUser(
                    this.Name,
                    this.Remark,
                    this.WaterUserType.WaterUserTypeID,
                    // TODO: parentwater is null
                    //
                    hasParent,
                    parentID,
                    this.WaterUserLevel.WaterUserLevelID);

                this.WaterUserID = WaterUserDBI.GetWaterUserID(this.Name);
            }
            else
            {
                WaterUserDBI.UpdateWaterUser(this.WaterUserID,
                    this.Name, 
                    this.Remark,
                    this.WaterUserType.WaterUserTypeID,
                    hasParent ,
                    parentID ,
                    //this.ParentWaterUser.WaterUserID,
                    this.WaterUserLevel.WaterUserLevelID);
            }
            // add wateruser channel map
            //
            int[] channelIDs = this.ChannelCollection.GetChannelIDs();
            WaterUserChannelMapDBI.Associate(WaterUserID, channelIDs);

            // add wateruser in device
            // 
            int[] inIDs = this.InDeviceCollection.GetDeviceIDs();
            WaterUserInDBI.AssociateWaterUserInDevice(this.WaterUserID, inIDs);

            // add wateruser out device
            //
            int[] outIDs = this.OutDeviceCollection.GetDeviceIDs();
            WaterUserOutDBI.AssociateWaterUserOutDevice(WaterUserID, outIDs);
        }
        #endregion //Save

        #region WaterUserClass
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static public WaterUserClass GetNoneWaterUserClass()
        {
            WaterUserClass w = new WaterUserClass(WaterUserLevel.GetNoneLevel());
            w.WaterUserID = 0;
            w.Name = "<无>";
            w.Remark = "";
            return w;
        }
        #endregion //WaterUserClass


        #region IsNoneWaterUser
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsNoneWaterUser()
        {
            return this.WaterUserID == 0;
        }
        #endregion //IsNoneWaterUser

        #region CalcUsedAmount
        /// <summary>
        /// 计算该用户的阶段用水量
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public double CalcUsedAmount(DateTime begin, DateTime end)
        {
            // 2011-05-24
            //

            double inAmount = this.InDeviceCollection.CalcUsedAmount(begin, end);
            double outAmount = this.OutDeviceCollection.CalcUsedAmount(begin, end);
            double amount = inAmount - outAmount;
            return amount;
        }
        #endregion //CalcUsedAmount

        #region GetNeedWaterDataTable
        /// <summary>
        /// 
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        public DataTable GetNeedWaterDataTable(DateTime begin, DateTime end)
        {
            return NeedWaterDBI.GetNeedWaterByWaterUser(this.WaterUserID, begin, end);
        }
        #endregion //GetNeedWaterDataTable

        #region GetDistributeWaterDataTable
        /// <summary>
        /// 获取用水户的配水信息
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <remarks>
        /// 由该用户的上级单位向其分配的水量信息
        /// </remarks>
        /// <returns></returns>
        public DataTable GetDistributeWaterDataTable(DateTime begin, DateTime end)
        {
            return DistributeDBI.GetDistributeDataTable(this.WaterUserID, begin, end);
        }
        #endregion //GetDistributeWaterDataTable

        #region GetNeedDistributeDataTable
        /// <summary>
        /// 
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public DataTable GetNeedDistributeDataTable(DateTime begin, DateTime end)
        {
            return new NeedDistributeCalculator(this, begin, end).Calc();
        }
        #endregion //GetNeedDistributeDataTable

        #region GetDitchDataLastDataTable
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable GetDitchDataLastDataTable()
        {
            int[] stationIDs = this.ChannelCollection.StationCollection.GetStationIDs();
            return DitchDataLastDBI.GetDitchDataLastDataTable(stationIDs);
        }
        #endregion //GetDitchDataLastDataTable

        #region GetDitchDataRealDataTable
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable GetDitchDataRealDataTable()
        {
            // 2011-6-17
            //
            int[] stationIDs = this.ChannelCollection.StationCollection.GetStationIDs();
            return DitchDataRealDBI.GetDitchDataRealDataTable(stationIDs);
        }
        #endregion //GetDitchDataRealDataTable

        #region GetDitchDataDayDataTable
        /// <summary>
        /// 获取日水位报表, 2小时每行
        /// </summary>
        /// <param name="day"></param>
        /// <returns></returns>
        public DataTable GetDitchDataDayDataTable(DateTime day)
        {
            DitchDataDayCreater d = new DitchDataDayCreater(this, day);
            return d.Create();
        }
        #endregion //GetDitchDataDayDataTable

        #region GetDitchDataHistoryDataTable
        /// <summary>
        /// 
        /// </summary>
        /// <param name="b"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public DataTable GetDitchDataHistoryDataTable(DateTime b, DateTime e)
        {
            int[] stationids = this.ChannelCollection.StationCollection.GetStationIDs();
            return DitchDataDBI.GetDataByStationIDs(b, e, stationids);
        }
        #endregion //GetDitchDataHistoryDataTable

        #region GetFeeDataTable
        /// <summary>
        /// 获取水费数据表
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public DataTable GetFeeDataTable(DateTime begin, DateTime end)
        {
            // TODO:
            //
            double price = this.UnitPrice;
            double usedAmount = this.InDeviceCollection.CalcUsedAmount(begin, end);
            double usedFee = price * usedAmount;
            double payedFee = this.GetPayFee(begin, end);
            double remaindFee = usedFee - payedFee;

            DataTable tbl = CreateFeeDataTable();
            AddFeeRow(tbl, this.Name, begin, end, price, usedAmount, usedFee, payedFee, remaindFee);
            return tbl;
        }
        #endregion //GetFeeDataTable

        #region GetPayFee
        /// <summary>
        /// 
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        private double GetPayFee(DateTime begin, DateTime end)
        {
             return FeeDBI.GetPayedFee(this.WaterUserID, begin, end);
        }
        #endregion //GetPayFee

        #region AddFeeRow
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tbl"></param>
        /// <param name="waterUserName"></param>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <param name="price"></param>
        /// <param name="usedAmount"></param>
        /// <param name="usedFee"></param>
        /// <param name="payedFee"></param>
        /// <param name="remaindFee"></param>
        private void AddFeeRow(DataTable tbl, string waterUserName, DateTime begin, DateTime end, 
            double price, double usedAmount, double usedFee, double payedFee, double remaindFee)
        {
            tbl.Rows.Add(waterUserName, begin, end, price, usedAmount, usedFee, payedFee, remaindFee);
        }
        #endregion //AddFeeRow

        #region CreateFeeDataTable
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private DataTable CreateFeeDataTable()
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("WaterUserName", typeof(string));
            tbl.Columns.Add("Begin", typeof(DateTime));
            tbl.Columns.Add("End", typeof(DateTime));
            tbl.Columns.Add("Price", typeof(double));
            tbl.Columns.Add("UsedAmount", typeof(double));
            tbl.Columns.Add("UsedFee", typeof(double));
            tbl.Columns.Add("payedFee", typeof(double));
            tbl.Columns.Add("remaindFee", typeof(double));

            return tbl;
        }
        #endregion //CreateFeeDataTable

        #region RainStationCollection
        public StationCollection RainStationCollection
        {
            get 
            {
                if (_rainStationCollection == null)
                {
                    _rainStationCollection = StationFactory.CreateRainStationCollection();

                }
                return _rainStationCollection;
            }
        } private StationCollection _rainStationCollection;
        #endregion //RainStationCollection

    }

    #region DitchDataDayCreater
    /// <summary>
    /// 
    /// </summary>
    internal class DitchDataDayCreater
    {
        WaterUserClass _w;
        DateTime _day;
        public DitchDataDayCreater(WaterUserClass w, DateTime day)
        {
            _w = w;
            _day = day;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable Create()
        {
            DataTable r = Create2HourDataTable();
            DateTime b = _day.Date;
            DateTime e = _day.Date + TimeSpan.FromDays(1d);

            DataTable org = _w.GetDitchDataHistoryDataTable(b, e);

            for (int i = 0; i < 12; i++)
            {
                DateTime bh = b + TimeSpan.FromMilliseconds(this.GetSetpMillisecond() * i);
                DateTime eh = b + TimeSpan.FromMilliseconds(this.GetSetpMillisecond() * (i + 1));

                string filter = string.Format("DT >= '{0}' and dt < '{1}' ", bh, eh);
                DataRow[] rows = org.Select(filter);

                //foreach ( 
                Calc(bh, rows, i, r);
            }
            // add avg row
            //
            AddAVGRow(r);
            return r;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="r"></param>
        private void AddAVGRow(DataTable r)
        {
            //ArrayList list = new ArrayList();
            //list.Add("平均");

            //for (int i = 1; i < r.Columns.Count; i++)
            //{
            //    string c = r.Columns[i].ColumnName;
            //    string s = string.Format("avg({0})", c);

            //    object obj = r.Compute(s, string.Empty);
            //    list.Add(obj);
            //}

            //r.Rows.Add(list.ToArray());
            DataTableHelper.AddAvgRow(r, 1, new object[] { "平均" });
        }

        /// <summary>
        /// return station -> avgwl map
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="rows"></param>
        void Calc(DateTime dt, DataRow[] rows, int resultIndex, DataTable r)
        {
            Hashtable wlH = new Hashtable();
            foreach (DataRow row in rows)
            {
                string stname = row[DBNames.vDitchData.StationName].ToString();
                double wl = Convert.ToDouble(row[DBNames.vDitchData.WL1]);
                double flux = Convert.ToDouble(row[DBNames.vDitchData.InstantFlux]);

                if (wlH[stname] == null)
                {
                    wlH[stname] = wl;
                }
                else
                {
                    double oldwl = (double)wlH[stname];
                    double newwl = (oldwl + wl )/ 2d;
                    wlH[stname] = newwl;
                }
            }


            foreach ( string stname in wlH.Keys )
            {
                double wl = (double)wlH[stname];
                r.Rows[resultIndex][stname] = (int)wl;
            }
            //return wlH;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        DataTable Create2HourDataTable()
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("时间", typeof(string));
            foreach ( StationClass st in _w.ChannelCollection.StationCollection )
            {
                DataColumn c = tbl.Columns.Add(st.StationName, typeof(int));
                c.DefaultValue = 0;
            }

            int stepMillisecond = //(int)(TimeSpan.FromDays(1d).TotalMilliseconds / 12);
                GetSetpMillisecond();
            for (int i = 0; i < 12; i++)
            {
                DataRow row = tbl.NewRow();
                TimeSpan ts = TimeSpan.FromMilliseconds(stepMillisecond * i);
                row[0] = string.Format("{0:00}:00", ts.TotalHours);
                tbl.Rows.Add(row);
            }
            
            return tbl;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        int GetSetpMillisecond()
        {
            int stepMillisecond = (int)(TimeSpan.FromDays(1d).TotalMilliseconds / 12);
            return stepMillisecond;
        }
    }
        
    #endregion //


    #region NeedDistributeCalculator Class
    /// <summary>
    /// 
    /// </summary>
    internal class NeedDistributeCalculator
    {
        WaterUserClass _w;
        DateTime _b, _e;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="w"></param>
        /// <param name="b"></param>
        /// <param name="e"></param>
        internal NeedDistributeCalculator(WaterUserClass w, DateTime b, DateTime e)
        {
            _w = w;
            _b = b; 
            _e = e;
        }

        private DataTable CreateResultDataTable()
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("WaterUserName", typeof(string));
            tbl.Columns.Add("NeedBegin", typeof(DateTime));
            tbl.Columns.Add("NeedEnd", typeof(DateTime));
            tbl.Columns.Add("NeedAmount", typeof(int));
            tbl.Columns.Add("DistributeAmount", typeof(int));
            tbl.Columns.Add("UsedAmount", typeof(int));

            //tbl.Columns.Add("", typeof());

            return tbl;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal DataTable Calc()
        {
            DataTable r = CreateResultDataTable ();

            // 1. get current wateruer need
            //
            DataTable needTbl = _w.GetNeedWaterDataTable(_b,_e);

            // 2. get distrabute table mapped to need
            // 
            DataTable distributeTbl = _w.GetDistributeWaterDataTable(_b, _e);

            // 3. get used water mapped to need
            //
            foreach (DataRow needrow in needTbl.Rows )
            {
                int needID = Convert.ToInt32(needrow[DBNames.tblNeedWater.NeedWaterID]);
                DateTime needBegin = Convert.ToDateTime (needrow[DBNames.tblNeedWater.NeedBeginDT]);
                DateTime needEnd= Convert.ToDateTime (needrow[DBNames.tblNeedWater.NeedEndDT]);
                int needAmount = Convert.ToInt32(needrow[DBNames.tblNeedWater.NeedAmount]);

                int disAmountTotal = 0;
                string s = string.Format("{0}={1}", DBNames.tblDistributeWater.NeedWaterID, needID);
                DataRow[] distributeRows = distributeTbl.Select(s);
                foreach (DataRow disRow in distributeRows)
                {
                    int disAmount = Convert.ToInt32(disRow[DBNames.tblDistributeWater.DistributeAmount]);
                    disAmountTotal += disAmount;
                }

                int usedAmount =(int) _w.CalcUsedAmount(needBegin, needEnd);

                // add result row
                //
                DataRow newrow = r.NewRow();
                newrow["WaterUserName"] = _w.Name;
                newrow["NeedBegin"] = needBegin;
                newrow["NeedEnd"] = needEnd;
                newrow["NeedAmount"] = needAmount;
                newrow["DistributeAmount"] = disAmountTotal;
                newrow["UsedAmount"] = usedAmount;
                r.Rows.Add(newrow);

            }

            return r; 
        }
    }
    #endregion //NeedDistributeCalculator 
}
