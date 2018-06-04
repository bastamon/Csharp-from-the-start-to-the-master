using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
namespace Test09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)//隐藏运行菜单
        {
            try
            {
                RegistryKey reg = Registry.CurrentUser;
                reg = reg.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
                reg.SetValue("NoRun",1);
                reg.Close();
                MessageBox.Show("隐藏运行菜单成功，请刷新桌面或重新启动计算机", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)//隐藏帮助菜单
        {
            try
            {
                RegistryKey reg = Registry.CurrentUser;
                reg = reg.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
                reg.SetValue("NoSMHelp", 1);
                reg.Close();
                MessageBox.Show("隐藏帮助菜单成功，请刷新桌面或重新启动计算机", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button3_Click(object sender, EventArgs e)//隐藏搜索菜单
        {
            try
            {
                RegistryKey reg = Registry.CurrentUser;
                reg = reg.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
                reg.SetValue("NoFind", 1);
                reg.Close();
                MessageBox.Show("隐藏搜索菜单成功，请刷新桌面或重新启动计算机", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 
        private void button4_Click(object sender, EventArgs e)//隐藏任务栏右键菜单
        {
            try
            {
                RegistryKey reg = Registry.CurrentUser;
                reg = reg.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
                reg.SetValue("notraycontextmenu", 1);
                reg.Close();
                MessageBox.Show("隐藏任务栏右键菜单成功，请刷新桌面或重新启动计算机", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button5_Click(object sender, EventArgs e)//隐藏任务栏时钟
        {
            try
            {
                RegistryKey reg = Registry.CurrentUser;
                reg = reg.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
                reg.SetValue("HideClock", 1);
                reg.Close();
                MessageBox.Show("隐藏任务栏时钟成功，请刷新桌面或重新启动计算机", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}