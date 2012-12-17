using System;
using System.IO;
using System.Windows.Forms;


namespace Xdgk.Common
{
    public class ExceptionHandler
    {
        /// <summary>
        /// 
        /// </summary>
        private ExceptionHandler()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        static public bool Show
        {
            get { return _showException; }
            set { _showException = value; }
        } static private bool _showException = true;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ex"></param>
        /// <returns></returns>
        static public string GetExceptionInfo(Exception ex)
        {
            //string strEx = "Message: " + ex.Message + Environment.NewLine;
            //strEx += "Source: " + ex.Source + Environment.NewLine;
            //strEx += "TargetSite: " + ex.TargetSite + Environment.NewLine;
            //strEx += "StackTrace: " + Environment.NewLine + ex.StackTrace + Environment.NewLine;

            //if (ex.HelpLink != null && ex.HelpLink.Length > 0)
            //    strEx += "HelpLink: " + ex.HelpLink + Environment.NewLine;


            //if (ex.InnerException != null)
            //    strEx += "InnerException: " + GetExceptionInfo(ex.InnerException);

            //return strEx;
            return ex.ToString();
            //string str = ex.ToString();
            //if (ex.InnerException != null)
            //{
            //    str += Environment.NewLine + "==========" + Environment.NewLine;
            //    str += "InnerException: " + ex.InnerException.GetType().Name + Environment.NewLine;
            //    str += GetExceptionInfo(ex.InnerException);
            //}
            //return str;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ex"></param>
        static public void Handle(Exception ex)
        {
            Handle_Helper(null, ex, _showException);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="show"></param>
        static public void Handle(Exception ex, bool show)
        {
            Handle_Helper(null, ex, show);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        static public void Handle(string message, Exception ex)
        {
            Handle_Helper(message, ex, _showException);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        /// <param name="show"></param>
        static public void Handle(string message, Exception ex, bool show)
        {
            Handle_Helper(message, ex, show);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        /// <param name="show"></param>
        static private void Handle_Helper(string message, Exception ex, bool show)
        {
            string s = GetExceptionInfo(ex);
            if (message != null && message.Trim().Length > 1)
            {
                s = message + Environment.NewLine + Environment.NewLine + s;
            }
            Save(s);

            if (!show)
                return;
            string displayInfo = ex.Message;
            if (message != null && message.Trim().Length > 1)
            {
                displayInfo = message + Environment.NewLine + Environment.NewLine + displayInfo;
            }
            MessageBox.Show(displayInfo, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            Environment.Exit(0);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="exmsg"></param>
        static private void Save(string exmsg)
        {
            try
            {
                string path = Application.StartupPath + "\\exception.txt";
                StreamWriter sw = File.AppendText(path);
                sw.WriteLine(DateTime.Now);
                sw.WriteLine(exmsg);
                sw.WriteLine();
                sw.Flush();
                sw.Close();
            }
            catch
            {
            }
            
        }
    }
}