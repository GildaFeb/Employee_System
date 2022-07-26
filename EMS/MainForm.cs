using LoginForm;
using System.Runtime.InteropServices;

namespace EMS
{
    public partial class MainForm : Form
    {
        public MainForm(dashboard dashboard)
        {
            InitializeComponent();
            hideSubMenu();
            hideshowAttendanceRepSubMenu();

            pnl_IndicatorDashboard.Show();
            pnl_IndicatorAttendance.Hide();
            //pnl_IndicatorEmployees.Hide();
            
            dashboard2.BringToFront();

            //this.ControlBox = false;
            this.Text = String.Empty;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;


        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

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

            pnl_IndicatorEmployeesNew.Show();
            pnl_IndicatorAttendance.Hide();
            pnl_IndicatorDashboard.Hide();

            // EMPLOYEES page
            employees2.BringToFront();

            addEmp_Pnl.Hide();
            updateEmp_Pnl.Hide();
            deleteEmp_Pnl.Hide();
        }

        private void subBtn_AddEmp_Click(object sender, EventArgs e)
        {
            // EMPLOYEE ADD Page (Revised)
            employeeSadd_revised2.BringToFront();

            addEmp_Pnl.Show();
            updateEmp_Pnl.Hide();
            deleteEmp_Pnl.Hide();
        }

        private void subBtn_UpdateEmp_Click(object sender, EventArgs e)
        {
            // EMPLOYEE UPDATE Page (Revised)
            employeeSupdate_revised2.BringToFront();

            addEmp_Pnl.Hide();
            updateEmp_Pnl.Show();
            deleteEmp_Pnl.Hide();
        }

        private void subBtn_SearchEmp_Click(object sender, EventArgs e)
        {
            // EMPLOYEE DELETE Page
            employeeSdelete3.BringToFront();

            addEmp_Pnl.Hide();
            updateEmp_Pnl.Hide();
            deleteEmp_Pnl.Show();
        }

        private void app_bg_load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h); 
        }


        private void app_bg_Load_1(object sender, EventArgs e)
        {

        }

        private void employeesPnl_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            showSubMenu(attendancePnl);

            pnl_IndicatorAttendance.Show();
            pnl_IndicatorDashboard.Hide();
            pnl_IndicatorEmployeesNew.Hide();

           // attendance1.BringToFront();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnl_IndicatorDashboard.Show();
            pnl_IndicatorAttendance.Hide();
            pnl_IndicatorEmployeesNew.Hide();

            // DASHBOARD Page
            dashboard2.BringToFront();

            hideSubMenu();
        }
        private void button17_Click(object sender, EventArgs e)
        {
            //ATTENDANCEdutyduration1.Show();   wag delete 
            hideSubMenu();
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

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
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
            //pnl_IndicatorEmployees.Hide();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            showSubMenu(attendancePnl);

            pnl_IndicatorEmployeesNew.Hide();
            pnl_IndicatorAttendance.Show();
            pnl_IndicatorDashboard.Hide();


            // ATTENDANCE Page
            attendance2.BringToFront();

            // Sub Panel Ellipse Indicators
            attendanceReport_Pnl.Hide();
            dutyDuration_Pnl.Hide();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            attendancEdutydurationDel1.BringToFront();
            showAttendanceRepSubMenu(attendanceReport_SubSubPnl);
            //attendanceReport_SubSubPnl.Visible = true;

            addDutyDuration_Pnl.Hide();
            updateDutyDuration_Pnl.Hide();
            deleteDutyDuration_Pnl.Hide();

            attendanceReport_Pnl.Hide();
            dutyDuration_Pnl.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            attendancEdutydurationAddrevised2.BringToFront();
            addDutyDuration_Pnl.Show();
            updateDutyDuration_Pnl.Hide();
            deleteDutyDuration_Pnl.Hide();

            dutyDuration_Pnl.Hide();
            attendanceReport_Pnl.Hide();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            attendanceReport_SubSubPnl.Visible = false;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            attendancEreport2.BringToFront();
            attendanceReport_SubSubPnl.Visible = false;
            /////
            attendanceReport_Pnl.Show();
            dutyDuration_Pnl.Hide();
            
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            
            attendancEdutydurationUpdrevised2.BringToFront();
            addDutyDuration_Pnl.Hide();
            updateDutyDuration_Pnl.Show();
            deleteDutyDuration_Pnl.Hide();

            dutyDuration_Pnl.Hide();
            attendanceReport_Pnl.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            attendancEdutydurationDel1.BringToFront();

            addDutyDuration_Pnl.Hide();
            updateDutyDuration_Pnl.Hide();
            deleteDutyDuration_Pnl.Show();

            dutyDuration_Pnl.Hide();
            attendanceReport_Pnl.Hide();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            if (CMessageBox.Show("Do you want to Log out?", "Logging Out Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoginForm.LogForm Login = new LoginForm.LogForm();
                Login.Show();
                this.Hide();
            }
        }

        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnl_IndicatorDashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(Environment.ExitCode); //will delete pag may logout button na 
        }

        private void addEmp_Pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void updateEmp_Pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void attendanceReport_Pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void attendanceReport_Pnl_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}