namespace EMS
{
    partial class ATTENDANCEreport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATTENDANCEreport));
            this.attndncrprt_DGV = new System.Windows.Forms.DataGridView();
            this.delete_ChckBx = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsgntn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Absnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prsnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Leavecol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ttlbr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.db_ViewCalendarBtn = new EMS.btn_one();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Search = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CmbxMonth = new EMS.CComboBox();
            this.CmbxYear = new EMS.CComboBox();
            this.btn_one3 = new EMS.btn_one();
            this.btn_one2 = new EMS.btn_one();
            this.btn_one1 = new EMS.btn_one();
            ((System.ComponentModel.ISupportInitialize)(this.attndncrprt_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // attndncrprt_DGV
            // 
            this.attndncrprt_DGV.AllowUserToResizeColumns = false;
            this.attndncrprt_DGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.attndncrprt_DGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.attndncrprt_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.attndncrprt_DGV.BackgroundColor = System.Drawing.Color.White;
            this.attndncrprt_DGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.attndncrprt_DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.attndncrprt_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.attndncrprt_DGV.ColumnHeadersHeight = 29;
            this.attndncrprt_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.attndncrprt_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.delete_ChckBx,
            this.EmpId,
            this.EmpName,
            this.dsgntn,
            this.Absnt,
            this.Prsnt,
            this.Leavecol,
            this.Ttlbr,
            this.Slry});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.attndncrprt_DGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.attndncrprt_DGV.GridColor = System.Drawing.Color.DarkGray;
            this.attndncrprt_DGV.Location = new System.Drawing.Point(119, 292);
            this.attndncrprt_DGV.Name = "attndncrprt_DGV";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.attndncrprt_DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.attndncrprt_DGV.RowHeadersWidth = 51;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.attndncrprt_DGV.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.attndncrprt_DGV.RowTemplate.Height = 29;
            this.attndncrprt_DGV.Size = new System.Drawing.Size(1322, 575);
            this.attndncrprt_DGV.TabIndex = 1;
            // 
            // delete_ChckBx
            // 
            this.delete_ChckBx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.NullValue = false;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.delete_ChckBx.DefaultCellStyle = dataGridViewCellStyle3;
            this.delete_ChckBx.HeaderText = "";
            this.delete_ChckBx.MinimumWidth = 6;
            this.delete_ChckBx.Name = "delete_ChckBx";
            this.delete_ChckBx.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete_ChckBx.Width = 29;
            // 
            // EmpId
            // 
            this.EmpId.FillWeight = 23.39183F;
            this.EmpId.HeaderText = "Employee ID";
            this.EmpId.MinimumWidth = 6;
            this.EmpId.Name = "EmpId";
            this.EmpId.Width = 163;
            // 
            // EmpName
            // 
            this.EmpName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EmpName.HeaderText = "Employee  Name";
            this.EmpName.MinimumWidth = 6;
            this.EmpName.Name = "EmpName";
            this.EmpName.Width = 200;
            // 
            // dsgntn
            // 
            this.dsgntn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dsgntn.HeaderText = "Designation/Position";
            this.dsgntn.MinimumWidth = 6;
            this.dsgntn.Name = "dsgntn";
            this.dsgntn.Width = 239;
            // 
            // Absnt
            // 
            this.Absnt.FillWeight = 23.39183F;
            this.Absnt.HeaderText = "Absents";
            this.Absnt.MinimumWidth = 6;
            this.Absnt.Name = "Absnt";
            this.Absnt.Width = 120;
            // 
            // Prsnt
            // 
            this.Prsnt.FillWeight = 23.39183F;
            this.Prsnt.HeaderText = "Present";
            this.Prsnt.MinimumWidth = 6;
            this.Prsnt.Name = "Prsnt";
            this.Prsnt.Width = 115;
            // 
            // Leavecol
            // 
            this.Leavecol.FillWeight = 23.39183F;
            this.Leavecol.HeaderText = "Leave";
            this.Leavecol.MinimumWidth = 6;
            this.Leavecol.Name = "Leavecol";
            // 
            // Ttlbr
            // 
            this.Ttlbr.FillWeight = 23.39183F;
            this.Ttlbr.HeaderText = "Duration/Total Labor";
            this.Ttlbr.MinimumWidth = 6;
            this.Ttlbr.Name = "Ttlbr";
            this.Ttlbr.Width = 239;
            // 
            // Slry
            // 
            this.Slry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Slry.HeaderText = "Salary";
            this.Slry.MinimumWidth = 6;
            this.Slry.Name = "Slry";
            this.Slry.Width = 130;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(114, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 48);
            this.label1.TabIndex = 74;
            this.label1.Text = "Attendance Report";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(119, 125);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(735, 22);
            this.label6.TabIndex = 75;
            this.label6.Text = "Kindly see below the attendance of the employee with their corresponding salary.";
            // 
            // db_ViewCalendarBtn
            // 
            this.db_ViewCalendarBtn.BackColor = System.Drawing.Color.White;
            this.db_ViewCalendarBtn.FlatAppearance.BorderSize = 0;
            this.db_ViewCalendarBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.db_ViewCalendarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.db_ViewCalendarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.db_ViewCalendarBtn.ForeColor = System.Drawing.Color.White;
            this.db_ViewCalendarBtn.Location = new System.Drawing.Point(117, 269);
            this.db_ViewCalendarBtn.Name = "db_ViewCalendarBtn";
            this.db_ViewCalendarBtn.Size = new System.Drawing.Size(1322, 605);
            this.db_ViewCalendarBtn.TabIndex = 80;
            this.db_ViewCalendarBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1025, 96);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 83;
            this.pictureBox2.TabStop = false;
            // 
            // Search
            // 
            this.Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Search.ForeColor = System.Drawing.Color.DarkGray;
            this.Search.Location = new System.Drawing.Point(1066, 99);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(341, 23);
            this.Search.TabIndex = 81;
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
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // CmbxMonth
            // 
            this.CmbxMonth.AccessibleName = "";
            this.CmbxMonth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbxMonth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbxMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(37)))), ((int)(((byte)(83)))));
            this.CmbxMonth.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(51)))));
            this.CmbxMonth.BorderSize = 0;
            this.CmbxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CmbxMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CmbxMonth.ForeColor = System.Drawing.Color.White;
            this.CmbxMonth.IconColor = System.Drawing.Color.White;
            this.CmbxMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.CmbxMonth.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CmbxMonth.ListTextColor = System.Drawing.Color.Black;
            this.CmbxMonth.Location = new System.Drawing.Point(123, 203);
            this.CmbxMonth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmbxMonth.MinimumSize = new System.Drawing.Size(229, 40);
            this.CmbxMonth.Name = "CmbxMonth";
            this.CmbxMonth.Size = new System.Drawing.Size(229, 40);
            this.CmbxMonth.TabIndex = 130;
            this.CmbxMonth.Texts = "Show by month of:";
            // 
            // CmbxYear
            // 
            this.CmbxYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbxYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbxYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(37)))), ((int)(((byte)(83)))));
            this.CmbxYear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(51)))));
            this.CmbxYear.BorderSize = 0;
            this.CmbxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CmbxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CmbxYear.ForeColor = System.Drawing.Color.White;
            this.CmbxYear.IconColor = System.Drawing.Color.White;
            this.CmbxYear.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CmbxYear.ListTextColor = System.Drawing.Color.Black;
            this.CmbxYear.Location = new System.Drawing.Point(377, 203);
            this.CmbxYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmbxYear.MinimumSize = new System.Drawing.Size(171, 40);
            this.CmbxYear.Name = "CmbxYear";
            this.CmbxYear.Size = new System.Drawing.Size(229, 40);
            this.CmbxYear.TabIndex = 129;
            this.CmbxYear.Texts = "Show by year of:";
            // 
            // btn_one3
            // 
            this.btn_one3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btn_one3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_one3.FlatAppearance.BorderSize = 0;
            this.btn_one3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_one3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_one3.ForeColor = System.Drawing.Color.White;
            this.btn_one3.Location = new System.Drawing.Point(1205, 904);
            this.btn_one3.Name = "btn_one3";
            this.btn_one3.Size = new System.Drawing.Size(235, 51);
            this.btn_one3.TabIndex = 132;
            this.btn_one3.Text = "Delete";
            this.btn_one3.UseVisualStyleBackColor = false;
            this.btn_one3.Click += new System.EventHandler(this.btn_one3_Click);
            // 
            // btn_one2
            // 
            this.btn_one2.BackColor = System.Drawing.Color.DarkGray;
            this.btn_one2.Enabled = false;
            this.btn_one2.FlatAppearance.BorderSize = 0;
            this.btn_one2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_one2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_one2.ForeColor = System.Drawing.Color.White;
            this.btn_one2.Location = new System.Drawing.Point(119, 904);
            this.btn_one2.Name = "btn_one2";
            this.btn_one2.Size = new System.Drawing.Size(282, 51);
            this.btn_one2.TabIndex = 131;
            this.btn_one2.Text = "Clear checked";
            this.btn_one2.UseVisualStyleBackColor = false;
            this.btn_one2.Click += new System.EventHandler(this.btn_one2_Click);
            // 
            // btn_one1
            // 
            this.btn_one1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(37)))), ((int)(((byte)(83)))));
            this.btn_one1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_one1.FlatAppearance.BorderSize = 0;
            this.btn_one1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_one1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_one1.ForeColor = System.Drawing.Color.White;
            this.btn_one1.Location = new System.Drawing.Point(914, 904);
            this.btn_one1.Name = "btn_one1";
            this.btn_one1.Size = new System.Drawing.Size(272, 51);
            this.btn_one1.TabIndex = 133;
            this.btn_one1.Text = "Reload Table";
            this.btn_one1.UseVisualStyleBackColor = false;
            // 
            // ATTENDANCEreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.btn_one1);
            this.Controls.Add(this.btn_one3);
            this.Controls.Add(this.CmbxMonth);
            this.Controls.Add(this.CmbxYear);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.attndncrprt_DGV);
            this.Controls.Add(this.db_ViewCalendarBtn);
            this.Controls.Add(this.btn_one2);
            this.Name = "ATTENDANCEreport";
            this.Size = new System.Drawing.Size(1555, 1033);
            this.Load += new System.EventHandler(this.ATTENDANCEreport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.attndncrprt_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView attndncrprt_DGV;
        private Label label1;
        private Label label6;
        private btn_one db_ViewCalendarBtn;
        private PictureBox pictureBox2;
        private TextBox Search;
        private PictureBox pictureBox1;
        private DataGridViewCheckBoxColumn delete_ChckBx;
        private DataGridViewTextBoxColumn EmpId;
        private DataGridViewTextBoxColumn EmpName;
        private DataGridViewTextBoxColumn dsgntn;
        private DataGridViewTextBoxColumn Absnt;
        private DataGridViewTextBoxColumn Prsnt;
        private DataGridViewTextBoxColumn Leavecol;
        private DataGridViewTextBoxColumn Ttlbr;
        private DataGridViewTextBoxColumn Slry;
        private CComboBox CmbxMonth;
        private CComboBox CmbxYear;
        private btn_one btn_one3;
        private btn_one btn_one2;
        private btn_one btn_one1;
    }
}
