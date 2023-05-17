namespace DoAnWinDows.PresentationLayer.UC_Controls
{
    partial class UCMenuCreditCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            toolStripMenuCreateCredit = new ToolStripMenuItem();
            toolStripMenuPay = new ToolStripMenuItem();
            toolStripMenuItemCreditRecharge = new ToolStripMenuItem();
            rechargeCredit = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientInactiveCaption;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuCreateCredit, toolStripMenuPay, toolStripMenuItemCreditRecharge });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1087, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuCreateCredit
            // 
            toolStripMenuCreateCredit.Name = "toolStripMenuCreateCredit";
            toolStripMenuCreateCredit.Size = new Size(110, 20);
            toolStripMenuCreateCredit.Text = "CreateCreditCard";
            toolStripMenuCreateCredit.Click += toolStripMenuCreateCredit_Click;
            // 
            // toolStripMenuPay
            // 
            toolStripMenuPay.Name = "toolStripMenuPay";
            toolStripMenuPay.Size = new Size(83, 20);
            toolStripMenuPay.Text = "PayByCredit";
            toolStripMenuPay.Click += toolStripMenuPay_Click;
            // 
            // toolStripMenuItemCreditRecharge
            // 
            toolStripMenuItemCreditRecharge.Name = "toolStripMenuItemCreditRecharge";
            toolStripMenuItemCreditRecharge.Size = new Size(100, 20);
            toolStripMenuItemCreditRecharge.Text = "CreditRecharge";
            toolStripMenuItemCreditRecharge.Click += toolStripMenuItemCreditRecharge_Click;
            // 
            // rechargeCredit
            // 
            rechargeCredit.Location = new Point(3, 27);
            rechargeCredit.Name = "rechargeCredit";
            rechargeCredit.Size = new Size(1072, 746);
            rechargeCredit.TabIndex = 2;
            // 
            // UCMenuCreditCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(rechargeCredit);
            Controls.Add(menuStrip1);
            Name = "UCMenuCreditCard";
            Size = new Size(1087, 546);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuCreateCredit;
        private ToolStripMenuItem toolStripMenuPay;
        private ToolStripMenuItem toolStripMenuItemCreditRecharge;
        private Panel rechargeCredit;
    }
}
