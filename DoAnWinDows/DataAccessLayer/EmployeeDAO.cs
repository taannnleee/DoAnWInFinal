using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnWinDows.BusinessLayer.Models;
using DoAnWinDows.DataAccessLayer;
using DoAnWinDows.Utilities;

namespace DoAnWinDows.DataAccessObject
{
    public class EmployeeDao
    {
        DBConnection dbconnect = new DBConnection();
        public DataTable DanhSachQuanLy()
        {
            string sqlStr = string.Format("Select LoginID, UserName,PassWord," +
               "EmployeeAccount.EmployeeID ,AccountType ,AccountStatus ,CreatedTime ,LastLoginTime," +
               "EmployeeName,IdentityCard,Address ,PhoneNumber,Position,Salary ,Gender ,Email,DateOfBirth From EmployeeLogin,EmployeeAccount, EmployeeInformation WHere EmployeeInformation.EmployeeID = EmployeeAccount.EmployeeID AND EmployeeInformation.EmployeeID = EmployeeLogin.LoginID AND EmployeeAccount.EmployeeID = EmployeeLogin.LoginID");
            return dbconnect.DanhSach(sqlStr);
        }

        public bool Them(EmployeeAccount empAcc,Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnStr))
            {
                string accountInsertSql = string.Format("Insert into EmployeeAccount(EmployeeID,AccountType,AccountStatus,CreatedTime,LastLoginTime)values('{0}','{1}','{2}','{3}','{4}')", employee.Employeeid, empAcc.Accounttype, empAcc.Accountstatus, empAcc.Createdtime, empAcc.Lastlogintime);
                string employeeInsertSql = string.Format("Insert into EmployeeInformation(EmployeeID ,EmployeeName,IdentityCard ,Address ,PhoneNumber,Gender ,Email,Position,Salary,DateOfBirth )values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", employee.Employeeid, employee.Employeename, employee.Identitycard, employee.Address, employee.Phonenumber, employee.Gender, employee.Email,employee.Position,employee.Salary,employee.Dateofbirth);
                string loginInsertSql = string.Format("Insert into EmployeeLogin(LoginID,UserName, PassWord)values('{0}','{1}','{2}')", empAcc.Loginid, empAcc.Username, empAcc.Password);
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    if (dbconnect.checkDataTransaction(accountInsertSql, transaction) &&
                    dbconnect.checkDataTransaction(employeeInsertSql, transaction) &&
                    dbconnect.checkDataTransaction(loginInsertSql, transaction))
                    {
                        transaction.Commit();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine("Error occurred: " + ex.Message);
                    return false;
                }
                return false;
            }
        }

        public bool Xoa(EmployeeAccount empAcc, Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnStr))
            {
                string accountDeleteSql = string.Format("DELETE FROM EmployeeAccount WHERE EmployeeID = '{0}'", empAcc.Employeeid);
                string employeeDeleteSql = string.Format("DELETE FROM EmployeeInformation WHERE EmployeeID = '{0}'", employee.Employeeid);
                string loginDeleteSql = string.Format("DELETE FROM EmployeeLogin WHERE LoginID = '{0}'", empAcc.Loginid);
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    if (dbconnect.checkDataTransaction(accountDeleteSql, transaction) &&
                    dbconnect.checkDataTransaction(employeeDeleteSql, transaction) &&
                    dbconnect.checkDataTransaction(loginDeleteSql, transaction))
                    {
                        transaction.Commit();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine("Error occurred: " + ex.Message);
                    return false;
                }
                return false;
            }
        }

        public bool Sua(EmployeeAccount empAcc, Employee employee)
        {

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnStr))
            {
                string accountEditSql = string.Format("UPDATE EmployeeAccount SET AccountType = '{0}',AccountStatus='{1}' where EmployeeID='{2}'", empAcc.Accounttype, empAcc.Accountstatus, empAcc.Employeeid);
                string employeeEditSql = string.Format("UPDATE EmployeeInformation  SET EmployeeName = '{0}',IdentityCard = '{1}',Address ='{2}',PhoneNumber='{3}',Gender='{4}',Email='{5}',Position='{6}',Salary='{7}', DateOfBirth='{8}' where EmployeeID='{9}'", employee.Employeename, employee.Identitycard, employee.Address, employee.Phonenumber, employee.Gender, employee.Email,employee.Position,employee.Salary,employee.Dateofbirth ,employee.Employeeid);
                string loginEditSql = string.Format("UPDATE EmployeeLogin SET Username = '{0}',PassWord = '{1}' where LoginID='{2}'", empAcc.Username, empAcc.Password, empAcc.Loginid);
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    if (dbconnect.checkDataTransaction(accountEditSql, transaction) &&
                    dbconnect.checkDataTransaction(employeeEditSql, transaction) &&
                    dbconnect.checkDataTransaction(loginEditSql, transaction))
                    {
                        transaction.Commit();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine("Error occurred: " + ex.Message);
                    return false;
                }
                return false;
            }
        }
        
        public void LoadRowInEmployeeTable(DataGridView dgv, string[] columnNames, Dictionary<string, Control> textBoxMapping)
        {
            LoadRowData.LoadSelectedRowData(dgv, columnNames, textBoxMapping);
        }

        public bool IsIDExist(EmployeeAccount empAcc)
        {
            string sqlStr = string.Format("SELECT COUNT(*) FROM EmployeeAccount  WHERE EmployeeID = '{0}' ", empAcc.Employeeid);
            return dbconnect.IsExist(sqlStr);
        }

        public void SearchCustomer(Customer cus, CustomerAccount acc, Control txt)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnStr);
            conn.Open();
            string query = string.Format("select * from Customer, CustomerAccount where Customer.CustomerID = CustomerAccount.CustomerID and CustomerAccount.AccountNumber = {0}", Convert.ToInt32(txt.Text));
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cus.Customerid = reader["CustomerID"].ToString();
                cus.Customername = reader["CustomerName"].ToString();
                cus.Identitycard = reader["IdentityCard"].ToString();
                cus.Address = reader["Address"].ToString();
                cus.Phonenumber = reader["PhoneNumber"].ToString();
                cus.Gender = reader["Gender"].ToString();
                cus.Email = reader["Email"].ToString();
              
                acc.Accountnumber = Convert.ToInt32(reader["AccountNumber"]);
                acc.Customerid = reader["CustomerID"].ToString();
                acc.Accounttype = reader["AccountType"].ToString();
                acc.Balance = reader["Balance"].ToString();
                acc.Accountstatus = reader["AccountStatus"].ToString();
                acc.Createdtime = Convert.ToDateTime(reader["CreatedTime"]);
                acc.Lastlogintime = Convert.ToDateTime(reader["LastLoginTime"]);
            }
            conn.Close();
        }
    }
}
