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
        }

        private void btn_one3_Click(object sender, EventArgs e)
        {
            verificationEmpUpdate verificationEmpUpdate = new verificationEmpUpdate();
            verificationEmpUpdate.Show();
        }

        private void birth_date_TextChanged(object sender, EventArgs e)
        {

        }

        private void cnumber_emergency_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void contact_number_TextChanged(object sender, EventArgs e)
        {

        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
