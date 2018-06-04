using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace Test19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime myVacation1 = new DateTime(2008, 3, 2);
            monthCalendar1.AddBoldedDate(myVacation1);
            monthCalendar1.UpdateBoldedDates();
        }
    }
}