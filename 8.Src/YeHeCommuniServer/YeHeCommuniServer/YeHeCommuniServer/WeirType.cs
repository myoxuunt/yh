using System;
using System.Collections.Generic;
using System.Text;

namespace YeHeCommuniServer
{
    /// <summary>
    /// 
    /// </summary>
    public class WeirType
    {
        private const int MINVALUE = 0;
        private const int MAXVALUE = 6;

        static readonly public WeirType Echelon = new WeirType(0, WaterStrings.Echelon);
        static readonly public WeirType Rectangle = new WeirType(1, WaterStrings.Rectangle);
        static readonly public WeirType Parshall = new WeirType(2, WaterStrings.Parshall);
        static readonly public WeirType Cutthroat = new WeirType(3, WaterStrings.Cutthroat);
        static readonly public WeirType OpenChannel = new WeirType(4, WaterStrings.OpenChannel);
        static readonly public WeirType MonoPulse = new WeirType(5, WaterStrings.MonoPulse);
        static readonly public WeirType DiPulse = new WeirType(6, WaterStrings.MonoPulse);


        /// <summary>
        /// 
        /// </summary>
        private WeirType(byte value, string text)
        {
            this.Value = value;
            this.Text = text;
        }

        #region Value
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 取值范围0～6　
        /// “0” 代表梯形堰，
        /// “1” 代表矩形堰，
        /// “2” 代表巴歇尔槽，
        /// “3” 代表无喉道槽，
        /// “4” 代表明渠流量检测，
        /// “5” 代表单脉冲型脉冲信号
        /// </remarks>
        public byte Value
        {
            get { return _value; }
            private set 
            {
                if (value >= MINVALUE  && value <= MAXVALUE )
                {
                    _value = value;
                }
                else
                {
                    string s = string.Format("WeirType value must in [{0}, {1}]", MINVALUE, MAXVALUE);
                    throw new ArgumentOutOfRangeException(s);
                }
            }
        } private byte _value;
        #endregion //Value

        #region Text
        /// <summary>
        /// 
        /// </summary>
        public string Text
        {
            get { return _text; }
            private set { _text = value; }
        } private string _text;
        #endregion //Text

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        static public Boolean IsValidValue(byte value)
        {
            return value >= MINVALUE && value <= MAXVALUE;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        static public WeirType GetWeirTypeByValue(byte value)
        {
            if (value >= MINVALUE && value <= MAXVALUE)
            {
                return WeirTypes[value];
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        static private WeirType[] WeirTypes
        {
            get {
                if (_weirTypes == null)
                {
                    _weirTypes = new WeirType[] { 
                        Echelon, Rectangle, Parshall, Cutthroat, 
                        OpenChannel, MonoPulse, DiPulse };
                }
                return _weirTypes;
            }
        } static private WeirType[] _weirTypes;
    }
}
