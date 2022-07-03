namespace EMS
{
    partial class ATTENDANCE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATTENDANCE));
            this.employeesTitlePage = new System.Windows.Forms.Label();
            this.timeTmr_Attendance = new System.Windows.Forms.Timer(this.components);
            this.clockLbl_Attendance = new System.Windows.Forms.Label();
            this.dayTodayLbl_Attendance = new System.Windows.Forms.Label();
            this.emp_Addbtn = new EMS.btn_one();
            this.btn_one2 = new EMS.btn_one();
            this.btn_one3 = new EMS.btn_one();
            this.btn_one4 = new EMS.btn_one();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_one1 = new EMS.btn_one();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // employeesTitlePage
            // 
            this.employeesTitlePage.AutoSize = true;
            this.employeesTitlePage.BackColor = System.Drawing.Color.Transparent;
            this.employeesTitlePage.Font = new System.Drawing.Font("SF Pro Display", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.employeesTitlePage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(51)))));
            this.employeesTitlePage.Location = new System.Drawing.Point(95, 101);
            this.employeesTitlePage.Name = "employeesTitlePage";
            this.employeesTitlePage.Size = new System.Drawing.Size(245, 50);
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
            this.clockLbl_Attendance.Font = new System.Drawing.Font("SF Pro Display", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clockLbl_Attendance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(51)))));
            this.clockLbl_Attendance.Location = new System.Drawing.Point(1192, 93);
            this.clockLbl_Attendance.Name = "clockLbl_Attendance";
            this.clockLbl_Attendance.Size = new System.Drawing.Size(244, 51);
            this.clockLbl_Attendance.TabIndex = 91;
            this.clockLbl_Attendance.Text = "11:11:11 pm";
            this.clockLbl_Attendance.Click += new System.EventHandler(this.clockLbl_Click);
            // 
            // dayTodayLbl_Attendance
            // 
            this.dayTodayLbl_Attendance.AutoSize = true;
            this.dayTodayLbl_Attendance.BackColor = System.Drawing.Color.Transparent;
            this.dayTodayLbl_Attendance.Font = new System.Drawing.Font("SF Pro Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dayTodayLbl_Attendance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(51)))));
            this.dayTodayLbl_Attendance.Location = new System.Drawing.Point(1232, 161);
            this.dayTodayLbl_Attendance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dayTodayLbl_Attendance.Name = "dayTodayLbl_Attendance";
            this.dayTodayLbl_Attendance.Size = new System.Drawing.Size(199, 20);
            this.dayTodayLbl_Attendance.TabIndex = 92;
            this.dayTodayLbl_Attendance.Text = "SUNDAY, June 19, 2022";
            // 
            // emp_Addbtn
            // 
            this.emp_Addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.emp_Addbtn.FlatAppearance.BorderSize = 0;
            this.emp_Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emp_Addbtn.Font = new System.Drawing.Font("SF Pro Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emp_Addbtn.ForeColor = System.Drawing.Color.White;
            this.emp_Addbtn.Image = ((System.Drawing.Image)(resources.GetObject("emp_Addbtn.Image")));
            this.emp_Addbtn.Location = new System.Drawing.Point(1153, 378);
            this.emp_Addbtn.Name = "emp_Addbtn";
            this.emp_Addbtn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 45);
            this.emp_Addbtn.Size = new System.Drawing.Size(310, 312);
            this.emp_Addbtn.TabIndex = 93;
            this.emp_Addbtn.Text = "Attendance report";
            this.emp_Addbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.emp_Addbtn.UseVisualStyleBackColor = false;
            // 
            // btn_one2
            // 
            this.btn_one2.BackColor = System.Drawing.Color.White;
            this.btn_one2.FlatAppearance.BorderSize = 0;
            this.btn_one2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_one2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_one2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_one2.Font = new System.Drawing.Font("SF Pro Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_one2.ForeColor = System.Drawing.Color.White;
            this.btn_one2.Location = new System.Drawing.Point(72, 378);
            this.btn_one2.Name = "btn_one2";
            this.btn_one2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 45);
            this.btn_one2.Size = new System.Drawing.Size(1039, 312);
            this.btn_one2.TabIndex = 94;
            this.btn_one2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_one2.UseVisualStyleBackColor = false;
            // 
            // btn_one3
            // 
            this.btn_one3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(202)))), ((int)(((byte)(63)))));
            this.btn_one3.FlatAppearance.BorderSize = 0;
            this.btn_one3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_one3.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_one3.ForeColor = System.Drawing.Color.White;
            this.btn_one3.Image = ((System.Drawing.Image)(resources.GetObject("btn_one3.Image")));
            this.btn_one3.Location = new System.Drawing.Point(397, 417);
            this.btn_one3.Name = "btn_one3";
            this.btn_one3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.btn_one3.Size = new System.Drawing.Size(199, 233);
            this.btn_one3.TabIndex = 93;
            this.btn_one3.Text = "Add";
            this.btn_one3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_one3.UseVisualStyleBackColor = false;
            // 
            // btn_one4
            // 
            this.btn_one4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(0)))));
            this.btn_one4.FlatAppearance.BorderSize = 0;
            this.btn_one4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_one4.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_one4.ForeColor = System.Drawing.Color.White;
            this.btn_one4.Image = ((System.Drawing.Image)(resources.GetObject("btn_one4.Image")));
            this.btn_one4.Location = new System.Drawing.Point(626, 417);
            this.btn_one4.Name = "btn_one4";
            this.btn_one4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.btn_one4.Size = new System.Drawing.Size(199, 233);
            this.btn_one4.TabIndex = 93;
            this.btn_one4.Text = "Update";
            this.btn_one4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_one4.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(311, 406);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 258);
            this.pictureBox3.TabIndex = 110;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(133, 447);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 111;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(165)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(126, 619);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 27);
            this.label1.TabIndex = 25;
            this.label1.Text = "Duty duration";
            // 
            // btn_one1
            // 
            this.btn_one1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btn_one1.FlatAppearance.BorderSize = 0;
            this.btn_one1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_one1.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_one1.ForeColor = System.Drawing.Color.White;
            this.btn_one1.Image = ((System.Drawing.Image)(resources.GetObject("btn_one1.Image")));
            this.btn_one1.Location = new System.Drawing.Point(855, 417);
            this.btn_one1.Name = "btn_one1";
            this.btn_one1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.btn_one1.Size = new System.Drawing.Size(199, 233);
            this.btn_one1.TabIndex = 93;
            this.btn_one1.Text = "Delete";
            this.btn_one1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_one1.UseVisualStyleBackColor = false;
            // 
            // ATTENDANCE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_one1);
            this.Controls.Add(this.btn_one4);
            this.Controls.Add(this.btn_one3);
            this.Controls.Add(this.emp_Addbtn);
            this.Controls.Add(this.dayTodayLbl_Attendance);
            this.Controls.Add(this.clockLbl_Attendance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeesTitlePage);
            this.Controls.Add(this.btn_one2);
            this.Name = "ATTENDANCE";
            this.Size = new System.Drawing.Size(1537, 1033);
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
    }
}
