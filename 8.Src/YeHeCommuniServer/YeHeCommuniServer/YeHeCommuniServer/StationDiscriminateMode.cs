using System;
using System.Collections.Generic;
using System.Text;
using Xdgk.Communi;

namespace YeHeCommuniServer
{
    internal class StationDiscriminateMode
    {
        public class Item
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="dm"></param>
            /// <param name="text"></param>
            public Item(DiscriminateMode dm, string text)
            {
                this._discriminateMode = dm;
                this._text = text;
            }

            /// <summary>
            /// 
            /// </summary>
            public DiscriminateMode DiscriminateMode
            {
                get { return _discriminateMode; }
            } private DiscriminateMode _discriminateMode;

            /// <summary>
            /// 
            /// </summary>
            public string Text
            {
                get { return _text; }
            } private string _text;
        }

        /// <summary>
        /// 
        /// </summary>
        static public Item[] Items
        {
            get { return s_items; }
        }

        /// <summary>
        /// 
        /// </summary>
        static private Item[] s_items = new Item[] 
        {
            new Item(DiscriminateMode.ByIPAddress, strings.ByIP ),
            new Item(DiscriminateMode.ByLocalPort, strings.ByLocalPort ),
            new Item (DiscriminateMode.ByRemotePort, strings.ByRemotePort )
        };
    }
}
