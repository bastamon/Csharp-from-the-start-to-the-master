using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Test03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlDataAdapter adapter;
        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection("server=.;database=db_16;uid=sa;pwd=");
            SqlDataAdapter sda = new SqlDataAdapter("select * from tb_emp",conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.RowHeadersVisible = false;
            for (int i = 0; i < dataGridView1.ColumnCount;i++ )
            {
                dataGridView1.Columns[i].Width = 84;
            }
            button1.Enabled = false;
            dataGridView1.Columns[0].ReadOnly = true;
        }
        private DataTable dbconn(string strSql)
        {
            conn.Open();
            this.adapter = new SqlDataAdapter(strSql, conn);
            DataTable dtSelect = new DataTable();
            int rnt = this.adapter.Fill(dtSelect);
            conn.Close();
            return dtSelect;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (dbUpdate())
            {
                MessageBox.Show("修改成功！");
            }
        }
        private Boolean dbUpdate()
        {
            string strSql = "select * from tb_emp";
            DataTable dtUpdate = new DataTable();
            dtUpdate = this.dbconn(strSql);
            dtUpdate.Rows.Clear();
            DataTable dtShow = new DataTable();
            dtShow = (DataTable)this.dataGridView1.DataSource;
            for (int i = 0; i < dtShow.Rows.Count; i++)
            {
                dtUpdate.ImportRow(dtShow.Rows[i]);
            }
            try
            {
                this.conn.Open();
                SqlCommandBuilder CommandBuiler;
                CommandBuiler = new SqlCommandBuilder(this.adapter);
                this.adapter.Update(dtUpdate);
                this.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
            }
            dtUpdate.AcceptChanges();
            return true;
        }
    }
}