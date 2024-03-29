﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace EMS
{
    public partial class EMPLOYEESadd_revised : UserControl
    {
        public EMPLOYEESadd_revised()
        {
            InitializeComponent();
            Generate_EmployeeID();
            employee_id.Enabled = false;
            last_name.MaxLength = 50;
            first_name.MaxLength = 50;
            middle_name.MaxLength = 50;
            designation.MaxLength = 50;
            email.MaxLength = 50;
            address.MaxLength = 50;
            contact_number.MaxLength = 15;
            cnumber_emergency.MaxLength = 15;

            hired_date.Value = DateTime.Now;
            hired_date.MaxDate = DateTime.Now;
            birth.Value = DateTime.Now;
            birth.MaxDate = DateTime.Now;

            regular_pay.MaxLength = 20;
        }


        // =========== [!] GENERATE ID FOR NEW EMPLOYEE ===============
        // Still not yet done. no server. completed after front and backend

        public void Generate_EmployeeID()
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
                                  Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");

            while (true)
            {
                int exist = 0;
                Random rand1 = new Random();
                int empID = rand1.Next(1111111, 99999999);

                OleDbCommand cmd = new OleDbCommand("Select * from EmployeeTbl where EmployeeID = @empID", con);
                cmd.Parameters.AddWithValue("@empID", empID);
                con.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        exist++;
                        break;
                    }
                }
                con.Close();

                if (exist == 0)
                {
                    employee_id.Text = empID.ToString();
                    break;
                }
            }          
        }

        // =========== [!] REGULAR PAY PICKER ===============

        private void regular_pay_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 160hrs(8hrs x 5days) x 4weeks - regular_worktime.Items[0]
            // 128hrs(8hrs x 4days) x 4weeks - regular_worktime.Items[1]
            // 120hrs(6hrs x 5days) x 4weeks - regular_worktime.Items[2]
            // 96hrs(8hrs x 3days) x 4weeks - regular_worktime.Items[3]
            // 48hrs(4hrs x 5days) x 4weeks - regular_worktime.Items[4]
            // [!] take note with the item number in every if else, thats the indicator of selected item

            if (string.IsNullOrWhiteSpace(designation.Text))
            {
                regular_worktime.Enabled = true;

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

                    total_rpay.Text = (Pay * 140).ToString();
                }
                else if (regular_worktime.SelectedItem == regular_worktime.Items[3])
                {

                    total_rpay.Text = (Pay * 112).ToString();
                }
                else if (regular_worktime.SelectedItem == regular_worktime.Items[4])
                {

                    total_rpay.Text = (Pay * 96).ToString();
                }

                worktime.Text = regular_worktime.Text;
                total.Text = total_rpay.Text;
                pay.Text = regular_pay.Text;
            }
        }

        // =========== [!] REGULAR WORKTIME ===============

        private void regular_worktime_SelectedIndexChanged(object sender, EventArgs e)
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

                total_rpay.Text = (Pay * 140).ToString();
            }
            else if (regular_worktime.SelectedItem == regular_worktime.Items[3])
            {

                total_rpay.Text = (Pay * 112).ToString();
            }
            else if (regular_worktime.SelectedItem == regular_worktime.Items[4])
            {

                total_rpay.Text = (Pay * 96).ToString();
            }

            worktime.Text = regular_worktime.Text;
            total.Text = total_rpay.Text;
            pay.Text = regular_pay.Text;
        }

        private void birth_ValueChanged(object sender, EventArgs e)
        {
            int Age = DateTime.Now.Year - birth.Value.Year;

            if (Age < 18)
            {
                errorbirth.Visible = true;
                registerBtn.Enabled = false;
            }
            else
            {
                errorbirth.Visible = false;
                registerBtn.Enabled = true;
            }
        }

        // =========== [!] ADD EMPLOYEE: SAVE BUTTON ===============

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(last_name.Text) ||
                string.IsNullOrWhiteSpace(first_name.Text) ||
                string.IsNullOrWhiteSpace(middle_name.Text) ||
                string.IsNullOrWhiteSpace(address.Text) ||
                string.IsNullOrWhiteSpace(email.Text) ||
                string.IsNullOrWhiteSpace(contact_number.Text) ||
                string.IsNullOrWhiteSpace(cnumber_emergency.Text) ||
                string.IsNullOrWhiteSpace(suffix.Text) ||
                string.IsNullOrWhiteSpace(designation.Text) ||
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
                if (string.IsNullOrWhiteSpace(designation.Text))
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
                if (string.IsNullOrWhiteSpace(hired_date.Text))
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
                // ----------- Add Employee: Passing data to database -----------
                //int ID = Convert.ToInt32(this.employee_id.Text);

                Employee_Details.Employee employeeInfo = new Employee_Details.Employee()
                {
                    employeeID = employee_id.Text,
                    first_name = first_name.Text,
                    last_name = last_name.Text,
                    sex = sex.Text,
                    email = email.Text,
                    address = address.Text,
                    middle_name = middle_name.Text,
                    suffix = suffix.Text,
                    birth_date = birth.Text,
                    hired_date = hired_date.Text,
                    designation = emp_position.Text,
                    contact_number = contact_number.Text,
                    emergency_contact_number = cnumber_emergency.Text,
                    regular_pay = pay.Text,
                    regular_worktime = worktime.Text,
                    total_salary = total.Text
                };

                String msg = "Register employee. Do you want to continue?";
                String caption = "Register Employee";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                MessageBoxIcon ico = MessageBoxIcon.Question;
                DialogResult result;
                result = MessageBox.Show(this, msg, caption, buttons, ico);

                if (result == DialogResult.Yes)
                {
                    bool check = Employee_Details.Employee_Database.AddEmployee(employeeInfo);
                    if (check == true)
                    {
                        successEMPadd successEMPadd = new successEMPadd();
                        successEMPadd.ShowDialog();
                        employee_id.Clear();
                        last_name.Clear();
                        first_name.Clear();
                        middle_name.Text = "";
                        suffix.SelectedItem = null;
                        designation.SelectedItem = null;
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
                        Generate_EmployeeID();
                    }
                    else
                    {
                        errorEMPadd errorEMPadd = new errorEMPadd();
                        errorEMPadd.ShowDialog();
                    }
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            String msg = "Do you want to clear all fields? ";
            String caption = "Clear all fields";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon ico = MessageBoxIcon.Question;
            DialogResult result;
            result = MessageBox.Show(this, msg, caption, buttons, ico);

            if (result == DialogResult.Yes)
            {
                employee_id.Clear();
                last_name.Clear();
                first_name.Clear();
                middle_name.Text = "";
                suffix.SelectedItem = null;
                designation.SelectedItem = null;
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
                Generate_EmployeeID();
            }
        }

        private void contact_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void cnumber_emergency_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void position_SelectedIndexChanged(object sender, EventArgs e)
        {
            emp_position.Text = designation.Text;
        }

        private void last_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_one2_Click(object sender, EventArgs e)
        {

        }

        private void btn_one1_Click(object sender, EventArgs e)
        {

        }

        public void EMPLOYEESadd_revised_Load(object sender, EventArgs e)
        {

        }

        private void hired_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void sex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void errorcnumber_emergency_Click(object sender, EventArgs e)
        {

        }

        private void errorregular_worktime_Click(object sender, EventArgs e)
        {

        }

        private void erroremail_Click(object sender, EventArgs e)
        {

        }

        private void errorcontact_number_Click(object sender, EventArgs e)
        {

        }

        private void errorregular_pay_Click(object sender, EventArgs e)
        {

        }

        private void erroraddress_Click(object sender, EventArgs e)
        {

        }

        private void errorposition_Click(object sender, EventArgs e)
        {

        }

        private void errorfirst_name_Click(object sender, EventArgs e)
        {

        }

        private void errormiddle_name_Click(object sender, EventArgs e)
        {

        }

        private void errorsuffix_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void errorlast_name_Click(object sender, EventArgs e)
        {

        }

        private void errorsex_Click(object sender, EventArgs e)
        {

        }

        private void errorbirth_Click(object sender, EventArgs e)
        {

        }

        private void erroremployee_id_Click(object sender, EventArgs e)
        {

        }

        private void worktime_Click(object sender, EventArgs e)
        {

        }

        private void total_rpay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
