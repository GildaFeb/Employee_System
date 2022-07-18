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
    public partial class dashboard : UserControl
    {
        public dashboard()
        {
            InitializeComponent();
            emp_num.Text = Employee_Details.Employee_Database.EmployeeNum().ToString();
            project_num.Text = Employee_Details.Employee_Database.AdministratorCount().ToString();
            fullstack_dev_num.Text = Employee_Details.Employee_Database.FullStackDevCount().ToString();
            software_engineer_num.Text = Employee_Details.Employee_Database.SoftwareEngCount().ToString();
            administrator_num.Text = Employee_Details.Employee_Database.AdministratorCount().ToString();


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            clockLbl.Text = DateTime.Now.ToLongTimeString();
            dayTodayLbl.Text = DateTime.Now.ToLongDateString();
        }

        private void timeTmr_Tick(object sender, EventArgs e)
        {
            clockLbl.Text = DateTime.Now.ToLongTimeString();
            timeTmr.Start();
        }

        private void db_ViewCalendarBtn_Click(object sender, EventArgs e)
        {

        }

        private void dayTodayLbl_Click(object sender, EventArgs e)
        {

        }

        private void db_ViewWelcomeBtn_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void db_ViewSalaryBtn_Click(object sender, EventArgs e)
        {

        }

        private void db_ViewAttendanceBtn_Click(object sender, EventArgs e)
        {

        }

        private void db_ViewEmployeesBtn_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            // Project Manager count
           
        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {
            
        }

        private void label12_Click(object sender, EventArgs e)
        {
            
        }

        private void emp_num_Click(object sender, EventArgs e)
        {

        }

        private void btn_one2_Click(object sender, EventArgs e)
        {
            emp_num.Text = Employee_Details.Employee_Database.EmployeeNum().ToString();
            project_num.Text = Employee_Details.Employee_Database.AdministratorCount().ToString();
            fullstack_dev_num.Text = Employee_Details.Employee_Database.FullStackDevCount().ToString();
            software_engineer_num.Text = Employee_Details.Employee_Database.SoftwareEngCount().ToString();
            administrator_num.Text = Employee_Details.Employee_Database.AdministratorCount().ToString();

        }
    }
}
