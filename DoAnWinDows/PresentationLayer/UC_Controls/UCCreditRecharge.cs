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


        private void btnRecharge_Click(object sender, EventArgs e)
        {
            CreditCard credit = getDataCredit();
            CustomerAccount cusacc = getDataCusAcc();
            if (creditRechargeDao.creditRecharge(credit, cusacc))
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Su");
            }
            
            //MessageBox.Show("Total payment:" + credit.Moneyspent);
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
