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
            menuStrip1 = new MenuStrip();
            accountToolStripMenuItem = new ToolStripMenuItem();
            administratorAccountManagementToolStripMenuItem = new ToolStripMenuItem();
            managerToolStripMenuItem = new ToolStripMenuItem();
            accountManagerToolStripMenuItem = new ToolStripMenuItem();
            employeeManagerToolStripMenuItem = new ToolStripMenuItem();
            panelContainer = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientInactiveCaption;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { accountToolStripMenuItem, managerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            accountToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { administratorAccountManagementToolStripMenuItem });
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            accountToolStripMenuItem.Size = new Size(168, 24);
            accountToolStripMenuItem.Text = "AdministratorAccount";
            // 
            // administratorAccountManagementToolStripMenuItem
            // 
            administratorAccountManagementToolStripMenuItem.Name = "administratorAccountManagementToolStripMenuItem";
            administratorAccountManagementToolStripMenuItem.Size = new Size(234, 26);
            administratorAccountManagementToolStripMenuItem.Text = "AccountManagement";
            administratorAccountManagementToolStripMenuItem.Click += administratorAccountManagementToolStripMenuItem_Click;
            // 
            // managerToolStripMenuItem
            // 
            managerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { accountManagerToolStripMenuItem, employeeManagerToolStripMenuItem });
            managerToolStripMenuItem.Name = "managerToolStripMenuItem";
            managerToolStripMenuItem.Size = new Size(82, 24);
            managerToolStripMenuItem.Text = "Manager";
            // 
            // accountManagerToolStripMenuItem
            // 
            accountManagerToolStripMenuItem.Name = "accountManagerToolStripMenuItem";
            accountManagerToolStripMenuItem.Size = new Size(221, 26);
            accountManagerToolStripMenuItem.Text = "Customer Account";
            accountManagerToolStripMenuItem.Click += customerAccountToolStripMenuItem_Click;
            // 
            // employeeManagerToolStripMenuItem
            // 
            employeeManagerToolStripMenuItem.Name = "employeeManagerToolStripMenuItem";
            employeeManagerToolStripMenuItem.Size = new Size(221, 26);
            employeeManagerToolStripMenuItem.Text = "Employee Manager";
            employeeManagerToolStripMenuItem.Click += employeeManagerToolStripMenuItem_Click;
            // 
            // panelContainer
            // 
            panelContainer.Location = new Point(0, 36);
            panelContainer.Margin = new Padding(3, 4, 3, 4);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(914, 560);
            panelContainer.TabIndex = 1;
            // 
            // FManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(914, 600);
            Controls.Add(panelContainer);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FManager";
            Text = "Manager";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem managerToolStripMenuItem;
        private ToolStripMenuItem accountManagerToolStripMenuItem;
        private Panel panelContainer;
        private ToolStripMenuItem employeeManagerToolStripMenuItem;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem administratorAccountManagementToolStripMenuItem;
    }
}