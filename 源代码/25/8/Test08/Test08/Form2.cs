using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
namespace Test08
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int i0, i1, i2, i3;
            if (checkBox1.Checked){i0 = 0;}else{i0 = 1;}
            try
            {
                RegistryKey reg;
                reg = Registry.CurrentUser;
                reg = reg.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\HideDesktopIcons\\NewStartPanel");
                reg.SetValue("{450D8FBA-AD25-11D0-98A8-0800361B1103}", i0, RegistryValueKind.DWord);
                reg.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (checkBox2.Checked) { i1 = 0; } else { i1 = 1; }
            try
            {
                RegistryKey reg;
                reg = Registry.CurrentUser;
                reg = reg.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\HideDesktopIcons\\NewStartPanel");
                reg.SetValue("{208D2C60-3AEA-1069-A2D7-08002B30309D}",i1, RegistryValueKind.DWord);
                reg.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (checkBox3.Checked) { i2 = 0; } else { i2 = 1; }
            try
            {
                RegistryKey reg;
                reg = Registry.CurrentUser;
                reg = reg.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\HideDesktopIcons\\NewStartPanel");
                reg.SetValue("{20D04FE0-3AEA-1069-A2D8-08002B30309D}",i2, RegistryValueKind.DWord);
                reg.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (checkBox4.Checked) { i3= 0; } else { i3 = 1; }
            try
            {
                RegistryKey reg;
                reg = Registry.CurrentUser;
                reg = reg.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\HideDesktopIcons\\NewStartPanel");
                reg.SetValue("{871C5380-42A0-1069-A2EA-08002B30309D}",i3, RegistryValueKind.DWord);
                reg.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("设置成功，请刷新桌面或重新启动计算机","信息提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}