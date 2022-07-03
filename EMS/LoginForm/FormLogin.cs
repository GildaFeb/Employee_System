using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.OleDb;

namespace LoginForm
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            
        }

        /*OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Souce=db1");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter DA = new OleDbDataAdapter();*/

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*con.Open();
            string login = "SELECT * FROM tbl_users WHERE username= '" + txtUsername.Texts + "'and passowrd= '" + txtpassword.Texts + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if(dr.Read() == true)
            {
                new dashboard().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Texts = "";
                txtpassword.Texts = "";
                txtUsername.Focus();
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Texts = "";
            txtpassword.Texts = "";
            txtUsername.Focus();
        }

        private void shwpswrd_Click(object sender, EventArgs e)
        {
            if (shwpswrd.Checked)
            {
                txtpassword.PasswordChar = false;
            }
            else
            {
                txtpassword.PasswordChar = false;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void shwpswrd_CheckedChanged(object sender, EventArgs e)
        {
            if (shwpswrd.Checked)
            {
                txtpassword.PasswordChar = false;
            }
            else
            {
                txtpassword.PasswordChar = false;
            }
        }
    }
}
