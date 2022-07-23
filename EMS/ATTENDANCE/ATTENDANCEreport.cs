using EMS.ATTENDANCE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS
{
    public partial class ATTENDANCEreport : UserControl
    {
        public ATTENDANCEreport()
        {
            InitializeComponent();


            DateTime getYear = DateTime.Now;
            int year = int.Parse(getYear.Year.ToString());

            for(int i = 2010; i <= year; i++)
            {
                Year_.Items.Add(i.ToString());
            }
            Year_.Items.Add("--Select Year--");
            Month_.Items.Add("--Select Month--");
            DateTime currentM = DateTime.Now;
            int month = int.Parse(currentM.Month.ToString());
            Month_.SelectedIndex = month-1;


            DateTime currentY = DateTime.Now;
            Year_.Texts = currentY.Year.ToString();

           
        }

        private void ATTENDANCEreport_Load(object sender, EventArgs e)
        {
            int count = 0;
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");

            con.Open();
            string MonthYear = Month_.SelectedIndex + 1 + "/" + Year_.Texts;
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM ReportTbl WHERE DutyDate= '" + MonthYear.ToString() + "'", con);
            OleDbDataReader read = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(read);

            attndncrprt_DGV.DataSource = dt;
        }

        private void DelReport_Click(object sender, EventArgs e)
        {
            if (CMessageBox.Show("Are you sure to delete the selected attendance report data?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Code to delete
                for (int i = attndncrprt_DGV.Rows.Count - 1; i >= 0; i--)
                {
                    if ((bool)attndncrprt_DGV.Rows[i].Cells[0].FormattedValue)
                    {
                        attndncrprt_DGV.Rows.RemoveAt(i);
                    }
                }

                CMessageBox.Show("Selected attendance report data deleted.");
            }
        }

        private void btn_one3_Click(object sender, EventArgs e)
        {
            VerificationRepDelete delete = new VerificationRepDelete();
            delete.ShowDialog();
        }

        private void btn_one2_Click(object sender, EventArgs e)
        {
            // [!] Alvin = function for clear checked
            foreach (DataGridViewRow Row in attndncrprt_DGV.Rows)
                ((DataGridViewCheckBoxCell)Row.Cells["delete_ChckBx"]).Value = null;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!(Search.Text == ""))
            {
                string alph = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";
                if (!(Search.Text.Contains(alph)))
                {
                    OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");

                    con.Open();
                    OleDbCommand cmd = new OleDbCommand("Select * from ReportTbl Where EmployeeID ='" + Search.Text + "'", con);
                    OleDbDataReader read = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(read);
                    attndncrprt_DGV.DataSource = dt;
                    Year_.Texts = "--Select Year--";
                    Month_.Texts = "--Select Month--";

                }
                else
                {
                    
                }

            }
            else
            {
                MessageBox.Show(" Failed to search. Search field is empty.");


            }
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            //searchbar Attendance Report

        }

        private void CmbxMonth_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if(Month_.Texts != null && Year_.Texts != null)
            {
                int count = 0;
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");

                con.Open();
                string MonthYear = Month_.SelectedIndex + 1 + "/" + Year_.Texts;
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM ReportTbl WHERE DutyDate= '" + MonthYear.ToString() + "'", con);
                OleDbDataReader read = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(read);

                attndncrprt_DGV.DataSource = dt;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void Year__OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (Month_.Texts != null && Year_.Texts != null)
            {
                int count = 0;
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");

                con.Open();
                string MonthYear = Month_.SelectedIndex + 1 + "/" + Year_.Texts;
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM ReportTbl WHERE DutyDate= '" + MonthYear.ToString() + "'", con);
                OleDbDataReader read = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(read);

                attndncrprt_DGV.DataSource = dt;
            }
        }

        private void btn_one1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");

            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM ReportTbl", con);
            OleDbDataReader read = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(read);

            attndncrprt_DGV.DataSource = dt;

            Year_.Texts = "--Select Year--";
            Month_.Texts = "--Select Month--";
        }
    }
}
