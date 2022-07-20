using Microsoft.Data.SqlClient;
using System;
using System.Collections;
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
    public partial class EMPLOYEESdelete : UserControl
    {
        
        public EMPLOYEESdelete()
        {
            InitializeComponent();
            tableDelete_DGV.ForeColor = Color.Black;
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = " Select ";
            checkBoxColumn.Width = 100;
            checkBoxColumn.Name = "checkBoxColumn";
            tableDelete_DGV.Columns.Insert(0, checkBoxColumn);




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        
        private void EMPLOYEESdelete_Load(object sender, EventArgs e)
        {
            deleteDataGridView();
            visualsDatagridview();
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");

            con.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from EmployeeTbl", con);
            OleDbDataReader read = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(read);
            tableDelete_DGV.DataSource = dt;
        }

        //
        void deleteDataGridView()
        {
            /*  UNNECESSARY, 'WAG IDELETE
             *  
             *  tableDelete_DGV.Rows.Add("tacv", 'b', 4, "male");
                tableDelete_DGV.Rows.Add("amazing", 'b', 4, "male");
                tableDelete_DGV.Rows.Add("code", 'b', 4, "male");
                tableDelete_DGV.Rows.Add("verse", 'b', 4, "male");
                tableDelete_DGV.Rows.Add("whatever", 'b', 4, "female"); 
    
                tableDelete_DGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing; //optional
                tableDelete_DGV.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(62, 113, 201);
                tableDelete_DGV.RowHeadersDefaultCellStyle.SelectionForeColor = Color.White;    */
        }

        void visualsDatagridview()
        {
            // UNNECESSARY, 'WAG IDELETE
          
            //tableDelete_DGV.AlternatingRowsDefaultCellStyle.BackColor = Color.Blue; //Color.FromArgb(238, 239, 249);
            //tableDelete_DGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tableDelete_DGV.DefaultCellStyle.SelectionBackColor = Color.FromArgb(202, 63, 63);
            //tableDelete_DGV.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            tableDelete_DGV.BackgroundColor = Color.White;
            //tableDelete_DGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            tableDelete_DGV.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(62, 113, 201);
            tableDelete_DGV.RowHeadersDefaultCellStyle.SelectionForeColor = Color.White;

            tableDelete_DGV.EnableHeadersVisualStyles = false;
            tableDelete_DGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //tableDelete_DGV.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);      
            tableDelete_DGV.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(63, 113, 202);
            tableDelete_DGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void db_ViewCalendarBtn_Click(object sender, EventArgs e)
        {

        }

        private void btn_one2_Click(object sender, EventArgs e)
        {
            verificationEmpDelete verificationEmpDelete = new verificationEmpDelete();
            verificationEmpDelete.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            /* untested, no data ∴ returns null
            (tableDelete_DGV.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format("employee_id" + Search.Text);
            */

            if (!(Search.Text == ""))
            {
                string alph = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";
                if (!(Search.Text.Contains(alph)))
                {
                    OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");

                    con.Open();
                    OleDbCommand cmd = new OleDbCommand("Select * from EmployeeTbl Where EmployeeID ='" + Search.Text + "'", con);
                    OleDbDataReader read = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(read);
                    tableDelete_DGV.DataSource = dt;
                    
                }
                else
                {
                    MessageBox.Show("Error. Employee ID not found.");
                }

            }
            else
            {
                MessageBox.Show(" Failed to search. Search field is empty.");
            }
        }

        private void btn_one3_Click(object sender, EventArgs e)
        {
            int count = 0;
            Int32 selectedCellCount =
            tableDelete_DGV.GetCellCount(DataGridViewElementStates.Selected);
            foreach (DataGridViewRow Row in tableDelete_DGV.Rows)
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

            /*
            if(total > 0)
            {
                string message = $"Are you sure you want to delete {total} rows?";
                if (total > 1)
                {
                    message = $"Are you sure you want to delete {total} rows?";
                    if(MessageBox.Show(message, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        for(int i = tableDelete_DGV.RowCount - 1; i >= 0; i--)
                        {
                            DataGridViewRow row = tableDelete_DGV.Rows[i];
                            if (Convert.ToBoolean(row.Cells["Selected"].Value)== true)
                            {
                                command.CommandText = "DELETE FROM EmployeeTbl WHERE EmployeeID= '" + row.Cells[1].Value.ToString() + "'";
                                command.Connection = con;

                                command.ExecuteNonQuery();
                            }

                        
                            

                        }
                    }

                }

            } */
            if (count != 0)
            {
                try
                {
                    
                    string[] IDS = new string[100];
                    String msg = "Are you sure you want to delete the employee/s you selected?";
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

                        for (int u = tableDelete_DGV.RowCount - 1; u >= 0; u--)
                        {
                            DataGridViewRow row = tableDelete_DGV.Rows[u];

                            if (Convert.ToBoolean(row.Cells["checkBoxColumn"].Value) == true)
                            {

                                command.CommandText = "DELETE FROM EmployeeTbl WHERE EmployeeID= '" + row.Cells[1].Value.ToString() + "'";
                                command.Connection = con;
                                command.ExecuteNonQuery();
                                tableDelete_DGV.Rows.RemoveAt(row.Index);
                            }




                        }
                        /*

                        for (int x = 1; x < IDS.Length; x++)
                        {
                            
                            command.CommandText = "DELETE FROM EmployeeTbl WHERE EmployeeID= '" + IDS[x].ToString() + "'";
                            command.Connection = con;

                            command.ExecuteNonQuery();

                            MessageBox.Show(IDS[x].ToString());
                        }*/
                        
                        if (check == true)
                            {
                            
                            successEMPdelete successEMPdelete = new successEMPdelete();
                            successEMPdelete.ShowDialog();
                            }
                        
                    }
                    else
                    {
                        return;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Deleting Failed:" + ex.Message.ToString(), "Delete",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
           /* else if (tableDelete_DGV.SelectedCells.Count != 0)
            {
                foreach (DataGridViewRow Row in tableDelete_DGV.Rows)
                {
                    if (!(((DataGridViewCheckBoxCell)Row.Cells["checkBoxColumn"]).Value == null))
                    {
                        delcmd.CommandText = "DELETE FROM EmployeeTbl WHERE EmployeeID='" + tableDelete_DGV.SelectedRows[Row.Index].Cells[0].Value.ToString() + "'";
                     
                        delcmd.Connection = con;
                        delcmd.ExecuteNonQuery();
                        
                        tableDelete_DGV.Rows.RemoveAt(tableDelete_DGV.SelectedRows[Row.Index].Index);
                        
                    }
                    
                }
                
            } */


            else
            {
                MessageBox.Show(" Please select record you want to delete.");
            }


            con.Close();

            

        }

        private void btn_one1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Row in tableDelete_DGV.Rows)
                ((DataGridViewCheckBoxCell)Row.Cells["checkBoxColumn"]).Value = null;
        }

        private void btn_one2_Click_1(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");

            con.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from EmployeeTbl", con);
            OleDbDataReader read = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(read);
            tableDelete_DGV.DataSource = dt;
        }

        private void tableDelete_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableDelete_DGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
// ETOOOO
