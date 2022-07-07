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
    public partial class EMPLOYEESadd_revised : UserControl
    {
        public EMPLOYEESadd_revised()
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

            hired_date.MaxDate = DateTime.Today;
            birth.MaxDate = DateTime.Today;

            regular_pay.MaxLength = 6;
            regular_worktime.MaxLength = 4;
        }

        private void label4_Click(object sender, EventArgs e)
        {

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

        private void btn_one3_Click(object sender, EventArgs e)
        {

        }

        private void btn_one8_Click(object sender, EventArgs e)
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

        private void btn_one3_Click_1(object sender, EventArgs e)
        {
            successEMPadd successEMPadd = new successEMPadd();
            successEMPadd.Show();
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

            if (!Char.IsDigit(ch) && ch != 8 && ch!= 46)
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
            int birthValidation(DateTime birth)
            {
                DateTime today = DateTime.Now;
                DateTime validDate = new DateTime(today.Year - 18, today.Month, today.Day);
                TimeSpan validAge = today.Subtract(validDate);
                TimeSpan actualAge = today.Subtract(birth);
                return TimeSpan.Compare(validAge, actualAge);
            }
        }

        private void regular_pay_SelectedIndexChanged(object sender, EventArgs e)
        {
            double Pay = Convert.ToDouble(Console.ReadLine());
        }

        private void total_rpay_SelectedIndexChanged(object sender, EventArgs e)
        {
            total_rpay.Value = regular_pay * regular_worktime;
        }
    }
}
