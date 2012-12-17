using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Communi.Interface;
using Xdgk.Communi;
using Xdgk.Common;

namespace Xdgk.Communi.Processor
{
    /// <summary>
    /// 
    /// </summary>
    public interface IParseResultProcessor
    {
        /// <summary>
        /// 
        /// </summary>
        string Name { get; }

        /// <summary>
        /// 
        /// </summary>
        string FromStation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        string FromDevice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        int FromAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        string FromOpera { get; set; }

        /// <summary>
        /// 
        /// </summary>
        string Description { get; }

        /// <summary>
        /// 
        /// </summary>
        string ForDevice { get; }

        /// <summary>
        /// 
        /// </summary>
        string FromReceivePart { get; set; }


        /// <summary>
        /// 
        /// </summary>
        DBIBase DBIBase { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pr"></param>
        void ProcessParseResult(CommuniSoft communiSoft, Xdgk.Communi.ParseResult pr);
    }

}
