namespace DoAnWinDows
{
    partial class UCCustomerAccount
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
            txtBalance = new TextBox();
            lblBalance = new Label();
            cboGender = new ComboBox();
            lblGender = new Label();
            lblCustomerName = new Label();
            txtAddress = new TextBox();
            txtAcountStatus = new TextBox();
            lblAddress = new Label();
            tblAccountStatus = new Label();
            gvQuanLy = new DataGridView();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            txtIdentitycard = new TextBox();
            txtCustomerID = new TextBox();
            txtPhoneNumber = new TextBox();
            lblIdentitycard = new Label();
            txtAccountNumber = new TextBox();
            lblAccountType = new Label();
            lblCustomerID = new Label();
            lblAccountNumber = new Label();
            btnSearch = new Button();
            btnClearAll = new Button();
            txtCustomerName = new TextBox();
            lblPhoneNumber = new Label();
            cboAccountType = new ComboBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblUserName = new Label();
            lblPassWord = new Label();
            txtUserName = new TextBox();
            txtPassWord = new TextBox();
            ((System.ComponentModel.ISupportInitialize)gvQuanLy).BeginInit();
            SuspendLayout();
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(482, 145);
            txtBalance.Margin = new Padding(3, 2, 3, 2);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(199, 23);
            txtBalance.TabIndex = 230;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(381, 155);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(48, 15);
            lblBalance.TabIndex = 229;
            lblBalance.Text = "Balance";
            // 
            // cboGender
            // 
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "male", "female" });
            cboGender.Location = new Point(116, 214);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(199, 23);
            cboGender.TabIndex = 228;
            cboGender.Text = "male";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(21, 217);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(45, 15);
            lblGender.TabIndex = 227;
            lblGender.Text = "Gender";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(16, 165);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(91, 15);
            lblCustomerName.TabIndex = 225;
            lblCustomerName.Text = "CustomerName";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(116, 130);
            txtAddress.Margin = new Padding(3, 2, 3, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(199, 23);
            txtAddress.TabIndex = 224;
            // 
            // txtAcountStatus
            // 
            txtAcountStatus.Location = new Point(489, 200);
            txtAcountStatus.Margin = new Padding(3, 2, 3, 2);
            txtAcountStatus.Name = "txtAcountStatus";
            txtAcountStatus.Size = new Size(199, 23);
            txtAcountStatus.TabIndex = 223;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(24, 130);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(49, 15);
            lblAddress.TabIndex = 221;
            lblAddress.Text = "Address";
            // 
            // tblAccountStatus
            // 
            tblAccountStatus.AutoSize = true;
            tblAccountStatus.Location = new Point(382, 200);
            tblAccountStatus.Name = "tblAccountStatus";
            tblAccountStatus.Size = new Size(84, 15);
            tblAccountStatus.TabIndex = 220;
            tblAccountStatus.Text = "AccountStatus";
            // 
            // gvQuanLy
            // 
            gvQuanLy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvQuanLy.Location = new Point(21, 307);
            gvQuanLy.Margin = new Padding(3, 2, 3, 2);
            gvQuanLy.Name = "gvQuanLy";
            gvQuanLy.RowHeadersWidth = 51;
            gvQuanLy.RowTemplate.Height = 29;
            gvQuanLy.Size = new Size(295, 156);
            gvQuanLy.TabIndex = 218;
            gvQuanLy.CellClick += gvQuanLy_CellClick_1;
            // 
            // btnSua
            // 
            btnSua.AutoSize = true;
            btnSua.Location = new Point(561, 285);
            btnSua.Margin = new Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(90, 25);
            btnSua.TabIndex = 217;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.AutoSize = true;
            btnXoa.Location = new Point(452, 285);
            btnXoa.Margin = new Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(90, 25);
            btnXoa.TabIndex = 215;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.AutoSize = true;
            btnThem.Location = new Point(350, 285);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(82, 25);
            btnThem.TabIndex = 214;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtIdentitycard
            // 
            txtIdentitycard.Location = new Point(116, 186);
            txtIdentitycard.Margin = new Padding(3, 2, 3, 2);
            txtIdentitycard.Name = "txtIdentitycard";
            txtIdentitycard.Size = new Size(199, 23);
            txtIdentitycard.TabIndex = 212;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(489, 74);
            txtCustomerID.Margin = new Padding(3, 2, 3, 2);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(199, 23);
            txtCustomerID.TabIndex = 210;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(116, 242);
            txtPhoneNumber.Margin = new Padding(3, 2, 3, 2);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(199, 23);
            txtPhoneNumber.TabIndex = 213;
            // 
            // lblIdentitycard
            // 
            lblIdentitycard.AutoSize = true;
            lblIdentitycard.Location = new Point(14, 194);
            lblIdentitycard.Name = "lblIdentitycard";
            lblIdentitycard.Size = new Size(70, 15);
            lblIdentitycard.TabIndex = 208;
            lblIdentitycard.Text = "Identitycard";
            // 
            // txtAccountNumber
            // 
            txtAccountNumber.Location = new Point(489, 42);
            txtAccountNumber.Margin = new Padding(3, 2, 3, 2);
            txtAccountNumber.Name = "txtAccountNumber";
            txtAccountNumber.Size = new Size(199, 23);
            txtAccountNumber.TabIndex = 211;
            // 
            // lblAccountType
            // 
            lblAccountType.AutoSize = true;
            lblAccountType.Location = new Point(382, 116);
            lblAccountType.Name = "lblAccountType";
            lblAccountType.Size = new Size(76, 15);
            lblAccountType.TabIndex = 206;
            lblAccountType.Text = "AccountType";
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Location = new Point(387, 82);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(70, 15);
            lblCustomerID.TabIndex = 209;
            lblCustomerID.Text = "CustomerID";
            // 
            // lblAccountNumber
            // 
            lblAccountNumber.AutoSize = true;
            lblAccountNumber.Location = new Point(382, 42);
            lblAccountNumber.Name = "lblAccountNumber";
            lblAccountNumber.Size = new Size(96, 15);
            lblAccountNumber.TabIndex = 207;
            lblAccountNumber.Text = "AccountNumber";
            // 
            // btnSearch
            // 
            btnSearch.AutoSize = true;
            btnSearch.Location = new Point(657, 285);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 25);
            btnSearch.TabIndex = 231;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClearAll
            // 
            btnClearAll.AutoSize = true;
            btnClearAll.Location = new Point(657, 314);
            btnClearAll.Margin = new Padding(3, 2, 3, 2);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(90, 25);
            btnClearAll.TabIndex = 232;
            btnClearAll.Text = "ClearAll";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(116, 159);
            txtCustomerName.Margin = new Padding(3, 2, 3, 2);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(199, 23);
            txtCustomerName.TabIndex = 233;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(24, 244);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(85, 15);
            lblPhoneNumber.TabIndex = 234;
            lblPhoneNumber.Text = "PhoneNumber";
            // 
            // cboAccountType
            // 
            cboAccountType.FormattingEnabled = true;
            cboAccountType.Items.AddRange(new object[] { "Basic account", "Privilege account", "Premium account" });
            cboAccountType.Location = new Point(481, 117);
            cboAccountType.Name = "cboAccountType";
            cboAccountType.Size = new Size(199, 23);
            cboAccountType.TabIndex = 235;
            cboAccountType.Text = "Basic account";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(24, 290);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 236;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(116, 282);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(199, 23);
            txtEmail.TabIndex = 237;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(9, 16);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(62, 15);
            lblUserName.TabIndex = 238;
            lblUserName.Text = "UserName";
            // 
            // lblPassWord
            // 
            lblPassWord.AutoSize = true;
            lblPassWord.Location = new Point(12, 45);
            lblPassWord.Name = "lblPassWord";
            lblPassWord.Size = new Size(59, 15);
            lblPassWord.TabIndex = 239;
            lblPassWord.Text = "PassWord";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(100, 13);
            txtUserName.Margin = new Padding(3, 2, 3, 2);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(199, 23);
            txtUserName.TabIndex = 240;
            // 
            // txtPassWord
            // 
            txtPassWord.Location = new Point(100, 45);
            txtPassWord.Margin = new Padding(3, 2, 3, 2);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new Size(199, 23);
            txtPassWord.TabIndex = 241;
            // 
            // UCCustomerAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gvQuanLy);
            Controls.Add(txtPassWord);
            Controls.Add(txtUserName);
            Controls.Add(lblPassWord);
            Controls.Add(lblUserName);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(cboAccountType);
            Controls.Add(lblPhoneNumber);
            Controls.Add(txtCustomerName);
            Controls.Add(btnClearAll);
            Controls.Add(btnSearch);
            Controls.Add(txtBalance);
            Controls.Add(lblBalance);
            Controls.Add(cboGender);
            Controls.Add(lblGender);
            Controls.Add(lblCustomerName);
            Controls.Add(txtAddress);
            Controls.Add(txtAcountStatus);
            Controls.Add(lblAddress);
            Controls.Add(tblAccountStatus);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(txtIdentitycard);
            Controls.Add(txtCustomerID);
            Controls.Add(txtPhoneNumber);
            Controls.Add(lblIdentitycard);
            Controls.Add(txtAccountNumber);
            Controls.Add(lblAccountType);
            Controls.Add(lblCustomerID);
            Controls.Add(lblAccountNumber);
            Name = "UCCustomerAccount";
            Size = new Size(822, 491);
            Load += UCAccountManager_Load;
            ((System.ComponentModel.ISupportInitialize)gvQuanLy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBalance;
        private Label lblBalance;
        private ComboBox cboGender;
        private Label lblGender;
        private DateTimePicker dateTimeDateOfBirth;
        private Label lblCustomerName;
        private TextBox txtAddress;
        private TextBox txtAcountStatus;
        private Label lblAddress;
        private Label tblAccountStatus;
        private DataGridView gvQuanLy;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private TextBox txtIdentitycard;
        private TextBox txtCustomerID;
        private TextBox txtPhoneNumber;
        private Label lblIdentitycard;
        private TextBox txtAccountNumber;
        private Label lblAccountType;
        private Label lblCustomerID;
        private Label lblAccountNumber;
        private Button btnSearch;
        private Button btnClearAll;
        private TextBox txtCustomerName;
        private Label lblPhoneNumber;
        private ComboBox cboAccountType;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblUserName;
        private Label lblPassWord;
        private TextBox txtUserName;
        private TextBox txtPassWord;
    }
}
