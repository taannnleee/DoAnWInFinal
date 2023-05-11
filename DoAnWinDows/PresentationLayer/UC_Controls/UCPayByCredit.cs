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

namespace DoAnWinDows.PresentationLayer.UC_Controls
{
    public partial class UCPayByCredit : UserControl
    {
        PayByCreditDAO payByCreditDAO = new PayByCreditDAO();
        public UCPayByCredit()
        {
            InitializeComponent();
        }

        public bool getDataCredit(CreditCard credit, string money)
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
            }
            BigInteger bigA = BigInteger.Parse(Calculation.AddStrings(credit.Moneyspent, money));
            BigInteger bigB = BigInteger.Parse(credit.Creditlimit);
            if (BigInteger.Compare(bigA, bigB) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            conn.Close();
        }

        private void panelHousePayments_Click(object sender, EventArgs e)
        {
            CreditCard creditcard = new CreditCard(txtCvvCode.Text);
            string money = "10000";
            
            if (getDataCredit(creditcard, money) == false)
            {
                payByCreditDAO.creditPayment(creditcard, money);
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Thanh toan vuot qua gioi han");
            }
        }

        private void panelElectricityPayments_Click(object sender, EventArgs e)
        {
            CreditCard creditcard = new CreditCard(txtCvvCode.Text);
            string money = "10000";

            if (getDataCredit(creditcard, money) == false)
            {
                payByCreditDAO.creditPayment(creditcard, money);
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Thanh toan vuot qua gioi han");
            }
        }

        private void panelWaterPayments_Click(object sender, EventArgs e)
        {
            CreditCard creditcard = new CreditCard(txtCvvCode.Text);
            string money = "10000";

            if (getDataCredit(creditcard, money) == false)
            {
                payByCreditDAO.creditPayment(creditcard, money);
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Thanh toan vuot qua gioi han");
            }
        }
    }
}
