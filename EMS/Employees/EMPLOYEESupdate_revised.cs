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
    public partial class EMPLOYEESupdate_revised : UserControl
    {
        public EMPLOYEESupdate_revised()
        {
            InitializeComponent();

            last_name.MaxLength = 50;
            first_name.MaxLength = 50;
            middle_name.MaxLength = 50;
            position.MaxLength = 50;
            email.MaxLength = 50;
            address.MaxLength = 50;
            contact_number.MaxLength = 15;
            cnumber_emergency.MaxLength = 15;

            hired_date.MaxDate = DateTime.Now;
            birth.MaxDate = DateTime.Now;

            regular_pay.MaxLength = 6;
            regular_worktime.MaxLength = 4;
        }

        private void btn_one3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(last_name.Text) || string.IsNullOrWhiteSpace(first_name.Text))
            {
                errorEMPadd errorEMPadd = new errorEMPadd();
                errorEMPadd.Show();
                return;
            }
            
            verificationEmpUpdate verificationEmpUpdate = new verificationEmpUpdate();
            verificationEmpUpdate.Show();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            employee_id.Clear();
            last_name.Clear();
            first_name.Clear();
            middle_name.Clear();
            suffix.SelectedItem = null;
            position.SelectedItem = null;
            regular_pay.SelectedItem = null;
            regular_worktime.SelectedItem = null;
            total_rpay.Clear();
            sex.SelectedItem = null;
            hired_date.Value = DateTime.Today;
            address.Clear();
            contact_number.Clear();
            email.Clear();
            cnumber_emergency.Clear();
            birth.Value = DateTime.Today;
        }

        private void suffix_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void birth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void hired_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void regular_pay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void regular_worktime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
