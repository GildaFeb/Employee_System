namespace EMS
{
    partial class EMPLOYEESdelete
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EMPLOYEESdelete));
            this.tableDelete_DGV = new System.Windows.Forms.DataGridView();
            this.delete_ChckBx = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateJoined = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoInCaseOfEmergency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Search = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.db_ViewCalendarBtn = new EMS.btn_one();
            this.clear_check = new EMS.btn_one();
            this.delete = new EMS.btn_one();
            ((System.ComponentModel.ISupportInitialize)(this.tableDelete_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableDelete_DGV
            // 
            this.tableDelete_DGV.AllowUserToResizeColumns = false;
            this.tableDelete_DGV.AllowUserToResizeRows = false;
            this.tableDelete_DGV.BackgroundColor = System.Drawing.Color.White;
            this.tableDelete_DGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableDelete_DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableDelete_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tableDelete_DGV.ColumnHeadersHeight = 29;
            this.tableDelete_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tableDelete_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.delete_ChckBx,
            this.idNumber,
            this.dateJoined,
            this.lastName,
            this.firstName,
            this.middleName,
            this.position,
            this.salary,
            this.age,
            this.sex,
            this.dateOfBirth,
            this.contactAddress,
            this.contactNumber,
            this.emailAddress,
            this.contactNoInCaseOfEmergency});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableDelete_DGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.tableDelete_DGV.GridColor = System.Drawing.Color.DarkGray;
            this.tableDelete_DGV.Location = new System.Drawing.Point(125, 256);
            this.tableDelete_DGV.Name = "tableDelete_DGV";
            this.tableDelete_DGV.RowHeadersWidth = 51;
            this.tableDelete_DGV.RowTemplate.Height = 29;
            this.tableDelete_DGV.Size = new System.Drawing.Size(1305, 557);
            this.tableDelete_DGV.TabIndex = 0;
            this.tableDelete_DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // delete_ChckBx
            // 
            this.delete_ChckBx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.NullValue = false;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.delete_ChckBx.DefaultCellStyle = dataGridViewCellStyle2;
            this.delete_ChckBx.HeaderText = "";
            this.delete_ChckBx.MinimumWidth = 6;
            this.delete_ChckBx.Name = "delete_ChckBx";
            this.delete_ChckBx.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete_ChckBx.Width = 29;
            // 
            // idNumber
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.idNumber.DefaultCellStyle = dataGridViewCellStyle3;
            this.idNumber.HeaderText = "ID Number";
            this.idNumber.MinimumWidth = 6;
            this.idNumber.Name = "idNumber";
            this.idNumber.Width = 125;
            // 
            // dateJoined
            // 
            this.dateJoined.HeaderText = "Date joined";
            this.dateJoined.MinimumWidth = 6;
            this.dateJoined.Name = "dateJoined";
            this.dateJoined.Width = 125;
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Last name";
            this.lastName.MinimumWidth = 6;
            this.lastName.Name = "lastName";
            this.lastName.Width = 175;
            // 
            // firstName
            // 
            this.firstName.HeaderText = "First name";
            this.firstName.MinimumWidth = 6;
            this.firstName.Name = "firstName";
            this.firstName.Width = 175;
            // 
            // middleName
            // 
            this.middleName.HeaderText = "Middle Name";
            this.middleName.MinimumWidth = 6;
            this.middleName.Name = "middleName";
            this.middleName.Width = 175;
            // 
            // position
            // 
            this.position.HeaderText = "Position";
            this.position.MinimumWidth = 6;
            this.position.Name = "position";
            this.position.Width = 175;
            // 
            // salary
            // 
            this.salary.HeaderText = "Salary";
            this.salary.MinimumWidth = 6;
            this.salary.Name = "salary";
            this.salary.Width = 175;
            // 
            // age
            // 
            this.age.HeaderText = "Age";
            this.age.MinimumWidth = 6;
            this.age.Name = "age";
            this.age.Width = 125;
            // 
            // sex
            // 
            this.sex.HeaderText = "Sex";
            this.sex.MinimumWidth = 6;
            this.sex.Name = "sex";
            this.sex.Width = 125;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.HeaderText = "Date of birth";
            this.dateOfBirth.MinimumWidth = 6;
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Width = 150;
            // 
            // contactAddress
            // 
            this.contactAddress.HeaderText = "Contact Address";
            this.contactAddress.MinimumWidth = 6;
            this.contactAddress.Name = "contactAddress";
            this.contactAddress.Width = 300;
            // 
            // contactNumber
            // 
            this.contactNumber.HeaderText = "Contact Number";
            this.contactNumber.MinimumWidth = 6;
            this.contactNumber.Name = "contactNumber";
            this.contactNumber.Width = 225;
            // 
            // emailAddress
            // 
            this.emailAddress.HeaderText = "Email Address";
            this.emailAddress.MinimumWidth = 6;
            this.emailAddress.Name = "emailAddress";
            this.emailAddress.Width = 300;
            // 
            // contactNoInCaseOfEmergency
            // 
            this.contactNoInCaseOfEmergency.HeaderText = "Contact no. in case of emergency";
            this.contactNoInCaseOfEmergency.MinimumWidth = 6;
            this.contactNoInCaseOfEmergency.Name = "contactNoInCaseOfEmergency";
            this.contactNoInCaseOfEmergency.Width = 350;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(119, 161);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(764, 22);
            this.label6.TabIndex = 74;
            this.label6.Text = "Search for the ID number or check the check box of the employee you want to delet" +
    "e\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(114, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 46);
            this.label1.TabIndex = 73;
            this.label1.Text = "Delete employee";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1025, 96);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 77;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Search
            // 
            this.Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Search.ForeColor = System.Drawing.Color.DarkGray;
            this.Search.Location = new System.Drawing.Point(1066, 99);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(341, 23);
            this.Search.TabIndex = 75;
            this.Search.Text = "Search";
            this.Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1008, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(422, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // db_ViewCalendarBtn
            // 
            this.db_ViewCalendarBtn.BackColor = System.Drawing.Color.White;
            this.db_ViewCalendarBtn.FlatAppearance.BorderSize = 0;
            this.db_ViewCalendarBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.db_ViewCalendarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.db_ViewCalendarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.db_ViewCalendarBtn.ForeColor = System.Drawing.Color.White;
            this.db_ViewCalendarBtn.Location = new System.Drawing.Point(125, 231);
            this.db_ViewCalendarBtn.Name = "db_ViewCalendarBtn";
            this.db_ViewCalendarBtn.Size = new System.Drawing.Size(1305, 605);
            this.db_ViewCalendarBtn.TabIndex = 79;
            this.db_ViewCalendarBtn.UseVisualStyleBackColor = false;
            this.db_ViewCalendarBtn.Click += new System.EventHandler(this.db_ViewCalendarBtn_Click);
            // 
            // clear_check
            // 
            this.clear_check.BackColor = System.Drawing.Color.DarkGray;
            this.clear_check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_check.FlatAppearance.BorderSize = 0;
            this.clear_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clear_check.ForeColor = System.Drawing.Color.Black;
            this.clear_check.Location = new System.Drawing.Point(125, 873);
            this.clear_check.Name = "clear_check";
            this.clear_check.Size = new System.Drawing.Size(165, 51);
            this.clear_check.TabIndex = 125;
            this.clear_check.Text = "Clear checked";
            this.clear_check.UseVisualStyleBackColor = false;
            this.clear_check.Click += new System.EventHandler(this.btn_one1_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(1295, 873);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(135, 51);
            this.delete.TabIndex = 126;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.btn_one3_Click);
            // 
            // EMPLOYEESdelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.clear_check);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableDelete_DGV);
            this.Controls.Add(this.db_ViewCalendarBtn);
            this.Location = new System.Drawing.Point(356, 50);
            this.Name = "EMPLOYEESdelete";
            this.Size = new System.Drawing.Size(1555, 1033);
            this.Load += new System.EventHandler(this.EMPLOYEESdelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableDelete_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView tableDelete_DGV;
        private Label label6;
        private Label label1;
        private PictureBox pictureBox2;
        private TextBox Search;
        private PictureBox pictureBox1;
        private btn_one db_ViewCalendarBtn;
        private DataGridViewCheckBoxColumn delete_ChckBx;
        private DataGridViewTextBoxColumn idNumber;
        private DataGridViewTextBoxColumn dateJoined;
        private DataGridViewTextBoxColumn lastName;
        private DataGridViewTextBoxColumn firstName;
        private DataGridViewTextBoxColumn middleName;
        private DataGridViewTextBoxColumn position;
        private DataGridViewTextBoxColumn salary;
        private DataGridViewTextBoxColumn age;
        private DataGridViewTextBoxColumn sex;
        private DataGridViewTextBoxColumn dateOfBirth;
        private DataGridViewTextBoxColumn contactAddress;
        private DataGridViewTextBoxColumn contactNumber;
        private DataGridViewTextBoxColumn emailAddress;
        private DataGridViewTextBoxColumn contactNoInCaseOfEmergency;
        private btn_one clear_check;
        private btn_one delete;
    }
}
