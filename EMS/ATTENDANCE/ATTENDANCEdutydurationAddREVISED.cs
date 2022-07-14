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
    public partial class ATTENDANCEdutydurationAddREVISED : UserControl
    {
        public ATTENDANCEdutydurationAddREVISED()
        {
            InitializeComponent();
        }

        private void AddSave_Click(object sender, EventArgs e)
        {
            SuccessDutyAdd add = new SuccessDutyAdd();
            add.ShowDialog();
        }

        private void AddLlblTimeIn_Click(object sender, EventArgs e)
        {

        }

        private void time_in_ValueChanged(object sender, EventArgs e)
        {
            /*// not finished
            TimeSpan inTime = TimeSpan.Parse(time_in.Text);
            TimeSpan outTime = TimeSpan.Parse(time_out.Text);
            if (outTime >= inTime)
            {
                duration.Text = outTime.Subtract(inTime).Days.ToString();
            }
            else
            {
                MessageBox.Show(" Error. Time in must earlier than time out. Try again");
            }
            */
        }

        private void time_out_ValueChanged(object sender, EventArgs e)
        {
            /*// not finished
            TimeSpan inTime = TimeSpan.Parse(time_in.Text);
            TimeSpan outTime = TimeSpan.Parse(time_out.Text);
            if (outTime >= inTime)
            {
                duration.Text = outTime.Subtract(inTime).Days.ToString();
            }
            else
            {
                MessageBox.Show(" Error. Time out (value) must set time after time in. Try again");
            }
            */
        }

        private void status_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            /*status.Items.Add("Present");
            status.Items.Add("Absent");
            status.Items.Add("Leave");*/

            //naga multiply if di naka comment - Alvin

            /*
            if (status.SelectedItem.ToString() == "Present")
            {
                //  [!] Alvin = enabled true the status, date, time in, time out
                time_in.Enabled = true;
                time_out.Enabled = true;
                duration.Enabled = true;
                overtime.Enabled = true;
                date_duty.Enabled = true;
            }
            else if (status.SelectedItem.ToString() == "Absent")
            {
                // [!] Alvin = enabled false the time in, time out
                time_in.Enabled = false;
                time_out.Enabled = false;
                date_duty.Enabled = true;

            }
            else if (status.SelectedItem.ToString() == "On Leave")
            {
                // [!] Alvin = enabled false the time in, time out, duration, overtime

                time_in.Enabled = false;
                time_out.Enabled = false;
                duration.Enabled = false;
                overtime.Enabled = false;
                date_duty.Enabled = true;
            }
            */
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            // [!] Alvin = clear all forms
            employee_id.Text = ""; //for some reason name sya (this is the ID)
            //status.SelectedItem = 
         
            

        }

        private void ATTENDANCEdutydurationAddREVISED_Load(object sender, EventArgs e)
        {

        }

        private void employee_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void inTime_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
