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
    }
}
