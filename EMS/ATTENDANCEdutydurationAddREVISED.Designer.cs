namespace EMS
{
    partial class ATTENDANCEdutydurationAddREVISED
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
            this.AddEmpStatus = new EMS.CComboBox();
            this.AddTimePickerOut = new System.Windows.Forms.DateTimePicker();
            this.AddTimePickerIn = new System.Windows.Forms.DateTimePicker();
            this.AddClear = new EMS.btn_one();
            this.AddSave = new EMS.btn_one();
            this.LblName = new System.Windows.Forms.Label();
            this.AddLblOvertime = new System.Windows.Forms.Label();
            this.AddLblTimeOut = new System.Windows.Forms.Label();
            this.AddLblDuration = new System.Windows.Forms.Label();
            this.AddLlblTimeIn = new System.Windows.Forms.Label();
            this.AddDutydate = new System.Windows.Forms.DateTimePicker();
            this.AddLblStatus = new System.Windows.Forms.Label();
            this.AddLblDate = new System.Windows.Forms.Label();
            this.AddName = new System.Windows.Forms.TextBox();
            this.AddLblId = new System.Windows.Forms.Label();
            this.AddEmpDuration = new System.Windows.Forms.TextBox();
            this.AddEmpOvertime = new System.Windows.Forms.TextBox();
            this.AddEmployeeId = new System.Windows.Forms.TextBox();
            this.LblStatus = new EMS.btn_one();
            this.AddTitle = new System.Windows.Forms.Label();
            this.Addbkgrnd = new EMS.btn_one();
            this.SuspendLayout();
            // 
            // AddEmpStatus
            // 
            this.AddEmpStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.AddEmpStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.AddEmpStatus.BackColor = System.Drawing.Color.White;
            this.AddEmpStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.AddEmpStatus.BorderSize = 2;
            this.AddEmpStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.AddEmpStatus.Font = new System.Drawing.Font("SF Pro Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddEmpStatus.ForeColor = System.Drawing.Color.Black;
            this.AddEmpStatus.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.AddEmpStatus.Items.AddRange(new object[] {
            "On Leave",
            "Absent",
            "Present"});
            this.AddEmpStatus.ListBackColor = System.Drawing.Color.DeepSkyBlue;
            this.AddEmpStatus.ListTextColor = System.Drawing.Color.Black;
            this.AddEmpStatus.Location = new System.Drawing.Point(853, 368);
            this.AddEmpStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddEmpStatus.MinimumSize = new System.Drawing.Size(229, 40);
            this.AddEmpStatus.Name = "AddEmpStatus";
            this.AddEmpStatus.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AddEmpStatus.Size = new System.Drawing.Size(349, 40);
            this.AddEmpStatus.TabIndex = 200;
            this.AddEmpStatus.Texts = "The Employee is:";
            // 
            // AddTimePickerOut
            // 
            this.AddTimePickerOut.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddTimePickerOut.CustomFormat = "";
            this.AddTimePickerOut.Font = new System.Drawing.Font("SF Pro Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddTimePickerOut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.AddTimePickerOut.Location = new System.Drawing.Point(447, 588);
            this.AddTimePickerOut.MinDate = new System.DateTime(1995, 1, 1, 23, 59, 0, 0);
            this.AddTimePickerOut.Name = "AddTimePickerOut";
            this.AddTimePickerOut.ShowUpDown = true;
            this.AddTimePickerOut.Size = new System.Drawing.Size(349, 29);
            this.AddTimePickerOut.TabIndex = 199;
            this.AddTimePickerOut.Value = new System.DateTime(2022, 7, 25, 23, 59, 59, 0);
            // 
            // AddTimePickerIn
            // 
            this.AddTimePickerIn.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddTimePickerIn.CustomFormat = "";
            this.AddTimePickerIn.Font = new System.Drawing.Font("SF Pro Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddTimePickerIn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.AddTimePickerIn.Location = new System.Drawing.Point(447, 480);
            this.AddTimePickerIn.MinDate = new System.DateTime(1995, 1, 1, 23, 59, 0, 0);
            this.AddTimePickerIn.Name = "AddTimePickerIn";
            this.AddTimePickerIn.ShowUpDown = true;
            this.AddTimePickerIn.Size = new System.Drawing.Size(349, 29);
            this.AddTimePickerIn.TabIndex = 198;
            this.AddTimePickerIn.Value = new System.DateTime(2022, 7, 25, 23, 59, 59, 0);
            // 
            // AddClear
            // 
            this.AddClear.BackColor = System.Drawing.Color.DarkGray;
            this.AddClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddClear.FlatAppearance.BorderSize = 0;
            this.AddClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddClear.ForeColor = System.Drawing.Color.Black;
            this.AddClear.Location = new System.Drawing.Point(421, 912);
            this.AddClear.Name = "AddClear";
            this.AddClear.Size = new System.Drawing.Size(135, 51);
            this.AddClear.TabIndex = 197;
            this.AddClear.Text = "Clear";
            this.AddClear.UseVisualStyleBackColor = false;
            // 
            // AddSave
            // 
            this.AddSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(202)))), ((int)(((byte)(63)))));
            this.AddSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddSave.FlatAppearance.BorderSize = 0;
            this.AddSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddSave.ForeColor = System.Drawing.Color.White;
            this.AddSave.Location = new System.Drawing.Point(1093, 912);
            this.AddSave.Name = "AddSave";
            this.AddSave.Size = new System.Drawing.Size(135, 51);
            this.AddSave.TabIndex = 196;
            this.AddSave.Text = "Save";
            this.AddSave.UseVisualStyleBackColor = false;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.BackColor = System.Drawing.Color.White;
            this.LblName.Font = new System.Drawing.Font("SF Pro Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblName.ForeColor = System.Drawing.Color.Gray;
            this.LblName.Location = new System.Drawing.Point(447, 173);
            this.LblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(123, 18);
            this.LblName.TabIndex = 194;
            this.LblName.Text = "Employee Name";
            // 
            // AddLblOvertime
            // 
            this.AddLblOvertime.AutoSize = true;
            this.AddLblOvertime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.AddLblOvertime.Font = new System.Drawing.Font("SF Pro Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddLblOvertime.ForeColor = System.Drawing.Color.White;
            this.AddLblOvertime.Location = new System.Drawing.Point(853, 434);
            this.AddLblOvertime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.AddLblOvertime.Name = "AddLblOvertime";
            this.AddLblOvertime.Size = new System.Drawing.Size(74, 18);
            this.AddLblOvertime.TabIndex = 192;
            this.AddLblOvertime.Text = "Overtime";
            // 
            // AddLblTimeOut
            // 
            this.AddLblTimeOut.AutoSize = true;
            this.AddLblTimeOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.AddLblTimeOut.Font = new System.Drawing.Font("SF Pro Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddLblTimeOut.ForeColor = System.Drawing.Color.White;
            this.AddLblTimeOut.Location = new System.Drawing.Point(447, 545);
            this.AddLblTimeOut.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.AddLblTimeOut.Name = "AddLblTimeOut";
            this.AddLblTimeOut.Size = new System.Drawing.Size(71, 18);
            this.AddLblTimeOut.TabIndex = 191;
            this.AddLblTimeOut.Text = "Time out";
            // 
            // AddLblDuration
            // 
            this.AddLblDuration.AutoSize = true;
            this.AddLblDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.AddLblDuration.Font = new System.Drawing.Font("SF Pro Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddLblDuration.ForeColor = System.Drawing.Color.White;
            this.AddLblDuration.Location = new System.Drawing.Point(853, 539);
            this.AddLblDuration.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.AddLblDuration.Name = "AddLblDuration";
            this.AddLblDuration.Size = new System.Drawing.Size(69, 18);
            this.AddLblDuration.TabIndex = 190;
            this.AddLblDuration.Text = "Duration";
            // 
            // AddLlblTimeIn
            // 
            this.AddLlblTimeIn.AutoSize = true;
            this.AddLlblTimeIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.AddLlblTimeIn.Font = new System.Drawing.Font("SF Pro Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddLlblTimeIn.ForeColor = System.Drawing.Color.White;
            this.AddLlblTimeIn.Location = new System.Drawing.Point(447, 441);
            this.AddLlblTimeIn.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.AddLlblTimeIn.Name = "AddLlblTimeIn";
            this.AddLlblTimeIn.Size = new System.Drawing.Size(61, 18);
            this.AddLlblTimeIn.TabIndex = 189;
            this.AddLlblTimeIn.Text = "Time in";
            // 
            // AddDutydate
            // 
            this.AddDutydate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddDutydate.CustomFormat = "";
            this.AddDutydate.Font = new System.Drawing.Font("SF Pro Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddDutydate.Location = new System.Drawing.Point(447, 370);
            this.AddDutydate.MinDate = new System.DateTime(1995, 1, 1, 23, 59, 0, 0);
            this.AddDutydate.Name = "AddDutydate";
            this.AddDutydate.Size = new System.Drawing.Size(349, 29);
            this.AddDutydate.TabIndex = 188;
            this.AddDutydate.Value = new System.DateTime(2022, 7, 25, 23, 59, 59, 0);
            // 
            // AddLblStatus
            // 
            this.AddLblStatus.AutoSize = true;
            this.AddLblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.AddLblStatus.Font = new System.Drawing.Font("SF Pro Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddLblStatus.ForeColor = System.Drawing.Color.White;
            this.AddLblStatus.Location = new System.Drawing.Point(853, 331);
            this.AddLblStatus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.AddLblStatus.Name = "AddLblStatus";
            this.AddLblStatus.Size = new System.Drawing.Size(53, 18);
            this.AddLblStatus.TabIndex = 187;
            this.AddLblStatus.Text = "Status";
            // 
            // AddLblDate
            // 
            this.AddLblDate.AutoSize = true;
            this.AddLblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.AddLblDate.Font = new System.Drawing.Font("SF Pro Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddLblDate.ForeColor = System.Drawing.Color.White;
            this.AddLblDate.Location = new System.Drawing.Point(447, 326);
            this.AddLblDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.AddLblDate.Name = "AddLblDate";
            this.AddLblDate.Size = new System.Drawing.Size(94, 18);
            this.AddLblDate.TabIndex = 186;
            this.AddLblDate.Text = "Date of duty";
            // 
            // AddName
            // 
            this.AddName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddName.Font = new System.Drawing.Font("SF Pro Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddName.ForeColor = System.Drawing.Color.Black;
            this.AddName.Location = new System.Drawing.Point(447, 206);
            this.AddName.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.AddName.Multiline = true;
            this.AddName.Name = "AddName";
            this.AddName.Size = new System.Drawing.Size(349, 32);
            this.AddName.TabIndex = 184;
            this.AddName.Text = " ";
            // 
            // AddLblId
            // 
            this.AddLblId.AutoSize = true;
            this.AddLblId.BackColor = System.Drawing.Color.White;
            this.AddLblId.Font = new System.Drawing.Font("SF Pro Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddLblId.ForeColor = System.Drawing.Color.Gray;
            this.AddLblId.Location = new System.Drawing.Point(853, 173);
            this.AddLblId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.AddLblId.Name = "AddLblId";
            this.AddLblId.Size = new System.Drawing.Size(95, 18);
            this.AddLblId.TabIndex = 185;
            this.AddLblId.Text = "Employee Id";
            // 
            // AddEmpDuration
            // 
            this.AddEmpDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddEmpDuration.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddEmpDuration.Font = new System.Drawing.Font("SF Pro Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddEmpDuration.ForeColor = System.Drawing.Color.Black;
            this.AddEmpDuration.Location = new System.Drawing.Point(853, 587);
            this.AddEmpDuration.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.AddEmpDuration.Multiline = true;
            this.AddEmpDuration.Name = "AddEmpDuration";
            this.AddEmpDuration.Size = new System.Drawing.Size(349, 32);
            this.AddEmpDuration.TabIndex = 183;
            this.AddEmpDuration.Text = " ";
            // 
            // AddEmpOvertime
            // 
            this.AddEmpOvertime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddEmpOvertime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddEmpOvertime.Font = new System.Drawing.Font("SF Pro Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddEmpOvertime.ForeColor = System.Drawing.Color.Black;
            this.AddEmpOvertime.Location = new System.Drawing.Point(853, 478);
            this.AddEmpOvertime.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.AddEmpOvertime.Multiline = true;
            this.AddEmpOvertime.Name = "AddEmpOvertime";
            this.AddEmpOvertime.Size = new System.Drawing.Size(349, 32);
            this.AddEmpOvertime.TabIndex = 182;
            this.AddEmpOvertime.Text = " ";
            // 
            // AddEmployeeId
            // 
            this.AddEmployeeId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddEmployeeId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddEmployeeId.Font = new System.Drawing.Font("SF Pro Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddEmployeeId.ForeColor = System.Drawing.Color.Black;
            this.AddEmployeeId.Location = new System.Drawing.Point(853, 206);
            this.AddEmployeeId.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.AddEmployeeId.Multiline = true;
            this.AddEmployeeId.Name = "AddEmployeeId";
            this.AddEmployeeId.Size = new System.Drawing.Size(349, 32);
            this.AddEmployeeId.TabIndex = 181;
            this.AddEmployeeId.Text = " ";
            // 
            // LblStatus
            // 
            this.LblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.LblStatus.FlatAppearance.BorderSize = 0;
            this.LblStatus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.LblStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.LblStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblStatus.Font = new System.Drawing.Font("SF Pro Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(37)))), ((int)(((byte)(83)))));
            this.LblStatus.Location = new System.Drawing.Point(397, 262);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(856, 629);
            this.LblStatus.TabIndex = 179;
            this.LblStatus.UseVisualStyleBackColor = false;
            // 
            // AddTitle
            // 
            this.AddTitle.AutoSize = true;
            this.AddTitle.BackColor = System.Drawing.Color.Transparent;
            this.AddTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(37)))), ((int)(((byte)(83)))));
            this.AddTitle.Location = new System.Drawing.Point(95, 101);
            this.AddTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.AddTitle.Name = "AddTitle";
            this.AddTitle.Size = new System.Drawing.Size(673, 48);
            this.AddTitle.TabIndex = 178;
            this.AddTitle.Text = "Add duty duration of an employee";
            // 
            // Addbkgrnd
            // 
            this.Addbkgrnd.BackColor = System.Drawing.Color.White;
            this.Addbkgrnd.FlatAppearance.BorderSize = 0;
            this.Addbkgrnd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Addbkgrnd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Addbkgrnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbkgrnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Addbkgrnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(37)))), ((int)(((byte)(83)))));
            this.Addbkgrnd.Location = new System.Drawing.Point(397, 145);
            this.Addbkgrnd.Name = "Addbkgrnd";
            this.Addbkgrnd.Size = new System.Drawing.Size(856, 153);
            this.Addbkgrnd.TabIndex = 193;
            this.Addbkgrnd.UseVisualStyleBackColor = false;
            // 
            // ATTENDANCEdutydurationAddREVISED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddEmpStatus);
            this.Controls.Add(this.AddTimePickerOut);
            this.Controls.Add(this.AddTimePickerIn);
            this.Controls.Add(this.AddClear);
            this.Controls.Add(this.AddSave);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.AddLblOvertime);
            this.Controls.Add(this.AddLblTimeOut);
            this.Controls.Add(this.AddLblDuration);
            this.Controls.Add(this.AddLlblTimeIn);
            this.Controls.Add(this.AddDutydate);
            this.Controls.Add(this.AddLblStatus);
            this.Controls.Add(this.AddLblDate);
            this.Controls.Add(this.AddName);
            this.Controls.Add(this.AddLblId);
            this.Controls.Add(this.AddEmpDuration);
            this.Controls.Add(this.AddEmpOvertime);
            this.Controls.Add(this.AddEmployeeId);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.AddTitle);
            this.Controls.Add(this.Addbkgrnd);
            this.Name = "ATTENDANCEdutydurationAddREVISED";
            this.Size = new System.Drawing.Size(1537, 1033);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CComboBox AddEmpStatus;
        private DateTimePicker AddTimePickerOut;
        private DateTimePicker AddTimePickerIn;
        private btn_one AddClear;
        private btn_one AddSave;
        private Label LblName;
        private Label AddLblOvertime;
        private Label AddLblTimeOut;
        private Label AddLblDuration;
        private Label AddLlblTimeIn;
        private DateTimePicker AddDutydate;
        private Label AddLblStatus;
        private Label AddLblDate;
        private TextBox AddName;
        private Label AddLblId;
        private TextBox AddEmpDuration;
        private TextBox AddEmpOvertime;
        private TextBox AddEmployeeId;
        private btn_one LblStatus;
        private Label AddTitle;
        private btn_one Addbkgrnd;
    }
}
