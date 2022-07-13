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
    public partial class verificationEmpDelete : Form
    {
        public verificationEmpDelete()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_one1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_one2_Click(object sender, EventArgs e)
        {
            this.Close();
            successEMPdelete successEMPdelete = new successEMPdelete();
            successEMPdelete.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
