namespace DoAnWinDows
{
    partial class UCWithdraw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCWithdraw));
            label1 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            btnSearch = new Button();
            txtAccNum = new TextBox();
            groupBox2 = new GroupBox();
            label5 = new Label();
            btnWithdraw = new Button();
            txtMoneyWithdraw = new TextBox();
            label2 = new Label();
            btnInvoice = new Button();
            txtInvoice = new RichTextBox();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(355, 21);
            label1.Name = "label1";
            label1.Size = new Size(215, 46);
            label1.TabIndex = 0;
            label1.Text = "WITHDRAW";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(24, 43);
            label3.Name = "label3";
            label3.Size = new Size(175, 28);
            label3.TabIndex = 2;
            label3.Text = "Account number:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(txtAccNum);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(78, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(334, 195);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer 's Information";
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
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientActiveCaption;
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(btnWithdraw);
            groupBox2.Controls.Add(txtMoneyWithdraw);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(78, 320);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(334, 183);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Withdraw Information";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(268, 72);
            label5.Name = "label5";
            label5.Size = new Size(53, 28);
            label5.TabIndex = 12;
            label5.Text = "VND";
            // 
            // btnWithdraw
            // 
            btnWithdraw.AutoSize = true;
            btnWithdraw.BackColor = SystemColors.GradientInactiveCaption;
            btnWithdraw.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnWithdraw.Location = new Point(82, 120);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(117, 40);
            btnWithdraw.TabIndex = 7;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = false;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // txtMoneyWithdraw
            // 
            txtMoneyWithdraw.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMoneyWithdraw.Location = new Point(24, 69);
            txtMoneyWithdraw.Name = "txtMoneyWithdraw";
            txtMoneyWithdraw.Size = new Size(238, 34);
            txtMoneyWithdraw.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(24, 32);
            label2.Name = "label2";
            label2.Size = new Size(203, 28);
            label2.TabIndex = 5;
            label2.Text = "Money to withdraw:";
            // 
            // btnInvoice
            // 
            btnInvoice.AutoSize = true;
            btnInvoice.BackColor = SystemColors.GradientInactiveCaption;
            btnInvoice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInvoice.Location = new Point(613, 440);
            btnInvoice.Name = "btnInvoice";
            btnInvoice.Size = new Size(144, 40);
            btnInvoice.TabIndex = 8;
            btnInvoice.Text = "Print invoice";
            btnInvoice.UseVisualStyleBackColor = false;
            btnInvoice.Click += btnInvoice_Click;
            // 
            // txtInvoice
            // 
            txtInvoice.Location = new Point(500, 91);
            txtInvoice.Name = "txtInvoice";
            txtInvoice.Size = new Size(367, 328);
            txtInvoice.TabIndex = 11;
            txtInvoice.Text = "";
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
            // UCWithdraw
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(txtInvoice);
            Controls.Add(btnInvoice);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UCWithdraw";
            Size = new Size(914, 573);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Button btnSearch;
        private TextBox txtAccNum;
        private GroupBox groupBox2;
        private Button btnWithdraw;
        private TextBox txtMoneyWithdraw;
        private Label label2;
        private Button btnInvoice;
        private RichTextBox txtInvoice;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Label label5;
    }
}
