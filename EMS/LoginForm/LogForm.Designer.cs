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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogForm));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LogTogglePass = new LoginForm.ToggleBtn();
            this.LogTxtPass = new LoginForm.TextBox();
            this.Pswrd = new System.Windows.Forms.Label();
            this.LogTxtUser = new LoginForm.TextBox();
            this.Usrnme = new System.Windows.Forms.Label();
            this.LogLblTitle = new System.Windows.Forms.Label();
            this.LblShwPass = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_one1 = new EMS.btn_one();
            this.btn_one2 = new EMS.btn_one();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.pictureBox2.Image = global::EMS.Properties.Resources.download_icon_lock_password_protect_safety_security_icon_1320086045132546966_512;
            this.pictureBox2.Location = new System.Drawing.Point(329, 317);
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
            this.pictureBox1.Location = new System.Drawing.Point(329, 220);
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
            this.LogTogglePass.Location = new System.Drawing.Point(104, 366);
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
            // LogTxtPass
            // 
            this.LogTxtPass.BackColor = System.Drawing.Color.White;
            this.LogTxtPass.BorderColor = System.Drawing.Color.Empty;
            this.LogTxtPass.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.LogTxtPass.BorderRadius = 10;
            this.LogTxtPass.BorderSize = 2;
            this.LogTxtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LogTxtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogTxtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LogTxtPass.Location = new System.Drawing.Point(97, 308);
            this.LogTxtPass.Margin = new System.Windows.Forms.Padding(4);
            this.LogTxtPass.Multiline = false;
            this.LogTxtPass.Name = "LogTxtPass";
            this.LogTxtPass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.LogTxtPass.PasswordChar = true;
            this.LogTxtPass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.LogTxtPass.PlaceholderText = "";
            this.LogTxtPass.Size = new System.Drawing.Size(261, 35);
            this.LogTxtPass.TabIndex = 16;
            this.LogTxtPass.Texts = "";
            this.LogTxtPass.UnderlinedStyle = false;
            // 
            // Pswrd
            // 
            this.Pswrd.AutoSize = true;
            this.Pswrd.Font = new System.Drawing.Font("SF Pro Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Pswrd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Pswrd.Location = new System.Drawing.Point(104, 278);
            this.Pswrd.Name = "Pswrd";
            this.Pswrd.Size = new System.Drawing.Size(78, 18);
            this.Pswrd.TabIndex = 13;
            this.Pswrd.Text = "Password";
            // 
            // LogTxtUser
            // 
            this.LogTxtUser.BackColor = System.Drawing.Color.White;
            this.LogTxtUser.BorderColor = System.Drawing.Color.Empty;
            this.LogTxtUser.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.LogTxtUser.BorderRadius = 10;
            this.LogTxtUser.BorderSize = 2;
            this.LogTxtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LogTxtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogTxtUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LogTxtUser.Location = new System.Drawing.Point(97, 214);
            this.LogTxtUser.Margin = new System.Windows.Forms.Padding(4);
            this.LogTxtUser.Multiline = true;
            this.LogTxtUser.Name = "LogTxtUser";
            this.LogTxtUser.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.LogTxtUser.PasswordChar = false;
            this.LogTxtUser.PlaceholderColor = System.Drawing.Color.DarkOrange;
            this.LogTxtUser.PlaceholderText = "";
            this.LogTxtUser.Size = new System.Drawing.Size(261, 32);
            this.LogTxtUser.TabIndex = 15;
            this.LogTxtUser.Texts = "";
            this.LogTxtUser.UnderlinedStyle = false;
            // 
            // Usrnme
            // 
            this.Usrnme.AutoSize = true;
            this.Usrnme.Font = new System.Drawing.Font("SF Pro Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Usrnme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Usrnme.Location = new System.Drawing.Point(104, 183);
            this.Usrnme.Name = "Usrnme";
            this.Usrnme.Size = new System.Drawing.Size(46, 18);
            this.Usrnme.TabIndex = 14;
            this.Usrnme.Text = "Email";
            // 
            // LogLblTitle
            // 
            this.LogLblTitle.AutoSize = true;
            this.LogLblTitle.Font = new System.Drawing.Font("SF Pro Text", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogLblTitle.ForeColor = System.Drawing.Color.White;
            this.LogLblTitle.Location = new System.Drawing.Point(88, 80);
            this.LogLblTitle.Name = "LogLblTitle";
            this.LogLblTitle.Size = new System.Drawing.Size(247, 53);
            this.LogLblTitle.TabIndex = 12;
            this.LogLblTitle.Text = "Let\'s start";
            // 
            // LblShwPass
            // 
            this.LblShwPass.AutoSize = true;
            this.LblShwPass.Font = new System.Drawing.Font("SF Pro Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblShwPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LblShwPass.Location = new System.Drawing.Point(256, 368);
            this.LblShwPass.Name = "LblShwPass";
            this.LblShwPass.Size = new System.Drawing.Size(105, 16);
            this.LblShwPass.TabIndex = 27;
            this.LblShwPass.Text = "Show Password";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(457, 80);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(369, 458);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // btn_one1
            // 
            this.btn_one1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.btn_one1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_one1.FlatAppearance.BorderSize = 0;
            this.btn_one1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_one1.Font = new System.Drawing.Font("SF Pro Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_one1.ForeColor = System.Drawing.Color.White;
            this.btn_one1.Location = new System.Drawing.Point(97, 448);
            this.btn_one1.Name = "btn_one1";
            this.btn_one1.Size = new System.Drawing.Size(261, 43);
            this.btn_one1.TabIndex = 29;
            this.btn_one1.Text = "Log in";
            this.btn_one1.UseVisualStyleBackColor = false;
            this.btn_one1.Click += new System.EventHandler(this.btn_one1_Click);
            // 
            // btn_one2
            // 
            this.btn_one2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(99)))));
            this.btn_one2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_one2.FlatAppearance.BorderSize = 0;
            this.btn_one2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_one2.Font = new System.Drawing.Font("SF Pro Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_one2.ForeColor = System.Drawing.Color.White;
            this.btn_one2.Location = new System.Drawing.Point(97, 507);
            this.btn_one2.Name = "btn_one2";
            this.btn_one2.Size = new System.Drawing.Size(261, 43);
            this.btn_one2.TabIndex = 29;
            this.btn_one2.Text = "Clear";
            this.btn_one2.UseVisualStyleBackColor = false;
            this.btn_one2.Click += new System.EventHandler(this.btn_one2_Click);
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(902, 631);
            this.Controls.Add(this.btn_one2);
            this.Controls.Add(this.btn_one1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblShwPass);
            this.Controls.Add(this.LogTogglePass);
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
            this.Name = "LogForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private ToggleBtn LogTogglePass;
        private TextBox LogTxtPass;
        private Label Pswrd;
        private TextBox LogTxtUser;
        private Label Usrnme;
        private Label LogLblTitle;
        private Label LblShwPass;
        private PictureBox pictureBox3;
        private EMS.btn_one btn_one1;
        private EMS.btn_one btn_one2;
    }
}