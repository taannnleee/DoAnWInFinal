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
            panel12 = new Panel();
            btnSettingPassWord = new Button();
            panel8 = new Panel();
            btnRecharge = new Button();
            panel10 = new Panel();
            panel11 = new Panel();
            btnTypeLoan = new Button();
            panel9 = new Panel();
            btnCreditCard = new Button();
            panel4 = new Panel();
            btnHome = new Button();
            panel3 = new Panel();
            panel1 = new Panel();
            btnWithDraw = new Button();
            btnBankSavings = new Button();
            panel5 = new Panel();
            panel7 = new Panel();
            btnTransactions = new Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            Hometimer = new System.Windows.Forms.Timer(components);
            panelEmployee = new Panel();
            sidebar.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            panel6.SuspendLayout();
            homeContainer.SuspendLayout();
            panel12.SuspendLayout();
            panel8.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
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
            menuButton.Location = new Point(3, 9);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(30, 44);
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
            lblMenu.BorderStyle = BorderStyle.Fixed3D;
            lblMenu.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblMenu.ForeColor = Color.Cyan;
            lblMenu.Location = new Point(60, 6);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(104, 47);
            lblMenu.TabIndex = 1;
            lblMenu.Text = "Menu";
            // 
            // homeContainer
            // 
            homeContainer.Controls.Add(panel12);
            homeContainer.Controls.Add(panel8);
            homeContainer.Controls.Add(panel10);
            homeContainer.Controls.Add(panel9);
            homeContainer.Controls.Add(panel4);
            homeContainer.Controls.Add(panel3);
            homeContainer.Controls.Add(btnBankSavings);
            homeContainer.Controls.Add(panel5);
            homeContainer.Location = new Point(3, 70);
            homeContainer.MaximumSize = new Size(200, 431);
            homeContainer.MinimumSize = new Size(200, 69);
            homeContainer.Name = "homeContainer";
            homeContainer.Size = new Size(200, 69);
            homeContainer.TabIndex = 6;
            // 
            // panel12
            // 
            panel12.Controls.Add(btnSettingPassWord);
            panel12.Location = new Point(-1, 379);
            panel12.Name = "panel12";
            panel12.Size = new Size(200, 55);
            panel12.TabIndex = 5;
            // 
            // btnSettingPassWord
            // 
            btnSettingPassWord.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSettingPassWord.BackColor = Color.FromArgb(64, 64, 64);
            btnSettingPassWord.BackgroundImageLayout = ImageLayout.None;
            btnSettingPassWord.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnSettingPassWord.FlatAppearance.BorderSize = 5000;
            btnSettingPassWord.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnSettingPassWord.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnSettingPassWord.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSettingPassWord.ForeColor = Color.White;
            btnSettingPassWord.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettingPassWord.Location = new Point(3, 4);
            btnSettingPassWord.Name = "btnSettingPassWord";
            btnSettingPassWord.Padding = new Padding(30, 0, 0, 0);
            btnSettingPassWord.Size = new Size(199, 48);
            btnSettingPassWord.TabIndex = 4;
            btnSettingPassWord.Text = "  Setting PassWord";
            btnSettingPassWord.TextAlign = ContentAlignment.MiddleRight;
            btnSettingPassWord.UseVisualStyleBackColor = false;
            btnSettingPassWord.Click += btnSettingPassWord_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnRecharge);
            panel8.Location = new Point(17, 237);
            panel8.Name = "panel8";
            panel8.Size = new Size(183, 52);
            panel8.TabIndex = 6;
            // 
            // btnRecharge
            // 
            btnRecharge.BackColor = Color.FromArgb(64, 64, 64);
            btnRecharge.BackgroundImageLayout = ImageLayout.None;
            btnRecharge.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnRecharge.FlatAppearance.BorderSize = 5000;
            btnRecharge.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnRecharge.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnRecharge.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRecharge.ForeColor = Color.White;
            btnRecharge.Image = (Image)resources.GetObject("btnRecharge.Image");
            btnRecharge.ImageAlign = ContentAlignment.MiddleLeft;
            btnRecharge.Location = new Point(-1, -10);
            btnRecharge.Name = "btnRecharge";
            btnRecharge.Padding = new Padding(30, 0, 0, 0);
            btnRecharge.Size = new Size(206, 63);
            btnRecharge.TabIndex = 6;
            btnRecharge.Text = "        Recharge";
            btnRecharge.UseVisualStyleBackColor = false;
            btnRecharge.Click += btnRecharge_Click;
            // 
            // panel10
            // 
            panel10.Controls.Add(panel11);
            panel10.Controls.Add(btnTypeLoan);
            panel10.Location = new Point(16, 338);
            panel10.Name = "panel10";
            panel10.Size = new Size(183, 44);
            panel10.TabIndex = 11;
            // 
            // panel11
            // 
            panel11.Location = new Point(1, 49);
            panel11.Name = "panel11";
            panel11.Size = new Size(180, 65);
            panel11.TabIndex = 12;
            // 
            // btnTypeLoan
            // 
            btnTypeLoan.BackColor = Color.FromArgb(64, 64, 64);
            btnTypeLoan.BackgroundImageLayout = ImageLayout.None;
            btnTypeLoan.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnTypeLoan.FlatAppearance.BorderSize = 5000;
            btnTypeLoan.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnTypeLoan.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnTypeLoan.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnTypeLoan.ForeColor = Color.White;
            btnTypeLoan.Image = (Image)resources.GetObject("btnTypeLoan.Image");
            btnTypeLoan.ImageAlign = ContentAlignment.MiddleLeft;
            btnTypeLoan.Location = new Point(0, -6);
            btnTypeLoan.Name = "btnTypeLoan";
            btnTypeLoan.Padding = new Padding(30, 0, 0, 0);
            btnTypeLoan.Size = new Size(203, 49);
            btnTypeLoan.TabIndex = 10;
            btnTypeLoan.Text = "        Type of Loan";
            btnTypeLoan.UseVisualStyleBackColor = false;
            btnTypeLoan.Click += btnTypeLoan_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(btnCreditCard);
            panel9.Location = new Point(16, 292);
            panel9.Name = "panel9";
            panel9.Size = new Size(189, 42);
            panel9.TabIndex = 11;
            // 
            // btnCreditCard
            // 
            btnCreditCard.BackColor = Color.FromArgb(64, 64, 64);
            btnCreditCard.BackgroundImageLayout = ImageLayout.None;
            btnCreditCard.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnCreditCard.FlatAppearance.BorderSize = 5000;
            btnCreditCard.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnCreditCard.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnCreditCard.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreditCard.ForeColor = Color.White;
            btnCreditCard.Image = (Image)resources.GetObject("btnCreditCard.Image");
            btnCreditCard.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreditCard.Location = new Point(1, -5);
            btnCreditCard.Name = "btnCreditCard";
            btnCreditCard.Padding = new Padding(30, 0, 0, 0);
            btnCreditCard.Size = new Size(192, 49);
            btnCreditCard.TabIndex = 4;
            btnCreditCard.Text = "        CreditCard";
            btnCreditCard.UseVisualStyleBackColor = false;
            btnCreditCard.Click += btnCreditCard_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnHome);
            panel4.Location = new Point(0, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(210, 68);
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
            btnHome.Location = new Point(1, 3);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(30, 0, 0, 0);
            btnHome.Size = new Size(202, 61);
            btnHome.TabIndex = 3;
            btnHome.Text = "        Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(btnWithDraw);
            panel3.Location = new Point(14, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(183, 61);
            panel3.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Location = new Point(1, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 67);
            panel1.TabIndex = 5;
            // 
            // btnWithDraw
            // 
            btnWithDraw.BackColor = Color.FromArgb(64, 64, 64);
            btnWithDraw.BackgroundImageLayout = ImageLayout.None;
            btnWithDraw.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnWithDraw.FlatAppearance.BorderSize = 5000;
            btnWithDraw.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnWithDraw.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnWithDraw.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnWithDraw.ForeColor = Color.White;
            btnWithDraw.Image = (Image)resources.GetObject("btnWithDraw.Image");
            btnWithDraw.ImageAlign = ContentAlignment.MiddleLeft;
            btnWithDraw.Location = new Point(-1, -5);
            btnWithDraw.Name = "btnWithDraw";
            btnWithDraw.Padding = new Padding(30, 0, 0, 0);
            btnWithDraw.Size = new Size(206, 63);
            btnWithDraw.TabIndex = 7;
            btnWithDraw.Text = "        WithDraw";
            btnWithDraw.UseVisualStyleBackColor = false;
            btnWithDraw.Click += btnWithDraw_Click;
            // 
            // btnBankSavings
            // 
            btnBankSavings.BackColor = Color.FromArgb(64, 64, 64);
            btnBankSavings.BackgroundImageLayout = ImageLayout.None;
            btnBankSavings.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnBankSavings.FlatAppearance.BorderSize = 5000;
            btnBankSavings.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnBankSavings.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnBankSavings.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBankSavings.ForeColor = Color.White;
            btnBankSavings.Image = (Image)resources.GetObject("btnBankSavings.Image");
            btnBankSavings.ImageAlign = ContentAlignment.MiddleLeft;
            btnBankSavings.Location = new Point(14, 127);
            btnBankSavings.Name = "btnBankSavings";
            btnBankSavings.Padding = new Padding(30, 0, 0, 0);
            btnBankSavings.Size = new Size(198, 63);
            btnBankSavings.TabIndex = 8;
            btnBankSavings.Text = "        BankSavings";
            btnBankSavings.UseVisualStyleBackColor = false;
            btnBankSavings.Click += btnBankSavings_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(btnTransactions);
            panel5.Location = new Point(15, 184);
            panel5.Name = "panel5";
            panel5.Size = new Size(183, 52);
            panel5.TabIndex = 5;
            // 
            // panel7
            // 
            panel7.Location = new Point(1, 69);
            panel7.Name = "panel7";
            panel7.Size = new Size(183, 52);
            panel7.TabIndex = 6;
            // 
            // btnTransactions
            // 
            btnTransactions.BackColor = Color.FromArgb(64, 64, 64);
            btnTransactions.BackgroundImageLayout = ImageLayout.None;
            btnTransactions.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnTransactions.FlatAppearance.BorderSize = 5000;
            btnTransactions.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnTransactions.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnTransactions.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTransactions.ForeColor = Color.White;
            btnTransactions.Image = (Image)resources.GetObject("btnTransactions.Image");
            btnTransactions.ImageAlign = ContentAlignment.MiddleLeft;
            btnTransactions.Location = new Point(0, -3);
            btnTransactions.Name = "btnTransactions";
            btnTransactions.Padding = new Padding(30, 0, 0, 0);
            btnTransactions.Size = new Size(206, 55);
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
            panelEmployee.Location = new Point(206, 3);
            panelEmployee.Name = "panelEmployee";
            panelEmployee.Size = new Size(1075, 746);
            panelEmployee.TabIndex = 2;
            // 
            // FEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1284, 749);
            Controls.Add(panelEmployee);
            Controls.Add(sidebar);
            Name = "FEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FEmployee";
            Load += FEmployee_Load;
            sidebar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            panel6.ResumeLayout(false);
            homeContainer.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
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
        private Button btnBankSavings;
        private Button btnWithDraw;
        private Button btnRecharge;
        private Button btnTransactions;
        private Panel panelEmployee;
        private Button btnTypeLoan;
        private Panel panel5;
        private Panel panel1;
        private Button btnSettingPassWord;
        private Panel panel7;
        private Panel panel8;
        private Panel panel10;
        private Panel panel9;
        private Panel panel12;
        private Panel panel11;
    }
}