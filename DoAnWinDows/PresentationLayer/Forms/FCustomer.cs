using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnWinDows.BusinessLayer.Models;

namespace DoAnWinDows
{
    public partial class FCustomer : Form
    {
        public CustomerAccount account;
        public Customer cus;
        public FCustomer(Customer cus, CustomerAccount account)
        {
            InitializeComponent();
            this.account = account;
            this.cus = cus;
        }

        public void AddUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCChangePassword changpass = new UCChangePassword(this.account);
            AddUserControl(changpass);
        }

        private void bankSavingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cus_UCBankSavings bankSavings = new Cus_UCBankSavings(this.account);
            AddUserControl(bankSavings);
        }

        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cus_UCWithdraw withdraw = new Cus_UCWithdraw(cus, account);
            AddUserControl(withdraw);
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cus_UCTransactions transactions = new Cus_UCTransactions(cus, account);
            AddUserControl(transactions);
        }

        private void rechargeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cus_UCRecharge recharge = new Cus_UCRecharge(this.cus, this.account);
            AddUserControl(recharge);
        }
    }
}
