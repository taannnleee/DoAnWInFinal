namespace DoAnWinDows.PresentationLayer.UC_Controls
{
    partial class UC_Unsecure_Loan
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
            richTextBoxInformation = new RichTextBox();
            groupBox1 = new GroupBox();
            btnLoan = new Button();
            txtLoanID = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            comboBoxLoanPeriod = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            txtLoanAmount = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            btnSearch = new Button();
            txtAccountNumber = new TextBox();
            label1 = new Label();
            btnReset = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBoxInformation
            // 
            richTextBoxInformation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxInformation.Location = new Point(448, 45);
            richTextBoxInformation.Margin = new Padding(3, 2, 3, 2);
            richTextBoxInformation.Name = "richTextBoxInformation";
            richTextBoxInformation.ReadOnly = true;
            richTextBoxInformation.Size = new Size(319, 320);
            richTextBoxInformation.TabIndex = 10;
            richTextBoxInformation.Text = "";
            // 
            // groupBox1
            // 
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
            groupBox1.Location = new Point(36, 162);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(392, 252);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Loan section";
            // 
            // btnLoan
            // 
            btnLoan.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnLoan.Location = new Point(131, 214);
            btnLoan.Margin = new Padding(3, 2, 3, 2);
            btnLoan.Name = "btnLoan";
            btnLoan.Size = new Size(90, 26);
            btnLoan.TabIndex = 19;
            btnLoan.Text = "Loan";
            btnLoan.UseVisualStyleBackColor = true;
            btnLoan.Click += btnLoan_Click;
            // 
            // txtLoanID
            // 
            txtLoanID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLoanID.Location = new Point(23, 60);
            txtLoanID.Margin = new Padding(3, 2, 3, 2);
            txtLoanID.Name = "txtLoanID";
            txtLoanID.Size = new Size(74, 29);
            txtLoanID.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(23, 37);
            label7.Name = "label7";
            label7.Size = new Size(68, 21);
            label7.TabIndex = 17;
            label7.Text = "Loan ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(23, 191);
            label6.Name = "label6";
            label6.Size = new Size(332, 21);
            label6.TabIndex = 16;
            label6.Text = "*Notice: the interest rate of loan is 2% per year";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(215, 164);
            label5.Name = "label5";
            label5.Size = new Size(40, 21);
            label5.TabIndex = 15;
            label5.Text = "Year";
            // 
            // comboBoxLoanPeriod
            // 
            comboBoxLoanPeriod.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxLoanPeriod.FormattingEnabled = true;
            comboBoxLoanPeriod.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            comboBoxLoanPeriod.Location = new Point(23, 162);
            comboBoxLoanPeriod.Margin = new Padding(3, 2, 3, 2);
            comboBoxLoanPeriod.Name = "comboBoxLoanPeriod";
            comboBoxLoanPeriod.Size = new Size(74, 29);
            comboBoxLoanPeriod.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(23, 139);
            label4.Name = "label4";
            label4.Size = new Size(101, 21);
            label4.TabIndex = 13;
            label4.Text = "Loan Period";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(215, 113);
            label3.Name = "label3";
            label3.Size = new Size(43, 21);
            label3.TabIndex = 12;
            label3.Text = "VND";
            // 
            // txtLoanAmount
            // 
            txtLoanAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLoanAmount.Location = new Point(23, 111);
            txtLoanAmount.Margin = new Padding(3, 2, 3, 2);
            txtLoanAmount.Name = "txtLoanAmount";
            txtLoanAmount.Size = new Size(172, 29);
            txtLoanAmount.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(23, 88);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 10;
            label2.Text = "Loan Amount";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(txtAccountNumber);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(36, 45);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(392, 118);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Account Information";
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(215, 62);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 26);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtAccountNumber
            // 
            txtAccountNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAccountNumber.Location = new Point(23, 62);
            txtAccountNumber.Margin = new Padding(3, 2, 3, 2);
            txtAccountNumber.Name = "txtAccountNumber";
            txtAccountNumber.Size = new Size(172, 29);
            txtAccountNumber.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 39);
            label1.Name = "label1";
            label1.Size = new Size(140, 21);
            label1.TabIndex = 3;
            label1.Text = "Account Number";
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.Location = new Point(578, 376);
            btnReset.Margin = new Padding(3, 2, 3, 2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(90, 26);
            btnReset.TabIndex = 13;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // UC_Unsecure_Loan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnReset);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(richTextBoxInformation);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UC_Unsecure_Loan";
            Size = new Size(800, 428);
            Load += UC_Unsecure_Loan_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBoxInformation;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private ComboBox comboBoxLoanPeriod;
        private Label label4;
        private Label label3;
        private TextBox txtLoanAmount;
        private Label label2;
        private GroupBox groupBox2;
        private Button btnSearch;
        private TextBox txtAccountNumber;
        private Label label1;
        private TextBox txtLoanID;
        private Label label7;
        private Button btnLoan;
        private Button btnReset;
    }
}
