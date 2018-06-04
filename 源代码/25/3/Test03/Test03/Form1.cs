using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
namespace Test03
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
                RegistryKey software = hklm.OpenSubKey("HARDWARE", true);
                RegistryKey main1 = software.CreateSubKey("LS");
                RegistryKey ddd = main1.CreateSubKey("SHJ");
                ddd.SetValue("value", "1234");
                MessageBox.Show("创建成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}