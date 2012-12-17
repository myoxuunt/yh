using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Communi;
using Xdgk.Common;

namespace YeHeCommuniServer
{
    /// <summary>
    /// 
    /// </summary>
    public class XD221Processor
    {
        /// <summary>
        /// 
        /// </summary>
        static public XD221Processor Defalut
        {
            get
            {
                if(_default == null)
                    _default = new XD221Processor();
                return _default;
            }
        } static private XD221Processor _default;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="task"></param>
        /// <param name="pr"></param>
        public void ProcessExecutedTask(Task task, ParseResult pr)
        {
            if (StringHelper.Equal(task.Opera.Name, OperaNames.ReadReal))
            {

                //
                // 功能码：     0x10
                // 数据数：     0位
                // 成功后返回： 0x21＋0x58＋0x44＋地址＋0x80＋功能码＋0x12＋日期＋时间＋已用水量＋瞬时流量＋闸前水位＋闸后水位＋CRC16

                // 日期（3字节BCD码 年＋月＋日）
                // 时间（3字节BCD码 时＋分＋秒）
                // 已用水量（4字节）（无符号整型）带一位小数点	m3          <b>
                // 瞬时流量（4字节）（无符号整型）带一位小数点	m3/h        <c>
                // 闸前水位（2字节）带两位小数点  m                         <a>
                // 闸后水位（2字节）带两位小数点  m
                //
                // 供电电压 (2Byte) 两位小数点                              <d>

                // 水位, 单位CM, <a>
                //
                int wl1 = (Int16)pr.NameObjects.GetObject("WL1");
                int wl2 = (Int16)pr.NameObjects.GetObject("WL2");
                uint instantFlux = (UInt32)pr.NameObjects.GetObject("IF");
                uint usedAmount = (uint)pr.NameObjects.GetObject("usedAmount");

                object objTemp = pr.NameObjects.GetObject("voltage");
                int voltage = Convert.ToInt32(objTemp);

                // <c>
                //
                instantFlux = (uint)(instantFlux / 10);
                // <b>
                //
                usedAmount = (uint)(usedAmount / 10);

                // <d>
                //
                voltage = voltage / 100;

                if (Config.Default.IsUseFluxFormula)
                {
                    instantFlux = (uint)YeHeCommuniServerApp.Default.DevieFormaulCollectionMapCollection.CalcInstantFlux(
                        task.Device.ID, DateTime.Now, wl1, wl2);
                }

                DitchDevice ditchDevice = task.Device as DitchDevice;
                ditchDevice.DitchData = new DitchData(wl1, wl2, instantFlux, usedAmount, voltage);
                DB.DitchDataDBI.Insert(ditchDevice, DateTime.Now, instantFlux, wl1, wl2, usedAmount, voltage);
            }

            //if (StringHelper.Equal(task.Opera.Name, OperaNames.ReadParams))
            //{
            //    XD221Params p = ProcessParams(pr);
            //    XD221Device xd221Device = task.Device as XD221Device;
            //    xd221Device.Xd221Params = p;
            //}
        }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="pr"></param>
        //private XD221Params ProcessParams(ParseResult pr)
        //{
        //    XD221Params p = new XD221Params();
        //    p.BaudRate = (byte)pr.NameObjects.GetObject("BaudRate");
        //    p.K = (Int16)pr.NameObjects.GetObject("K");
        //    p.B = Convert.ToInt16(pr.NameObjects.GetObject("B"));

        //    // TODO: get xd221 params
        //    //
        //    p.CutthroatLength = Convert.ToInt32(pr.NameObjects.GetObject("CutthroatLength"));
        //    p.CutthroatMinWidth = Convert.ToInt32(pr.NameObjects.GetObject("CutthroatMinWidth"));
        //    p.EchelonBottomWidth = Convert.ToInt32(pr.NameObjects.GetObject("EchelonBottomWidth"));
        //    p.OpenChannelBorderModulus = Convert.ToInt32(pr.NameObjects.GetObject("OpenChannelBorderModulus"));
        //    p.OpenChannelBottomSlope = Convert.ToInt32(pr.NameObjects.GetObject("OpenChannelBottomSlope"));
        //    p.OpenChannelBottomWidth = Convert.ToInt32(pr.NameObjects.GetObject("OpenChannelBottomWidth"));
        //    p.OpenChannelCoarseRate = Convert.ToInt32(pr.NameObjects.GetObject("OpenChannelCoarseRate"));
        //    p.ParshallWidth = Convert.ToInt32(pr.NameObjects.GetObject("ParshallWidth"));
        //    p.PulseModulus = Convert.ToInt32(pr.NameObjects.GetObject("PulseModulus"));
        //    p.PulseSensitivity1 = Convert.ToInt32(pr.NameObjects.GetObject("PulseSensitivity1"));
        //    p.RectangleHeight = Convert.ToInt32(pr.NameObjects.GetObject("RectangleHeight"));
        //    p.RectangleTotalWidth = Convert.ToInt32(pr.NameObjects.GetObject("RectangleTotalWidth"));
        //    p.RectangleWidth = Convert.ToInt32(pr.NameObjects.GetObject("RectangleWidth"));
        //    return p;
        //}
    }
}
