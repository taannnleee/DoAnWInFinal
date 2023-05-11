namespace DoAnWinDows.PresentationLayer.UC_Controls
{
    partial class UCPayByCredit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPayByCredit));
            lblCvvCode = new Label();
            lblHousingPayments = new Label();
            panelElectricityPayments = new Panel();
            lblElectricityPayments = new Label();
            panelHousePayments = new Panel();
            panelWaterPayments = new Panel();
            lblWaterPayment = new Label();
            txtCvvCode = new TextBox();
            SuspendLayout();
            // 
            // lblCvvCode
            // 
            lblCvvCode.AutoSize = true;
            lblCvvCode.Location = new Point(3, 80);
            lblCvvCode.Name = "lblCvvCode";
            lblCvvCode.Size = new Size(55, 15);
            lblCvvCode.TabIndex = 334;
            lblCvvCode.Text = "CvvCode";
            // 
            // lblHousingPayments
            // 
            lblHousingPayments.AutoSize = true;
            lblHousingPayments.Location = new Point(60, 322);
            lblHousingPayments.Name = "lblHousingPayments";
            lblHousingPayments.Size = new Size(107, 15);
            lblHousingPayments.TabIndex = 324;
            lblHousingPayments.Text = "Housing Payments";
            // 
            // panelElectricityPayments
            // 
            panelElectricityPayments.BackgroundImage = (Image)resources.GetObject("panelElectricityPayments.BackgroundImage");
            panelElectricityPayments.BackgroundImageLayout = ImageLayout.Zoom;
            panelElectricityPayments.Location = new Point(275, 111);
            panelElectricityPayments.Name = "panelElectricityPayments";
            panelElectricityPayments.Size = new Size(200, 199);
            panelElectricityPayments.TabIndex = 337;
            panelElectricityPayments.Click += panelElectricityPayments_Click;
            // 
            // lblElectricityPayments
            // 
            lblElectricityPayments.AutoSize = true;
            lblElectricityPayments.Location = new Point(314, 322);
            lblElectricityPayments.Name = "lblElectricityPayments";
            lblElectricityPayments.Size = new Size(113, 15);
            lblElectricityPayments.TabIndex = 324;
            lblElectricityPayments.Text = "Electricity Payments";
            // 
            // panelHousePayments
            // 
            panelHousePayments.BackgroundImage = (Image)resources.GetObject("panelHousePayments.BackgroundImage");
            panelHousePayments.BackgroundImageLayout = ImageLayout.Zoom;
            panelHousePayments.Location = new Point(18, 111);
            panelHousePayments.Name = "panelHousePayments";
            panelHousePayments.Size = new Size(197, 199);
            panelHousePayments.TabIndex = 336;
            panelHousePayments.Click += panelHousePayments_Click;
            // 
            // panelWaterPayments
            // 
            panelWaterPayments.BackgroundImage = (Image)resources.GetObject("panelWaterPayments.BackgroundImage");
            panelWaterPayments.BackgroundImageLayout = ImageLayout.Zoom;
            panelWaterPayments.Location = new Point(513, 111);
            panelWaterPayments.Name = "panelWaterPayments";
            panelWaterPayments.Size = new Size(200, 199);
            panelWaterPayments.TabIndex = 338;
            panelWaterPayments.Click += panelWaterPayments_Click;
            // 
            // lblWaterPayment
            // 
            lblWaterPayment.AutoSize = true;
            lblWaterPayment.Location = new Point(577, 322);
            lblWaterPayment.Name = "lblWaterPayment";
            lblWaterPayment.Size = new Size(93, 15);
            lblWaterPayment.TabIndex = 324;
            lblWaterPayment.Text = "Water Payments";
            // 
            // txtCvvCode
            // 
            txtCvvCode.Location = new Point(128, 74);
            txtCvvCode.Name = "txtCvvCode";
            txtCvvCode.Size = new Size(100, 23);
            txtCvvCode.TabIndex = 339;
            // 
            // UCPayByCredit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblWaterPayment);
            Controls.Add(lblElectricityPayments);
            Controls.Add(lblHousingPayments);
            Controls.Add(lblCvvCode);
            Controls.Add(panelElectricityPayments);
            Controls.Add(panelHousePayments);
            Controls.Add(panelWaterPayments);
            Controls.Add(txtCvvCode);
            Name = "UCPayByCredit";
            Size = new Size(871, 649);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCvvCode;
        private Label lblHousingPayments;
        private Panel panelElectricityPayments;
        private Label lblElectricityPayments;
        private Panel panelHousePayments;
        private Panel panelWaterPayments;
        private Label lblWaterPayment;
        private TextBox txtCvvCode;
    }
}
