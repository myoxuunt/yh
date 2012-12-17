using System;
using System.Collections.Generic;
using System.Text;

namespace YeHeCommuniServer
{
    /// <summary>
    /// 
    /// </summary>
    public class DitchDataCache
    {
        /// <summary>
        /// 
        /// </summary>
        public DitchDataCache()
        {
            Clear();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Clear()
        {
            this.WLDT = DateTime.MinValue;
            this.UsedAmountDT = DateTime.MinValue;
            this.WL1 = 0;
            this.WL2 = 0;
            this.InstantFlux = 0;
            this.UsedAmount = 0;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsComplete()
        {
            if ((WLDT != DateTime.MinValue) && (UsedAmountDT != DateTime.MinValue))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="usedAmount"></param>
        public void SetUsedAmount(uint usedAmount)
        {
            _usedAmount = usedAmount;
            _usedAmountDT = DateTime.Now;
        }

        /// <summary>
        /// 设置水位, 瞬时流量, 电压
        /// </summary>
        public void SetWLInstantFlux(int wl1, int wl2, uint instantFlux, int voltage)
        {
            _wL1 = wl1;
            _wL2 = wl2;
            _instantFlux = instantFlux;
            _wlDT = DateTime.Now;
            this._voltage = voltage;
        }

        #region WL1
        /// <summary>
        /// 
        /// </summary>
        public int WL1
        {
            get { return _wL1; }
            set { _wL1 = value; }
        } private int _wL1;
        #endregion //WL1

        #region WL2
        /// <summary>
        /// 
        /// </summary>
        public int WL2
        {
            get { return _wL2; }
            set { _wL2 = value; }
        } private int _wL2;
        #endregion //WL2

        #region InstantFlux
        /// <summary>
        /// 
        /// </summary>
        public float InstantFlux
        {
            get { return _instantFlux; }
            set { _instantFlux = value; }
        } private float _instantFlux;
        #endregion //InstantFlux

        #region UsedAmount
        /// <summary>
        /// 
        /// </summary>
        public uint UsedAmount
        {
            get { return _usedAmount; }
            set { _usedAmount = value; }
        } private uint _usedAmount;
        #endregion //UsedAmount

        #region UsedAmountDT
        /// <summary>
        /// 
        /// </summary>
        public DateTime UsedAmountDT
        {
            get { return _usedAmountDT; }
            set { _usedAmountDT = value; }
        } private DateTime _usedAmountDT;
        #endregion //UsedAmountDT

        #region WLDT
        /// <summary>
        /// 
        /// </summary>
        public DateTime WLDT
        {
            get { return _wlDT; }
            set { _wlDT = value; }
        } private DateTime _wlDT;
        #endregion //WLDT

        #region Voltage
        /// <summary>
        /// 
        /// </summary>
        public int Voltage
        {
            get { return _voltage; }
            set { _voltage = value; }
        } private int _voltage;
        #endregion //
    }
}
