﻿using EMS.ATTENDANCE;
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

            date_duty.Value = DateTime.Now;
            status_.Text = "--Select--";
            date_duty.CustomFormat = "dddd MMMM dd, yyyy";
            blank_timein.Enabled = false;
            blank_timeout.Enabled = false;

            if (status_.SelectedItem == status_.Items[0])
            {
                //  [!] Alvin = enabled true the status, date, time in, time out
                timein.Enabled = true;
                timeout.Enabled = true;
                now_timein.Enabled = true;
                now_timeout.Enabled = true;
                blank_timeout.Visible = true;
                blank_timein.Visible = true;
                submit_cover.Visible = false;
                pending_cover.Visible = false;
            }
            else if (status_.SelectedItem == status_.Items[1])
            {
                // [!] Alvin = enabled false the time in, time out
                timeout.Enabled = false;
                timein.Enabled = false;
                blank_timein.Enabled = false;
                blank_timeout.Enabled = false;
                now_timein.Enabled = false;
                now_timeout.Enabled = false;
                date_duty.Enabled = true;
                overtime.Text = "";
                duty_duration.Text = "";

                submit_cover.Visible = false;
                pending_cover.Visible = true;

            }
            else if (status_.SelectedItem == status_.Items[2])
            {
                // [!] Alvin = enabled false the time in, time out, duration, overtime
                now_timein.Enabled = false;
                now_timeout.Enabled = false;
                blank_timein.Enabled = false;
                blank_timeout.Enabled = false;
                timein.Enabled = false;
                timeout.Enabled = false;
                date_duty.Enabled = true;
                overtime.Text = "";
                duty_duration.Text = "";

                submit_cover.Visible = false;
                pending_cover.Visible = true;
            }
        }
        private void UpdTimePickerIn_ValueChanged(object sender, EventArgs e)
        {
            /*
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
            */
        }

        private void time_out_ValueChanged(object sender, EventArgs e)
        {
            /*
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
            */
        }

        private void status_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            /*status.Items.Add("Present");
            status.Items.Add("Absent");
            status.Items.Add("Leave");

            //naga multiply if di naka comment - Alvin

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
                time_in.Enabled = false;
                time_out.Enabled = false;
                duration.Enabled = false;
                overtime.Enabled = false;
                date_duty.Enabled = true;
                // [!] Alvin = enabled false the time in, time out, duration, overtime
            }
            */
        }

        private void ATTENDANCEdutydurationUpdREVISED_Load(object sender, EventArgs e)
        {
            date_duty.Value = DateTime.Now;
            status_.Text = "--Select--";
            date_duty.CustomFormat = "dddd MMMM dd, yyyy";
            blank_timein.Enabled = false;
            blank_timeout.Enabled = false;

            if (status_.SelectedItem == status_.Items[0])
            {
                //  [!] Alvin = enabled true the status, date, time in, time out
                timein.Enabled = true;
                timeout.Enabled = true;
                now_timein.Enabled = true;
                now_timeout.Enabled = true;
                blank_timeout.Visible = true;
                blank_timein.Visible = true;
                submit_cover.Visible = false;
                pending_cover.Visible = false;
            }
            else if (status_.SelectedItem == status_.Items[1])
            {
                // [!] Alvin = enabled false the time in, time out
                timeout.Enabled = false;
                timein.Enabled = false;
                blank_timein.Enabled = false;
                blank_timeout.Enabled = false;
                now_timein.Enabled = false;
                now_timeout.Enabled = false;
                date_duty.Enabled = true;
                overtime.Text = "";
                duty_duration.Text = "";

                submit_cover.Visible = false;
                pending_cover.Visible = true;

            }
            else if (status_.SelectedItem == status_.Items[2])
            {
                // [!] Alvin = enabled false the time in, time out, duration, overtime
                now_timein.Enabled = false;
                now_timeout.Enabled = false;
                blank_timein.Enabled = false;
                blank_timeout.Enabled = false;
                timein.Enabled = false;
                timeout.Enabled = false;
                date_duty.Enabled = true;
                overtime.Text = "";
                duty_duration.Text = "";

                submit_cover.Visible = false;
                pending_cover.Visible = true;
            }
        }

        private void btn_findemployee_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(employee_id.Text) || string.IsNullOrWhiteSpace(date_duty.Text))
            {
                MessageBox.Show(" Please enter ID number (e.g., 90012983)"); // no design
            }
            else
            {
                 


                if (Employee_Details.Employee_Database.ShowDuty_ByIDandDate(employee_id.Text, date_duty.Text) == true)
                {
                    MessageBox.Show("This employee with ID number '" + employee_id.Text + "' with a duty date: " + date_duty.Text +
                       " is not in the pending table."); // no design
                    status_.Enabled = false;
                    date_duty.Enabled = true;
                }
                else
                {

                    employee_id.Enabled = false;
                    date_duty.Enabled = false;
                    status_.Enabled = true;

                    status_.Text = Employee_Details.Employee_Database.ShowAttendance(employee_id.Text, date_duty.Text).status;
                    
                    
                    duty_duration.Text = Employee_Details.Employee_Database.ShowAttendance(employee_id.Text, date_duty.Text).duration;
                    name_emp.Text = Employee_Details.Employee_Database.ShowAttendance(employee_id.Text, date_duty.Text).Fullname;
                    overtime.Text = Employee_Details.Employee_Database.ShowAttendance(employee_id.Text, date_duty.Text).overtime;

                    if(Employee_Details.Employee_Database.ShowAttendance(employee_id.Text, date_duty.Text).timeIn == " ")
                    {
                        blank_timein.Visible = true;
                    }
                    else
                    {
                        blank_timein.Visible = false;
                        timein.Text = Employee_Details.Employee_Database.ShowAttendance(employee_id.Text, date_duty.Text).timeIn;
                    }
                    if (Employee_Details.Employee_Database.ShowAttendance(employee_id.Text, date_duty.Text).timeOut == " ")
                    {
                        blank_timeout.Visible = true;
                    }
                    else
                    {
                        timeout.Text = Employee_Details.Employee_Database.ShowAttendance(employee_id.Text, date_duty.Text).timeOut;
                        blank_timein.Visible = false;
                    }





                }
            }
        }

        private void employee_id_TextChanged(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(employee_id.Text)))
            {
                id_message.Visible = false;
            }
        }

        private void btn_clear_Click_2(object sender, EventArgs e)
        {
            employee_id.Text = "";
            duty_duration.Text = "";
            overtime.Text = "";
            blank_timeout.Visible = true;
            blank_timein.Visible = true;
            employee_name.Text = "";
            status_.SelectedItem = null;
            status_.Text = "--Select--";
            name_emp.Text = "-----------";

            pending_cover.Visible = true;
            submit_cover.Visible = true;
            status_.Enabled = false;
            now_timein.Enabled = false;
            now_timeout.Enabled = false;
            employee_id.Enabled = true;
            date_duty.Enabled = true;
            id_message.Visible = true;
        }

        private void pending_btn_Click(object sender, EventArgs e)
        {
            if (invalid_time.Visible == false && (status_.Text == "Present" || status_.Text == "Absent" || status_.Text == "Leave"))
            {
                String msg = " You are about to update this record. Do you want to continue? ";
                String caption = "Update Record";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                MessageBoxIcon ico = MessageBoxIcon.Question;
                DialogResult result;
                result = MessageBox.Show(this, msg, caption, buttons, ico);
                if (result == DialogResult.Yes)
                {
                    if (blank_timein.Visible == true && blank_timeout.Visible == true)
                    {
                        Employee_Details.Duty_Pending _Pending = new Employee_Details.Duty_Pending()
                        {
                            EmployeeID = employee_id.Text,
                            Fullname = employee_name.Text,
                            duty_date = date_duty.Text,
                            status = status_.Text,

                            timeIn = " ",
                            timeOut = " ",
                            duration = " ",
                            overtime = " ",
                        };
                        if (Employee_Details.Employee_Database.UpdatePendingDuty(_Pending) == true)
                        {
                            SuccessDutyUpdate successDutyUpdate = new SuccessDutyUpdate();
                            successDutyUpdate.Show();
                            employee_id.Text = "";
                            duty_duration.Text = "";
                            overtime.Text = "";
                            blank_timeout.Visible = true;
                            blank_timein.Visible = true;
                            employee_name.Text = "";
                            status_.SelectedItem = null;
                            status_.Text = "--Select--";
                            id_message.Visible = true;
                            name_emp.Text = "-----------";

                            pending_cover.Visible = true;
                            submit_cover.Visible = true;
                            status_.Enabled = false;
                            now_timein.Enabled = false;
                            now_timeout.Enabled = false;
                            employee_id.Enabled = true;
                            date_duty.Enabled = true;
                        }

                    }
                    else if (blank_timein.Visible == false && blank_timeout.Visible == true)
                    {
                        Employee_Details.Duty_Pending _Pending = new Employee_Details.Duty_Pending()
                        {
                            EmployeeID = employee_id.Text,
                            Fullname = employee_name.Text,
                            duty_date = date_duty.Text,
                            status = status_.Text,
                            timeIn = timein.Text,


                            timeOut = " ",
                            duration = " ",
                            overtime = " ",

                        };
                        if (Employee_Details.Employee_Database.UpdatePendingDuty(_Pending) == true)
                        {
                            SuccessDutyUpdate successDutyUpdate = new SuccessDutyUpdate();
                            successDutyUpdate.Show();
                            employee_id.Text = "";
                            duty_duration.Text = "";
                            overtime.Text = "";
                            blank_timeout.Visible = true;
                            blank_timein.Visible = true;
                            employee_name.Text = "";
                            status_.SelectedItem = null;
                            status_.Text = "--Select--";
                            id_message.Visible = true;
                            name_emp.Text = "-----------";

                            pending_cover.Visible = true;
                            submit_cover.Visible = true;
                            status_.Enabled = false;
                            now_timein.Enabled = false;
                            now_timeout.Enabled = false;
                            employee_id.Enabled = true;
                            date_duty.Enabled = true;

                        }
                    }
                    else if (blank_timein.Visible == false && blank_timeout.Visible == false)
                    {
                        Employee_Details.Duty_Pending _Pending = new Employee_Details.Duty_Pending()
                        {
                            EmployeeID = employee_id.Text,
                            Fullname = employee_name.Text,
                            duty_date = date_duty.Text,
                            status = status_.Text,
                            timeIn = timein.Text,
                            timeOut = timeout.Text,
                            duration = duty_duration.Text,
                            overtime = overtime.Text,

                        };
                        if (Employee_Details.Employee_Database.UpdatePendingDuty(_Pending) == true)
                        {
                            SuccessDutyUpdate successDutyUpdate = new SuccessDutyUpdate();
                            successDutyUpdate.Show();
                            employee_id.Text = "";
                            duty_duration.Text = "";
                            overtime.Text = "";
                            blank_timeout.Visible = true;
                            blank_timein.Visible = true;
                            employee_name.Text = "";
                            status_.SelectedItem = null;
                            status_.Text = "--Select--";
                            id_message.Visible = true;
                            name_emp.Text = "-----------";

                            pending_cover.Visible = true;
                            submit_cover.Visible = true;
                            status_.Enabled = false;
                            now_timein.Enabled = false;
                            now_timeout.Enabled = false;
                            employee_id.Enabled = true;
                            date_duty.Enabled = true;

                        }
                        else
                        {
                            MessageBox.Show("There's an error in updating.");
                        }
                    }else if (blank_timein.Visible == true && blank_timeout.Visible == false)
                    {
                        MessageBox.Show("You have value for 'Time out but not in 'Time in'. Please double check.");
                    }
                }
            }
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            if (invalid_time.Visible == false && status_.Text == "Present" && blank_timein.Visible == false && blank_timeout.Visible == false)
            {
                String msg = " You are about to submit this as Attendance Report. Do you want to continue? ";
                String caption = "Attendance Report.";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                MessageBoxIcon ico = MessageBoxIcon.Question;
                DialogResult result;
                result = MessageBox.Show(this, msg, caption, buttons, ico);
                if (result == DialogResult.Yes)
                {

                    /*char[] work = duty_duration.Text.ToCharArray();
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
                    double worked_hrs = work_time - time;*/

                    dat.Text = date_duty.Value.Month.ToString() + "/" + date_duty.Value.Year.ToString();
                    Employee_Details.Report _record = new Employee_Details.Report()
                    {
                        EmployeeID = employee_id.Text,
                        Fullname = employee_name.Text,
                        DutyDate = dat.Text,
                        Present = status_.Text,
                        worked_hrs = dur.Text,
                        Overtime = overtime.Text,
                        Status = status_.Text,

                    }; Employee_Details.Duty_Pending _Pending = new Employee_Details.Duty_Pending()
                    {
                        EmployeeID = employee_id.Text,
                        Fullname = employee_name.Text,
                        duty_date = date_duty.Text,
                        status = status_.Text,
                        timeIn = timein.Text,
                        timeOut = timeout.Text,
                        duration = duty_duration.Text,
                        overtime = overtime.Text,

                    };
                    if (Employee_Details.Employee_Database.SubmitReport(_record) == true && Employee_Details.Employee_Database.AddHistory(_Pending) == true)
                    {
                        SuccessDutyAdd successDutyAdd = new SuccessDutyAdd();
                        successDutyAdd.Show(); // will change

                        // Reset fields
                        employee_id.Text = "";
                        duty_duration.Text = "";
                        overtime.Text = "";
                        blank_timeout.Visible = true;
                        blank_timein.Visible = true;
                        employee_name.Text = "";
                        status_.SelectedItem = null;
                        status_.Text = "--Select--";
                        id_message.Visible = true;
                        name_emp.Text = "-----------";

                        pending_cover.Visible = true;
                        submit_cover.Visible = true;
                        status_.Enabled = false;
                        now_timein.Enabled = false;
                        now_timeout.Enabled = false;
                        employee_id.Enabled = true;
                        date_duty.Enabled = true;
                    }
                }
            }
            else if ((status_.Text == "Absent" || status_.Text == "Leave"))
            {
                String msg = " You are about to submit this report and will no longer change. Do you want to continue? ";
                String caption = "Submit Report";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                MessageBoxIcon ico = MessageBoxIcon.Question;
                DialogResult result;
                result = MessageBox.Show(this, msg, caption, buttons, ico);
                if (result == DialogResult.Yes)
                {

                    dat.Text = date_duty.Value.Month.ToString() + "/" + date_duty.Value.Year.ToString();
                    Employee_Details.Report _record = new Employee_Details.Report()
                    {
                        EmployeeID = employee_id.Text,
                        Fullname = employee_name.Text,
                        DutyDate = dat.Text,
                        Status = status_.Text,
                        worked_hrs = "0",
                        Overtime = "0",
                    };
                    Employee_Details.Duty_Pending _Pending = new Employee_Details.Duty_Pending()
                    {
                        EmployeeID = employee_id.Text,
                        Fullname = employee_name.Text,
                        duty_date = date_duty.Text,
                        status = status_.Text,
                        timeIn = "0",
                        timeOut = "0",
                        duration = "0",
                        overtime = "0",

                    };
                    if (Employee_Details.Employee_Database.SubmitReport(_record) == true && Employee_Details.Employee_Database.AddHistory(_Pending) == true)
                    {
                        SuccessDutyAdd successDutyAdd = new SuccessDutyAdd();
                        successDutyAdd.Show(); // will change

                        // Reset fields
                        employee_id.Text = "";
                        duty_duration.Text = "";
                        overtime.Text = "";
                        blank_timeout.Visible = true;
                        blank_timein.Visible = true;
                        employee_name.Text = "";
                        status_.SelectedItem = null;
                        status_.Text = "--Select--";
                        id_message.Visible = true;
                        name_emp.Text = "-----------";

                        pending_cover.Visible = true;
                        submit_cover.Visible = true;
                        status_.Enabled = false;
                        now_timein.Enabled = false;
                        now_timeout.Enabled = false;
                        employee_id.Enabled = true;
                        date_duty.Enabled = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("You selected present. You need to fill the 'time in' and 'time out' to submit Report.");
            }
        }

        private void status__SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (status_.SelectedItem == status_.Items[0])
            {
                //  [!] Alvin = enabled true the status, date, time in, time out
                timein.Enabled = true;
                timeout.Enabled = true;
                now_timein.Enabled = true;
                now_timeout.Enabled = true;

                submit_cover.Visible = false;
                pending_cover.Visible = false;
            }
            else if (status_.SelectedItem == status_.Items[1])
            {
                // [!] Alvin = enabled false the time in, time out
                timeout.Enabled = false;
                timein.Enabled = false;
                blank_timein.Enabled = false;
                blank_timeout.Enabled = false;
                now_timein.Enabled = false;
                now_timeout.Enabled = false;
                date_duty.Enabled = false;
                overtime.Text = "";
                duty_duration.Text = "";

                submit_cover.Visible = false;
                pending_cover.Visible = true;

            }
            else if (status_.SelectedItem == status_.Items[2])
            {
                // [!] Alvin = enabled false the time in, time out, duration, overtime
                now_timein.Enabled = false;
                now_timeout.Enabled = false;
                blank_timein.Enabled = false;
                blank_timeout.Enabled = false;
                timein.Enabled = false;
                timeout.Enabled = false;
                date_duty.Enabled = false;
                overtime.Text = "";
                duty_duration.Text = "";

                submit_cover.Visible = false;
                pending_cover.Visible = true;
            }
        }

        private void now_timein_Click_1(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            timein.Text = dateTime.ToString();
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


            if (blank_timeout.Visible == false && blank_timeout.Visible == false && duration.ToString().Contains("-"))
            {
                duty_duration.Text = duration.ToString();
                invalid_time.Visible = true;
                overtime.Text = null;
            }
            else if (!(duration.ToString().Contains("-")) && (blank_timeout.Visible == false && blank_timein.Visible == false))
            {
                duty_duration.Text = duration.ToString();
                dur.Text = duration.Hours.ToString();
                if ((durationsConvertToTime > work_time))
                {
                    invalid_time.Visible = false;
                    overtime.Text = overtime_hrs.ToString();
                }
                else
                {
                    invalid_time.Visible = false;
                    overtime.Text = "0";
                }
            }
        }

        private void now_timeout_Click_1(object sender, EventArgs e)
        {
            //int pay = int.Parse(regular_pay);
            /*double rate = pay * (1.5);
            double overtime_pay = rate * overtime_hrs;*/
            //DateTime dateTime = DateTime.ParseExact(now.Date.ToString(), "hh:mm", System.Globalization.CultureInfo.InvariantCulture);
            blank_timeout.Visible = false;
            DateTime dateTime = DateTime.Now;
            timeout.Text = dateTime.ToString();
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

            if (blank_timeout.Visible == false && blank_timeout.Visible == false && duration.ToString().Contains("-"))
            {
                duty_duration.Text = duration.ToString();
                invalid_time.Visible = true;
                overtime.Text = null;
            }
            else if (!(duration.ToString().Contains("-")) && (blank_timeout.Visible == false && blank_timein.Visible == false))
            {
                duty_duration.Text = duration.ToString();
                dur.Text = duration.Hours.ToString();
                if ((durationsConvertToTime > work_time))
                {
                    invalid_time.Visible = false;
                    overtime.Text = overtime_hrs.ToString();
                }
                else
                {
                    invalid_time.Visible = false;
                    overtime.Text = "0";
                }
            }
        }

        private void timein_ValueChanged_1(object sender, EventArgs e)
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

            if (blank_timeout.Visible == false && blank_timeout.Visible == false && duration.ToString().Contains("-"))
            {
                duty_duration.Text = duration.ToString();
                invalid_time.Visible = true;
                overtime.Text = null;
            }
            else if (!(duration.ToString().Contains("-")) && (blank_timeout.Visible == false && blank_timein.Visible == false))
            {
                duty_duration.Text = duration.ToString();
                dur.Text = duration.Hours.ToString();
                if ((durationsConvertToTime > work_time))
                {
                    invalid_time.Visible = false;
                    overtime.Text = overtime_hrs.ToString();
                }
                else
                {
                    invalid_time.Visible = false;
                    overtime.Text = "0";
                }
            }
        }

        private void timeout_ValueChanged_1(object sender, EventArgs e)
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

            if (blank_timeout.Visible == false && blank_timeout.Visible == false && duration.ToString().Contains("-"))
            {
                duty_duration.Text = duration.ToString();
                invalid_time.Visible = true;
                overtime.Text = null;
            }
            else if (!(duration.ToString().Contains("-")) && (blank_timeout.Visible == false && blank_timein.Visible == false))
            {
                duty_duration.Text = duration.ToString();
                dur.Text = duration.Hours.ToString();
                if ((durationsConvertToTime > work_time))
                {
                    invalid_time.Visible = false;
                    overtime.Text = overtime_hrs.ToString();
                }
                else
                {
                    invalid_time.Visible = false;
                    overtime.Text = "0";
                }
            }
        }

        private void clear_timein_Click(object sender, EventArgs e)
        {
            blank_timein.Visible = true;
            duty_duration.Text = "";
            overtime.Text = null;
            blank_timeout.Visible = true;
        }

        private void clear_timeout_Click(object sender, EventArgs e)
        {
            blank_timeout.Visible = true;
            duty_duration.Text = "";
            overtime.Text = null;
        }
    }
}
