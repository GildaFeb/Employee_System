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
            

            
            if (status.SelectedItem.ToString() == "Present")
            {
                //  [!] Alvin = enabled true the status, date, time in, time out
                timein.Enabled = true;
                timeout.Enabled = true;
                now_timein.Enabled = true;
                now_timeout.Enabled = true;
            }
            else if (status.SelectedItem.ToString() == "Absent")
            {
                // [!] Alvin = enabled false the time in, time out
                timeout.Enabled = false;
                timein.Enabled = false;
                now_timein.Enabled = false;
                now_timeout.Enabled = false;
                date_duty.Enabled = true;
                pending.Enabled = false;
                

            }
            else if (status.SelectedItem.ToString() == "On Leave")
            {
                // [!] Alvin = enabled false the time in, time out, duration, overtime
                now_timein.Enabled = false;
                now_timeout.Enabled = false;
                timein.Enabled = false;
                timeout.Enabled = false;
                date_duty.Enabled = true;
                pending.Enabled = false;
            }
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            // [!] Alvin = clear all forms
            employee_id.Text = null;
            status.SelectedItem = "The Employee is:";
            duty_duration.Text = null;
            overtime.Text = null;
            timein.Value = DateTime.Today;
            timeout.Value = DateTime.Today;



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

        private void time_in_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           /* DateTime startTime = Convert.ToDateTime(time_in.Text);
            DateTime endtime = Convert.ToDateTime(time_out.Text);
            TimeSpan duration = startTime - endtime;
            duty_duration.Text = duration.ToString(); */

        }

        private void now_timein_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            //DateTime dateTime = DateTime.ParseExact(now.Date.ToString(), "hh:mm", System.Globalization.CultureInfo.InvariantCulture);
            timein.Text = now.ToString("HH:mm");
        }

        private void now_timeout_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            timeout.Text = now.ToString("HH:mm");
        }

        private void clear_timein_Click(object sender, EventArgs e)
        {
            timein.Text = null;
        }

        private void clear_timeout_Click(object sender, EventArgs e)
        {
            time_out.Text = null;
        }

        private void btn_findemployee_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(employee_id.Text) || string.IsNullOrWhiteSpace(date_duty.Text))
            {
                MessageBox.Show(" Please enter ID number (e.g., 90012983)"); // no design
            }
            else
            {
                bool checkDuty = Employee_Details.Employee_Database.ShowDuty_ByIDandDate(employee_id.Text, date_duty.Text);
                bool checkEmployee = Employee_Details.Employee_Database.CheckEmployee(employee_id.Text);


                 if (checkEmployee == false)
                {
                    MessageBox.Show(" This ID number is not resgistered. '"); // no design

                }else if (checkDuty == false)
                {
                    MessageBox.Show("This employee with ID number '" + employee_id.Text + "' has already been added to attendance for this date" + date_duty.Text +
                       ". Please check Duty Table or Attendance Report."); // no design
                    status.Enabled = true;
                }
                else
                {
                   
                    
                    status.Enabled = true;
                    string firstName, middleName, lastName, suffix;




                    if (Employee_Details.Employee_Database.ShowEmployee(employee_id.Text).suffix.ToString() == "None" || Employee_Details.Employee_Database.ShowEmployee(employee_id.Text).suffix.ToString() == null)
                    {
                        firstName = Employee_Details.Employee_Database.ShowEmployee(employee_id.Text).first_name.ToString();
                        middleName = Employee_Details.Employee_Database.ShowEmployee(employee_id.Text).middle_name.ToString();
                        lastName = Employee_Details.Employee_Database.ShowEmployee(employee_id.Text).last_name.ToString();

                        employee_name.Text = " " + firstName + " " + middleName + " " + lastName;
                    }
                    else
                    {
                        suffix = Employee_Details.Employee_Database.ShowEmployee(employee_id.Text).suffix.ToString();
                        firstName = Employee_Details.Employee_Database.ShowEmployee(employee_id.Text).first_name.ToString();
                        middleName = Employee_Details.Employee_Database.ShowEmployee(employee_id.Text).middle_name.ToString();
                        lastName = Employee_Details.Employee_Database.ShowEmployee(employee_id.Text).last_name.ToString();
                        employee_name.Text = " " + firstName + " " + middleName + " " + lastName + " " + suffix;
                    }
                }
            }
        }

        private void time_out_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            /* DateTime startTime = Convert.ToDateTime(time_in.Text);
            DateTime endtime = Convert.ToDateTime(time_out.Text);
            TimeSpan duration = startTime - endtime;
            duty_duration.Text = duration.ToString();
            MessageBox.Show(duration.TotalSeconds.ToString());*/


            /* TimeSpan t1 = TimeSpan.Parse(time_in.Text);
             TimeSpan t2 = TimeSpan.Parse(time_out.Text);
             double _24h = (new TimeSpan(24, 0, 0)).TotalMilliseconds;
             double diff = t2.TotalMilliseconds - t1.TotalMilliseconds;
             if (diff < 0) diff += _24h;
             duty_duration.Text = TimeSpan.FromMilliseconds(diff).ToString(); */

            TimeSpan duration = timeout.Value - timein.Value;
            duty_duration.Text = duration.ToString();


        }

        private void AddLblDuration_Click(object sender, EventArgs e)
        {
            
        }

        private void timein_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan duration = timeout.Value - timein.Value;
            duty_duration.Text = duration.ToString();

            string regular_pay = Employee_Details.Employee_Database.ShowEmployee(employee_id.Text).regular_pay.ToString();
            string worktime = Employee_Details.Employee_Database.ShowEmployee(employee_id.Text).regular_worktime.ToString();


            char[] work = worktime.ToCharArray();
            char[] emp_worktime = new char[30];
            int i = 0;

            while (!(work[i] == 'h'))
            {
                emp_worktime[i] = work[i];
                i++;
            }
            string ConvertedWorktime = new string(emp_worktime);
            int work_time = Convert.ToInt32(ConvertedWorktime.ToLower());

            int durationsConvertToTime = int.Parse(duration.Hours.ToString());
            int overtime_hrs = work_time - durationsConvertToTime;

            int pay = int.Parse(regular_pay);
            double rate = pay * (1.5);
            double overtime_pay = rate * overtime_hrs;

            overtime.Text = overtime_pay.ToString();
        }

        private void timeout_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan duration = timeout.Value - timein.Value;
            duty_duration.Text = duration.ToString();

            string regular_pay = Employee_Details.Employee_Database.ShowEmployee(employee_id.Text).regular_pay.ToString();
            string worktime = Employee_Details.Employee_Database.ShowEmployee(employee_id.Text).regular_worktime.ToString();


            char[] work = worktime.ToCharArray();
            char[] emp_worktime = new char[30];
            int i = 0;

            while (!(work[i] == 'h'))
            {
                emp_worktime[i] = work[i];
                i++;
            }
            string ConvertedWorktime = new string(emp_worktime);
            int work_time = Convert.ToInt32(ConvertedWorktime.ToLower());

            int durationsConvertToTime = int.Parse(duration.Hours.ToString());
            int overtime_hrs = work_time - durationsConvertToTime;

            int pay = int.Parse(regular_pay);
            double rate = pay * (1.5);
            double overtime_pay = rate * overtime_hrs;

            overtime.Text = overtime_pay.ToString();
        }
    }
}
