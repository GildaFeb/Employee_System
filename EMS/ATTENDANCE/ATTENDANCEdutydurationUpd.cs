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
    public partial class ATTENDANCEdutydurationUpd : Form
    {
        public ATTENDANCEdutydurationUpd()
        {
            InitializeComponent();
        }

        private void DutyCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void UpdClear_Click(object sender, EventArgs e)
        {
            UpdEmpDuration.Text = "";
            UpdEmployeeId.Text = "";
            UpdEmpOvertime.Text = "";
            UpdEmpStatus.Texts = "The Employee is:";
        }

        private void UpdSave_Click(object sender, EventArgs e)
        {
            if (CMessageBox.Show("Are you sure to save the updated informations?", "Save Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CMessageBox.Show("Informations are updated to the duty duration.");
                UpdEmpDuration.Text = "";
                UpdEmployeeId.Text = "";
                UpdEmpOvertime.Text = "";
                UpdEmpStatus.Texts = "The Employee is:";

                //Code to save in database
            }
        }
    }
}
