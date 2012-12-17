using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using Xdgk.Communi.Interface;

namespace Xdgk.Communi
{
    public class CardSNConverter : BytesConverter 
    {
        private const int CARD_ID_DATA_LENGTH = 8;

        #region IBytesConverter 成员

        override public object ConvertToObject(byte[] bytes)
        {
            Debug.Assert( bytes.Length == CARD_ID_DATA_LENGTH );
            string sCardId = string.Empty;
            for (int i=0; i<bytes.Length; i++)
            {
                sCardId += bytes[i].ToString("X2");
            }
            return sCardId;
        }

        override public byte[] ConvertToBytes(object obj)
        {
            throw new NotFiniteNumberException("CardSNConverter.ConvertToBytes");
        }

        #endregion
    }
}
        //private static string MakeCardId( byte[] datas )
        //{
        //}