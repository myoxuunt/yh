﻿using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;

namespace Xdgk.UI.Z
{

    /// <summary>
    /// 
    /// </summary>
    public class ColorProvider
    {
        private int i = -1;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Color GetNextColor()
        {
            i++;
            if (i >= Table.Length)
            {
                i = 0;
            }
            Color c = Table[i];
            return c;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetNextColorString()
        {
            i++;
            if (i >= Table.Length)
            {
                i = 0;
            }

            Color c = Table[i];
            string s = string.Format("#{0:x2}{1:x2}{2:x2}", c.R, c.G, c.B);
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        static public Color[] Table
        {
            get
            {
                if (_table == null)
                {
                    _table = new Color[]
                    {
                        Color.Red,
                        Color.Blue,
                        Color.Green,
                        Color.Purple,
                        Color.Fuchsia ,
                        Color.Black ,
                        Color.Navy,
                        Color.Lime ,
                        Color.Gray ,
                        Color.Yellow ,
                    };
                }
                return _table;
            }
        }
        static private Color[] _table;
    }
}
