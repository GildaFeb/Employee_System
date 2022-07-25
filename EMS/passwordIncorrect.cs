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
    public partial class passwordIncorrect : Form
    {
        public passwordIncorrect()
        {
            InitializeComponent();
        }

        private void okayBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
