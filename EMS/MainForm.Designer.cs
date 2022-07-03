namespace EMS
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogoutBtn = new EMS.btn_one();
            this.pnl_IndicatorAttendance = new System.Windows.Forms.Panel();
            this.btn_one4 = new EMS.btn_one();
            this.attendancePnl = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.attendanceReport_SubSubPnl = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pnl_IndicatorEmployees = new System.Windows.Forms.Panel();
            this.btn_one1 = new EMS.btn_one();
            this.pnl_IndicatorDashboard = new System.Windows.Forms.Panel();
            this.indicatorDashboard = new EMS.btn_one();
            this.employeesPnl = new System.Windows.Forms.Panel();
            this.subBtn_SearchEmp = new System.Windows.Forms.Button();
            this.subBtn_UpdateEmp = new System.Windows.Forms.Button();
            this.subBtn_AddEmp = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.employees1 = new EMS.EMPLOYEES();
            this.attendance1 = new EMS.ATTENDANCE();
            this.employeeSadd_revised1 = new EMS.EMPLOYEESadd_revised();
            this.employeeSupdate_revised1 = new EMS.EMPLOYEESupdate_revised();
            this.employeeSdelete2 = new EMS.EMPLOYEESdelete();
            this.dashboard1 = new EMS.dashboard();
            this.attendancEreport1 = new EMS.ATTENDANCEreport();
            this.attendancEdutyduration1 = new EMS.ATTENDANCEdutyduration();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnl_IndicatorAttendance.SuspendLayout();
            this.attendancePnl.SuspendLayout();
            this.attendanceReport_SubSubPnl.SuspendLayout();
            this.pnl_IndicatorEmployees.SuspendLayout();
            this.pnl_IndicatorDashboard.SuspendLayout();
            this.employeesPnl.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(37)))), ((int)(((byte)(83)))));
            this.panel1.Controls.Add(this.LogoutBtn);
            this.panel1.Controls.Add(this.pnl_IndicatorAttendance);
            this.panel1.Controls.Add(this.attendancePnl);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.pnl_IndicatorEmployees);
            this.panel1.Controls.Add(this.pnl_IndicatorDashboard);
            this.panel1.Controls.Add(this.employeesPnl);
            this.panel1.Controls.Add(this.btnEmployees);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 1033);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.White;
            this.LogoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutBtn.FlatAppearance.BorderSize = 0;
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogoutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(33)))), ((int)(((byte)(64)))));
            this.LogoutBtn.Location = new System.Drawing.Point(119, 970);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(135, 50);
            this.LogoutBtn.TabIndex = 160;
            this.LogoutBtn.Text = "Log Out";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // pnl_IndicatorAttendance
            // 
            this.pnl_IndicatorAttendance.BackColor = System.Drawing.Color.Transparent;
            this.pnl_IndicatorAttendance.Controls.Add(this.btn_one4);
            this.pnl_IndicatorAttendance.Location = new System.Drawing.Point(0, 450);
            this.pnl_IndicatorAttendance.Name = "pnl_IndicatorAttendance";
            this.pnl_IndicatorAttendance.Size = new System.Drawing.Size(16, 75);
            this.pnl_IndicatorAttendance.TabIndex = 24;
            // 
            // btn_one4
            // 
            this.btn_one4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(233)))), ((int)(((byte)(32)))));
            this.btn_one4.FlatAppearance.BorderSize = 0;
            this.btn_one4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_one4.ForeColor = System.Drawing.Color.White;
            this.btn_one4.Location = new System.Drawing.Point(-20, 12);
            this.btn_one4.Name = "btn_one4";
            this.btn_one4.Size = new System.Drawing.Size(24, 51);
            this.btn_one4.TabIndex = 23;
            this.btn_one4.Text = "btn_one1";
            this.btn_one4.UseVisualStyleBackColor = false;
            // 
            // attendancePnl
            // 
            this.attendancePnl.Controls.Add(this.button8);
            this.attendancePnl.Controls.Add(this.attendanceReport_SubSubPnl);
            this.attendancePnl.Controls.Add(this.button12);
            this.attendancePnl.Controls.Add(this.button7);
            this.attendancePnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.attendancePnl.Location = new System.Drawing.Point(0, 665);
            this.attendancePnl.Name = "attendancePnl";
            this.attendancePnl.Size = new System.Drawing.Size(365, 305);
            this.attendancePnl.TabIndex = 106;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(99)))));
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(0, 246);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(130, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(365, 50);
            this.button8.TabIndex = 3;
            this.button8.Text = "Leave management";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // attendanceReport_SubSubPnl
            // 
            this.attendanceReport_SubSubPnl.Controls.Add(this.button10);
            this.attendanceReport_SubSubPnl.Controls.Add(this.button9);
            this.attendanceReport_SubSubPnl.Controls.Add(this.button11);
            this.attendanceReport_SubSubPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.attendanceReport_SubSubPnl.Location = new System.Drawing.Point(0, 100);
            this.attendanceReport_SubSubPnl.Name = "attendanceReport_SubSubPnl";
            this.attendanceReport_SubSubPnl.Size = new System.Drawing.Size(365, 146);
            this.attendanceReport_SubSubPnl.TabIndex = 89;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(99)))));
            this.button10.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button10.Location = new System.Drawing.Point(0, 100);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(155, 0, 0, 0);
            this.button10.Size = new System.Drawing.Size(365, 50);
            this.button10.TabIndex = 3;
            this.button10.Text = "Add";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(99)))));
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button9.Location = new System.Drawing.Point(0, 50);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(155, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(365, 50);
            this.button9.TabIndex = 2;
            this.button9.Text = "Delete";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(99)))));
            this.button11.Dock = System.Windows.Forms.DockStyle.Top;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button11.Location = new System.Drawing.Point(0, 0);
            this.button11.Name = "button11";
            this.button11.Padding = new System.Windows.Forms.Padding(155, 0, 0, 0);
            this.button11.Size = new System.Drawing.Size(365, 50);
            this.button11.TabIndex = 3;
            this.button11.Text = "Update";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(99)))));
            this.button12.Dock = System.Windows.Forms.DockStyle.Top;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button12.Location = new System.Drawing.Point(0, 50);
            this.button12.Name = "button12";
            this.button12.Padding = new System.Windows.Forms.Padding(130, 0, 0, 0);
            this.button12.Size = new System.Drawing.Size(365, 50);
            this.button12.TabIndex = 1;
            this.button12.Text = "Attendance report";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click_1);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(99)))));
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(0, 0);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(130, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(365, 50);
            this.button7.TabIndex = 3;
            this.button7.Text = "Duty duration";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(37)))), ((int)(((byte)(83)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 590);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(365, 75);
            this.button3.TabIndex = 105;
            this.button3.Text = "             Attendance";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // pnl_IndicatorEmployees
            // 
            this.pnl_IndicatorEmployees.BackColor = System.Drawing.Color.Transparent;
            this.pnl_IndicatorEmployees.Controls.Add(this.btn_one1);
            this.pnl_IndicatorEmployees.Location = new System.Drawing.Point(0, 375);
            this.pnl_IndicatorEmployees.Name = "pnl_IndicatorEmployees";
            this.pnl_IndicatorEmployees.Size = new System.Drawing.Size(16, 75);
            this.pnl_IndicatorEmployees.TabIndex = 24;
            // 
            // btn_one1
            // 
            this.btn_one1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(233)))), ((int)(((byte)(32)))));
            this.btn_one1.FlatAppearance.BorderSize = 0;
            this.btn_one1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_one1.ForeColor = System.Drawing.Color.White;
            this.btn_one1.Location = new System.Drawing.Point(-20, 12);
            this.btn_one1.Name = "btn_one1";
            this.btn_one1.Size = new System.Drawing.Size(24, 51);
            this.btn_one1.TabIndex = 23;
            this.btn_one1.Text = "btn_one1";
            this.btn_one1.UseVisualStyleBackColor = false;
            // 
            // pnl_IndicatorDashboard
            // 
            this.pnl_IndicatorDashboard.BackColor = System.Drawing.Color.Transparent;
            this.pnl_IndicatorDashboard.Controls.Add(this.indicatorDashboard);
            this.pnl_IndicatorDashboard.Location = new System.Drawing.Point(0, 300);
            this.pnl_IndicatorDashboard.Name = "pnl_IndicatorDashboard";
            this.pnl_IndicatorDashboard.Size = new System.Drawing.Size(16, 75);
            this.pnl_IndicatorDashboard.TabIndex = 24;
            // 
            // indicatorDashboard
            // 
            this.indicatorDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(233)))), ((int)(((byte)(32)))));
            this.indicatorDashboard.FlatAppearance.BorderSize = 0;
            this.indicatorDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.indicatorDashboard.ForeColor = System.Drawing.Color.White;
            this.indicatorDashboard.Location = new System.Drawing.Point(-20, 12);
            this.indicatorDashboard.Name = "indicatorDashboard";
            this.indicatorDashboard.Size = new System.Drawing.Size(24, 51);
            this.indicatorDashboard.TabIndex = 23;
            this.indicatorDashboard.Text = "btn_one1";
            this.indicatorDashboard.UseVisualStyleBackColor = false;
            // 
            // employeesPnl
            // 
            this.employeesPnl.Controls.Add(this.subBtn_SearchEmp);
            this.employeesPnl.Controls.Add(this.subBtn_UpdateEmp);
            this.employeesPnl.Controls.Add(this.subBtn_AddEmp);
            this.employeesPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.employeesPnl.Location = new System.Drawing.Point(0, 450);
            this.employeesPnl.Name = "employeesPnl";
            this.employeesPnl.Size = new System.Drawing.Size(365, 140);
            this.employeesPnl.TabIndex = 18;
            this.employeesPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.employeesPnl_Paint);
            // 
            // subBtn_SearchEmp
            // 
            this.subBtn_SearchEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(99)))));
            this.subBtn_SearchEmp.Dock = System.Windows.Forms.DockStyle.Top;
            this.subBtn_SearchEmp.FlatAppearance.BorderSize = 0;
            this.subBtn_SearchEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subBtn_SearchEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subBtn_SearchEmp.Location = new System.Drawing.Point(0, 95);
            this.subBtn_SearchEmp.Name = "subBtn_SearchEmp";
            this.subBtn_SearchEmp.Padding = new System.Windows.Forms.Padding(130, 0, 0, 0);
            this.subBtn_SearchEmp.Size = new System.Drawing.Size(365, 45);
            this.subBtn_SearchEmp.TabIndex = 2;
            this.subBtn_SearchEmp.Text = "Delete";
            this.subBtn_SearchEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subBtn_SearchEmp.UseVisualStyleBackColor = false;
            this.subBtn_SearchEmp.Click += new System.EventHandler(this.subBtn_SearchEmp_Click);
            // 
            // subBtn_UpdateEmp
            // 
            this.subBtn_UpdateEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(99)))));
            this.subBtn_UpdateEmp.Dock = System.Windows.Forms.DockStyle.Top;
            this.subBtn_UpdateEmp.FlatAppearance.BorderSize = 0;
            this.subBtn_UpdateEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subBtn_UpdateEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subBtn_UpdateEmp.Location = new System.Drawing.Point(0, 50);
            this.subBtn_UpdateEmp.Name = "subBtn_UpdateEmp";
            this.subBtn_UpdateEmp.Padding = new System.Windows.Forms.Padding(130, 0, 0, 0);
            this.subBtn_UpdateEmp.Size = new System.Drawing.Size(365, 45);
            this.subBtn_UpdateEmp.TabIndex = 1;
            this.subBtn_UpdateEmp.Text = "Update";
            this.subBtn_UpdateEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subBtn_UpdateEmp.UseVisualStyleBackColor = false;
            this.subBtn_UpdateEmp.Click += new System.EventHandler(this.subBtn_UpdateEmp_Click);
            // 
            // subBtn_AddEmp
            // 
            this.subBtn_AddEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(99)))));
            this.subBtn_AddEmp.Dock = System.Windows.Forms.DockStyle.Top;
            this.subBtn_AddEmp.FlatAppearance.BorderSize = 0;
            this.subBtn_AddEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subBtn_AddEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subBtn_AddEmp.ForeColor = System.Drawing.Color.White;
            this.subBtn_AddEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subBtn_AddEmp.Location = new System.Drawing.Point(0, 0);
            this.subBtn_AddEmp.Name = "subBtn_AddEmp";
            this.subBtn_AddEmp.Padding = new System.Windows.Forms.Padding(130, 0, 0, 0);
            this.subBtn_AddEmp.Size = new System.Drawing.Size(365, 50);
            this.subBtn_AddEmp.TabIndex = 0;
            this.subBtn_AddEmp.Text = "Add";
            this.subBtn_AddEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subBtn_AddEmp.UseVisualStyleBackColor = false;
            this.subBtn_AddEmp.Click += new System.EventHandler(this.subBtn_AddEmp_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(37)))), ((int)(((byte)(83)))));
            this.btnEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEmployees.ForeColor = System.Drawing.Color.White;
            this.btnEmployees.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployees.Image")));
            this.btnEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.Location = new System.Drawing.Point(0, 375);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnEmployees.Size = new System.Drawing.Size(365, 75);
            this.btnEmployees.TabIndex = 17;
            this.btnEmployees.Text = "             Employees";
            this.btnEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.UseVisualStyleBackColor = false;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(37)))), ((int)(((byte)(83)))));
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 300);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(365, 75);
            this.btnDashboard.TabIndex = 16;
            this.btnDashboard.Text = "             Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(37)))), ((int)(((byte)(83)))));
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(365, 300);
            this.flowLayoutPanel1.TabIndex = 15;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 64);
            this.label2.TabIndex = 22;
            this.label2.Text = "Logo\r\nApp Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // employees1
            // 
            this.employees1.AutoScroll = true;
            this.employees1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.employees1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employees1.Location = new System.Drawing.Point(0, 0);
            this.employees1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employees1.Name = "employees1";
            this.employees1.Size = new System.Drawing.Size(1902, 1033);
            this.employees1.TabIndex = 15;
            // 
            // attendance1
            // 
            this.attendance1.AutoScroll = true;
            this.attendance1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.attendance1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attendance1.Location = new System.Drawing.Point(0, 0);
            this.attendance1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.attendance1.Name = "attendance1";
            this.attendance1.Size = new System.Drawing.Size(1902, 1033);
            this.attendance1.TabIndex = 16;
            // 
            // employeeSadd_revised1
            // 
            this.employeeSadd_revised1.AutoScroll = true;
            this.employeeSadd_revised1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.employeeSadd_revised1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeSadd_revised1.Location = new System.Drawing.Point(0, 0);
            this.employeeSadd_revised1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeeSadd_revised1.Name = "employeeSadd_revised1";
            this.employeeSadd_revised1.Size = new System.Drawing.Size(1902, 1033);
            this.employeeSadd_revised1.TabIndex = 17;
            // 
            // employeeSupdate_revised1
            // 
            this.employeeSupdate_revised1.AutoScroll = true;
            this.employeeSupdate_revised1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.employeeSupdate_revised1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeSupdate_revised1.Location = new System.Drawing.Point(0, 0);
            this.employeeSupdate_revised1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeeSupdate_revised1.Name = "employeeSupdate_revised1";
            this.employeeSupdate_revised1.Size = new System.Drawing.Size(1902, 1033);
            this.employeeSupdate_revised1.TabIndex = 18;
            // 
            // employeeSdelete2
            // 
            this.employeeSdelete2.AutoScroll = true;
            this.employeeSdelete2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.employeeSdelete2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeSdelete2.Location = new System.Drawing.Point(0, 0);
            this.employeeSdelete2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeeSdelete2.Name = "employeeSdelete2";
            this.employeeSdelete2.Size = new System.Drawing.Size(1902, 1033);
            this.employeeSdelete2.TabIndex = 19;
            // 
            // dashboard1
            // 
            this.dashboard1.AutoScroll = true;
            this.dashboard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.dashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(1902, 1033);
            this.dashboard1.TabIndex = 20;
            // 
            // attendancEreport1
            // 
            this.attendancEreport1.AutoScroll = true;
            this.attendancEreport1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.attendancEreport1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attendancEreport1.Location = new System.Drawing.Point(0, 0);
            this.attendancEreport1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.attendancEreport1.Name = "attendancEreport1";
            this.attendancEreport1.Size = new System.Drawing.Size(1902, 1033);
            this.attendancEreport1.TabIndex = 22;
            // 
            // attendancEdutyduration1
            // 
            this.attendancEdutyduration1.AutoScroll = true;
            this.attendancEdutyduration1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.attendancEdutyduration1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attendancEdutyduration1.Location = new System.Drawing.Point(365, 0);
            this.attendancEdutyduration1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.attendancEdutyduration1.Name = "attendancEdutyduration1";
            this.attendancEdutyduration1.Size = new System.Drawing.Size(1537, 1033);
            this.attendancEdutyduration1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(365, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1537, 1033);
            this.panel2.TabIndex = 24;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.attendancEdutyduration1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dashboard1);
            this.Controls.Add(this.employeeSdelete2);
            this.Controls.Add(this.employeeSupdate_revised1);
            this.Controls.Add(this.employeeSadd_revised1);
            this.Controls.Add(this.attendance1);
            this.Controls.Add(this.employees1);
            this.Controls.Add(this.attendancEreport1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Tag = "";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.app_bg_Load_1);
            this.panel1.ResumeLayout(false);
            this.pnl_IndicatorAttendance.ResumeLayout(false);
            this.attendancePnl.ResumeLayout(false);
            this.attendanceReport_SubSubPnl.ResumeLayout(false);
            this.pnl_IndicatorEmployees.ResumeLayout(false);
            this.pnl_IndicatorDashboard.ResumeLayout(false);
            this.employeesPnl.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Panel employeesPnl;
        private Button subBtn_SearchEmp;
        private Button subBtn_UpdateEmp;
        private Button subBtn_AddEmp;
        private Button btnEmployees;
        private Button btnDashboard;
        private FlowLayoutPanel flowLayoutPanel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label2;
        private btn_one indicatorDashboard;
        private btn_one btn_one1;
        private btn_one btn_one4;
        private employeeAdd employeeAdd1;
        private EMPLOYEESupdate employeeSupdate1;
        private ATTENDANCE attendance1;
        private SALARY salary1;
        private EMPLOYEESdelete employeeSdelete1;
        private ATTENDANCEdutyduration Attendancedprtmnt1;
        private Button button8;
        private Button button3;
        private Panel attendancePnl;
        private Panel attendanceReport_SubSubPnl;
        private Button button10;
        private Button button9;
        private Button button11;
        private Button button12;
        private Button button7;
        private Panel pnl_IndicatorAttendance;
        private Panel pnl_IndicatorEmployees;
        private Panel pnl_IndicatorDashboard;
        private EMPLOYEES employees1;
        private EMPLOYEESadd_revised employeeSadd_revised1;
        private EMPLOYEESupdate_revised employeeSupdate_revised1;
        private EMPLOYEESdelete employeeSdelete2;
        private dashboard dashboard1;
        private ATTENDANCEreport attendancEreport1;
        private ATTENDANCEdutyduration attendancEdutyduration1;
        private btn_one LogoutBtn;
        private Panel panel2;
    }
}