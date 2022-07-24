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
            this.btn_clear = new EMS.btn_one();
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
            this.duty_duration = new System.Windows.Forms.TextBox();
            this.overtime = new System.Windows.Forms.TextBox();
            this.LblStatus = new EMS.btn_one();
            this.AddTitle = new System.Windows.Forms.Label();
            this.Addbkgrnd = new EMS.btn_one();
            this.btn_findemployee = new EMS.btn_one();
            this.time_out = new System.Windows.Forms.MaskedTextBox();
            this.clear_timein = new System.Windows.Forms.Label();
            this.now_timein = new System.Windows.Forms.Label();
            this.now_timeout = new System.Windows.Forms.Label();
            this.clear_timeout = new System.Windows.Forms.Label();
            this.timein = new System.Windows.Forms.DateTimePicker();
            this.timeout = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.pending_txt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.report_txt = new System.Windows.Forms.Label();
            this.blank_timein = new System.Windows.Forms.TextBox();
            this.blank_timeout = new LoginForm.TextBox();
            this.pending_btn = new EMS.btn_one();
            this.submit_btn = new EMS.btn_one();
            this.submit_cover = new System.Windows.Forms.Label();
            this.pending_cover = new System.Windows.Forms.Label();
            this.invalid_time = new System.Windows.Forms.Label();
            this.status_ = new System.Windows.Forms.ComboBox();
            this.dur = new System.Windows.Forms.Label();
            this.dat = new System.Windows.Forms.Label();
            this.DDsubheading = new System.Windows.Forms.Label();
            this.employee_name = new System.Windows.Forms.Label();
            this.id_message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.DimGray;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(128, 692);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(273, 51);
            this.btn_clear.TabIndex = 197;
            this.btn_clear.Text = "Reset";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.BackColor = System.Drawing.Color.White;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblName.ForeColor = System.Drawing.Color.Gray;
            this.LblName.Location = new System.Drawing.Point(187, 315);
            this.LblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(92, 18);
            this.LblName.TabIndex = 194;
            this.LblName.Text = "Employee ID";
            // 
            // AddLblOvertime
            // 
            this.AddLblOvertime.AutoSize = true;
            this.AddLblOvertime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.AddLblOvertime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddLblOvertime.ForeColor = System.Drawing.Color.White;
            this.AddLblOvertime.Location = new System.Drawing.Point(1009, 570);
            this.AddLblOvertime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.AddLblOvertime.Name = "AddLblOvertime";
            this.AddLblOvertime.Size = new System.Drawing.Size(68, 18);
            this.AddLblOvertime.TabIndex = 192;
            this.AddLblOvertime.Text = "Overtime";
            // 
            // AddLblTimeOut
            // 
            this.AddLblTimeOut.AutoSize = true;
            this.AddLblTimeOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.AddLblTimeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddLblTimeOut.ForeColor = System.Drawing.Color.White;
            this.AddLblTimeOut.Location = new System.Drawing.Point(604, 572);
            this.AddLblTimeOut.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.AddLblTimeOut.Name = "AddLblTimeOut";
            this.AddLblTimeOut.Size = new System.Drawing.Size(66, 18);
            this.AddLblTimeOut.TabIndex = 191;
            this.AddLblTimeOut.Text = "Time out";
            // 
            // AddLblDuration
            // 
            this.AddLblDuration.AutoSize = true;
            this.AddLblDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.AddLblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddLblDuration.ForeColor = System.Drawing.Color.White;
            this.AddLblDuration.Location = new System.Drawing.Point(1005, 476);
            this.AddLblDuration.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.AddLblDuration.Name = "AddLblDuration";
            this.AddLblDuration.Size = new System.Drawing.Size(64, 18);
            this.AddLblDuration.TabIndex = 190;
            this.AddLblDuration.Text = "Duration";
            // 
            // AddLlblTimeIn
            // 
            this.AddLlblTimeIn.AutoSize = true;
            this.AddLlblTimeIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.AddLlblTimeIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddLlblTimeIn.ForeColor = System.Drawing.Color.White;
            this.AddLlblTimeIn.Location = new System.Drawing.Point(604, 483);
            this.AddLlblTimeIn.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.AddLlblTimeIn.Name = "AddLlblTimeIn";
            this.AddLlblTimeIn.Size = new System.Drawing.Size(56, 18);
            this.AddLlblTimeIn.TabIndex = 189;
            this.AddLlblTimeIn.Text = "Time in";
            // 
            // date_duty
            // 
            this.date_duty.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date_duty.CustomFormat = "";
            this.date_duty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date_duty.Location = new System.Drawing.Point(600, 350);
            this.date_duty.MinDate = new System.DateTime(1995, 1, 1, 23, 59, 0, 0);
            this.date_duty.Name = "date_duty";
            this.date_duty.Size = new System.Drawing.Size(349, 28);
            this.date_duty.TabIndex = 188;
            this.date_duty.Value = new System.DateTime(2022, 7, 25, 0, 0, 0, 0);
            // 
            // AddLblStatus
            // 
            this.AddLblStatus.AutoSize = true;
            this.AddLblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.AddLblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddLblStatus.ForeColor = System.Drawing.Color.White;
            this.AddLblStatus.Location = new System.Drawing.Point(187, 572);
            this.AddLblStatus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.AddLblStatus.Name = "AddLblStatus";
            this.AddLblStatus.Size = new System.Drawing.Size(50, 18);
            this.AddLblStatus.TabIndex = 187;
            this.AddLblStatus.Text = "Status";
            // 
            // AddLblDate
            // 
            this.AddLblDate.AutoSize = true;
            this.AddLblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.AddLblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddLblDate.ForeColor = System.Drawing.Color.White;
            this.AddLblDate.Location = new System.Drawing.Point(187, 483);
            this.AddLblDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.AddLblDate.Name = "AddLblDate";
            this.AddLblDate.Size = new System.Drawing.Size(115, 18);
            this.AddLblDate.TabIndex = 186;
            this.AddLblDate.Text = "Employee name";
            // 
            // employee_id
            // 
            this.employee_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employee_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.employee_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employee_id.ForeColor = System.Drawing.Color.Black;
            this.employee_id.Location = new System.Drawing.Point(187, 347);
            this.employee_id.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.employee_id.Multiline = true;
            this.employee_id.Name = "employee_id";
            this.employee_id.Size = new System.Drawing.Size(349, 31);
            this.employee_id.TabIndex = 184;
            this.employee_id.TextChanged += new System.EventHandler(this.employee_id_TextChanged);
            // 
            // AddLblId
            // 
            this.AddLblId.AutoSize = true;
            this.AddLblId.BackColor = System.Drawing.Color.White;
            this.AddLblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddLblId.ForeColor = System.Drawing.Color.Gray;
            this.AddLblId.Location = new System.Drawing.Point(600, 317);
            this.AddLblId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.AddLblId.Name = "AddLblId";
            this.AddLblId.Size = new System.Drawing.Size(124, 18);
            this.AddLblId.TabIndex = 185;
            this.AddLblId.Text = "Choose duty date";
            // 
            // duty_duration
            // 
            this.duty_duration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.duty_duration.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.duty_duration.Enabled = false;
            this.duty_duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.duty_duration.ForeColor = System.Drawing.Color.Black;
            this.duty_duration.Location = new System.Drawing.Point(1009, 500);
            this.duty_duration.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.duty_duration.Multiline = true;
            this.duty_duration.Name = "duty_duration";
            this.duty_duration.Size = new System.Drawing.Size(349, 31);
            this.duty_duration.TabIndex = 183;
            this.duty_duration.Text = " ";
            // 
            // overtime
            // 
            this.overtime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.overtime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.overtime.Enabled = false;
            this.overtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.overtime.ForeColor = System.Drawing.Color.Black;
            this.overtime.Location = new System.Drawing.Point(1009, 592);
            this.overtime.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.overtime.Multiline = true;
            this.overtime.Name = "overtime";
            this.overtime.Size = new System.Drawing.Size(349, 31);
            this.overtime.TabIndex = 182;
            this.overtime.Text = " ";
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
            this.LblStatus.Location = new System.Drawing.Point(128, 397);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(1291, 276);
            this.LblStatus.TabIndex = 179;
            this.LblStatus.UseVisualStyleBackColor = false;
            // 
            // AddTitle
            // 
            this.AddTitle.AutoSize = true;
            this.AddTitle.BackColor = System.Drawing.Color.Transparent;
            this.AddTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(37)))), ((int)(((byte)(83)))));
            this.AddTitle.Location = new System.Drawing.Point(95, 91);
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
            this.Addbkgrnd.Location = new System.Drawing.Point(128, 293);
            this.Addbkgrnd.Name = "Addbkgrnd";
            this.Addbkgrnd.Size = new System.Drawing.Size(880, 155);
            this.Addbkgrnd.TabIndex = 193;
            this.Addbkgrnd.UseVisualStyleBackColor = false;
            // 
            // btn_findemployee
            // 
            this.btn_findemployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.btn_findemployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_findemployee.FlatAppearance.BorderSize = 0;
            this.btn_findemployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_findemployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_findemployee.ForeColor = System.Drawing.Color.White;
            this.btn_findemployee.Location = new System.Drawing.Point(1051, 315);
            this.btn_findemployee.Name = "btn_findemployee";
            this.btn_findemployee.Size = new System.Drawing.Size(225, 51);
            this.btn_findemployee.TabIndex = 201;
            this.btn_findemployee.Text = "Find Employee";
            this.btn_findemployee.UseVisualStyleBackColor = false;
            this.btn_findemployee.Click += new System.EventHandler(this.btn_findemployee_Click);
            // 
            // time_out
            // 
            this.time_out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(37)))), ((int)(((byte)(83)))));
            this.time_out.Enabled = false;
            this.time_out.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.time_out.Location = new System.Drawing.Point(844, 500);
            this.time_out.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.time_out.Name = "time_out";
            this.time_out.Size = new System.Drawing.Size(109, 34);
            this.time_out.TabIndex = 206;
            this.time_out.ValidatingType = typeof(System.DateTime);
            this.time_out.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.time_out_MaskInputRejected);
            // 
            // clear_timein
            // 
            this.clear_timein.AutoSize = true;
            this.clear_timein.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.clear_timein.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_timein.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.clear_timein.ForeColor = System.Drawing.Color.White;
            this.clear_timein.Location = new System.Drawing.Point(904, 473);
            this.clear_timein.Name = "clear_timein";
            this.clear_timein.Size = new System.Drawing.Size(49, 23);
            this.clear_timein.TabIndex = 208;
            this.clear_timein.Text = "Clear";
            this.clear_timein.Click += new System.EventHandler(this.clear_timein_Click);
            // 
            // now_timein
            // 
            this.now_timein.AutoSize = true;
            this.now_timein.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(37)))), ((int)(((byte)(83)))));
            this.now_timein.Cursor = System.Windows.Forms.Cursors.Hand;
            this.now_timein.Enabled = false;
            this.now_timein.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.now_timein.ForeColor = System.Drawing.Color.White;
            this.now_timein.Location = new System.Drawing.Point(857, 506);
            this.now_timein.Name = "now_timein";
            this.now_timein.Size = new System.Drawing.Size(84, 23);
            this.now_timein.TabIndex = 209;
            this.now_timein.Text = "Time now";
            this.now_timein.Click += new System.EventHandler(this.now_timein_Click);
            // 
            // now_timeout
            // 
            this.now_timeout.AutoSize = true;
            this.now_timeout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(37)))), ((int)(((byte)(83)))));
            this.now_timeout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.now_timeout.Enabled = false;
            this.now_timeout.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.now_timeout.ForeColor = System.Drawing.Color.White;
            this.now_timeout.Location = new System.Drawing.Point(857, 597);
            this.now_timeout.Name = "now_timeout";
            this.now_timeout.Size = new System.Drawing.Size(84, 23);
            this.now_timeout.TabIndex = 211;
            this.now_timeout.Text = "Time now";
            this.now_timeout.Click += new System.EventHandler(this.now_timeout_Click);
            // 
            // clear_timeout
            // 
            this.clear_timeout.AutoSize = true;
            this.clear_timeout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.clear_timeout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_timeout.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.clear_timeout.ForeColor = System.Drawing.Color.White;
            this.clear_timeout.Location = new System.Drawing.Point(904, 567);
            this.clear_timeout.Name = "clear_timeout";
            this.clear_timeout.Size = new System.Drawing.Size(49, 23);
            this.clear_timeout.TabIndex = 210;
            this.clear_timeout.Text = "Clear";
            this.clear_timeout.Click += new System.EventHandler(this.clear_timeout_Click);
            // 
            // timein
            // 
            this.timein.CustomFormat = "hh:mm:ss tt";
            this.timein.Enabled = false;
            this.timein.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timein.Location = new System.Drawing.Point(604, 504);
            this.timein.Name = "timein";
            this.timein.Size = new System.Drawing.Size(349, 27);
            this.timein.TabIndex = 212;
            this.timein.ValueChanged += new System.EventHandler(this.timein_ValueChanged);
            // 
            // timeout
            // 
            this.timeout.CustomFormat = "hh:mm:ss tt";
            this.timeout.Enabled = false;
            this.timeout.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeout.Location = new System.Drawing.Point(604, 596);
            this.timeout.Name = "timeout";
            this.timeout.Size = new System.Drawing.Size(349, 27);
            this.timeout.TabIndex = 213;
            this.timeout.ValueChanged += new System.EventHandler(this.timeout_ValueChanged);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(37)))), ((int)(((byte)(83)))));
            this.maskedTextBox1.Enabled = false;
            this.maskedTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBox1.Location = new System.Drawing.Point(844, 594);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(109, 34);
            this.maskedTextBox1.TabIndex = 214;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // pending_txt
            // 
            this.pending_txt.AutoSize = true;
            this.pending_txt.ForeColor = System.Drawing.Color.Black;
            this.pending_txt.Location = new System.Drawing.Point(969, 746);
            this.pending_txt.Name = "pending_txt";
            this.pending_txt.Size = new System.Drawing.Size(178, 20);
            this.pending_txt.TabIndex = 216;
            this.pending_txt.Text = "This will see in Duty Table";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1071, 569);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 217;
            this.label2.Text = "(hrs)";
            // 
            // report_txt
            // 
            this.report_txt.AutoSize = true;
            this.report_txt.ForeColor = System.Drawing.Color.Black;
            this.report_txt.Location = new System.Drawing.Point(1171, 746);
            this.report_txt.Name = "report_txt";
            this.report_txt.Size = new System.Drawing.Size(233, 20);
            this.report_txt.TabIndex = 218;
            this.report_txt.Text = "This will see in Attendance Report";
            // 
            // blank_timein
            // 
            this.blank_timein.Location = new System.Drawing.Point(604, 504);
            this.blank_timein.Name = "blank_timein";
            this.blank_timein.Size = new System.Drawing.Size(349, 27);
            this.blank_timein.TabIndex = 219;
            // 
            // blank_timeout
            // 
            this.blank_timeout.BackColor = System.Drawing.SystemColors.Window;
            this.blank_timeout.BorderColor = System.Drawing.Color.Transparent;
            this.blank_timeout.BorderFocusColor = System.Drawing.Color.HotPink;
            this.blank_timeout.BorderRadius = 0;
            this.blank_timeout.BorderSize = 2;
            this.blank_timeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.blank_timeout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.blank_timeout.Location = new System.Drawing.Point(604, 594);
            this.blank_timeout.Margin = new System.Windows.Forms.Padding(4);
            this.blank_timeout.Multiline = false;
            this.blank_timeout.Name = "blank_timeout";
            this.blank_timeout.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.blank_timeout.PasswordChar = false;
            this.blank_timeout.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.blank_timeout.PlaceholderText = "";
            this.blank_timeout.Size = new System.Drawing.Size(349, 35);
            this.blank_timeout.TabIndex = 220;
            this.blank_timeout.Texts = "";
            this.blank_timeout.UnderlinedStyle = false;
            // 
            // pending_btn
            // 
            this.pending_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(202)))), ((int)(((byte)(63)))));
            this.pending_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pending_btn.FlatAppearance.BorderSize = 0;
            this.pending_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pending_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pending_btn.ForeColor = System.Drawing.Color.White;
            this.pending_btn.Location = new System.Drawing.Point(944, 692);
            this.pending_btn.Name = "pending_btn";
            this.pending_btn.Size = new System.Drawing.Size(221, 51);
            this.pending_btn.TabIndex = 221;
            this.pending_btn.Text = "Pending";
            this.pending_btn.UseVisualStyleBackColor = false;
            this.pending_btn.Click += new System.EventHandler(this.pending_btn_Click);
            // 
            // submit_btn
            // 
            this.submit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(37)))), ((int)(((byte)(83)))));
            this.submit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submit_btn.FlatAppearance.BorderSize = 0;
            this.submit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.submit_btn.ForeColor = System.Drawing.Color.White;
            this.submit_btn.Location = new System.Drawing.Point(1171, 692);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(248, 51);
            this.submit_btn.TabIndex = 222;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = false;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // submit_cover
            // 
            this.submit_cover.AutoSize = true;
            this.submit_cover.Location = new System.Drawing.Point(1171, 693);
            this.submit_cover.Margin = new System.Windows.Forms.Padding(50, 0, 50, 50);
            this.submit_cover.Name = "submit_cover";
            this.submit_cover.Padding = new System.Windows.Forms.Padding(150, 50, 100, 50);
            this.submit_cover.Size = new System.Drawing.Size(250, 120);
            this.submit_cover.TabIndex = 226;
            this.submit_cover.Click += new System.EventHandler(this.submit_cover_Click);
            // 
            // pending_cover
            // 
            this.pending_cover.AutoSize = true;
            this.pending_cover.Location = new System.Drawing.Point(915, 687);
            this.pending_cover.Margin = new System.Windows.Forms.Padding(50, 0, 50, 50);
            this.pending_cover.Name = "pending_cover";
            this.pending_cover.Padding = new System.Windows.Forms.Padding(150, 50, 100, 50);
            this.pending_cover.Size = new System.Drawing.Size(250, 120);
            this.pending_cover.TabIndex = 227;
            this.pending_cover.Click += new System.EventHandler(this.pending_cover_Click);
            // 
            // invalid_time
            // 
            this.invalid_time.AutoSize = true;
            this.invalid_time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.invalid_time.ForeColor = System.Drawing.Color.DarkRed;
            this.invalid_time.Location = new System.Drawing.Point(1009, 534);
            this.invalid_time.Name = "invalid_time";
            this.invalid_time.Size = new System.Drawing.Size(269, 20);
            this.invalid_time.TabIndex = 228;
            this.invalid_time.Text = "Invalid time in and time out. Edit again.";
            this.invalid_time.Visible = false;
            // 
            // status_
            // 
            this.status_.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status_.Enabled = false;
            this.status_.FormattingEnabled = true;
            this.status_.Items.AddRange(new object[] {
            "Present",
            "Absent",
            "Leave",
            "--Select--"});
            this.status_.Location = new System.Drawing.Point(187, 600);
            this.status_.Name = "status_";
            this.status_.Size = new System.Drawing.Size(349, 28);
            this.status_.TabIndex = 229;
            this.status_.SelectedIndexChanged += new System.EventHandler(this.status__SelectedIndexChanged);
            // 
            // dur
            // 
            this.dur.AutoSize = true;
            this.dur.Location = new System.Drawing.Point(24, 787);
            this.dur.Name = "dur";
            this.dur.Size = new System.Drawing.Size(0, 20);
            this.dur.TabIndex = 230;
            this.dur.Visible = false;
            // 
            // dat
            // 
            this.dat.AutoSize = true;
            this.dat.Location = new System.Drawing.Point(74, 793);
            this.dat.Name = "dat";
            this.dat.Size = new System.Drawing.Size(0, 20);
            this.dat.TabIndex = 231;
            // 
            // DDsubheading
            // 
            this.DDsubheading.AutoSize = true;
            this.DDsubheading.BackColor = System.Drawing.Color.Transparent;
            this.DDsubheading.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DDsubheading.ForeColor = System.Drawing.Color.Gray;
            this.DDsubheading.Location = new System.Drawing.Point(95, 152);
            this.DDsubheading.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DDsubheading.Name = "DDsubheading";
            this.DDsubheading.Size = new System.Drawing.Size(455, 22);
            this.DDsubheading.TabIndex = 232;
            this.DDsubheading.Text = "Enter ID Number and DATE first to find employee.";
            // 
            // employee_name
            // 
            this.employee_name.AutoSize = true;
            this.employee_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.employee_name.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.employee_name.ForeColor = System.Drawing.Color.White;
            this.employee_name.Location = new System.Drawing.Point(187, 506);
            this.employee_name.Name = "employee_name";
            this.employee_name.Size = new System.Drawing.Size(0, 24);
            this.employee_name.TabIndex = 233;
            // 
            // id_message
            // 
            this.id_message.AutoSize = true;
            this.id_message.ForeColor = System.Drawing.Color.Black;
            this.id_message.Location = new System.Drawing.Point(287, 315);
            this.id_message.Name = "id_message";
            this.id_message.Size = new System.Drawing.Size(126, 20);
            this.id_message.TabIndex = 234;
            this.id_message.Text = "*Enter ID Number";
            this.id_message.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ATTENDANCEdutydurationAddREVISED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.id_message);
            this.Controls.Add(this.employee_name);
            this.Controls.Add(this.DDsubheading);
            this.Controls.Add(this.dat);
            this.Controls.Add(this.dur);
            this.Controls.Add(this.status_);
            this.Controls.Add(this.invalid_time);
            this.Controls.Add(this.pending_cover);
            this.Controls.Add(this.submit_cover);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.pending_btn);
            this.Controls.Add(this.now_timeout);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.blank_timeout);
            this.Controls.Add(this.now_timein);
            this.Controls.Add(this.time_out);
            this.Controls.Add(this.blank_timein);
            this.Controls.Add(this.report_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pending_txt);
            this.Controls.Add(this.timeout);
            this.Controls.Add(this.timein);
            this.Controls.Add(this.clear_timeout);
            this.Controls.Add(this.clear_timein);
            this.Controls.Add(this.btn_findemployee);
            this.Controls.Add(this.btn_clear);
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
            this.Controls.Add(this.duty_duration);
            this.Controls.Add(this.overtime);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.AddTitle);
            this.Controls.Add(this.Addbkgrnd);
            this.Name = "ATTENDANCEdutydurationAddREVISED";
            this.Size = new System.Drawing.Size(1537, 1035);
            this.Load += new System.EventHandler(this.ATTENDANCEdutydurationAddREVISED_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private btn_one btn_clear;
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
        private TextBox duty_duration;
        private TextBox overtime;
        private btn_one LblStatus;
        private Label AddTitle;
        private btn_one Addbkgrnd;
        private btn_one btn_findemployee;
        private MaskedTextBox time_out;
        private Label clear_timein;
        private Label now_timein;
        private Label now_timeout;
        private Label clear_timeout;
        private DateTimePicker timein;
        private DateTimePicker timeout;
        private MaskedTextBox maskedTextBox1;
        private Label pending_txt;
        private Label label2;
        private Label report_txt;
        private TextBox blank_timein;
        private LoginForm.TextBox blank_timeout;
        private btn_one pending_btn;
        private btn_one submit_btn;
        private Label submit_cover;
        private Label pending_cover;
        private Label invalid_time;
        private ComboBox status_;
        private Label dur;
        private Label dat;
        private Label DDsubheading;
        private Label employee_name;
        private Label id_message;
    }
}
