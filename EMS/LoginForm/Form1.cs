//using System.Data.OleDb;

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
            if (txtUsername.Texts == "" && txtPassword.Texts == "" && txtCpass.Texts == "")
            {
                //CMessageBox.Show("Username and Password fields are empty", "Resgistration Failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /*else if (txtPassword.Texts == txtCpass.Texts) 
            {
                con.Open();
                string register = "INSERT INTO tbl_users VALUES('" + txtUsername.Texts + "','" + txtPassword.Texts + "')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                txtUsername.Texts = "";
                txtPassword.Texts = "";
                txtCpass.Texts = "";
                

                MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
            else
            {
                MessageBox.Show("Password does not match", "Registration Failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Texts = "";
                txtCpass.Texts = "";
                txtPassword.Focus();
            }

        }

        private void FrmReg_Load(object sender, EventArgs e)
        {

        }

        private void txtCpass__TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnShwpswrd_CheckedChanged(object sender, EventArgs e)
        {
            if(btnShwpswrd.Checked)
            {
                txtPassword.PasswordChar = false;
                txtCpass.PasswordChar = false;
            }
            else
            {
                txtPassword.PasswordChar = true;
                txtCpass.PasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Texts = "";
            txtPassword.Texts = "";
            txtCpass.Texts = "";
            txtUsername.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Hide();
        }
    }
}