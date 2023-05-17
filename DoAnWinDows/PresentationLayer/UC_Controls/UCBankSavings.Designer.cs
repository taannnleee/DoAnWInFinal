namespace DoAnWinDows
{
    partial class UCBankSavings
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
            gvQuanLy = new DataGridView();
            label3 = new Label();
            btnTatToan = new Button();
            btnThem = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnRefresh = new Button();
            btnInterest = new Button();
            lblAccountNumber = new Label();
            lblAmount = new Label();
            lblInterestRate = new Label();
            lblCreatedDate = new Label();
            txtAccountNumber = new TextBox();
            txtAmount = new TextBox();
            dtpCreatedDate = new DateTimePicker();
            cboInterestRate = new ComboBox();
            grbRenewalOption = new GroupBox();
            rdbtnAutoClose = new RadioButton();
            rdbtnAutoRenew = new RadioButton();
            rdbtnPrincipalAutoRenew = new RadioButton();
            btnCheck = new Button();
            rtxtInformation = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)gvQuanLy).BeginInit();
            grbRenewalOption.SuspendLayout();
            SuspendLayout();
            // 
            // gvQuanLy
            // 
            gvQuanLy.Anchor = AnchorStyles.Top;
            gvQuanLy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvQuanLy.Location = new Point(39, 317);
            gvQuanLy.Name = "gvQuanLy";
            gvQuanLy.RowHeadersWidth = 51;
            gvQuanLy.RowTemplate.Height = 29;
            gvQuanLy.Size = new Size(1147, 378);
            gvQuanLy.TabIndex = 268;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(493, 0);
            label3.Name = "label3";
            label3.Size = new Size(251, 45);
            label3.TabIndex = 266;
            label3.Text = "BANKSAVINGS";
            // 
            // btnTatToan
            // 
            btnTatToan.Anchor = AnchorStyles.Top;
            btnTatToan.AutoSize = true;
            btnTatToan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTatToan.Location = new Point(857, 279);
            btnTatToan.Name = "btnTatToan";
            btnTatToan.Size = new Size(129, 30);
            btnTatToan.TabIndex = 265;
            btnTatToan.Text = "FinalSettlement";
            btnTatToan.UseVisualStyleBackColor = true;
            btnTatToan.Click += btnTatToan_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top;
            btnThem.AutoSize = true;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.Location = new Point(656, 279);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(103, 30);
            btnThem.TabIndex = 264;
            btnThem.Text = "Add";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top;
            btnSearch.Location = new Point(1082, 245);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(63, 29);
            btnSearch.TabIndex = 283;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top;
            txtSearch.Location = new Point(656, 245);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(420, 27);
            txtSearch.TabIndex = 284;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top;
            btnRefresh.Location = new Point(1152, 245);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(34, 29);
            btnRefresh.TabIndex = 285;
            btnRefresh.Text = "RF";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnInterest
            // 
            btnInterest.Anchor = AnchorStyles.Top;
            btnInterest.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnInterest.Location = new Point(1083, 280);
            btnInterest.Name = "btnInterest";
            btnInterest.Size = new Size(103, 29);
            btnInterest.TabIndex = 286;
            btnInterest.Text = "Interest";
            btnInterest.UseVisualStyleBackColor = true;
            btnInterest.Click += btnInterest_Click;
            // 
            // lblAccountNumber
            // 
            lblAccountNumber.Anchor = AnchorStyles.Top;
            lblAccountNumber.AutoSize = true;
            lblAccountNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAccountNumber.Location = new Point(156, 51);
            lblAccountNumber.Name = "lblAccountNumber";
            lblAccountNumber.Size = new Size(125, 20);
            lblAccountNumber.TabIndex = 287;
            lblAccountNumber.Text = "AccountNumber";
            // 
            // lblAmount
            // 
            lblAmount.Anchor = AnchorStyles.Top;
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAmount.Location = new Point(156, 82);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(67, 20);
            lblAmount.TabIndex = 288;
            lblAmount.Text = "Amount";
            // 
            // lblInterestRate
            // 
            lblInterestRate.Anchor = AnchorStyles.Top;
            lblInterestRate.AutoSize = true;
            lblInterestRate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblInterestRate.Location = new Point(156, 114);
            lblInterestRate.Name = "lblInterestRate";
            lblInterestRate.Size = new Size(96, 20);
            lblInterestRate.TabIndex = 289;
            lblInterestRate.Text = "Interset rate";
            // 
            // lblCreatedDate
            // 
            lblCreatedDate.Anchor = AnchorStyles.Top;
            lblCreatedDate.AutoSize = true;
            lblCreatedDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCreatedDate.Location = new Point(158, 286);
            lblCreatedDate.Name = "lblCreatedDate";
            lblCreatedDate.Size = new Size(100, 20);
            lblCreatedDate.TabIndex = 290;
            lblCreatedDate.Text = "Created Date";
            // 
            // txtAccountNumber
            // 
            txtAccountNumber.Anchor = AnchorStyles.Top;
            txtAccountNumber.Location = new Point(299, 48);
            txtAccountNumber.Name = "txtAccountNumber";
            txtAccountNumber.Size = new Size(150, 27);
            txtAccountNumber.TabIndex = 292;
            // 
            // txtAmount
            // 
            txtAmount.Anchor = AnchorStyles.Top;
            txtAmount.Location = new Point(275, 83);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(221, 27);
            txtAmount.TabIndex = 293;
            // 
            // dtpCreatedDate
            // 
            dtpCreatedDate.Anchor = AnchorStyles.Top;
            dtpCreatedDate.Location = new Point(261, 281);
            dtpCreatedDate.Name = "dtpCreatedDate";
            dtpCreatedDate.Size = new Size(221, 27);
            dtpCreatedDate.TabIndex = 294;
            // 
            // cboInterestRate
            // 
            cboInterestRate.Anchor = AnchorStyles.Top;
            cboInterestRate.FormattingEnabled = true;
            cboInterestRate.Items.AddRange(new object[] { "3 month 3.0%", "6 month 3.5%", "9 month 4.0%", "12 month 4.5%" });
            cboInterestRate.Location = new Point(275, 116);
            cboInterestRate.Name = "cboInterestRate";
            cboInterestRate.Size = new Size(221, 28);
            cboInterestRate.TabIndex = 295;
            // 
            // grbRenewalOption
            // 
            grbRenewalOption.Anchor = AnchorStyles.Top;
            grbRenewalOption.Controls.Add(rdbtnAutoClose);
            grbRenewalOption.Controls.Add(rdbtnAutoRenew);
            grbRenewalOption.Controls.Add(rdbtnPrincipalAutoRenew);
            grbRenewalOption.FlatStyle = FlatStyle.System;
            grbRenewalOption.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grbRenewalOption.Location = new Point(158, 150);
            grbRenewalOption.Name = "grbRenewalOption";
            grbRenewalOption.Size = new Size(291, 125);
            grbRenewalOption.TabIndex = 299;
            grbRenewalOption.TabStop = false;
            grbRenewalOption.Text = "Renewal Option :";
            // 
            // rdbtnAutoClose
            // 
            rdbtnAutoClose.AutoSize = true;
            rdbtnAutoClose.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rdbtnAutoClose.Location = new Point(103, 86);
            rdbtnAutoClose.Name = "rdbtnAutoClose";
            rdbtnAutoClose.Size = new Size(103, 24);
            rdbtnAutoClose.TabIndex = 301;
            rdbtnAutoClose.TabStop = true;
            rdbtnAutoClose.Text = "Auto Close";
            rdbtnAutoClose.UseVisualStyleBackColor = true;
            // 
            // rdbtnAutoRenew
            // 
            rdbtnAutoRenew.AutoSize = true;
            rdbtnAutoRenew.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rdbtnAutoRenew.Location = new Point(103, 56);
            rdbtnAutoRenew.Name = "rdbtnAutoRenew";
            rdbtnAutoRenew.Size = new Size(112, 24);
            rdbtnAutoRenew.TabIndex = 300;
            rdbtnAutoRenew.TabStop = true;
            rdbtnAutoRenew.Text = "Auto Renew";
            rdbtnAutoRenew.UseVisualStyleBackColor = true;
            // 
            // rdbtnPrincipalAutoRenew
            // 
            rdbtnPrincipalAutoRenew.AutoSize = true;
            rdbtnPrincipalAutoRenew.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rdbtnPrincipalAutoRenew.Location = new Point(103, 26);
            rdbtnPrincipalAutoRenew.Name = "rdbtnPrincipalAutoRenew";
            rdbtnPrincipalAutoRenew.Size = new Size(176, 24);
            rdbtnPrincipalAutoRenew.TabIndex = 299;
            rdbtnPrincipalAutoRenew.TabStop = true;
            rdbtnPrincipalAutoRenew.Text = "Principal Auto Renew";
            rdbtnPrincipalAutoRenew.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            btnCheck.Anchor = AnchorStyles.Top;
            btnCheck.BackgroundImage = Properties.Resources.maxresdefault;
            btnCheck.BackgroundImageLayout = ImageLayout.Stretch;
            btnCheck.Location = new Point(455, 48);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(41, 29);
            btnCheck.TabIndex = 300;
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // rtxtInformation
            // 
            rtxtInformation.Location = new Point(645, 48);
            rtxtInformation.Name = "rtxtInformation";
            rtxtInformation.Size = new Size(541, 191);
            rtxtInformation.TabIndex = 301;
            rtxtInformation.Text = "";
            // 
            // UCBankSavings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(rtxtInformation);
            Controls.Add(btnCheck);
            Controls.Add(grbRenewalOption);
            Controls.Add(cboInterestRate);
            Controls.Add(dtpCreatedDate);
            Controls.Add(txtAmount);
            Controls.Add(txtAccountNumber);
            Controls.Add(lblCreatedDate);
            Controls.Add(lblInterestRate);
            Controls.Add(lblAmount);
            Controls.Add(lblAccountNumber);
            Controls.Add(btnInterest);
            Controls.Add(btnRefresh);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(gvQuanLy);
            Controls.Add(label3);
            Controls.Add(btnTatToan);
            Controls.Add(btnThem);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UCBankSavings";
            Size = new Size(1229, 759);
            Load += UCBankSavings_Load;
            ((System.ComponentModel.ISupportInitialize)gvQuanLy).EndInit();
            grbRenewalOption.ResumeLayout(false);
            grbRenewalOption.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView gvQuanLy;
        private Label label3;
        private Button btnTatToan;
        private Button btnThem;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnRefresh;
        private Button btnInterest;
        private Label lblAccountNumber;
        private Label lblAmount;
        private Label lblInterestRate;
        private Label lblCreatedDate;
        private TextBox txtAccountNumber;
        private TextBox txtAmount;
        private DateTimePicker dtpCreatedDate;
        private ComboBox cboInterestRate;
        private GroupBox grbRenewalOption;
        private RadioButton rdbtnAutoClose;
        private RadioButton rdbtnAutoRenew;
        private RadioButton rdbtnPrincipalAutoRenew;
        private Button btnCheck;
        private RichTextBox rtxtInformation;
    }
}
