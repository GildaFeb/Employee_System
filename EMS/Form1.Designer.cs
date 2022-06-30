namespace EMS
{
    partial class forms1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forms1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_one4 = new EMS.btn_one();
            this.pnl_IndicatorAttendance = new System.Windows.Forms.Panel();
            this.btn_one2 = new EMS.btn_one();
            this.pnl_IndicatorEmployees = new System.Windows.Forms.Panel();
            this.btn_one1 = new EMS.btn_one();
            this.pnl_IndicatorDashboard = new System.Windows.Forms.Panel();
            this.indicatorDashboard = new EMS.btn_one();
            this.attendancePnl = new System.Windows.Forms.Panel();
            this.button19 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.employeesPnl = new System.Windows.Forms.Panel();
            this.subBtn_SearchEmp = new System.Windows.Forms.Button();
            this.subBtn_UpdateEmp = new System.Windows.Forms.Button();
            this.subBtn_AddEmp = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dashboard1 = new EMS.dashboard();
            this.employees1 = new EMS.EMPLOYEES();
            this.panel1.SuspendLayout();
            this.pnl_IndicatorAttendance.SuspendLayout();
            this.pnl_IndicatorEmployees.SuspendLayout();
            this.pnl_IndicatorDashboard.SuspendLayout();
            this.attendancePnl.SuspendLayout();
            this.employeesPnl.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(37)))), ((int)(((byte)(83)))));
            this.panel1.Controls.Add(this.btn_one4);
            this.panel1.Controls.Add(this.pnl_IndicatorAttendance);
            this.panel1.Controls.Add(this.pnl_IndicatorEmployees);
            this.panel1.Controls.Add(this.pnl_IndicatorDashboard);
            this.panel1.Controls.Add(this.attendancePnl);
            this.panel1.Controls.Add(this.btnAttendance);
            this.panel1.Controls.Add(this.employeesPnl);
            this.panel1.Controls.Add(this.btnEmployees);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 1033);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // btn_one4
            // 
            this.btn_one4.BackColor = System.Drawing.Color.White;
            this.btn_one4.FlatAppearance.BorderSize = 0;
            this.btn_one4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_one4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_one4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(51)))));
            this.btn_one4.Location = new System.Drawing.Point(89, 848);
            this.btn_one4.Name = "btn_one4";
            this.btn_one4.Size = new System.Drawing.Size(176, 50);
            this.btn_one4.TabIndex = 88;
            this.btn_one4.Text = "Log out";
            this.btn_one4.UseVisualStyleBackColor = false;
            // 
            // pnl_IndicatorAttendance
            // 
            this.pnl_IndicatorAttendance.BackColor = System.Drawing.Color.Transparent;
            this.pnl_IndicatorAttendance.Controls.Add(this.btn_one2);
            this.pnl_IndicatorAttendance.Location = new System.Drawing.Point(0, 422);
            this.pnl_IndicatorAttendance.Name = "pnl_IndicatorAttendance";
            this.pnl_IndicatorAttendance.Size = new System.Drawing.Size(16, 75);
            this.pnl_IndicatorAttendance.TabIndex = 15;
            this.pnl_IndicatorAttendance.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_3);
            // 
            // btn_one2
            // 
            this.btn_one2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(233)))), ((int)(((byte)(32)))));
            this.btn_one2.FlatAppearance.BorderSize = 0;
            this.btn_one2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_one2.ForeColor = System.Drawing.Color.White;
            this.btn_one2.Location = new System.Drawing.Point(-20, 12);
            this.btn_one2.Name = "btn_one2";
            this.btn_one2.Size = new System.Drawing.Size(24, 51);
            this.btn_one2.TabIndex = 23;
            this.btn_one2.Text = "btn_one1";
            this.btn_one2.UseVisualStyleBackColor = false;
            this.btn_one2.Click += new System.EventHandler(this.btn_one1_Click);
            // 
            // pnl_IndicatorEmployees
            // 
            this.pnl_IndicatorEmployees.BackColor = System.Drawing.Color.Transparent;
            this.pnl_IndicatorEmployees.Controls.Add(this.btn_one1);
            this.pnl_IndicatorEmployees.Location = new System.Drawing.Point(0, 347);
            this.pnl_IndicatorEmployees.Name = "pnl_IndicatorEmployees";
            this.pnl_IndicatorEmployees.Size = new System.Drawing.Size(16, 75);
            this.pnl_IndicatorEmployees.TabIndex = 15;
            this.pnl_IndicatorEmployees.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_3);
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
            this.btn_one1.Click += new System.EventHandler(this.btn_one1_Click);
            // 
            // pnl_IndicatorDashboard
            // 
            this.pnl_IndicatorDashboard.BackColor = System.Drawing.Color.Transparent;
            this.pnl_IndicatorDashboard.Controls.Add(this.indicatorDashboard);
            this.pnl_IndicatorDashboard.Location = new System.Drawing.Point(0, 272);
            this.pnl_IndicatorDashboard.Name = "pnl_IndicatorDashboard";
            this.pnl_IndicatorDashboard.Size = new System.Drawing.Size(16, 75);
            this.pnl_IndicatorDashboard.TabIndex = 15;
            this.pnl_IndicatorDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_3);
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
            this.indicatorDashboard.Click += new System.EventHandler(this.btn_one1_Click);
            // 
            // attendancePnl
            // 
            this.attendancePnl.Controls.Add(this.button19);
            this.attendancePnl.Controls.Add(this.button17);
            this.attendancePnl.Controls.Add(this.button14);
            this.attendancePnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.attendancePnl.Location = new System.Drawing.Point(0, 636);
            this.attendancePnl.Name = "attendancePnl";
            this.attendancePnl.Size = new System.Drawing.Size(347, 151);
            this.attendancePnl.TabIndex = 20;
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(99)))));
            this.button19.Dock = System.Windows.Forms.DockStyle.Top;
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button19.Location = new System.Drawing.Point(0, 100);
            this.button19.Name = "button19";
            this.button19.Padding = new System.Windows.Forms.Padding(130, 0, 0, 0);
            this.button19.Size = new System.Drawing.Size(347, 47);
            this.button19.TabIndex = 3;
            this.button19.Text = "Leave management";
            this.button19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(99)))));
            this.button17.Dock = System.Windows.Forms.DockStyle.Top;
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button17.Location = new System.Drawing.Point(0, 50);
            this.button17.Name = "button17";
            this.button17.Padding = new System.Windows.Forms.Padding(130, 0, 0, 0);
            this.button17.Size = new System.Drawing.Size(347, 50);
            this.button17.TabIndex = 2;
            this.button17.Text = "Duty duration";
            this.button17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(99)))));
            this.button14.Dock = System.Windows.Forms.DockStyle.Top;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button14.Location = new System.Drawing.Point(0, 0);
            this.button14.Name = "button14";
            this.button14.Padding = new System.Windows.Forms.Padding(130, 0, 0, 0);
            this.button14.Size = new System.Drawing.Size(347, 50);
            this.button14.TabIndex = 1;
            this.button14.Text = "Attendance report";
            this.button14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click_1);
            // 
            // btnAttendance
            // 
            this.btnAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(37)))), ((int)(((byte)(83)))));
            this.btnAttendance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAttendance.FlatAppearance.BorderSize = 0;
            this.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAttendance.ForeColor = System.Drawing.Color.White;
            this.btnAttendance.Image = ((System.Drawing.Image)(resources.GetObject("btnAttendance.Image")));
            this.btnAttendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttendance.Location = new System.Drawing.Point(0, 561);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnAttendance.Size = new System.Drawing.Size(347, 75);
            this.btnAttendance.TabIndex = 19;
            this.btnAttendance.Text = "                  Attendance";
            this.btnAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttendance.UseVisualStyleBackColor = false;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // employeesPnl
            // 
            this.employeesPnl.Controls.Add(this.subBtn_SearchEmp);
            this.employeesPnl.Controls.Add(this.subBtn_UpdateEmp);
            this.employeesPnl.Controls.Add(this.subBtn_AddEmp);
            this.employeesPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.employeesPnl.Location = new System.Drawing.Point(0, 422);
            this.employeesPnl.Name = "employeesPnl";
            this.employeesPnl.Size = new System.Drawing.Size(347, 139);
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
            this.subBtn_SearchEmp.Size = new System.Drawing.Size(347, 45);
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
            this.subBtn_UpdateEmp.Size = new System.Drawing.Size(347, 45);
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
            this.subBtn_AddEmp.Size = new System.Drawing.Size(347, 50);
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
            this.btnEmployees.Location = new System.Drawing.Point(0, 347);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnEmployees.Size = new System.Drawing.Size(347, 75);
            this.btnEmployees.TabIndex = 17;
            this.btnEmployees.Text = "                  Employees";
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
            this.btnDashboard.Location = new System.Drawing.Point(0, 272);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(347, 75);
            this.btnDashboard.TabIndex = 16;
            this.btnDashboard.Text = "                  Dashboard";
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(347, 272);
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
            this.label2.Size = new System.Drawing.Size(124, 52);
            this.label2.TabIndex = 22;
            this.label2.Text = "Logo\r\nApp Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // dashboard1
            // 
            this.dashboard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.dashboard1.Location = new System.Drawing.Point(347, 0);
            this.dashboard1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(1555, 1033);
            this.dashboard1.TabIndex = 15;
            this.dashboard1.Load += new System.EventHandler(this.dashboard1_Load_2);
            // 
            // employees1
            // 
            this.employees1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.employees1.Location = new System.Drawing.Point(347, 0);
            this.employees1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employees1.Name = "employees1";
            this.employees1.Size = new System.Drawing.Size(1555, 1033);
            this.employees1.TabIndex = 16;
            this.employees1.Load += new System.EventHandler(this.employees1_Load_1);
            // 
            // forms1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.employees1);
            this.Controls.Add(this.dashboard1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "forms1";
            this.Tag = "";
            this.Text = "App Name";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.app_bg_Load_1);
            this.panel1.ResumeLayout(false);
            this.pnl_IndicatorAttendance.ResumeLayout(false);
            this.pnl_IndicatorEmployees.ResumeLayout(false);
            this.pnl_IndicatorDashboard.ResumeLayout(false);
            this.attendancePnl.ResumeLayout(false);
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
        private Panel attendancePnl;
        private Button button19;
        private Button button17;
        private Button button14;
        private Button btnAttendance;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label2;
        private btn_one indicatorDashboard;
        private Panel pnl_IndicatorDashboard;
        private Panel pnl_IndicatorAttendance;
        private btn_one btn_one2;
        private Panel pnl_IndicatorEmployees;
        private btn_one btn_one1;
        private btn_one btn_one4;
        private dashboard dashboard1;
        private EMPLOYEES employees1;
        private employeeAdd employeeAdd1;
        private EMPLOYEESupdate employeeSupdate1;
        private ATTENDANCE attendance1;
        private SALARY salary1;
        private EMPLOYEESdelete employeeSdelete1;
        private ATTENDANCEdutyduration Attendancedprtmnt1;
    }
}