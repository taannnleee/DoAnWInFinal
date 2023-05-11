namespace DoAnWinDows
{
    partial class Cus_UCWithdraw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cus_UCWithdraw));
            label1 = new Label();
            lblName = new Label();
            label2 = new Label();
            label3 = new Label();
            txtAccNum = new TextBox();
            txtBalance = new TextBox();
            label4 = new Label();
            txtAmWithdraw = new TextBox();
            label5 = new Label();
            txtInvoice = new RichTextBox();
            btnWithdraw = new Button();
            btnInvoice = new Button();
            label6 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
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
            label1.Location = new Point(32, 58);
            label1.Name = "label1";
            label1.Size = new Size(226, 46);
            label1.TabIndex = 0;
            label1.Text = "Xin chao ban";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(249, 58);
            lblName.Name = "lblName";
            lblName.Size = new Size(117, 46);
            lblName.TabIndex = 1;
            lblName.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(30, 38);
            label2.Name = "label2";
            label2.Size = new Size(181, 28);
            label2.TabIndex = 2;
            label2.Text = "Account number: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(30, 78);
            label3.Name = "label3";
            label3.Size = new Size(91, 28);
            label3.TabIndex = 3;
            label3.Text = "Balance:";
            // 
            // txtAccNum
            // 
            txtAccNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAccNum.Location = new Point(217, 35);
            txtAccNum.Name = "txtAccNum";
            txtAccNum.ReadOnly = true;
            txtAccNum.Size = new Size(144, 34);
            txtAccNum.TabIndex = 4;
            txtAccNum.TextAlign = HorizontalAlignment.Right;
            // 
            // txtBalance
            // 
            txtBalance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBalance.Location = new Point(217, 75);
            txtBalance.Name = "txtBalance";
            txtBalance.ReadOnly = true;
            txtBalance.Size = new Size(144, 34);
            txtBalance.TabIndex = 5;
            txtBalance.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(30, 39);
            label4.Name = "label4";
            label4.Size = new Size(177, 28);
            label4.TabIndex = 6;
            label4.Text = "So tien muon rut:";
            // 
            // txtAmWithdraw
            // 
            txtAmWithdraw.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAmWithdraw.Location = new Point(213, 36);
            txtAmWithdraw.Name = "txtAmWithdraw";
            txtAmWithdraw.Size = new Size(137, 34);
            txtAmWithdraw.TabIndex = 8;
            txtAmWithdraw.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(367, 39);
            label5.Name = "label5";
            label5.Size = new Size(53, 28);
            label5.TabIndex = 9;
            label5.Text = "VND";
            // 
            // txtInvoice
            // 
            txtInvoice.Location = new Point(518, 27);
            txtInvoice.Name = "txtInvoice";
            txtInvoice.Size = new Size(367, 328);
            txtInvoice.TabIndex = 10;
            txtInvoice.Text = "";
            // 
            // btnWithdraw
            // 
            btnWithdraw.BackColor = SystemColors.GradientInactiveCaption;
            btnWithdraw.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnWithdraw.Location = new Point(142, 95);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(159, 44);
            btnWithdraw.TabIndex = 11;
            btnWithdraw.Text = "Rut tien";
            btnWithdraw.UseVisualStyleBackColor = false;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // btnInvoice
            // 
            btnInvoice.BackColor = SystemColors.GradientInactiveCaption;
            btnInvoice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInvoice.Location = new Point(669, 370);
            btnInvoice.Name = "btnInvoice";
            btnInvoice.Size = new Size(166, 44);
            btnInvoice.TabIndex = 12;
            btnInvoice.Text = "In hoa don";
            btnInvoice.UseVisualStyleBackColor = false;
            btnInvoice.Click += btnInvoice_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(367, 78);
            label6.Name = "label6";
            label6.Size = new Size(53, 28);
            label6.TabIndex = 13;
            label6.Text = "VND";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(txtBalance);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtAccNum);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(32, 116);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(444, 142);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thong tin khach hang";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientActiveCaption;
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtAmWithdraw);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(btnWithdraw);
            groupBox2.Location = new Point(32, 275);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(444, 161);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Rut tien";
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
            // Cus_UCWithdraw
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnInvoice);
            Controls.Add(txtInvoice);
            Controls.Add(lblName);
            Controls.Add(label1);
            Name = "Cus_UCWithdraw";
            Size = new Size(915, 540);
            Load += Cus_UCWithdraw_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblName;
        private Label label2;
        private Label label3;
        private TextBox txtAccNum;
        private TextBox txtBalance;
        private Label label4;
        private TextBox txtAmWithdraw;
        private Label label5;
        private RichTextBox txtInvoice;
        private Button btnWithdraw;
        private Button btnInvoice;
        private Label label6;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
