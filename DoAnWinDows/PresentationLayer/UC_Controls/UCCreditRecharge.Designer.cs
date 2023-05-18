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
            lblCvvCode = new Label();
            label1 = new Label();
            btnRecharge = new Button();
            lblDepositAmount = new Label();
            gvCreditDetails = new DataGridView();
            label3 = new Label();
            txtCvvCode = new TextBox();
            label2 = new Label();
            txtDepositAmount = new TextBox();
            btnClear = new Button();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)gvCreditCard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvCreditDetails).BeginInit();
            SuspendLayout();
            // 
            // btnCheck
            // 
            btnCheck.AutoSize = true;
            btnCheck.Location = new Point(149, 178);
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
            gvCreditCard.Location = new Point(561, 49);
            gvCreditCard.Name = "gvCreditCard";
            gvCreditCard.RowTemplate.Height = 25;
            gvCreditCard.Size = new Size(485, 377);
            gvCreditCard.TabIndex = 327;
            gvCreditCard.CellClick += gvCreditCard_CellClick;
            // 
            // lblCvvCode
            // 
            lblCvvCode.AutoSize = true;
            lblCvvCode.Location = new Point(37, 121);
            lblCvvCode.Name = "lblCvvCode";
            lblCvvCode.Size = new Size(55, 15);
            lblCvvCode.TabIndex = 323;
            lblCvvCode.Text = "CvvCode";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 282);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 332;
            // 
            // btnRecharge
            // 
            btnRecharge.AutoSize = true;
            btnRecharge.Location = new Point(150, 378);
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
            lblDepositAmount.Location = new Point(26, 305);
            lblDepositAmount.Name = "lblDepositAmount";
            lblDepositAmount.Size = new Size(91, 15);
            lblDepositAmount.TabIndex = 335;
            lblDepositAmount.Text = "DepositAmount";
            // 
            // gvCreditDetails
            // 
            gvCreditDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvCreditDetails.Location = new Point(561, 481);
            gvCreditDetails.Name = "gvCreditDetails";
            gvCreditDetails.RowTemplate.Height = 25;
            gvCreditDetails.Size = new Size(485, 150);
            gvCreditDetails.TabIndex = 336;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Location = new Point(135, 140);
            label3.Name = "label3";
            label3.Size = new Size(370, 2);
            label3.TabIndex = 338;
            label3.Text = "label3";
            // 
            // txtCvvCode
            // 
            txtCvvCode.BackColor = Color.SteelBlue;
            txtCvvCode.BorderStyle = BorderStyle.None;
            txtCvvCode.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCvvCode.ForeColor = Color.White;
            txtCvvCode.HideSelection = false;
            txtCvvCode.Location = new Point(135, 110);
            txtCvvCode.Margin = new Padding(3, 2, 3, 2);
            txtCvvCode.Name = "txtCvvCode";
            txtCvvCode.Size = new Size(299, 28);
            txtCvvCode.TabIndex = 337;
            txtCvvCode.TabStop = false;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Location = new Point(135, 324);
            label2.Name = "label2";
            label2.Size = new Size(370, 2);
            label2.TabIndex = 340;
            label2.Text = "label2";
            // 
            // txtDepositAmount
            // 
            txtDepositAmount.BackColor = Color.SteelBlue;
            txtDepositAmount.BorderStyle = BorderStyle.None;
            txtDepositAmount.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDepositAmount.ForeColor = Color.White;
            txtDepositAmount.HideSelection = false;
            txtDepositAmount.Location = new Point(136, 294);
            txtDepositAmount.Margin = new Padding(3, 2, 3, 2);
            txtDepositAmount.Name = "txtDepositAmount";
            txtDepositAmount.Size = new Size(299, 28);
            txtDepositAmount.TabIndex = 339;
            txtDepositAmount.TabStop = false;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(310, 378);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 341;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(561, 22);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 342;
            label4.Text = "CreditCard";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(544, 463);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 343;
            label5.Text = "CreditDetails";
            // 
            // UCCreditRecharge
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnClear);
            Controls.Add(label2);
            Controls.Add(txtDepositAmount);
            Controls.Add(label3);
            Controls.Add(txtCvvCode);
            Controls.Add(gvCreditDetails);
            Controls.Add(lblDepositAmount);
            Controls.Add(btnRecharge);
            Controls.Add(label1);
            Controls.Add(btnCheck);
            Controls.Add(gvCreditCard);
            Controls.Add(lblCvvCode);
            Name = "UCCreditRecharge";
            Size = new Size(1072, 746);
            ((System.ComponentModel.ISupportInitialize)gvCreditCard).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvCreditDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCheck;
        private DataGridView gvCreditCard;
        private Label lblCvvCode;
        private Label label1;
        private Button btnRecharge;
        private Label lblDepositAmount;
        private DataGridView gvCreditDetails;
        private Label label3;
        private TextBox txtCvvCode;
        private Label label2;
        private TextBox txtDepositAmount;
        private Button btnClear;
        private Label label4;
        private Label label5;
    }
}
