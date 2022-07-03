//using System.Data.OleDb;
using EMS;

namespace LoginForm
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        /*OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Souce=db1");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter DA = new OleDbDataAdapter();*/
        private void button1_Click(object sender, EventArgs e)
        {
            if (RegTxtUsername.Texts == "" || RegTxtPassword.Texts == "" || RegTxtCpass.Texts == "")
            {
                CMessageBox.Show("Username or Password fields are empty.", "Resgistration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (RegTxtPassword.Texts == RegTxtCpass.Texts) 
            {
               /* con.Open();
                string register = "INSERT INTO tbl_users VALUES('" + txtUsername.Texts + "','" + txtPassword.Texts + "')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();      
                con.Close();*/                  //Space for code to save in database 

                RegTxtUsername.Texts = "";
                RegTxtPassword.Texts = "";
                RegTxtCpass.Texts = "";


                CMessageBox.Show("Your Account has been Successfully Created.", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CMessageBox.Show("Password does not match.", "Registration Failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RegTxtPassword.Texts = "";
                RegTxtCpass.Texts = "";
                RegTxtPassword.Focus();
            }

        }
        private void btnShwpswrd_CheckedChanged(object sender, EventArgs e)
        {
            if(RegTogglePass.Checked)
            {
                RegTxtPassword.PasswordChar = false;
                RegTxtCpass.PasswordChar = false;
            }
            else
            {
                RegTxtPassword.PasswordChar = true;
                RegTxtCpass.PasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegTxtUsername.Texts = "";
            RegTxtPassword.Texts = "";
            RegTxtCpass.Texts = "";
            RegTxtUsername.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new LogForm().Show();
            this.Hide();
        }

        private void frmRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }
    }
}