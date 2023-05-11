namespace DoAnWinDows
{
    partial class FLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin));
            panel1 = new Panel();
            btnExit = new Button();
            btnLogin = new Button();
            cboDecentralization = new ComboBox();
            txtUserName = new TextBox();
            lblUserName = new Label();
            txtPassWord = new TextBox();
            lblPassWord = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(cboDecentralization);
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(lblUserName);
            panel1.Controls.Add(txtPassWord);
            panel1.Controls.Add(lblPassWord);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(169, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 267);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.GradientInactiveCaption;
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(221, 171);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(86, 31);
            btnExit.TabIndex = 57;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.GradientInactiveCaption;
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(109, 171);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(86, 31);
            btnLogin.TabIndex = 56;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // cboDecentralization
            // 
            cboDecentralization.FormattingEnabled = true;
            cboDecentralization.Items.AddRange(new object[] { "Manager", "Employee", "Customer" });
            cboDecentralization.Location = new Point(151, 21);
            cboDecentralization.Margin = new Padding(3, 4, 3, 4);
            cboDecentralization.Name = "cboDecentralization";
            cboDecentralization.Size = new Size(105, 28);
            cboDecentralization.TabIndex = 55;
            cboDecentralization.Text = "Manager";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(101, 69);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(227, 27);
            txtUserName.TabIndex = 53;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserName.Location = new Point(13, 72);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(84, 20);
            lblUserName.TabIndex = 51;
            lblUserName.Text = "UserName";
            // 
            // txtPassWord
            // 
            txtPassWord.Location = new Point(101, 115);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new Size(227, 27);
            txtPassWord.TabIndex = 54;
            // 
            // lblPassWord
            // 
            lblPassWord.AutoSize = true;
            lblPassWord.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassWord.Location = new Point(13, 117);
            lblPassWord.Name = "lblPassWord";
            lblPassWord.Size = new Size(81, 20);
            lblPassWord.TabIndex = 52;
            lblPassWord.Text = "Password";
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(24, 87);
            panel2.Name = "panel2";
            panel2.Size = new Size(101, 115);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 21);
            label1.Name = "label1";
            label1.Size = new Size(102, 38);
            label1.TabIndex = 2;
            label1.Text = "LOGIN";
            // 
            // FLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(519, 267);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FLogin";
            Text = "Login";
            Load += FLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnExit;
        private Button btnLogin;
        private ComboBox cboDecentralization;
        private TextBox txtUserName;
        private Label lblUserName;
        private TextBox txtPassWord;
        private Label lblPassWord;
        private Panel panel2;
        private Label label1;
    }
}