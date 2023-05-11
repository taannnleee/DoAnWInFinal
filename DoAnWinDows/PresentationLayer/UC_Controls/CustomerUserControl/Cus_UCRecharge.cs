using DoAnWinDows.BusinessLayer.Models;
using DoAnWinDows.DataAccessObject;
using DoAnWinDows.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWinDows
{
    public partial class Cus_UCRecharge : UserControl
    {
        private Customer customer;
        private CustomerAccount customerAcc;
        CustomerAccountDAO customerAccountDAO = new CustomerAccountDAO();
        public Cus_UCRecharge(Customer cus, CustomerAccount acc)
        {
            InitializeComponent();
            customer = cus;
            customerAcc = acc;
        }

        private void Cus_UCRecharge_Load(object sender, EventArgs e)
        {
            LoadInformation();
        }
        private void LoadInformation()
        {
            rtxtInformation.Clear();
            rtxtInformation.Text += "THONG TIN KHACH HANG\n";
            rtxtInformation.Text += "Ten khach hang: " + customer.Customername + "\n";
            rtxtInformation.Text += "So tai khoan: " + customerAcc.Accountnumber + "\n";
            rtxtInformation.Text += "Loai tai khoan: " + customerAcc.Accounttype + "\n";
            rtxtInformation.Text += "So du: " + customerAcc.Balance + "\n\n";
        }
        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            rtxtInvoice.Clear();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtxtInvoice.Text, new Font("Microsoft Sans Serif", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }

        private void btnRecharge_Click(object sender, EventArgs e)
        {
            customerAcc.Balance = Calculation.AddStrings(customerAcc.Balance, txtMoneyRecharge.Text);
            rtxtInvoice.Text += "********************************************************************************************************\n";
            rtxtInvoice.Text += "*****                                  HOA DON NAP TIEN                                   *****\n";
            rtxtInvoice.Text += "********************************************************************************************************\n\n";
            rtxtInvoice.Text += "Ngay nap: " + DateTime.Now + "\n";
            rtxtInvoice.Text += "Ten khach hang: " + customer.Customername + "\n";
            rtxtInvoice.Text += "So tai khoan: " + customerAcc.Accountnumber + "\n";
            rtxtInvoice.Text += "Loai tai khoan: " + customerAcc.Accounttype + "\n";
            rtxtInvoice.Text += "So tien nap: " + txtMoneyRecharge.Text + "\n";
            txtMoneyRecharge.Clear();
            customerAccountDAO.Edit(customerAcc);
            LoadInformation();
        }
    }
}
