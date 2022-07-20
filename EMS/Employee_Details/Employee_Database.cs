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

        // ======================== DASHBOARD ========================

        public static int EmployeeNum()
        {
            /* OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");

             con.Open();
             OleDbCommand cmd = new OleDbCommand("SELECT COUNT(*) FROM EmployeeTbl", con);
             cmd.ExecuteReader();
             int count = cmd.ExecuteScalar().ToString();
             con.Close();
             return count;*/
            int count = 0;
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");

            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM EmployeeTbl", con);
            OleDbDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                count++;
            }
            con.Close();
            return count;
        }

        public static int ProjectNumCount()
        {
            int count = 0;
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");

            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM EmployeeTbl WHERE Designation = 'Project Manager'", con);
            OleDbDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                count++;
            }
            con.Close();
            return count;
        }

        public static int AdministratorCount()
        {
            int count = 0;
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");

            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM EmployeeTbl WHERE Designation = 'Administrator'", con);
            OleDbDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                count++;
            }
            con.Close();
            return count;
        }
        public static int SoftwareEngCount()
        {
            int count = 0;
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");

            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM EmployeeTbl WHERE Designation = 'Software Engineer'", con);
            OleDbDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                count++;
            }
            con.Close();
            return count;
        }
        public static int FullStackDevCount()
        {
            int count = 0;
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");

            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM EmployeeTbl WHERE Designation = 'Fullstack Developer'", con);
            OleDbDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                count++;
            }
            con.Close();
            return count;
        }






        // =================================== EMPLOYEE PAGE ======================= 

        public static bool AddEmployee(Employee employee)
        {

            try
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
            catch (Exception ex)
            {
                errorEMPadd error = new errorEMPadd();
                error.Show();
                return false;
            
            }
                
        }
        public static bool UpdateEmployee(Employee employee)
        {
           
               
            try
            {
                OleDbConnection Con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");
                Con.Open();
                OleDbCommand cmd = new OleDbCommand("UPDATE EmployeeTbl SET Fname='" + employee.first_name + "',Lname='" + employee.last_name + "',Mname='" + employee.middle_name + "',Suffix='" + employee.suffix + "',Date_joined='" + employee.hired_date + "',Birth='" + employee.birth_date + "',Sex='" + employee.sex + "',Address='" + employee.address + "',Cnumber='" + employee.contact_number + "',Cemergency='" + employee.emergency_contact_number+ "',Email='" + employee.email + "',Designation='" + employee.designation + "',Regular_pay='" + employee.regular_pay + "',Regular_worktime='" + employee.regular_worktime + "', Total_rpay='" + employee.total_salary + "'  WHERE EmployeeID='" + employee.employeeID + "'", Con);

                /*cmd.Parameters.AddWithValue("@empID", employee.employeeID);
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
                cmd.Parameters.AddWithValue("@total_salary", employee.total_salary);*/
                
                cmd.ExecuteNonQuery();
                Con.Close();
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
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
            int check = 0;
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

                check++;
            }
            
            if(check == 0)
            {
                MessageBox.Show("This ID number is not registered."); // no design
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
            int check = 0;
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
                check++;
                
            }
            if (check == 0)
            {
                MessageBox.Show("This ID number is not registered.");
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
                con.Close();
                return false;
            }
        }


        // -------- END: EMPLOYEE PAGE --------

        // ========================= REPORT ATTENDACE ========================

        public static void ShowEmployee_ByMonthYear()
        {

        }
        public static void ShowEmployee_ByID()
        {

        }
        public static void ShowEmployee_Default()
        {

        }

        // ---------- END: REPORT ATTENDACE -----






        // ======================== DUTY DURATION PAGE  ==================
        public static int DutyRecord()
        {
            int count = 0;
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");

            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM DutyTbl", con);
            OleDbDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                count++;
            }
            con.Close();
            return count;
        }


        public static bool UpdateDuty()
        {
            MessageBox.Show("Delete Employee");
            return true;
        }

        public static bool ShowDuty_ByIDandDate(string ID, string date)
        {
            int count = 0;
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");

            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM DutyTbl WHERE EmployeeID = '"+ID+"' AND DutyDate ='"+date+"'", con);
            OleDbDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                count++;
            }
            if(count == 0)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }

           
        }


        public static bool UpdatePendingDuty(Duty_Pending duty_Pending)
        {


            try
            {
                OleDbConnection Con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");
                Con.Open();
                OleDbCommand cmd = new OleDbCommand("UPDATE DutyTable SET Status='" + duty_Pending.status + "',TimeIn='" + duty_Pending.timeIn + "',TimeOut='" + duty_Pending.timeOut + "',Duration='" + duty_Pending.duration + "',Overtime='" + duty_Pending.overtime + "', WHERE EmployeeID='" + duty_Pending.EmployeeID + "', AND DutyDate= '" + duty_Pending.duty_date + "'", Con);


                cmd.ExecuteNonQuery();
                Con.Close();
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

                return false;
            }
        }

        public static bool AddDuty(Duty_Pending duty_Pending)
        {

            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "INSERT INTO DutyTbl (EmployeeID,Fullname,DutyDate,Status,TimeIn,TimeOut,Duration,Overtime) VALUES(@empID,@fullname,@dutydate,@status,@timein,@timeout,@duration,@overtime)";
                cmd.Connection = con;

                cmd.Parameters.AddWithValue("@empID", duty_Pending.EmployeeID);
                cmd.Parameters.AddWithValue("@fullname", duty_Pending.Fullname);
                cmd.Parameters.AddWithValue("@dutydate", duty_Pending.duty_date);
                cmd.Parameters.AddWithValue("@status", duty_Pending.status);
                cmd.Parameters.AddWithValue("@timein", duty_Pending.timeIn);
                cmd.Parameters.AddWithValue("@timeout", duty_Pending.timeOut);
                cmd.Parameters.AddWithValue("@duration", duty_Pending.duration);
                cmd.Parameters.AddWithValue("@overtime", duty_Pending.overtime);


                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                errorEMPadd error = new errorEMPadd();
                error.Show();

                return false;

            }
        }

        // ------- END: DUTY DURATION PAGE  ------




        // ===================== ATTENDANCE REPORT ===================



        public static bool SubmitReport(Report report)
        {

            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "INSERT INTO Report(EmployeeID,Fullname,Designation,Date of Duty,Present,Absent,Leave,Overtime,Overtime Pay,Total Regular Worktime,Total Salary) VALUES(@empID,@emp,@desig,@dduty,@pres,@abs,@leave,@overtime,@o_pay,@worked_hrs,@salary)";
                cmd.Connection = con;

                cmd.Parameters.AddWithValue("@empID", report.EmployeeID);
                cmd.Parameters.AddWithValue("@emp", report.Fullname  );
                cmd.Parameters.AddWithValue("@design", report.Designation);
                cmd.Parameters.AddWithValue("@dduty", report.DutyDate);
                cmd.Parameters.AddWithValue("@pres", report.Present);
                cmd.Parameters.AddWithValue("@abs", report.Abesent);
                cmd.Parameters.AddWithValue("@leave", report.Leave);
                cmd.Parameters.AddWithValue("@overtime", report.Overtime);
                cmd.Parameters.AddWithValue("@o_pay", report.Overtime_Pay);
                cmd.Parameters.AddWithValue("@worked_hrs", report.worked_hrs);
                cmd.Parameters.AddWithValue("@salary", report.total_salary);


                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                errorEMPadd error = new errorEMPadd();
                error.Show();
                return false;

            }

        }




        public static Report ShowRecordBy_MonthAndYear(string date)
        {


            OleDbCommand cmd = new OleDbCommand();
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");
            con.Open();
            cmd = new OleDbCommand("SELECT * Report WHERE Date of Duty LIKE='%" + date + "%'");
            cmd.Connection = con;
            OleDbDataReader read = cmd.ExecuteReader();
            Report report = new Report();
            int check = 0;
            while (read.Read())
            {
                report.EmployeeID = read.GetString(1);
                report.Fullname = read.GetString(3);
                report.Designation = read.GetString(2);
                report.DutyDate = read.GetString(4);
                report.Present = read.GetString(5);
                report.Abesent = read.GetString(6); ;
                report.Leave = read.GetString(7);
                report.Overtime = read.GetString(8);
                report.Overtime_Pay = read.GetString(9);
                report.worked_hrs = read.GetString(10);
                report.total_salary= read.GetString(11);

                check++;
            }

            if (check == 0)
            {
                MessageBox.Show("Record not found."); // no design

            }
            con.Close();
            return report;
        }

        public static Report ShowReportByID(string id)
        {


            OleDbCommand cmd = new OleDbCommand();
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");
            con.Open();
            cmd = new OleDbCommand("SELECT * Report WHERE EmployeeID ='" + id + "'");
            cmd.Connection = con;
            OleDbDataReader read = cmd.ExecuteReader();
            Report report = new Report();
            int check = 0;
            while (read.Read())
            {
                report.EmployeeID = read.GetString(1);
                report.Fullname = read.GetString(3);
                report.Designation = read.GetString(2);
                report.DutyDate = read.GetString(4);
                report.Present = read.GetString(5);
                report.Abesent = read.GetString(6); ;
                report.Leave = read.GetString(7);
                report.Overtime = read.GetString(8);
                report.Overtime_Pay = read.GetString(9);
                report.worked_hrs = read.GetString(10);
                report.total_salary = read.GetString(11);

                check++;
            }

            if (check == 0)
            {
                MessageBox.Show("Record not found."); // no design
            }
            con.Close();
            return report;
        }
    }

}
