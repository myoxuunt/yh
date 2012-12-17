using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NUnit.Core;

namespace Xdgk.Comm.Test
{
    [TestFixture]
    public class Class1
    {

        [Test]
        public void t1()
        {
            Console.WriteLine(InternalTraceWriter.LogDirectory);
        }
    }
}
