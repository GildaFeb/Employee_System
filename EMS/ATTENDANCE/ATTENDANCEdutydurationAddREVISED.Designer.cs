﻿namespace EMS
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
            this.btn_clear = new EMS.btn_one();
            this.btn_save = new EMS.btn_one();
            this.LblName = new System.Windows.Forms.Label();
            this.AddLblOvertime = new System.Windows.Forms.Label();
            this.AddLblTimeOut = new System.Windows.Forms.Label();
            this.AddLblDuration = new System.Windows.Forms.Label();
            this.AddLlblTimeIn = new System.Windows.Forms.Label();
            this.date_duty = new System.Windows.Forms.DateTimePicker();
            this.AddLblStatus = new System.Windows.Forms.Label();
            this.AddLblDate = new System.Windows.Forms.Label();
            this.employee_id = new System.Windows.Forms.TextBox();
            this.AddLblId = new System.Windows.Forms.Label();
            this.duration = new System.Windows.Forms.TextBox();
            this.overtime = new System.Windows.Forms.TextBox();
            this.employee_name = new System.Windows.Forms.TextBox();
            this.LblStatus = new EMS.btn_one();
            this.AddTitle = new System.Windows.Forms.Label();
            this.Addbkgrnd = new EMS.btn_one();
            this.status = new EMS.CComboBox();
            this.btn_findemployee = new EMS.btn_one();
            this.time_inPeriod = new System.Windows.Forms.ComboBox();
            this.time_in = new System.Windows.Forms.MaskedTextBox();
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
            this.btn_clear.Location = new System.Drawing.Point(112, 519);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(239, 38);
            this.btn_clear.TabIndex = 197;
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
            this.btn_save.Location = new System.Drawing.Point(1042, 519);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(200, 38);
            this.btn_save.TabIndex = 196;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.AddSave_Click);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.BackColor = System.Drawing.Color.White;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblName.ForeColor = System.Drawing.Color.Gray;
            this.LblName.Location = new System.Drawing.Point(164, 236);
            this.LblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(77, 15);
            this.LblName.TabIndex = 194;
            this.LblName.Text = "Employee ID";
            // 
            // AddLblOvertime
            // 
            this.AddLblOvertime.AutoSize = true;
            this.AddLblOvertime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.AddLblOvertime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddLblOvertime.ForeColor = System.Drawing.Color.White;
            this.AddLblOvertime.Location = new System.Drawing.Point(883, 414);
            this.AddLblOvertime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddLblOvertime.Name = "AddLblOvertime";
            this.AddLblOvertime.Size = new System.Drawing.Size(56, 15);
            this.AddLblOvertime.TabIndex = 192;
            this.AddLblOvertime.Text = "Overtime";
            // 
            // AddLblTimeOut
            // 
            this.AddLblTimeOut.AutoSize = true;
            this.AddLblTimeOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.AddLblTimeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddLblTimeOut.ForeColor = System.Drawing.Color.White;
            this.AddLblTimeOut.Location = new System.Drawing.Point(525, 417);
            this.AddLblTimeOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddLblTimeOut.Name = "AddLblTimeOut";
            this.AddLblTimeOut.Size = new System.Drawing.Size(55, 15);
            this.AddLblTimeOut.TabIndex = 191;
            this.AddLblTimeOut.Text = "Time out";
            // 
            // AddLblDuration
            // 
            this.AddLblDuration.AutoSize = true;
            this.AddLblDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.AddLblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddLblDuration.ForeColor = System.Drawing.Color.White;
            this.AddLblDuration.Location = new System.Drawing.Point(883, 345);
            this.AddLblDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddLblDuration.Name = "AddLblDuration";
            this.AddLblDuration.Size = new System.Drawing.Size(54, 15);
            this.AddLblDuration.TabIndex = 190;
            this.AddLblDuration.Text = "Duration";
            // 
            // AddLlblTimeIn
            // 
            this.AddLlblTimeIn.AutoSize = true;
            this.AddLlblTimeIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.AddLlblTimeIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddLlblTimeIn.ForeColor = System.Drawing.Color.White;
            this.AddLlblTimeIn.Location = new System.Drawing.Point(525, 338);
            this.AddLlblTimeIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddLlblTimeIn.Name = "AddLlblTimeIn";
            this.AddLlblTimeIn.Size = new System.Drawing.Size(48, 15);
            this.AddLlblTimeIn.TabIndex = 189;
            this.AddLlblTimeIn.Text = "Time in";
            this.AddLlblTimeIn.Click += new System.EventHandler(this.AddLlblTimeIn_Click);
            // 
            // date_duty
            // 
            this.date_duty.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date_duty.CustomFormat = "";
            this.date_duty.Enabled = false;
            this.date_duty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date_duty.Location = new System.Drawing.Point(164, 442);
            this.date_duty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_duty.MinDate = new System.DateTime(1995, 1, 1, 23, 59, 0, 0);
            this.date_duty.Name = "date_duty";
            this.date_duty.Size = new System.Drawing.Size(306, 24);
            this.date_duty.TabIndex = 188;
            this.date_duty.Value = new System.DateTime(2022, 7, 25, 23, 59, 59, 0);
            // 
            // AddLblStatus
            // 
            this.AddLblStatus.AutoSize = true;
            this.AddLblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.AddLblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddLblStatus.ForeColor = System.Drawing.Color.White;
            this.AddLblStatus.Location = new System.Drawing.Point(164, 338);
            this.AddLblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddLblStatus.Name = "AddLblStatus";
            this.AddLblStatus.Size = new System.Drawing.Size(41, 15);
            this.AddLblStatus.TabIndex = 187;
            this.AddLblStatus.Text = "Status";
            // 
            // AddLblDate
            // 
            this.AddLblDate.AutoSize = true;
            this.AddLblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.AddLblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddLblDate.ForeColor = System.Drawing.Color.White;
            this.AddLblDate.Location = new System.Drawing.Point(164, 414);
            this.AddLblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddLblDate.Name = "AddLblDate";
            this.AddLblDate.Size = new System.Drawing.Size(71, 15);
            this.AddLblDate.TabIndex = 186;
            this.AddLblDate.Text = "Date of duty";
            // 
            // employee_id
            // 
            this.employee_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employee_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.employee_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employee_id.ForeColor = System.Drawing.Color.Black;
            this.employee_id.Location = new System.Drawing.Point(164, 260);
            this.employee_id.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.employee_id.Multiline = true;
            this.employee_id.Name = "employee_id";
            this.employee_id.Size = new System.Drawing.Size(306, 24);
            this.employee_id.TabIndex = 184;
            this.employee_id.Text = " ";
            this.employee_id.TextChanged += new System.EventHandler(this.employee_id_TextChanged);
            // 
            // AddLblId
            // 
            this.AddLblId.AutoSize = true;
            this.AddLblId.BackColor = System.Drawing.Color.White;
            this.AddLblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddLblId.ForeColor = System.Drawing.Color.Gray;
            this.AddLblId.Location = new System.Drawing.Point(525, 236);
            this.AddLblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddLblId.Name = "AddLblId";
            this.AddLblId.Size = new System.Drawing.Size(99, 15);
            this.AddLblId.TabIndex = 185;
            this.AddLblId.Text = "Employee Name";
            // 
            // duration
            // 
            this.duration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.duration.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.duration.Enabled = false;
            this.duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.duration.ForeColor = System.Drawing.Color.Black;
            this.duration.Location = new System.Drawing.Point(883, 375);
            this.duration.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.duration.Multiline = true;
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(306, 24);
            this.duration.TabIndex = 183;
            this.duration.Text = " ";
            // 
            // overtime
            // 
            this.overtime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.overtime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.overtime.Enabled = false;
            this.overtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.overtime.ForeColor = System.Drawing.Color.Black;
            this.overtime.Location = new System.Drawing.Point(883, 444);
            this.overtime.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.overtime.Multiline = true;
            this.overtime.Name = "overtime";
            this.overtime.Size = new System.Drawing.Size(306, 24);
            this.overtime.TabIndex = 182;
            this.overtime.Text = " ";
            // 
            // employee_name
            // 
            this.employee_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employee_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.employee_name.Enabled = false;
            this.employee_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employee_name.ForeColor = System.Drawing.Color.Black;
            this.employee_name.Location = new System.Drawing.Point(525, 260);
            this.employee_name.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.employee_name.Multiline = true;
            this.employee_name.Name = "employee_name";
            this.employee_name.Size = new System.Drawing.Size(306, 24);
            this.employee_name.TabIndex = 181;
            this.employee_name.Text = " ";
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
            this.LblStatus.TabIndex = 179;
            this.LblStatus.UseVisualStyleBackColor = false;
            // 
            // AddTitle
            // 
            this.AddTitle.AutoSize = true;
            this.AddTitle.BackColor = System.Drawing.Color.Transparent;
            this.AddTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(37)))), ((int)(((byte)(83)))));
            this.AddTitle.Location = new System.Drawing.Point(83, 68);
            this.AddTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddTitle.Name = "AddTitle";
            this.AddTitle.Size = new System.Drawing.Size(556, 39);
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
            this.Addbkgrnd.Location = new System.Drawing.Point(112, 220);
            this.Addbkgrnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Addbkgrnd.Name = "Addbkgrnd";
            this.Addbkgrnd.Size = new System.Drawing.Size(770, 116);
            this.Addbkgrnd.TabIndex = 193;
            this.Addbkgrnd.UseVisualStyleBackColor = false;
            // 
            // status
            // 
            this.status.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.status.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.status.BackColor = System.Drawing.Color.White;
            this.status.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.status.BorderSize = 0;
            this.status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.status.ForeColor = System.Drawing.Color.Black;
            this.status.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.status.Items.AddRange(new object[] {
            "On Leave",
            "Absent",
            "Present"});
            this.status.ListBackColor = System.Drawing.Color.Silver;
            this.status.ListTextColor = System.Drawing.Color.Black;
            this.status.Location = new System.Drawing.Point(164, 364);
            this.status.MinimumSize = new System.Drawing.Size(200, 30);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(305, 34);
            this.status.TabIndex = 200;
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
            this.btn_findemployee.Location = new System.Drawing.Point(934, 236);
            this.btn_findemployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_findemployee.Name = "btn_findemployee";
            this.btn_findemployee.Size = new System.Drawing.Size(197, 38);
            this.btn_findemployee.TabIndex = 201;
            this.btn_findemployee.Text = "Find Employee";
            this.btn_findemployee.UseVisualStyleBackColor = false;
            // 
            // time_inPeriod
            // 
            this.time_inPeriod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.time_inPeriod.FormattingEnabled = true;
            this.time_inPeriod.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.time_inPeriod.Location = new System.Drawing.Point(731, 367);
            this.time_inPeriod.Name = "time_inPeriod";
            this.time_inPeriod.Size = new System.Drawing.Size(100, 29);
            this.time_inPeriod.TabIndex = 203;
            // 
            // time_in
            // 
            this.time_in.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.time_in.Location = new System.Drawing.Point(533, 367);
            this.time_in.Mask = "00:00:00";
            this.time_in.Name = "time_in";
            this.time_in.Size = new System.Drawing.Size(192, 29);
            this.time_in.TabIndex = 204;
            this.time_in.Text = "115959";
            this.time_in.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // time_out
            // 
            this.time_out.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.time_out.Location = new System.Drawing.Point(533, 441);
            this.time_out.Mask = "00:00:00";
            this.time_out.Name = "time_out";
            this.time_out.Size = new System.Drawing.Size(192, 29);
            this.time_out.TabIndex = 206;
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
            this.time_outPeriod.Location = new System.Drawing.Point(731, 441);
            this.time_outPeriod.Name = "time_outPeriod";
            this.time_outPeriod.Size = new System.Drawing.Size(100, 29);
            this.time_outPeriod.TabIndex = 205;
            // 
            // ATTENDANCEdutydurationAddREVISED
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
            this.Controls.Add(this.AddLblOvertime);
            this.Controls.Add(this.AddLblTimeOut);
            this.Controls.Add(this.AddLblDuration);
            this.Controls.Add(this.AddLlblTimeIn);
            this.Controls.Add(this.date_duty);
            this.Controls.Add(this.AddLblStatus);
            this.Controls.Add(this.AddLblDate);
            this.Controls.Add(this.employee_id);
            this.Controls.Add(this.AddLblId);
            this.Controls.Add(this.duration);
            this.Controls.Add(this.overtime);
            this.Controls.Add(this.employee_name);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.AddTitle);
            this.Controls.Add(this.Addbkgrnd);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ATTENDANCEdutydurationAddREVISED";
            this.Size = new System.Drawing.Size(1345, 776);
            this.Load += new System.EventHandler(this.ATTENDANCEdutydurationAddREVISED_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private btn_one btn_clear;
        private btn_one btn_save;
        private Label LblName;
        private Label AddLblOvertime;
        private Label AddLblTimeOut;
        private Label AddLblDuration;
        private Label AddLlblTimeIn;
        private DateTimePicker date_duty;
        private Label AddLblStatus;
        private Label AddLblDate;
        private TextBox employee_id;
        private Label AddLblId;
        private TextBox duration;
        private TextBox overtime;
        private TextBox employee_name;
        private btn_one LblStatus;
        private Label AddTitle;
        private btn_one Addbkgrnd;
        private CComboBox status;
        private btn_one btn_findemployee;
        private ComboBox time_inPeriod;
        private MaskedTextBox time_in;
        private MaskedTextBox time_out;
        private ComboBox time_outPeriod;
    }
}
