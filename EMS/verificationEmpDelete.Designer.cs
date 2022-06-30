namespace EMS
{
    partial class verificationEmpDelete
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_one2 = new EMS.btn_one();
            this.btn_one1 = new EMS.btn_one();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(270, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // btn_one2
            // 
            this.btn_one2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btn_one2.FlatAppearance.BorderSize = 0;
            this.btn_one2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_one2.Font = new System.Drawing.Font("SF Pro Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_one2.ForeColor = System.Drawing.Color.White;
            this.btn_one2.Location = new System.Drawing.Point(368, 426);
            this.btn_one2.Name = "btn_one2";
            this.btn_one2.Size = new System.Drawing.Size(161, 50);
            this.btn_one2.TabIndex = 77;
            this.btn_one2.Text = "Confirm";
            this.btn_one2.UseVisualStyleBackColor = false;
            // 
            // btn_one1
            // 
            this.btn_one1.BackColor = System.Drawing.Color.DarkGray;
            this.btn_one1.FlatAppearance.BorderSize = 0;
            this.btn_one1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_one1.Font = new System.Drawing.Font("SF Pro Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_one1.ForeColor = System.Drawing.Color.White;
            this.btn_one1.Location = new System.Drawing.Point(139, 426);
            this.btn_one1.Name = "btn_one1";
            this.btn_one1.Size = new System.Drawing.Size(161, 50);
            this.btn_one1.TabIndex = 78;
            this.btn_one1.Text = "Cancel";
            this.btn_one1.UseVisualStyleBackColor = false;
            this.btn_one1.Click += new System.EventHandler(this.btn_one1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("SF Pro Display", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.label3.Location = new System.Drawing.Point(200, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 39);
            this.label3.TabIndex = 79;
            this.label3.Text = "Confirm deletion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("SF Pro Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(74, 304);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(542, 21);
            this.label2.TabIndex = 80;
            this.label2.Text = "Are you sure you want to delete the employee/s you selected?";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // verificationEmpDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(681, 578);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_one2);
            this.Controls.Add(this.btn_one1);
            this.Location = new System.Drawing.Point(270, 95);
            this.Name = "verificationEmpDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private btn_one btn_one2;
        private btn_one btn_one1;
        private Label label3;
        private Label label2;
    }
}