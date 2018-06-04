using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
namespace Test06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey hklm = Registry.LocalMachine;
                //hklm.DeleteSubKey("aaa", false);
                //打开"SOFTWARE"子键
                RegistryKey software = hklm.OpenSubKey("HARDWARE", true);
                //打开"aaa"子键
                RegistryKey no1 = software.OpenSubKey("LS", true);
                //删除名称为"ddd"的子键
                no1.DeleteSubKeyTree("SHJ");
                MessageBox.Show("删除成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}