using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Employee_Details
{
    public class Employee
    {
        // HELLO THEREEEEE!
        public int employeeID { get; set; }
        public string last_name { get; set; }
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public string birth_date { get; set; }
        public string suffix { get; set; }
        public string sex { get; set; }
        public string address { get; set; }
        public string contact_number { get; set; }
        public string emergency_contact_number { get; set; }
        public string position { get; set; }
        public string regular_pay { get; set; }
        public string email { get; set; }
        public string hired_date { get; set; }
        public string regular_worktime { get; set; }
        public string total_salary { get; set; }

    }

    public class Duty_Temporaru
    {
        public string dutyID { get; set; }
        public string timeIn { get; set; }
        public string timeOut { get; set; }
        public string overtime { get; set; }
        public string duration { get; set; }
        public string date { get; set; }
    }

    public class Submitted_Duty
    {
        public string dutyID { get; set; }
        public string timeIn { get; set; }
        public string timeOut { get; set; }
        public string overtime { get; set; }
        public string duration { get; set; }
        public string date { get; set; }
    }
}
