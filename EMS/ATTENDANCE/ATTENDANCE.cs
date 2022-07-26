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
    public partial class _ATTENDANCE : UserControl
    {
        public _ATTENDANCE()
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

        private void duty_addBtn_Click(object sender, EventArgs e)
        {
            this.SendToBack();
            ATTENDANCEdutydurationAddREVISED dutydurationAdd = new ATTENDANCEdutydurationAddREVISED();
            dutydurationAdd.Show();
        }

        private void duty_updateBtn_Click(object sender, EventArgs e)
        {
            this.SendToBack();
            ATTENDANCEdutydurationUpdREVISED dutydurationUpdate = new ATTENDANCEdutydurationUpdREVISED();
            dutydurationUpdate.BringToFront();
        }

        private void duty_deleteBtn_Click(object sender, EventArgs e)
        {
            this.SendToBack();
            ATTENDANCEdutydurationDel dutydurationDelete = new ATTENDANCEdutydurationDel();
            dutydurationDelete.BringToFront();
        }

        private void attendanceReport_Click(object sender, EventArgs e)
        {
            this.SendToBack();
            ATTENDANCEreport attendanceReport = new ATTENDANCEreport();
            attendanceReport.BringToFront();
        }
    }
}
