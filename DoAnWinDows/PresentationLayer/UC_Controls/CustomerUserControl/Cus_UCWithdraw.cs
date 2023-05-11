using DoAnWinDows.BusinessLayer.Models;
using DoAnWinDows.DataAccessLayer;
using DoAnWinDows.DataAccessObject;
using DoAnWinDows.Utilities;
using Microsoft.Data.SqlClient;
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
    public partial class Cus_UCWithdraw : UserControl
    {
        private CustomerAccount customerAcc;
        private Customer cus;
        CustomerAccountDAO DAO = new CustomerAccountDAO();

        public Cus_UCWithdraw(Customer cus, CustomerAccount acc)
        {
            InitializeComponent();
            customerAcc = acc;
            this.cus = cus;
        }

        private String temp;

        public void LoadInfor()
        {
            lblName.Text = cus.Customername;
            txtAccNum.Text = customerAcc.Accountnumber.ToString();
            txtBalance.Text = customerAcc.Balance;
            txtAmWithdraw.Text = "";
        }

        private void Cus_UCWithdraw_Load(object sender, EventArgs e)
        {
            try
            {
                LoadInfor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            customerAcc.Balance = Calculation.SubtractStrings(customerAcc.Balance, txtAmWithdraw.Text);
            DAO.Edit(customerAcc);
            temp = txtAmWithdraw.Text;
            LoadInfor();

            txtInvoice.Clear();
            txtInvoice.Text += "********************************************************************************************************\n";
            txtInvoice.Text += "*****                                  HOA DON RUT TIEN                                   *****\n";
            txtInvoice.Text += "********************************************************************************************************\n\n";
            txtInvoice.Text += "Ngay rut: " + DateTime.Now + "\n\n";
            txtInvoice.Text += "Ten khach hang: " + cus.Customername + "\n\n";
            txtInvoice.Text += "So tai khoan: " + customerAcc.Accountnumber + "\n\n";
            txtInvoice.Text += "Loai tai khoan: " + customerAcc.Accounttype + "\n\n";
            txtInvoice.Text += "So tien da rut: " + temp + " VND\n\n";
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtInvoice.Text, new Font("Microsoft Sans Serif", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            txtInvoice.Clear();
        }
    }
}
