using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS
{
    public partial class TRASH_SALARY : UserControl
    {
        public TRASH_SALARY()
        {
            InitializeComponent();
        }

        private void SALARY_Load(object sender, EventArgs e)
        {
            dayTodayLbl_Salary.Text = DateTime.Now.ToLongDateString();
            clockLbl_Salary.Text= DateTime.Now.ToLongTimeString();

            timeTmr_Salary.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void clockLbl_Salary_Click(object sender, EventArgs e)
        {

        }

        private void timeTmr_Salary_Tick(object sender, EventArgs e)
        {
            clockLbl_Salary.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
