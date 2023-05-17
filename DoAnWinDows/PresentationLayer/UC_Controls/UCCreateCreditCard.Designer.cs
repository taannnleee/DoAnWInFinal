namespace DoAnWinDows.PresentationLayer.UC_Controls
{
    partial class UCCreateCreditCard
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
            components = new System.ComponentModel.Container();
            gvCreditCard = new DataGridView();
            btnCheck = new Button();
            pictureBox2 = new PictureBox();
            txtUserName = new TextBox();
            txtPassWord = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            panelInforCreditAccount = new Panel();
            lblAccountNumber = new Label();
            lblCustomerID = new Label();
            lblAccountType = new Label();
            txtAccountNumber = new TextBox();
            txtCustomerID = new TextBox();
            lblAccountStatus = new Label();
            txtAcountStatus = new TextBox();
            lblBalance = new Label();
            txtBalance = new TextBox();
            cboAccountType = new ComboBox();
            panel1 = new Panel();
            lblAddress = new Label();
            lblIdentitycard = new Label();
            txtPhoneNumber = new TextBox();
            txtIdentitycard = new TextBox();
            txtAddress = new TextBox();
            lblCustomerName = new Label();
            lblGender = new Label();
            cboGender = new ComboBox();
            txtCustomerName = new TextBox();
            txtEmail = new TextBox();
            lblPhoneNumber = new Label();
            lblEmail = new Label();
            Infortimer = new System.Windows.Forms.Timer(components);
            inforContainer = new Panel();
            btnArrow = new Button();
            ((System.ComponentModel.ISupportInitialize)gvCreditCard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            panelInforCreditAccount.SuspendLayout();
            panel1.SuspendLayout();
            inforContainer.SuspendLayout();
            SuspendLayout();
            // 
            // gvCreditCard
            // 
            gvCreditCard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvCreditCard.Location = new Point(3, 267);
            gvCreditCard.Name = "gvCreditCard";
            gvCreditCard.RowTemplate.Height = 25;
            gvCreditCard.Size = new Size(729, 350);
            gvCreditCard.TabIndex = 296;
            // 
            // btnCheck
            // 
            btnCheck.AutoSize = true;
            btnCheck.Location = new Point(6, 172);
            btnCheck.Margin = new Padding(3, 2, 3, 2);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(82, 25);
            btnCheck.TabIndex = 250;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._5172568_add_contact_user_icon;
            pictureBox2.Location = new Point(20, 32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 302;
            pictureBox2.TabStop = false;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.SteelBlue;
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.ForeColor = SystemColors.Window;
            txtUserName.HideSelection = false;
            txtUserName.Location = new Point(74, 32);
            txtUserName.Margin = new Padding(3, 2, 3, 2);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(302, 28);
            txtUserName.TabIndex = 301;
            txtUserName.TabStop = false;
            txtUserName.Text = "UserName";
            txtUserName.Enter += txtUserName_Enter;
            // 
            // txtPassWord
            // 
            txtPassWord.BackColor = Color.SteelBlue;
            txtPassWord.BorderStyle = BorderStyle.None;
            txtPassWord.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassWord.ForeColor = Color.White;
            txtPassWord.HideSelection = false;
            txtPassWord.Location = new Point(77, 115);
            txtPassWord.Margin = new Padding(3, 2, 3, 2);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new Size(299, 28);
            txtPassWord.TabIndex = 303;
            txtPassWord.TabStop = false;
            txtPassWord.Text = "PassWord";
            txtPassWord.Enter += txtPassWord_Enter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.key;
            pictureBox1.Location = new Point(20, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 304;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Location = new Point(76, 148);
            label3.Name = "label3";
            label3.Size = new Size(300, 2);
            label3.TabIndex = 305;
            label3.Text = "label3";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Location = new Point(74, 69);
            label1.Name = "label1";
            label1.Size = new Size(300, 2);
            label1.TabIndex = 306;
            label1.Text = "label1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Controls.Add(txtPassWord);
            groupBox1.Controls.Add(btnCheck);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(16, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(449, 202);
            groupBox1.TabIndex = 307;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login Customer Account";
            // 
            // panelInforCreditAccount
            // 
            panelInforCreditAccount.Controls.Add(lblAccountNumber);
            panelInforCreditAccount.Controls.Add(lblCustomerID);
            panelInforCreditAccount.Controls.Add(lblAccountType);
            panelInforCreditAccount.Controls.Add(txtAccountNumber);
            panelInforCreditAccount.Controls.Add(txtCustomerID);
            panelInforCreditAccount.Controls.Add(lblAccountStatus);
            panelInforCreditAccount.Controls.Add(txtAcountStatus);
            panelInforCreditAccount.Controls.Add(lblBalance);
            panelInforCreditAccount.Controls.Add(txtBalance);
            panelInforCreditAccount.Controls.Add(cboAccountType);
            panelInforCreditAccount.Location = new Point(3, 3);
            panelInforCreditAccount.Name = "panelInforCreditAccount";
            panelInforCreditAccount.Size = new Size(296, 206);
            panelInforCreditAccount.TabIndex = 299;
            // 
            // lblAccountNumber
            // 
            lblAccountNumber.AutoSize = true;
            lblAccountNumber.Location = new Point(-2, 25);
            lblAccountNumber.Name = "lblAccountNumber";
            lblAccountNumber.Size = new Size(96, 15);
            lblAccountNumber.TabIndex = 275;
            lblAccountNumber.Text = "AccountNumber";
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Location = new Point(0, 54);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(70, 15);
            lblCustomerID.TabIndex = 277;
            lblCustomerID.Text = "CustomerID";
            // 
            // lblAccountType
            // 
            lblAccountType.AutoSize = true;
            lblAccountType.Location = new Point(-3, 96);
            lblAccountType.Name = "lblAccountType";
            lblAccountType.Size = new Size(76, 15);
            lblAccountType.TabIndex = 274;
            lblAccountType.Text = "AccountType";
            // 
            // txtAccountNumber
            // 
            txtAccountNumber.Location = new Point(92, 17);
            txtAccountNumber.Margin = new Padding(3, 2, 3, 2);
            txtAccountNumber.Name = "txtAccountNumber";
            txtAccountNumber.Size = new Size(199, 23);
            txtAccountNumber.TabIndex = 279;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(92, 51);
            txtCustomerID.Margin = new Padding(3, 2, 3, 2);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(199, 23);
            txtCustomerID.TabIndex = 278;
            // 
            // lblAccountStatus
            // 
            lblAccountStatus.AutoSize = true;
            lblAccountStatus.Location = new Point(-3, 183);
            lblAccountStatus.Name = "lblAccountStatus";
            lblAccountStatus.Size = new Size(84, 15);
            lblAccountStatus.TabIndex = 282;
            lblAccountStatus.Text = "AccountStatus";
            // 
            // txtAcountStatus
            // 
            txtAcountStatus.Location = new Point(92, 170);
            txtAcountStatus.Margin = new Padding(3, 2, 3, 2);
            txtAcountStatus.Name = "txtAcountStatus";
            txtAcountStatus.Size = new Size(199, 23);
            txtAcountStatus.TabIndex = 284;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(-1, 135);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(48, 15);
            lblBalance.TabIndex = 289;
            lblBalance.Text = "Balance";
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(92, 123);
            txtBalance.Margin = new Padding(3, 2, 3, 2);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(199, 23);
            txtBalance.TabIndex = 290;
            // 
            // cboAccountType
            // 
            cboAccountType.FormattingEnabled = true;
            cboAccountType.Items.AddRange(new object[] { "Basic account", "Privilege account", "Premium account" });
            cboAccountType.Location = new Point(92, 85);
            cboAccountType.Name = "cboAccountType";
            cboAccountType.Size = new Size(199, 23);
            cboAccountType.TabIndex = 293;
            cboAccountType.Text = "Basic account";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblAddress);
            panel1.Controls.Add(lblIdentitycard);
            panel1.Controls.Add(txtPhoneNumber);
            panel1.Controls.Add(txtIdentitycard);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(lblCustomerName);
            panel1.Controls.Add(lblGender);
            panel1.Controls.Add(cboGender);
            panel1.Controls.Add(txtCustomerName);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(lblPhoneNumber);
            panel1.Controls.Add(lblEmail);
            panel1.Location = new Point(3, 215);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 213);
            panel1.TabIndex = 300;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(0, 37);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(49, 15);
            lblAddress.TabIndex = 283;
            lblAddress.Text = "Address";
            // 
            // lblIdentitycard
            // 
            lblIdentitycard.AutoSize = true;
            lblIdentitycard.Location = new Point(-3, 101);
            lblIdentitycard.Name = "lblIdentitycard";
            lblIdentitycard.Size = new Size(70, 15);
            lblIdentitycard.TabIndex = 276;
            lblIdentitycard.Text = "Identitycard";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(109, 149);
            txtPhoneNumber.Margin = new Padding(3, 2, 3, 2);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(179, 23);
            txtPhoneNumber.TabIndex = 281;
            // 
            // txtIdentitycard
            // 
            txtIdentitycard.Location = new Point(109, 93);
            txtIdentitycard.Margin = new Padding(3, 2, 3, 2);
            txtIdentitycard.Name = "txtIdentitycard";
            txtIdentitycard.Size = new Size(179, 23);
            txtIdentitycard.TabIndex = 280;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(109, 37);
            txtAddress.Margin = new Padding(3, 2, 3, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(179, 23);
            txtAddress.TabIndex = 285;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(-3, 74);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(91, 15);
            lblCustomerName.TabIndex = 286;
            lblCustomerName.Text = "CustomerName";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(0, 129);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(45, 15);
            lblGender.TabIndex = 287;
            lblGender.Text = "Gender";
            // 
            // cboGender
            // 
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "male", "female" });
            cboGender.Location = new Point(109, 121);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(179, 23);
            cboGender.TabIndex = 288;
            cboGender.Text = "male";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(109, 66);
            txtCustomerName.Margin = new Padding(3, 2, 3, 2);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(179, 23);
            txtCustomerName.TabIndex = 291;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(109, 189);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(179, 23);
            txtEmail.TabIndex = 295;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(0, 157);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(85, 15);
            lblPhoneNumber.TabIndex = 292;
            lblPhoneNumber.Text = "PhoneNumber";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(3, 197);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 294;
            lblEmail.Text = "Email";
            // 
            // Infortimer
            // 
            Infortimer.Interval = 8;
            Infortimer.Tick += Infortimer_Tick;
            // 
            // inforContainer
            // 
            inforContainer.Controls.Add(btnArrow);
            inforContainer.Controls.Add(panelInforCreditAccount);
            inforContainer.Controls.Add(panel1);
            inforContainer.Location = new Point(1078, 3);
            inforContainer.MaximumSize = new Size(299, 480);
            inforContainer.MinimumSize = new Size(10, 480);
            inforContainer.Name = "inforContainer";
            inforContainer.Size = new Size(10, 480);
            inforContainer.TabIndex = 310;
            inforContainer.Visible = false;
            // 
            // btnArrow
            // 
            btnArrow.Image = Properties.Resources.arrow1;
            btnArrow.Location = new Point(135, 445);
            btnArrow.Name = "btnArrow";
            btnArrow.Size = new Size(42, 32);
            btnArrow.TabIndex = 311;
            btnArrow.UseVisualStyleBackColor = true;
            btnArrow.Click += btnArrow_Click;
            // 
            // UCCreateCreditCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(inforContainer);
            Controls.Add(gvCreditCard);
            Controls.Add(groupBox1);
            Name = "UCCreateCreditCard";
            Size = new Size(1072, 746);
            Load += UCCreditCard_Load;
            ((System.ComponentModel.ISupportInitialize)gvCreditCard).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelInforCreditAccount.ResumeLayout(false);
            panelInforCreditAccount.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            inforContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnClearAll;
        private Button btnSearch;
        private Button btnSua;
        private Button btnXoa;
        private DataGridView gvCreditCard;
        private Button btnCheck;
        private PictureBox pictureBox2;
        private TextBox txtUserName;
        private TextBox txtPassWord;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label1;
        private GroupBox groupBox1;
        private Panel panelInforCreditAccount;
        private Label lblAccountNumber;
        private Label lblCustomerID;
        private Label lblAccountType;
        private TextBox txtAccountNumber;
        private TextBox txtCustomerID;
        private Label lblAccountStatus;
        private TextBox txtAcountStatus;
        private Label lblBalance;
        private TextBox txtBalance;
        private ComboBox cboAccountType;
        private Panel panel1;
        private Label lblAddress;
        private Label lblIdentitycard;
        private TextBox txtPhoneNumber;
        private TextBox txtIdentitycard;
        private TextBox txtAddress;
        private Label lblCustomerName;
        private Label lblGender;
        private ComboBox cboGender;
        private TextBox txtCustomerName;
        private TextBox txtEmail;
        private Label lblPhoneNumber;
        private Label lblEmail;
        private System.Windows.Forms.Timer Infortimer;
        private Panel inforContainer;
        private Button btnArrow;
    }
}
