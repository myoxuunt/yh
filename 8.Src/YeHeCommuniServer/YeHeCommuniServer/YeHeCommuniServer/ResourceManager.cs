using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace YeHeCommuniServer
{
    /// <summary>
    /// 
    /// </summary>
    public class ResourceManager
    {
        /// <summary>
        /// 
        /// </summary>
        public ImageList ImageList
        {
            get
            {
                if (_imageList == null)
                {
                    _imageList = new ImageList();
                    //Icon connection = new Icon(".\\res\\connect.ico");
                    //_imageList.Images.Add(connection);
                    //Icon disconnection = new Icon(".\\res\\disconnect.ico");
                    //_imageList.Images.Add(disconnection);
                                        
                    //Icon empty = new Icon(".\\res\\empty.ico");
                    //_imageList.Images.Add(empty);
                    Init(_imageList);

                }
                return _imageList;
            }
        } private ImageList _imageList;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="imageList"></param>
        private void Init(ImageList imageList)
        {
            string[] fileNames = new string[]
            {
                "DisConnect",
                "Connect",
                "Device"
            };
            foreach( string s in fileNames )
            {
                Icon empty = new Icon(".\\res\\" + s + ".ico");
                _imageList.Images.Add(s, empty);

            }
        }

    }
}
