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
            blank_timein.Enabled = false;
            blank_timeout.Enabled = false;
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

                submit_cover.Visible = false;
                pending_cover.Visible = false;
            }
            else if (status.SelectedItem.ToString() == "Absent")
            {
                // [!] Alvin = enabled false the time in, time out
                timeout.Enabled = false;
                timein.Enabled = false;
                now_timein.Enabled = false;
                now_timeout.Enabled = false;
                date_duty.Enabled = true;
                overtime.Text = "";
                duty_duration.Text = "";

                submit_cover.Visible = false;
                pending_cover.Visible = true;

            }
            else if (status.SelectedItem.ToString() == "On Leave")
            {
                // [!] Alvin = enabled false the time in, time out, duration, overtime
                now_timein.Enabled = false;
                now_timeout.Enabled = false;
                timein.Enabled = false;
                timeout.Enabled = false;
                date_duty.Enabled = true;
                overtime.Text = "";
                duty_duration.Text = "";

                submit_cover.Visible = false;
                pending_cover.Visible = true;
            }
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            // [!] Alvin = clear all forms
            employee_id.Text = "";
            status.Text = " ";
            duty_duration.Text = "";
            overtime.Text = "";
            blank_timeout.Visible = true;
            blank_timein.Visible = true;
            employee_name.Text = "";

            pending_cover.Visible = true;
            submit_cover.Visible = true;
            status.Enabled = false;
            now_timein.Enabled = false;
            now_timeout.Enabled = false;

            

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
            /*
            //DateTime dateTime = DateTime.ParseExact(now.Date.ToString(), "hh:mm", System.Globalization.CultureInfo.InvariantCulture);
            blank_timein.Visible = false;
            timein.Visible = true;
            TimeSpan duration = timeout.Value - timein.Value;
            duty_duration.Text = duration.ToString();

            //string regular_pay = Employee_Details.Employee_Database.ShowEmployee(employee_id.Text).regular_pay.ToString();
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
            int overtime_hrs = durationsConvertToTime - work_time;
            if(durationsConvertToTime > work_time)
            {
                overtime.Text = "0";
            }
            else
            {
                overtime.Text = overtime_hrs.ToString();
            }*/
            //int pay = int.Parse(regular_pay);
            /*double rate = pay * (1.5);
            double overtime_pay = rate * overtime_hrs;*/
            //DateTime dateTime = DateTime.ParseExact(now.Date.ToString(), "hh:mm", System.Globalization.CultureInfo.InvariantCulture);
            blank_timein.Visible = false;
            timein.Visible = true;
            TimeSpan duration = timeout.Value - timein.Value;

            //string regular_pay = Employee_Details.Employee_Database.ShowEmployee(employee_id.Text).regular_pay.ToString();
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
            int overtime_hrs = durationsConvertToTime - work_time;

            if (durationsConvertToTime < 0 && blank_timeout.Visible == false)
            {
                duty_duration.Text = "";
            }
            else if (durationsConvertToTime < 0 && blank_timeout.Visible == true)
            {
                invalid_time.Visible = true;

            }
            else
            {
                duty_duration.Text = duration.ToString();
                if ((durationsConvertToTime > work_time))
                {
                    overtime.Text = overtime_hrs.ToString();
                }
                else
                {

                    overtime.Text = "0";
                }
            }
        }

        private void now_timeout_Click(object sender, EventArgs e)
        {

            //int pay = int.Parse(regular_pay);
            /*double rate = pay * (1.5);
            double overtime_pay = rate * overtime_hrs;*/
            //DateTime dateTime = DateTime.ParseExact(now.Date.ToString(), "hh:mm", System.Globalization.CultureInfo.InvariantCulture);
            blank_timeout.Visible = false;
            timeout.Visible = true;
            TimeSpan duration = timeout.Value - timein.Value;
           

            //string regular_pay = Employee_Details.Employee_Database.ShowEmployee(employee_id.Text).regular_pay.ToString();
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
            int overtime_hrs = durationsConvertToTime - work_time;

            if (durationsConvertToTime < 0 && blank_timein.Visible == false)
            {
                duty_duration.Text = "";
            }
            else if (durationsConvertToTime < 0 && blank_timein.Visible == true)
            {
                invalid_time.Visible = true;

            }
            else
            {
                duty_duration.Text = duration.ToString();
                if ((durationsConvertToTime > work_time))
                {
                    overtime.Text = overtime_hrs.ToString();
                }
                else
                {

                    overtime.Text = "0";
                }
            }
        }

        private void clear_timein_Click(object sender, EventArgs e)
        {
            blank_timein.Visible = true;
            duty_duration.Text = "";

        }

        private void clear_timeout_Click(object sender, EventArgs e)
        {
            blank_timeout.Visible = true;
            duty_duration.Text = "";
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



            //int pay = int.Parse(regular_pay);
            /*double rate = pay * (1.5);
            double overtime_pay = rate * overtime_hrs;*/
            //DateTime dateTime = DateTime.ParseExact(now.Date.ToString(), "hh:mm", System.Globalization.CultureInfo.InvariantCulture);
            blank_timein.Visible = false;
            timein.Visible = true;
            TimeSpan duration = timeout.Value - timein.Value;

            //string regular_pay = Employee_Details.Employee_Database.ShowEmployee(employee_id.Text).regular_pay.ToString();
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
            int overtime_hrs = durationsConvertToTime - work_time;

            if (durationsConvertToTime < 0 &&  blank_timeout.Visible == false)
            {
                duty_duration.Text = "";
            }else if (durationsConvertToTime < 0 && blank_timeout.Visible == true)
            {
                invalid_time.Visible = true;

            }
            else
            {
                duty_duration.Text = duration.ToString();
                if ((durationsConvertToTime > work_time))
                {
                    overtime.Text = overtime_hrs.ToString();
                }
                else
                {

                    overtime.Text = "0";
                }
            }

        }

        private void timeout_ValueChanged(object sender, EventArgs e)
        {

            //int pay = int.Parse(regular_pay);
            /*double rate = pay * (1.5);
            double overtime_pay = rate * overtime_hrs;*/
            //DateTime dateTime = DateTime.ParseExact(now.Date.ToString(), "hh:mm", System.Globalization.CultureInfo.InvariantCulture);
            blank_timeout.Visible = false;
            timeout.Visible = true;
            TimeSpan duration = timeout.Value - timein.Value;

            //string regular_pay = Employee_Details.Employee_Database.ShowEmployee(employee_id.Text).regular_pay.ToString();
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
            int overtime_hrs = durationsConvertToTime - work_time;

            if (durationsConvertToTime < 0 && blank_timein.Visible == false)
            {
                duty_duration.Text = "";
            }
            else if (durationsConvertToTime < 0 && blank_timein.Visible == true)
            {
                invalid_time.Visible = true;

            }
            else
            {
                duty_duration.Text = duration.ToString();
                if ((durationsConvertToTime > work_time))
                {
                    overtime.Text = overtime_hrs.ToString();
                }
                else
                {

                    overtime.Text = "0";
                }
            }


        }

        private void LblStatus_Click(object sender, EventArgs e)
        {

        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void pending_cover_Click(object sender, EventArgs e)
        {

        }

        private void submit_cover_Click(object sender, EventArgs e)
        {

        }

        private void submit_cover_Click_1(object sender, EventArgs e)
        {

        }

        private void submit_btn_Click_1(object sender, EventArgs e)
        {

        }

        private void pending_btn_Click(object sender, EventArgs e)
        {
            if(status.Texts != null && invalid_time.Visible == false)
            {
                String msg = " You are about to save this as Pending. Do you want to continue? ";
                String caption = "Will be added to Table Duty.";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                MessageBoxIcon ico = MessageBoxIcon.Question;
                DialogResult result;
                result = MessageBox.Show(this, msg, caption, buttons, ico);
                if (result == DialogResult.Yes)
                {

                    char[] work = duty_duration.Text.ToCharArray();
                    char[] emp_worktime = new char[30];
                    int i = 0;

                    while (!(work[i] == ':'))
                    {
                        emp_worktime[i] = work[i];
                        i++;
                    }
                    string ConvertedWorktime = new string(emp_worktime);
                    int work_time = Convert.ToInt32(ConvertedWorktime.ToLower());
                    int time = int.Parse(overtime.Text);
                    double worked_hrs = work_time - time;
                    Employee_Details.Duty_Pending _Pending = new Employee_Details.Duty_Pending()
                    {
                        EmployeeID = employee_id.Text,
                        Fullname = employee_name.Text,
                        duty_date = date_duty.Text,
                        status = status.Texts,
                        timeIn = timein.Text,
                        timeOut = timeout.Text,
                        duration = duty_duration.Text,
                        overtime = overtime.Text,

                    };
                    if(Employee_Details.Employee_Database.AddDuty(_Pending) == true)
                    {
                        SuccessDutyAdd successDutyAdd = new SuccessDutyAdd();
                        successDutyAdd.Show();

                    }
                }
            }
            else
            {

            }
        }

        private void blank_timein_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
