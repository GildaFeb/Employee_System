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
    public partial class ATTENDANCEdutydurationUpdREVISED : UserControl
    {
        public ATTENDANCEdutydurationUpdREVISED()
        {
            InitializeComponent();
        }

        private void UpdLblOvertime_Click(object sender, EventArgs e)
        {

        }

        private void UpdEmpOvertime_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdSave_Click(object sender, EventArgs e)
        {
            VerificationDutyUpdate verificationAttenUpdate = new VerificationDutyUpdate();
            verificationAttenUpdate.ShowDialog();
        }

        private void UpdTimePickerIn_ValueChanged(object sender, EventArgs e)
        {
            // not finished
            DateTime inTime = Convert.ToDateTime(time_in.Text);
            DateTime outTime = Convert.ToDateTime(time_out.Text);
            if (outTime >= inTime)
            {
                duration.Text = outTime.Subtract(inTime).Days.ToString();
            }
            else
            {
                MessageBox.Show(" Error. Time in must earlier than time out. Try again");
            }
        }

        private void UpdLlblTimeIn_Click(object sender, EventArgs e)
        {

        }

        private void UpdLblId_Click(object sender, EventArgs e)
        {

        }

        private void time_out_ValueChanged(object sender, EventArgs e)
        {
            // not finished
            DateTime inTime = Convert.ToDateTime(time_in.Text);
            DateTime outTime = Convert.ToDateTime(time_out.Text);
            if (outTime > inTime)
            {
                duration.Text = outTime.Subtract(inTime).Days.ToString();
            }
            else
            {
                MessageBox.Show(" Error. Time out (value) must set time after time in. Try again");
            }
        }

        private void UpdLblDuration_Click(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            // [!] Alvin = clear all forms
        }

        private void status_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            status.Items.Add("Present");
            status.Items.Add("Absent");
            status.Items.Add("Leave");

            if (status.SelectedItem.ToString() == "Present")
            {
                //  [!] Alvin = enabled true the status, date, time in, time out
            }
            else if (status.SelectedItem.ToString() == "Absent")
            {
                // [!] Alvin = enabled false the time in, time out

            }
            else if (status.SelectedItem.ToString() == "Leave")
            {
                // [!] Alvin = enabled false the time in, time out, duration, overtime
            }
        }
    }
}
