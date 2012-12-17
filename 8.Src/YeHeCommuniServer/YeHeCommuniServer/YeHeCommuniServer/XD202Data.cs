using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Communi;

namespace YeHeCommuniServer
{
    /// <summary>
    /// 
    /// </summary>
    public class XD202Data : IData 
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="height"></param>
        /// <param name="beforeWaterLevel"></param>
        /// <param name="behindWaterLevel"></param>
        public XD202Data(int instantFlux, int remainAmount, int height, int beforeWaterLevel, int behindWaterLevel)
        {
            this.DT = DateTime.Now;
            this.InstantFlux = instantFlux;
            this.RemainAmount = remainAmount;
            this.Height = height;
            this.BeforeWaterLevel = beforeWaterLevel;
            this.BehindWaterLevel = behindWaterLevel;
        }

        #region InstantFlux
        /// <summary>
        /// 获取或设置瞬时流量(m3 / h)
        /// </summary>
        public int InstantFlux
        {
            get { return _instantFlux; }
            set { _instantFlux = value; }
        } private int _instantFlux;
        #endregion //InstantFlux

        #region RemainAmount
        /// <summary>
        /// 获取或设置剩余水量(m3)
        /// </summary>
        public int RemainAmount
        {
            get { return _remainAmount; }
            set { _remainAmount = value; }
        } private int _remainAmount;
        #endregion //RemainAmount

        #region Height
        /// <summary>
        /// 获取或设置闸门高度(cm)
        /// </summary>
        public int Height
        {
            get { return _height; }
            set { _height = value; }
        } private int _height;
        #endregion //Height

        #region BeforeWaterLevel
        /// <summary>
        /// 获取或设置闸前水位(cm)
        /// </summary>
        public int BeforeWaterLevel
        {
            get { return _beforeWaterLevel; }
            set { _beforeWaterLevel = value; }
        } private int _beforeWaterLevel;
        #endregion //BeforeWaterLevel

        #region BehindWaterLevel
        /// <summary>
        /// 获取或设置闸后水位(cm)
        /// </summary>
        public int BehindWaterLevel
        {
            get { return _behindWaterLevel; }
            set { _behindWaterLevel = value; }
        } private int _behindWaterLevel;
        #endregion //BehindWaterLevel


        #region IData 成员
        /// <summary>
        /// 
        /// </summary>
        public DateTime DT
        {
            get
            {
                return _dt;
            }
            set
            {
                _dt = value;
            }
        } private DateTime _dt;

        #endregion
    }
}
