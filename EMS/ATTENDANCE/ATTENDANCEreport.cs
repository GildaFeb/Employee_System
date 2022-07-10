﻿using System;
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
    public partial class ATTENDANCEreport : UserControl
    {
        public ATTENDANCEreport()
        {
            InitializeComponent();
        }

        private void ATTENDANCEreport_Load(object sender, EventArgs e)
        {
            for (int i = 1995; i <= 2022; i++)
            {
                CmbxYear.Items.Add(i);
            }
        }

        private void DelReport_Click(object sender, EventArgs e)
        {
            if (CMessageBox.Show("Are you sure to delete the selected attendance report data?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Code to delete
                for (int i = attndncrprt_DGV.Rows.Count - 1; i >= 0; i--)
                {
                    if ((bool)attndncrprt_DGV.Rows[i].Cells[0].FormattedValue)
                    {
                        attndncrprt_DGV.Rows.RemoveAt(i);
                    }
                }

                CMessageBox.Show("Selected attendance report data deleted.");
            }
        }

        private void btn_one3_Click(object sender, EventArgs e)
        {
            VerificationRepDelete delete = new VerificationRepDelete();
            delete.ShowDialog();
        }

        private void btn_one2_Click(object sender, EventArgs e)
        {
            // [!] Alvin = function for clear checked
            foreach (DataGridViewRow Row in attndncrprt_DGV.Rows)
                ((DataGridViewCheckBoxCell)Row.Cells["delete_ChckBx"]).Value = null;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
