namespace EMS
{
    partial class ATTENDANCEdutydurationUpdREVISED
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
            this.btn_clear = new EMS.btn_one();
            this.btn_save = new EMS.btn_one();
            this.LblName = new System.Windows.Forms.Label();
            this.UpdLblOvertime = new System.Windows.Forms.Label();
            this.UpdLblTimeOut = new System.Windows.Forms.Label();
            this.UpdLblDuration = new System.Windows.Forms.Label();
            this.UpdLlblTimeIn = new System.Windows.Forms.Label();
            this.date_duty = new System.Windows.Forms.DateTimePicker();
            this.UpdLblStatus = new System.Windows.Forms.Label();
            this.UpdLblDate = new System.Windows.Forms.Label();
            this.employee_name = new System.Windows.Forms.TextBox();
            this.UpdLblId = new System.Windows.Forms.Label();
            this.duration = new System.Windows.Forms.TextBox();
            this.overtime = new System.Windows.Forms.TextBox();
            this.employee_id = new System.Windows.Forms.TextBox();
            this.LblStatus = new EMS.btn_one();
            this.LblTitle = new System.Windows.Forms.Label();
            this.btn_one14 = new EMS.btn_one();
            this.status = new EMS.CComboBox();
            this.btn_findemployee = new EMS.btn_one();
            this.time_in = new System.Windows.Forms.MaskedTextBox();
            this.time_inPeriod = new System.Windows.Forms.ComboBox();
            this.time_out = new System.Windows.Forms.MaskedTextBox();
            this.time_outPeriod = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.DarkGray;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(112, 520);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(190, 38);
            this.btn_clear.TabIndex = 198;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(202)))), ((int)(((byte)(63)))));
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(1040, 520);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(202, 38);
            this.btn_save.TabIndex = 197;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.UpdSave_Click);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(0)))));
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblName.Location = new System.Drawing.Point(525, 236);
            this.LblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(99, 15);
            this.LblName.TabIndex = 195;
            this.LblName.Text = "Employee Name";
            // 
            // UpdLblOvertime
            // 
            this.UpdLblOvertime.AutoSize = true;
            this.UpdLblOvertime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.UpdLblOvertime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdLblOvertime.ForeColor = System.Drawing.Color.White;
            this.UpdLblOvertime.Location = new System.Drawing.Point(883, 414);
            this.UpdLblOvertime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpdLblOvertime.Name = "UpdLblOvertime";
            this.UpdLblOvertime.Size = new System.Drawing.Size(56, 15);
            this.UpdLblOvertime.TabIndex = 193;
            this.UpdLblOvertime.Text = "Overtime";
            this.UpdLblOvertime.Click += new System.EventHandler(this.UpdLblOvertime_Click);
            // 
            // UpdLblTimeOut
            // 
            this.UpdLblTimeOut.AutoSize = true;
            this.UpdLblTimeOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.UpdLblTimeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdLblTimeOut.ForeColor = System.Drawing.Color.White;
            this.UpdLblTimeOut.Location = new System.Drawing.Point(525, 418);
            this.UpdLblTimeOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpdLblTimeOut.Name = "UpdLblTimeOut";
            this.UpdLblTimeOut.Size = new System.Drawing.Size(55, 15);
            this.UpdLblTimeOut.TabIndex = 192;
            this.UpdLblTimeOut.Text = "Time out";
            // 
            // UpdLblDuration
            // 
            this.UpdLblDuration.AutoSize = true;
            this.UpdLblDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.UpdLblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdLblDuration.ForeColor = System.Drawing.Color.White;
            this.UpdLblDuration.Location = new System.Drawing.Point(883, 338);
            this.UpdLblDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpdLblDuration.Name = "UpdLblDuration";
            this.UpdLblDuration.Size = new System.Drawing.Size(54, 15);
            this.UpdLblDuration.TabIndex = 191;
            this.UpdLblDuration.Text = "Duration";
            this.UpdLblDuration.Click += new System.EventHandler(this.UpdLblDuration_Click);
            // 
            // UpdLlblTimeIn
            // 
            this.UpdLlblTimeIn.AutoSize = true;
            this.UpdLlblTimeIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.UpdLlblTimeIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdLlblTimeIn.ForeColor = System.Drawing.Color.White;
            this.UpdLlblTimeIn.Location = new System.Drawing.Point(525, 338);
            this.UpdLlblTimeIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpdLlblTimeIn.Name = "UpdLlblTimeIn";
            this.UpdLlblTimeIn.Size = new System.Drawing.Size(48, 15);
            this.UpdLlblTimeIn.TabIndex = 190;
            this.UpdLlblTimeIn.Text = "Time in";
            this.UpdLlblTimeIn.Click += new System.EventHandler(this.UpdLlblTimeIn_Click);
            // 
            // date_duty
            // 
            this.date_duty.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date_duty.CustomFormat = "";
            this.date_duty.Enabled = false;
            this.date_duty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date_duty.Location = new System.Drawing.Point(164, 446);
            this.date_duty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_duty.MinDate = new System.DateTime(1995, 12, 25, 23, 59, 59, 0);
            this.date_duty.Name = "date_duty";
            this.date_duty.Size = new System.Drawing.Size(306, 24);
            this.date_duty.TabIndex = 189;
            this.date_duty.Value = new System.DateTime(2022, 7, 25, 23, 59, 59, 0);
            // 
            // UpdLblStatus
            // 
            this.UpdLblStatus.AutoSize = true;
            this.UpdLblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.UpdLblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdLblStatus.ForeColor = System.Drawing.Color.White;
            this.UpdLblStatus.Location = new System.Drawing.Point(164, 338);
            this.UpdLblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpdLblStatus.Name = "UpdLblStatus";
            this.UpdLblStatus.Size = new System.Drawing.Size(41, 15);
            this.UpdLblStatus.TabIndex = 188;
            this.UpdLblStatus.Text = "Status";
            // 
            // UpdLblDate
            // 
            this.UpdLblDate.AutoSize = true;
            this.UpdLblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.UpdLblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdLblDate.ForeColor = System.Drawing.Color.White;
            this.UpdLblDate.Location = new System.Drawing.Point(164, 414);
            this.UpdLblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpdLblDate.Name = "UpdLblDate";
            this.UpdLblDate.Size = new System.Drawing.Size(71, 15);
            this.UpdLblDate.TabIndex = 187;
            this.UpdLblDate.Text = "Date of duty";
            // 
            // employee_name
            // 
            this.employee_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employee_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.employee_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employee_name.ForeColor = System.Drawing.Color.Black;
            this.employee_name.Location = new System.Drawing.Point(164, 260);
            this.employee_name.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.employee_name.Multiline = true;
            this.employee_name.Name = "employee_name";
            this.employee_name.Size = new System.Drawing.Size(306, 24);
            this.employee_name.TabIndex = 185;
            this.employee_name.Text = " ";
            // 
            // UpdLblId
            // 
            this.UpdLblId.AutoSize = true;
            this.UpdLblId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(0)))));
            this.UpdLblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdLblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UpdLblId.Location = new System.Drawing.Point(164, 236);
            this.UpdLblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpdLblId.Name = "UpdLblId";
            this.UpdLblId.Size = new System.Drawing.Size(77, 15);
            this.UpdLblId.TabIndex = 186;
            this.UpdLblId.Text = "Employee ID";
            this.UpdLblId.Click += new System.EventHandler(this.UpdLblId_Click);
            // 
            // duration
            // 
            this.duration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.duration.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.duration.Enabled = false;
            this.duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.duration.ForeColor = System.Drawing.Color.Black;
            this.duration.Location = new System.Drawing.Point(883, 375);
            this.duration.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.duration.Multiline = true;
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(306, 24);
            this.duration.TabIndex = 184;
            this.duration.Text = " ";
            // 
            // overtime
            // 
            this.overtime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.overtime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.overtime.Enabled = false;
            this.overtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.overtime.ForeColor = System.Drawing.Color.Black;
            this.overtime.Location = new System.Drawing.Point(886, 442);
            this.overtime.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.overtime.Multiline = true;
            this.overtime.Name = "overtime";
            this.overtime.Size = new System.Drawing.Size(306, 24);
            this.overtime.TabIndex = 183;
            this.overtime.Text = " ";
            this.overtime.TextChanged += new System.EventHandler(this.UpdEmpOvertime_TextChanged);
            // 
            // employee_id
            // 
            this.employee_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employee_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.employee_id.Enabled = false;
            this.employee_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employee_id.ForeColor = System.Drawing.Color.Black;
            this.employee_id.Location = new System.Drawing.Point(525, 260);
            this.employee_id.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.employee_id.Multiline = true;
            this.employee_id.Name = "employee_id";
            this.employee_id.Size = new System.Drawing.Size(306, 24);
            this.employee_id.TabIndex = 182;
            this.employee_id.Text = " ";
            // 
            // LblStatus
            // 
            this.LblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.LblStatus.FlatAppearance.BorderSize = 0;
            this.LblStatus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.LblStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.LblStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(37)))), ((int)(((byte)(83)))));
            this.LblStatus.Location = new System.Drawing.Point(112, 298);
            this.LblStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(1130, 207);
            this.LblStatus.TabIndex = 180;
            this.LblStatus.UseVisualStyleBackColor = false;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(37)))), ((int)(((byte)(83)))));
            this.LblTitle.Location = new System.Drawing.Point(83, 76);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(608, 39);
            this.LblTitle.TabIndex = 179;
            this.LblTitle.Text = "Update duty duration of an employee";
            // 
            // btn_one14
            // 
            this.btn_one14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(0)))));
            this.btn_one14.FlatAppearance.BorderSize = 0;
            this.btn_one14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_one14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_one14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_one14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_one14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(37)))), ((int)(((byte)(83)))));
            this.btn_one14.Location = new System.Drawing.Point(112, 212);
            this.btn_one14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_one14.Name = "btn_one14";
            this.btn_one14.Size = new System.Drawing.Size(770, 116);
            this.btn_one14.TabIndex = 194;
            this.btn_one14.UseVisualStyleBackColor = false;
            // 
            // status
            // 
            this.status.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.status.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.status.BackColor = System.Drawing.Color.White;
            this.status.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.status.BorderSize = 0;
            this.status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.status.ForeColor = System.Drawing.Color.Black;
            this.status.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.status.Items.AddRange(new object[] {
            "On Leave",
            "Absent",
            "Present"});
            this.status.ListBackColor = System.Drawing.Color.Silver;
            this.status.ListTextColor = System.Drawing.Color.Black;
            this.status.Location = new System.Drawing.Point(164, 369);
            this.status.MinimumSize = new System.Drawing.Size(200, 30);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(305, 30);
            this.status.TabIndex = 201;
            this.status.Texts = "The Employee is:";
            this.status.OnSelectedIndexChanged += new System.EventHandler(this.status_OnSelectedIndexChanged);
            // 
            // btn_findemployee
            // 
            this.btn_findemployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(37)))), ((int)(((byte)(83)))));
            this.btn_findemployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_findemployee.FlatAppearance.BorderSize = 0;
            this.btn_findemployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_findemployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_findemployee.ForeColor = System.Drawing.Color.White;
            this.btn_findemployee.Location = new System.Drawing.Point(920, 236);
            this.btn_findemployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_findemployee.Name = "btn_findemployee";
            this.btn_findemployee.Size = new System.Drawing.Size(197, 38);
            this.btn_findemployee.TabIndex = 202;
            this.btn_findemployee.Text = "Find Employee";
            this.btn_findemployee.UseVisualStyleBackColor = false;
            // 
            // time_in
            // 
            this.time_in.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.time_in.Location = new System.Drawing.Point(531, 374);
            this.time_in.Mask = "00:00:00";
            this.time_in.Name = "time_in";
            this.time_in.Size = new System.Drawing.Size(192, 29);
            this.time_in.TabIndex = 206;
            this.time_in.Text = "115959";
            this.time_in.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.time_in.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.inTime_MaskInputRejected);
            // 
            // time_inPeriod
            // 
            this.time_inPeriod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.time_inPeriod.FormattingEnabled = true;
            this.time_inPeriod.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.time_inPeriod.Location = new System.Drawing.Point(729, 374);
            this.time_inPeriod.Name = "time_inPeriod";
            this.time_inPeriod.Size = new System.Drawing.Size(100, 29);
            this.time_inPeriod.TabIndex = 205;
            this.time_inPeriod.SelectedIndexChanged += new System.EventHandler(this.inPeriod_SelectedIndexChanged);
            // 
            // time_out
            // 
            this.time_out.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.time_out.Location = new System.Drawing.Point(531, 442);
            this.time_out.Mask = "00:00:00";
            this.time_out.Name = "time_out";
            this.time_out.Size = new System.Drawing.Size(192, 29);
            this.time_out.TabIndex = 208;
            this.time_out.Text = "115959";
            this.time_out.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // time_outPeriod
            // 
            this.time_outPeriod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.time_outPeriod.FormattingEnabled = true;
            this.time_outPeriod.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.time_outPeriod.Location = new System.Drawing.Point(729, 442);
            this.time_outPeriod.Name = "time_outPeriod";
            this.time_outPeriod.Size = new System.Drawing.Size(100, 29);
            this.time_outPeriod.TabIndex = 207;
            // 
            // ATTENDANCEdutydurationUpdREVISED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.time_out);
            this.Controls.Add(this.time_outPeriod);
            this.Controls.Add(this.time_in);
            this.Controls.Add(this.time_inPeriod);
            this.Controls.Add(this.btn_findemployee);
            this.Controls.Add(this.status);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.UpdLblOvertime);
            this.Controls.Add(this.UpdLblTimeOut);
            this.Controls.Add(this.UpdLblDuration);
            this.Controls.Add(this.UpdLlblTimeIn);
            this.Controls.Add(this.date_duty);
            this.Controls.Add(this.UpdLblStatus);
            this.Controls.Add(this.UpdLblDate);
            this.Controls.Add(this.employee_name);
            this.Controls.Add(this.UpdLblId);
            this.Controls.Add(this.duration);
            this.Controls.Add(this.overtime);
            this.Controls.Add(this.employee_id);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.btn_one14);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ATTENDANCEdutydurationUpdREVISED";
            this.Size = new System.Drawing.Size(1361, 776);
            this.Load += new System.EventHandler(this.ATTENDANCEdutydurationUpdREVISED_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private btn_one btn_clear;
        private btn_one btn_save;
        private Label LblName;
        private Label UpdLblOvertime;
        private Label UpdLblTimeOut;
        private Label UpdLblDuration;
        private Label UpdLlblTimeIn;
        private DateTimePicker date_duty;
        private Label UpdLblStatus;
        private Label UpdLblDate;
        private TextBox employee_name;
        private Label UpdLblId;
        private TextBox duration;
        private TextBox overtime;
        private TextBox employee_id;
        private btn_one LblStatus;
        private Label LblTitle;
        private btn_one btn_one14;
        private CComboBox status;
        private btn_one btn_findemployee;
        private MaskedTextBox time_in;
        private ComboBox time_inPeriod;
        private MaskedTextBox time_out;
        private ComboBox time_outPeriod;
    }
}
