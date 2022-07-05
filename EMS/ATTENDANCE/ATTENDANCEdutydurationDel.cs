using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS
{
    public partial class ATTENDANCEdutydurationDel : UserControl
    {
        public ATTENDANCEdutydurationDel()
        {
            InitializeComponent();
        }

        private void ATTENDANCEdepartment_Load(object sender, EventArgs e)
        {
            visualsDatagridview();
            
            for(int i=1995; i<= 2022; i++)
            {
                CmbxYear.Items.Add(i);
            }
        }
        void visualsDatagridview()
        {
            // UNNECESSARY, 'WAG IDELETE

            //tableDelete_DGV.AlternatingRowsDefaultCellStyle.BackColor = Color.Blue; //Color.FromArgb(238, 239, 249);
            //tableDelete_DGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tableDelete_DGV.DefaultCellStyle.SelectionBackColor = Color.FromArgb(202, 63, 63);
            //tableDelete_DGV.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            tableDelete_DGV.BackgroundColor = Color.White;
            //tableDelete_DGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            tableDelete_DGV.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(62, 113, 201);
            tableDelete_DGV.RowHeadersDefaultCellStyle.SelectionForeColor = Color.White;

            tableDelete_DGV.EnableHeadersVisualStyles = false;
            tableDelete_DGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //tableDelete_DGV.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);      
            tableDelete_DGV.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(63, 113, 202);
            tableDelete_DGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void ATTENDANCEdutyduration_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void DelDuration_Click(object sender, EventArgs e)
        {
            if (CMessageBox.Show("Are you sure to delete the selected data in duty duration?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Code to delete

                CMessageBox.Show("Selected Duty duration data deleted.");
            }
        }

        private void tableDelete_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CmbxMonth_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_one3_Click_1(object sender, EventArgs e)
        {
            verificationAttenDelete verificationAttenDelete = new verificationAttenDelete();
            verificationAttenDelete.Show();
        }
    }
}
