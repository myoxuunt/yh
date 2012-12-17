using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YHZKPort
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.textBox1.Text= DBcon.Instance.GetSendTime();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int time = int.Parse(textBox1.Text.Trim());
                DBcon.Instance.SetSendTime(time.ToString());
                MessageBox.Show("设置成功！"); this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("时间设置格式不符，请写入整形数字");
            }
        }
    }
}
