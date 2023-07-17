namespace MyStores.UserControls
{
    partial class InvoiceUserControl
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
            shopNameLabel = new Label();
            saleNumberLabel = new Label();
            dateTimeLabel = new Label();
            lineItemFlowLayoutPanel = new FlowLayoutPanel();
            totalValueLabel = new Label();
            totalHeadingLabel = new Label();
            SuspendLayout();
            // 
            // shopNameLabel
            // 
            shopNameLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            shopNameLabel.Location = new Point(0, 11);
            shopNameLabel.Name = "shopNameLabel";
            shopNameLabel.Size = new Size(555, 39);
            shopNameLabel.TabIndex = 0;
            shopNameLabel.Text = "Store Name";
            shopNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // saleNumberLabel
            // 
            saleNumberLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            saleNumberLabel.Location = new Point(0, 50);
            saleNumberLabel.Name = "saleNumberLabel";
            saleNumberLabel.Size = new Size(555, 30);
            saleNumberLabel.TabIndex = 1;
            saleNumberLabel.Text = "Sale #22";
            saleNumberLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateTimeLabel
            // 
            dateTimeLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimeLabel.Location = new Point(0, 80);
            dateTimeLabel.Name = "dateTimeLabel";
            dateTimeLabel.Size = new Size(555, 28);
            dateTimeLabel.TabIndex = 2;
            dateTimeLabel.Text = "Date - ";
            dateTimeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lineItemFlowLayoutPanel
            // 
            lineItemFlowLayoutPanel.Location = new Point(17, 128);
            lineItemFlowLayoutPanel.Name = "lineItemFlowLayoutPanel";
            lineItemFlowLayoutPanel.Size = new Size(520, 374);
            lineItemFlowLayoutPanel.TabIndex = 3;
            // 
            // totalValueLabel
            // 
            totalValueLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            totalValueLabel.Location = new Point(268, 527);
            totalValueLabel.Name = "totalValueLabel";
            totalValueLabel.Size = new Size(287, 28);
            totalValueLabel.TabIndex = 4;
            totalValueLabel.Text = "$ 0.00";
            totalValueLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // totalHeadingLabel
            // 
            totalHeadingLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            totalHeadingLabel.Location = new Point(0, 527);
            totalHeadingLabel.Name = "totalHeadingLabel";
            totalHeadingLabel.Size = new Size(262, 28);
            totalHeadingLabel.TabIndex = 5;
            totalHeadingLabel.Text = "Total:";
            totalHeadingLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // InvoiceUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 211, 177);
            Controls.Add(totalValueLabel);
            Controls.Add(totalHeadingLabel);
            Controls.Add(lineItemFlowLayoutPanel);
            Controls.Add(dateTimeLabel);
            Controls.Add(saleNumberLabel);
            Controls.Add(shopNameLabel);
            Name = "InvoiceUserControl";
            Size = new Size(555, 579);
            ResumeLayout(false);
        }

        #endregion

        private Label shopNameLabel;
        private Label saleNumberLabel;
        private Label dateTimeLabel;
        private FlowLayoutPanel lineItemFlowLayoutPanel;
        private Label totalValueLabel;
        private Label totalHeadingLabel;
    }
}
