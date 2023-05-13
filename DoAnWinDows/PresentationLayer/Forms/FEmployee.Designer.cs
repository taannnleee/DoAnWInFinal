namespace DoAnWinDows.PresentationLayer.Forms
{
    partial class FEmployee
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FEmployee));
            sidebar = new FlowLayoutPanel();
            panel2 = new Panel();
            menuButton = new PictureBox();
            panel6 = new Panel();
            button4 = new Button();
            lblMenu = new Label();
            homeContainer = new Panel();
            panel7 = new Panel();
            btnTypeLoan = new Button();
            panel1 = new Panel();
            btnCreditCard = new Button();
            panel5 = new Panel();
            btnWithDraw = new Button();
            loanContainer = new Panel();
            btnRecharge = new Button();
            panel12 = new Panel();
            btnTypeOfLoan = new Button();
            panel11 = new Panel();
            button1 = new Button();
            panel4 = new Panel();
            btnHome = new Button();
            panel8 = new Panel();
            btnBankSavings = new Button();
            panel9 = new Panel();
            panel3 = new Panel();
            panel10 = new Panel();
            btnTransactions = new Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            Hometimer = new System.Windows.Forms.Timer(components);
            panelEmployee = new Panel();
            panelLoan = new Panel();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripMenuItem();
            toolStripMenuItem8 = new ToolStripMenuItem();
            panelCreditCard = new Panel();
            menuStrip2 = new MenuStrip();
            createCreditCardToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem9 = new ToolStripMenuItem();
            toolStripMenuItem10 = new ToolStripMenuItem();
            sidebar.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            panel6.SuspendLayout();
            homeContainer.SuspendLayout();
            panel7.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            loanContainer.SuspendLayout();
            panel12.SuspendLayout();
            panel11.SuspendLayout();
            panel4.SuspendLayout();
            panel8.SuspendLayout();
            panel3.SuspendLayout();
            panelLoan.SuspendLayout();
            menuStrip1.SuspendLayout();
            panelCreditCard.SuspendLayout();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(64, 64, 64);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(homeContainer);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(205, 661);
            sidebar.MinimumSize = new Size(61, 661);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(205, 661);
            sidebar.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(menuButton);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(lblMenu);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 61);
            panel2.TabIndex = 2;
            // 
            // menuButton
            // 
            menuButton.BackColor = Color.Transparent;
            menuButton.BorderStyle = BorderStyle.FixedSingle;
            menuButton.Cursor = Cursors.Hand;
            menuButton.Image = (Image)resources.GetObject("menuButton.Image");
            menuButton.Location = new Point(3, 3);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(53, 50);
            menuButton.SizeMode = PictureBoxSizeMode.StretchImage;
            menuButton.TabIndex = 0;
            menuButton.TabStop = false;
            menuButton.Click += menuButton_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(button4);
            panel6.Location = new Point(3, 61);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 42);
            panel6.TabIndex = 6;
            // 
            // button4
            // 
            button4.ImageAlign = ContentAlignment.MiddleRight;
            button4.Location = new Point(57, 3);
            button4.Name = "button4";
            button4.Size = new Size(145, 36);
            button4.TabIndex = 3;
            button4.Text = "Home";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.BackColor = Color.FromArgb(64, 64, 64);
            lblMenu.ForeColor = Color.White;
            lblMenu.Location = new Point(62, 28);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(38, 15);
            lblMenu.TabIndex = 1;
            lblMenu.Text = "Menu";
            // 
            // homeContainer
            // 
            homeContainer.Controls.Add(panel7);
            homeContainer.Controls.Add(panel1);
            homeContainer.Controls.Add(panel5);
            homeContainer.Controls.Add(loanContainer);
            homeContainer.Controls.Add(panel4);
            homeContainer.Controls.Add(panel8);
            homeContainer.Controls.Add(panel3);
            homeContainer.Location = new Point(3, 70);
            homeContainer.MaximumSize = new Size(200, 500);
            homeContainer.MinimumSize = new Size(200, 52);
            homeContainer.Name = "homeContainer";
            homeContainer.Size = new Size(200, 451);
            homeContainer.TabIndex = 6;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnTypeLoan);
            panel7.Location = new Point(0, 299);
            panel7.Name = "panel7";
            panel7.Size = new Size(200, 41);
            panel7.TabIndex = 11;
            // 
            // btnTypeLoan
            // 
            btnTypeLoan.BackColor = Color.FromArgb(64, 64, 64);
            btnTypeLoan.BackgroundImageLayout = ImageLayout.None;
            btnTypeLoan.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnTypeLoan.FlatAppearance.BorderSize = 5000;
            btnTypeLoan.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnTypeLoan.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnTypeLoan.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnTypeLoan.ForeColor = Color.White;
            btnTypeLoan.Image = (Image)resources.GetObject("btnTypeLoan.Image");
            btnTypeLoan.ImageAlign = ContentAlignment.MiddleLeft;
            btnTypeLoan.Location = new Point(5, 0);
            btnTypeLoan.Name = "btnTypeLoan";
            btnTypeLoan.Padding = new Padding(30, 0, 0, 0);
            btnTypeLoan.Size = new Size(203, 49);
            btnTypeLoan.TabIndex = 10;
            btnTypeLoan.Text = "        Type of Loan";
            btnTypeLoan.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCreditCard);
            panel1.Location = new Point(3, 251);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 42);
            panel1.TabIndex = 2;
            // 
            // btnCreditCard
            // 
            btnCreditCard.BackColor = Color.FromArgb(64, 64, 64);
            btnCreditCard.BackgroundImageLayout = ImageLayout.None;
            btnCreditCard.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnCreditCard.FlatAppearance.BorderSize = 5000;
            btnCreditCard.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnCreditCard.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnCreditCard.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreditCard.ForeColor = Color.White;
            btnCreditCard.Image = (Image)resources.GetObject("btnCreditCard.Image");
            btnCreditCard.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreditCard.Location = new Point(-1, 0);
            btnCreditCard.Name = "btnCreditCard";
            btnCreditCard.Padding = new Padding(30, 0, 0, 0);
            btnCreditCard.Size = new Size(206, 49);
            btnCreditCard.TabIndex = 4;
            btnCreditCard.Text = "        CreditCard";
            btnCreditCard.UseVisualStyleBackColor = false;
            btnCreditCard.Click += btnCreditCard_Click;
            btnCreditCard.Leave += btnCreditCard_Leave;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnWithDraw);
            panel5.Location = new Point(9, 99);
            panel5.Name = "panel5";
            panel5.Size = new Size(191, 43);
            panel5.TabIndex = 7;
            // 
            // btnWithDraw
            // 
            btnWithDraw.BackColor = Color.FromArgb(64, 64, 64);
            btnWithDraw.BackgroundImageLayout = ImageLayout.None;
            btnWithDraw.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnWithDraw.FlatAppearance.BorderSize = 5000;
            btnWithDraw.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnWithDraw.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnWithDraw.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnWithDraw.ForeColor = Color.White;
            btnWithDraw.Image = (Image)resources.GetObject("btnWithDraw.Image");
            btnWithDraw.ImageAlign = ContentAlignment.MiddleLeft;
            btnWithDraw.Location = new Point(0, 0);
            btnWithDraw.Name = "btnWithDraw";
            btnWithDraw.Padding = new Padding(30, 0, 0, 0);
            btnWithDraw.Size = new Size(206, 42);
            btnWithDraw.TabIndex = 7;
            btnWithDraw.Text = "        WithDraw";
            btnWithDraw.UseVisualStyleBackColor = false;
            btnWithDraw.Click += btnWithDraw_Click;
            // 
            // loanContainer
            // 
            loanContainer.Controls.Add(btnRecharge);
            loanContainer.Controls.Add(panel12);
            loanContainer.Controls.Add(panel11);
            loanContainer.Location = new Point(5, 194);
            loanContainer.MaximumSize = new Size(200, 193);
            loanContainer.MinimumSize = new Size(200, 53);
            loanContainer.Name = "loanContainer";
            loanContainer.Size = new Size(200, 53);
            loanContainer.TabIndex = 10;
            // 
            // btnRecharge
            // 
            btnRecharge.BackColor = Color.FromArgb(64, 64, 64);
            btnRecharge.BackgroundImageLayout = ImageLayout.None;
            btnRecharge.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnRecharge.FlatAppearance.BorderSize = 5000;
            btnRecharge.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnRecharge.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnRecharge.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRecharge.ForeColor = Color.White;
            btnRecharge.Image = (Image)resources.GetObject("btnRecharge.Image");
            btnRecharge.ImageAlign = ContentAlignment.MiddleLeft;
            btnRecharge.Location = new Point(1, 4);
            btnRecharge.Name = "btnRecharge";
            btnRecharge.Padding = new Padding(30, 0, 0, 0);
            btnRecharge.Size = new Size(206, 49);
            btnRecharge.TabIndex = 6;
            btnRecharge.Text = "        Recharge";
            btnRecharge.UseVisualStyleBackColor = false;
            btnRecharge.Click += btnRecharge_Click;
            // 
            // panel12
            // 
            panel12.Controls.Add(btnTypeOfLoan);
            panel12.Location = new Point(24, 105);
            panel12.Name = "panel12";
            panel12.Size = new Size(198, 41);
            panel12.TabIndex = 10;
            // 
            // btnTypeOfLoan
            // 
            btnTypeOfLoan.BackColor = Color.FromArgb(64, 64, 64);
            btnTypeOfLoan.BackgroundImageLayout = ImageLayout.None;
            btnTypeOfLoan.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnTypeOfLoan.FlatAppearance.BorderSize = 5000;
            btnTypeOfLoan.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnTypeOfLoan.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnTypeOfLoan.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnTypeOfLoan.ForeColor = Color.White;
            btnTypeOfLoan.Image = (Image)resources.GetObject("btnTypeOfLoan.Image");
            btnTypeOfLoan.ImageAlign = ContentAlignment.MiddleLeft;
            btnTypeOfLoan.Location = new Point(0, -8);
            btnTypeOfLoan.Name = "btnTypeOfLoan";
            btnTypeOfLoan.Padding = new Padding(30, 0, 0, 0);
            btnTypeOfLoan.Size = new Size(206, 49);
            btnTypeOfLoan.TabIndex = 8;
            btnTypeOfLoan.Text = "        Type of Loan";
            btnTypeOfLoan.UseVisualStyleBackColor = false;
            // 
            // panel11
            // 
            panel11.Controls.Add(button1);
            panel11.Location = new Point(9, 58);
            panel11.Name = "panel11";
            panel11.Size = new Size(198, 41);
            panel11.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button1.FlatAppearance.BorderSize = 5000;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(15, -8);
            button1.Name = "button1";
            button1.Padding = new Padding(30, 0, 0, 0);
            button1.Size = new Size(206, 49);
            button1.TabIndex = 9;
            button1.Text = "        Type of Loan";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnHome);
            panel4.Location = new Point(0, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(210, 51);
            panel4.TabIndex = 4;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(64, 64, 64);
            btnHome.BackgroundImageLayout = ImageLayout.None;
            btnHome.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnHome.FlatAppearance.BorderSize = 5000;
            btnHome.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnHome.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.ForeColor = Color.White;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, -1);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(30, 0, 0, 0);
            btnHome.Size = new Size(202, 49);
            btnHome.TabIndex = 3;
            btnHome.Text = "        Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnBankSavings);
            panel8.Controls.Add(panel9);
            panel8.Location = new Point(5, 147);
            panel8.Name = "panel8";
            panel8.Size = new Size(199, 40);
            panel8.TabIndex = 7;
            // 
            // btnBankSavings
            // 
            btnBankSavings.BackColor = Color.FromArgb(64, 64, 64);
            btnBankSavings.BackgroundImageLayout = ImageLayout.None;
            btnBankSavings.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnBankSavings.FlatAppearance.BorderSize = 5000;
            btnBankSavings.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnBankSavings.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnBankSavings.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBankSavings.ForeColor = Color.White;
            btnBankSavings.Image = (Image)resources.GetObject("btnBankSavings.Image");
            btnBankSavings.ImageAlign = ContentAlignment.MiddleLeft;
            btnBankSavings.Location = new Point(0, -12);
            btnBankSavings.Name = "btnBankSavings";
            btnBankSavings.Padding = new Padding(30, 0, 0, 0);
            btnBankSavings.Size = new Size(206, 49);
            btnBankSavings.TabIndex = 8;
            btnBankSavings.Text = "        BankSavings";
            btnBankSavings.UseVisualStyleBackColor = false;
            btnBankSavings.Click += btnBankSavings_Click;
            // 
            // panel9
            // 
            panel9.Location = new Point(0, 44);
            panel9.Name = "panel9";
            panel9.Size = new Size(194, 56);
            panel9.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel10);
            panel3.Controls.Add(btnTransactions);
            panel3.Location = new Point(2, 57);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 42);
            panel3.TabIndex = 4;
            // 
            // panel10
            // 
            panel10.Location = new Point(3, 39);
            panel10.Name = "panel10";
            panel10.Size = new Size(197, 42);
            panel10.TabIndex = 9;
            // 
            // btnTransactions
            // 
            btnTransactions.BackColor = Color.FromArgb(64, 64, 64);
            btnTransactions.BackgroundImageLayout = ImageLayout.None;
            btnTransactions.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnTransactions.FlatAppearance.BorderSize = 5000;
            btnTransactions.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnTransactions.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnTransactions.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnTransactions.ForeColor = Color.White;
            btnTransactions.Image = (Image)resources.GetObject("btnTransactions.Image");
            btnTransactions.ImageAlign = ContentAlignment.MiddleLeft;
            btnTransactions.Location = new Point(3, -7);
            btnTransactions.Name = "btnTransactions";
            btnTransactions.Padding = new Padding(30, 0, 0, 0);
            btnTransactions.Size = new Size(206, 49);
            btnTransactions.TabIndex = 5;
            btnTransactions.Text = "        Transactions";
            btnTransactions.UseVisualStyleBackColor = false;
            btnTransactions.Click += btnTransactions_Click;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 8;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // Hometimer
            // 
            Hometimer.Interval = 8;
            Hometimer.Tick += Hometimer_Tick;
            // 
            // panelEmployee
            // 
            panelEmployee.Location = new Point(214, 41);
            panelEmployee.Name = "panelEmployee";
            panelEmployee.Size = new Size(1071, 517);
            panelEmployee.TabIndex = 2;
            // 
            // panelLoan
            // 
            panelLoan.Controls.Add(menuStrip1);
            panelLoan.Location = new Point(214, 6);
            panelLoan.Name = "panelLoan";
            panelLoan.Size = new Size(1071, 29);
            panelLoan.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientInactiveCaption;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem5 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1071, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(68, 20);
            toolStripMenuItem1.Text = "Unsecure";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(208, 22);
            toolStripMenuItem2.Text = "Loan";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(208, 22);
            toolStripMenuItem3.Text = "List of Loan Account";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(208, 22);
            toolStripMenuItem4.Text = "Blacklist of Loan Account";
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem6, toolStripMenuItem7, toolStripMenuItem8 });
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(71, 20);
            toolStripMenuItem5.Text = "Mortgage";
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(208, 22);
            toolStripMenuItem6.Text = "Loan";
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(208, 22);
            toolStripMenuItem7.Text = "List of Loan Account";
            // 
            // toolStripMenuItem8
            // 
            toolStripMenuItem8.Name = "toolStripMenuItem8";
            toolStripMenuItem8.Size = new Size(208, 22);
            toolStripMenuItem8.Text = "Blacklist of Loan Account";
            // 
            // panelCreditCard
            // 
            panelCreditCard.Controls.Add(menuStrip2);
            panelCreditCard.Location = new Point(211, 6);
            panelCreditCard.Name = "panelCreditCard";
            panelCreditCard.Size = new Size(331, 25);
            panelCreditCard.TabIndex = 0;
            panelCreditCard.Visible = false;
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = SystemColors.GradientInactiveCaption;
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { createCreditCardToolStripMenuItem, toolStripMenuItem9, toolStripMenuItem10 });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(331, 24);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // createCreditCardToolStripMenuItem
            // 
            createCreditCardToolStripMenuItem.Name = "createCreditCardToolStripMenuItem";
            createCreditCardToolStripMenuItem.Size = new Size(110, 20);
            createCreditCardToolStripMenuItem.Text = "CreateCreditCard";
            // 
            // toolStripMenuItem9
            // 
            toolStripMenuItem9.Name = "toolStripMenuItem9";
            toolStripMenuItem9.Size = new Size(83, 20);
            toolStripMenuItem9.Text = "PayByCredit";
            // 
            // toolStripMenuItem10
            // 
            toolStripMenuItem10.Name = "toolStripMenuItem10";
            toolStripMenuItem10.Size = new Size(100, 20);
            toolStripMenuItem10.Text = "CreditRecharge";
            // 
            // FEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1284, 749);
            Controls.Add(panelLoan);
            Controls.Add(panelEmployee);
            Controls.Add(panelCreditCard);
            Controls.Add(sidebar);
            Name = "FEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FEmployee";
            sidebar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            panel6.ResumeLayout(false);
            homeContainer.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            loanContainer.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panelLoan.ResumeLayout(false);
            panelLoan.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelCreditCard.ResumeLayout(false);
            panelCreditCard.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel panel1;
        private PictureBox menuButton;
        private Label lblMenu;
        private System.Windows.Forms.Timer sidebarTimer;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button btnHome;
        private Panel panel6;
        private Button button4;
        private Button btnCreditCard;
        private System.Windows.Forms.Timer Hometimer;
        private Panel homeContainer;
        private Button btnTypeOfLoan;
        private Panel panel8;
        private Button btnBankSavings;
        private Panel panel9;
        private Button btnWithDraw;
        private Panel panel10;
        private Button btnRecharge;
        private Button btnTransactions;
        private Panel panel5;
        private Panel panel11;
        private Panel panelEmployee;
        private Button btnTypeLoan;
        private Panel loanContainer;
        private Panel panel12;
        private Button button1;
        private Panel panel7;
        private Panel panelLoan;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem toolStripMenuItem8;
        private Panel panelCreditCard;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem createCreditCardToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem9;
        private ToolStripMenuItem toolStripMenuItem10;
    }
}