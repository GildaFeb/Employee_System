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
    public partial class ATTENDANCEdutydurationDel : UserControl
    {
        CheckBox headerCheckBox = new CheckBox();
        public ATTENDANCEdutydurationDel()
        {
            InitializeComponent();

            tableDelete.ForeColor = Color.Black;

            //Find the Location of Header Cell.
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            checkBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            checkBoxColumn.Width = 100;
            checkBoxColumn.Name = "checkBoxColumn";
            checkBoxColumn.HeaderText = "";
            tableDelete.Columns.Insert(0, checkBoxColumn);
            Point headerCellLocation = this.tableDelete.GetCellDisplayRectangle(0, -1, true).Location;

            //Place the Header CheckBox in the Location of the Header Cell.
            headerCheckBox.Location = new Point(headerCellLocation.X + 55, headerCellLocation.Y + 5);
            headerCheckBox.BackColor = Color.White;
            headerCheckBox.Size = new Size(18, 18);

            //Assign Click event to the Header CheckBox.
            headerCheckBox.Click += new EventHandler(HeaderCheckBox_Clicked);
            tableDelete.Controls.Add(headerCheckBox);

            //Add a CheckBox Column to the DataGridView at the first position.

            //Assign Click event to the DataGridView Cell.
            tableDelete.CellContentClick += new DataGridViewCellEventHandler(TableDB_CellClick);

        }

        private void HeaderCheckBox_Clicked(object sender, EventArgs e)
        {
            //Necessary to end the edit mode of the Cell.
            tableDelete.EndEdit();

            //Loop and check and uncheck all row CheckBoxes based on Header Cell CheckBox.
            foreach (DataGridViewRow row in tableDelete.Rows)
            {
                DataGridViewCheckBoxCell checkBox = ((DataGridViewCheckBoxCell)row.Cells["checkBoxColumn"]);
                checkBox.Value = headerCheckBox.Checked;
            }
        }
        private void TableDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Check to ensure that the row CheckBox is clicked.
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                //Loop to verify whether all row CheckBoxes are checked or not.
                bool isChecked = true;
                foreach (DataGridViewRow row in tableDelete.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["checkBoxColumn"].EditedFormattedValue) == false)
                    {
                        isChecked = false;
                        break;
                    }
                }
                headerCheckBox.Checked = isChecked;
            }
        }


        private void ATTENDANCEdepartment_Load(object sender, EventArgs e)
        {
            visualsDatagridview();
             OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");

             con.Open();
             OleDbCommand cmd = new OleDbCommand("Select * from DutyTbl", con);
             OleDbDataReader read = cmd.ExecuteReader();
             DataTable dt = new DataTable();
             dt.Load(read);
            if (Employee_Details.Employee_Database.DutyRecord() == 0 )
            {
                noData.Visible = true;
            }
            tableDelete.DataSource = dt;
            

        }
        void visualsDatagridview()
        {
            // UNNECESSARY, 'WAG IDELETE

            //tableDelete_DGV.AlternatingRowsDefaultCellStyle.BackColor = Color.Blue; //Color.FromArgb(238, 239, 249);
            //tableDelete_DGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tableDelete.DefaultCellStyle.SelectionBackColor = Color.FromArgb(202, 63, 63);
            //tableDelete_DGV.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            tableDelete.BackgroundColor = Color.White;
            //tableDelete_DGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            tableDelete.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(62, 113, 201);
            tableDelete.RowHeadersDefaultCellStyle.SelectionForeColor = Color.White;

            tableDelete.EnableHeadersVisualStyles = false;
            tableDelete.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //tableDelete_DGV.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);      
            tableDelete.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(63, 113, 202);
            tableDelete.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void ATTENDANCEdutyduration_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void DelDuration_Click(object sender, EventArgs e)
        {
            if (CMessageBox.Show("Are you sure to delete the selected data in duty duration?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Code to delete
                //note to sef, recheck next time
                for (int i = tableDelete.Rows.Count - 1; i >= 0; i--)
                {
                    if ((bool)tableDelete.Rows[i].Cells[0].FormattedValue)
                    {
                        tableDelete.Rows.RemoveAt(i);
                    }
                }

                CMessageBox.Show("Selected Duty duration data deleted.");
            }
        }

        private void tableDelete_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");

            con.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from DutyTbl", con);
            OleDbDataReader read = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(read);
            tableDelete.DataSource = dt;
        }

        private void CmbxMonth_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_one3_Click_1(object sender, EventArgs e)
        {
            int count = 0;
            Int32 selectedCellCount =
            tableDelete.GetCellCount(DataGridViewElementStates.Selected);
            foreach (DataGridViewRow Row in tableDelete.Rows)
            {
                if (!(((DataGridViewCheckBoxCell)Row.Cells["checkBoxColumn"]).Value == null))
                {
                    count++;
                }
            }
            int i;

            //int total = tableDelete_DGV.Rows.Cast<DataGridViewRow>().Where(p => Convert.ToBoolean(p.Cells["Selected"].Value) == true).Count();
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");
            OleDbCommand command = new OleDbCommand();

            con.Open();
            if (count != 0)
            {
              //  try
              //  {

                    string[] IDS = new string[100];
                    String msg = "Are you sure you want to delete this record?";
                    String caption = "Delete Record";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    MessageBoxIcon ico = MessageBoxIcon.Question;
                    DialogResult result;
                    result = MessageBox.Show(this, msg, caption, buttons, ico);
                    if (result == DialogResult.Yes)
                    {
                        int val = 0;
                        bool check = true;


                        /*foreach (DataGridViewRow Row in tableDelete_DGV.Rows)
                        {

                                try
                                {
                                    val++;
                                    if(!(((DataGridViewCheckBoxCell)Row.Cells["checkBoxColumn"]).Value == null))
                                    {  //id.Add(tableDelete_DGV.Rows[Row.Index].Cells[1].Value);
                                        IDS[val] = CheckBox.Item
                                        tableDelete_DGV.Rows.RemoveAt(Row.Index); //not sure
                                        MessageBox.Show(IDS[val].ToString());
                            }
                                }
                                catch (Exception ex)
                                {
                                    check = false;
                                    MessageBox.Show(ex.ToString());
                                }

                        }*/

                        for (int u = tableDelete.RowCount - 1; u >= 0; u--)
                        {
                            DataGridViewRow row = tableDelete.Rows[u];

                            if (Convert.ToBoolean(row.Cells["checkBoxColumn"].Value) == true)
                            {
                                
                                command.CommandText = "DELETE FROM DutyTbl WHERE EmployeeID = '" + row.Cells[2].Value.ToString() + "' AND DutyDate = '"+ row.Cells[4].Value.ToString() + "'";
                                command.Connection = con;
                                command.ExecuteNonQuery();
                                tableDelete.Rows.RemoveAt(row.Index);

                        }
                            
                        }
                        if (check == true)
                        {
                            successDutydelete dutydelete = new successDutydelete();
                            dutydelete.Show();
                        }

                    }
                    else
                    {
                        return;
                    }

               // }
               /* catch (Exception ex)
                {
                    //MessageBox.Show("Deleting Failed:" + ex.Message.ToString(), "Delete",
                     //   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/

                con.Close();
            }
            else
            {
                MessageBox.Show(" Please select record you want to delete.");
            }


            con.Close();

        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // [!] Alvin = function for search bar pero kung gagamit ng function sa database just let me know

        }
        private void btn_one1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_one1_Click_1(object sender, EventArgs e)
        {
            //to uncheck all checked boxes
            foreach (DataGridViewRow Row in tableDelete.Rows)
                ((DataGridViewCheckBoxCell)Row.Cells["checkBoxColumn"]).Value = null;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (!(Search.Text == ""))
            {
                string alph = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";
                if (!(Search.Text.Contains(alph)))
                {
                    OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");

                    con.Open();
                    OleDbCommand cmd = new OleDbCommand("Select * from DutyTbl Where EmployeeID ='" + Search.Text + "'", con);
                    OleDbDataReader read = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(read);
                    tableDelete.DataSource = dt;

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

        private void searchbyyearmonth_Click(object sender, EventArgs e)
        {
         
        }

        private void reload_table_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");

            con.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from DutyTbl", con);
            OleDbDataReader read = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(read);
            if(Employee_Details.Employee_Database.DutyRecord() == 0)
            {
                noData.Visible = true;
            }

            tableDelete.DataSource = dt;
        }
    }
}
