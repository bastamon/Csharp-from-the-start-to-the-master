using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace Test15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            comboBox1.Items.Add("用一生下载你");
            comboBox1.Items.Add("芸烨湘枫");
            comboBox1.Items.Add("一生所爱");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.SelectAll();
        }
    }
}