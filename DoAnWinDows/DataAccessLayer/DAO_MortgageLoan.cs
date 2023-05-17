using DoAnWinDows.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DoAnWinDows.DataAccessLayer
{
    internal class DAO_MortgageLoan
    {
        static DBConnection db = new DBConnection();

        public static void Add(MortgageLoan_CustomerAccount mortgage_acc)
        {
            try
            {
                string query = string.Format("insert into MortgageLoan(LoanID, AccountNumber, CustomerName, LoanAmount, LoanPeriod, Collateral, LoanPayable, LoanStatus, StartLoan, EndLoan) values ({0}, {1}, '{2}', '{3}', {4}, '{5}', '{6}', '{7}', '{8}', '{9}')", mortgage_acc.LoanID, mortgage_acc.AccountNumber, mortgage_acc.CustomerName, mortgage_acc.LoanAmount, mortgage_acc.LoanPeriod, mortgage_acc.Collateral, mortgage_acc.LoanPayable, mortgage_acc.LoanStatus, mortgage_acc.StartLoan, mortgage_acc.EndLoan);
                db.ThucThi(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static DataTable ShowMortgageLoanAccount()
        {
            return db.DanhSach("select * from MortgageLoan");
        }

        public static DataTable Search(string textbox)
        {
            return db.DanhSach("select * from MortgageLoan where AccountNumber = " + textbox);
        }

        public static DataTable Show_Mortgage_BlackList()
        {
            DateTime current = DateTime.Now;
            string format_datetime_current = current.ToString("MM/dd/yyyy");
            return db.DanhSach(string.Format("SELECT * FROM MortgageLoan WHERE EndLoan < '{0}'", format_datetime_current));
        }

        public static bool IDisExisted(TextBox txt)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnStr);
            conn.Open();
            string query = string.Format("select count(*) from MortgageLoan where LoanID = {0}", txt.Text);
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
