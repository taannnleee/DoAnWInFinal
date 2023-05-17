using DoAnWinDows.BusinessLayer.Models;
using DoAnWinDows.Utilities;
//using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAnWinDows.DataAccessLayer
{
    public class CreditCardDAO
    {
        DBConnection dbconnect = new DBConnection();
        public DataTable DanhSachQuanLy()
        {
            string sqlStr = string.Format("Select * From CreditCard");
            return dbconnect.DanhSach(sqlStr);
        }

        public bool Them(CreditCard credit)
        {
            string sqlStr = string.Format("Insert into CreditCard(ExpirationDate,CreditLimit,MoneySpent,DateCreated,AccountNumber,CVVCode,CreditCardStatus)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", credit.Expirationdate, credit.Creditlimit, credit.Moneyspent, credit.Datecreated, credit.Accountnumber, credit.Cvvcode, credit.CreditCardStatus);
            return dbconnect.ThucThi(sqlStr);
        }

        public bool IsCreditAccountExists(CustomerAccount customerAccount)
        {
            string sqlStr = string.Format("SELECT COUNT(*) FROM CustomerLogin WHERE UserName = '{0}'And PassWord = '{1}'", customerAccount.Username, customerAccount.Password);
            return dbconnect.IsExist(sqlStr);
        }

        public bool IsCvvtExists(string cvv)
        {
            string sqlStr = string.Format("SELECT COUNT(*) FROM CreditCard WHERE CVVCode = '{0}'", cvv);
            return dbconnect.IsExist(sqlStr);
        }

        public SqlDataReader GetDataDefaultAccount(string user, string pass)
        {
            String sqlQuery = String.Format("Select * From CustomerLogin,CustomerAccount, Customer WHere Customer.CustomerID = CustomerAccount.CustomerID AND Customer.CustomerID = CustomerLogin.LoginID AND CustomerAccount.CustomerID = CustomerLogin.LoginID AND Username ='{0}' AND PassWord = '{1}' ", user, pass);
            SqlDataReader reader = dbconnect.GetDataReader(sqlQuery);
            if (reader != null && reader.HasRows)
            {
                reader.Read();
            }
            return reader;
        }

        public SqlDataReader GetDataCredit(int accNumber)
        {
            String sqlQuery = String.Format("Select * From CustomerAccount Where CustomerAccount.AccountNumber ={0}", accNumber);
            SqlDataReader reader = dbconnect.GetDataReader(sqlQuery);
            if (reader != null && reader.HasRows)
            {
                reader.Read();
            }
            return reader;
        }

        public List<CreditCard> GetExpirationDate()
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnStr);
            conn.Open();
            DateTime today = DateTime.Now;
            List<CreditCard> lcreditcard = new List<CreditCard>();
            String sqlQuery = String.Format("SELECT * FROM CreditCard WHERE DATEDIFF(day, ExpirationDate, @Today) > 30");
            SqlCommand cmd = new SqlCommand(sqlQuery, conn);
            cmd.Parameters.AddWithValue("@Today", today);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                CreditCard credit = new CreditCard();
                credit.Expirationdate = Convert.ToDateTime(reader["ExpirationDate"]);
                credit.Cvvcode = reader["CVVCode"].ToString();
                lcreditcard.Add(credit);
            }

            reader.Close();
            return lcreditcard;
        }

        public void UpdateExpirationDate(string cvvcode, string status)
        {
            string sqlreditdetails = string.Format("UPDATE CreditCard SET CreditCardStatus = '{0}' WHERE CVVCode='{1}'", status, cvvcode);
            dbconnect.ThucThi(sqlreditdetails);
        }

        public CreditCard GetData(string cvvcode)
        {
            String sqlQuery = String.Format("Select * From CreditCard Where CVVCode ='{0}'", cvvcode);
            SqlDataReader reader = dbconnect.GetDataReader(sqlQuery);
            CreditCard credit = new CreditCard();
            if (reader != null && reader.HasRows)
            {
                reader.Read();
                credit.Moneyspent = reader["MoneySpent"].ToString();
                credit.Accountnumber = Convert.ToInt32(reader["AccountNumber"]);
                credit.Cvvcode = reader["CVVCode"].ToString();
                credit.CreditCardStatus = reader["CreditCardStatus"].ToString();
            }
            reader.Close();
            return credit;
        }

        public CustomerAccount GetCusData(string acountnumber)
        {
            String sqlQuery = String.Format("Select * From CustomerAccount Where AccountNumber ='{0}'", acountnumber);
            SqlDataReader reader = dbconnect.GetDataReader(sqlQuery);
            CustomerAccount cusacc = new CustomerAccount();
            if (reader != null && reader.HasRows)
            {
                reader.Read();
                cusacc.Balance = reader["Balance"].ToString();
            }
            reader.Close();
            return cusacc;
        }
    }
}
