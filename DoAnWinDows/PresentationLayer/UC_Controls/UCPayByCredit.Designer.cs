namespace DoAnWinDows.PresentationLayer.UC_Controls
{
    partial class UCPayByCredit
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
            txtCvvCode = new TextBox();
            groupBox1 = new GroupBox();
            btnCompleted = new Button();
            cbSupplier = new ComboBox();
            cbService = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            txtExpense = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            txtAvailableBalances = new TextBox();
            gvCreditDetails = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvCreditDetails).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Location = new Point(88, 55);
            label3.Name = "label3";
            label3.Size = new Size(300, 2);
            label3.TabIndex = 307;
            label3.Text = "label3";
            // 
            // txtCvvCode
            // 
            txtCvvCode.BackColor = Color.SteelBlue;
            txtCvvCode.BorderStyle = BorderStyle.None;
            txtCvvCode.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCvvCode.ForeColor = Color.White;
            txtCvvCode.HideSelection = false;
            txtCvvCode.Location = new Point(88, 20);
            txtCvvCode.Margin = new Padding(3, 2, 3, 2);
            txtCvvCode.Name = "txtCvvCode";
            txtCvvCode.Size = new Size(299, 28);
            txtCvvCode.TabIndex = 306;
            txtCvvCode.TabStop = false;
            txtCvvCode.Text = "Cvv";
            txtCvvCode.Enter += txtCvv_Enter;
            txtCvvCode.Leave += txtCvv_Leave;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCompleted);
            groupBox1.Controls.Add(cbSupplier);
            groupBox1.Controls.Add(cbService);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtExpense);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(64, 136);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(467, 377);
            groupBox1.TabIndex = 308;
            groupBox1.TabStop = false;
            groupBox1.Text = "Billing Information";
            // 
            // btnCompleted
            // 
            btnCompleted.Location = new Point(203, 339);
            btnCompleted.Name = "btnCompleted";
            btnCompleted.Size = new Size(75, 23);
            btnCompleted.TabIndex = 320;
            btnCompleted.Text = "Completed";
            btnCompleted.UseVisualStyleBackColor = true;
            btnCompleted.Click += btnCompleted_Click;
            // 
            // cbSupplier
            // 
            cbSupplier.FormattingEnabled = true;
            cbSupplier.Items.AddRange(new object[] { "Water Payments", "Electricity Payments", "Housing Payments" });
            cbSupplier.Location = new Point(94, 113);
            cbSupplier.Name = "cbSupplier";
            cbSupplier.Size = new Size(278, 23);
            cbSupplier.TabIndex = 319;
            cbSupplier.Text = "New Jersey American Water";
            // 
            // cbService
            // 
            cbService.FormattingEnabled = true;
            cbService.Items.AddRange(new object[] { "Water Payments", "Electricity Payments", "Housing Payments" });
            cbService.Location = new Point(111, 41);
            cbService.Name = "cbService";
            cbService.Size = new Size(278, 23);
            cbService.TabIndex = 318;
            cbService.Text = "Water Payments";
            cbService.SelectedIndexChanged += cbService_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 247);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 317;
            label8.Text = "Expense";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 121);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 316;
            label7.Text = "Supplier";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 41);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 315;
            label6.Text = "Service";
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Location = new Point(57, 311);
            label4.Name = "label4";
            label4.Size = new Size(300, 2);
            label4.TabIndex = 314;
            label4.Text = "label4";
            // 
            // txtExpense
            // 
            txtExpense.BackColor = Color.SteelBlue;
            txtExpense.BorderStyle = BorderStyle.None;
            txtExpense.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtExpense.ForeColor = Color.White;
            txtExpense.HideSelection = false;
            txtExpense.Location = new Point(58, 281);
            txtExpense.Margin = new Padding(3, 2, 3, 2);
            txtExpense.Name = "txtExpense";
            txtExpense.Size = new Size(299, 28);
            txtExpense.TabIndex = 313;
            txtExpense.TabStop = false;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Location = new Point(72, 147);
            label2.Name = "label2";
            label2.Size = new Size(300, 2);
            label2.TabIndex = 312;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Location = new Point(89, 69);
            label1.Name = "label1";
            label1.Size = new Size(300, 2);
            label1.TabIndex = 310;
            label1.Text = "label1";
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Location = new Point(70, 104);
            label5.Name = "label5";
            label5.Size = new Size(300, 2);
            label5.TabIndex = 310;
            label5.Text = "label5";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.SteelBlue;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.ForeColor = Color.White;
            textBox4.HideSelection = false;
            textBox4.Location = new Point(3, 69);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(182, 28);
            textBox4.TabIndex = 309;
            textBox4.TabStop = false;
            textBox4.Text = "Available Balances";
            // 
            // txtAvailableBalances
            // 
            txtAvailableBalances.BackColor = Color.SteelBlue;
            txtAvailableBalances.BorderStyle = BorderStyle.None;
            txtAvailableBalances.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtAvailableBalances.ForeColor = Color.White;
            txtAvailableBalances.HideSelection = false;
            txtAvailableBalances.Location = new Point(191, 69);
            txtAvailableBalances.Margin = new Padding(3, 2, 3, 2);
            txtAvailableBalances.Name = "txtAvailableBalances";
            txtAvailableBalances.ReadOnly = true;
            txtAvailableBalances.Size = new Size(179, 28);
            txtAvailableBalances.TabIndex = 311;
            txtAvailableBalances.TabStop = false;
            // 
            // gvCreditDetails
            // 
            gvCreditDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvCreditDetails.Location = new Point(664, 254);
            gvCreditDetails.Name = "gvCreditDetails";
            gvCreditDetails.RowTemplate.Height = 25;
            gvCreditDetails.Size = new Size(240, 150);
            gvCreditDetails.TabIndex = 312;
            // 
            // UCPayByCredit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gvCreditDetails);
            Controls.Add(txtAvailableBalances);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(txtCvvCode);
            Name = "UCPayByCredit";
            Size = new Size(1072, 746);
            Load += UCPayByCredit_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gvCreditDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtCvvCode;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox txtExpense;
        private Label label2;
        private Label label1;
        private Label label5;
        private TextBox textBox4;
        private TextBox txtAvailableBalances;
        private Label label8;
        private Label label7;
        private Label label6;
        private ComboBox cbService;
        private ComboBox cbSupplier;
        private Button btnCompleted;
        private DataGridView gvCreditDetails;
    }
}
