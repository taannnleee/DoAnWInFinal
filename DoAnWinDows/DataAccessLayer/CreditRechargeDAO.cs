using DoAnWinDows.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnWinDows.DataAccessLayer;
using System.Data.SqlClient;
using DoAnWinDows.Utilities;

namespace DoAnWinDows.DataAccessLayer
{
    public class CreditRechargeDAO
    {
        DBConnection dbconnect = new DBConnection();
        public DataTable DebtCheck(CreditCard credit)
        {
            string sqlStr = string.Format("Select * From CreditCard Where CVVCode ='{0}' ", credit.Cvvcode);
            return dbconnect.DanhSach(sqlStr);
        }

        public DataTable DebtDetails(CreditCard credit)
        {
            string sqlStr = string.Format("Select * From CreditDetails Where CVVCode ='{0}' ", credit.Cvvcode);
            return dbconnect.DanhSach(sqlStr);
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

        public bool creditRecharge(CreditCard credit, CustomerAccount cussacc)
        {
            //string sqlCreditCard = string.Format("UPDATE CreditCard SET MoneySpent = CAST(MoneySpent AS int) - {0} WHERE CVVCode = '{1}'", int.Parse(credit.Moneyspent),credit.Cvvcode);
            string sqlCreditCard = string.Format("UPDATE CreditCard SET MoneySpent = '0' WHERE CVVCode = '{0}'", credit.Cvvcode);
            string customerAccount = string.Format("UPDATE CustomerAccount SET Balance = CAST(Balance AS int) - {0} WHERE AccountNumber = '{1}'", int.Parse(credit.Moneyspent), credit.Accountnumber);
                string creditDetails = string.Format("DELETE FROM CreditDetails WHERE CVVCode= '{0}'", credit.Cvvcode);
                try
                {
                    if (dbconnect.ThucThi(sqlCreditCard) && dbconnect.ThucThi(customerAccount) && dbconnect.ThucThi(creditDetails))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error occurred: " + ex.Message);
                    return false;
                }
                return false;
            
        }

        public void LoadRowInCreditCardTable(DataGridView dgv, string[] columnNames, Dictionary<string, Control> textBoxMapping)
        {
            LoadRowData.LoadSelectedRowData(dgv, columnNames, textBoxMapping);
        }
    }
}
