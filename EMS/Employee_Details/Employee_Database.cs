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
        public static bool UpdateEmployee(Employee employee)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=|DataDiretory|\EmployeeTbl.mdf");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Employee SET Fname= @fname ,Lname= @lname,Mname=@mname, Suffix=@suffix, Date_joined=@date_joined," +
                " Birth=@birth, Sex=@sex, Address=@address, Cnumber=@cnumber, Cemergency=@cemergency, email=@email, Position=@position, Regular_pay=@red_salary, Regular_worktime=@worktime, " +
                "Total_rpay=@total_salary WHERE EmployeeID = @empID";
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

            return true;
        }
        public Employee ShowEmployee(int ID)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection con = new SqlConnection(@"Data Source=|DataDiretory|\EmployeeTbl.mdf");
            MessageBox.Show("Show Employee");
            con.Open();
            cmd = new SqlCommand("SELECT * FROM Employee where EmployeeID=" + ID);
            cmd.Connection = con;
            SqlDataReader read = cmd.ExecuteReader();
            bool temp = false;
            Employee employeeInfo = new Employee();
            while (read.Read())
            {
                employeeInfo.first_name = read.GetString(1);
                employeeInfo.last_name = read.GetString(2);
                employeeInfo.middle_name = read.GetString(3);
                employeeInfo.hired_date = read.GetString(4);
                employeeInfo.birth_date = read.GetString(5); ;
                employeeInfo.sex = read.GetString(6);
                employeeInfo.address = read.GetString(7);
                employeeInfo.contact_number = read.GetString(8);
                employeeInfo.email = read.GetString(9);
                employeeInfo.emergency_contact_number = read.GetString(10);
                employeeInfo.position = read.GetString(11);
                employeeInfo.regular_pay = read.GetString(12);
                employeeInfo.regular_worktime = read.GetString(13);
                employeeInfo.total_salary = read.GetString(14);
                temp = true;
            }
            if (temp == false)
                MessageBox.Show("Data not found.");
            con.Close();
            return employeeInfo;
        }
        public static bool DeleteEmployee(int ID)
        {
            SqlConnection con = new SqlConnection(@"Data Source=|DataDiretory|\EmployeeTbl.mdf");

            string query = "Delete from data1 where ID= '" + ID + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                MessageBox.Show("successfully data Deleted", "user information");
                while (myreader.Read())
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

        // ------- END: DUTY DURATION PAGE  ------



    }

}
