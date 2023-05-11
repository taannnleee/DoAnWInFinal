using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnWinDows.BusinessLayer.Models;
using DoAnWinDows.DataAccessLayer;
using DoAnWinDows.Utilities;
using System.Data.SqlClient;

namespace DoAnWinDows.DataAccessObject
{
    public class CustomerAccountDAO
    {
        DBConnection dbconnect = new DBConnection();
        public DataTable DanhSachQuanLy()
        {
            string sqlStr = string.Format("Select LoginID, UserName,PassWord," +
                "AccountNumber,CustomerAccount.CustomerID ,AccountType ,Balance ,AccountStatus ,CreatedTime ,LastLoginTime," +
                "CustomerName,IdentityCard,Address ,PhoneNumber ,Gender ,Email From CustomerLogin,CustomerAccount, Customer WHere Customer.CustomerID = CustomerAccount.CustomerID AND Customer.CustomerID = CustomerLogin.LoginID AND CustomerAccount.CustomerID = CustomerLogin.LoginID");
            return dbconnect.DanhSach(sqlStr);
        }

        public bool Inserst(CustomerAccount account, Customer info)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnStr))
            {
                string accountInsertSql = string.Format("Insert into CustomerAccount(AccountNumber,CustomerID,AccountType,Balance,AccountStatus,CreatedTime,LastLoginTime)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", account.Accountnumber, account.Customerid, account.Accounttype, account.Balance, account.Accountstatus, account.Createdtime, account.Lastlogintime);
                string customerInsertSql = string.Format("Insert into Customer(CustomerID ,CustomerName,IdentityCard ,Address ,PhoneNumber,Gender ,Email )values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", info.Customerid, info.Customername, info.Identitycard, info.Address, info.Phonenumber, info.Gender, info.Email);
                string loginInsertSql = string.Format("Insert into CustomerLogin(LoginID,UserName, PassWord)values('{0}','{1}','{2}')", account.Loginid, account.Username, account.Password);
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    if(dbconnect.checkDataTransaction(accountInsertSql, transaction)&&
                    dbconnect.checkDataTransaction(customerInsertSql, transaction)&&
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

        public bool Delete(CustomerAccount account, Customer info)
        {

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnStr))
            {
                string accountDeleteSql = string.Format("DELETE FROM CustomerAccount WHERE CustomerID = '{0}'", account.Customerid);
                string customerDeleteSql = string.Format("DELETE FROM Customer WHERE CustomerID = '{0}'", info.Customerid);
                string loginDeleteSql = string.Format("DELETE FROM CustomerLogin WHERE LoginID = '{0}'", account.Loginid);
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    if (dbconnect.checkDataTransaction(accountDeleteSql, transaction) &&
                    dbconnect.checkDataTransaction(customerDeleteSql, transaction) &&
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

        public bool Edit(CustomerAccount account, Customer info)
        {
           
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnStr))
            {
                string accountEditSql = string.Format("UPDATE CustomerAccount SET AccountNumber = '{0}',AccountType = '{1}',Balance ='{2}',AccountStatus='{3}' where CustomerID='{4}'", account.Accountnumber, account.Accounttype, account.Balance, account.Accountstatus, account.Customerid);
                string customerEditSql = string.Format("UPDATE Customer SET CustomerName = '{0}',IdentityCard = '{1}',Address ='{2}',PhoneNumber='{3}',Gender='{4}',Email='{5}' where CustomerID='{6}'", info.Customername, info.Identitycard, info.Address, info.Phonenumber, info.Gender, info.Email, info.Customerid);
                string loginEditSql = string.Format("UPDATE CustomerLogin SET Username = '{0}',PassWord = '{1}' where LoginID='{2}'", account.Username, account.Password, account.Loginid);
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    if (dbconnect.checkDataTransaction(accountEditSql, transaction) &&
                    dbconnect.checkDataTransaction(customerEditSql, transaction) &&
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

        public DataTable Search(CustomerAccount account,Customer info)
        {
            string sqlStr = string.Format("Select LoginID, UserName,PassWord," +
                "AccountNumber,CustomerAccount.CustomerID ,AccountType ,Balance ,AccountStatus ,CreatedTime ,LastLoginTime," +
                "CustomerName,IdentityCard,Address ,PhoneNumber ,Gender ,Email From Login,CustomerAccount, Customer WHere Customer.CustomerID = CustomerAccount.CustomerID AND Customer.CustomerID = Login.LoginID AND CustomerAccount.CustomerID = Login.LoginID AND CustomerAccount.CustomerID = '{0}'", account.Customerid);
            return dbconnect.DanhSach(sqlStr);
        }

        public void Edit(CustomerAccount account)
        {
            string sqlStr = string.Format("UPDATE CustomerAccount SET CustomerID = '{0}',AccountType = '{1}',Balance ='{2}',AccountStatus='{3}' where AccountNumber='{4}'", account.Customerid, account.Accounttype, account.Balance, account.Accountstatus,account.Accountnumber);
            dbconnect.ThucThi(sqlStr);
        }

        public void LoadRowInAccountTable(DataGridView dgv, string[] columnNames, Dictionary<string, Control> textBoxMapping)
        {
            LoadRowData.LoadSelectedRowData(dgv, columnNames, textBoxMapping);
        }

        public bool IsIDExist(CustomerAccount account)
        {
            string sqlStr = string.Format("SELECT COUNT(*) FROM CustomerAccount  WHERE CustomerID = '{0}' ", account.Customerid);
            return dbconnect.IsExist(sqlStr);
        }

        public void TakeData(Customer cus, CustomerAccount acc)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnStr);
            string queryCus = string.Format("select * from Customer, CustomerLogin where Customer.CustomerID = CustomerLogin.LoginID and CustomerLogin.UserName = '{0}' and CustomerLogin.PassWord = '{1}'", acc.Username, acc.Password);
            conn.Open();
            SqlCommand cmd;
            cmd = new SqlCommand(queryCus, conn);
            SqlDataReader reader1 = cmd.ExecuteReader();
            while (reader1.Read())
            {
                cus.Customerid = reader1["CustomerID"].ToString();
                cus.Customername = reader1["CustomerName"].ToString();
                cus.Identitycard = reader1["IdentityCard"].ToString();
                cus.Address = reader1["Address"].ToString();
                cus.Phonenumber = reader1["PhoneNumber"].ToString();
                cus.Gender = reader1["Gender"].ToString();
                cus.Email = reader1["Email"].ToString();
            }
            conn.Close();

            conn.Open();
            string queryCusAcc = string.Format("select * from CustomerLogin, CustomerAccount where CustomerLogin.LoginID = cast(CustomerAccount.CustomerID as nvarchar(100)) and CustomerLogin.UserName = '{0}' and CustomerLogin.PassWord = '{1}'", acc.Username, acc.Password);
            cmd = new SqlCommand(queryCusAcc, conn);
            SqlDataReader reader2 = cmd.ExecuteReader();
            while (reader2.Read())
            {
                acc.Loginid = reader2["LoginID"].ToString();
                acc.Accountnumber = Convert.ToInt32(reader2["AccountNumber"]);
                acc.Customerid = reader2["CustomerID"].ToString();
                acc.Accounttype = reader2["AccountType"].ToString();
                acc.Balance = reader2["Balance"].ToString();
                acc.Accountstatus = reader2["AccountStatus"].ToString();
                acc.Createdtime = Convert.ToDateTime(reader2["CreatedTime"]);
                acc.Lastlogintime = Convert.ToDateTime(reader2["LastLoginTime"]);
            }
            conn.Close();
        }
    }
}
