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
    public partial class verificationAttenUpdate : Form
    {
        public verificationAttenUpdate()
        {
            InitializeComponent();
        }

        private void btn_one2_Click(object sender, EventArgs e)
        {
            // Success Message Box
            successAttendanceUpdate successAttendanceUpdate = new successAttendanceUpdate();
            successAttendanceUpdate.Show();
        }
    }
}
