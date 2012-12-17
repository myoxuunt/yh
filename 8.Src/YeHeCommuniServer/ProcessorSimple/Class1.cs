using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Communi;
using Xdgk.Communi.Processor;

namespace ProcessorSimple
{
    public class Simple : ParseResultProcessorBase
    {

        public Simple()
            : base("aaa1lll", "bbb1", "ccc1")
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="communiSoft"></param>
        /// <param name="pr"></param>
        public override void ProcessParseResult(Xdgk.Communi.CommuniSoft communiSoft, Xdgk.Communi.ParseResult pr)
        {
            System.Diagnostics.Debug.Fail("from simple");
            //throw new NotImplementedException();
        }
    }

    public class Simple1 : ParseResultProcessorBase
    {

        public Simple1()
            : base("1", "1", "1")
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="communiSoft"></param>
        /// <param name="pr"></param>
        public override void ProcessParseResult(Xdgk.Communi.CommuniSoft communiSoft, Xdgk.Communi.ParseResult pr)
        {
            System.Diagnostics.Debug.Fail("from simple 11");
            //throw new NotImplementedException();
        }
    }
}
