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
    public partial class ATTENDANCE : UserControl
    {
        public ATTENDANCE()
        {
            InitializeComponent();
        }

        private void clockLbl_Click(object sender, EventArgs e)
        {

        }

        private void ATTENDANCE_Load(object sender, EventArgs e)
        {
            dayTodayLbl_Attendance.Text = DateTime.Now.ToLongDateString();
            clockLbl_Attendance.Text = DateTime.Now.ToLongTimeString();

            timeTmr_Attendance.Start();
        }

        private void timeTmr_Attendance_Tick(object sender, EventArgs e)
        {
            clockLbl_Attendance.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
