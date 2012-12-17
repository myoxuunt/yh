using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Xdgk.Common
{
    /// <summary>
    /// 可序列化字体结构
    /// </summary>
    public struct SerializableFont
    {
        // Size, Name, Style 用于序列化时候使用，

        /// <summary>
        /// 
        /// </summary>
        public float Size
        {
            get
            {
                if (_size <= 0)
                {
                    _size = 9F;
                }
                return _size;
            }
            set { _size = value; }
        } private float _size;


        public string Name;
        public FontStyle Style;
        private Font _font ;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="font"></param>
        public SerializableFont(Font font)
        {
            _font = null;
            //this.SetFont(font);
            _size = font.Size;
            this.Name = font.Name;
            this.Style = font.Style;
            this._font = font;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Font GetFont()
        {
            if (_font == null)
            {
                _font = new Font(this.Name, this.Size, this.Style);
            }
            return _font;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="font"></param>
        public void SetFont(Font font)
        {
            if (font == null)
                throw new ArgumentNullException("font");

            this.Size = font.Size;
            this.Name = font.Name;
            this.Style = font.Style;
            this._font = font;
        }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="font"></param>
        ///// <returns></returns>
        //public static SerializableFont FromFont(Font font)
        //{
        //    return new SerializableFont(font);
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <returns></returns>
        //public Font ToFont()
        //{
        //    return new Font(Name, Size, Style);
        //}
    }
}
