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
    public partial class verificationAttenDelete : Form
    {
        public verificationAttenDelete()
        {
            InitializeComponent();
        }

        private void btn_one2_Click(object sender, EventArgs e)
        {
            this.Close();
            successATTENDANCEdelete successATTENDANCEdelete = new successATTENDANCEdelete();
            successATTENDANCEdelete.ShowDialog();
        }

        private void btn_one1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
