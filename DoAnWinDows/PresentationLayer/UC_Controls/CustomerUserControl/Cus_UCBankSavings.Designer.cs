namespace DoAnWinDows
{
    partial class Cus_UCBankSavings
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
            label3 = new Label();
            grbRenewalOption = new GroupBox();
            rdbtnAutoClose = new RadioButton();
            rdbtnAutoRenew = new RadioButton();
            rdbtnPrincipalAutoRenew = new RadioButton();
            cboInterestRate = new ComboBox();
            dtpCreatedDate = new DateTimePicker();
            txtAmount = new TextBox();
            lblCreatedDate = new Label();
            lblInterestRate = new Label();
            lblAmount = new Label();
            btnInterest = new Button();
            btnFinalSettlement = new Button();
            btnAdd = new Button();
            gvQuanLy = new DataGridView();
            grbRenewalOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvQuanLy).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(315, 15);
            label3.Name = "label3";
            label3.Size = new Size(251, 45);
            label3.TabIndex = 267;
            label3.Text = "BANKSAVINGS";
            // 
            // grbRenewalOption
            // 
            grbRenewalOption.Anchor = AnchorStyles.Top;
            grbRenewalOption.Controls.Add(rdbtnAutoClose);
            grbRenewalOption.Controls.Add(rdbtnAutoRenew);
            grbRenewalOption.Controls.Add(rdbtnPrincipalAutoRenew);
            grbRenewalOption.FlatStyle = FlatStyle.System;
            grbRenewalOption.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grbRenewalOption.Location = new Point(497, 72);
            grbRenewalOption.Name = "grbRenewalOption";
            grbRenewalOption.Size = new Size(291, 125);
            grbRenewalOption.TabIndex = 306;
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
            // cboInterestRate
            // 
            cboInterestRate.Anchor = AnchorStyles.Top;
            cboInterestRate.FormattingEnabled = true;
            cboInterestRate.Items.AddRange(new object[] { "3 month 3.0%", "6 month 3.5%", "9 month 4.0%", "12 month 4.5%" });
            cboInterestRate.Location = new Point(138, 106);
            cboInterestRate.Name = "cboInterestRate";
            cboInterestRate.Size = new Size(221, 28);
            cboInterestRate.TabIndex = 305;
            // 
            // dtpCreatedDate
            // 
            dtpCreatedDate.Anchor = AnchorStyles.Top;
            dtpCreatedDate.Location = new Point(138, 140);
            dtpCreatedDate.Name = "dtpCreatedDate";
            dtpCreatedDate.Size = new Size(221, 27);
            dtpCreatedDate.TabIndex = 304;
            // 
            // txtAmount
            // 
            txtAmount.Anchor = AnchorStyles.Top;
            txtAmount.Location = new Point(138, 73);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(221, 27);
            txtAmount.TabIndex = 303;
            // 
            // lblCreatedDate
            // 
            lblCreatedDate.Anchor = AnchorStyles.Top;
            lblCreatedDate.AutoSize = true;
            lblCreatedDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCreatedDate.Location = new Point(19, 145);
            lblCreatedDate.Name = "lblCreatedDate";
            lblCreatedDate.Size = new Size(100, 20);
            lblCreatedDate.TabIndex = 302;
            lblCreatedDate.Text = "Created Date";
            // 
            // lblInterestRate
            // 
            lblInterestRate.Anchor = AnchorStyles.Top;
            lblInterestRate.AutoSize = true;
            lblInterestRate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblInterestRate.Location = new Point(19, 104);
            lblInterestRate.Name = "lblInterestRate";
            lblInterestRate.Size = new Size(96, 20);
            lblInterestRate.TabIndex = 301;
            lblInterestRate.Text = "Interset rate";
            // 
            // lblAmount
            // 
            lblAmount.Anchor = AnchorStyles.Top;
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAmount.Location = new Point(19, 72);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(67, 20);
            lblAmount.TabIndex = 300;
            lblAmount.Text = "Amount";
            // 
            // btnInterest
            // 
            btnInterest.Anchor = AnchorStyles.Top;
            btnInterest.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnInterest.Location = new Point(545, 213);
            btnInterest.Name = "btnInterest";
            btnInterest.Size = new Size(103, 29);
            btnInterest.TabIndex = 309;
            btnInterest.Text = "Interest";
            btnInterest.UseVisualStyleBackColor = true;
            btnInterest.Click += btnInterest_Click;
            // 
            // btnFinalSettlement
            // 
            btnFinalSettlement.Anchor = AnchorStyles.Top;
            btnFinalSettlement.AutoSize = true;
            btnFinalSettlement.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnFinalSettlement.Location = new Point(397, 212);
            btnFinalSettlement.Name = "btnFinalSettlement";
            btnFinalSettlement.Size = new Size(129, 30);
            btnFinalSettlement.TabIndex = 308;
            btnFinalSettlement.Text = "FinalSettlement";
            btnFinalSettlement.UseVisualStyleBackColor = true;
            btnFinalSettlement.Click += btnFinalSettlement_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top;
            btnAdd.AutoSize = true;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(246, 212);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(103, 30);
            btnAdd.TabIndex = 307;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // gvQuanLy
            // 
            gvQuanLy.Anchor = AnchorStyles.Top;
            gvQuanLy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvQuanLy.Location = new Point(3, 248);
            gvQuanLy.Name = "gvQuanLy";
            gvQuanLy.RowHeadersWidth = 51;
            gvQuanLy.RowTemplate.Height = 29;
            gvQuanLy.Size = new Size(909, 289);
            gvQuanLy.TabIndex = 310;
            // 
            // Cus_UCBankSavings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(gvQuanLy);
            Controls.Add(btnInterest);
            Controls.Add(btnFinalSettlement);
            Controls.Add(btnAdd);
            Controls.Add(grbRenewalOption);
            Controls.Add(cboInterestRate);
            Controls.Add(dtpCreatedDate);
            Controls.Add(txtAmount);
            Controls.Add(lblCreatedDate);
            Controls.Add(lblInterestRate);
            Controls.Add(lblAmount);
            Controls.Add(label3);
            Name = "Cus_UCBankSavings";
            Size = new Size(915, 540);
            Load += Cus_UCBankSavings_Load;
            grbRenewalOption.ResumeLayout(false);
            grbRenewalOption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gvQuanLy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private GroupBox grbRenewalOption;
        private RadioButton rdbtnAutoClose;
        private RadioButton rdbtnAutoRenew;
        private RadioButton rdbtnPrincipalAutoRenew;
        private ComboBox cboInterestRate;
        private DateTimePicker dtpCreatedDate;
        private TextBox txtAmount;
        private Label lblCreatedDate;
        private Label lblInterestRate;
        private Label lblAmount;
        private Button btnInterest;
        private Button btnFinalSettlement;
        private Button btnAdd;
        private DataGridView gvQuanLy;
    }
}
