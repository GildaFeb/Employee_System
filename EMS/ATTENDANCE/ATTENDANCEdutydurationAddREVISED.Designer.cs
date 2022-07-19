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
            this.time_in = new System.Windows.Forms.MaskedTextBox();
            this.time_out = new System.Windows.Forms.MaskedTextBox();
            this.clear_timein = new System.Windows.Forms.Label();
            this.now_timein = new System.Windows.Forms.Label();
            this.now_timeout = new System.Windows.Forms.Label();
            this.clear_timeout = new System.Windows.Forms.Label();
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
            this.btn_clear.Location = new System.Drawing.Point(128, 692);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(273, 51);
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
            this.btn_save.Location = new System.Drawing.Point(1191, 692);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(229, 51);
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
            this.AddLblOvertime.Location = new System.Drawing.Point(1009, 552);
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
            this.AddLblTimeOut.Location = new System.Drawing.Point(600, 556);
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
            this.AddLblDuration.Location = new System.Drawing.Point(1009, 460);
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
            this.AddLlblTimeIn.Location = new System.Drawing.Point(600, 451);
            this.AddLlblTimeIn.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.AddLlblTimeIn.Name = "AddLlblTimeIn";
            this.AddLlblTimeIn.Size = new System.Drawing.Size(56, 18);
            this.AddLlblTimeIn.TabIndex = 189;
            this.AddLlblTimeIn.Text = "Time in";
            this.AddLlblTimeIn.Click += new System.EventHandler(this.AddLlblTimeIn_Click);
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
            this.date_duty.Value = new System.DateTime(2022, 7, 25, 23, 59, 59, 0);
            // 
            // AddLblStatus
            // 
            this.AddLblStatus.AutoSize = true;
            this.AddLblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.AddLblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddLblStatus.ForeColor = System.Drawing.Color.White;
            this.AddLblStatus.Location = new System.Drawing.Point(187, 552);
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
            this.AddLblDate.Location = new System.Drawing.Point(187, 460);
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
            this.employee_id.Text = " ";
            this.employee_id.TextChanged += new System.EventHandler(this.employee_id_TextChanged);
            // 
            // AddLblId
            // 
            this.AddLblId.AutoSize = true;
            this.AddLblId.BackColor = System.Drawing.Color.White;
            this.AddLblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddLblId.ForeColor = System.Drawing.Color.Gray;
            this.AddLblId.Location = new System.Drawing.Point(600, 315);
            this.AddLblId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.AddLblId.Name = "AddLblId";
            this.AddLblId.Size = new System.Drawing.Size(39, 18);
            this.AddLblId.TabIndex = 185;
            this.AddLblId.Text = "Date";
            // 
            // duration
            // 
            this.duration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.duration.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.duration.ForeColor = System.Drawing.Color.Black;
            this.duration.Location = new System.Drawing.Point(1009, 500);
            this.duration.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.duration.Multiline = true;
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(349, 31);
            this.duration.TabIndex = 183;
            this.duration.Text = " ";
            // 
            // overtime
            // 
            this.overtime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.overtime.Cursor = System.Windows.Forms.Cursors.IBeam;
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
            // employee_name
            // 
            this.employee_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employee_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.employee_name.Enabled = false;
            this.employee_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employee_name.ForeColor = System.Drawing.Color.Black;
            this.employee_name.Location = new System.Drawing.Point(187, 494);
            this.employee_name.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.employee_name.Multiline = true;
            this.employee_name.Name = "employee_name";
            this.employee_name.Size = new System.Drawing.Size(349, 37);
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
            // status
            // 
            this.status.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.status.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.status.BackColor = System.Drawing.Color.White;
            this.status.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.status.BorderSize = 0;
            this.status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.status.ForeColor = System.Drawing.Color.Black;
            this.status.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.status.Items.AddRange(new object[] {
            "On Leave",
            "Absent",
            "Present"});
            this.status.ListBackColor = System.Drawing.Color.Silver;
            this.status.ListTextColor = System.Drawing.Color.Black;
            this.status.Location = new System.Drawing.Point(187, 583);
            this.status.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.status.MinimumSize = new System.Drawing.Size(229, 40);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(349, 40);
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
            this.btn_findemployee.Location = new System.Drawing.Point(1067, 315);
            this.btn_findemployee.Name = "btn_findemployee";
            this.btn_findemployee.Size = new System.Drawing.Size(225, 51);
            this.btn_findemployee.TabIndex = 201;
            this.btn_findemployee.Text = "Find Employee";
            this.btn_findemployee.UseVisualStyleBackColor = false;
            this.btn_findemployee.Click += new System.EventHandler(this.btn_findemployee_Click);
            // 
            // time_in
            // 
            this.time_in.Cursor = System.Windows.Forms.Cursors.Hand;
            this.time_in.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.time_in.Location = new System.Drawing.Point(609, 494);
            this.time_in.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.time_in.Mask = "00:00";
            this.time_in.Name = "time_in";
            this.time_in.Size = new System.Drawing.Size(344, 34);
            this.time_in.TabIndex = 204;
            this.time_in.ValidatingType = typeof(System.DateTime);
            this.time_in.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.time_in_MaskInputRejected);
            // 
            // time_out
            // 
            this.time_out.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.time_out.Location = new System.Drawing.Point(609, 589);
            this.time_out.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.time_out.Mask = "00:00";
            this.time_out.Name = "time_out";
            this.time_out.Size = new System.Drawing.Size(344, 34);
            this.time_out.TabIndex = 206;
            this.time_out.ValidatingType = typeof(System.DateTime);
            // 
            // clear_timein
            // 
            this.clear_timein.AutoSize = true;
            this.clear_timein.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.clear_timein.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_timein.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.clear_timein.ForeColor = System.Drawing.Color.White;
            this.clear_timein.Location = new System.Drawing.Point(817, 470);
            this.clear_timein.Name = "clear_timein";
            this.clear_timein.Size = new System.Drawing.Size(49, 23);
            this.clear_timein.TabIndex = 208;
            this.clear_timein.Text = "Clear";
            this.clear_timein.Click += new System.EventHandler(this.clear_timein_Click);
            // 
            // now_timein
            // 
            this.now_timein.AutoSize = true;
            this.now_timein.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.now_timein.Cursor = System.Windows.Forms.Cursors.Hand;
            this.now_timein.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.now_timein.ForeColor = System.Drawing.Color.White;
            this.now_timein.Location = new System.Drawing.Point(869, 470);
            this.now_timein.Name = "now_timein";
            this.now_timein.Size = new System.Drawing.Size(84, 23);
            this.now_timein.TabIndex = 209;
            this.now_timein.Text = "Time now";
            this.now_timein.Click += new System.EventHandler(this.now_timein_Click);
            // 
            // now_timeout
            // 
            this.now_timeout.AutoSize = true;
            this.now_timeout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.now_timeout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.now_timeout.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.now_timeout.ForeColor = System.Drawing.Color.White;
            this.now_timeout.Location = new System.Drawing.Point(869, 562);
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
            this.clear_timeout.Location = new System.Drawing.Point(817, 562);
            this.clear_timeout.Name = "clear_timeout";
            this.clear_timeout.Size = new System.Drawing.Size(49, 23);
            this.clear_timeout.TabIndex = 210;
            this.clear_timeout.Text = "Clear";
            this.clear_timeout.Click += new System.EventHandler(this.clear_timeout_Click);
            // 
            // ATTENDANCEdutydurationAddREVISED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.now_timeout);
            this.Controls.Add(this.clear_timeout);
            this.Controls.Add(this.now_timein);
            this.Controls.Add(this.clear_timein);
            this.Controls.Add(this.time_out);
            this.Controls.Add(this.time_in);
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
            this.Name = "ATTENDANCEdutydurationAddREVISED";
            this.Size = new System.Drawing.Size(1537, 1035);
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
        private MaskedTextBox time_in;
        private MaskedTextBox time_out;
        private Label clear_timein;
        private Label now_timein;
        private Label now_timeout;
        private Label clear_timeout;
    }
}
