namespace DoAnWinDows
{
    partial class UCEmployeeManager
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
            gvEmployee = new DataGridView();
            txtPassWord = new TextBox();
            txtUserName = new TextBox();
            lblPassWord = new Label();
            lblUserName = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            cboAccountType = new ComboBox();
            lblPhoneNumber = new Label();
            txtEmployeeName = new TextBox();
            btnClearAll = new Button();
            btnSearch = new Button();
            cboGender = new ComboBox();
            lblGender = new Label();
            lblEmployeeName = new Label();
            txtAddress = new TextBox();
            txtAcountStatus = new TextBox();
            lblAddress = new Label();
            tblAccountStatus = new Label();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            txtIdentitycard = new TextBox();
            txtEmployeeID = new TextBox();
            txtPhoneNumber = new TextBox();
            lblIdentitycard = new Label();
            lblAccountType = new Label();
            lblEmployeeID = new Label();
            lblPosition = new Label();
            lblDateOfBirth = new Label();
            cboPosition = new ComboBox();
            dtmDateOfBirth = new DateTimePicker();
            lblSalary = new Label();
            txtSalary = new TextBox();
            ((System.ComponentModel.ISupportInitialize)gvEmployee).BeginInit();
            SuspendLayout();
            // 
            // gvEmployee
            // 
            gvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvEmployee.Location = new Point(19, 296);
            gvEmployee.Margin = new Padding(3, 2, 3, 2);
            gvEmployee.Name = "gvEmployee";
            gvEmployee.RowHeadersWidth = 51;
            gvEmployee.RowTemplate.Height = 29;
            gvEmployee.Size = new Size(295, 156);
            gvEmployee.TabIndex = 253;
            gvEmployee.CellClick += gvEmployee_CellClick;
            // 
            // txtPassWord
            // 
            txtPassWord.Location = new Point(437, 34);
            txtPassWord.Margin = new Padding(3, 2, 3, 2);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new Size(199, 23);
            txtPassWord.TabIndex = 273;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(437, 2);
            txtUserName.Margin = new Padding(3, 2, 3, 2);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(199, 23);
            txtUserName.TabIndex = 272;
            // 
            // lblPassWord
            // 
            lblPassWord.AutoSize = true;
            lblPassWord.Location = new Point(349, 34);
            lblPassWord.Name = "lblPassWord";
            lblPassWord.Size = new Size(59, 15);
            lblPassWord.TabIndex = 271;
            lblPassWord.Text = "PassWord";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(346, 5);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(62, 15);
            lblUserName.TabIndex = 270;
            lblUserName.Text = "UserName";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(114, 271);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(199, 23);
            txtEmail.TabIndex = 269;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(22, 279);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 268;
            lblEmail.Text = "Email";
            // 
            // cboAccountType
            // 
            cboAccountType.FormattingEnabled = true;
            cboAccountType.Items.AddRange(new object[] { "Normal Account", "Premium Account" });
            cboAccountType.Location = new Point(487, 124);
            cboAccountType.Name = "cboAccountType";
            cboAccountType.Size = new Size(199, 23);
            cboAccountType.TabIndex = 267;
            cboAccountType.Text = "Normal Account";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(18, 247);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(85, 15);
            lblPhoneNumber.TabIndex = 266;
            lblPhoneNumber.Text = "PhoneNumber";
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(113, 58);
            txtEmployeeName.Margin = new Padding(3, 2, 3, 2);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(199, 23);
            txtEmployeeName.TabIndex = 265;
            // 
            // btnClearAll
            // 
            btnClearAll.AutoSize = true;
            btnClearAll.Location = new Point(512, 316);
            btnClearAll.Margin = new Padding(3, 2, 3, 2);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(90, 25);
            btnClearAll.TabIndex = 264;
            btnClearAll.Text = "ClearAll";
            btnClearAll.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.AutoSize = true;
            btnSearch.Location = new Point(386, 316);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 25);
            btnSearch.TabIndex = 263;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // cboGender
            // 
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "male", "female" });
            cboGender.Location = new Point(113, 212);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(199, 23);
            cboGender.TabIndex = 260;
            cboGender.Text = "male";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(18, 220);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(45, 15);
            lblGender.TabIndex = 259;
            lblGender.Text = "Gender";
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Location = new Point(13, 64);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(91, 15);
            lblEmployeeName.TabIndex = 258;
            lblEmployeeName.Text = "EmployeeName";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(114, 26);
            txtAddress.Margin = new Padding(3, 2, 3, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(199, 23);
            txtAddress.TabIndex = 257;
            // 
            // txtAcountStatus
            // 
            txtAcountStatus.Location = new Point(487, 189);
            txtAcountStatus.Margin = new Padding(3, 2, 3, 2);
            txtAcountStatus.Name = "txtAcountStatus";
            txtAcountStatus.Size = new Size(199, 23);
            txtAcountStatus.TabIndex = 256;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(18, 34);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(49, 15);
            lblAddress.TabIndex = 255;
            lblAddress.Text = "Address";
            // 
            // tblAccountStatus
            // 
            tblAccountStatus.AutoSize = true;
            tblAccountStatus.Location = new Point(380, 189);
            tblAccountStatus.Name = "tblAccountStatus";
            tblAccountStatus.Size = new Size(84, 15);
            tblAccountStatus.TabIndex = 254;
            tblAccountStatus.Text = "AccountStatus";
            // 
            // btnSua
            // 
            btnSua.AutoSize = true;
            btnSua.Location = new Point(559, 274);
            btnSua.Margin = new Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(90, 25);
            btnSua.TabIndex = 252;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.AutoSize = true;
            btnXoa.Location = new Point(450, 274);
            btnXoa.Margin = new Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(90, 25);
            btnXoa.TabIndex = 251;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.AutoSize = true;
            btnThem.Location = new Point(348, 274);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(82, 25);
            btnThem.TabIndex = 250;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtIdentitycard
            // 
            txtIdentitycard.Location = new Point(113, 85);
            txtIdentitycard.Margin = new Padding(3, 2, 3, 2);
            txtIdentitycard.Name = "txtIdentitycard";
            txtIdentitycard.Size = new Size(199, 23);
            txtIdentitycard.TabIndex = 248;
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(487, 73);
            txtEmployeeID.Margin = new Padding(3, 2, 3, 2);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(199, 23);
            txtEmployeeID.TabIndex = 246;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(115, 244);
            txtPhoneNumber.Margin = new Padding(3, 2, 3, 2);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(199, 23);
            txtPhoneNumber.TabIndex = 249;
            // 
            // lblIdentitycard
            // 
            lblIdentitycard.AutoSize = true;
            lblIdentitycard.Location = new Point(11, 93);
            lblIdentitycard.Name = "lblIdentitycard";
            lblIdentitycard.Size = new Size(70, 15);
            lblIdentitycard.TabIndex = 244;
            lblIdentitycard.Text = "Identitycard";
            // 
            // lblAccountType
            // 
            lblAccountType.AutoSize = true;
            lblAccountType.Location = new Point(385, 127);
            lblAccountType.Name = "lblAccountType";
            lblAccountType.Size = new Size(76, 15);
            lblAccountType.TabIndex = 242;
            lblAccountType.Text = "AccountType";
            // 
            // lblEmployeeID
            // 
            lblEmployeeID.AutoSize = true;
            lblEmployeeID.Location = new Point(385, 81);
            lblEmployeeID.Name = "lblEmployeeID";
            lblEmployeeID.Size = new Size(70, 15);
            lblEmployeeID.TabIndex = 245;
            lblEmployeeID.Text = "EmployeeID";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(11, 127);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(50, 15);
            lblPosition.TabIndex = 274;
            lblPosition.Text = "Position";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Location = new Point(11, 151);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(69, 15);
            lblDateOfBirth.TabIndex = 275;
            lblDateOfBirth.Text = "DateOfBirth";
            // 
            // cboPosition
            // 
            cboPosition.FormattingEnabled = true;
            cboPosition.Items.AddRange(new object[] { "Transaction room", "Credit room", "Finance Department" });
            cboPosition.Location = new Point(113, 124);
            cboPosition.Name = "cboPosition";
            cboPosition.Size = new Size(199, 23);
            cboPosition.TabIndex = 276;
            cboPosition.Text = "Transaction room";
            // 
            // dtmDateOfBirth
            // 
            dtmDateOfBirth.Location = new Point(113, 151);
            dtmDateOfBirth.Name = "dtmDateOfBirth";
            dtmDateOfBirth.Size = new Size(200, 23);
            dtmDateOfBirth.TabIndex = 277;
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Location = new Point(11, 186);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(38, 15);
            lblSalary.TabIndex = 278;
            lblSalary.Text = "Salary";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(113, 178);
            txtSalary.Margin = new Padding(3, 2, 3, 2);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(199, 23);
            txtSalary.TabIndex = 279;
            // 
            // UCEmployeeManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtSalary);
            Controls.Add(lblSalary);
            Controls.Add(dtmDateOfBirth);
            Controls.Add(cboPosition);
            Controls.Add(lblDateOfBirth);
            Controls.Add(lblPosition);
            Controls.Add(gvEmployee);
            Controls.Add(txtPassWord);
            Controls.Add(txtUserName);
            Controls.Add(lblPassWord);
            Controls.Add(lblUserName);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(cboAccountType);
            Controls.Add(lblPhoneNumber);
            Controls.Add(txtEmployeeName);
            Controls.Add(btnClearAll);
            Controls.Add(btnSearch);
            Controls.Add(cboGender);
            Controls.Add(lblGender);
            Controls.Add(lblEmployeeName);
            Controls.Add(txtAddress);
            Controls.Add(txtAcountStatus);
            Controls.Add(lblAddress);
            Controls.Add(tblAccountStatus);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(txtIdentitycard);
            Controls.Add(txtEmployeeID);
            Controls.Add(txtPhoneNumber);
            Controls.Add(lblIdentitycard);
            Controls.Add(lblAccountType);
            Controls.Add(lblEmployeeID);
            Name = "UCEmployeeManager";
            Size = new Size(691, 512);
            Load += UCEmployeeManager_Load;
            ((System.ComponentModel.ISupportInitialize)gvEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gvEmployee;
        private TextBox txtPassWord;
        private TextBox txtUserName;
        private Label lblPassWord;
        private Label lblUserName;
        private TextBox txtEmail;
        private Label lblEmail;
        private ComboBox cboAccountType;
        private Label lblPhoneNumber;
        private TextBox txtEmployeeName;
        private Button btnClearAll;
        private Button btnSearch;
        private ComboBox cboGender;
        private Label lblGender;
        private Label lblEmployeeName;
        private TextBox txtAddress;
        private TextBox txtAcountStatus;
        private Label lblAddress;
        private Label tblAccountStatus;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private TextBox txtIdentitycard;
        private TextBox txtEmployeeID;
        private TextBox txtPhoneNumber;
        private Label lblIdentitycard;
        private Label lblAccountType;
        private Label lblEmployeeID;
        private Label lblPosition;
        private Label lblDateOfBirth;
        private ComboBox cboPosition;
        private DateTimePicker dtmDateOfBirth;
        private Label lblSalary;
        private TextBox txtSalary;
    }
}
