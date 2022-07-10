using Microsoft.Data.SqlClient;
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

namespace EMS
{
    public partial class EMPLOYEESadd_revised : UserControl
    {
        public EMPLOYEESadd_revised()
        {
            InitializeComponent();
            // Generate_EmployeeID();
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

            //no scroll bars
            //wala pong dropdown para sa civil status at puno na po yung box except kung tatanggalin po yung "others"
        }


        // =========== [!] GENERATE ID FOR NEW EMPLOYEE ===============
        // Still not yet done. no server. completed after front and backend

        public void Generate_EmployeeID()
        {
            
            /* SqlConnection Con = new SqlConnection(@"Data Source=|DataDiretory|\EmployeeTbl.mdf");

            while (true)
            {

                int exist = 0;
                Random rand1 = new Random();
                int empID = rand1.Next(1111111, 99999999);

                SqlCommand cmd = new SqlCommand("Select * from Employee where EmployeeID = @empID", Con);
                cmd.Parameters.AddWithValue("@empID", empID);
                //Con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        exist++;
                        break;
                    }
                }
                //Con.Close();

                if (exist == 0)
                {
                    employee_id.Text = empID.ToString();
                    break;
                }
            }

            */
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_one6_Click(object sender, EventArgs e)
        {

        }

        private void salary_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_one15_Click(object sender, EventArgs e)
        {

        }

        private void btn_one17_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void middle_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void first_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_one2_Click(object sender, EventArgs e)
        {

        }

        private void btn_one7_Click(object sender, EventArgs e)
        {

        }

        private void btn_one12_Click(object sender, EventArgs e)
        {

        }

        private void btn_one4_Click(object sender, EventArgs e)
        {

        }

        private void btn_one10_Click(object sender, EventArgs e)
        {

        }

        private void btn_one9_Click(object sender, EventArgs e)
        {

        }

        private void position_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_one1_Click(object sender, EventArgs e)
        {

        }

        private void EMPLOYEESadd_revised_Load(object sender, EventArgs e)
        {

        }

        // =========== [!] ADD EMPLOYEE: SAVE BUTTON ===============

        private void btn_one3_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(employee_id.Text) || 
                string.IsNullOrWhiteSpace(last_name.Text) ||
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
                if (string.IsNullOrWhiteSpace(employee_id.Text))
                {
                    erroremployee_id.Visible = true;
                }
                else
                {
                    erroremployee_id.Visible = false;
                }
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
                // ----------- Add Employee: Passing data to database -----------
                Employee_Details.Employee employeeInfo = new Employee_Details.Employee()
                {
                    employeeID = employee_id.Text.ToString(),
                    first_name = first_name.Text.ToString(),
                    email = email.Text.ToString(),
                    address = address.Text.ToString(),
                    last_name = last_name.Text.ToString(),
                    middle_name = middle_name.Text.ToString(),
                    suffix = suffix.Text.ToString(),
                    birth_date = birth.Value.ToString(),
                    hired_date = hired_date.Value.ToString(),
                    position = position.Text.ToString(),
                    contact_number = contact_number.Text.ToString(),
                    emergency_contact_number = cnumber_emergency.Text.ToString(),
                    regular_pay = regular_pay.Text.ToString(),
                    regular_worktime = regular_worktime.Text.ToString(),
                    total_salary = total_rpay.Text.ToString(),
                };
                
                // (Not yet finished) = adding to database
                bool check = Employee_Details.Employee_Database.AddEmployee(employeeInfo);
                if (check == true) 
                {
                    successEMPadd successEMPadd = new successEMPadd();
                    successEMPadd.ShowDialog();
                }
                else
                {
                    errorEMPadd errorEMPadd = new errorEMPadd();
                    errorEMPadd.ShowDialog();
                }

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

        private void hired_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void sex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void birth_ValueChanged(object sender, EventArgs e)
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

        // =========== [!] REGULAR PAY PICKER ===============

        private void regular_pay_SelectedIndexChanged(object sender, EventArgs e)
        {


            // 160hrs(8hrs x 5days) x 4weeks - regular_worktime.Items[0]
            // 128hrs(8hrs x 4days) x 4weeks - regular_worktime.Items[1]
            // 120hrs(6hrs x 5days) x 4weeks - regular_worktime.Items[2]
            // 96hrs(8hrs x 3days) x 4weeks - regular_worktime.Items[3]
            // 48hrs(4hrs x 5days) x 4weeks - regular_worktime.Items[4]
            // [!] take note with the item number in every if else, thats the indicator of selected item

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

        private void total_rpay_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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


        // =========== [!] REGULAR WORKTIME ===============
        private void regular_worktime_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
