namespace DoAnWinDows
{
    partial class Cus_UCRecharge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cus_UCRecharge));
            lblReCharge = new Label();
            groupBox2 = new GroupBox();
            btnPrintBill = new Button();
            rtxtInvoice = new RichTextBox();
            label5 = new Label();
            btnRecharge = new Button();
            txtMoneyRecharge = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            rtxtInformation = new RichTextBox();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblReCharge
            // 
            lblReCharge.AutoSize = true;
            lblReCharge.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblReCharge.Location = new Point(290, 13);
            lblReCharge.Name = "lblReCharge";
            lblReCharge.Size = new Size(192, 45);
            lblReCharge.TabIndex = 29;
            lblReCharge.Text = "RECHARGE";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientActiveCaption;
            groupBox2.Controls.Add(btnPrintBill);
            groupBox2.Controls.Add(rtxtInvoice);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(btnRecharge);
            groupBox2.Controls.Add(txtMoneyRecharge);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(340, 62);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(460, 401);
            groupBox2.TabIndex = 44;
            groupBox2.TabStop = false;
            groupBox2.Text = "Withdraw Information";
            // 
            // btnPrintBill
            // 
            btnPrintBill.BackColor = SystemColors.GradientInactiveCaption;
            btnPrintBill.Location = new Point(191, 364);
            btnPrintBill.Name = "btnPrintBill";
            btnPrintBill.Size = new Size(94, 29);
            btnPrintBill.TabIndex = 14;
            btnPrintBill.Text = "Print Bill";
            btnPrintBill.UseVisualStyleBackColor = false;
            btnPrintBill.Click += btnPrintBill_Click;
            // 
            // rtxtInvoice
            // 
            rtxtInvoice.Location = new Point(6, 149);
            rtxtInvoice.Name = "rtxtInvoice";
            rtxtInvoice.Size = new Size(448, 209);
            rtxtInvoice.TabIndex = 13;
            rtxtInvoice.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(347, 60);
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
            btnRecharge.Location = new Point(180, 94);
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
            txtMoneyRecharge.Location = new Point(138, 54);
            txtMoneyRecharge.Name = "txtMoneyRecharge";
            txtMoneyRecharge.Size = new Size(203, 34);
            txtMoneyRecharge.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(138, 23);
            label1.Name = "label1";
            label1.Size = new Size(197, 28);
            label1.TabIndex = 5;
            label1.Text = "Money to recharge:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(rtxtInformation);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(3, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(331, 401);
            groupBox1.TabIndex = 45;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer 's Information";
            // 
            // rtxtInformation
            // 
            rtxtInformation.Location = new Point(6, 34);
            rtxtInformation.Name = "rtxtInformation";
            rtxtInformation.Size = new Size(315, 359);
            rtxtInformation.TabIndex = 33;
            rtxtInformation.Text = "";
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
            // Cus_UCRecharge
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(lblReCharge);
            Name = "Cus_UCRecharge";
            Size = new Size(803, 468);
            Load += Cus_UCRecharge_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReCharge;
        private GroupBox groupBox2;
        private Button btnPrintBill;
        private RichTextBox rtxtInvoice;
        private Label label5;
        private Button btnRecharge;
        private TextBox txtMoneyRecharge;
        private Label label1;
        private GroupBox groupBox1;
        private RichTextBox rtxtInformation;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
