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
            this.gvCreditDetails.DataSource = creditRechargeDao.DebtDetails(credit);
        }

        public CreditCard getDataCredit()
        {
            CreditCard credit = reditcardDAO.GetData(txtCvvCode.Text);
            return credit;
        }

        public CustomerAccount getDataCusAcc()
        {
            CreditCard credit = getDataCredit();
            CustomerAccount cusacc =  reditcardDAO.GetCusData(credit.Accountnumber.ToString());
            return cusacc;
        }

        public bool checkBalance()
        {
            CustomerAccount cusAcc = getDataCusAcc();
            CreditCard credit = getDataCredit();
            BigInteger bigA = BigInteger.Parse(cusAcc.Balance);
            BigInteger bigB = BigInteger.Parse(credit.Moneyspent);
            if (BigInteger.Compare(bigA, bigB) >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsExpiredAccount(CreditCard credit)
        {
            if (credit.CreditCardStatus == "Expired")
            {
                return true;
            }
            return false;
        }


        private void btnRecharge_Click(object sender, EventArgs e)
        {
            CreditCard credit = getDataCredit();
            CustomerAccount cusacc = getDataCusAcc();
            if (IsExpiredAccount(credit))
            {
                int number = int.Parse(credit.Moneyspent);
                number = number + Convert.ToInt32(number* 0.1* Convert.ToInt32(credit.OverdueMonths));
                credit.Moneyspent = number.ToString();
                MessageBox.Show("Overdue payment");
                MessageBox.Show("interest = : " + credit.Moneyspent);
            }
            if (checkBalance())
            {
                if (creditRechargeDao.creditRecharge(credit, cusacc))
                {
                    reditcardDAO.backupStatus(credit.Cvvcode, "Active", "0");
                    MessageBox.Show("Success");
                    MessageBox.Show("Total payment:" + credit.Moneyspent);
                }
                else
                {
                    MessageBox.Show("Fail");
                }
            }
            else
            {
                MessageBox.Show("The amount in the original account is not enough");
            }
            
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


    }
}
