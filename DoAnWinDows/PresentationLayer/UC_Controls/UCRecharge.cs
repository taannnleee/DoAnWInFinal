﻿using DoAnWinDows.BusinessLayer.Models;
using DoAnWinDows.DataAccessObject;
using DoAnWinDows.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DoAnWinDows
{
    public partial class UCRecharge : UserControl
    {
        CustomerAccountDAO customerAccountDAO = new CustomerAccountDAO();
        //BindingSource bindingSource = new BindingSource();

        CustomerAccount acc = new CustomerAccount();
        Customer cus = new Customer();
        EmployeeDao emDAO = new EmployeeDao();
        private string temp;

        public UCRecharge()
        {
            InitializeComponent();
        }
        private void LoadInformation()
        {
            rtxtInformation.Clear();
            rtxtInformation.Text += "THONG TIN KHACH HANG\n";
            rtxtInformation.Text += "Ten khach hang: " + cus.Customername + "\n";
            rtxtInformation.Text += "So tai khoan: " + acc.Accountnumber + "\n";
            rtxtInformation.Text += "Loai tai khoan: " + acc.Accounttype + "\n";
            rtxtInformation.Text += "So du: " + acc.Balance + "\n\n";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            emDAO.SearchCustomer(cus, acc, txtAccNum);
            LoadInformation();
        }

        private void btnRecharge_Click(object sender, EventArgs e)
        {
            acc.Balance = Calculation.AddStrings(acc.Balance, txtMoneyRecharge.Text);
            rtxtInvoice.Text += "********************************************************************************************************\n";
            rtxtInvoice.Text += "*****                                  HOA DON NAP TIEN                                   *****\n";
            rtxtInvoice.Text += "********************************************************************************************************\n\n";
            rtxtInvoice.Text += "Ngay nap: " + DateTime.Now + "\n";
            rtxtInvoice.Text += "Ten khach hang: " + cus.Customername + "\n";
            rtxtInvoice.Text += "So tai khoan: " + acc.Accountnumber + "\n";
            rtxtInvoice.Text += "Loai tai khoan: " + acc.Accounttype + "\n";
            rtxtInvoice.Text += "So tien nap: " + txtMoneyRecharge.Text + "\n";
            txtMoneyRecharge.Clear();
            customerAccountDAO.Edit(acc);
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
    }
}
