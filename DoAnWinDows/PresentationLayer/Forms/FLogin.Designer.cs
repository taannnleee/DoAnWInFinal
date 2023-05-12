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
            btnLogin = new Button();
            cboDecentralization = new ComboBox();
            txtUserName = new TextBox();
            txtPassWord = new TextBox();
            panel2 = new Panel();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LightBlue;
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(50, 415);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(362, 48);
            btnLogin.TabIndex = 56;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // cboDecentralization
            // 
            cboDecentralization.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cboDecentralization.FormattingEnabled = true;
            cboDecentralization.Items.AddRange(new object[] { "Manager", "Employee" });
            cboDecentralization.Location = new Point(57, 167);
            cboDecentralization.Name = "cboDecentralization";
            cboDecentralization.Size = new Size(355, 33);
            cboDecentralization.TabIndex = 55;
            cboDecentralization.Text = "Employee";
            cboDecentralization.MouseEnter += cboDecentralization_MouseEnter;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.SteelBlue;
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.ForeColor = SystemColors.Window;
            txtUserName.HideSelection = false;
            txtUserName.Location = new Point(110, 245);
            txtUserName.Margin = new Padding(3, 2, 3, 2);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(302, 28);
            txtUserName.TabIndex = 53;
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
            txtPassWord.Location = new Point(111, 345);
            txtPassWord.Margin = new Padding(3, 2, 3, 2);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new Size(299, 28);
            txtPassWord.TabIndex = 54;
            txtPassWord.TabStop = false;
            txtPassWord.Text = "PassWord";
            txtPassWord.Enter += txtPassWord_Enter;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(191, 56);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(88, 86);
            panel2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(txtPassWord);
            panel1.Controls.Add(cboDecentralization);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(548, 716);
            panel1.TabIndex = 58;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._5172568_add_contact_user_icon;
            pictureBox2.Location = new Point(57, 238);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 66;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Location = new Point(266, 112);
            label2.Name = "label2";
            label2.Size = new Size(170, 2);
            label2.TabIndex = 63;
            label2.Text = "label2";
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Location = new Point(29, 112);
            label4.Name = "label4";
            label4.Size = new Size(170, 2);
            label4.TabIndex = 64;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Location = new Point(110, 275);
            label3.Name = "label3";
            label3.Size = new Size(300, 2);
            label3.TabIndex = 62;
            label3.Text = "label3";
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Location = new Point(111, 375);
            label5.Name = "label5";
            label5.Size = new Size(300, 2);
            label5.TabIndex = 61;
            label5.Text = "label5";
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
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.key;
            pictureBox1.Location = new Point(54, 330);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 65;
            pictureBox1.TabStop = false;
            // 
            // FLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImage = Properties.Resources.background_login;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1284, 661);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnLogin;
        private ComboBox cboDecentralization;
        private TextBox txtUserName;
        private TextBox txtPassWord;
        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}