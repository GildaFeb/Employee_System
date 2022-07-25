namespace EMS
{
    partial class EMPLOYEES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EMPLOYEES));
            this.employeesTitlePage = new System.Windows.Forms.Label();
            this.emp_Addbtn = new EMS.btn_one();
            this.emp_Updatebtn = new EMS.btn_one();
            this.emp_Deletebtn = new EMS.btn_one();
            this.dayTodayLbl_Employees = new System.Windows.Forms.Label();
            this.clockLbl_Employees = new System.Windows.Forms.Label();
            this.timeTmr_Employees = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // employeesTitlePage
            // 
            this.employeesTitlePage.AutoSize = true;
            this.employeesTitlePage.BackColor = System.Drawing.Color.Transparent;
            this.employeesTitlePage.Font = new System.Drawing.Font("SF Pro Display", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.employeesTitlePage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(37)))), ((int)(((byte)(83)))));
            this.employeesTitlePage.Location = new System.Drawing.Point(95, 101);
            this.employeesTitlePage.Name = "employeesTitlePage";
            this.employeesTitlePage.Size = new System.Drawing.Size(230, 50);
            this.employeesTitlePage.TabIndex = 19;
            this.employeesTitlePage.Text = "Employees";
            // 
            // emp_Addbtn
            // 
            this.emp_Addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(202)))), ((int)(((byte)(63)))));
            this.emp_Addbtn.FlatAppearance.BorderSize = 0;
            this.emp_Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emp_Addbtn.Font = new System.Drawing.Font("SF Pro Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emp_Addbtn.ForeColor = System.Drawing.Color.White;
            this.emp_Addbtn.Image = ((System.Drawing.Image)(resources.GetObject("emp_Addbtn.Image")));
            this.emp_Addbtn.Location = new System.Drawing.Point(212, 349);
            this.emp_Addbtn.Name = "emp_Addbtn";
            this.emp_Addbtn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 45);
            this.emp_Addbtn.Size = new System.Drawing.Size(310, 312);
            this.emp_Addbtn.TabIndex = 20;
            this.emp_Addbtn.Text = "Add";
            this.emp_Addbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.emp_Addbtn.UseVisualStyleBackColor = false;
            this.emp_Addbtn.Click += new System.EventHandler(this.btn_one5_Click);
            // 
            // emp_Updatebtn
            // 
            this.emp_Updatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(0)))));
            this.emp_Updatebtn.FlatAppearance.BorderSize = 0;
            this.emp_Updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emp_Updatebtn.Font = new System.Drawing.Font("SF Pro Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emp_Updatebtn.ForeColor = System.Drawing.Color.White;
            this.emp_Updatebtn.Image = ((System.Drawing.Image)(resources.GetObject("emp_Updatebtn.Image")));
            this.emp_Updatebtn.Location = new System.Drawing.Point(611, 349);
            this.emp_Updatebtn.Name = "emp_Updatebtn";
            this.emp_Updatebtn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 45);
            this.emp_Updatebtn.Size = new System.Drawing.Size(310, 312);
            this.emp_Updatebtn.TabIndex = 20;
            this.emp_Updatebtn.Text = "Update";
            this.emp_Updatebtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.emp_Updatebtn.UseVisualStyleBackColor = false;
            this.emp_Updatebtn.Click += new System.EventHandler(this.btn_one5_Click);
            // 
            // emp_Deletebtn
            // 
            this.emp_Deletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.emp_Deletebtn.FlatAppearance.BorderSize = 0;
            this.emp_Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emp_Deletebtn.Font = new System.Drawing.Font("SF Pro Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emp_Deletebtn.ForeColor = System.Drawing.Color.White;
            this.emp_Deletebtn.Image = ((System.Drawing.Image)(resources.GetObject("emp_Deletebtn.Image")));
            this.emp_Deletebtn.Location = new System.Drawing.Point(1012, 349);
            this.emp_Deletebtn.Name = "emp_Deletebtn";
            this.emp_Deletebtn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 45);
            this.emp_Deletebtn.Size = new System.Drawing.Size(310, 312);
            this.emp_Deletebtn.TabIndex = 20;
            this.emp_Deletebtn.Text = "View and Delete";
            this.emp_Deletebtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.emp_Deletebtn.UseVisualStyleBackColor = false;
            this.emp_Deletebtn.Click += new System.EventHandler(this.btn_one5_Click);
            // 
            // dayTodayLbl_Employees
            // 
            this.dayTodayLbl_Employees.AutoSize = true;
            this.dayTodayLbl_Employees.BackColor = System.Drawing.Color.Transparent;
            this.dayTodayLbl_Employees.Font = new System.Drawing.Font("SF Pro Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dayTodayLbl_Employees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(51)))));
            this.dayTodayLbl_Employees.Location = new System.Drawing.Point(1222, 161);
            this.dayTodayLbl_Employees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dayTodayLbl_Employees.Name = "dayTodayLbl_Employees";
            this.dayTodayLbl_Employees.Size = new System.Drawing.Size(199, 20);
            this.dayTodayLbl_Employees.TabIndex = 74;
            this.dayTodayLbl_Employees.Text = "SUNDAY, June 19, 2022";
            // 
            // clockLbl_Employees
            // 
            this.clockLbl_Employees.AutoSize = true;
            this.clockLbl_Employees.BackColor = System.Drawing.Color.Transparent;
            this.clockLbl_Employees.Font = new System.Drawing.Font("SF Pro Display", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clockLbl_Employees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(51)))));
            this.clockLbl_Employees.Location = new System.Drawing.Point(1182, 93);
            this.clockLbl_Employees.Name = "clockLbl_Employees";
            this.clockLbl_Employees.Size = new System.Drawing.Size(244, 51);
            this.clockLbl_Employees.TabIndex = 73;
            this.clockLbl_Employees.Text = "11:11:11 pm";
            this.clockLbl_Employees.Click += new System.EventHandler(this.clockLbl_Click);
            // 
            // timeTmr_Employees
            // 
            this.timeTmr_Employees.Tick += new System.EventHandler(this.timeTmr_Tick);
            // 
            // EMPLOYEES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.dayTodayLbl_Employees);
            this.Controls.Add(this.clockLbl_Employees);
            this.Controls.Add(this.emp_Addbtn);
            this.Controls.Add(this.emp_Deletebtn);
            this.Controls.Add(this.emp_Updatebtn);
            this.Controls.Add(this.employeesTitlePage);
            this.Name = "EMPLOYEES";
            this.Size = new System.Drawing.Size(1555, 1033);
            this.Load += new System.EventHandler(this.EMPLOYEES_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label employeesTitlePage;
        private btn_one emp_Addbtn;
        private btn_one emp_Updatebtn;
        private btn_one emp_Deletebtn;
        private Label dayTodayLbl_Employees;
        private Label clockLbl_Employees;
        private System.Windows.Forms.Timer timeTmr_Employees;
    }
}
