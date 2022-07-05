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
    public partial class VerificationDutyUpdate : Form
    {
        public VerificationDutyUpdate()
        {
            InitializeComponent();
        }

        private void btn_one2_Click(object sender, EventArgs e)
        {
            // Success Message Box
            this.Close();
            SuccessDutyUpdate successAttendanceUpdate = new SuccessDutyUpdate();
            successAttendanceUpdate.ShowDialog();
        }

        private void btn_one1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
