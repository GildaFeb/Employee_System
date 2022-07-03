using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EMS;
//using System.Data.OleDb;

namespace LoginForm
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
            
        }

        /*OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Souce=db1");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter DA = new OleDbDataAdapter();*/

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*con.Open();
            string login = "SELECT * FROM tbl_users WHERE username= '" + txtUsername.Texts + "'and passowrd= '" + txtpassword.Texts + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();

                    //Space for database code*/

            if(LogTxtPass.Texts == "" || LogTxtUser.Texts == "")        
            {
                CMessageBox.Show("Username or Password field is empty", "Login Failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogTxtUser.Texts = "";
                LogTxtPass.Texts = "";
                LogTxtUser.Focus();
            }

            /*else if(dr.Read() == true)
            {
                MainForm main = new MainForm();     //Space for Condition if User and Pass is == to database.
                main.Show();
                this.Hide();                   
            }*/
            else
            {
                CMessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogTxtUser.Texts = "";
                LogTxtPass.Texts = "";
                LogTxtUser.Focus();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogTxtUser.Texts = "";
            LogTxtPass.Texts = "";
            LogTxtUser.Focus();
        }

        private void shwpswrd_Click(object sender, EventArgs e)
        {
            if (LogTogglePass.Checked)
            {
                LogTxtPass.PasswordChar = false;
            }
            else
            {
                LogTxtPass.PasswordChar = false;
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
            if (LogTogglePass.Checked)
            {
                LogTxtPass.PasswordChar = false;
            }
            else
            {
                LogTxtPass.PasswordChar = false;
            }
        }
    }
}
