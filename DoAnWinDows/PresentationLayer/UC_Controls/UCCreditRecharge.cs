using DoAnWinDows.BusinessLayer.Models;
using DoAnWinDows.DataAccessLayer;
using DoAnWinDows.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DoAnWinDows.PresentationLayer.UC_Controls
{
    public partial class UCCreditRecharge : UserControl
    {
        CreditRechargeDAO creditRechargeDao = new CreditRechargeDAO();
        CreditCardDAO reditcardDAO = new CreditCardDAO();
        public UCCreditRecharge()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            LoadCreditById();
        }

        public void LoadCreditById()
        {
            CreditCard credit = new CreditCard(txtCvvCode.Text, txtDepositAmount.Text);
            this.gvCreditCard.DataSource = creditRechargeDao.DebtCheck(credit);
        }

        public bool getDataCredit(CreditCard credit)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnStr);
            conn.Open();
            String sqlQuery = String.Format("Select * From CreditCard Where CVVCode ='{0}'", txtCvvCode.Text);
            SqlCommand cmd = new SqlCommand(sqlQuery, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                credit.Moneyspent = reader["MoneySpent"].ToString();
                credit.Creditlimit = reader["CreditLimit"].ToString();
                credit.Accountnumber = Convert.ToInt32(reader["AccountNumber"]);
            }
            BigInteger bigA = BigInteger.Parse(credit.Moneyspent);
            BigInteger bigB = BigInteger.Parse(txtDepositAmount.Text);
            if (BigInteger.Compare(bigA, bigB) >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            conn.Close();
        }

        public bool getDataCusAcc(CustomerAccount cusAcc, CreditCard credit)
        {
            SqlDataReader reader = reditcardDAO.GetDataCredit(Convert.ToInt32(credit.Accountnumber));
            if (reader != null)
            {
                cusAcc.Balance = reader["Balance"].ToString();
            }
            BigInteger bigB = BigInteger.Parse(txtDepositAmount.Text);
            BigInteger bigA = BigInteger.Parse(Math.Round(Convert.ToDouble(cusAcc.Balance)).ToString());
            if (BigInteger.Compare(bigA, bigB) >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckMoney(CreditCard readcreditcard, CustomerAccount cusAcc)
        {
            bool a = getDataCredit(readcreditcard);
            bool b = getDataCusAcc(cusAcc, readcreditcard);
            if (a && b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnRecharge_Click(object sender, EventArgs e)
        {
            DateTime currentime = Time.GetCurrentTime();
            CreditCard readcreditcard = new CreditCard(txtCvvCode.Text, txtDepositAmount.Text);
            CustomerAccount readcusAcc = new CustomerAccount();
            CreditCard credit = new CreditCard(txtCvvCode.Text, txtDepositAmount.Text);
            if (CheckMoney(readcreditcard, readcusAcc))
            {
                if (checkDateGap(currentime) < 31)
                {
                    creditRechargeDao.creditRecharge(credit, readcreditcard.Accountnumber, currentime);
                    MessageBox.Show("Success");
                }
                else
                {
                    int latedate = checkDateGap(currentime) - 31;
                    double interest = ((Convert.ToDouble(credit.Moneyspent) * 0.01) * latedate) + (Convert.ToDouble(credit.Moneyspent));
                    credit.Moneyspent = interest.ToString();
                    creditRechargeDao.creditRecharge(credit, readcreditcard.Accountnumber, currentime);
                    MessageBox.Show("Success");
                    //MessageBox.Show(latedate.ToString());
                    //MessageBox.Show(credit.Moneyspent);
                }
                MessageBox.Show("So tien da thanh toan:" + credit.Moneyspent);
            }
            else
            {
                MessageBox.Show("Fail");
            }
            LoadCreditById();
        }

        string[] columnNames1 = { "CVVCode", "MoneySpent" };

        private Dictionary<string, Control> PairData()
        {
            Dictionary<string, Control> textBoxMapping = new Dictionary<string, Control>
            {
                { "MoneySpent", txtDepositAmount },
                {"CVVCode",txtCvvCode }
            };
            return textBoxMapping;
        }

        private void gvCreditCard_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            creditRechargeDao.LoadRowInCreditCardTable(gvCreditCard, columnNames1, PairData());
        }

        public int checkDateGap(DateTime date)
        {
            DateTime expirationdate = date;
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnStr);
            conn.Open();
            String sqlQuery = String.Format("Select * From CreditCard Where CVVCode ='{0}'", txtCvvCode.Text);
            SqlCommand cmd = new SqlCommand(sqlQuery, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                expirationdate = Convert.ToDateTime(reader["ExpirationDate"]);
            }
            conn.Close();
            TimeSpan difference = expirationdate - date;
            int numberOfDays = Math.Abs(difference.Days);
            return numberOfDays;
        }
    }
}
