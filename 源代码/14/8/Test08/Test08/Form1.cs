﻿using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace Test08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
            listView1.Groups.Add(new ListViewGroup("名称",HorizontalAlignment.Left));
            listView1.Groups.Add(new ListViewGroup("年龄", HorizontalAlignment.Left));
            listView1.Items.Add("用一生下载你");
            listView1.Items.Add("芸烨湘枫");
            listView1.Items.Add("一生所爱");
            listView1.Items.Add("28");
            listView1.Items.Add("27");
            listView1.Items.Add("26");
            listView1.Items[0].Group = listView1.Groups[0];
            listView1.Items[1].Group = listView1.Groups[0];
            listView1.Items[2].Group = listView1.Groups[0];
            listView1.Items[3].Group = listView1.Groups[1];
            listView1.Items[4].Group = listView1.Groups[1];
            listView1.Items[5].Group = listView1.Groups[1];
        }
    }
}