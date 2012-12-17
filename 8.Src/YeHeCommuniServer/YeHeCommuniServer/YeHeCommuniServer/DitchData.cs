using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Communi;
using System.Diagnostics;

namespace YeHeCommuniServer
{
    /// <summary>
    /// 
    /// </summary>
    public class DitchData : IData 
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="wl1"></param>
        /// <param name="wl2"></param>
        /// <param name="instantFlux"></param>
        /// <param name="usedAmount"></param>
        /// <param name="voltage"></param>
        public DitchData(int wl1, int wl2, uint instantFlux, uint usedAmount, int voltage)
            : this(DateTime.Now, wl1, wl2, instantFlux, usedAmount, voltage)
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        public DitchData(DateTime dt, int wl1, int wl2,  float instantFlux, uint usedAmount, 
            int voltage)
        {
            this.DT = dt;
            this.WL1 = wl1;
            this.WL2 = wl2;
            this.InstantFlux = instantFlux;
            this.UsedAmount = usedAmount;
            this.Voltage = voltage;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cache"></param>
        public DitchData(DitchDataCache cache)
        {
            Debug.Assert(cache.IsComplete());

            this.DT = cache.WLDT;
            this.WL1 = cache.WL1;
            this.WL2 = cache.WL2;
            this.InstantFlux = cache.InstantFlux;
            this.UsedAmount = cache.UsedAmount;
            this.Voltage = cache.Voltage;
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

        #region DT
        /// <summary>
        /// 
        /// </summary>
        public DateTime DT
        {
            get { return _DT; }
            set { _DT = value; }
        } private DateTime _DT;
        #endregion //DT

        #region Voltage
        /// <summary>
        /// 
        /// </summary>
        public int Voltage
        {
            get { return _voltage; }
            set { _voltage = value; }
        } private int _voltage;
        #endregion //Voltage

    }
}
