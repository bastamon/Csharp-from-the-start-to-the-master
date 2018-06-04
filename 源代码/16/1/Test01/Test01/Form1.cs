using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Test01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server=.;database=db_16;uid=sa;pwd=");
            SqlDataAdapter sda = new SqlDataAdapter("select * from tb_emp",conn);
            DataSet ds = new DataSet();
            sda.Fill(ds,"emp");
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}