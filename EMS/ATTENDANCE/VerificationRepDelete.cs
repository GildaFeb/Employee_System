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
    public partial class VerificationRepDelete : Form
    {
        public VerificationRepDelete()
        {
            InitializeComponent();
        }

        private void btn_one1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_one2_Click(object sender, EventArgs e)
        {
            SuccessRepDelete  del = new SuccessRepDelete();
            del.ShowDialog();
            this.Close();
        }
    }
}
