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
    public partial class ATTENDANCEdutydurationAdd : Form
    {
        public ATTENDANCEdutydurationAdd()
        {
            InitializeComponent();
        }

        private void DutyCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddSave_Click(object sender, EventArgs e)
        {
            if(CMessageBox.Show("Are you sure to save the informations to duty duration?", "Save Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CMessageBox.Show("Information saved to the duty duration.");
                AddEmpDuration.Text = "";
                AddEmployeeId.Text = "";
                AddEmpOvertime.Text = "";
                AddEmpStatus.Texts = "The Employee is:";

                                            //Code to save in database
            }
        }

        private void AddClear_Click(object sender, EventArgs e)
        {
            AddEmpDuration.Text = "";
            AddEmployeeId.Text = "";                            
            AddEmpOvertime.Text = "";
            AddEmpStatus.Texts = "The Employee is:";
        }
    }
}
