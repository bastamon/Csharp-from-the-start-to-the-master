using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Test19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = textBox1.Text.Trim();
            char[] charstr = str1.ToCharArray();
            Array.Reverse(charstr);
            string str2 = new string(charstr);
            textBox2.Text = str2;
        }
    }
}