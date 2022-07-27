using LoginForm;
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
    public partial class LogOut : Form
    {
        public LogOut()
        {
            InitializeComponent();
        }

        private void btn_one2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_one1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogOut_Load(object sender, EventArgs e)
        {
            
        }
    }
}
