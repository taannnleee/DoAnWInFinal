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

namespace DoAnWinDows.DataAccessLayer
{
    public class PayByCreditDAO
    {
        DBConnection dbconnect = new DBConnection();

        public bool creditPayment(CreditCard credit,string money)
        {
            string sqlCreditCard = string.Format("UPDATE CreditCard SET MoneySpent = CAST(MoneySpent AS int) + {0}  WHERE CvvCode = '{1}'", Convert.ToInt32(money),credit.Cvvcode);
            return dbconnect.ThucThi(sqlCreditCard);
        }
    }
}
