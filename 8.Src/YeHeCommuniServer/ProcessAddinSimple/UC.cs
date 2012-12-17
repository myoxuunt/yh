using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ProcessAddinSimple
{
    public partial class UC : UserControl
    {
        public UC()
        {
            InitializeComponent();
        }

        private void UC_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Description
        {
            set { this.textBox1.Text = value; }
        }
    }
}
