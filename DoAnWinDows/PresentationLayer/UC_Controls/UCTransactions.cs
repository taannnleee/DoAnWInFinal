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
//using DoAnWinDows.BusinessLayer.Models;
using DoAnWinDows.DataAccessLayer;

namespace DoAnWinDows
{
    public partial class UCTransactions : UserControl
    {
        public UCTransactions()
        {
            InitializeComponent();
        }

        Customer sender = new Customer();
        Customer receiver = new Customer();
        CustomerAccount senderAccount = new CustomerAccount();
        CustomerAccount receiverAccount = new CustomerAccount();
        EmployeeDao DAO = new EmployeeDao();
        CustomerAccountDAO cusDAO = new CustomerAccountDAO();

        private void btnSearchSender_Click(object sender, EventArgs e)
        {
            DAO.SearchCustomer(this.sender, senderAccount, txtAccNumSender);
            txtInvoice.Text += "Thong tin nguoi gui:\n";
            txtInvoice.Text += "Ten nguoi gui: " + this.sender.Customername + "\n";
            txtInvoice.Text += "So tai khoan: " + senderAccount.Accountnumber + "\n";
            txtInvoice.Text += "Loai tai khoan: " + senderAccount.Accounttype + "\n";
            txtInvoice.Text += "So du tai khoan: " + senderAccount.Balance + "\n\n";
        }

        private void btnSearchReceiver_Click(object sender, EventArgs e)
        {
            DAO.SearchCustomer(receiver, receiverAccount, txtAccNumReceiver);
            txtInvoice.Text += "Thong tin nguoi nhan:\n";
            txtInvoice.Text += "Ten nguoi nhan: " + receiver.Customername + "\n";
            txtInvoice.Text += "So tai khoan: " + receiverAccount.Accountnumber + "\n";
            txtInvoice.Text += "Loai tai khoan: " + receiverAccount.Accounttype + "\n\n";
        }

        private void UCTransactions_Load(object sender, EventArgs e)
        {
            txtInvoice.Clear();
            txtInvoice.Text += "THONG TIN KHACH HANG\n\n";
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            DialogResult notification = MessageBox.Show("Xac nhan chuyen tien.\n" + "So tien chuyen: " + txtMoneyTransaction.Text + ".\n" + "Noi dung chuyen: " + txtMessage.Text + ".", "Xac nhan", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (notification == DialogResult.OK)
            {
                senderAccount.Balance = Calculation.SubtractStrings(senderAccount.Balance, txtMoneyTransaction.Text);
                receiverAccount.Balance = Calculation.AddStrings(receiverAccount.Balance, txtMoneyTransaction.Text);
                txtInvoice.Text += "Thong tin chuyen tien:\n";
                txtInvoice.Text += "So tien chuyen: " + txtMoneyTransaction.Text + "\n";
                txtInvoice.Text += "Noi dung chuyen: " + txtMessage.Text + "\n";
                cusDAO.Edit(senderAccount);
                cusDAO.Edit(receiverAccount);
                ReadyToPrintInvoice();
            }
            else
            {
                MessageBox.Show("Giao dich that bai", "Xac nhan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ReadyToPrintInvoice()
        {
            txtInvoice.Clear();
            txtInvoice.Text += "********************************************************************************************************\n";
            txtInvoice.Text += "*****                                  HOA DON GIAO DICH                                 *****\n";
            txtInvoice.Text += "********************************************************************************************************\n\n";
            txtInvoice.Text += "Ngay thuc hien giao dich: " + DateTime.Now + "\n\n";
            txtInvoice.Text += "Ten khach hang chuyen tien: " + sender.Customername + "\n";
            txtInvoice.Text += "So tai khoan: " + senderAccount.Accountnumber + "\n";
            txtInvoice.Text += "Loai tai khoan: " + senderAccount.Accounttype + "\n\n";
            txtInvoice.Text += "Ten khach hang nhan tien: " + receiver.Customername + "\n";
            txtInvoice.Text += "So tai khoan: " + receiverAccount.Accountnumber + "\n";
            txtInvoice.Text += "Loai tai khoan: " + receiverAccount.Accounttype + "\n\n";
            txtInvoice.Text += "So tien da chuyen: " + txtMoneyTransaction.Text + "\n";
            txtInvoice.Text += "Noi dung chuyen tien: " + txtMessage.Text + "\n";
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            txtInvoice.Clear();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtInvoice.Text, new Font("Microsoft Sans Serif", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }

        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
            txtInvoice.Clear();
            txtInvoice.Text += "THONG TIN KHACH HANG\n\n";
            txtAccNumReceiver.Text = "";
            txtAccNumSender.Text = "";
            txtMessage.Text = "";
            txtMoneyTransaction.Text = "";
        }
    }
}
