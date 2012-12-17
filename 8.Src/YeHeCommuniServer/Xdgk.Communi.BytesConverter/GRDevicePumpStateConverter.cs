using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Communi.Interface;
using System.Diagnostics;

namespace Xdgk.Communi
{
    /// <summary>
    /// XD-100 pump state converter
    /// </summary>
    public class GRDevicePumpStateConverter : BytesConverter 
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="state"></param>
        /// <param name="bitIndex"></param>
        /// <returns></returns>
        static private PumpStateEnum GetPumpStateEnum( byte state, int bitIndex )
        {
            byte mask = (byte)Math.Pow( 2, bitIndex );
            int r = mask & state;
            if ( r > 0 )
                return PumpStateEnum.Run;
            else
                return PumpStateEnum.Stop;
        }

        #region IBytesConverter 成员
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        override public object ConvertToObject(byte[] bytes)
        {
            byte b = bytes[0];

            PumpStateCollection pss = new PumpStateCollection();
            PumpState ps = new PumpState(PumpTypeEnum.CyclePump, 1, GetPumpStateEnum(b, 0));
            pss.Add(ps);

            ps = new PumpState(PumpTypeEnum.CyclePump,2,GetPumpStateEnum(b,1));
            pss.Add(ps);

            ps = new PumpState(PumpTypeEnum.CyclePump,3,GetPumpStateEnum(b,2));
            pss.Add(ps);

            ps = new PumpState(PumpTypeEnum.RecruitPump,1,GetPumpStateEnum(b,3));
            pss.Add(ps);

            ps = new PumpState(PumpTypeEnum.RecruitPump,2,GetPumpStateEnum(b,4));
            pss.Add(ps);

            return pss;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ps"></param>
        /// <returns></returns>
        int GetIndex(PumpState ps)
        {
            // cycle NO - idx
            // 1 - 0
            // 2 - 1
            // 3 - 2

            // recruit NO - idx
            // 1 - 3
            // 2 - 4
            if (ps.PumpTypeEnum == PumpTypeEnum.CyclePump)
            {
                Debug.Assert(ps.PumpNO >= 1 && ps.PumpNO <= 3, 
                    "cyclepump NO must in [1, 3] : " + ps.PumpNO);
                return ps.PumpNO - 1;
            }
            if (ps.PumpTypeEnum == PumpTypeEnum.RecruitPump)
            {
                Debug.Assert(ps.PumpNO >= 1 && ps.PumpNO <= 2, 
                    "recruitpump NO must in [1, 2] : " + ps.PumpNO);
                return ps.PumpNO + 2;
            }
            throw new ArgumentException("invalid pumpstate: " + ps.PumpTypeEnum + " " + ps.PumpNO);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ps"></param>
        /// <returns></returns>
        private byte GetValue(PumpState ps)
        {
            return (byte)System.Math.Pow(2, GetIndex(ps));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        override public byte[] ConvertToBytes(object obj)
        {
            byte b = 0;
            PumpStateCollection pss = obj as PumpStateCollection;
            foreach (PumpState ps in pss)
            {
                b |= GetValue(ps);
            }
            //throw new NotImplementedException();
            return new byte[] { b };
        }
        #endregion
    }
}
