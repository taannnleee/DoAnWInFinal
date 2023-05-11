namespace DoAnWinDows.PresentationLayer.UC_Controls
{
    partial class UC_Mortgage_Loan
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
            btnReset = new Button();
            txtAccountNumber = new TextBox();
            btnLoan = new Button();
            txtLoanID = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            comboBoxLoanPeriod = new ComboBox();
            btnSearch = new Button();
            groupBox2 = new GroupBox();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            comboBoxCollateral = new ComboBox();
            label8 = new Label();
            txtLoanAmount = new TextBox();
            richTextBoxInformation = new RichTextBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.Location = new Point(660, 480);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(103, 35);
            btnReset.TabIndex = 17;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // txtAccountNumber
            // 
            txtAccountNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAccountNumber.Location = new Point(26, 83);
            txtAccountNumber.Name = "txtAccountNumber";
            txtAccountNumber.Size = new Size(196, 34);
            txtAccountNumber.TabIndex = 4;
            // 
            // btnLoan
            // 
            btnLoan.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnLoan.Location = new Point(150, 285);
            btnLoan.Name = "btnLoan";
            btnLoan.Size = new Size(103, 35);
            btnLoan.TabIndex = 19;
            btnLoan.Text = "Loan";
            btnLoan.UseVisualStyleBackColor = true;
            btnLoan.Click += btnLoan_Click;
            // 
            // txtLoanID
            // 
            txtLoanID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLoanID.Location = new Point(26, 80);
            txtLoanID.Name = "txtLoanID";
            txtLoanID.Size = new Size(84, 34);
            txtLoanID.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(26, 49);
            label7.Name = "label7";
            label7.Size = new Size(84, 28);
            label7.TabIndex = 17;
            label7.Text = "Loan ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(26, 255);
            label6.Name = "label6";
            label6.Size = new Size(416, 28);
            label6.TabIndex = 16;
            label6.Text = "*Notice: the interest rate of loan is 2% per year";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(120, 219);
            label5.Name = "label5";
            label5.Size = new Size(48, 28);
            label5.TabIndex = 15;
            label5.Text = "Year";
            // 
            // comboBoxLoanPeriod
            // 
            comboBoxLoanPeriod.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxLoanPeriod.FormattingEnabled = true;
            comboBoxLoanPeriod.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            comboBoxLoanPeriod.Location = new Point(26, 216);
            comboBoxLoanPeriod.Name = "comboBoxLoanPeriod";
            comboBoxLoanPeriod.Size = new Size(84, 36);
            comboBoxLoanPeriod.TabIndex = 14;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(246, 83);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(103, 35);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(txtAccountNumber);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(40, 39);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(448, 157);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Account Information";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 52);
            label1.Name = "label1";
            label1.Size = new Size(173, 28);
            label1.TabIndex = 3;
            label1.Text = "Account Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(26, 185);
            label4.Name = "label4";
            label4.Size = new Size(123, 28);
            label4.TabIndex = 13;
            label4.Text = "Loan Period";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(246, 151);
            label3.Name = "label3";
            label3.Size = new Size(53, 28);
            label3.TabIndex = 12;
            label3.Text = "VND";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(26, 117);
            label2.Name = "label2";
            label2.Size = new Size(139, 28);
            label2.TabIndex = 10;
            label2.Text = "Loan Amount";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxCollateral);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnLoan);
            groupBox1.Controls.Add(txtLoanID);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBoxLoanPeriod);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtLoanAmount);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(40, 195);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(448, 336);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Loan section";
            // 
            // comboBoxCollateral
            // 
            comboBoxCollateral.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCollateral.FormattingEnabled = true;
            comboBoxCollateral.Items.AddRange(new object[] { "Motobike", "Car", "House" });
            comboBoxCollateral.Location = new Point(190, 216);
            comboBoxCollateral.Name = "comboBoxCollateral";
            comboBoxCollateral.Size = new Size(145, 36);
            comboBoxCollateral.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(190, 185);
            label8.Name = "label8";
            label8.Size = new Size(103, 28);
            label8.TabIndex = 20;
            label8.Text = "Collateral";
            // 
            // txtLoanAmount
            // 
            txtLoanAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLoanAmount.Location = new Point(26, 148);
            txtLoanAmount.Name = "txtLoanAmount";
            txtLoanAmount.Size = new Size(196, 34);
            txtLoanAmount.TabIndex = 11;
            // 
            // richTextBoxInformation
            // 
            richTextBoxInformation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxInformation.Location = new Point(511, 39);
            richTextBoxInformation.Name = "richTextBoxInformation";
            richTextBoxInformation.ReadOnly = true;
            richTextBoxInformation.Size = new Size(364, 425);
            richTextBoxInformation.TabIndex = 14;
            richTextBoxInformation.Text = "";
            // 
            // UC_Mortgage_Loan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnReset);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(richTextBoxInformation);
            Name = "UC_Mortgage_Loan";
            Size = new Size(914, 571);
            Load += UC_Mortgage_Loan_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnReset;
        private TextBox txtAccountNumber;
        private Button btnLoan;
        private TextBox txtLoanID;
        private Label label7;
        private Label label6;
        private Label label5;
        private ComboBox comboBoxLoanPeriod;
        private Button btnSearch;
        private GroupBox groupBox2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox1;
        private ComboBox comboBoxCollateral;
        private Label label8;
        private TextBox txtLoanAmount;
        private RichTextBox richTextBoxInformation;
    }
}
