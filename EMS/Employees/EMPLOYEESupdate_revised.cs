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

            hired_date.MaxDate = DateTime.Now;
            birth.MaxDate = DateTime.Now;

            regular_pay.MaxLength = 6;
            regular_worktime.MaxLength = 4;
        }

        private void btn_one3_Click(object sender, EventArgs e)
        {
            //subjected for shortening
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
            }
            else
            {
                verificationEmpUpdate verificationEmpUpdate = new verificationEmpUpdate();
                verificationEmpUpdate.Show();

                /* clear for save
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
                */
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
            }
            else
            {
                errorbirth.Visible = false;
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
    }
}
