using DoAnWinDows.PresentationLayer.UC_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWinDows.PresentationLayer.Forms
{
    public partial class FEmployee1 : Form
    {
        public FEmployee1()
        {
            InitializeComponent();
        }

        public void AddUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panelEmployee.Controls.Clear();
            panelEmployee.Controls.Add(uc);
            uc.BringToFront();
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCTransactions trans = new UCTransactions();
            AddUserControl(trans);
        }

        private void rechargeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCRecharge recharge = new UCRecharge();
            AddUserControl(recharge);
        }

        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCWithdraw withdraw = new UCWithdraw();
            AddUserControl(withdraw);
        }

        private void bankSavingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCBankSavings banksavings = new UCBankSavings();
            banksavings.Dock = DockStyle.Fill;
            AddUserControl(banksavings);
        }

        private void payByCreditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCPayByCredit pay = new UCPayByCredit();
            AddUserControl(pay);
        }

        private void createCreditCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCCreateCreditCard creditCard = new UCCreateCreditCard();
            AddUserControl(creditCard);
        }

        private void creditRechargeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCCreditRecharge uCCreditRecharge = new UCCreditRecharge();
            AddUserControl((uCCreditRecharge));
        }

        private void loanToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            UC_Unsecure_Loan unsecure_loan = new UC_Unsecure_Loan();
            AddUserControl(unsecure_loan);
        }

        private void listOfLoanAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_Unsecure_ListOfLoanAccount unsecure_listOfLoan = new UC_Unsecure_ListOfLoanAccount();
            AddUserControl(unsecure_listOfLoan);
        }

        private void loanToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UC_Mortgage_Loan mortgageLoan = new UC_Mortgage_Loan();
            AddUserControl(mortgageLoan);
        }

        private void listOfLoanAccountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UC_Mortgage_ListOfLoanAccount mortgage_listOfLoan = new UC_Mortgage_ListOfLoanAccount();
            AddUserControl(mortgage_listOfLoan);
        }

        private void blacklistOfLoanAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_Unsecure_Blacklist black_list = new UC_Unsecure_Blacklist();
            AddUserControl(black_list);
        }

        private void blacklistOfLoanAccountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UC_Mortgage_BlackList blacklist = new UC_Mortgage_BlackList();
            AddUserControl(blacklist);
        }
    }
}
