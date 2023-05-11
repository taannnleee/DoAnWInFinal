using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DoAnWinDows.DataAccessObject;
using DoAnWinDows.BusinessLayer.Models;
using DoAnWinDows.Utilities;

namespace DoAnWinDows
{
    public partial class Cus_UCTransactions : UserControl
    {
        private Customer cus;
        private CustomerAccount cusAcc;
        EmployeeDao DAO = new EmployeeDao();
        Customer cusReceiver = new Customer();
        CustomerAccount cusAccReceiver = new CustomerAccount();

        public Cus_UCTransactions(Customer cus, CustomerAccount acc)
        {
            InitializeComponent();
            this.cus = cus;
            this.cusAcc = acc;
        }

        private void Cus_UCTransactions_Load(object sender, EventArgs e)
        {
            lblName.Text = cus.Customername;
            txtInvoice.Clear();
            txtInvoice.Text += "THONG TIN CHUYEN TIEN\n\n";
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            DAO.SearchCustomer(cusReceiver, cusAccReceiver, txtReceiverAccNum);
            txtReceiverName.Text = cusReceiver.Customername;
        }

        private void btnTransact_Click(object sender, EventArgs e)
        {
            cusAcc.Balance = Calculation.SubtractStrings(cusAcc.Balance, txtMoneyTransaction.Text);
            cusAccReceiver.Balance = Calculation.AddStrings(cusAccReceiver.Balance, txtMoneyTransaction.Text);
            txtInvoice.Text += "Khach hang: " + cus.Customername + "\n";
            txtInvoice.Text += "So tai khoan: " + cusAcc.Accountnumber + "\n";
            txtInvoice.Text += "Loai tai khoan: " + cusAcc.Accounttype + "\n\n";
            txtInvoice.Text += "Nguoi nhan: " + cusReceiver.Customername + "\n";
            txtInvoice.Text += "So tai khoan: " + cusAccReceiver.Accountnumber + "\n";
            txtInvoice.Text += "Loai tai khoan: " + cusAccReceiver.Accounttype + "\n\n";
            txtInvoice.Text += "So tien da chuyen: " + txtMoneyTransaction.Text + "\n";
            txtInvoice.Text += "Ghi chu: " + txtMessage.Text + "\n";
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            txtInvoice.Clear();
            txtInvoice.Text += "********************************************************************************************************\n";
            txtInvoice.Text += "*****                                  HOA DON CHUYEN TIEN                                   *****\n";
            txtInvoice.Text += "********************************************************************************************************\n\n";
            txtInvoice.Text += "Khach hang: " + cus.Customername + "\n";
            txtInvoice.Text += "So tai khoan: " + cusAcc.Accountnumber + "\n";
            txtInvoice.Text += "Loai tai khoan: " + cusAcc.Accounttype + "\n\n";
            txtInvoice.Text += "Nguoi nhan: " + cusReceiver.Customername + "\n";
            txtInvoice.Text += "So tai khoan: " + cusAccReceiver.Accountnumber + "\n";
            txtInvoice.Text += "Loai tai khoan: " + cusAccReceiver.Accounttype + "\n\n";
            txtInvoice.Text += "So tien da chuyen: " + txtMoneyTransaction.Text + "\n";
            txtInvoice.Text += "Ghi chu: " + txtMessage.Text + "\n";

            txtMessage.Text = "";
            txtMoneyTransaction.Text = "";

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            txtInvoice.Clear();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtInvoice.Text, new Font("Microsoft Sans Serif", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }
    }
}
