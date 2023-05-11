namespace DoAnWinDows
{
    partial class FCustomer
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
            panelContainer = new Panel();
            menuStripCustumer = new MenuStrip();
            accountToolStripMenuItem = new ToolStripMenuItem();
            bankSavingsToolStripMenuItem = new ToolStripMenuItem();
            withdrawToolStripMenuItem = new ToolStripMenuItem();
            transactionsToolStripMenuItem = new ToolStripMenuItem();
            rechargeToolStripMenuItem = new ToolStripMenuItem();
            menuStripCustumer.SuspendLayout();
            SuspendLayout();
            // 
            // panelContainer
            // 
            panelContainer.Location = new Point(-3, 65);
            panelContainer.Margin = new Padding(3, 4, 3, 4);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(915, 540);
            panelContainer.TabIndex = 0;
            // 
            // menuStripCustumer
            // 
            menuStripCustumer.BackColor = SystemColors.GradientInactiveCaption;
            menuStripCustumer.ImageScalingSize = new Size(20, 20);
            menuStripCustumer.Items.AddRange(new ToolStripItem[] { accountToolStripMenuItem, bankSavingsToolStripMenuItem, withdrawToolStripMenuItem, transactionsToolStripMenuItem, rechargeToolStripMenuItem });
            menuStripCustumer.Location = new Point(0, 0);
            menuStripCustumer.Name = "menuStripCustumer";
            menuStripCustumer.Padding = new Padding(7, 3, 0, 3);
            menuStripCustumer.Size = new Size(914, 30);
            menuStripCustumer.TabIndex = 1;
            menuStripCustumer.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            accountToolStripMenuItem.Size = new Size(136, 24);
            accountToolStripMenuItem.Text = "ChangePassWord";
            accountToolStripMenuItem.Click += accountToolStripMenuItem_Click;
            // 
            // bankSavingsToolStripMenuItem
            // 
            bankSavingsToolStripMenuItem.Name = "bankSavingsToolStripMenuItem";
            bankSavingsToolStripMenuItem.Size = new Size(105, 24);
            bankSavingsToolStripMenuItem.Text = "BankSavings";
            bankSavingsToolStripMenuItem.Click += bankSavingsToolStripMenuItem_Click;
            // 
            // withdrawToolStripMenuItem
            // 
            withdrawToolStripMenuItem.Name = "withdrawToolStripMenuItem";
            withdrawToolStripMenuItem.Size = new Size(87, 24);
            withdrawToolStripMenuItem.Text = "Withdraw";
            withdrawToolStripMenuItem.Click += withdrawToolStripMenuItem_Click;
            // 
            // transactionsToolStripMenuItem
            // 
            transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            transactionsToolStripMenuItem.Size = new Size(104, 24);
            transactionsToolStripMenuItem.Text = "Transactions";
            transactionsToolStripMenuItem.Click += transactionsToolStripMenuItem_Click;
            // 
            // rechargeToolStripMenuItem
            // 
            rechargeToolStripMenuItem.Name = "rechargeToolStripMenuItem";
            rechargeToolStripMenuItem.Size = new Size(85, 24);
            rechargeToolStripMenuItem.Text = "Recharge";
            rechargeToolStripMenuItem.Click += rechargeToolStripMenuItem_Click;
            // 
            // FCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(914, 600);
            Controls.Add(panelContainer);
            Controls.Add(menuStripCustumer);
            MainMenuStrip = menuStripCustumer;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FCustomer";
            Text = "FCustomer";
            menuStripCustumer.ResumeLayout(false);
            menuStripCustumer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelContainer;
        private MenuStrip menuStripCustumer;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem bankSavingsToolStripMenuItem;
        private ToolStripMenuItem withdrawToolStripMenuItem;
        private ToolStripMenuItem transactionsToolStripMenuItem;
        private ToolStripMenuItem rechargeToolStripMenuItem;
    }
}