namespace DoAnWinDows
{
    partial class UCAdministratorAccount
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
            lblFullName = new Label();
            lblPhone = new Label();
            lblPassword = new Label();
            txtName = new TextBox();
            lblIdentitycard = new Label();
            txtPhone = new TextBox();
            btnClearAll = new Button();
            txtIdentitycard = new TextBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            gvAdministratorAccount = new DataGridView();
            tblEmail = new Label();
            lblAddress = new Label();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            lblDateofbirth = new Label();
            dateTimeDateOfBirth = new DateTimePicker();
            lblGender = new Label();
            comboBoxGender = new ComboBox();
            txtPassWord = new TextBox();
            ((System.ComponentModel.ISupportInitialize)gvAdministratorAccount).BeginInit();
            SuspendLayout();
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(43, 75);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(58, 15);
            lblFullName.TabIndex = 233;
            lblFullName.Text = "FullName";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(44, 106);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(41, 15);
            lblPhone.TabIndex = 235;
            lblPhone.Text = "Phone";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(45, 141);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(59, 15);
            lblPassword.TabIndex = 232;
            lblPassword.Text = "PassWord";
            // 
            // txtName
            // 
            txtName.Location = new Point(119, 75);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(199, 23);
            txtName.TabIndex = 237;
            // 
            // lblIdentitycard
            // 
            lblIdentitycard.AutoSize = true;
            lblIdentitycard.Location = new Point(44, 183);
            lblIdentitycard.Name = "lblIdentitycard";
            lblIdentitycard.Size = new Size(70, 15);
            lblIdentitycard.TabIndex = 234;
            lblIdentitycard.Text = "Identitycard";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(118, 106);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(199, 23);
            txtPhone.TabIndex = 239;
            // 
            // btnClearAll
            // 
            btnClearAll.AutoSize = true;
            btnClearAll.Location = new Point(619, 367);
            btnClearAll.Margin = new Padding(3, 2, 3, 2);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(90, 25);
            btnClearAll.TabIndex = 257;
            btnClearAll.Text = "ClearAll";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // txtIdentitycard
            // 
            txtIdentitycard.Location = new Point(118, 183);
            txtIdentitycard.Margin = new Padding(3, 2, 3, 2);
            txtIdentitycard.Name = "txtIdentitycard";
            txtIdentitycard.Size = new Size(199, 23);
            txtIdentitycard.TabIndex = 238;
            // 
            // btnThem
            // 
            btnThem.AutoSize = true;
            btnThem.Location = new Point(324, 367);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(82, 25);
            btnThem.TabIndex = 240;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.AutoSize = true;
            btnXoa.Location = new Point(412, 367);
            btnXoa.Margin = new Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(90, 25);
            btnXoa.TabIndex = 241;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.AutoSize = true;
            btnSua.Location = new Point(505, 367);
            btnSua.Margin = new Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(90, 25);
            btnSua.TabIndex = 243;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // gvAdministratorAccount
            // 
            gvAdministratorAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvAdministratorAccount.Location = new Point(340, 106);
            gvAdministratorAccount.Margin = new Padding(3, 2, 3, 2);
            gvAdministratorAccount.Name = "gvAdministratorAccount";
            gvAdministratorAccount.RowHeadersWidth = 51;
            gvAdministratorAccount.RowTemplate.Height = 29;
            gvAdministratorAccount.Size = new Size(426, 242);
            gvAdministratorAccount.TabIndex = 244;
            gvAdministratorAccount.CellClick += gvAdministratorAccount_CellClick;
            // 
            // tblEmail
            // 
            tblEmail.AutoSize = true;
            tblEmail.Location = new Point(49, 223);
            tblEmail.Name = "tblEmail";
            tblEmail.Size = new Size(36, 15);
            tblEmail.TabIndex = 246;
            tblEmail.Text = "Email";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(52, 258);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(49, 15);
            lblAddress.TabIndex = 247;
            lblAddress.Text = "Address";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(119, 223);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(199, 23);
            txtEmail.TabIndex = 249;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(119, 258);
            txtAddress.Margin = new Padding(3, 2, 3, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(199, 23);
            txtAddress.TabIndex = 250;
            // 
            // lblDateofbirth
            // 
            lblDateofbirth.AutoSize = true;
            lblDateofbirth.Location = new Point(44, 293);
            lblDateofbirth.Name = "lblDateofbirth";
            lblDateofbirth.Size = new Size(67, 15);
            lblDateofbirth.TabIndex = 251;
            lblDateofbirth.Text = "Dateofbirth";
            // 
            // dateTimeDateOfBirth
            // 
            dateTimeDateOfBirth.Location = new Point(117, 293);
            dateTimeDateOfBirth.Name = "dateTimeDateOfBirth";
            dateTimeDateOfBirth.Size = new Size(200, 23);
            dateTimeDateOfBirth.TabIndex = 252;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(52, 333);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(45, 15);
            lblGender.TabIndex = 253;
            lblGender.Text = "Gender";
            // 
            // comboBoxGender
            // 
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "male", "female" });
            comboBoxGender.Location = new Point(117, 333);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(199, 23);
            comboBoxGender.TabIndex = 254;
            comboBoxGender.Text = "male";
            // 
            // txtPassWord
            // 
            txtPassWord.Location = new Point(119, 143);
            txtPassWord.Margin = new Padding(3, 2, 3, 2);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new Size(199, 23);
            txtPassWord.TabIndex = 236;
            // 
            // UCAdministratorAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnClearAll);
            Controls.Add(comboBoxGender);
            Controls.Add(lblGender);
            Controls.Add(dateTimeDateOfBirth);
            Controls.Add(lblDateofbirth);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(lblAddress);
            Controls.Add(tblEmail);
            Controls.Add(gvAdministratorAccount);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(txtIdentitycard);
            Controls.Add(txtPassWord);
            Controls.Add(txtPhone);
            Controls.Add(lblIdentitycard);
            Controls.Add(txtName);
            Controls.Add(lblPassword);
            Controls.Add(lblPhone);
            Controls.Add(lblFullName);
            Name = "UCAdministratorAccount";
            Size = new Size(808, 455);
            Load += UCAdministratorAccount_Load;
            ((System.ComponentModel.ISupportInitialize)gvAdministratorAccount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFullName;
        private Label lblPhone;
        private Label lblPassword;
        private TextBox txtName;
        private Label lblIdentitycard;
        private TextBox txtPhone;
        private Button btnClearAll;
        private TextBox txtIdentitycard;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private DataGridView gvAdministratorAccount;
        private Label tblEmail;
        private Label lblAddress;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private Label lblDateofbirth;
        private DateTimePicker dateTimeDateOfBirth;
        private Label lblGender;
        private ComboBox comboBoxGender;
        private TextBox txtPassWord;
    }
}
