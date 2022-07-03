namespace EMS
{
    partial class successEMPadd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(successEMPadd));
            this.btn_one1 = new EMS.btn_one();
            this.btn_one2 = new EMS.btn_one();
            this.employeesTitlePage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_one1
            // 
            this.btn_one1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(202)))), ((int)(((byte)(63)))));
            this.btn_one1.FlatAppearance.BorderSize = 0;
            this.btn_one1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_one1.Font = new System.Drawing.Font("SF Pro Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_one1.ForeColor = System.Drawing.Color.White;
            this.btn_one1.Location = new System.Drawing.Point(139, 426);
            this.btn_one1.Name = "btn_one1";
            this.btn_one1.Size = new System.Drawing.Size(161, 50);
            this.btn_one1.TabIndex = 0;
            this.btn_one1.Text = "View table";
            this.btn_one1.UseVisualStyleBackColor = false;
            this.btn_one1.Click += new System.EventHandler(this.btn_one1_Click);
            // 
            // btn_one2
            // 
            this.btn_one2.BackColor = System.Drawing.Color.White;
            this.btn_one2.FlatAppearance.BorderSize = 0;
            this.btn_one2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_one2.Font = new System.Drawing.Font("SF Pro Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_one2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(113)))), ((int)(((byte)(202)))));
            this.btn_one2.Location = new System.Drawing.Point(368, 426);
            this.btn_one2.Name = "btn_one2";
            this.btn_one2.Size = new System.Drawing.Size(161, 50);
            this.btn_one2.TabIndex = 0;
            this.btn_one2.Text = "Done";
            this.btn_one2.UseVisualStyleBackColor = false;
            this.btn_one2.Click += new System.EventHandler(this.btn_one2_Click);
            // 
            // employeesTitlePage
            // 
            this.employeesTitlePage.AutoSize = true;
            this.employeesTitlePage.BackColor = System.Drawing.Color.Transparent;
            this.employeesTitlePage.Font = new System.Drawing.Font("SF Pro Display", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.employeesTitlePage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(37)))), ((int)(((byte)(83)))));
            this.employeesTitlePage.Location = new System.Drawing.Point(259, 246);
            this.employeesTitlePage.Name = "employeesTitlePage";
            this.employeesTitlePage.Size = new System.Drawing.Size(145, 39);
            this.employeesTitlePage.TabIndex = 34;
            this.employeesTitlePage.Text = "Success";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(270, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("SF Pro Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(200, 304);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(272, 21);
            this.label6.TabIndex = 75;
            this.label6.Text = "Employee has been registered.";
            // 
            // successEMPadd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(681, 578);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.employeesTitlePage);
            this.Controls.Add(this.btn_one2);
            this.Controls.Add(this.btn_one1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "successEMPadd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.successEMPadd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private btn_one btn_one1;
        private btn_one btn_one2;
        private Label employeesTitlePage;
        private PictureBox pictureBox1;
        private Label label6;
    }
}