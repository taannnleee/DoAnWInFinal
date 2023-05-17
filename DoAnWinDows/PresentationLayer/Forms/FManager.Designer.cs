namespace DoAnWinDows
{
    partial class FManager
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FManager));
            Hometimer = new System.Windows.Forms.Timer(components);
            sidebarTimer = new System.Windows.Forms.Timer(components);
            panelManager = new Panel();
            homeContainer = new Panel();
            panel7 = new Panel();
            btnEmployee = new Button();
            panel5 = new Panel();
            btnCustomer = new Button();
            panel4 = new Panel();
            btnManager = new Button();
            panel3 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            menuButton = new PictureBox();
            panel6 = new Panel();
            button4 = new Button();
            lblMenu = new Label();
            sidebar = new FlowLayoutPanel();
            homeContainer.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            panel6.SuspendLayout();
            sidebar.SuspendLayout();
            SuspendLayout();
            // 
            // Hometimer
            // 
            Hometimer.Interval = 10;
            Hometimer.Tick += Hometimer_Tick;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 8;
            // 
            // panelManager
            // 
            panelManager.Location = new Point(211, 3);
            panelManager.Name = "panelManager";
            panelManager.Size = new Size(1072, 746);
            panelManager.TabIndex = 4;
            // 
            // homeContainer
            // 
            homeContainer.Controls.Add(panel7);
            homeContainer.Controls.Add(panel5);
            homeContainer.Controls.Add(panel4);
            homeContainer.Location = new Point(3, 70);
            homeContainer.MaximumSize = new Size(200, 200);
            homeContainer.MinimumSize = new Size(200, 60);
            homeContainer.Name = "homeContainer";
            homeContainer.Size = new Size(200, 60);
            homeContainer.TabIndex = 6;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnEmployee);
            panel7.Location = new Point(3, 130);
            panel7.Name = "panel7";
            panel7.Size = new Size(202, 66);
            panel7.TabIndex = 9;
            // 
            // btnEmployee
            // 
            btnEmployee.BackColor = Color.FromArgb(64, 64, 64);
            btnEmployee.BackgroundImageLayout = ImageLayout.None;
            btnEmployee.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnEmployee.FlatAppearance.BorderSize = 5000;
            btnEmployee.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnEmployee.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnEmployee.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmployee.ForeColor = Color.White;
            btnEmployee.Image = (Image)resources.GetObject("btnEmployee.Image");
            btnEmployee.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmployee.Location = new Point(7, -2);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Padding = new Padding(30, 0, 0, 0);
            btnEmployee.Size = new Size(216, 65);
            btnEmployee.TabIndex = 7;
            btnEmployee.Text = "        Employee";
            btnEmployee.UseVisualStyleBackColor = false;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnCustomer);
            panel5.Location = new Point(0, 59);
            panel5.Name = "panel5";
            panel5.Size = new Size(204, 68);
            panel5.TabIndex = 5;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = Color.FromArgb(64, 64, 64);
            btnCustomer.BackgroundImageLayout = ImageLayout.None;
            btnCustomer.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnCustomer.FlatAppearance.BorderSize = 5000;
            btnCustomer.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnCustomer.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnCustomer.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCustomer.ForeColor = Color.White;
            btnCustomer.Image = (Image)resources.GetObject("btnCustomer.Image");
            btnCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomer.Location = new Point(9, 0);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Padding = new Padding(30, 0, 0, 0);
            btnCustomer.Size = new Size(217, 65);
            btnCustomer.TabIndex = 8;
            btnCustomer.Text = "        Customer";
            btnCustomer.UseVisualStyleBackColor = false;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnManager);
            panel4.Controls.Add(panel3);
            panel4.Location = new Point(0, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(197, 57);
            panel4.TabIndex = 4;
            // 
            // btnManager
            // 
            btnManager.BackColor = Color.FromArgb(64, 64, 64);
            btnManager.BackgroundImageLayout = ImageLayout.None;
            btnManager.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnManager.FlatAppearance.BorderSize = 5000;
            btnManager.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnManager.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnManager.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnManager.ForeColor = Color.White;
            btnManager.Image = (Image)resources.GetObject("btnManager.Image");
            btnManager.ImageAlign = ContentAlignment.MiddleLeft;
            btnManager.Location = new Point(0, -3);
            btnManager.Name = "btnManager";
            btnManager.Padding = new Padding(30, 0, 0, 0);
            btnManager.Size = new Size(188, 57);
            btnManager.TabIndex = 3;
            btnManager.Text = "        Manager";
            btnManager.UseVisualStyleBackColor = false;
            btnManager.Click += btnHome_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel1);
            panel3.Location = new Point(17, 53);
            panel3.Name = "panel3";
            panel3.Size = new Size(183, 49);
            panel3.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Location = new Point(1, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 49);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(menuButton);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(lblMenu);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 61);
            panel2.TabIndex = 2;
            // 
            // menuButton
            // 
            menuButton.BackColor = Color.Transparent;
            menuButton.BorderStyle = BorderStyle.FixedSingle;
            menuButton.Cursor = Cursors.Hand;
            menuButton.Image = (Image)resources.GetObject("menuButton.Image");
            menuButton.Location = new Point(3, 3);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(53, 50);
            menuButton.SizeMode = PictureBoxSizeMode.StretchImage;
            menuButton.TabIndex = 0;
            menuButton.TabStop = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(button4);
            panel6.Location = new Point(3, 61);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 42);
            panel6.TabIndex = 6;
            // 
            // button4
            // 
            button4.ImageAlign = ContentAlignment.MiddleRight;
            button4.Location = new Point(57, 3);
            button4.Name = "button4";
            button4.Size = new Size(145, 36);
            button4.TabIndex = 3;
            button4.Text = "Home";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.BackColor = Color.FromArgb(64, 64, 64);
            lblMenu.BorderStyle = BorderStyle.Fixed3D;
            lblMenu.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblMenu.ForeColor = Color.Cyan;
            lblMenu.Location = new Point(60, 6);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(104, 47);
            lblMenu.TabIndex = 1;
            lblMenu.Text = "Menu";
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(64, 64, 64);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(homeContainer);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(205, 661);
            sidebar.MinimumSize = new Size(61, 661);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(205, 661);
            sidebar.TabIndex = 3;
            // 
            // FManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1284, 749);
            Controls.Add(sidebar);
            Controls.Add(panelManager);
            Name = "FManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manager";
            homeContainer.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            panel6.ResumeLayout(false);
            sidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer Hometimer;
        private System.Windows.Forms.Timer sidebarTimer;
        private Panel panelManager;
        private Panel homeContainer;
        private Panel panel5;
        private Button btnCustomer;
        private Panel panel4;
        private Button btnManager;
        private Panel panel3;
        private Panel panel1;
        private Button btnEmployee;
        private Panel panel2;
        private PictureBox menuButton;
        private Panel panel6;
        private Button button4;
        private Label lblMenu;
        private FlowLayoutPanel sidebar;
        private Panel panel7;
    }
}