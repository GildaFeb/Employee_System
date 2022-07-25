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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EMPLOYEESdelete));
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Search = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.db_ViewCalendarBtn = new EMS.btn_one();
            this.clear_check = new EMS.btn_one();
            this.delete = new EMS.btn_one();
            this.btn_one2 = new EMS.btn_one();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableDelete_DGV = new System.Windows.Forms.DataGridView();
            this.noData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDelete_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("SF Pro Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(109, 141);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(739, 21);
            this.label6.TabIndex = 74;
            this.label6.Text = "Search for the ID number or check the check box of the employee you want to delet" +
    "e\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(104, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 48);
            this.label1.TabIndex = 73;
            this.label1.Text = "Delete employee";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1004, 96);
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
            this.Search.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Search.ForeColor = System.Drawing.Color.DarkGray;
            this.Search.Location = new System.Drawing.Point(1045, 99);
            this.Search.Name = "Search";
            this.Search.PlaceholderText = "Enter ID Number";
            this.Search.Size = new System.Drawing.Size(341, 24);
            this.Search.TabIndex = 75;
            this.Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(987, 84);
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
            this.db_ViewCalendarBtn.Location = new System.Drawing.Point(104, 231);
            this.db_ViewCalendarBtn.Name = "db_ViewCalendarBtn";
            this.db_ViewCalendarBtn.Size = new System.Drawing.Size(1305, 605);
            this.db_ViewCalendarBtn.TabIndex = 79;
            this.db_ViewCalendarBtn.UseVisualStyleBackColor = false;
            this.db_ViewCalendarBtn.Click += new System.EventHandler(this.db_ViewCalendarBtn_Click);
            // 
            // clear_check
            // 
            this.clear_check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(165)))), ((int)(((byte)(174)))));
            this.clear_check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_check.FlatAppearance.BorderSize = 0;
            this.clear_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_check.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clear_check.ForeColor = System.Drawing.Color.Black;
            this.clear_check.Location = new System.Drawing.Point(104, 873);
            this.clear_check.Name = "clear_check";
            this.clear_check.Size = new System.Drawing.Size(219, 51);
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
            this.delete.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(1185, 873);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(224, 51);
            this.delete.TabIndex = 126;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.btn_one3_Click);
            // 
            // btn_one2
            // 
            this.btn_one2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.btn_one2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_one2.FlatAppearance.BorderSize = 0;
            this.btn_one2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_one2.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_one2.ForeColor = System.Drawing.Color.White;
            this.btn_one2.Location = new System.Drawing.Point(901, 873);
            this.btn_one2.Name = "btn_one2";
            this.btn_one2.Size = new System.Drawing.Size(219, 51);
            this.btn_one2.TabIndex = 131;
            this.btn_one2.Text = "Refresh";
            this.btn_one2.UseVisualStyleBackColor = false;
            this.btn_one2.Click += new System.EventHandler(this.btn_one2_Click_1);
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(EMS.Employee_Details.Employee);
            // 
            // tableDelete_DGV
            // 
            this.tableDelete_DGV.AllowUserToAddRows = false;
            this.tableDelete_DGV.AllowUserToDeleteRows = false;
            this.tableDelete_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDelete_DGV.Location = new System.Drawing.Point(104, 262);
            this.tableDelete_DGV.Name = "tableDelete_DGV";
            this.tableDelete_DGV.RowHeadersWidth = 51;
            this.tableDelete_DGV.RowTemplate.Height = 29;
            this.tableDelete_DGV.Size = new System.Drawing.Size(1305, 549);
            this.tableDelete_DGV.TabIndex = 133;
            this.tableDelete_DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableDelete_DGV_CellContentClick_1);
            // 
            // noData
            // 
            this.noData.AutoSize = true;
            this.noData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noData.ForeColor = System.Drawing.Color.Black;
            this.noData.Location = new System.Drawing.Point(672, 535);
            this.noData.Name = "noData";
            this.noData.Size = new System.Drawing.Size(171, 28);
            this.noData.TabIndex = 205;
            this.noData.Text = "No data recorded.";
            this.noData.Visible = false;
            // 
            // EMPLOYEESdelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.noData);
            this.Controls.Add(this.tableDelete_DGV);
            this.Controls.Add(this.btn_one2);
            this.Controls.Add(this.clear_check);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.db_ViewCalendarBtn);
            this.Location = new System.Drawing.Point(356, 50);
            this.Name = "EMPLOYEESdelete";
            this.Size = new System.Drawing.Size(1555, 1033);
            this.Load += new System.EventHandler(this.EMPLOYEESdelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDelete_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label6;
        private Label label1;
        private PictureBox pictureBox2;
        private TextBox Search;
        private PictureBox pictureBox1;
        private btn_one db_ViewCalendarBtn;
        private btn_one clear_check;
        private btn_one delete;
        private btn_one btn_one2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private BindingSource employeeBindingSource;
        private DataGridView tableDelete_DGV;
        private Label noData;
    }
}
