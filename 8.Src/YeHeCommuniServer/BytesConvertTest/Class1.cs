using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Communi;
using NUnit.Framework;

namespace BytesConvertTest
{
    public class Class1
    {
        [Test]
        public void UInt32ModbusTest()
        {
            UInt32ModbusConverter c = new UInt32ModbusConverter();
            byte[] bs = c.ConvertToBytes(0x0102);
            string s = BitConverter.ToString(bs);
            Console.WriteLine(s);
            UInt32 u = (UInt32) c.ConvertToObject(bs);

            Assert.AreEqual(0x0102, u);


            byte[] bs1 = new byte[] { 0x03, 0x04, 0x01, 0x02};
            UInt32 u1 =(UInt32) c.ConvertToObject(bs1);
            Assert.AreEqual(0x01020304, u1);


            byte[] bs2 = c.ConvertToBytes(u1);
            UInt32 u2 = (UInt32)c.ConvertToObject(bs2);
            Assert.AreEqual(u1,u2);
        }
    }
}
