using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Test21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strPath = textBox1.Text.Substring(0, textBox1.Text.LastIndexOf("\\"));
            string strName = textBox1.Text.Substring(textBox1.Text.LastIndexOf("\\") + 1, (textBox1.Text.LastIndexOf(".") - textBox1.Text.LastIndexOf("\\") - 1));
            string strEName = textBox1.Text.Substring(textBox1.Text.LastIndexOf(".") + 1, (textBox1.Text.Length - textBox1.Text.LastIndexOf(".") - 1));
            MessageBox.Show("文件路径：" + strPath + "\n 文件名：" + strName + "\n 文件扩展名：" + strEName, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All files (*.*)|*.*";
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName.ToString();
        }
    }
}