using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace EMS
{
    public partial class employeeAdd : UserControl
    {
        public employeeAdd()
        {
            InitializeComponent();
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
                MessageBox.Show(" Conected to database!");
            }
            catch
            {
                MessageBox.Show(" There was problem in the internet");
            }
        }
        // ============== CONNECTING TO DATABASE ==============

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "TQrONgtH3QPSbKwlsvFza8drRcWswTyL3dRpec6a",
            BasePath = "https://employee-102-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };

        IFirebaseClient client;



        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
                MessageBox.Show(" Conected to database!");
            }
            catch
            {
                MessageBox.Show(" There was problem in the internet");
            }
        }

        // =================== REGISTER EMPLOYEE ======================

        private void btn_one3_Click_1(object sender, EventArgs e)
        {
            successEMPadd successEMPadd = new successEMPadd();
            successEMPadd.Show();
        }
        public async void register_employee()
        {
            Employee_Details.Employee employee = new Employee_Details.Employee()
            {
                employee_id = employee_id.Text,
                last_name = last_name.Text,
                first_name = first_name.Text,
                middle_name = middle_name.Text,
                birth_date = birth.Text,
                sex = sex.Text,
                address = address.Text,
                contact_number = contact_number.Text,
                email = email.Text,
                emergency_contact_number = emergency_contact.Text,
                position = position.Text,
                salary = salary.Text


            };
            FirebaseResponse response = await client.SetAsync("Employees/" + employee_id.Text, employee);
            MessageBox.Show(" Registered Successfully! ");
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_one12_Click(object sender, EventArgs e)
        {

        }

        private void btn_one9_Click(object sender, EventArgs e)
        {

        }

        private void btn_one13_Click(object sender, EventArgs e)
        {

        }

        private void btn_one11_Click(object sender, EventArgs e)
        {

        }

        private void btn_one1_Click(object sender, EventArgs e)
        {

        }

        private void btn_one3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_one8_Click(object sender, EventArgs e)
        {

        }

        private void btn_one7_Click(object sender, EventArgs e)
        {

        }

        private void btn_one6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_one5_Click(object sender, EventArgs e)
        {

        }

        private void btn_one4_Click(object sender, EventArgs e)
        {

        }

        private void btn_one2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
        }

        private void employeeAdd_Load(object sender, EventArgs e)
        {

        }

        private void btn_one7_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btn_one14_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_one12_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btn_one2_Click_1(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btn_one16_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btn_one4_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_one17_Click(object sender, EventArgs e)
        {

        }

        private void btn_one13_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click_2(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btn_one5_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_one9_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_one6_Click_1(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btn_one8_Click_1(object sender, EventArgs e)
        {

        }
       
    }
}
