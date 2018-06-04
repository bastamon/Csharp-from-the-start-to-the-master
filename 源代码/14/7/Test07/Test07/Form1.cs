using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace Test07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
            listView1.LargeImageList = imageList1;
            imageList1.Images.Add(Image.FromFile("1.bmp"));
            imageList1.Images.Add(Image.FromFile("2.bmp"));
            listView1.Items.Add("用一生下载你");
            listView1.Items.Add("一生所爱");
            listView1.Items.Add("用一生下载你");
            listView1.Items.Add("一生所爱");
            listView1.Items.Add("用一生下载你");
            listView1.Items[0].ImageIndex = 0;
            listView1.Items[1].ImageIndex = 1;
            listView1.Items[2].ImageIndex = 0;
            listView1.Items[3].ImageIndex = 1;
            listView1.Items[4].ImageIndex = 0;
            listView1.TileSize = new Size(100, 50); 
        }
    }
}