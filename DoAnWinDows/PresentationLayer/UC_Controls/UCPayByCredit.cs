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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAnWinDows.PresentationLayer.UC_Controls
{
    public partial class UCPayByCredit : UserControl
    {
        PayByCreditDAO payByCreditDAO = new PayByCreditDAO();
        public UCPayByCredit()
        {
            InitializeComponent();
        }

        private void txtCvv_Enter(object sender, EventArgs e)
        {
            if (txtCvvCode.Text == "Cvv")
            {
                txtCvvCode.Text = "";
            }
        }

        private void txtCvv_Leave(object sender, EventArgs e)
        {
            txtAvailableBalances.Text = CheckAvaiableMoney();
        }

        public bool getDataCredit(CreditCard credit, string money)
        {
            CreditCard creditData = payByCreditDAO.GetDataCredit(txtCvvCode.Text);
            if (creditData != null)
            {
                credit.Moneyspent = creditData.Moneyspent;
                credit.Creditlimit = creditData.Creditlimit;
            }
            BigInteger bigA = BigInteger.Parse(Calculation.AddStrings(credit.Moneyspent, money));
            BigInteger bigB = BigInteger.Parse(credit.Creditlimit);
            return BigInteger.Compare(bigA, bigB) > 0;
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            string description = String.Format("{0}{1}", cbService.Text, cbSupplier.Text);
            CreditDetails crdDetails = new CreditDetails(txtCvvCode.Text, Time.GetCurrentTime(), txtExpense.Text, description);
            CreditCard creditcard = new CreditCard(txtCvvCode.Text);
            string money = txtExpense.Text;
            if (getDataCredit(creditcard, money) == false)
            {
                payByCreditDAO.creditPayment(creditcard, money);
                payByCreditDAO.creditCardPaymentDetails(crdDetails);

                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Payment over limit");
            }
            LoadListCreditDetails();
        }

        public string CheckAvaiableMoney()
        {
            CreditCard creditData = payByCreditDAO.GetDataCredit(txtCvvCode.Text);
            BigInteger bigA;
            if (!BigInteger.TryParse(creditData.Moneyspent, out bigA))
            {
                bigA = BigInteger.One;
            }
            BigInteger bigB;
            if (!BigInteger.TryParse(creditData.Creditlimit, out bigB))
            {
                bigB = BigInteger.One;
            }
            return (bigB - bigA).ToString();
        }

        private void cbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSupplier.Items.Clear();
            if (cbService.SelectedIndex == 0)
            {
                cbSupplier.Text = "California Water Service Group (CWSG)";
                cbSupplier.Items.Add("California Water Service Group (CWSG)");
                cbSupplier.Items.Add("American States Water Company");
                cbSupplier.Items.Add("New Jersey American Water");
            }
            else if (cbService.SelectedIndex == 1)
            {
                cbSupplier.Text = "Pacific Gas and Electric Company (PG&E)";
                cbSupplier.Items.Add("Pacific Gas and Electric Company (PG&E)");
                cbSupplier.Items.Add("Southern California Edison (SCE)");
                cbSupplier.Items.Add("American Electric Power (AEP)");
            }
            else if (cbService.SelectedIndex == 2)
            {
                cbService.Text = "Greystar";
                cbSupplier.Items.Add("Greystar");
                cbSupplier.Items.Add("UDR, Inc.");
            }
        }

        public void LoadListCreditDetails()
        {
            this.gvCreditDetails.DataSource = payByCreditDAO.DanhSachQuanLy(txtCvvCode.Text);
        }
        private void UCPayByCredit_Load(object sender, EventArgs e)
        {
            LoadListCreditDetails();
        }
    }
}
