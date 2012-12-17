using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;

namespace Xdgk.Common
{
    /// <summary>
    /// 
    /// </summary>
    public struct SerializableColor
    {
        /// <summary>
        /// 
        /// </summary>
        public int Argb;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="color"></param>
        public SerializableColor(Color color)
        {
            //this.A = color.A;
            //this.R = color.R;
            //this.G = color.G;
            //this.B = color.B;
            this.Argb = color.ToArgb();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static SerializableColor FromColor(Color color)
        {
            return new SerializableColor(color);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Color ToColor()
        {
            //return Color.FromArgb(FromArgb(A, R, G, B));
            return Color.FromArgb(Argb);
        }
    }
}
