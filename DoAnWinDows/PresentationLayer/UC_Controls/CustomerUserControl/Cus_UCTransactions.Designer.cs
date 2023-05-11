namespace DoAnWinDows
{
    partial class Cus_UCTransactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cus_UCTransactions));
            lblName = new Label();
            txtReceiverAccNum = new TextBox();
            label2 = new Label();
            txtReceiverName = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            btnSearch = new Button();
            groupBox2 = new GroupBox();
            btnTransact = new Button();
            label4 = new Label();
            txtMoneyTransaction = new TextBox();
            txtMessage = new TextBox();
            label5 = new Label();
            txtInvoice = new RichTextBox();
            btnPrintInvoice = new Button();
            label6 = new Label();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(249, 58);
            lblName.Name = "lblName";
            lblName.Size = new Size(117, 46);
            lblName.TabIndex = 3;
            lblName.Text = "label2";
            // 
            // txtReceiverAccNum
            // 
            txtReceiverAccNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtReceiverAccNum.Location = new Point(283, 50);
            txtReceiverAccNum.Name = "txtReceiverAccNum";
            txtReceiverAccNum.Size = new Size(160, 34);
            txtReceiverAccNum.TabIndex = 6;
            txtReceiverAccNum.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, 53);
            label2.Name = "label2";
            label2.Size = new Size(260, 28);
            label2.TabIndex = 5;
            label2.Text = "Receiver Account Number";
            // 
            // txtReceiverName
            // 
            txtReceiverName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtReceiverName.Location = new Point(283, 89);
            txtReceiverName.Name = "txtReceiverName";
            txtReceiverName.ReadOnly = true;
            txtReceiverName.Size = new Size(160, 34);
            txtReceiverName.TabIndex = 8;
            txtReceiverName.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(17, 92);
            label3.Name = "label3";
            label3.Size = new Size(174, 28);
            label3.TabIndex = 7;
            label3.Text = "Receiver's Name:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtReceiverAccNum);
            groupBox1.Controls.Add(txtReceiverName);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(32, 114);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(456, 209);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thong tin nguoi nhan";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.GradientInactiveCaption;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(142, 148);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(144, 44);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click_1;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientActiveCaption;
            groupBox2.Controls.Add(btnTransact);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtMoneyTransaction);
            groupBox2.Controls.Add(txtMessage);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(32, 329);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(456, 185);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chuyen tien";
            // 
            // btnTransact
            // 
            btnTransact.BackColor = SystemColors.GradientInactiveCaption;
            btnTransact.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTransact.Location = new Point(155, 114);
            btnTransact.Name = "btnTransact";
            btnTransact.Size = new Size(144, 44);
            btnTransact.TabIndex = 17;
            btnTransact.Text = "Transact";
            btnTransact.UseVisualStyleBackColor = false;
            btnTransact.Click += btnTransact_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(15, 28);
            label4.Name = "label4";
            label4.Size = new Size(197, 28);
            label4.TabIndex = 13;
            label4.Text = "Money Transaction:";
            // 
            // txtMoneyTransaction
            // 
            txtMoneyTransaction.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMoneyTransaction.Location = new Point(283, 25);
            txtMoneyTransaction.Name = "txtMoneyTransaction";
            txtMoneyTransaction.Size = new Size(158, 34);
            txtMoneyTransaction.TabIndex = 14;
            txtMoneyTransaction.TextAlign = HorizontalAlignment.Right;
            // 
            // txtMessage
            // 
            txtMessage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMessage.Location = new Point(283, 64);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(158, 34);
            txtMessage.TabIndex = 16;
            txtMessage.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(15, 67);
            label5.Name = "label5";
            label5.Size = new Size(94, 28);
            label5.TabIndex = 15;
            label5.Text = "Message";
            // 
            // txtInvoice
            // 
            txtInvoice.Location = new Point(602, 75);
            txtInvoice.Name = "txtInvoice";
            txtInvoice.Size = new Size(278, 328);
            txtInvoice.TabIndex = 18;
            txtInvoice.Text = "";
            // 
            // btnPrintInvoice
            // 
            btnPrintInvoice.BackColor = SystemColors.GradientInactiveCaption;
            btnPrintInvoice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrintInvoice.Location = new Point(665, 451);
            btnPrintInvoice.Name = "btnPrintInvoice";
            btnPrintInvoice.Size = new Size(144, 44);
            btnPrintInvoice.TabIndex = 18;
            btnPrintInvoice.Text = "Print invoice";
            btnPrintInvoice.UseVisualStyleBackColor = false;
            btnPrintInvoice.Click += btnPrintInvoice_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(32, 58);
            label6.Name = "label6";
            label6.Size = new Size(226, 46);
            label6.TabIndex = 19;
            label6.Text = "Xin chao ban";
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
            // Cus_UCTransactions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(label6);
            Controls.Add(btnPrintInvoice);
            Controls.Add(txtInvoice);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblName);
            Name = "Cus_UCTransactions";
            Size = new Size(915, 540);
            Load += Cus_UCTransactions_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtReceiverAccNum;
        private Label label2;
        private TextBox txtReceiverName;
        private Label label3;
        private GroupBox groupBox1;
        private Button btnSearch;
        private GroupBox groupBox2;
        private Button btnTransact;
        private Label label4;
        private TextBox txtMoneyTransaction;
        private TextBox txtMessage;
        private Label label5;
        private RichTextBox txtInvoice;
        private Button btnPrintInvoice;
        private Label label6;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
