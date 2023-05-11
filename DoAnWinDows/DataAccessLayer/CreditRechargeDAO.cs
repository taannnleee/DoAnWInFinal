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

        public bool creditRecharge(CreditCard credit, int accNumber, DateTime currentime)
        {
            
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnStr))
            {
                string sqlCreditCard = string.Format("UPDATE CreditCard SET MoneySpent = CAST(MoneySpent AS float) - {0}, ExpirationDate ='{1}' WHERE CVVCode = '{2}'", float.Parse(credit.Moneyspent),currentime ,credit.Cvvcode);
                string customerAccount = string.Format("UPDATE CustomerAccount SET Balance = CAST(Balance AS float) - {0} WHERE AccountNumber = '{1}'", float.Parse(credit.Moneyspent), accNumber);
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    if (dbconnect.checkDataTransaction(customerAccount, transaction) &&
                    dbconnect.checkDataTransaction(sqlCreditCard, transaction))
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

        public void LoadRowInCreditCardTable(DataGridView dgv, string[] columnNames, Dictionary<string, Control> textBoxMapping)
        {
            LoadRowData.LoadSelectedRowData(dgv, columnNames, textBoxMapping);
        }
    }
}
