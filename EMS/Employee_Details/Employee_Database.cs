using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Employee_Details
{
    internal class Employee_Database
    {
        // ======== EMPLOYEE PAGE =======
        public static bool AddEmployee(Employee employee)
        {
            try
            {
                SqlConnection Con = new SqlConnection(@"Data Source=|DataDiretory|\EmployeeTbl.mdf");


                MessageBox.Show("Add Employee");
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO Employee(EmployeeID, Fname,Lname,Mname, Suffix, Date_joined," +
                    " Birth, Sex, Address, Cnumber, Cemergency, email, Position, Regular_pay, Regular_worktime, " +
                    "Total_rpay) VALUES(@empID, @fname,@lname,@mname, @suffix, @date_joined," +
                    "@birth,@sex, @address, @cnumber,@cemergency, @email, @position, @reg_salary, @worktime,@total_salary )";
                cmd.Connection = Con;

                cmd.Parameters.AddWithValue("@empID", employee.employeeID);
                cmd.Parameters.AddWithValue("@fname", employee.first_name);
                cmd.Parameters.AddWithValue("@lname", employee.last_name);
                cmd.Parameters.AddWithValue("@mname", employee.middle_name);
                cmd.Parameters.AddWithValue("@suffix", employee.suffix);
                cmd.Parameters.AddWithValue("@date_joined", employee.hired_date);
                cmd.Parameters.AddWithValue("@birth", employee.birth_date);
                cmd.Parameters.AddWithValue("@sex", employee.sex);
                cmd.Parameters.AddWithValue("@address", employee.address);
                cmd.Parameters.AddWithValue("@cnumber", employee.contact_number);
                cmd.Parameters.AddWithValue("@cemergency", employee.emergency_contact_number);
                cmd.Parameters.AddWithValue("@email", employee.email);
                cmd.Parameters.AddWithValue("@position", employee.position);
                cmd.Parameters.AddWithValue("@reg_salary", employee.regular_pay);
                cmd.Parameters.AddWithValue("@worktime", employee.regular_worktime);
                cmd.Parameters.AddWithValue("@total_salary", employee.total_salary);


                cmd.ExecuteNonQuery();
                Con.Close();
                return true;

            }
            catch
            {
                return false;
            }
            

           
        }
        public static bool UpdateEmployee()
        {
            MessageBox.Show("Update Employee");
            return true;
        }
        public static bool ShowEmployee()
        {
            MessageBox.Show("Show Employee");
            return true;
        }
        public static bool DeleteEmployee()
        {
            MessageBox.Show("Delete Employee");
            return true;
        }

        // ======== EMPLOYEE PAGE =======

    }

}
