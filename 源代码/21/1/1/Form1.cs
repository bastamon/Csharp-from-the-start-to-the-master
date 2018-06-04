using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strPath= "帮助文件.hlp";    //指定帮助文件路径
            Help.ShowHelp(this, strPath);      //显示帮助文件
        }
    }
}