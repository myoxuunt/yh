using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;

namespace RWTrans
{
    public class Logger
    {
        /// <summary>
        /// 
        /// </summary>
        public TextBox OutputTextBox
        {
            get { return _outputTextBox; }
            set 
            {
                _outputTextBox = value;
                this._outputTextBox.ReadOnly = true;
                this._outputTextBox.ForeColor = System.Drawing.Color.White;
                this._outputTextBox.ScrollBars = ScrollBars.Both;
                this._outputTextBox.Multiline = true;
            }
        } private TextBox _outputTextBox;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        public void Add(string msg)
        {
            if (this.OutputTextBox.TextLength >= this.OutputTextBox.MaxLength)
            {
                this.OutputTextBox.Clear();
            }
            string text = string.Format(
                "{0}\t{1}\r\n",
                DateTime.Now,
                msg);
            this.OutputTextBox.AppendText(text);
        }

        /// <summary>
        /// 
        /// </summary>
        public void AddSeparatLine()
        {
            this.OutputTextBox.AppendText(Environment.NewLine);
        }
    }
}
