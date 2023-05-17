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
            btnLogin.Location = new Point(57, 553);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(414, 64);
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
            cboDecentralization.Location = new Point(65, 223);
            cboDecentralization.Margin = new Padding(3, 4, 3, 4);
            cboDecentralization.Name = "cboDecentralization";
            cboDecentralization.Size = new Size(405, 40);
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
            txtUserName.Location = new Point(127, 317);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(345, 35);
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
            txtPassWord.Location = new Point(127, 460);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.PasswordChar = '*';
            txtPassWord.Size = new Size(342, 35);
            txtPassWord.TabIndex = 54;
            txtPassWord.TabStop = false;
            txtPassWord.Text = "PassWord";
            txtPassWord.Enter += txtPassWord_Enter;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(218, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(101, 115);
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
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(626, 955);
            panel1.TabIndex = 58;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._5172568_add_contact_user_icon;
            pictureBox2.Location = new Point(65, 317);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 66;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Location = new Point(304, 149);
            label2.Name = "label2";
            label2.Size = new Size(194, 3);
            label2.TabIndex = 63;
            label2.Text = "label2";
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Location = new Point(33, 149);
            label4.Name = "label4";
            label4.Size = new Size(194, 3);
            label4.TabIndex = 64;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Location = new Point(126, 367);
            label3.Name = "label3";
            label3.Size = new Size(343, 3);
            label3.TabIndex = 62;
            label3.Text = "label3";
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Location = new Point(127, 500);
            label5.Name = "label5";
            label5.Size = new Size(343, 3);
            label5.TabIndex = 61;
            label5.Text = "label5";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.GhostWhite;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(391, 92);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.key;
            pictureBox1.Location = new Point(62, 440);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 65;
            pictureBox1.TabStop = false;
            // 
            // FLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImage = Properties.Resources.background_login;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1467, 881);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += FLogin_Load;
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