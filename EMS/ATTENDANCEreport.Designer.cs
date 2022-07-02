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
            this.ClrReport = new EMS.btn_one();
            this.DelReport = new EMS.btn_one();
            this.ComboYear = new EMS.CComboBox();
            this.ComboMonth = new EMS.CComboBox();
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
            this.attndncrprt_DGV.Location = new System.Drawing.Point(109, 219);
            this.attndncrprt_DGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.attndncrprt_DGV.Size = new System.Drawing.Size(1157, 431);
            this.attndncrprt_DGV.TabIndex = 1;
            this.attndncrprt_DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.attndncrprt_DGV_CellContentClick);
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
            this.delete_ChckBx.Width = 26;
            // 
            // EmpId
            // 
            this.EmpId.FillWeight = 23.39183F;
            this.EmpId.HeaderText = "Employee ID";
            this.EmpId.Name = "EmpId";
            this.EmpId.Width = 136;
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
            this.dsgntn.Name = "dsgntn";
            this.dsgntn.Width = 199;
            // 
            // Absnt
            // 
            this.Absnt.FillWeight = 23.39183F;
            this.Absnt.HeaderText = "Absents";
            this.Absnt.Name = "Absnt";
            // 
            // Prsnt
            // 
            this.Prsnt.FillWeight = 23.39183F;
            this.Prsnt.HeaderText = "Present";
            this.Prsnt.Name = "Prsnt";
            this.Prsnt.Width = 96;
            // 
            // Leavecol
            // 
            this.Leavecol.FillWeight = 23.39183F;
            this.Leavecol.HeaderText = "Leave";
            this.Leavecol.Name = "Leavecol";
            this.Leavecol.Width = 82;
            // 
            // Ttlbr
            // 
            this.Ttlbr.FillWeight = 23.39183F;
            this.Ttlbr.HeaderText = "Duration/Total Labor";
            this.Ttlbr.Name = "Ttlbr";
            this.Ttlbr.Width = 199;
            // 
            // Slry
            // 
            this.Slry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Slry.HeaderText = "Salary";
            this.Slry.Name = "Slry";
            this.Slry.Width = 130;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(108, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 39);
            this.label1.TabIndex = 74;
            this.label1.Text = "Attendance Report";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("SF Pro Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(107, 95);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(666, 18);
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
            this.db_ViewCalendarBtn.Location = new System.Drawing.Point(109, 196);
            this.db_ViewCalendarBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.db_ViewCalendarBtn.Name = "db_ViewCalendarBtn";
            this.db_ViewCalendarBtn.Size = new System.Drawing.Size(1157, 454);
            this.db_ViewCalendarBtn.TabIndex = 80;
            this.db_ViewCalendarBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(897, 72);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 83;
            this.pictureBox2.TabStop = false;
            // 
            // Search
            // 
            this.Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Search.ForeColor = System.Drawing.Color.DarkGray;
            this.Search.Location = new System.Drawing.Point(933, 74);
            this.Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(298, 19);
            this.Search.TabIndex = 81;
            this.Search.Text = "Search";
            this.Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(882, 63);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // ClrReport
            // 
            this.ClrReport.BackColor = System.Drawing.Color.DarkGray;
            this.ClrReport.FlatAppearance.BorderSize = 0;
            this.ClrReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClrReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClrReport.ForeColor = System.Drawing.Color.Black;
            this.ClrReport.Location = new System.Drawing.Point(109, 674);
            this.ClrReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClrReport.Name = "ClrReport";
            this.ClrReport.Size = new System.Drawing.Size(154, 38);
            this.ClrReport.TabIndex = 126;
            this.ClrReport.Text = "Clear checked";
            this.ClrReport.UseVisualStyleBackColor = false;
            // 
            // DelReport
            // 
            this.DelReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.DelReport.FlatAppearance.BorderSize = 0;
            this.DelReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DelReport.ForeColor = System.Drawing.Color.White;
            this.DelReport.Location = new System.Drawing.Point(1097, 674);
            this.DelReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DelReport.Name = "DelReport";
            this.DelReport.Size = new System.Drawing.Size(154, 38);
            this.DelReport.TabIndex = 125;
            this.DelReport.Text = "Delete";
            this.DelReport.UseVisualStyleBackColor = false;
            // 
            // ComboYear
            // 
            this.ComboYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboYear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ComboYear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(51)))));
            this.ComboYear.BorderSize = 2;
            this.ComboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.ComboYear.Font = new System.Drawing.Font("SF Pro Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ComboYear.ForeColor = System.Drawing.Color.Black;
            this.ComboYear.IconColor = System.Drawing.Color.Blue;
            this.ComboYear.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.ComboYear.ListTextColor = System.Drawing.Color.DimGray;
            this.ComboYear.Location = new System.Drawing.Point(118, 161);
            this.ComboYear.MinimumSize = new System.Drawing.Size(200, 30);
            this.ComboYear.Name = "ComboYear";
            this.ComboYear.Padding = new System.Windows.Forms.Padding(2);
            this.ComboYear.Size = new System.Drawing.Size(200, 30);
            this.ComboYear.TabIndex = 127;
            this.ComboYear.Texts = "Show by year of:";
            // 
            // ComboMonth
            // 
            this.ComboMonth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboMonth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboMonth.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ComboMonth.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(51)))));
            this.ComboMonth.BorderSize = 2;
            this.ComboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.ComboMonth.Font = new System.Drawing.Font("SF Pro Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ComboMonth.ForeColor = System.Drawing.Color.Black;
            this.ComboMonth.IconColor = System.Drawing.Color.Blue;
            this.ComboMonth.Items.AddRange(new object[] {
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
            this.ComboMonth.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.ComboMonth.ListTextColor = System.Drawing.Color.DimGray;
            this.ComboMonth.Location = new System.Drawing.Point(118, 125);
            this.ComboMonth.MinimumSize = new System.Drawing.Size(200, 30);
            this.ComboMonth.Name = "ComboMonth";
            this.ComboMonth.Padding = new System.Windows.Forms.Padding(2);
            this.ComboMonth.Size = new System.Drawing.Size(200, 30);
            this.ComboMonth.TabIndex = 127;
            this.ComboMonth.Texts = "Show by month of:";
            // 
            // ATTENDANCEreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.ComboMonth);
            this.Controls.Add(this.ComboYear);
            this.Controls.Add(this.ClrReport);
            this.Controls.Add(this.DelReport);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.attndncrprt_DGV);
            this.Controls.Add(this.db_ViewCalendarBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ATTENDANCEreport";
            this.Size = new System.Drawing.Size(1361, 775);
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
        private btn_one ClrReport;
        private btn_one DelReport;
        private CComboBox ComboYear;
        private CComboBox ComboMonth;
        private DataGridViewCheckBoxColumn delete_ChckBx;
        private DataGridViewTextBoxColumn EmpId;
        private DataGridViewTextBoxColumn EmpName;
        private DataGridViewTextBoxColumn dsgntn;
        private DataGridViewTextBoxColumn Absnt;
        private DataGridViewTextBoxColumn Prsnt;
        private DataGridViewTextBoxColumn Leavecol;
        private DataGridViewTextBoxColumn Ttlbr;
        private DataGridViewTextBoxColumn Slry;
    }
}
