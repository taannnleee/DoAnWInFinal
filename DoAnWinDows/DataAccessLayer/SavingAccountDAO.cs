using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnWinDows.BusinessLayer.Models;
using DoAnWinDows.DataAccessLayer;
using DoAnWinDows.Utilities;
using Microsoft.VisualBasic;
using System.Data.SqlClient;

namespace DoAnWinDows.DataAccessObject
{
    public class SavingAccountDAO
    {
        DBConnection dbconnect = new DBConnection();
        public DataTable ListBankPassBook()
        {
            string sqlStr = string.Format("Select SA.SavingAccountID,SA.CustomerID,SA.Balance,SA.InterestRate,SA.CreatedDate,SA.RenewalOption,CA.AccountNumber,SA.DueDate From SavingAccount SA LEFT JOIN CustomerAccount CA ON SA.CustomerID=CA.CustomerID");
            return dbconnect.DanhSach(sqlStr);
        }

        public void Them(SavingAccount savingAccount)
        {
            string sql = string.Format("UPDATE CustomerAccount SET Balance = Balance - {0} WHERE CustomerID = '{1}'", savingAccount.Balance, savingAccount.Customerid);
            dbconnect.ThucThi(sql);
            string sqlStr = string.Format("Insert into SavingAccount(CustomerID,Balance,InterestRate,CreatedDate,RenewalOption,DueDate)values('{0}','{1}','{2}','{3}','{4}','{5}')", savingAccount.Customerid,savingAccount.Balance,savingAccount.Interestrate,savingAccount.Createddate,savingAccount.Renewaloption,savingAccount.Duedate);
            dbconnect.ThucThi(sqlStr);
        }

        public void TatToan(SavingAccount savingAccount)
        {
            string sql = string.Format("UPDATE CustomerAccount SET Balance = Balance + {0} WHERE CustomerID = '{1}'", savingAccount.Balance, savingAccount.Customerid);
            dbconnect.ThucThi(sql);
            string sqlStr = string.Format("DELETE FROM SavingAccount WHERE SavingAccountID = {0}", savingAccount.Savingaccountid);
            dbconnect.ThucThi(sqlStr);
        }
        public void GiaHanGoc(SavingAccount savingAccount,float interestAmount)
        {
            string sql = string.Format("UPDATE CustomerAccount SET Balance = Balance + {0} WHERE CustomerID = '{1}'", interestAmount, savingAccount.Customerid);
            dbconnect.ThucThi(sql);
            string sqlStr = string.Format("UPDATE SavingAccount SET CreatedDate = '{0}',DueDate='{1}' WHERE SavingAccountID = {2} ", savingAccount.Createddate,savingAccount.Duedate,savingAccount.Savingaccountid );
            dbconnect.ThucThi(sqlStr);
        }

        public void Sua(SavingAccount savingAccount)
        {
            string sqlStr = string.Format("UPDATE SavingAccount SET CustomerID = '{0}',Balance = '{1}',InterestRate='{2}',CreatedDate='{3}',RenewalOption='{4}',DueDate='{5}' WHERE SavingAccountID = {6} ", savingAccount.Customerid, savingAccount.Balance, savingAccount.Interestrate, savingAccount.Createddate, savingAccount.Renewaloption, savingAccount.Duedate,savingAccount.Savingaccountid );
            dbconnect.ThucThi(sqlStr);
        }
        public DataTable Search(string AccountNumber)
        {
            string sqlStr = string.Format("Select SA.SavingAccountID,SA.CustomerID,SA.Balance,SA.InterestRate,SA.CreatedDate,SA.RenewalOption,CA.AccountNumber,SA.DueDate From SavingAccount SA LEFT JOIN CustomerAccount CA ON SA.CustomerID=CA.CustomerID WHERE CA.AccountNumber = '{0}'", AccountNumber);
            return dbconnect.DanhSach(sqlStr);
        }
        public void LoadRowInBankSavingsTable(DataGridView dgv, string[] columnNames, Dictionary<string, Control> textBoxMapping)
        {
            LoadRowData.LoadSelectedRowData(dgv, columnNames, textBoxMapping);
        }
        public bool Check(SavingAccount savingAccount)
        {
            string sqlStr = string.Format("SELECT CASE WHEN COUNT(*) > 0 THEN 1 ELSE 0 END AS result FROM Customer WHERE CustomerID = '{0}'", savingAccount.Customerid);
            return dbconnect.IsExist(sqlStr);
        }
        public List<SavingAccount> GetSavingsAccounts()
        {
            // Khởi tạo danh sách tài khoản tiết kiệm
            List<SavingAccount> savingsAccounts = new List<SavingAccount>();

            // Kết nối tới cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnStr))
            {
                // Mở kết nối
                connection.Open();

                // Chuẩn bị câu lệnh truy vấn
                string query = "SELECT * FROM SavingAccount";

                // Tạo đối tượng SqlCommand
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thực thi truy vấn và đọc dữ liệu
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Lấy thông tin tài khoản từ bản ghi đọc được
                            int id = (int)reader["SavingAccountID"];
                            string customerid = reader["CustomerID"].ToString();
                            string balance = reader["Balance"].ToString();
                            float interestRate = (float)(decimal)reader["InterestRate"];
                            DateTime createddate = (DateTime)reader["CreatedDate"];
                            string renewaloption = reader["RenewalOption"].ToString();
                            DateTime duedate = (DateTime)reader["DueDate"];

                            // Tạo đối tượng SavingsAccount và thêm vào danh sách
                            SavingAccount account = new SavingAccount(id,customerid,balance,interestRate,createddate,renewaloption,duedate);
                            savingsAccounts.Add(account);
                        }
                    }
                }
            }
            return savingsAccounts;
        }
    }
}
