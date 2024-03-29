﻿using EMS.ATTENDANCE;
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
        public static int onLeaveReportCount(string date)
        {
            int count = 0;
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");

            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM HistoryTbl WHERE Status = 'Leave' AND DutyDate = '"+date+"'", con);
            OleDbDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                count++;
            }
            con.Close();
            return count;
        }
        public static int onLeavePendingCount(string date)
        {
            int count = 0;
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");

            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM DutyTbl WHERE Status = 'Leave' AND DutyDate = '" + date + "'", con);
            OleDbDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                count++;
            }
            con.Close();
            return count;
        }
        public static int totalRecordsCount()
        {
            int count = 0;
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");

            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM HistoryTbl", con);
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
            catch
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
                DataNotFound notFound = new DataNotFound();
                notFound.Show();
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
                DataNotFound notFound = new DataNotFound();
                notFound.Show();
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
            //try
            //{
                OleDbConnection Con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");
                Con.Open();
                OleDbCommand cmd = new OleDbCommand("UPDATE DutyTbl SET Status='" + duty_Pending.status + "',TimeIn='" + duty_Pending.timeIn + "',TimeOut='" + duty_Pending.timeOut + "',Duration='" + duty_Pending.duration + "',Overtime='" + duty_Pending.overtime + "' WHERE EmployeeID='" + duty_Pending.EmployeeID + "' AND DutyDate= '" + duty_Pending.duty_date + "'", Con);

                cmd.ExecuteNonQuery();
                Con.Close();
                return true;
            /*}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }*/
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
            catch
            {
                errorEMPadd error = new errorEMPadd();
                error.Show();

                return false;

            }
        }

        public static bool AddHistory(Duty_Pending duty_Pending)
        {

            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "INSERT INTO HistoryTbl (EmployeeID,Fullname,DutyDate,Status,TimeIn,TimeOut,Duration,Overtime) VALUES(@empID,@fullname,@dutydate,@status,@timein,@timeout,@duration,@overtime)";
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
            catch
            {
                errorEMPadd error = new errorEMPadd();
                error.Show();

                return false;

            }
        }


        public static Duty_Pending ShowAttendance(string ID, string date)
        {


            OleDbCommand cmd = new OleDbCommand();
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");
            con.Open();
            cmd = new OleDbCommand("SELECT * FROM DutyTbl where EmployeeID='" + ID + "' AND DutyDate = '" + date + "'");
            cmd.Connection = con;
            OleDbDataReader read = cmd.ExecuteReader();
            Duty_Pending pending = new Duty_Pending();
            int check = 0;
            while (read.Read())
            {
                pending.Fullname = read.GetString(2);

                pending.status = read.GetString(4);
                pending.timeIn = read.GetString(5);
                pending.timeOut = read.GetString(6);
                pending.duration = read.GetString(7);
                pending.overtime = read.GetString(8);
                check++;
            }

            con.Close();
            return pending;

        }








            // ------- END: DUTY DURATION PAGE  ------




            // ===================== ATTENDANCE REPORT ===================



            public static bool SubmitReport(Report report)
        {
            int check = 0;
           // try
            //{
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");
                con.Open();
                OleDbCommand cmd = new OleDbCommand();

                

                // worktime
                //string worktime = ShowEmployee(report.EmployeeID).regular_worktime;

                // regular pay
                int reg_pay = int.Parse(ShowEmployee(report.EmployeeID).regular_pay); // regular pay

                // getting total duration
                int new_duration = int.Parse(report.worked_hrs);
                

                // getting total overtime
                int new_ot = int.Parse(report.Overtime);
                
                // dif
                int lapse = new_duration - new_ot;

                if (getReport(report.EmployeeID, report.DutyDate.ToString()) == 0)
                {
                    check = 1;
                    if (report.Status == "Present")
                    {
                        double new_ot_pay = new_ot * (reg_pay * 1.5);
                        int ot_pay = (int)new_ot_pay;
                        int worked_pay = lapse * reg_pay;
                        int total = worked_pay + ot_pay;
                      //cmd.CommandText = "INSERT INTO ReportTbl(EmployeeID,Fullname,Designation,DutyDate,Present,Overtime,Overtime Pay,Worked Hours,Total Salary) VALUES(@empID,@emp,@desig,@dduty,1,@overtime,@o_pay,@worked_hrs,@salary)";
                      
                        cmd.CommandText = "INSERT INTO ReportTbl(EmployeeID,Fullname,Designation,DutyDate,Present,Overtime,Overtime_Pay,Worked_Hours,Total_Salary) VALUES(@empID,@emp,@desig,@dduty,1,@overtime,@o_pay,@worked_hrs,@salary)";
                        cmd.Connection = con;

                        cmd.Parameters.AddWithValue("@empID", report.EmployeeID);
                        cmd.Parameters.AddWithValue("@emp", report.Fullname);
                        cmd.Parameters.AddWithValue("@desig", ShowEmployee(report.EmployeeID).designation);
                        cmd.Parameters.AddWithValue("@dduty", report.DutyDate);
                        cmd.Parameters.AddWithValue("@overtime", new_ot);
                        cmd.Parameters.AddWithValue("@o_pay", ot_pay);
                        cmd.Parameters.AddWithValue("@worked_hrs", new_duration);
                        cmd.Parameters.AddWithValue("@salary", total);
                        cmd.ExecuteNonQuery();

                    }
                    else if (report.Status == "Absent")
                    {
                       
                        cmd.CommandText = "INSERT INTO ReportTbl(EmployeeID,Fullname,Designation,DutyDate,Absent) VALUES(@empID,@emp,@desig,@dduty,@abs)";
                        cmd.Connection = con;

                        cmd.Parameters.AddWithValue("@empID", report.EmployeeID);
                        cmd.Parameters.AddWithValue("@emp", report.Fullname);
                        cmd.Parameters.AddWithValue("@desig", ShowEmployee(report.EmployeeID).designation);
                        cmd.Parameters.AddWithValue("@dduty", report.DutyDate);
                        cmd.Parameters.AddWithValue("@abs", 1);
                        cmd.ExecuteNonQuery();

                    }
                    else if (report.Status == "Leave")
                    {

                        cmd.CommandText = "INSERT INTO ReportTbl(EmployeeID,Fullname,Designation,DutyDate,Leave) VALUES(@empID,@emp,@desig,@dduty,@leave)";
                        cmd.Connection = con;

                        cmd.Parameters.AddWithValue("@empID", report.EmployeeID);
                        cmd.Parameters.AddWithValue("@emp", report.Fullname);
                        cmd.Parameters.AddWithValue("@desig", ShowEmployee(report.EmployeeID).designation);
                        cmd.Parameters.AddWithValue("@dduty", report.DutyDate);
                        cmd.Parameters.AddWithValue("@leave", 1);
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                check = 2;
                    
                    if (report.Status == "Present")
                    {
                        int total_duration = getDuration(report.EmployeeID, report.DutyDate, new_duration);
                        int OT = getOvertime(report.EmployeeID, report.DutyDate, new_ot);
                        // getting total overtime pay
                        double _ot_multiplier = 1.5;
                        double overtime_pay = OT * _ot_multiplier;
                        int OT_pay = (int)overtime_pay;

                        // regular worktime * reg pay
                        int regular_worktime = total_duration - OT;
                        int regular_salary = regular_worktime * reg_pay;


                        // getting total salary
                        int total_salary = OT_pay + regular_salary;
                        int submittedRecord = getPresent(report.DutyDate, report.EmployeeID);
                        int totalPresent = 1 + submittedRecord;
                        //WHERE EmployeeID='" + employee.employeeID + "'"
                        cmd.CommandText = "UPDATE ReportTbl SET Present = '" + totalPresent + "', Overtime = '"+OT+"', Overtime_Pay = '"+OT_pay+"', Worked_Hours = '"+total_duration+"', Total_Salary = '"+total_salary+"' WHERE EmployeeID = '"+report.EmployeeID+ "' AND DutyDate= '"+report.DutyDate+"'";
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();

                    }
                    else if (report.Status == "Absent")
                    {
                        int submittedRecord = getAbsent(report.DutyDate, report.EmployeeID);
                        int totalAbsent = 1 + submittedRecord;
                        cmd.CommandText = "UPDATE ReportTbl SET Absent = '" + totalAbsent + "' WHERE EmployeeID = '" + report.EmployeeID + "' AND DutyDate= '" + report.DutyDate + "'";
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();

                    }
                    else if (report.Status == "Leave")
                    {
                        int submittedRecord = getLeave(report.DutyDate, report.EmployeeID);
                        int totalLeave = 1 + submittedRecord;
                        cmd.CommandText = "UPDATE ReportTbl SET Absent = '" + totalLeave + "' WHERE EmployeeID = '" + report.EmployeeID + "' AND DutyDate= '" + report.DutyDate + "'";
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();
                    }
                }

                con.Close();
                return true;
           /* }
            catch 
            {
                errorEMPadd error = new errorEMPadd();
                error.Show();
                return false;

            }
           */
        }



        // [!] not used
        public static Report ShowRecordBy_MonthAndYear(string date)
        {


            OleDbCommand cmd = new OleDbCommand();
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");
            con.Open();
            cmd = new OleDbCommand("SELECT * ReportTbl WHERE DutyDate LIKE='%" + date + "%'");
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
                report.Absent = read.GetString(6); ;
                report.Leave = read.GetString(7);
                report.Overtime = read.GetString(8);
                report.Overtime_Pay = read.GetString(9);
                report.worked_hrs = read.GetString(10);
                report.total_salary= read.GetString(11);

                check++;
            }

            if (check == 0)
            {
                DataNotFound notFound = new DataNotFound();
                notFound.Show();

            }
            con.Close();
            return report;
        }

        // [!] not used
        public static Report ShowReportByID(string id)
        {


            OleDbCommand cmd = new OleDbCommand();
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");
            con.Open();
            cmd = new OleDbCommand("SELECT * ReportTbl WHERE EmployeeID ='" + id + "'");
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
                report.Absent = read.GetString(6); ;
                report.Leave = read.GetString(7);
                report.Overtime = read.GetString(8);
                report.Overtime_Pay = read.GetString(9);
                report.worked_hrs = read.GetString(10);
                report.total_salary = read.GetString(11);

                check++;
            }

            if (check == 0)
            {
                DataNotFound notFound = new DataNotFound();
                notFound.Show();
            }
            con.Close();
            return report;
        }


        public static int CountRecords()
        {


            OleDbCommand cmd = new OleDbCommand();
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");
            con.Open();
            cmd = new OleDbCommand("SELECT * FROM ReportTbl");
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
                report.Absent = read.GetString(6); ;
                report.Leave = read.GetString(7);
                report.Overtime = read.GetString(8);
                report.Overtime_Pay = read.GetString(9);
                report.worked_hrs = read.GetString(10);
                report.total_salary = read.GetString(11);

                check++;
            }

            if (check == 0)
            {
                DataNotFound notFound = new DataNotFound();
                notFound.Show();
                con.Close();
                return check;
            }
            con.Close();
            return check;
        }




        // GET PRESENT, ABSENT AND LEAVE 


        public static int getPresent(string MonthYear, string ID)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");
          
            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM ReportTbl WHERE EmployeeID = '" + ID + "' AND DutyDate = '" + MonthYear + "'", con);
            OleDbDataReader read = cmd.ExecuteReader();
            int present = 0;
            if (read.Read())
            {

                present = read.GetInt32(5);

            }
            return present;
            


        }

        public static int getAbsent(string MonthYear, string ID)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");

            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM ReportTbl WHERE EmployeeID = '" + ID + "' AND DutyDate = '" + MonthYear + "'", con);
            OleDbDataReader read = cmd.ExecuteReader();
            int absent = 0;
            if (read.Read())
            {

                absent = read.GetInt32(6);

            }
            return absent;

        }

        public static int getLeave(string MonthYear, string ID)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");

            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM ReportTbl WHERE EmployeeID = '" + ID + "' AND DutyDate = '" + MonthYear + "'", con);
            OleDbDataReader read = cmd.ExecuteReader();
            int leave = 0;
            if (read.Read())
            {

                leave = read.GetInt32(7);

            }
            return leave;

        }

        public static int getOvertime(string ID, string date, int OT)
        {
            int check = 0;
            //string recordedOvertime;
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");

            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM ReportTbl WHERE EmployeeID = '" + ID+ "' AND DutyDate = '" + date+"'", con);

            OleDbDataReader read = cmd.ExecuteReader();

            if (read.Read())
            {
                int overtime;
                overtime = read.GetInt32(8);
                OT += overtime;
                check++;
               
            }
            
            if (check == 0)
            {
                return OT;
            }
            else
            {
                return OT;
            }
               

        }

        // get duration

        public static int getDuration(string ID, string date, int worked_hrs)
        {
            int count = 0;
            int duration = 0;
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");

            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM ReportTbl WHERE EmployeeID = '" + ID + "' AND DutyDate = '" + date + "'", con);
            OleDbDataReader read = cmd.ExecuteReader();

            if (read.Read())
            {
                duration = read.GetInt32(10);
                worked_hrs += duration;
                count++;

            }

            if (count == 0)
            {
                return worked_hrs;
            }
            else
            {
                return worked_hrs;
            }
        }



        // check report


        public static int getReport(string ID, string date)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");

            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM ReportTbl WHERE EmployeeID  = '" + ID + "' AND DutyDate = '" + date + "'", con);
            OleDbDataReader read = cmd.ExecuteReader();
            if(read.HasRows)
            {
                return 1;
            }
            else
                return 0; 
        }


        // check history

        public static int checkHistory(string ID, string date)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EMSDb.accdb;Persist Security Info=True");

            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM HistoryTbl WHERE EmployeeID  = '" + ID + "' AND DutyDate = '" + date + "'", con);
            OleDbDataReader read = cmd.ExecuteReader();
            if (read.HasRows)
            {
                return 1;
            }
            else
                return 0;
        }



    }

}
