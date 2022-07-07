using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Employee_Details
{
    internal class Employee_Database
    {
      //  SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gilda\OneDrive\Documents\EmployeeDB.mdf;Integrated Security=True;Connect Timeout=30");


        public static bool AddEmployee()
        {
/*
            MessageBox.Show("Add Employee");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Employee(EmployeeID, Fname,Lname,Mname, Date_joined, Birth, Sex, Address, Cnumber, email) VALUES(@empID, @fname,@lname,@mname,@date_joined,@birth,@sex, @address, @cnumber, @email)";
            cmd.Connection = Con;

            cmd.Parameters.AddWithValue("@empID", employee_id.Text);
            cmd.Parameters.AddWithValue("@fname", first_name.Text);
            cmd.Parameters.AddWithValue("@lname", last_name.Text);
            cmd.Parameters.AddWithValue("@mname", middle_name.Text);
            cmd.Parameters.AddWithValue("@date_joined", hired_date.Value.Date);
            cmd.Parameters.AddWithValue("@birth", birth.Value.Date);
            cmd.Parameters.AddWithValue("@sex", sex.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@address", address.Text);
            cmd.Parameters.AddWithValue("@cnumber", contact_number.Text);
            cmd.Parameters.AddWithValue("@email", email.Text);

            cmd.ExecuteNonQuery();
            Con.Close();
*/
            return true;
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
    }
    
}
