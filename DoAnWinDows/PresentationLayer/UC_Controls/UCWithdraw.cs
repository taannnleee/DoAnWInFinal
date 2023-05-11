using DoAnWinDows.DataAccessObject;
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
using DoAnWinDows.BusinessLayer.Models;
using DoAnWinDows.Utilities;
using System.CodeDom.Compiler;

namespace DoAnWinDows
{
    public partial class UCWithdraw : UserControl
    {
        public UCWithdraw()
        {
            InitializeComponent();
        }

        CustomerAccountDAO accDAO = new CustomerAccountDAO();
        CustomerAccount acc = new CustomerAccount();
        Customer cus = new Customer();
        EmployeeDao emDAO = new EmployeeDao();
        private string temp;

        public void LoadInformation()
        {
            txtInvoice.Clear();
            txtInvoice.Text += "THONG TIN KHACH HANG\n";
            txtInvoice.Text += "Ten khach hang: " + cus.Customername + "\n";
            txtInvoice.Text += "So tai khoan: " + acc.Accountnumber + "\n";
            txtInvoice.Text += "Loai tai khoan: " + acc.Accounttype + "\n";
            txtInvoice.Text += "So du: " + acc.Balance + "\n\n";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            emDAO.SearchCustomer(cus, acc, txtAccNum);
            LoadInformation();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            acc.Balance = Calculation.SubtractStrings(acc.Balance, txtMoneyWithdraw.Text);
            txtInvoice.Text += "So tien rut: " + txtMoneyWithdraw.Text + "\n";
            txtInvoice.Text += "Ngay rut: " + DateTime.Now + "\n";
            txtInvoice.Text += "So du sau khi rut: " + acc.Balance + "\n";
            temp = txtMoneyWithdraw.Text;
            txtMoneyWithdraw.Text = "";
            accDAO.Edit(acc);
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            txtInvoice.Clear();
            txtInvoice.Text += "********************************************************************************************************\n";
            txtInvoice.Text += "*****                                  HOA DON RUT TIEN                                   *****\n";
            txtInvoice.Text += "********************************************************************************************************\n\n";
            txtInvoice.Text += "Ngay rut: " + DateTime.Now + "\n";
            txtInvoice.Text += "Ten khach hang: " + cus.Customername + "\n";
            txtInvoice.Text += "So tai khoan: " + acc.Accountnumber + "\n";
            txtInvoice.Text += "Loai tai khoan: " + acc.Accounttype + "\n";
            txtInvoice.Text += "So tien da rut: " + temp + " VND\n";

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
