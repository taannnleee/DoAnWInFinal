using DoAnWinDows.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnWinDows.DataAccessLayer;
using DoAnWinDows.Utilities;
using System.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace DoAnWinDows.DataAccessLayer
{
    public class PayByCreditDAO
    {
        DBConnection dbconnect = new DBConnection();

        public DataTable DanhSachQuanLy( string cvvcode)
        {
            string sqlStr = string.Format("Select ID,TransactionDate,TransactionAmount,Description From CreditDetails where CVVCode ='{0}'", cvvcode);
            return dbconnect.DanhSach(sqlStr);
        }

        public bool creditPayment(CreditCard credit,string money)
        {
            string sqlCreditCard = string.Format("UPDATE CreditCard SET MoneySpent = CAST(MoneySpent AS int) + {0}  WHERE CvvCode = '{1}'", Convert.ToInt32(money),credit.Cvvcode);
            return dbconnect.ThucThi(sqlCreditCard);
        }

        public bool creditCardPaymentDetails(CreditDetails crdDetails)
        {
            string sqlCreditCard = string.Format("Insert into CreditDetails(CVVCode,TransactionDate,TransactionAmount,Description)values('{0}','{1}','{2}','{3}')", crdDetails.CvvCode, crdDetails.Transactiondate, crdDetails.TransactionAmount, crdDetails.Description);
            return dbconnect.ThucThi(sqlCreditCard);
        }

        public CreditCard GetDataCredit(string cvvcode)
        {
            String sqlQuery = String.Format("SELECT * FROM CreditCard WHERE CVVCode = '{0}'", cvvcode);
            SqlDataReader reader = dbconnect.GetDataReader(sqlQuery);
            CreditCard credit = new CreditCard();
            if (reader != null && reader.HasRows)
            {
                reader.Read();
                credit.Moneyspent = reader["MoneySpent"].ToString();
                credit.Creditlimit = reader["CreditLimit"].ToString();
            }
            reader.Close();
            return credit;
        }
    }
}
