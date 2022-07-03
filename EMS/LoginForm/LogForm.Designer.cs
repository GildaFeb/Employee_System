namespace LoginForm
{
    partial class LogForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LogClrBtn = new LoginForm.Button();
            this.LogBtn = new LoginForm.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LogTogglePass = new LoginForm.ToggleBtn();
            this.LblLogCreate = new System.Windows.Forms.Label();
            this.LblLogAcc = new System.Windows.Forms.Label();
            this.LogTxtPass = new LoginForm.TextBox();
            this.Pswrd = new System.Windows.Forms.Label();
            this.LogTxtUser = new LoginForm.TextBox();
            this.Usrnme = new System.Windows.Forms.Label();
            this.LogLblTitle = new System.Windows.Forms.Label();
            this.LblShwPass = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // LogClrBtn
            // 
            this.LogClrBtn.BackColor = System.Drawing.Color.White;
            this.LogClrBtn.BackgroundColor = System.Drawing.Color.White;
            this.LogClrBtn.BorderColor = System.Drawing.Color.Transparent;
            this.LogClrBtn.BorderRadius = 0;
            this.LogClrBtn.BorderSize = 1;
            this.LogClrBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogClrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogClrBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.LogClrBtn.Location = new System.Drawing.Point(470, 324);
            this.LogClrBtn.Name = "LogClrBtn";
            this.LogClrBtn.Size = new System.Drawing.Size(216, 35);
            this.LogClrBtn.TabIndex = 25;
            this.LogClrBtn.Text = "CLEAR";
            this.LogClrBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.LogClrBtn.UseVisualStyleBackColor = false;
            this.LogClrBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // LogBtn
            // 
            this.LogBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.LogBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.LogBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.LogBtn.BorderRadius = 0;
            this.LogBtn.BorderSize = 0;
            this.LogBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogBtn.FlatAppearance.BorderSize = 0;
            this.LogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogBtn.ForeColor = System.Drawing.Color.White;
            this.LogBtn.Location = new System.Drawing.Point(470, 283);
            this.LogBtn.Name = "LogBtn";
            this.LogBtn.Size = new System.Drawing.Size(216, 35);
            this.LogBtn.TabIndex = 26;
            this.LogBtn.Text = "LOG IN";
            this.LogBtn.TextColor = System.Drawing.Color.White;
            this.LogBtn.UseVisualStyleBackColor = false;
            this.LogBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.pictureBox2.Image = global::EMS.Properties.Resources.download_icon_lock_password_protect_safety_security_icon_1320086045132546966_512;
            this.pictureBox2.Location = new System.Drawing.Point(658, 208);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.pictureBox1.Image = global::EMS.Properties.Resources.account_icon_8;
            this.pictureBox1.Location = new System.Drawing.Point(658, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // LogTogglePass
            // 
            this.LogTogglePass.AutoSize = true;
            this.LogTogglePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogTogglePass.Location = new System.Drawing.Point(530, 235);
            this.LogTogglePass.MinimumSize = new System.Drawing.Size(45, 22);
            this.LogTogglePass.Name = "LogTogglePass";
            this.LogTogglePass.OffBackColor = System.Drawing.Color.Gray;
            this.LogTogglePass.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.LogTogglePass.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.LogTogglePass.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.LogTogglePass.Size = new System.Drawing.Size(45, 22);
            this.LogTogglePass.TabIndex = 22;
            this.LogTogglePass.UseVisualStyleBackColor = true;
            this.LogTogglePass.CheckedChanged += new System.EventHandler(this.shwpswrd_CheckedChanged);
            // 
            // LblLogCreate
            // 
            this.LblLogCreate.AutoSize = true;
            this.LblLogCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblLogCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.LblLogCreate.Location = new System.Drawing.Point(518, 402);
            this.LblLogCreate.Name = "LblLogCreate";
            this.LblLogCreate.Size = new System.Drawing.Size(125, 16);
            this.LblLogCreate.TabIndex = 17;
            this.LblLogCreate.Text = "Create Account";
            this.LblLogCreate.Click += new System.EventHandler(this.label5_Click);
            // 
            // LblLogAcc
            // 
            this.LblLogAcc.AutoSize = true;
            this.LblLogAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblLogAcc.Location = new System.Drawing.Point(490, 386);
            this.LblLogAcc.Name = "LblLogAcc";
            this.LblLogAcc.Size = new System.Drawing.Size(181, 16);
            this.LblLogAcc.TabIndex = 18;
            this.LblLogAcc.Text = "Don\'t Have an Account";
            // 
            // LogTxtPass
            // 
            this.LogTxtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.LogTxtPass.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.LogTxtPass.BorderFocusColor = System.Drawing.Color.HotPink;
            this.LogTxtPass.BorderRadius = 10;
            this.LogTxtPass.BorderSize = 2;
            this.LogTxtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LogTxtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogTxtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LogTxtPass.Location = new System.Drawing.Point(470, 201);
            this.LogTxtPass.Margin = new System.Windows.Forms.Padding(4);
            this.LogTxtPass.Multiline = false;
            this.LogTxtPass.Name = "LogTxtPass";
            this.LogTxtPass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.LogTxtPass.PasswordChar = true;
            this.LogTxtPass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.LogTxtPass.PlaceholderText = "";
            this.LogTxtPass.Size = new System.Drawing.Size(216, 32);
            this.LogTxtPass.TabIndex = 16;
            this.LogTxtPass.Texts = "";
            this.LogTxtPass.UnderlinedStyle = false;
            // 
            // Pswrd
            // 
            this.Pswrd.AutoSize = true;
            this.Pswrd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Pswrd.Location = new System.Drawing.Point(470, 182);
            this.Pswrd.Name = "Pswrd";
            this.Pswrd.Size = new System.Drawing.Size(77, 16);
            this.Pswrd.TabIndex = 13;
            this.Pswrd.Text = "Password";
            // 
            // LogTxtUser
            // 
            this.LogTxtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.LogTxtUser.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.LogTxtUser.BorderFocusColor = System.Drawing.Color.HotPink;
            this.LogTxtUser.BorderRadius = 10;
            this.LogTxtUser.BorderSize = 2;
            this.LogTxtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LogTxtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogTxtUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LogTxtUser.Location = new System.Drawing.Point(470, 129);
            this.LogTxtUser.Margin = new System.Windows.Forms.Padding(4);
            this.LogTxtUser.Multiline = true;
            this.LogTxtUser.Name = "LogTxtUser";
            this.LogTxtUser.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.LogTxtUser.PasswordChar = false;
            this.LogTxtUser.PlaceholderColor = System.Drawing.Color.DarkOrange;
            this.LogTxtUser.PlaceholderText = "";
            this.LogTxtUser.Size = new System.Drawing.Size(216, 32);
            this.LogTxtUser.TabIndex = 15;
            this.LogTxtUser.Texts = "";
            this.LogTxtUser.UnderlinedStyle = false;
            // 
            // Usrnme
            // 
            this.Usrnme.AutoSize = true;
            this.Usrnme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Usrnme.Location = new System.Drawing.Point(472, 110);
            this.Usrnme.Name = "Usrnme";
            this.Usrnme.Size = new System.Drawing.Size(79, 16);
            this.Usrnme.TabIndex = 14;
            this.Usrnme.Text = "Username";
            // 
            // LogLblTitle
            // 
            this.LogLblTitle.AutoSize = true;
            this.LogLblTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogLblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.LogLblTitle.Location = new System.Drawing.Point(462, 49);
            this.LogLblTitle.Name = "LogLblTitle";
            this.LogLblTitle.Size = new System.Drawing.Size(167, 34);
            this.LogLblTitle.TabIndex = 12;
            this.LogLblTitle.Text = "Let\'s Start";
            // 
            // LblShwPass
            // 
            this.LblShwPass.AutoSize = true;
            this.LblShwPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblShwPass.Location = new System.Drawing.Point(572, 238);
            this.LblShwPass.Name = "LblShwPass";
            this.LblShwPass.Size = new System.Drawing.Size(123, 16);
            this.LblShwPass.TabIndex = 27;
            this.LblShwPass.Text = "Show Password";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.Image = global::EMS.Properties.Resources.Employee;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(439, 450);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(219)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(709, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.LblShwPass);
            this.Controls.Add(this.LogClrBtn);
            this.Controls.Add(this.LogBtn);
            this.Controls.Add(this.LogTogglePass);
            this.Controls.Add(this.LblLogCreate);
            this.Controls.Add(this.LblLogAcc);
            this.Controls.Add(this.LogTxtPass);
            this.Controls.Add(this.Pswrd);
            this.Controls.Add(this.LogTxtUser);
            this.Controls.Add(this.Usrnme);
            this.Controls.Add(this.LogLblTitle);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button LogClrBtn;
        private Button LogBtn;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private ToggleBtn LogTogglePass;
        private Label LblLogCreate;
        private Label LblLogAcc;
        private TextBox LogTxtPass;
        private Label Pswrd;
        private TextBox LogTxtUser;
        private Label Usrnme;
        private Label LogLblTitle;
        private Label LblShwPass;
        private PictureBox pictureBox3;
    }
}