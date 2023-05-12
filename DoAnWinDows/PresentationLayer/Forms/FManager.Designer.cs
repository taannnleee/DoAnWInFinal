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
            menuStrip1.Items.AddRange(new ToolStripItem[] { managerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // managerToolStripMenuItem
            // 
            managerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { accountManagerToolStripMenuItem, employeeManagerToolStripMenuItem });
            managerToolStripMenuItem.Name = "managerToolStripMenuItem";
            managerToolStripMenuItem.Size = new Size(66, 20);
            managerToolStripMenuItem.Text = "Manager";
            // 
            // accountManagerToolStripMenuItem
            // 
            accountManagerToolStripMenuItem.Name = "accountManagerToolStripMenuItem";
            accountManagerToolStripMenuItem.Size = new Size(180, 22);
            accountManagerToolStripMenuItem.Text = "Customer Account";
            accountManagerToolStripMenuItem.Click += customerAccountToolStripMenuItem_Click;
            // 
            // employeeManagerToolStripMenuItem
            // 
            employeeManagerToolStripMenuItem.Name = "employeeManagerToolStripMenuItem";
            employeeManagerToolStripMenuItem.Size = new Size(180, 22);
            employeeManagerToolStripMenuItem.Text = "Employee Manager";
            employeeManagerToolStripMenuItem.Click += employeeManagerToolStripMenuItem_Click;
            // 
            // panelContainer
            // 
            panelContainer.Location = new Point(0, 27);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(800, 420);
            panelContainer.TabIndex = 1;
            // 
            // FManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContainer);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
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
    }
}