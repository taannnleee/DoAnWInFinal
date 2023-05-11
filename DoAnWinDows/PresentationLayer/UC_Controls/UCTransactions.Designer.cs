namespace DoAnWinDows
{
    partial class UCTransactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCTransactions));
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnSearchReceiver = new Button();
            txtAccNumReceiver = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnSearchSender = new Button();
            txtAccNumSender = new TextBox();
            label3 = new Label();
            txtInvoice = new RichTextBox();
            btnInvoice = new Button();
            groupBox3 = new GroupBox();
            txtMessage = new TextBox();
            label6 = new Label();
            label5 = new Label();
            btnTransaction = new Button();
            txtMoneyTransaction = new TextBox();
            label4 = new Label();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            btnNewTransaction = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(316, 14);
            label1.Name = "label1";
            label1.Size = new Size(260, 46);
            label1.TabIndex = 1;
            label1.Text = "TRANSACTION";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientActiveCaption;
            groupBox2.Controls.Add(btnSearchReceiver);
            groupBox2.Controls.Add(txtAccNumReceiver);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(535, 63);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(334, 163);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Receiver's Information";
            // 
            // btnSearchReceiver
            // 
            btnSearchReceiver.AutoSize = true;
            btnSearchReceiver.BackColor = SystemColors.GradientInactiveCaption;
            btnSearchReceiver.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearchReceiver.Location = new Point(122, 111);
            btnSearchReceiver.Name = "btnSearchReceiver";
            btnSearchReceiver.Size = new Size(87, 40);
            btnSearchReceiver.TabIndex = 7;
            btnSearchReceiver.Text = "Search";
            btnSearchReceiver.UseVisualStyleBackColor = false;
            btnSearchReceiver.Click += btnSearchReceiver_Click;
            // 
            // txtAccNumReceiver
            // 
            txtAccNumReceiver.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAccNumReceiver.Location = new Point(49, 60);
            txtAccNumReceiver.Name = "txtAccNumReceiver";
            txtAccNumReceiver.Size = new Size(238, 34);
            txtAccNumReceiver.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(49, 23);
            label2.Name = "label2";
            label2.Size = new Size(175, 28);
            label2.TabIndex = 5;
            label2.Text = "Account number:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(btnSearchSender);
            groupBox1.Controls.Add(txtAccNumSender);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(77, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(331, 163);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sender's Information";
            // 
            // btnSearchSender
            // 
            btnSearchSender.AutoSize = true;
            btnSearchSender.BackColor = SystemColors.GradientInactiveCaption;
            btnSearchSender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearchSender.Location = new Point(120, 111);
            btnSearchSender.Name = "btnSearchSender";
            btnSearchSender.Size = new Size(87, 40);
            btnSearchSender.TabIndex = 4;
            btnSearchSender.Text = "Search";
            btnSearchSender.UseVisualStyleBackColor = false;
            btnSearchSender.Click += btnSearchSender_Click;
            // 
            // txtAccNumSender
            // 
            txtAccNumSender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAccNumSender.Location = new Point(47, 60);
            txtAccNumSender.Name = "txtAccNumSender";
            txtAccNumSender.Size = new Size(238, 34);
            txtAccNumSender.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(47, 23);
            label3.Name = "label3";
            label3.Size = new Size(175, 28);
            label3.TabIndex = 2;
            label3.Text = "Account number:";
            // 
            // txtInvoice
            // 
            txtInvoice.Location = new Point(535, 238);
            txtInvoice.Name = "txtInvoice";
            txtInvoice.Size = new Size(334, 210);
            txtInvoice.TabIndex = 13;
            txtInvoice.Text = "";
            // 
            // btnInvoice
            // 
            btnInvoice.AutoSize = true;
            btnInvoice.BackColor = SystemColors.GradientInactiveCaption;
            btnInvoice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInvoice.Location = new Point(641, 454);
            btnInvoice.Name = "btnInvoice";
            btnInvoice.Size = new Size(144, 40);
            btnInvoice.TabIndex = 12;
            btnInvoice.Text = "Print invoice";
            btnInvoice.UseVisualStyleBackColor = false;
            btnInvoice.Click += btnInvoice_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.GradientActiveCaption;
            groupBox3.Controls.Add(txtMessage);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(btnTransaction);
            groupBox3.Controls.Add(txtMoneyTransaction);
            groupBox3.Controls.Add(label4);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(77, 238);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(331, 277);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Transaction Information";
            // 
            // txtMessage
            // 
            txtMessage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMessage.Location = new Point(29, 162);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(238, 34);
            txtMessage.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(29, 125);
            label6.Name = "label6";
            label6.Size = new Size(99, 28);
            label6.TabIndex = 14;
            label6.Text = "Message:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(273, 82);
            label5.Name = "label5";
            label5.Size = new Size(53, 28);
            label5.TabIndex = 13;
            label5.Text = "VND";
            // 
            // btnTransaction
            // 
            btnTransaction.AutoSize = true;
            btnTransaction.BackColor = SystemColors.GradientInactiveCaption;
            btnTransaction.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTransaction.Location = new Point(95, 215);
            btnTransaction.Name = "btnTransaction";
            btnTransaction.Size = new Size(133, 40);
            btnTransaction.TabIndex = 4;
            btnTransaction.Text = "Transaction";
            btnTransaction.UseVisualStyleBackColor = false;
            btnTransaction.Click += btnTransaction_Click;
            // 
            // txtMoneyTransaction
            // 
            txtMoneyTransaction.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMoneyTransaction.Location = new Point(29, 79);
            txtMoneyTransaction.Name = "txtMoneyTransaction";
            txtMoneyTransaction.Size = new Size(238, 34);
            txtMoneyTransaction.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(29, 42);
            label4.Name = "label4";
            label4.Size = new Size(193, 28);
            label4.TabIndex = 2;
            label4.Text = "Money to Transact:";
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // btnNewTransaction
            // 
            btnNewTransaction.AutoSize = true;
            btnNewTransaction.BackColor = SystemColors.GradientInactiveCaption;
            btnNewTransaction.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewTransaction.Location = new Point(622, 500);
            btnNewTransaction.Name = "btnNewTransaction";
            btnNewTransaction.Size = new Size(180, 40);
            btnNewTransaction.TabIndex = 14;
            btnNewTransaction.Text = "New transaction";
            btnNewTransaction.UseVisualStyleBackColor = false;
            btnNewTransaction.Click += btnNewTransaction_Click;
            // 
            // UCTransactions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(btnNewTransaction);
            Controls.Add(groupBox3);
            Controls.Add(txtInvoice);
            Controls.Add(btnInvoice);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UCTransactions";
            Size = new Size(914, 573);
            Load += UCTransactions_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox2;
        private Button btnSearchReceiver;
        private TextBox txtAccNumReceiver;
        private Label label2;
        private GroupBox groupBox1;
        private Button btnSearchSender;
        private TextBox txtAccNumSender;
        private Label label3;
        private RichTextBox txtInvoice;
        private Button btnInvoice;
        private GroupBox groupBox3;
        private Button btnTransaction;
        private TextBox txtMoneyTransaction;
        private Label label4;
        private TextBox txtMessage;
        private Label label6;
        private Label label5;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Button btnNewTransaction;
    }
}
