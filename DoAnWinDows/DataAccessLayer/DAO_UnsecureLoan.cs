using DoAnWinDows.BusinessLayer.Models;
using Guna.UI2.AnimatorNS;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWinDows.DataAccessLayer
{
    internal static class DAO_UnsecureLoan
    {
        static DBConnection db = new DBConnection();

        public static void Add(UnsecureLoan_CustomerAccount unsecure_acc)
        {
            try
            {
                string query = string.Format("insert into UnsecureLoan(LoanID, AccountNumber, CustomerName, LoanAmount, LoanPeriod, LoanPayable, LoanStatus, StartLoan, EndLoan) values ({0}, {1}, '{2}', '{3}', {4}, '{5}', '{6}', '{7}', '{8}')", unsecure_acc.LoanID, unsecure_acc.AccountNumber, unsecure_acc.CustomerName, unsecure_acc.LoanAmount, unsecure_acc.LoanPeriod, unsecure_acc.LoanPayable, unsecure_acc.LoanStatus, unsecure_acc.StartLoan, unsecure_acc.EndLoan);
                db.ThucThi(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static DataTable ShowUnsecureLoanAccount()
        {
            return db.DanhSach("select * from UnsecureLoan");
        }

        public static DataTable Search(string textbox)
        {
            return db.DanhSach("select * from UnsecureLoan where AccountNumber = " + textbox);
        }

        public static DataTable Show_Unsecure_BlackList()
        {
            DateTime date_time = DateTime.Now;
            string format_datetime = date_time.ToString("dd/MM/yyyy");
            return db.DanhSach(string.Format("SELECT * FROM UnsecureLoan WHERE EndLoan < '{0}'", format_datetime));
        }

        public static bool IDisExisted(TextBox txt)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnStr);
            conn.Open();
            string query = string.Format("select count(*) from UnsecureLoan where LoanID = {0}", txt.Text);
            SqlCommand command = new SqlCommand(query, conn);
            int count = (int)command.ExecuteScalar();
            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            conn.Close();
        }
    }
}
