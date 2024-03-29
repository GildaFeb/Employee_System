﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Employee_Details
{
    public class Employee
    {
        // HELLO THEREEEEE!
        public string employeeID { get; set; }
        public string last_name { get; set; }
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public string birth_date { get; set; }
        public string suffix { get; set; }
        public string sex { get; set; }
        public string address { get; set; }
        public string contact_number { get; set; }
        public string emergency_contact_number { get; set; }
        public string designation { get; set; }
        public string regular_pay { get; set; }
        public string email { get; set; }
        public string hired_date { get; set; }
        public string regular_worktime { get; set; }
        public string total_salary { get; set; }

    }

    public class Duty_Pending
    {
        public string dutyID { get; set; }
        public string EmployeeID { get; set; }
        public string Fullname { get; set; }
        public string status { get; set; }
        public string timeIn { get; set; }
        public string timeOut { get; set; }
        public string duration { get; set; }
        public string duty_date { get; set; }
        public string overtime { get; set; }
    }

    public class Report
    {
        public string ReportID { get; set; }
        public string EmployeeID { get; set; }
        public string Fullname { get; set; }
        public string Designation { get; set; }
        public string DutyDate { get; set; }
        public string Status { get; set; }
        public string Overtime { get; set; }
        public string Overtime_Pay { get; set; }
        public string worked_hrs { get; set; }
        public string total_salary { get; set; }
        public string Absent { get; set; }
        public string Present { get; set; }
        public string Leave { get; set; }
    }
}
