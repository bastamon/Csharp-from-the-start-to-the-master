using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Test11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsDB.ClsDBControl DBC = new Test11.ClsDB.ClsDBControl();
            string strSql = "insert into tb_people values('" + this.textBox1.Text.Trim().ToString() + "','" +
            this.textBox2.Text.Trim().ToString() + "','" + this.textBox3.Text.Trim().ToString() + "')";
            if (DBC.insertDB(strSql))
            {
                MessageBox.Show("OK");
            }
        }
    }
}