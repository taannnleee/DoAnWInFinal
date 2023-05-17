namespace DoAnWinDows
{
    partial class UCRecharge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCRecharge));
            label3 = new Label();
            groupBox1 = new GroupBox();
            rtxtInformation = new RichTextBox();
            btnSearch = new Button();
            txtAccNum = new TextBox();
            label4 = new Label();
            groupBox2 = new GroupBox();
            btnPrintBill = new Button();
            rtxtInvoice = new RichTextBox();
            label5 = new Label();
            btnRecharge = new Button();
            txtMoneyRecharge = new TextBox();
            label2 = new Label();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(468, 0);
            label3.Name = "label3";
            label3.Size = new Size(192, 45);
            label3.TabIndex = 28;
            label3.Text = "RECHARGE";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(rtxtInformation);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(txtAccNum);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(25, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1095, 223);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer 's Information";
            // 
            // rtxtInformation
            // 
            rtxtInformation.Location = new Point(310, 15);
            rtxtInformation.Name = "rtxtInformation";
            rtxtInformation.Size = new Size(779, 205);
            rtxtInformation.TabIndex = 33;
            rtxtInformation.Text = "";
            // 
            // btnSearch
            // 
            btnSearch.AutoSize = true;
            btnSearch.BackColor = SystemColors.GradientInactiveCaption;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(82, 131);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(102, 40);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtAccNum
            // 
            txtAccNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAccNum.Location = new Point(24, 80);
            txtAccNum.Name = "txtAccNum";
            txtAccNum.Size = new Size(238, 34);
            txtAccNum.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(24, 43);
            label4.Name = "label4";
            label4.Size = new Size(175, 28);
            label4.TabIndex = 2;
            label4.Text = "Account number:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientActiveCaption;
            groupBox2.Controls.Add(btnPrintBill);
            groupBox2.Controls.Add(rtxtInvoice);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(btnRecharge);
            groupBox2.Controls.Add(txtMoneyRecharge);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(25, 293);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1095, 358);
            groupBox2.TabIndex = 33;
            groupBox2.TabStop = false;
            groupBox2.Text = "Withdraw Information";
            // 
            // btnPrintBill
            // 
            btnPrintBill.BackColor = SystemColors.GradientInactiveCaption;
            btnPrintBill.Location = new Point(645, 296);
            btnPrintBill.Name = "btnPrintBill";
            btnPrintBill.Size = new Size(94, 29);
            btnPrintBill.TabIndex = 14;
            btnPrintBill.Text = "Print Bill";
            btnPrintBill.UseVisualStyleBackColor = false;
            btnPrintBill.Click += btnPrintBill_Click;
            // 
            // rtxtInvoice
            // 
            rtxtInvoice.Location = new Point(310, 13);
            rtxtInvoice.Name = "rtxtInvoice";
            rtxtInvoice.Size = new Size(779, 249);
            rtxtInvoice.TabIndex = 13;
            rtxtInvoice.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(233, 72);
            label5.Name = "label5";
            label5.Size = new Size(53, 28);
            label5.TabIndex = 12;
            label5.Text = "VND";
            // 
            // btnRecharge
            // 
            btnRecharge.AutoSize = true;
            btnRecharge.BackColor = SystemColors.GradientInactiveCaption;
            btnRecharge.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRecharge.Location = new Point(67, 119);
            btnRecharge.Name = "btnRecharge";
            btnRecharge.Size = new Size(117, 40);
            btnRecharge.TabIndex = 7;
            btnRecharge.Text = "Recharge";
            btnRecharge.UseVisualStyleBackColor = false;
            btnRecharge.Click += btnRecharge_Click;
            // 
            // txtMoneyRecharge
            // 
            txtMoneyRecharge.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMoneyRecharge.Location = new Point(24, 69);
            txtMoneyRecharge.Name = "txtMoneyRecharge";
            txtMoneyRecharge.Size = new Size(203, 34);
            txtMoneyRecharge.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(24, 32);
            label2.Name = "label2";
            label2.Size = new Size(197, 28);
            label2.TabIndex = 5;
            label2.Text = "Money to recharge:";
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
            // UCRecharge
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UCRecharge";
            Size = new Size(1168, 735);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private GroupBox groupBox1;
        private Button btnSearch;
        private TextBox txtAccNum;
        private Label label4;
        private RichTextBox rtxtInformation;
        private GroupBox groupBox2;
        private RichTextBox rtxtInvoice;
        private Label label5;
        private Button btnRecharge;
        private TextBox txtMoneyRecharge;
        private Label label2;
        private Button btnPrintBill;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
