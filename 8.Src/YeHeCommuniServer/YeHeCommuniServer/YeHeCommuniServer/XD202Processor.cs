using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Communi;

namespace YeHeCommuniServer
{
    /// <summary>
    /// 
    /// </summary>
    public class XD202Processor
    {
        /// <summary>
        /// 
        /// </summary>
        static public XD202Processor Default
        {
            get
            {
                if (s_default == null)
                {
                    s_default = new XD202Processor();
                }
                return s_default;
            }
        } static private XD202Processor s_default;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="task"></param>
        /// <param name="pr"></param>
        public void ProcessExecutedTask(Task task, ParseResult pr)
        {
            int instantFlux = Convert.ToInt32(pr.NameObjects.GetObject("IF"));
            int remainAmount = Convert.ToInt32(pr.NameObjects.GetObject("RemainAmount"));
            int beforeWL = Convert.ToInt32(pr.NameObjects.GetObject ("WL1"));
            int behindWL = Convert.ToInt32(pr.NameObjects.GetObject("WL2"));
            int height = Convert.ToInt32(pr.NameObjects.GetObject("Height"));

            XD202Data data = new XD202Data(instantFlux, remainAmount, height, beforeWL, behindWL);
            XD202Device d = task.Device as XD202Device;
            d.XD202Data = data;


            // TODO:
            //
            DB.MeasureSluiceData.Insert(d, data);
        }
    }
}
