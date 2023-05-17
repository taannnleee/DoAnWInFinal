namespace DoAnWinDows
{
    partial class UCChangePassword
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
            btnClearAll = new Button();
            btnComplete = new Button();
            lblOldPassword = new Label();
            lblNewPassWord = new Label();
            picCaptcha = new PictureBox();
            lblCaptcha = new Label();
            lblUserName = new Label();
            label3 = new Label();
            txtUserName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtOldPassWord = new TextBox();
            txtNewPassWord = new TextBox();
            txtCaptcha = new TextBox();
            label4 = new Label();
            gvChangePassWord = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)picCaptcha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvChangePassWord).BeginInit();
            SuspendLayout();
            // 
            // btnClearAll
            // 
            btnClearAll.AutoSize = true;
            btnClearAll.Location = new Point(426, 573);
            btnClearAll.Margin = new Padding(5, 3, 5, 3);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(141, 42);
            btnClearAll.TabIndex = 278;
            btnClearAll.Text = "ClearAll";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // btnComplete
            // 
            btnComplete.AutoSize = true;
            btnComplete.Location = new Point(55, 573);
            btnComplete.Margin = new Padding(5, 3, 5, 3);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(129, 42);
            btnComplete.TabIndex = 266;
            btnComplete.Text = "Complete";
            btnComplete.UseVisualStyleBackColor = true;
            btnComplete.Click += btnComplete_Click;
            // 
            // lblOldPassword
            // 
            lblOldPassword.AutoSize = true;
            lblOldPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblOldPassword.ForeColor = Color.White;
            lblOldPassword.Location = new Point(20, 156);
            lblOldPassword.Margin = new Padding(5, 0, 5, 0);
            lblOldPassword.Name = "lblOldPassword";
            lblOldPassword.Size = new Size(131, 25);
            lblOldPassword.TabIndex = 258;
            lblOldPassword.Text = "OldPassWord";
            // 
            // lblNewPassWord
            // 
            lblNewPassWord.AutoSize = true;
            lblNewPassWord.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNewPassWord.ForeColor = Color.White;
            lblNewPassWord.Location = new Point(20, 268);
            lblNewPassWord.Margin = new Padding(5, 0, 5, 0);
            lblNewPassWord.Name = "lblNewPassWord";
            lblNewPassWord.Size = new Size(140, 25);
            lblNewPassWord.TabIndex = 279;
            lblNewPassWord.Text = "NewPassWord";
            // 
            // picCaptcha
            // 
            picCaptcha.Location = new Point(460, 373);
            picCaptcha.Margin = new Padding(5);
            picCaptcha.Name = "picCaptcha";
            picCaptcha.Size = new Size(201, 55);
            picCaptcha.TabIndex = 281;
            picCaptcha.TabStop = false;
            // 
            // lblCaptcha
            // 
            lblCaptcha.AutoSize = true;
            lblCaptcha.ForeColor = Color.White;
            lblCaptcha.Location = new Point(20, 439);
            lblCaptcha.Margin = new Padding(5, 0, 5, 0);
            lblCaptcha.Name = "lblCaptcha";
            lblCaptcha.Size = new Size(81, 25);
            lblCaptcha.TabIndex = 282;
            lblCaptcha.Text = "Captcha";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserName.ForeColor = Color.White;
            lblUserName.Location = new Point(20, 32);
            lblUserName.Margin = new Padding(5, 0, 5, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(104, 25);
            lblUserName.TabIndex = 284;
            lblUserName.Text = "UserName";
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Location = new Point(187, 57);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(471, 3);
            label3.TabIndex = 287;
            label3.Text = "label3";
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.SteelBlue;
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.ForeColor = SystemColors.Window;
            txtUserName.HideSelection = false;
            txtUserName.Location = new Point(187, 24);
            txtUserName.Margin = new Padding(5, 3, 5, 3);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(475, 28);
            txtUserName.TabIndex = 286;
            txtUserName.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Location = new Point(184, 295);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(471, 3);
            label1.TabIndex = 291;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Location = new Point(184, 191);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(471, 3);
            label2.TabIndex = 294;
            label2.Text = "label2";
            // 
            // txtOldPassWord
            // 
            txtOldPassWord.BackColor = Color.SteelBlue;
            txtOldPassWord.BorderStyle = BorderStyle.None;
            txtOldPassWord.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtOldPassWord.ForeColor = SystemColors.Window;
            txtOldPassWord.HideSelection = false;
            txtOldPassWord.Location = new Point(187, 154);
            txtOldPassWord.Margin = new Padding(5, 3, 5, 3);
            txtOldPassWord.Name = "txtOldPassWord";
            txtOldPassWord.Size = new Size(475, 28);
            txtOldPassWord.TabIndex = 293;
            txtOldPassWord.TabStop = false;
            // 
            // txtNewPassWord
            // 
            txtNewPassWord.BackColor = Color.SteelBlue;
            txtNewPassWord.BorderStyle = BorderStyle.None;
            txtNewPassWord.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewPassWord.ForeColor = SystemColors.Window;
            txtNewPassWord.HideSelection = false;
            txtNewPassWord.Location = new Point(195, 261);
            txtNewPassWord.Margin = new Padding(5, 3, 5, 3);
            txtNewPassWord.Name = "txtNewPassWord";
            txtNewPassWord.Size = new Size(475, 28);
            txtNewPassWord.TabIndex = 296;
            txtNewPassWord.TabStop = false;
            // 
            // txtCaptcha
            // 
            txtCaptcha.BackColor = Color.SteelBlue;
            txtCaptcha.BorderStyle = BorderStyle.None;
            txtCaptcha.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCaptcha.ForeColor = SystemColors.Window;
            txtCaptcha.HideSelection = false;
            txtCaptcha.Location = new Point(184, 436);
            txtCaptcha.Margin = new Padding(5, 3, 5, 3);
            txtCaptcha.Name = "txtCaptcha";
            txtCaptcha.Size = new Size(475, 28);
            txtCaptcha.TabIndex = 298;
            txtCaptcha.TabStop = false;
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Location = new Point(184, 472);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(471, 3);
            label4.TabIndex = 297;
            label4.Text = "label4";
            // 
            // gvChangePassWord
            // 
            gvChangePassWord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvChangePassWord.Location = new Point(716, 24);
            gvChangePassWord.Name = "gvChangePassWord";
            gvChangePassWord.RowTemplate.Height = 25;
            gvChangePassWord.Size = new Size(344, 591);
            gvChangePassWord.TabIndex = 299;
            // 
            // UCChangePassword
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gvChangePassWord);
            Controls.Add(txtCaptcha);
            Controls.Add(label4);
            Controls.Add(txtNewPassWord);
            Controls.Add(label2);
            Controls.Add(txtOldPassWord);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(txtUserName);
            Controls.Add(lblUserName);
            Controls.Add(lblCaptcha);
            Controls.Add(picCaptcha);
            Controls.Add(lblNewPassWord);
            Controls.Add(btnClearAll);
            Controls.Add(btnComplete);
            Controls.Add(lblOldPassword);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "UCChangePassword";
            Size = new Size(1685, 1243);
            Load += UCChangePassword_Load;
            ((System.ComponentModel.ISupportInitialize)picCaptcha).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvChangePassWord).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClearAll;
        private Button btnComplete;
        private Label lblOldPassword;
        private Label lblNewPassWord;
        private PictureBox picCaptcha;
        private Label lblCaptcha;
        private Label lblUserName;
        private Label label3;
        private TextBox txtUserName;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private TextBox txtOldPassWord;
        private TextBox txtNewPassWord;
        private TextBox txtCaptcha;
        private Label label4;
        private DataGridView gvChangePassWord;
    }
}
