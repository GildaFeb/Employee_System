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
            date_duty.CustomFormat = "dddd MMMM dd, yyyy";
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
            time_in.Text = employee_id.Text;
        }

        private void inTime_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void time_in_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void now_timein_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            //DateTime dateTime = DateTime.ParseExact(now.Date.ToString(), "hh:mm", System.Globalization.CultureInfo.InvariantCulture);
            time_in.Text = now.ToString("HH:mm");
        }

        private void now_timeout_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            time_out.Text = now.ToString("HH:mm");
        }

        private void clear_timein_Click(object sender, EventArgs e)
        {
            time_out.Text = null;
        }

        private void clear_timeout_Click(object sender, EventArgs e)
        {
            time_out.Text = null;
        }

        private void btn_findemployee_Click(object sender, EventArgs e)
        {
            if(employee_id.Text== null)
            {
                MessageBox.Show(" Please enter ID number (e.g., 90012983)");
            }
            else
            {
                bool validation = Employee_Details.Employee_Database.ShowDuty_ByIDandDate(employee_id.Text, date_duty.Text);

                if (validation == true)
                {
                    status.Enabled = true;
                    time_in.Enabled = true;
                    time_out.Enabled = true;
                    string firstName, middleName, lastName, suffix;

                    firstName = Employee_Details.Employee_Database.ShowEmployee(employee_id.Text).first_name.ToString();
                    middleName = Employee_Details.Employee_Database.ShowEmployee(employee_id.Text).first_name.ToString();
                    lastName = Employee_Details.Employee_Database.ShowEmployee(employee_id.Text).first_name.ToString();
                    suffix = Employee_Details.Employee_Database.ShowEmployee(employee_id.Text).first_name.ToString();

                    if(suffix == null)
                    {
                        employee_name.Text = firstName + middleName + lastName;
                    }
                    else
                    {
                        employee_name.Text = firstName + middleName + lastName + suffix;
                    }
                }
            }
        }
    }
}
