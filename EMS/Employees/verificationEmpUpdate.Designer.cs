namespace EMS
{
    partial class verificationEmpUpdate
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
            this.btn_one2 = new EMS.btn_one();
            this.btn_one1 = new EMS.btn_one();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_one2
            // 
            this.btn_one2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(0)))));
            this.btn_one2.FlatAppearance.BorderSize = 0;
            this.btn_one2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_one2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_one2.ForeColor = System.Drawing.Color.White;
            this.btn_one2.Location = new System.Drawing.Point(316, 215);
            this.btn_one2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_one2.Name = "btn_one2";
            this.btn_one2.Size = new System.Drawing.Size(118, 38);
            this.btn_one2.TabIndex = 82;
            this.btn_one2.Text = "Confirm";
            this.btn_one2.UseVisualStyleBackColor = false;
            this.btn_one2.Click += new System.EventHandler(this.btn_one2_Click_1);
            // 
            // btn_one1
            // 
            this.btn_one1.BackColor = System.Drawing.Color.DarkGray;
            this.btn_one1.FlatAppearance.BorderSize = 0;
            this.btn_one1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_one1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_one1.ForeColor = System.Drawing.Color.White;
            this.btn_one1.Location = new System.Drawing.Point(121, 215);
            this.btn_one1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_one1.Name = "btn_one1";
            this.btn_one1.Size = new System.Drawing.Size(118, 38);
            this.btn_one1.TabIndex = 83;
            this.btn_one1.Text = "Cancel";
            this.btn_one1.UseVisualStyleBackColor = false;
            this.btn_one1.Click += new System.EventHandler(this.btn_one1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(169, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 31);
            this.label1.TabIndex = 84;
            this.label1.Text = "Confirm update";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(105, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 18);
            this.label2.TabIndex = 85;
            this.label2.Text = "Are you sure you want to modify the employee?";
            this.label2.Click += new System.EventHandler(this.label3_Click);
            // 
            // verificationEmpUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(577, 320);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_one2);
            this.Controls.Add(this.btn_one1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "verificationEmpUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "verificationEmpUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private btn_one btn_one2;
        private btn_one btn_one1;
        private Label label1;
        private Label label2;
    }
}