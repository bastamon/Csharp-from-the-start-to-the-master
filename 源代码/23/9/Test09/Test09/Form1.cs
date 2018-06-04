using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
namespace Test09
{
    public partial class Form1 : Form
    {
        SqlConnection sqlcon;
        SqlDataAdapter myda;
        DataSet myds;
        public string M_str_sql = "server=(local);database=db_23;uid=sa;pwd=;";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlcon = new SqlConnection(M_str_sql);
            myda = new SqlDataAdapter("select * from tb_student", sqlcon);
            myds = new DataSet();
            myda.Fill(myds, "tb_student");
            CrystalReport1 CReport = new CrystalReport1();
            CReport.SetDataSource(myds.Tables["tb_student"]);
            crystalReportViewer1.ReportSource = CReport;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string P_str_sql = " {tb_student.考生性别} like '" + toolStripComboBox1.Text.Trim() + "'";
            ReportDocument reportDocument = new ReportDocument();
            string P_str_creportPath = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0,
                Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\"));
            P_str_creportPath += "\\CrystalReport1.rpt";
            reportDocument.Load(P_str_creportPath);
            reportDocument.DataDefinition.RecordSelectionFormula = P_str_sql;
            crystalReportViewer1.ReportSource = reportDocument;
        }
    }
}