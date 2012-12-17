using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Communi.Interface;
using System.Diagnostics;

namespace Xdgk.Communi
{



    /// <summary>
    /// 
    /// </summary>
    public class XGDateTimeConverter : BytesConverter 
    {
        #region IBytesConverter 成员

            private const int YEAR_POS = 7,
            MONTH_POS   = 6,
            DAY_POS     = 5,
            HOUR_POS    = 4,
            MINUTE_POS  = 3,
            SECOND_POS  = 2,
            CARD_ID_BEGIN_POS   = 8,
            CARD_ID_DATA_LENGTH = 8;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        override public object ConvertToObject(byte[] bytes)
        {
            if (bytes == null)
                throw new ArgumentNullException("bytes");

            if (bytes.Length < 8)
                throw new ArgumentException("xgdatatime bytes length must >= 8");

            //BCDConverter c = new BCDConverter();
            int year   = (int)BCDConverter.BCDToDEC( bytes[ YEAR_POS   ] );
            int month  = (int)BCDConverter.BCDToDEC( bytes[ MONTH_POS  ] );
            int day    = (int)BCDConverter.BCDToDEC( bytes[ DAY_POS    ] );
            int hour   = (int)BCDConverter.BCDToDEC( bytes[ HOUR_POS   ] );
            int minute = (int)BCDConverter.BCDToDEC( bytes[ MINUTE_POS ] );
            int second = (int)BCDConverter.BCDToDEC( bytes[ SECOND_POS ] );
            year += 2000;
            return new DateTime(year, month, day, hour, minute, second);

            //byte[] cardIdDatas = new byte[ CARD_ID_DATA_LENGTH ];
            //Array.Copy( datas, CARD_ID_BEGIN_POS, cardIdDatas, 0, CARD_ID_DATA_LENGTH );
            //string cardId = MakeCardId( cardIdDatas );
            //return new Record( year, month, day, hour, minute, second, cardId );
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        override public byte[] ConvertToBytes(object obj)
        {
            BCDConverter c = new BCDConverter();
            DateTime dt = Convert.ToDateTime(obj);
            byte[] bs = new byte[8];
            int y = dt.Year % 100;
            bs[YEAR_POS]    = (byte)BCDConverter.DECToBCD(y);
            bs[MONTH_POS]   = (byte)BCDConverter.DECToBCD(dt.Month);
            bs[DAY_POS]     = (byte)BCDConverter.DECToBCD(dt.Day);
            bs[HOUR_POS]    = (byte)BCDConverter.DECToBCD(dt.Hour);
            bs[MINUTE_POS]  = (byte)BCDConverter.DECToBCD(dt.Minute);
            bs[SECOND_POS ] = (byte)BCDConverter.DECToBCD(dt.Second);
            return bs;
        }

        #endregion
    }
}
