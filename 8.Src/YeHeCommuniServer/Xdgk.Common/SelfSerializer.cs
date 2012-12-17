using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Xdgk.Common
{
    [Serializable]
    public class SelfSerializer
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static object Load(Type type, string filename)
        {
            FileStream stream = null;
            object obj2;
            try
            {
                stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
                obj2 = new XmlSerializer(type).Deserialize(stream);
            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                }
            }
            return obj2;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        public void Save(Stream stream)
        {
            //try
            //{
                new XmlSerializer(base.GetType()).Serialize(stream, this);
            //}
            //catch (Exception exception)
            //{
            //    Console.WriteLine(exception.Message);
            //}
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filename"></param>
        public virtual void Save(string filename)
        {
            FileStream stream = null;
            try
            {
                stream = new FileStream(filename, FileMode.Create);
                this.Save(stream);
            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                }
            }
        }
    }
}
