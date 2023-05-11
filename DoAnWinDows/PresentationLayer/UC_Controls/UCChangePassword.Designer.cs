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
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.txtOldPassWord = new System.Windows.Forms.TextBox();
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.lblNewPassWord = new System.Windows.Forms.Label();
            this.txtNewPassWord = new System.Windows.Forms.TextBox();
            this.picCaptcha = new System.Windows.Forms.PictureBox();
            this.lblCaptcha = new System.Windows.Forms.Label();
            this.txtCaptcha = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCaptcha)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClearAll
            // 
            this.btnClearAll.AutoSize = true;
            this.btnClearAll.Location = new System.Drawing.Point(269, 305);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(90, 25);
            this.btnClearAll.TabIndex = 278;
            this.btnClearAll.Text = "ClearAll";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Location = new System.Drawing.Point(433, 305);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 25);
            this.btnExit.TabIndex = 267;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnComplete
            // 
            this.btnComplete.AutoSize = true;
            this.btnComplete.Location = new System.Drawing.Point(116, 305);
            this.btnComplete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(82, 25);
            this.btnComplete.TabIndex = 266;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // txtOldPassWord
            // 
            this.txtOldPassWord.Location = new System.Drawing.Point(253, 120);
            this.txtOldPassWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOldPassWord.Name = "txtOldPassWord";
            this.txtOldPassWord.Size = new System.Drawing.Size(199, 23);
            this.txtOldPassWord.TabIndex = 262;
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.Location = new System.Drawing.Point(169, 128);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(78, 15);
            this.lblOldPassword.TabIndex = 258;
            this.lblOldPassword.Text = "OldPassWord";
            // 
            // lblNewPassWord
            // 
            this.lblNewPassWord.AutoSize = true;
            this.lblNewPassWord.Location = new System.Drawing.Point(169, 175);
            this.lblNewPassWord.Name = "lblNewPassWord";
            this.lblNewPassWord.Size = new System.Drawing.Size(83, 15);
            this.lblNewPassWord.TabIndex = 279;
            this.lblNewPassWord.Text = "NewPassWord";
            // 
            // txtNewPassWord
            // 
            this.txtNewPassWord.Location = new System.Drawing.Point(253, 167);
            this.txtNewPassWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewPassWord.Name = "txtNewPassWord";
            this.txtNewPassWord.Size = new System.Drawing.Size(199, 23);
            this.txtNewPassWord.TabIndex = 280;
            // 
            // picCaptcha
            // 
            this.picCaptcha.Location = new System.Drawing.Point(399, 213);
            this.picCaptcha.Name = "picCaptcha";
            this.picCaptcha.Size = new System.Drawing.Size(102, 64);
            this.picCaptcha.TabIndex = 281;
            this.picCaptcha.TabStop = false;
            // 
            // lblCaptcha
            // 
            this.lblCaptcha.AutoSize = true;
            this.lblCaptcha.Location = new System.Drawing.Point(169, 244);
            this.lblCaptcha.Name = "lblCaptcha";
            this.lblCaptcha.Size = new System.Drawing.Size(51, 15);
            this.lblCaptcha.TabIndex = 282;
            this.lblCaptcha.Text = "Captcha";
            // 
            // txtCaptcha
            // 
            this.txtCaptcha.Location = new System.Drawing.Point(238, 244);
            this.txtCaptcha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCaptcha.Name = "txtCaptcha";
            this.txtCaptcha.Size = new System.Drawing.Size(155, 23);
            this.txtCaptcha.TabIndex = 283;
            // 
            // UCChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCaptcha);
            this.Controls.Add(this.lblCaptcha);
            this.Controls.Add(this.picCaptcha);
            this.Controls.Add(this.txtNewPassWord);
            this.Controls.Add(this.lblNewPassWord);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.txtOldPassWord);
            this.Controls.Add(this.lblOldPassword);
            this.Name = "UCChangePassword";
            this.Size = new System.Drawing.Size(708, 442);
            this.Load += new System.EventHandler(this.UCChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCaptcha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnClearAll;
        private Button btnExit;
        private Button btnComplete;
        private TextBox txtOldPassWord;
        private Label lblOldPassword;
        private Label lblNewPassWord;
        private TextBox txtNewPassWord;
        private PictureBox picCaptcha;
        private Label lblCaptcha;
        private TextBox txtCaptcha;
    }
}
