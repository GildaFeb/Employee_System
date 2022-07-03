using LoginForm;

namespace EMS
{
    public partial class forms1 : Form
    {
        public forms1(dashboard dashboard)
        {
            InitializeComponent();
            hideSubMenu();
            hideshowAttendanceRepSubMenu();

            pnl_IndicatorDashboard.Show();
            pnl_IndicatorAttendance.Hide();
            pnl_IndicatorEmployees.Hide();
            
            dashboard1.BringToFront();

        }
        
        private void hideSubMenu()
        {
            employeesPnl.Visible = false;
            attendancePnl.Visible = false;
            //attendanceReport_SubSubPnl.Visible = false;
        }

        private void hideshowAttendanceRepSubMenu()
        {
            //employeesPnl.Visible = false;
            //attendancePnl.Visible = false;
            attendanceReport_SubSubPnl.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void showAttendanceRepSubMenu(Panel attendanceReport_SubSubPnl)
        {
            if (attendanceReport_SubSubPnl.Visible == false)
            {
                hideshowAttendanceRepSubMenu();
                attendanceReport_SubSubPnl.Visible = true;
            }
            else
            {
                attendanceReport_SubSubPnl.Visible = false;
            }
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            showSubMenu(employeesPnl);

            pnl_IndicatorEmployees.Show();
            pnl_IndicatorAttendance.Hide();
            pnl_IndicatorDashboard.Hide();

            // EMPLOYEES page
            employees1.BringToFront();

        }

        private void subBtn_AddEmp_Click(object sender, EventArgs e)
        {
            // EMPLOYEE ADD Page (Revised)
            employeeSadd_revised1.BringToFront();
        }

        private void subBtn_UpdateEmp_Click(object sender, EventArgs e)
        {
            // EMPLOYEE UPDATE Page (Revised)
            employeeSupdate_revised1.BringToFront();
        }

        private void subBtn_SearchEmp_Click(object sender, EventArgs e)
        {
            // EMPLOYEE DELETE Page
            employeeSdelete2.BringToFront();
        }

        private void app_bg_load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h); 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_dashboard1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_one2_Click(object sender, EventArgs e)
        {

        }

        private void app_bg_Load_1(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btn_one7_Click(object sender, EventArgs e)
        {

        }

        private void txtBox_search(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void attendanceTimer_Tick(object sender, EventArgs e)
        {

        }

        private void attendanceBtn_Click_1(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void add_Subbtn_Click(object sender, EventArgs e)
        {

        }

        private void employeesTimer_Tick_1(object sender, EventArgs e)
        {

        }

        private void employeesContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {

        }

        private void btn_employees_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void employeesPnl_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void salaryPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            showSubMenu(attendancePnl);
            
            pnl_IndicatorAttendance.Show();
            pnl_IndicatorDashboard.Hide();
            pnl_IndicatorEmployees.Hide();

           // attendance1.BringToFront();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {

            pnl_IndicatorAttendance.Hide();
            pnl_IndicatorDashboard.Hide();
            pnl_IndicatorEmployees.Hide();

            salary1.BringToFront();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnl_IndicatorDashboard.Show();
            pnl_IndicatorAttendance.Hide();
            pnl_IndicatorEmployees.Hide();

            // DASHBOARD Page
            dashboard1.BringToFront();

            hideSubMenu();
        }
        private void button17_Click(object sender, EventArgs e)
        {
            //ATTENDANCEdutyduration1.Show();   wag delete 
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void backPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        
        // Function to CLOSE ALL SUBMENUS IF ANOTHER SUBMENU IS OPENED
        private Form activeForm = null;
        private void openBackPanel(Form backPanel)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = backPanel;
            backPanel.FormBorderStyle = FormBorderStyle.None;
            backPanel.Dock = DockStyle.Fill;
            backPanel.Controls.Add(backPanel);
            backPanel.Tag = backPanel;
            backPanel.BringToFront();
            backPanel.Show();
        }
        

        private void employeeAdd1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dashboard1_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void dashboard1_Load_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void dashboard2_Load(object sender, EventArgs e)
        {

        }

        private void employees1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btn_one1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_3(object sender, PaintEventArgs e)
        {

        }

        private void dashboard1_Load_2(object sender, EventArgs e)
        {

        }

        private void employees1_Load_1(object sender, EventArgs e)
        {

        }

        private void btn_one3_Click(object sender, EventArgs e)
        {
            //employeeSadd_revised1.BringToFront();
        }

        private void btn_one3_Click_1(object sender, EventArgs e)
        {
            //employeeSadd_revised1.BringToFront();
        }

        private void btn_one5_Click(object sender, EventArgs e)
        {
            //employeeSupdate_revised1.BringToFront();
        }

        private void panel2_Paint_4(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnl_IndicatorDashboard.Hide();
            pnl_IndicatorEmployees.Hide();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            showSubMenu(attendancePnl);

            pnl_IndicatorEmployees.Hide();
            pnl_IndicatorAttendance.Show();
            pnl_IndicatorDashboard.Hide();

            // ATTENDANCE Page
            attendance1.BringToFront();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            attendancEreport1.BringToFront();
            showAttendanceRepSubMenu(attendanceReport_SubSubPnl);
            //attendanceReport_SubSubPnl.Visible = true;

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            attendanceReport_SubSubPnl.Visible = false;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            attendancEdutyduration1.BringToFront();
            attendanceReport_SubSubPnl.Visible = false;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
        }

        private void attendanceReport_SubSubPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_one10_Click(object sender, EventArgs e)
        {

        }
    }
}