namespace DoAnWinDows.PresentationLayer.UC_Controls
{
    partial class UC_Unsecure_ListOfLoanAccount
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
            groupBox1 = new GroupBox();
            gvInformation = new DataGridView();
            label1 = new Label();
            txtAccountNumber = new TextBox();
            btnSearch = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvInformation).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(gvInformation);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 127);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(914, 443);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "List Of Loan Account";
            // 
            // gvInformation
            // 
            gvInformation.AllowUserToAddRows = false;
            gvInformation.AllowUserToDeleteRows = false;
            gvInformation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvInformation.Dock = DockStyle.Fill;
            gvInformation.Location = new Point(3, 30);
            gvInformation.MultiSelect = false;
            gvInformation.Name = "gvInformation";
            gvInformation.ReadOnly = true;
            gvInformation.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            gvInformation.RowTemplate.Height = 29;
            gvInformation.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvInformation.Size = new Size(908, 410);
            gvInformation.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(179, 65);
            label1.Name = "label1";
            label1.Size = new Size(179, 28);
            label1.TabIndex = 2;
            label1.Text = "Account Number:";
            // 
            // txtAccountNumber
            // 
            txtAccountNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAccountNumber.Location = new Point(364, 62);
            txtAccountNumber.Name = "txtAccountNumber";
            txtAccountNumber.Size = new Size(184, 34);
            txtAccountNumber.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.AutoSize = true;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(564, 60);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 38);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // UC_Unsecure_ListOfLoanAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSearch);
            Controls.Add(txtAccountNumber);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "UC_Unsecure_ListOfLoanAccount";
            Size = new Size(914, 570);
            Load += UC_Unsecure_ListOfLoanAccount_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvInformation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView gvInformation;
        private Label label1;
        private TextBox txtAccountNumber;
        private Button btnSearch;
    }
}
