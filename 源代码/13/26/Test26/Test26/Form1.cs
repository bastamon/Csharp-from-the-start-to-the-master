using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
namespace Test26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }        
        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            richTextBox1.Text = "姓名：芸烨湘枫\n性别：女\n年龄：27\n民族：汉\n职业：医疗";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输出姓名");
                textBox1.Focus();
            }
            else
            {
                if (textBox1.Text.Trim() == "芸烨湘枫")
                {
                    panel1.Show();
                }
                else
                {
                    MessageBox.Show("查无此人");
                    textBox1.Text = "";
                }
            }
        }
    }
}