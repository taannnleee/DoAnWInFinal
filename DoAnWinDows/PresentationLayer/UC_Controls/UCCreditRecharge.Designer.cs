namespace DoAnWinDows.PresentationLayer.UC_Controls
{
    partial class UCCreditRecharge
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
            btnCheck = new Button();
            gvCreditCard = new DataGridView();
            txtCvvCode = new TextBox();
            lblCvvCode = new Label();
            label1 = new Label();
            txtDepositAmount = new TextBox();
            btnRecharge = new Button();
            lblDepositAmount = new Label();
            ((System.ComponentModel.ISupportInitialize)gvCreditCard).BeginInit();
            SuspendLayout();
            // 
            // btnCheck
            // 
            btnCheck.AutoSize = true;
            btnCheck.Location = new Point(369, 86);
            btnCheck.Margin = new Padding(3, 2, 3, 2);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(82, 25);
            btnCheck.TabIndex = 331;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // gvCreditCard
            // 
            gvCreditCard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvCreditCard.Location = new Point(483, 139);
            gvCreditCard.Name = "gvCreditCard";
            gvCreditCard.RowTemplate.Height = 25;
            gvCreditCard.Size = new Size(226, 134);
            gvCreditCard.TabIndex = 327;
            gvCreditCard.CellClick += gvCreditCard_CellClick;
            // 
            // txtCvvCode
            // 
            txtCvvCode.Location = new Point(153, 86);
            txtCvvCode.Margin = new Padding(3, 2, 3, 2);
            txtCvvCode.Name = "txtCvvCode";
            txtCvvCode.Size = new Size(199, 23);
            txtCvvCode.TabIndex = 325;
            // 
            // lblCvvCode
            // 
            lblCvvCode.AutoSize = true;
            lblCvvCode.Location = new Point(65, 89);
            lblCvvCode.Name = "lblCvvCode";
            lblCvvCode.Size = new Size(55, 15);
            lblCvvCode.TabIndex = 323;
            lblCvvCode.Text = "CvvCode";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 182);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 332;
            // 
            // txtDepositAmount
            // 
            txtDepositAmount.Location = new Point(153, 174);
            txtDepositAmount.Margin = new Padding(3, 2, 3, 2);
            txtDepositAmount.Name = "txtDepositAmount";
            txtDepositAmount.Size = new Size(199, 23);
            txtDepositAmount.TabIndex = 333;
            // 
            // btnRecharge
            // 
            btnRecharge.AutoSize = true;
            btnRecharge.Location = new Point(255, 248);
            btnRecharge.Margin = new Padding(3, 2, 3, 2);
            btnRecharge.Name = "btnRecharge";
            btnRecharge.Size = new Size(82, 25);
            btnRecharge.TabIndex = 334;
            btnRecharge.Text = "Recharge";
            btnRecharge.UseVisualStyleBackColor = true;
            btnRecharge.Click += btnRecharge_Click;
            // 
            // lblDepositAmount
            // 
            lblDepositAmount.AutoSize = true;
            lblDepositAmount.Location = new Point(55, 182);
            lblDepositAmount.Name = "lblDepositAmount";
            lblDepositAmount.Size = new Size(91, 15);
            lblDepositAmount.TabIndex = 335;
            lblDepositAmount.Text = "DepositAmount";
            // 
            // UCCreditRecharge
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblDepositAmount);
            Controls.Add(btnRecharge);
            Controls.Add(txtDepositAmount);
            Controls.Add(label1);
            Controls.Add(btnCheck);
            Controls.Add(gvCreditCard);
            Controls.Add(txtCvvCode);
            Controls.Add(lblCvvCode);
            Name = "UCCreditRecharge";
            Size = new Size(813, 535);
            ((System.ComponentModel.ISupportInitialize)gvCreditCard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCheck;
        private DataGridView gvCreditCard;
        private TextBox txtCvvCode;
        private Label lblCvvCode;
        private Label label1;
        private TextBox txtDepositAmount;
        private Button btnRecharge;
        private Label lblDepositAmount;
    }
}
