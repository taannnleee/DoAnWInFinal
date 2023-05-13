using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWinDows.PresentationLayer.UC_Controls
{
    public partial class UCMenuLoan : UserControl
    {
        public UCMenuLoan()
        {
            InitializeComponent();
        }

        public void AddUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panelLoan.Controls.Clear();
            panelLoan.Controls.Add(uc);
            uc.BringToFront();
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
