using Microsoft.Data.SqlClient;
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
    public partial class EMPLOYEESdelete : UserControl
    {
        public EMPLOYEESdelete()
        {
            InitializeComponent();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void EMPLOYEESdelete_Load(object sender, EventArgs e)
        {
            deleteDataGridView();
            visualsDatagridview();
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
                double outputValue = 0;
                bool isNumber = false;

                isNumber = double.TryParse(Search.Text, out outputValue);
                if (!isNumber)
                {
                    // search through ID
                }
                else if (isNumber)
                {
                    // search through lastname
                }
                else
                {
                    MessageBox.Show("Error. Enter ID or Name.");
                }
            }
            else
            {
                MessageBox.Show(" Failed to search. Search field is empty.");
            }
        }

        private void btn_one3_Click(object sender, EventArgs e)
        {

            Int32 selectedRowCount = tableDelete_DGV.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                try
                {

                    String msg = "Are you sure you want to delete the employee/s you selected?";
                    String caption = "Delete Record";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    MessageBoxIcon ico = MessageBoxIcon.Question;
                    DialogResult result;
                    result = MessageBox.Show(this, msg, caption, buttons, ico);
                    if (result == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow item in this.tableDelete_DGV.SelectedRows)
                        {
                            using (SqlConnection con = new SqlConnection(@"Data Source=|DataDiretory|\EmployeeTbl.mdf"))
                            {
                                SqlCommand cmd = con.CreateCommand();
                                int id = Convert.ToInt32(tableDelete_DGV.SelectedRows[0].Cells[0].Value);
                                cmd.CommandText = "Delete from Lot_Numbers where ID='" + id + "'";

                                tableDelete_DGV.Rows.RemoveAt(this.tableDelete_DGV.SelectedRows[0].Index);
                                con.Open();
                                cmd.ExecuteNonQuery();

                            }

                        }
                        successEMPdelete successEMPdelete = new successEMPdelete();
                        successEMPdelete.ShowDialog();
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
            else
            {
                MessageBox.Show(" Please select record you want to delete.");
            }


            
        }

        private void btn_one1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Row in tableDelete_DGV.Rows)
                ((DataGridViewCheckBoxCell)Row.Cells["delete_ChckBx"]).Value = null;
        }
    }
}
