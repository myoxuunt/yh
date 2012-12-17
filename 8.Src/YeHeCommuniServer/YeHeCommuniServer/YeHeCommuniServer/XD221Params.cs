using System;
using System.Collections.Generic;
using System.Text;

namespace YeHeCommuniServer
{
    /// <summary>
    /// 
    /// </summary>
    public class XD221Params
    {
        #region BaudRate
        /// <summary>
        /// 
        /// </summary>
        public int BaudRate
        {
            get { return _baudRate; }
            set { _baudRate = value; }
        } private int _baudRate;
        #endregion //BaudRate

        #region EchelonBottomWidth
        /// <summary>
        /// 
        /// </summary>
        public int EchelonBottomWidth
        {
            get { return _echelonBottomWidth; }
            set { _echelonBottomWidth = value; }
        } private int _echelonBottomWidth;
        #endregion //EchelonBottomWidth

        #region RectangleWidth
        /// <summary>
        /// 
        /// </summary>
        public int RectangleWidth
        {
            get { return _rectangleWidth; }
            set { _rectangleWidth = value; }
        } private int _rectangleWidth;
        #endregion //RectangleWidth

        #region RectangleTotalWidth
        /// <summary>
        /// 
        /// </summary>
        public int RectangleTotalWidth
        {
            get { return _rectangleTotalWidth; }
            set { _rectangleTotalWidth = value; }
        } private int _rectangleTotalWidth;
        #endregion //RectangleTotalWidth

        #region RectangleHeight
        /// <summary>
        /// 
        /// </summary>
        public int RectangleHeight
        {
            get { return _rectangleHeight; }
            set { _rectangleHeight = value; }
        } private int _rectangleHeight;
        #endregion //RectangleHeight

        #region ParshallWidth
        /// <summary>
        /// 
        /// </summary>
        public int ParshallWidth
        {
            get { return _parshallWidth; }
            set { _parshallWidth = value; }
        } private int _parshallWidth;
        #endregion //ParshallWidth

        #region CutthroatMinWidth
        /// <summary>
        /// 
        /// </summary>
        public int CutthroatMinWidth
        {
            get { return _cutthroatMinWidth; }
            set { _cutthroatMinWidth = value; }
        } private int _cutthroatMinWidth;
        #endregion //CutthroatMinWidth

        #region CutthroatLength
        /// <summary>
        /// 
        /// </summary>
        public int CutthroatLength
        {
            get { return _cutthroatLength; }
            set { _cutthroatLength = value; }
        } private int _cutthroatLength;
        #endregion //CutthroatLength

        #region OpenChannelBottomWidth
        /// <summary>
        /// 
        /// </summary>
        public int OpenChannelBottomWidth
        {
            get { return _openChannelBottomWidth; }
            set { _openChannelBottomWidth = value; }
        } private int _openChannelBottomWidth;
        #endregion //OpenChannelBottomWidth

        #region OpenChannelBottomSlope
        /// <summary>
        /// 
        /// </summary>
        public int OpenChannelBottomSlope
        {
            get { return _openChannelBottomSlope; }
            set { _openChannelBottomSlope = value; }
        } private int _openChannelBottomSlope;
        #endregion //OpenChannelBottomSlope

        #region OpenChannelCoarseRate
        /// <summary>
        /// 
        /// </summary>
        public int OpenChannelCoarseRate
        {
            get { return _openChannelCoarseRate; }
            set { _openChannelCoarseRate = value; }
        } private int _openChannelCoarseRate;
        #endregion //OpenChannelCoarseRate

        #region OpenChannelBorderModulus
        /// <summary>
        /// 
        /// </summary>
        public int OpenChannelBorderModulus
        {
            get { return _openChannelBorderModulus; }
            set { _openChannelBorderModulus = value; }
        } private int _openChannelBorderModulus;
        #endregion //OpenChannelBorderModulus

        #region K
        /// <summary>
        /// 
        /// </summary>
        public int K
        {
            get { return _k; }
            set { _k = value; }
        } private int _k;
        #endregion //K

        #region B
        /// <summary>
        /// 
        /// </summary>
        public int B
        {
            get { return _b; }
            set { _b = value; }
        } private int _b;
        #endregion //B

        #region PulseModulus
        /// <summary>
        /// 
        /// </summary>
        public int PulseModulus
        {
            get { return _pulseModulus; }
            set { _pulseModulus = value; }
        } private int _pulseModulus;
        #endregion //PulseModulus

        #region PulseSensitivity1
        /// <summary>
        /// 
        /// </summary>
        public int PulseSensitivity1
        {
            get { return _pulseSensitivity; }
            set { _pulseSensitivity = value; }
        } private int _pulseSensitivity;
        #endregion //PulseSensitivity1
    }
}
