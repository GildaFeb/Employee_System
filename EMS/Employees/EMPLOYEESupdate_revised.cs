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
    public partial class EMPLOYEESupdate_revised : UserControl
    {
        public EMPLOYEESupdate_revised()
        {
            InitializeComponent();

            last_name.MaxLength = 50;
            first_name.MaxLength = 50;
            middle_name.MaxLength = 50;
            position.MaxLength = 50;
            email.MaxLength = 50;
            address.MaxLength = 50;
            contact_number.MaxLength = 15;
            cnumber_emergency.MaxLength = 15;

            hired_date.Value = DateTime.Now;
            hired_date.MaxDate = DateTime.Now;
            birth.Value = DateTime.Now;
            birth.MaxDate = DateTime.Now;

            regular_pay.MaxLength = 6;
            regular_worktime.MaxLength = 4;
        }

        private void btn_one3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(last_name.Text) ||
                string.IsNullOrWhiteSpace(first_name.Text) ||
                string.IsNullOrWhiteSpace(middle_name.Text) ||
                string.IsNullOrWhiteSpace(address.Text) ||
                string.IsNullOrWhiteSpace(email.Text) ||
                string.IsNullOrWhiteSpace(contact_number.Text) ||
                string.IsNullOrWhiteSpace(cnumber_emergency.Text) ||
                string.IsNullOrWhiteSpace(suffix.Text) ||
                string.IsNullOrWhiteSpace(position.Text) ||
                string.IsNullOrWhiteSpace(regular_pay.Text) ||
                string.IsNullOrWhiteSpace(regular_worktime.Text) ||
                string.IsNullOrWhiteSpace(sex.Text))
            {

                if (string.IsNullOrWhiteSpace(last_name.Text))
                {
                    errorlast_name.Visible = true;
                }
                else
                {
                    errorlast_name.Visible = false;
                }
                if (string.IsNullOrWhiteSpace(first_name.Text))
                {
                    errorfirst_name.Visible = true;
                }
                else
                {
                    errorfirst_name.Visible = false;
                }
                if (string.IsNullOrWhiteSpace(middle_name.Text))
                {
                    errormiddle_name.Visible = true;
                }
                else
                {
                    errormiddle_name.Visible = false;
                }
                if (string.IsNullOrWhiteSpace(suffix.Text))
                {
                    errorsuffix.Visible = true;
                }
                else
                {
                    errorsuffix.Visible = false;
                }
                if (string.IsNullOrWhiteSpace(position.Text))
                {
                    errorposition.Visible = true;
                }
                else
                {
                    errorposition.Visible = false;
                }
                if (string.IsNullOrWhiteSpace(regular_pay.Text))
                {
                    errorregular_pay.Visible = true;
                }
                else
                {
                    errorregular_pay.Visible = false;
                }
                if (string.IsNullOrWhiteSpace(regular_worktime.Text))
                {
                    errorregular_worktime.Visible = true;
                }
                else
                {
                    errorregular_worktime.Visible = false;
                }
                if (string.IsNullOrWhiteSpace(sex.Text))
                {
                    errorsex.Visible = true;
                }
                else
                {
                    errorsex.Visible = false;
                }
                if (string.IsNullOrWhiteSpace(address.Text))
                {
                    erroraddress.Visible = true;
                }
                else
                {
                    erroraddress.Visible = false;
                }
                if (string.IsNullOrWhiteSpace(contact_number.Text))
                {
                    errorcontact_number.Visible = true;
                }
                else
                {
                    errorcontact_number.Visible = false;
                }
                if (string.IsNullOrWhiteSpace(email.Text))
                {
                    erroremail.Visible = true;
                }
                else
                {
                    erroremail.Visible = false;
                }
                if (string.IsNullOrWhiteSpace(cnumber_emergency.Text))
                {
                    errorcnumber_emergency.Visible = true;
                }
                else
                {
                    errorcnumber_emergency.Visible = false;
                }

                errorEmptyFields errorEmptyFields = new errorEmptyFields();
                errorEmptyFields.ShowDialog();
            }
            else
            {
                // ----------- Update Employee: Passing data to database -----------

                //int ID = Int32.Parse(employee_id.Text);
                string date_joined = hired_date.CustomFormat = "MM-dd-yyyy";
                string birthday = birth.CustomFormat = "MM-dd-yyyy";
                Employee_Details.Employee employeeInfo = new Employee_Details.Employee()
                {

                    employeeID = employee_id.Text.ToString(),
                    first_name = first_name.Text.ToString(),
                    email = email.Text.ToString(),
                    address = address.Text.ToString(),
                    last_name = last_name.Text.ToString(),
                    middle_name = middle_name.Text.ToString(),
                    suffix = suffix.Text.ToString(),
                    birth_date = birthday.ToString(),
                    hired_date = date_joined.ToString(),
                    position = position.Text.ToString(),
                    contact_number = contact_number.Text.ToString(),
                    emergency_contact_number = cnumber_emergency.Text.ToString(),
                    regular_pay = regular_pay.Text.ToString(),
                    regular_worktime = regular_worktime.Text.ToString(),
                    total_salary = total_rpay.Text.ToString(),
                };
                verificationEmpUpdate verificationEmpUpdate = new verificationEmpUpdate();
                verificationEmpUpdate.ShowDialog();


                if (!(verificationEmpUpdate.ShowDialog() == DialogResult.Cancel))
                {
                    bool check = Employee_Details.Employee_Database.UpdateEmployee(employeeInfo);
                    if (check == true)
                    {
                        successEMPupdate successEMPupdate = new successEMPupdate();
                        successEMPupdate.ShowDialog();

                        employee_id.Clear();
                        last_name.Clear();
                        first_name.Clear();
                        middle_name.Clear();
                        suffix.SelectedItem = null;
                        position.SelectedItem = null;
                        regular_pay.SelectedItem = null;
                        regular_worktime.SelectedItem = null;
                        total_rpay.Clear();
                        sex.SelectedItem = null;
                        hired_date.Value = DateTime.Today;
                        address.Clear();
                        contact_number.Clear();
                        email.Clear();
                        cnumber_emergency.Clear();
                        birth.Value = DateTime.Today;

                        errorlast_name.Visible = false;
                        errorfirst_name.Visible = false;
                        errormiddle_name.Visible = false;
                        errorsuffix.Visible = false;
                        errorposition.Visible = false;
                        errorregular_pay.Visible = false;
                        errorregular_worktime.Visible = false;
                        errorsex.Visible = false;
                        erroraddress.Visible = false;
                        errorcontact_number.Visible = false;
                        erroremail.Visible = false;
                        errorcnumber_emergency.Visible = false;
                    }
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            employee_id.Clear();
            last_name.Clear();
            first_name.Clear();
            middle_name.Clear();
            suffix.SelectedItem = null;
            position.SelectedItem = null;
            regular_pay.SelectedItem = null;
            regular_worktime.SelectedItem = null;
            total_rpay.Clear();
            sex.SelectedItem = null;
            hired_date.Value = DateTime.Today;
            address.Clear();
            contact_number.Clear();
            email.Clear();
            cnumber_emergency.Clear();
            birth.Value = DateTime.Today;
        }

        private void suffix_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void birth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void hired_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void regular_pay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void regular_worktime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void contact_number_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void cnumber_emergency_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void btn_one1_Click(object sender, EventArgs e)
        {

        }

        private void sex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void birth_ValueChanged_1(object sender, EventArgs e)
        {
            int Age = DateTime.Now.Year - birth.Value.Year;

            if (Age < 18)
            {
                errorbirth.Visible = true;
                btn_save.Enabled = false;
            }
            else
            {
                errorbirth.Visible = false;
                btn_save.Enabled = true;
            }
        }

        private void contact_number_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void cnumber_emergency_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void regular_pay_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (regular_worktime != null && regular_pay != null)
            {

                double Pay = 0.0;
                double.TryParse(regular_pay.Text.Trim(), out Pay);

                if (regular_worktime.SelectedItem == regular_worktime.Items[0])
                {
                    total_rpay.Text = (Pay * 160).ToString();
                }
                else if (regular_worktime.SelectedItem == regular_worktime.Items[1])
                {

                    total_rpay.Text = (Pay * 128).ToString();
                }
                else if (regular_worktime.SelectedItem == regular_worktime.Items[2])
                {

                    total_rpay.Text = (Pay * 120).ToString();
                }
                else if (regular_worktime.SelectedItem == regular_worktime.Items[3])
                {

                    total_rpay.Text = (Pay * 96).ToString();
                }
                else if (regular_worktime.SelectedItem == regular_worktime.Items[4])
                {

                    total_rpay.Text = (Pay * 48).ToString();
                }
            }
            else
            {
                MessageBox.Show(" Select Regular Pay and Worktime to view TOTAL REGULAR PAY");
            }
        }

        private void regular_worktime_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (regular_worktime != null && regular_pay != null)
            {

                double Pay = 0.0;
                double.TryParse(regular_pay.Text.Trim(), out Pay);

                if (regular_worktime.SelectedItem == regular_worktime.Items[0])
                {
                    total_rpay.Text = (Pay * 160).ToString();
                }
                else if (regular_worktime.SelectedItem == regular_worktime.Items[1])
                {

                    total_rpay.Text = (Pay * 128).ToString();
                }
                else if (regular_worktime.SelectedItem == regular_worktime.Items[2])
                {

                    total_rpay.Text = (Pay * 120).ToString();
                }
                else if (regular_worktime.SelectedItem == regular_worktime.Items[3])
                {

                    total_rpay.Text = (Pay * 96).ToString();
                }
                else if (regular_worktime.SelectedItem == regular_worktime.Items[4])
                {

                    total_rpay.Text = (Pay * 48).ToString();
                }
            }
            else
            {
                MessageBox.Show(" Select Regular Pay and Worktime to view TOTAL REGULAR PAY");
            }
        }

        private void employee_id_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(employee_id.Text))
            {
                last_name.Enabled = true;
                first_name.Enabled = true;
                middle_name.Enabled = true;
                suffix.Enabled = true;
                position.Enabled = true;
                regular_pay.Enabled = true;
                regular_worktime.Enabled = true;
                sex.Enabled = true;
                address.Enabled = true;
                contact_number.Enabled = true;
                email.Enabled = true;
                cnumber_emergency.Enabled = true;
                hired_date.Enabled = true;
                birth.Enabled = true;
            }
            else if (string.IsNullOrWhiteSpace(employee_id.Text))
            {
                last_name.Enabled = false;
                first_name.Enabled = false;
                middle_name.Enabled = false;
                suffix.Enabled = false;
                position.Enabled = false;
                regular_pay.Enabled = false;
                regular_worktime.Enabled = false;
                sex.Enabled = false;
                address.Enabled = false;
                contact_number.Enabled = false;
                email.Enabled = false;
                cnumber_emergency.Enabled = false;
                hired_date.Enabled = false;
                birth.Enabled = false;
            }
            }
    }
}
