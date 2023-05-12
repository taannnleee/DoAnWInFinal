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
            btnExit = new Button();
            btnLogin = new Button();
            cboDecentralization = new ComboBox();
            txtUserName = new TextBox();
            lblUserName = new Label();
            txtPassWord = new TextBox();
            lblPassWord = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.GradientInactiveCaption;
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(259, 249);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
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
            btnLogin.Location = new Point(161, 249);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 56;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // cboDecentralization
            // 
            cboDecentralization.FormattingEnabled = true;
            cboDecentralization.Items.AddRange(new object[] { "Manager", "Employee" });
            cboDecentralization.Location = new Point(198, 137);
            cboDecentralization.Name = "cboDecentralization";
            cboDecentralization.Size = new Size(92, 23);
            cboDecentralization.TabIndex = 55;
            cboDecentralization.Text = "Employee";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(154, 173);
            txtUserName.Margin = new Padding(3, 2, 3, 2);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(199, 23);
            txtUserName.TabIndex = 53;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserName.Location = new Point(77, 175);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(69, 15);
            lblUserName.TabIndex = 51;
            lblUserName.Text = "UserName";
            // 
            // txtPassWord
            // 
            txtPassWord.Location = new Point(154, 207);
            txtPassWord.Margin = new Padding(3, 2, 3, 2);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new Size(199, 23);
            txtPassWord.TabIndex = 54;
            // 
            // lblPassWord
            // 
            lblPassWord.AutoSize = true;
            lblPassWord.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassWord.Location = new Point(77, 209);
            lblPassWord.Name = "lblPassWord";
            lblPassWord.Size = new Size(65, 15);
            lblPassWord.TabIndex = 52;
            lblPassWord.Text = "Password";
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(184, 28);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(88, 86);
            panel2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(548, 716);
            panel1.TabIndex = 58;
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Location = new Point(78, 54);
            label5.Name = "label5";
            label5.Size = new Size(100, 2);
            label5.TabIndex = 61;
            label5.Text = "label5";
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Location = new Point(278, 54);
            label3.Name = "label3";
            label3.Size = new Size(110, 2);
            label3.TabIndex = 60;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Location = new Point(27, 89);
            label2.Name = "label2";
            label2.Size = new Size(3, 200);
            label2.TabIndex = 59;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.GhostWhite;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(342, 69);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            // 
            // FLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImage = Properties.Resources.background_login;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1284, 711);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(cboDecentralization);
            Controls.Add(txtUserName);
            Controls.Add(lblUserName);
            Controls.Add(lblPassWord);
            Controls.Add(txtPassWord);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnExit;
        private Button btnLogin;
        private ComboBox cboDecentralization;
        private TextBox txtUserName;
        private Label lblUserName;
        private TextBox txtPassWord;
        private Label lblPassWord;
        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
    }
}