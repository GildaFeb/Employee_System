namespace EMS
{
    partial class EMPLOYEESupdate_revised
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EMPLOYEESupdate_revised));
            this.btn_clear = new EMS.btn_one();
            this.btn_save = new EMS.btn_one();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.sex = new System.Windows.Forms.ComboBox();
            this.position = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.birth_date = new System.Windows.Forms.TextBox();
            this.cnumber_emergency = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.contact_number = new System.Windows.Forms.TextBox();
            this.middle_name = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.first_name = new System.Windows.Forms.TextBox();
            this.last_name = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.employee_id = new System.Windows.Forms.TextBox();
            this.hired_date = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.btn_one1 = new EMS.btn_one();
            this.btn_one14 = new EMS.btn_one();
            this.label11 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.regular_pay = new System.Windows.Forms.ComboBox();
            this.regular_worktime = new System.Windows.Forms.ComboBox();
            this.total_rpay = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(969, 876);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(258, 50);
            this.btn_clear.TabIndex = 158;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(202)))), ((int)(((byte)(63)))));
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(1233, 876);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(242, 50);
            this.btn_save.TabIndex = 159;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_one3_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(594, 672);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(827, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 156;
            this.pictureBox3.TabStop = false;
            // 
            // sex
            // 
            this.sex.Enabled = false;
            this.sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sex.ForeColor = System.Drawing.Color.Black;
            this.sex.FormattingEnabled = true;
            this.sex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.sex.Location = new System.Drawing.Point(597, 768);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(349, 33);
            this.sex.TabIndex = 154;
            // 
            // position
            // 
            this.position.Enabled = false;
            this.position.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.position.ForeColor = System.Drawing.Color.Black;
            this.position.FormattingEnabled = true;
            this.position.Items.AddRange(new object[] {
            "Position A",
            "Position B",
            "Position C"});
            this.position.Location = new System.Drawing.Point(597, 326);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(349, 33);
            this.position.TabIndex = 153;
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(594, 475);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 18);
            this.label2.TabIndex = 151;
            this.label2.Text = "Regular worktime";
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(594, 381);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 152;
            this.label3.Text = "Regular pay";
            // 
            // label9
            // 
            this.label9.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(595, 288);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 18);
            this.label9.TabIndex = 150;
            this.label9.Text = "Position";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.White;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.label21.Location = new System.Drawing.Point(597, 229);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(214, 29);
            this.label21.TabIndex = 147;
            this.label21.Text = "Employment data";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.label15.Location = new System.Drawing.Point(1074, 228);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(252, 29);
            this.label15.TabIndex = 146;
            this.label15.Text = "Contact and address";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.label14.Location = new System.Drawing.Point(477, 750);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 29);
            this.label14.TabIndex = 145;
            this.label14.Text = "Other";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.label1.Location = new System.Drawing.Point(121, 229);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 144;
            this.label1.Text = "Name";
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(596, 577);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 18);
            this.label5.TabIndex = 141;
            this.label5.Text = "Total regular pay";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(1070, 729);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 18);
            this.label17.TabIndex = 139;
            this.label17.Text = "Date of birth";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(593, 729);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 18);
            this.label12.TabIndex = 135;
            this.label12.Text = "Sex";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(1071, 577);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(259, 18);
            this.label10.TabIndex = 133;
            this.label10.Text = "Contact number in case of emergency";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(1071, 475);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 18);
            this.label8.TabIndex = 136;
            this.label8.Text = "Email address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(1071, 381);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 18);
            this.label7.TabIndex = 132;
            this.label7.Text = "Contact number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(1071, 288);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 138;
            this.label6.Text = "Address";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(117, 475);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 18);
            this.label13.TabIndex = 140;
            this.label13.Text = "Middle name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(117, 381);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 134;
            this.label4.Text = "First name";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label18.Location = new System.Drawing.Point(117, 288);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 18);
            this.label18.TabIndex = 137;
            this.label18.Text = "Last name";
            // 
            // birth_date
            // 
            this.birth_date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.birth_date.Enabled = false;
            this.birth_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.birth_date.ForeColor = System.Drawing.Color.Black;
            this.birth_date.Location = new System.Drawing.Point(1074, 768);
            this.birth_date.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.birth_date.Multiline = true;
            this.birth_date.Name = "birth_date";
            this.birth_date.Size = new System.Drawing.Size(349, 32);
            this.birth_date.TabIndex = 125;
            this.birth_date.Text = " ";
            this.birth_date.TextChanged += new System.EventHandler(this.birth_date_TextChanged);
            // 
            // cnumber_emergency
            // 
            this.cnumber_emergency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cnumber_emergency.Enabled = false;
            this.cnumber_emergency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cnumber_emergency.ForeColor = System.Drawing.Color.Black;
            this.cnumber_emergency.Location = new System.Drawing.Point(1071, 616);
            this.cnumber_emergency.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cnumber_emergency.Multiline = true;
            this.cnumber_emergency.Name = "cnumber_emergency";
            this.cnumber_emergency.Size = new System.Drawing.Size(349, 32);
            this.cnumber_emergency.TabIndex = 126;
            this.cnumber_emergency.Text = " ";
            this.cnumber_emergency.TextChanged += new System.EventHandler(this.cnumber_emergency_TextChanged);
            // 
            // email
            // 
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email.Enabled = false;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email.ForeColor = System.Drawing.Color.Black;
            this.email.Location = new System.Drawing.Point(1074, 513);
            this.email.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(349, 32);
            this.email.TabIndex = 124;
            this.email.Text = " ";
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // contact_number
            // 
            this.contact_number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contact_number.Enabled = false;
            this.contact_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contact_number.ForeColor = System.Drawing.Color.Black;
            this.contact_number.Location = new System.Drawing.Point(1075, 420);
            this.contact_number.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.contact_number.Multiline = true;
            this.contact_number.Name = "contact_number";
            this.contact_number.Size = new System.Drawing.Size(349, 32);
            this.contact_number.TabIndex = 127;
            this.contact_number.Text = " ";
            this.contact_number.TextChanged += new System.EventHandler(this.contact_number_TextChanged);
            // 
            // middle_name
            // 
            this.middle_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.middle_name.Enabled = false;
            this.middle_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.middle_name.ForeColor = System.Drawing.Color.Black;
            this.middle_name.Location = new System.Drawing.Point(121, 513);
            this.middle_name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.middle_name.Multiline = true;
            this.middle_name.Name = "middle_name";
            this.middle_name.Size = new System.Drawing.Size(349, 32);
            this.middle_name.TabIndex = 131;
            this.middle_name.Text = " ";
            // 
            // address
            // 
            this.address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address.Enabled = false;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.address.ForeColor = System.Drawing.Color.Black;
            this.address.Location = new System.Drawing.Point(1075, 326);
            this.address.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(349, 32);
            this.address.TabIndex = 128;
            this.address.Text = " ";
            this.address.TextChanged += new System.EventHandler(this.address_TextChanged);
            // 
            // first_name
            // 
            this.first_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.first_name.Enabled = false;
            this.first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.first_name.ForeColor = System.Drawing.Color.Black;
            this.first_name.Location = new System.Drawing.Point(121, 419);
            this.first_name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.first_name.Multiline = true;
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(349, 32);
            this.first_name.TabIndex = 129;
            this.first_name.Text = " ";
            // 
            // last_name
            // 
            this.last_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.last_name.Enabled = false;
            this.last_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.last_name.ForeColor = System.Drawing.Color.Black;
            this.last_name.Location = new System.Drawing.Point(121, 326);
            this.last_name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.last_name.Multiline = true;
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(349, 32);
            this.last_name.TabIndex = 130;
            this.last_name.Text = " ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(0)))));
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(602, 98);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 22);
            this.label16.TabIndex = 122;
            this.label16.Text = "ID number";
            // 
            // employee_id
            // 
            this.employee_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employee_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.employee_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employee_id.ForeColor = System.Drawing.Color.Black;
            this.employee_id.Location = new System.Drawing.Point(604, 132);
            this.employee_id.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.employee_id.Multiline = true;
            this.employee_id.Name = "employee_id";
            this.employee_id.Size = new System.Drawing.Size(349, 32);
            this.employee_id.TabIndex = 120;
            // 
            // hired_date
            // 
            this.hired_date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hired_date.CustomFormat = "";
            this.hired_date.Enabled = false;
            this.hired_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hired_date.Location = new System.Drawing.Point(1078, 134);
            this.hired_date.Name = "hired_date";
            this.hired_date.Size = new System.Drawing.Size(349, 30);
            this.hired_date.TabIndex = 119;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(0)))));
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label20.Location = new System.Drawing.Point(1074, 99);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(82, 18);
            this.label20.TabIndex = 118;
            this.label20.Text = "Date joined";
            // 
            // btn_one1
            // 
            this.btn_one1.BackColor = System.Drawing.Color.White;
            this.btn_one1.FlatAppearance.BorderSize = 0;
            this.btn_one1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_one1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_one1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_one1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_one1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(37)))), ((int)(((byte)(83)))));
            this.btn_one1.Location = new System.Drawing.Point(77, 195);
            this.btn_one1.Name = "btn_one1";
            this.btn_one1.Size = new System.Drawing.Size(1398, 644);
            this.btn_one1.TabIndex = 143;
            this.btn_one1.UseVisualStyleBackColor = false;
            // 
            // btn_one14
            // 
            this.btn_one14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(0)))));
            this.btn_one14.FlatAppearance.BorderSize = 0;
            this.btn_one14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(233)))), ((int)(((byte)(32)))));
            this.btn_one14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(233)))), ((int)(((byte)(32)))));
            this.btn_one14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_one14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_one14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(37)))), ((int)(((byte)(83)))));
            this.btn_one14.Location = new System.Drawing.Point(559, 75);
            this.btn_one14.Name = "btn_one14";
            this.btn_one14.Size = new System.Drawing.Size(916, 179);
            this.btn_one14.TabIndex = 142;
            this.btn_one14.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(122, 133);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(235, 22);
            this.label11.TabIndex = 160;
            this.label11.Text = "Enter the ID number first.";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(37)))), ((int)(((byte)(83)))));
            this.label22.Location = new System.Drawing.Point(114, 75);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(381, 42);
            this.label22.TabIndex = 155;
            this.label22.Text = "Update an employee";
            // 
            // regular_pay
            // 
            this.regular_pay.Enabled = false;
            this.regular_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.regular_pay.ForeColor = System.Drawing.Color.Black;
            this.regular_pay.FormattingEnabled = true;
            this.regular_pay.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.regular_pay.Location = new System.Drawing.Point(597, 420);
            this.regular_pay.Name = "regular_pay";
            this.regular_pay.Size = new System.Drawing.Size(349, 33);
            this.regular_pay.TabIndex = 153;
            // 
            // regular_worktime
            // 
            this.regular_worktime.Enabled = false;
            this.regular_worktime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.regular_worktime.ForeColor = System.Drawing.Color.Black;
            this.regular_worktime.FormattingEnabled = true;
            this.regular_worktime.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.regular_worktime.Location = new System.Drawing.Point(597, 513);
            this.regular_worktime.Name = "regular_worktime";
            this.regular_worktime.Size = new System.Drawing.Size(349, 33);
            this.regular_worktime.TabIndex = 153;
            // 
            // total_rpay
            // 
            this.total_rpay.Enabled = false;
            this.total_rpay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.total_rpay.ForeColor = System.Drawing.Color.Black;
            this.total_rpay.FormattingEnabled = true;
            this.total_rpay.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.total_rpay.Location = new System.Drawing.Point(597, 616);
            this.total_rpay.Name = "total_rpay";
            this.total_rpay.Size = new System.Drawing.Size(349, 33);
            this.total_rpay.TabIndex = 153;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(969, 132);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 162;
            this.pictureBox2.TabStop = false;
            // 
            // EMPLOYEESupdate_revised
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.total_rpay);
            this.Controls.Add(this.regular_worktime);
            this.Controls.Add(this.regular_pay);
            this.Controls.Add(this.position);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.birth_date);
            this.Controls.Add(this.cnumber_emergency);
            this.Controls.Add(this.email);
            this.Controls.Add(this.contact_number);
            this.Controls.Add(this.middle_name);
            this.Controls.Add(this.address);
            this.Controls.Add(this.first_name);
            this.Controls.Add(this.last_name);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.employee_id);
            this.Controls.Add(this.hired_date);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btn_one1);
            this.Controls.Add(this.btn_one14);
            this.Name = "EMPLOYEESupdate_revised";
            this.Size = new System.Drawing.Size(1555, 1033);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private btn_one btn_clear;
        private btn_one btn_save;
        private PictureBox pictureBox3;
        private ComboBox sex;
        private ComboBox position;
        private Label label2;
        private Label label3;
        private Label label9;
        private Label label21;
        private Label label15;
        private Label label14;
        private Label label1;
        private Label label5;
        private Label label17;
        private Label label12;
        private Label label10;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label13;
        private Label label4;
        private Label label18;
        private TextBox birth_date;
        private TextBox cnumber_emergency;
        private TextBox email;
        private TextBox contact_number;
        private TextBox middle_name;
        private TextBox address;
        private TextBox first_name;
        private TextBox last_name;
        private Label label16;
        private TextBox employee_id;
        private DateTimePicker hired_date;
        private Label label20;
        private btn_one btn_one1;
        private btn_one btn_one14;
        private Label label11;
        private Label label22;
        private ComboBox regular_pay;
        private ComboBox regular_worktime;
        private ComboBox total_rpay;
        private PictureBox pictureBox2;
    }
}
