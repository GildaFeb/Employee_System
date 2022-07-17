using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Employee_Details
{
    internal class Employee_Database
    {
        // ======== EMPLOYEE PAGE ======= ITO ITO ITO
        public static bool AddEmployee(Employee employee)
        {
            
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "INSERT INTO EmployeeTbl(EmployeeID,Fname,Lname,Mname,Suffix,Date_joined,Birth,Sex,Address,Cnumber,Cemergency,Email,Designation,Regular_pay,Regular_worktime,Total_rpay) VALUES(@empID,@fname,@lname,@mname,@suffix,@date_joined,@birth,@sex,@address,@cnumber,@cemergency,@email,@position_emp,@reg_salary,@worktime,@total_salary)";
                cmd.Connection = con;

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
                cmd.Parameters.AddWithValue("@position_emp", employee.designation);
                cmd.Parameters.AddWithValue("@reg_salary", employee.regular_pay);
                cmd.Parameters.AddWithValue("@worktime", employee.regular_worktime);
                cmd.Parameters.AddWithValue("@total_salary", employee.total_salary); 


                cmd.ExecuteNonQuery();
                con.Close();
                return true;




        }
        public static bool UpdateEmployee(Employee employee)
        {
            OleDbConnection Con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");
            Con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "UPDATE EmployeeTbl SET EmployeeID=@empID,Fname=@fname,Mname=@mname,Lname=@lname,Suffix=@suffix,Date_joined=@date_joined,Birth=@birth,Sex=@sex,Address=@address,Cnumber=@cnumber,Cemergency=@cemergency,Email=@email,Designation=@designation,Regular_pay=@reg_salary,Regular_worktime=@worktime,Total_rpay=@total_salary WHERE EmployeeID=@empID";
            cmd.Connection = Con;
            OleDbDataReader read = cmd.ExecuteReader();
            bool check = false;
            while (read.Read())
            {
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
                cmd.Parameters.AddWithValue("@designation", employee.designation);
                cmd.Parameters.AddWithValue("@reg_salary", employee.regular_pay);
                cmd.Parameters.AddWithValue("@worktime", employee.regular_worktime);
                cmd.Parameters.AddWithValue("@total_salary", employee.total_salary);
                check = true;
            }
            if (check == false)
            {
                Con.Close();
                return false;
            }
            else
            {
                Con.Open();
                return true;
            }
        }
        public static Employee ShowEmployee(string ID)
        {
            OleDbCommand cmd = new OleDbCommand();
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");
            con.Open();
            cmd = new OleDbCommand("SELECT * FROM EmployeeTbl where EmployeeID='" + ID + "'");
            cmd.Connection = con;
            OleDbDataReader read = cmd.ExecuteReader();
            Employee employeeInfo = new Employee();
            while (read.Read())
            {
                employeeInfo.first_name = read.GetString(1);
                employeeInfo.middle_name = read.GetString(3);
                employeeInfo.last_name = read.GetString(2);
                employeeInfo.suffix = read.GetString(4);
                employeeInfo.hired_date = read.GetString(5);
                employeeInfo.birth_date = read.GetString(6); ;
                employeeInfo.sex = read.GetString(7);
                employeeInfo.address = read.GetString(8);
                employeeInfo.contact_number = read.GetString(9);
                employeeInfo.email = read.GetString(10);
                employeeInfo.emergency_contact_number = read.GetString(11);
                employeeInfo.designation = read.GetString(12);
                employeeInfo.regular_pay = read.GetString(13);
                employeeInfo.regular_worktime = read.GetString(14);
                employeeInfo.total_salary = read.GetString(15);
                
            }
                
            con.Close();
            return employeeInfo;
        }

        public static bool CheckEmployee(string ID)
        {
            OleDbCommand cmd = new OleDbCommand();
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");
            con.Open();
            cmd = new OleDbCommand("SELECT * FROM EmployeeTbl where EmployeeID='" + ID + "'");
            cmd.Connection = con;
            OleDbDataReader read = cmd.ExecuteReader();
            bool temp = false;
            Employee employeeInfo = new Employee();
            while (read.Read())
            {
                employeeInfo.first_name = read.GetString(1);
                employeeInfo.middle_name = read.GetString(2);
                employeeInfo.last_name = read.GetString(3);
                employeeInfo.suffix = read.GetString(4);
                employeeInfo.hired_date = read.GetString(5);
                employeeInfo.birth_date = read.GetString(6); ;
                employeeInfo.sex = read.GetString(7);
                employeeInfo.address = read.GetString(8);
                employeeInfo.contact_number = read.GetString(9);
                employeeInfo.email = read.GetString(10);
                employeeInfo.emergency_contact_number = read.GetString(11);
                employeeInfo.designation = read.GetString(12);
                employeeInfo.regular_pay = read.GetString(13);
                employeeInfo.regular_worktime = read.GetString(14);
                employeeInfo.total_salary = read.GetString(15);
                temp = true;
                
            }
            if (temp == false)
            {
                MessageBox.Show("Data not found.");
                con.Close();
                return false;
            }
            else
            {
                
                con.Close();
                return true;
            }
        }

        public static bool DeleteEmployee(string ID)
        {
            OleDbConnection con = new OleDbConnection(@"Data Source=|DataDiretory|\EmployeeTbl.mdf");

            string query = "Delete from data1 where ID= '" + ID + "'";
            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                MessageBox.Show("successfully data Deleted", "user information");
                while (reader.Read())
                {
                }
                con.Close();
                return true;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
                return false;
            }
        }


        // -------- END: EMPLOYEE PAGE --------

        // ======== DUTY DURATION PAGE / REPORT ATTENDACE =======

        public static void ShowEmployee_ByMonthYear()
        {

        }
        public static void ShowEmployee_ByName()
        {

        }
        public static void ShowEmployee_ByID()
        {

        }
        public static void ShowEmployee_Default()
        {

        }

        // ---------- END: DUTY DURATION PAGE / REPORT ATTENDACE -----

        // ======== DUTY DURATION PAGE  =======

        public static bool DeleteDuty()
        {
            MessageBox.Show("Show Employee");
            return true;
        }
        public static bool UpdateDuty()
        {
            MessageBox.Show("Delete Employee");
            return true;
        }
        public static void ShowDuty_ByName()
        {

        }
        public static void ShowDuty_ByID()
        {

        }

        // ------- END: DUTY DURATION PAGE  ------

        public static void ShowDuty_ByMonthYear()
        {

        }


    }

}
