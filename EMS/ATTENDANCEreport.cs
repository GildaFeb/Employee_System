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
    public partial class ATTENDANCEreport : UserControl
    {
        public ATTENDANCEreport()
        {
            InitializeComponent();
        }

        private void attndncrprt_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ATTENDANCEreport_Load(object sender, EventArgs e)
        {
            for (int i = 1995; i <= 2022; i++)
            {
                ComboYear.Items.Add(i);
            }
        }
    }
}
