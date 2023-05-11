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
            string sqlStr = string.Format("Insert into CreditCard(ExpirationDate,CreditLimit,MoneySpent,DateCreated,AccountNumber,CVVCode)values('{0}','{1}','{2}','{3}','{4}','{5}')", credit.Expirationdate, credit.Creditlimit, credit.Moneyspent, credit.Datecreated, credit.Accountnumber,credit.Cvvcode);
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
    }
}
