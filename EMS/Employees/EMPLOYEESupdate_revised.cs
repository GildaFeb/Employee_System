using System;
using System.Collections;
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
            designation.MaxLength = 50;
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
                // ----------- Update Employee: Passing data to database -----------

                //int ID = Int32.Parse(employee_id.Text);
                
                Employee_Details.Employee employeeInfo = new Employee_Details.Employee()
                {
                    employeeID = employee_id.Text,
                    first_name = first_name.Text,
                    email = email.Text,
                    address = address.Text,
                    sex = sex.Text,
                    last_name = last_name.Text,
                    middle_name = middle_name.Text,
                    suffix = suffix.Text,
                    birth_date = birth.Text,
                    hired_date = hired_date.Text,
                    designation = designation.Text,
                    contact_number = contact_number.Text,
                    emergency_contact_number = cnumber_emergency.Text,
                    regular_pay = regular_pay.Text,
                    regular_worktime = regular_worktime.Text,
                    total_salary = total_rpay.Text,
                    
                };
                //verificationEmpUpdate verificationEmpUpdate = new verificationEmpUpdate();
                //verificationEmpUpdate.ShowDialog();
                String msg = "Update this employee's details. Do you want to continue?";
                String caption = "Update Employee";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                MessageBoxIcon ico = MessageBoxIcon.Question;
                DialogResult result;
                result = MessageBox.Show(this, msg, caption, buttons, ico);
                if (result == DialogResult.Yes)
                { 
                    bool check = Employee_Details.Employee_Database.UpdateEmployee(employeeInfo);
                    if (check == true)
                    {
                        successEMPupdate successEMPupdate = new successEMPupdate();
                        successEMPupdate.ShowDialog();

                        employee_id.Clear();
                        last_name.Clear();
                        middle_name.Items.Clear();
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
                        first_name.Clear();

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
                middle_name.SelectedItem = null;
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
            }
                
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
            last_name.Enabled = false;
            first_name.Enabled = false;
            middle_name.Enabled = false;
            suffix.Enabled = false;
            designation.Enabled = false;
            regular_pay.Enabled = false;
            regular_worktime.Enabled = false;
            sex.Enabled = false;
            address.Enabled = false;
            contact_number.Enabled = false;
            email.Enabled = false;
            cnumber_emergency.Enabled = false;
            hired_date.Enabled = false;
            birth.Enabled = false;


            last_name.Clear();
            first_name.Clear();
            middle_name.SelectedItem = null;
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

            bool check = Employee_Details.Employee_Database.CheckEmployee(employee_id.Text);
            if (!string.IsNullOrWhiteSpace(employee_id.Text) && check == true)
            {
                last_name.Enabled = true;
                first_name.Enabled = true;
                middle_name.Enabled = true;
                suffix.Enabled = true;
                designation.Enabled = true;
                regular_pay.Enabled = true;
                regular_worktime.Enabled = true;
                sex.Enabled = true;
                address.Enabled = true;
                contact_number.Enabled = true;
                email.Enabled = true;
                cnumber_emergency.Enabled = true;
                hired_date.Enabled = true;
                birth.Enabled = true;

                last_name.Text = Employee_Details.Employee_Database.ShowEmployee(employee_id.Text).last_name.ToString();
                first_name.Text = Employee_Details.Employee_Database.ShowEmployee(employee_id.Text).first_name.ToString();
                middle_name.Text = Employee_Details.Employee_Database.ShowEmployee(employee_id.Text).middle_name.ToString();
                suffix.Text = Employee_Details.Employee_Database.ShowEmployee(employee_id.Text).suffix.ToString();
                hired_date.Value = DateTime.Parse(Employee_Details.Employee_Database.ShowEmployee(employee_id.Text).hired_date.ToString());
                birth.Value = DateTime.Parse(Employee_Details.Employee_Database.ShowEmployee(employee_id.Text).birth_date.ToString());
                sex.Text = Employee_Details.Employee_Database.ShowEmployee(employee_id.Text).sex.ToString();
                address.Text = Employee_Details.Employee_Database.ShowEmployee(employee_id.Text).address.ToString();
                contact_number.Text = Employee_Details.Employee_Database.ShowEmployee(employee_id.Text).contact_number.ToString();
                cnumber_emergency.Text = Employee_Details.Employee_Database.ShowEmployee(employee_id.Text).emergency_contact_number.ToString();
                email.Text = Employee_Details.Employee_Database.ShowEmployee(employee_id.Text).email.ToString();
                designation.Text = Employee_Details.Employee_Database.ShowEmployee(employee_id.Text).designation.ToString();
                regular_pay.Text = Employee_Details.Employee_Database.ShowEmployee(employee_id.Text).regular_pay.ToString();
                regular_worktime.Text = Employee_Details.Employee_Database.ShowEmployee(employee_id.Text).regular_worktime.ToString();
                total_rpay.Text = Employee_Details.Employee_Database.ShowEmployee(employee_id.Text).total_salary.ToString();
            }
            else if (string.IsNullOrWhiteSpace(employee_id.Text) && check == false)
            {
                last_name.Enabled = false;
                first_name.Enabled = false;
                middle_name.Enabled = false;
                suffix.Enabled = false;
                designation.Enabled = false;
                regular_pay.Enabled = false;
                regular_worktime.Enabled = false;
                sex.Enabled = false;
                address.Enabled = false;
                contact_number.Enabled = false;
                email.Enabled = false;
                cnumber_emergency.Enabled = false;
                hired_date.Enabled = false;
                birth.Enabled = false;


                last_name.Clear();
                first_name.Clear();
                middle_name.SelectedItem = null;
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
            }
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

        }

        private void designation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
