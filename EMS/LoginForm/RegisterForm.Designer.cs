namespace LoginForm
{
    partial class frmRegister
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblTitle = new System.Windows.Forms.Label();
            this.RegLblUser = new System.Windows.Forms.Label();
            this.RegTxtUsername = new LoginForm.TextBox();
            this.RegLblPass = new System.Windows.Forms.Label();
            this.RegTxtPassword = new LoginForm.TextBox();
            this.RegLblCpass = new System.Windows.Forms.Label();
            this.RegTxtCpass = new LoginForm.TextBox();
            this.LblShowPass = new System.Windows.Forms.Label();
            this.RegTogglePass = new LoginForm.ToggleBtn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.RegBtn = new LoginForm.Button();
            this.RegClrBtn = new LoginForm.Button();
            this.RegAccLbl = new System.Windows.Forms.Label();
            this.LblBack = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Headerbar = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.LblTitle.Location = new System.Drawing.Point(483, 81);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(167, 34);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Let\'s Start";
            // 
            // RegLblUser
            // 
            this.RegLblUser.AutoSize = true;
            this.RegLblUser.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RegLblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RegLblUser.Location = new System.Drawing.Point(493, 142);
            this.RegLblUser.Name = "RegLblUser";
            this.RegLblUser.Size = new System.Drawing.Size(79, 16);
            this.RegLblUser.TabIndex = 1;
            this.RegLblUser.Text = "Username";
            // 
            // RegTxtUsername
            // 
            this.RegTxtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.RegTxtUsername.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.RegTxtUsername.BorderFocusColor = System.Drawing.Color.HotPink;
            this.RegTxtUsername.BorderRadius = 10;
            this.RegTxtUsername.BorderSize = 2;
            this.RegTxtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RegTxtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegTxtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RegTxtUsername.Location = new System.Drawing.Point(491, 161);
            this.RegTxtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.RegTxtUsername.Multiline = true;
            this.RegTxtUsername.Name = "RegTxtUsername";
            this.RegTxtUsername.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.RegTxtUsername.PasswordChar = false;
            this.RegTxtUsername.PlaceholderColor = System.Drawing.Color.DarkOrange;
            this.RegTxtUsername.PlaceholderText = "";
            this.RegTxtUsername.Size = new System.Drawing.Size(216, 32);
            this.RegTxtUsername.TabIndex = 2;
            this.RegTxtUsername.Texts = "";
            this.RegTxtUsername.UnderlinedStyle = false;
            // 
            // RegLblPass
            // 
            this.RegLblPass.AutoSize = true;
            this.RegLblPass.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RegLblPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RegLblPass.Location = new System.Drawing.Point(491, 214);
            this.RegLblPass.Name = "RegLblPass";
            this.RegLblPass.Size = new System.Drawing.Size(77, 16);
            this.RegLblPass.TabIndex = 1;
            this.RegLblPass.Text = "Password";
            // 
            // RegTxtPassword
            // 
            this.RegTxtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.RegTxtPassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.RegTxtPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.RegTxtPassword.BorderRadius = 10;
            this.RegTxtPassword.BorderSize = 2;
            this.RegTxtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RegTxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegTxtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RegTxtPassword.Location = new System.Drawing.Point(491, 233);
            this.RegTxtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.RegTxtPassword.Multiline = false;
            this.RegTxtPassword.Name = "RegTxtPassword";
            this.RegTxtPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.RegTxtPassword.PasswordChar = true;
            this.RegTxtPassword.PlaceholderColor = System.Drawing.Color.Transparent;
            this.RegTxtPassword.PlaceholderText = "";
            this.RegTxtPassword.Size = new System.Drawing.Size(216, 32);
            this.RegTxtPassword.TabIndex = 3;
            this.RegTxtPassword.Texts = "";
            this.RegTxtPassword.UnderlinedStyle = false;
            // 
            // RegLblCpass
            // 
            this.RegLblCpass.AutoSize = true;
            this.RegLblCpass.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RegLblCpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RegLblCpass.Location = new System.Drawing.Point(491, 288);
            this.RegLblCpass.Name = "RegLblCpass";
            this.RegLblCpass.Size = new System.Drawing.Size(139, 16);
            this.RegLblCpass.TabIndex = 4;
            this.RegLblCpass.Text = "Confirm Password";
            // 
            // RegTxtCpass
            // 
            this.RegTxtCpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.RegTxtCpass.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.RegTxtCpass.BorderFocusColor = System.Drawing.Color.HotPink;
            this.RegTxtCpass.BorderRadius = 10;
            this.RegTxtCpass.BorderSize = 2;
            this.RegTxtCpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RegTxtCpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegTxtCpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RegTxtCpass.Location = new System.Drawing.Point(491, 307);
            this.RegTxtCpass.Margin = new System.Windows.Forms.Padding(4);
            this.RegTxtCpass.Multiline = false;
            this.RegTxtCpass.Name = "RegTxtCpass";
            this.RegTxtCpass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.RegTxtCpass.PasswordChar = true;
            this.RegTxtCpass.PlaceholderColor = System.Drawing.Color.Transparent;
            this.RegTxtCpass.PlaceholderText = "";
            this.RegTxtCpass.Size = new System.Drawing.Size(216, 32);
            this.RegTxtCpass.TabIndex = 5;
            this.RegTxtCpass.Texts = "";
            this.RegTxtCpass.UnderlinedStyle = false;
            // 
            // LblShowPass
            // 
            this.LblShowPass.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblShowPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblShowPass.Location = new System.Drawing.Point(587, 346);
            this.LblShowPass.Name = "LblShowPass";
            this.LblShowPass.Size = new System.Drawing.Size(134, 19);
            this.LblShowPass.TabIndex = 7;
            this.LblShowPass.Text = "Show Password";
            // 
            // RegTogglePass
            // 
            this.RegTogglePass.AutoSize = true;
            this.RegTogglePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegTogglePass.Location = new System.Drawing.Point(546, 343);
            this.RegTogglePass.MinimumSize = new System.Drawing.Size(45, 22);
            this.RegTogglePass.Name = "RegTogglePass";
            this.RegTogglePass.OffBackColor = System.Drawing.Color.Gray;
            this.RegTogglePass.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.RegTogglePass.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.RegTogglePass.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.RegTogglePass.Size = new System.Drawing.Size(45, 22);
            this.RegTogglePass.TabIndex = 8;
            this.RegTogglePass.UseVisualStyleBackColor = true;
            this.RegTogglePass.CheckedChanged += new System.EventHandler(this.btnShwpswrd_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.pictureBox1.Image = global::EMS.Properties.Resources.account_icon_8;
            this.pictureBox1.Location = new System.Drawing.Point(679, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.pictureBox2.Image = global::EMS.Properties.Resources.download_icon_lock_password_protect_safety_security_icon_1320086045132546966_512;
            this.pictureBox2.Location = new System.Drawing.Point(679, 240);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // RegBtn
            // 
            this.RegBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.RegBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.RegBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.RegBtn.BorderRadius = 0;
            this.RegBtn.BorderSize = 0;
            this.RegBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegBtn.FlatAppearance.BorderSize = 0;
            this.RegBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RegBtn.ForeColor = System.Drawing.Color.White;
            this.RegBtn.Location = new System.Drawing.Point(491, 390);
            this.RegBtn.Name = "RegBtn";
            this.RegBtn.Size = new System.Drawing.Size(216, 35);
            this.RegBtn.TabIndex = 11;
            this.RegBtn.Text = "REGISTER";
            this.RegBtn.TextColor = System.Drawing.Color.White;
            this.RegBtn.UseVisualStyleBackColor = false;
            this.RegBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegClrBtn
            // 
            this.RegClrBtn.BackColor = System.Drawing.Color.White;
            this.RegClrBtn.BackgroundColor = System.Drawing.Color.White;
            this.RegClrBtn.BorderColor = System.Drawing.Color.Transparent;
            this.RegClrBtn.BorderRadius = 0;
            this.RegClrBtn.BorderSize = 1;
            this.RegClrBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegClrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegClrBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RegClrBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.RegClrBtn.Location = new System.Drawing.Point(491, 431);
            this.RegClrBtn.Name = "RegClrBtn";
            this.RegClrBtn.Size = new System.Drawing.Size(216, 35);
            this.RegClrBtn.TabIndex = 11;
            this.RegClrBtn.Text = "CLEAR";
            this.RegClrBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.RegClrBtn.UseVisualStyleBackColor = false;
            this.RegClrBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // RegAccLbl
            // 
            this.RegAccLbl.AutoSize = true;
            this.RegAccLbl.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RegAccLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RegAccLbl.Location = new System.Drawing.Point(501, 483);
            this.RegAccLbl.Name = "RegAccLbl";
            this.RegAccLbl.Size = new System.Drawing.Size(198, 16);
            this.RegAccLbl.TabIndex = 4;
            this.RegAccLbl.Text = "Already Have an Account";
            // 
            // LblBack
            // 
            this.LblBack.AutoSize = true;
            this.LblBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblBack.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.LblBack.Location = new System.Drawing.Point(545, 508);
            this.LblBack.Name = "LblBack";
            this.LblBack.Size = new System.Drawing.Size(115, 16);
            this.LblBack.TabIndex = 4;
            this.LblBack.Text = "Back to LOGIN";
            this.LblBack.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::EMS.Properties.Resources.ezgif_com_gif_maker;
            this.pictureBox3.Location = new System.Drawing.Point(0, 39);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(469, 506);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // Headerbar
            // 
            this.Headerbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(187)))), ((int)(((byte)(198)))));
            this.Headerbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Headerbar.Location = new System.Drawing.Point(0, 0);
            this.Headerbar.Name = "Headerbar";
            this.Headerbar.Size = new System.Drawing.Size(723, 78);
            this.Headerbar.TabIndex = 13;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.pictureBox4.Image = global::EMS.Properties.Resources.download_icon_lock_password_protect_safety_security_icon_1320086045132546966_512;
            this.pictureBox4.Location = new System.Drawing.Point(679, 314);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(225)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(723, 544);
            this.ControlBox = false;
            this.Controls.Add(this.Headerbar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.RegClrBtn);
            this.Controls.Add(this.RegBtn);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RegTogglePass);
            this.Controls.Add(this.LblShowPass);
            this.Controls.Add(this.RegTxtCpass);
            this.Controls.Add(this.LblBack);
            this.Controls.Add(this.RegAccLbl);
            this.Controls.Add(this.RegLblCpass);
            this.Controls.Add(this.RegTxtPassword);
            this.Controls.Add(this.RegLblPass);
            this.Controls.Add(this.RegTxtUsername);
            this.Controls.Add(this.RegLblUser);
            this.Controls.Add(this.LblTitle);
            this.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmRegister";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRegister_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblTitle;
        private Label RegLblUser;
        private TextBox RegTxtUsername;
        private Label RegLblPass;
        private TextBox RegTxtPassword;
        private Label RegLblCpass;
        private TextBox RegTxtCpass;
        private Label LblShowPass;
        private LoginForm.ToggleBtn RegTogglePass;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button RegBtn;
        private Button RegClrBtn;
        private Label RegAccLbl;
        private Label LblBack;
        private PictureBox pictureBox3;
        private Panel Headerbar;
        private PictureBox pictureBox4;
    }
}