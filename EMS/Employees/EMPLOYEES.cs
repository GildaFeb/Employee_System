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
    public partial class EMPLOYEES : UserControl
    {
        public EMPLOYEES()
        {
            InitializeComponent();
        }

        private void btn_one5_Click(object sender, EventArgs e)
        {

        }
    


        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void EMPLOYEES_Load(object sender, EventArgs e)
        {
            dayTodayLbl_Employees.Text = DateTime.Now.ToLongDateString();
            clockLbl_Employees.Text = DateTime.Now.ToLongTimeString();

            timeTmr_Employees.Start();
        }

        private void timeTmr_Tick(object sender, EventArgs e)
        {
            clockLbl_Employees.Text = DateTime.Now.ToLongTimeString();
            timeTmr_Employees.Start();
        }

        private void clockLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
