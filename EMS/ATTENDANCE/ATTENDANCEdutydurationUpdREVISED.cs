﻿using System;
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
    public partial class ATTENDANCEdutydurationUpdREVISED : UserControl
    {
        public ATTENDANCEdutydurationUpdREVISED()
        {
            InitializeComponent();
        }

        private void UpdLblOvertime_Click(object sender, EventArgs e)
        {

        }

        private void UpdEmpOvertime_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdSave_Click(object sender, EventArgs e)
        {
            verificationAttenUpdate verificationAttenUpdate = new verificationAttenUpdate();
            verificationAttenUpdate.Show();
        }

        private void UpdTimePickerIn_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UpdLlblTimeIn_Click(object sender, EventArgs e)
        {

        }
    }
}