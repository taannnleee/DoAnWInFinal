namespace DoAnWinDows.PresentationLayer.Forms
{
    partial class FEmployee1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            transactionsToolStripMenuItem = new ToolStripMenuItem();
            rechargeToolStripMenuItem = new ToolStripMenuItem();
            withdrawToolStripMenuItem = new ToolStripMenuItem();
            bankSavingsToolStripMenuItem = new ToolStripMenuItem();
            creditCardToolStripMenuItem = new ToolStripMenuItem();
            createCreditCardToolStripMenuItem = new ToolStripMenuItem();
            payByCreditToolStripMenuItem = new ToolStripMenuItem();
            creditRechargeToolStripMenuItem = new ToolStripMenuItem();
            loanToolStripMenuItem = new ToolStripMenuItem();
            unsecureToolStripMenuItem = new ToolStripMenuItem();
            loanToolStripMenuItem1 = new ToolStripMenuItem();
            listOfLoanAccountToolStripMenuItem = new ToolStripMenuItem();
            blacklistOfLoanAccountToolStripMenuItem = new ToolStripMenuItem();
            mortgageToolStripMenuItem = new ToolStripMenuItem();
            loanToolStripMenuItem2 = new ToolStripMenuItem();
            listOfLoanAccountToolStripMenuItem1 = new ToolStripMenuItem();
            blacklistOfLoanAccountToolStripMenuItem1 = new ToolStripMenuItem();
            panelEmployee = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientInactiveCaption;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { transactionsToolStripMenuItem, rechargeToolStripMenuItem, withdrawToolStripMenuItem, bankSavingsToolStripMenuItem, creditCardToolStripMenuItem, loanToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1284, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // transactionsToolStripMenuItem
            // 
            transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            transactionsToolStripMenuItem.Size = new Size(84, 20);
            transactionsToolStripMenuItem.Text = "Transactions";
            transactionsToolStripMenuItem.Click += transactionsToolStripMenuItem_Click;
            // 
            // rechargeToolStripMenuItem
            // 
            rechargeToolStripMenuItem.Name = "rechargeToolStripMenuItem";
            rechargeToolStripMenuItem.Size = new Size(68, 20);
            rechargeToolStripMenuItem.Text = "Recharge";
            rechargeToolStripMenuItem.Click += rechargeToolStripMenuItem_Click;
            // 
            // withdrawToolStripMenuItem
            // 
            withdrawToolStripMenuItem.Name = "withdrawToolStripMenuItem";
            withdrawToolStripMenuItem.Size = new Size(70, 20);
            withdrawToolStripMenuItem.Text = "Withdraw";
            withdrawToolStripMenuItem.Click += withdrawToolStripMenuItem_Click;
            // 
            // bankSavingsToolStripMenuItem
            // 
            bankSavingsToolStripMenuItem.Name = "bankSavingsToolStripMenuItem";
            bankSavingsToolStripMenuItem.Size = new Size(85, 20);
            bankSavingsToolStripMenuItem.Text = "BankSavings";
            bankSavingsToolStripMenuItem.Click += bankSavingsToolStripMenuItem_Click;
            // 
            // creditCardToolStripMenuItem
            // 
            creditCardToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createCreditCardToolStripMenuItem, payByCreditToolStripMenuItem, creditRechargeToolStripMenuItem });
            creditCardToolStripMenuItem.Name = "creditCardToolStripMenuItem";
            creditCardToolStripMenuItem.Size = new Size(76, 20);
            creditCardToolStripMenuItem.Text = "CreditCard";
            // 
            // createCreditCardToolStripMenuItem
            // 
            createCreditCardToolStripMenuItem.Name = "createCreditCardToolStripMenuItem";
            createCreditCardToolStripMenuItem.Size = new Size(165, 22);
            createCreditCardToolStripMenuItem.Text = "CreateCreditCard";
            createCreditCardToolStripMenuItem.Click += createCreditCardToolStripMenuItem_Click;
            // 
            // payByCreditToolStripMenuItem
            // 
            payByCreditToolStripMenuItem.Name = "payByCreditToolStripMenuItem";
            payByCreditToolStripMenuItem.Size = new Size(165, 22);
            payByCreditToolStripMenuItem.Text = "PayByCredit";
            payByCreditToolStripMenuItem.Click += payByCreditToolStripMenuItem_Click;
            // 
            // creditRechargeToolStripMenuItem
            // 
            creditRechargeToolStripMenuItem.Name = "creditRechargeToolStripMenuItem";
            creditRechargeToolStripMenuItem.Size = new Size(165, 22);
            creditRechargeToolStripMenuItem.Text = "CreditRecharge";
            creditRechargeToolStripMenuItem.Click += creditRechargeToolStripMenuItem_Click;
            // 
            // loanToolStripMenuItem
            // 
            loanToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { unsecureToolStripMenuItem, mortgageToolStripMenuItem });
            loanToolStripMenuItem.Name = "loanToolStripMenuItem";
            loanToolStripMenuItem.Size = new Size(86, 20);
            loanToolStripMenuItem.Text = "Type of Loan";
            // 
            // unsecureToolStripMenuItem
            // 
            unsecureToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loanToolStripMenuItem1, listOfLoanAccountToolStripMenuItem, blacklistOfLoanAccountToolStripMenuItem });
            unsecureToolStripMenuItem.Name = "unsecureToolStripMenuItem";
            unsecureToolStripMenuItem.Size = new Size(126, 22);
            unsecureToolStripMenuItem.Text = "Unsecure";
            // 
            // loanToolStripMenuItem1
            // 
            loanToolStripMenuItem1.Name = "loanToolStripMenuItem1";
            loanToolStripMenuItem1.Size = new Size(208, 22);
            loanToolStripMenuItem1.Text = "Loan";
            loanToolStripMenuItem1.Click += loanToolStripMenuItem1_Click_1;
            // 
            // listOfLoanAccountToolStripMenuItem
            // 
            listOfLoanAccountToolStripMenuItem.Name = "listOfLoanAccountToolStripMenuItem";
            listOfLoanAccountToolStripMenuItem.Size = new Size(208, 22);
            listOfLoanAccountToolStripMenuItem.Text = "List of Loan Account";
            listOfLoanAccountToolStripMenuItem.Click += listOfLoanAccountToolStripMenuItem_Click;
            // 
            // blacklistOfLoanAccountToolStripMenuItem
            // 
            blacklistOfLoanAccountToolStripMenuItem.Name = "blacklistOfLoanAccountToolStripMenuItem";
            blacklistOfLoanAccountToolStripMenuItem.Size = new Size(208, 22);
            blacklistOfLoanAccountToolStripMenuItem.Text = "Blacklist of Loan Account";
            blacklistOfLoanAccountToolStripMenuItem.Click += blacklistOfLoanAccountToolStripMenuItem_Click;
            // 
            // mortgageToolStripMenuItem
            // 
            mortgageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loanToolStripMenuItem2, listOfLoanAccountToolStripMenuItem1, blacklistOfLoanAccountToolStripMenuItem1 });
            mortgageToolStripMenuItem.Name = "mortgageToolStripMenuItem";
            mortgageToolStripMenuItem.Size = new Size(126, 22);
            mortgageToolStripMenuItem.Text = "Mortgage";
            // 
            // loanToolStripMenuItem2
            // 
            loanToolStripMenuItem2.Name = "loanToolStripMenuItem2";
            loanToolStripMenuItem2.Size = new Size(208, 22);
            loanToolStripMenuItem2.Text = "Loan";
            loanToolStripMenuItem2.Click += loanToolStripMenuItem2_Click;
            // 
            // listOfLoanAccountToolStripMenuItem1
            // 
            listOfLoanAccountToolStripMenuItem1.Name = "listOfLoanAccountToolStripMenuItem1";
            listOfLoanAccountToolStripMenuItem1.Size = new Size(208, 22);
            listOfLoanAccountToolStripMenuItem1.Text = "List of Loan Account";
            listOfLoanAccountToolStripMenuItem1.Click += listOfLoanAccountToolStripMenuItem1_Click;
            // 
            // blacklistOfLoanAccountToolStripMenuItem1
            // 
            blacklistOfLoanAccountToolStripMenuItem1.Name = "blacklistOfLoanAccountToolStripMenuItem1";
            blacklistOfLoanAccountToolStripMenuItem1.Size = new Size(208, 22);
            blacklistOfLoanAccountToolStripMenuItem1.Text = "Blacklist of Loan Account";
            blacklistOfLoanAccountToolStripMenuItem1.Click += blacklistOfLoanAccountToolStripMenuItem1_Click;
            // 
            // panelEmployee
            // 
            panelEmployee.Dock = DockStyle.Fill;
            panelEmployee.Location = new Point(0, 24);
            panelEmployee.Name = "panelEmployee";
            panelEmployee.Size = new Size(1284, 637);
            panelEmployee.TabIndex = 1;
            // 
            // FEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1284, 661);
            Controls.Add(panelEmployee);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FEmployee";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem transactionsToolStripMenuItem;
        private ToolStripMenuItem rechargeToolStripMenuItem;
        private ToolStripMenuItem withdrawToolStripMenuItem;
        private ToolStripMenuItem bankSavingsToolStripMenuItem;
        private ToolStripMenuItem creditCardToolStripMenuItem;
        private Panel panelEmployee;
        private ToolStripMenuItem payByCreditToolStripMenuItem;
        private ToolStripMenuItem createCreditCardToolStripMenuItem;
        private ToolStripMenuItem creditRechargeToolStripMenuItem;
        private ToolStripMenuItem loanToolStripMenuItem;
        private ToolStripMenuItem unsecureToolStripMenuItem;
        private ToolStripMenuItem loanToolStripMenuItem1;
        private ToolStripMenuItem listOfLoanAccountToolStripMenuItem;
        private ToolStripMenuItem blacklistOfLoanAccountToolStripMenuItem;
        private ToolStripMenuItem mortgageToolStripMenuItem;
        private ToolStripMenuItem loanToolStripMenuItem2;
        private ToolStripMenuItem listOfLoanAccountToolStripMenuItem1;
        private ToolStripMenuItem blacklistOfLoanAccountToolStripMenuItem1;
    }
}