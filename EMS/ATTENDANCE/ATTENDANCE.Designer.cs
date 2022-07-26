namespace EMS
{
    partial class _ATTENDANCE
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_ATTENDANCE));
            this.employeesTitlePage = new System.Windows.Forms.Label();
            this.timeTmr_Attendance = new System.Windows.Forms.Timer(this.components);
            this.clockLbl_Attendance = new System.Windows.Forms.Label();
            this.dayTodayLbl_Attendance = new System.Windows.Forms.Label();
            this.attendanceReport = new EMS.btn_one();
            this.btn_one2 = new EMS.btn_one();
            this.duty_addBtn = new EMS.btn_one();
            this.duty_updateBtn = new EMS.btn_one();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.duty_deleteBtn = new EMS.btn_one();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // employeesTitlePage
            // 
            this.employeesTitlePage.AutoSize = true;
            this.employeesTitlePage.BackColor = System.Drawing.Color.Transparent;
            this.employeesTitlePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.employeesTitlePage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(51)))));
            this.employeesTitlePage.Location = new System.Drawing.Point(61, 76);
            this.employeesTitlePage.Name = "employeesTitlePage";
            this.employeesTitlePage.Size = new System.Drawing.Size(199, 39);
            this.employeesTitlePage.TabIndex = 25;
            this.employeesTitlePage.Text = "Attendance";
            // 
            // timeTmr_Attendance
            // 
            this.timeTmr_Attendance.Tick += new System.EventHandler(this.timeTmr_Attendance_Tick);
            // 
            // clockLbl_Attendance
            // 
            this.clockLbl_Attendance.AutoSize = true;
            this.clockLbl_Attendance.BackColor = System.Drawing.Color.Transparent;
            this.clockLbl_Attendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clockLbl_Attendance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(51)))));
            this.clockLbl_Attendance.Location = new System.Drawing.Point(1021, 70);
            this.clockLbl_Attendance.Name = "clockLbl_Attendance";
            this.clockLbl_Attendance.Size = new System.Drawing.Size(220, 39);
            this.clockLbl_Attendance.TabIndex = 91;
            this.clockLbl_Attendance.Text = "11:11:11 pm";
            this.clockLbl_Attendance.Click += new System.EventHandler(this.clockLbl_Click);
            // 
            // dayTodayLbl_Attendance
            // 
            this.dayTodayLbl_Attendance.AutoSize = true;
            this.dayTodayLbl_Attendance.BackColor = System.Drawing.Color.Transparent;
            this.dayTodayLbl_Attendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dayTodayLbl_Attendance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(51)))));
            this.dayTodayLbl_Attendance.Location = new System.Drawing.Point(1056, 121);
            this.dayTodayLbl_Attendance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dayTodayLbl_Attendance.Name = "dayTodayLbl_Attendance";
            this.dayTodayLbl_Attendance.Size = new System.Drawing.Size(164, 17);
            this.dayTodayLbl_Attendance.TabIndex = 92;
            this.dayTodayLbl_Attendance.Text = "SUNDAY, June 19, 2022";
            // 
            // attendanceReport
            // 
            this.attendanceReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.attendanceReport.FlatAppearance.BorderSize = 0;
            this.attendanceReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attendanceReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.attendanceReport.ForeColor = System.Drawing.Color.White;
            this.attendanceReport.Image = ((System.Drawing.Image)(resources.GetObject("attendanceReport.Image")));
            this.attendanceReport.Location = new System.Drawing.Point(987, 284);
            this.attendanceReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.attendanceReport.Name = "attendanceReport";
            this.attendanceReport.Padding = new System.Windows.Forms.Padding(0, 0, 0, 34);
            this.attendanceReport.Size = new System.Drawing.Size(271, 234);
            this.attendanceReport.TabIndex = 93;
            this.attendanceReport.Text = "Attendance report";
            this.attendanceReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.attendanceReport.UseVisualStyleBackColor = false;
            this.attendanceReport.Click += new System.EventHandler(this.attendanceReport_Click);
            // 
            // btn_one2
            // 
            this.btn_one2.BackColor = System.Drawing.Color.White;
            this.btn_one2.FlatAppearance.BorderSize = 0;
            this.btn_one2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_one2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_one2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_one2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_one2.ForeColor = System.Drawing.Color.White;
            this.btn_one2.Location = new System.Drawing.Point(41, 284);
            this.btn_one2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_one2.Name = "btn_one2";
            this.btn_one2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 34);
            this.btn_one2.Size = new System.Drawing.Size(909, 234);
            this.btn_one2.TabIndex = 94;
            this.btn_one2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_one2.UseVisualStyleBackColor = false;
            // 
            // duty_addBtn
            // 
            this.duty_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(202)))), ((int)(((byte)(63)))));
            this.duty_addBtn.FlatAppearance.BorderSize = 0;
            this.duty_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.duty_addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.duty_addBtn.ForeColor = System.Drawing.Color.White;
            this.duty_addBtn.Image = ((System.Drawing.Image)(resources.GetObject("duty_addBtn.Image")));
            this.duty_addBtn.Location = new System.Drawing.Point(326, 313);
            this.duty_addBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.duty_addBtn.Name = "duty_addBtn";
            this.duty_addBtn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 22);
            this.duty_addBtn.Size = new System.Drawing.Size(174, 175);
            this.duty_addBtn.TabIndex = 93;
            this.duty_addBtn.Text = "Add";
            this.duty_addBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.duty_addBtn.UseVisualStyleBackColor = false;
            this.duty_addBtn.Click += new System.EventHandler(this.duty_addBtn_Click);
            // 
            // duty_updateBtn
            // 
            this.duty_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(0)))));
            this.duty_updateBtn.FlatAppearance.BorderSize = 0;
            this.duty_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.duty_updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.duty_updateBtn.ForeColor = System.Drawing.Color.White;
            this.duty_updateBtn.Image = ((System.Drawing.Image)(resources.GetObject("duty_updateBtn.Image")));
            this.duty_updateBtn.Location = new System.Drawing.Point(526, 313);
            this.duty_updateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.duty_updateBtn.Name = "duty_updateBtn";
            this.duty_updateBtn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 22);
            this.duty_updateBtn.Size = new System.Drawing.Size(174, 175);
            this.duty_updateBtn.TabIndex = 93;
            this.duty_updateBtn.Text = "Update";
            this.duty_updateBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.duty_updateBtn.UseVisualStyleBackColor = false;
            this.duty_updateBtn.Click += new System.EventHandler(this.duty_updateBtn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(250, 304);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 194);
            this.pictureBox3.TabIndex = 110;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(94, 335);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 111;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(165)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(88, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Duty duration";
            // 
            // duty_deleteBtn
            // 
            this.duty_deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.duty_deleteBtn.FlatAppearance.BorderSize = 0;
            this.duty_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.duty_deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.duty_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.duty_deleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("duty_deleteBtn.Image")));
            this.duty_deleteBtn.Location = new System.Drawing.Point(726, 313);
            this.duty_deleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.duty_deleteBtn.Name = "duty_deleteBtn";
            this.duty_deleteBtn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 22);
            this.duty_deleteBtn.Size = new System.Drawing.Size(174, 175);
            this.duty_deleteBtn.TabIndex = 93;
            this.duty_deleteBtn.Text = "Delete";
            this.duty_deleteBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.duty_deleteBtn.UseVisualStyleBackColor = false;
            this.duty_deleteBtn.Click += new System.EventHandler(this.duty_deleteBtn_Click);
            // 
            // _ATTENDANCE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.duty_deleteBtn);
            this.Controls.Add(this.duty_updateBtn);
            this.Controls.Add(this.duty_addBtn);
            this.Controls.Add(this.attendanceReport);
            this.Controls.Add(this.dayTodayLbl_Attendance);
            this.Controls.Add(this.clockLbl_Attendance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeesTitlePage);
            this.Controls.Add(this.btn_one2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "_ATTENDANCE";
            this.Size = new System.Drawing.Size(1345, 775);
            this.Load += new System.EventHandler(this.ATTENDANCE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label employeesTitlePage;
        private System.Windows.Forms.Timer timeTmr_Attendance;
        private Label clockLbl_Attendance;
        private Label dayTodayLbl_Attendance;
        private btn_one emp_Addbtn;
        private btn_one btn_one2;
        private btn_one btn_one3;
        private btn_one btn_one4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Label label1;
        private btn_one btn_one1;
        private btn_one duty_addBtn;
        private btn_one updateBtn;
        private btn_one duty_deleteBtn;
        private btn_one duty_updateBtn;
        private btn_one attendanceReport;
    }
}
