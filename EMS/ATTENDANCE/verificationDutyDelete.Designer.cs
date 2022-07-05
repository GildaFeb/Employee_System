namespace EMS
{
    partial class verificationDutyDelete
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
            this.label3 = new System.Windows.Forms.Label();
            this.btn_one2 = new EMS.btn_one();
            this.btn_one1 = new EMS.btn_one();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.label3.Location = new System.Drawing.Point(169, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 31);
            this.label3.TabIndex = 83;
            this.label3.Text = "Confirm deletion";
            // 
            // btn_one2
            // 
            this.btn_one2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btn_one2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_one2.FlatAppearance.BorderSize = 0;
            this.btn_one2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_one2.Font = new System.Drawing.Font("SF Pro Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_one2.ForeColor = System.Drawing.Color.White;
            this.btn_one2.Location = new System.Drawing.Point(316, 215);
            this.btn_one2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_one2.Name = "btn_one2";
            this.btn_one2.Size = new System.Drawing.Size(118, 38);
            this.btn_one2.TabIndex = 81;
            this.btn_one2.Text = "Confirm";
            this.btn_one2.UseVisualStyleBackColor = false;
            this.btn_one2.Click += new System.EventHandler(this.btn_one2_Click);
            // 
            // btn_one1
            // 
            this.btn_one1.BackColor = System.Drawing.Color.DarkGray;
            this.btn_one1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_one1.FlatAppearance.BorderSize = 0;
            this.btn_one1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_one1.Font = new System.Drawing.Font("SF Pro Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_one1.ForeColor = System.Drawing.Color.White;
            this.btn_one1.Location = new System.Drawing.Point(121, 215);
            this.btn_one1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_one1.Name = "btn_one1";
            this.btn_one1.Size = new System.Drawing.Size(118, 38);
            this.btn_one1.TabIndex = 82;
            this.btn_one1.Text = "Cancel";
            this.btn_one1.UseVisualStyleBackColor = false;
            this.btn_one1.Click += new System.EventHandler(this.btn_one1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("SF Pro Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(71, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(404, 36);
            this.label2.TabIndex = 84;
            this.label2.Text = "Are you sure you want to delete the duty duration of the\r\nemployee/s you selected" +
    "?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // verificationDutyDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(577, 320);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_one2);
            this.Controls.Add(this.btn_one1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "verificationDutyDelete";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label3;
        private btn_one btn_one2;
        private btn_one btn_one1;
        private Label label2;
    }
}