using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Xdgk.CF;

namespace FormulaTest
{
    [TestFixture ]
    public class  FormulaTestClass
    {
        [Test]
        public void t1()
        {
            int wl1 = 10, wl2 = 10;
            for (int i = 1; i < 10; i++)
            {

                //impl("wl1 + wl2", wl1, wl2);
                //impl("5*((wl1)^2)", wl1, wl2);
                //impl("Log10(100) * wl1 * wl2", wl1, wl2);
                //double n =  Math.Log(100);
                impl("0.0115 * wl1^1.2912", wl1 * i, wl2);
            }

            // will be 0
            //
            //impl("not exist formula", wl1, wl2);
        }


        public void impl(string express, int wl1, int wl2)
        {
            //string express = "wl1 + wl";
            Formula f = new Formula(0, 
                DateTime.Parse("2000-1-1"), 
                DateTime.Parse("2000-12-31"),
                express);

            float flux = f.CalcInstantFlux(wl1, wl2);

            string s = string.Format("Express: {0}\r\n", express);
            s += string.Format("wl1: {0}, wl2: {1}\r\n", wl1, wl2);
            s += string.Format("flux: {0}\r\n", flux);

            //Console.WriteLine(express + ":" + flux);
            Console.Write(s);
        }
    }
}
