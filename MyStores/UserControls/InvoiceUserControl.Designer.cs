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
            invoiceLineItemUserControl1 = new InvoiceLineItemUserControl();
            dateValueLabel = new Label();
            lineItemFlowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // shopNameLabel
            // 
            shopNameLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            shopNameLabel.Location = new Point(0, 11);
            shopNameLabel.Name = "shopNameLabel";
            shopNameLabel.Size = new Size(678, 39);
            shopNameLabel.TabIndex = 0;
            shopNameLabel.Text = "Store Name";
            shopNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // saleNumberLabel
            // 
            saleNumberLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            saleNumberLabel.Location = new Point(0, 50);
            saleNumberLabel.Name = "saleNumberLabel";
            saleNumberLabel.Size = new Size(678, 30);
            saleNumberLabel.TabIndex = 1;
            saleNumberLabel.Text = "Sale #22";
            saleNumberLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateTimeLabel
            // 
            dateTimeLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimeLabel.Location = new Point(0, 80);
            dateTimeLabel.Name = "dateTimeLabel";
            dateTimeLabel.Size = new Size(277, 28);
            dateTimeLabel.TabIndex = 2;
            dateTimeLabel.Text = "Date - ";
            dateTimeLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lineItemFlowLayoutPanel
            // 
            lineItemFlowLayoutPanel.Controls.Add(invoiceLineItemUserControl1);
            lineItemFlowLayoutPanel.Location = new Point(17, 128);
            lineItemFlowLayoutPanel.Name = "lineItemFlowLayoutPanel";
            lineItemFlowLayoutPanel.Size = new Size(643, 374);
            lineItemFlowLayoutPanel.TabIndex = 3;
            // 
            // totalValueLabel
            // 
            totalValueLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            totalValueLabel.Location = new Point(346, 527);
            totalValueLabel.Name = "totalValueLabel";
            totalValueLabel.Size = new Size(332, 38);
            totalValueLabel.TabIndex = 4;
            totalValueLabel.Text = "$ 0.00";
            totalValueLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // totalHeadingLabel
            // 
            totalHeadingLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            totalHeadingLabel.Location = new Point(0, 527);
            totalHeadingLabel.Name = "totalHeadingLabel";
            totalHeadingLabel.Size = new Size(340, 38);
            totalHeadingLabel.TabIndex = 5;
            totalHeadingLabel.Text = "Total:";
            totalHeadingLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // invoiceLineItemUserControl1
            // 
            invoiceLineItemUserControl1.BackColor = Color.FromArgb(227, 211, 177);
            invoiceLineItemUserControl1.Location = new Point(3, 3);
            invoiceLineItemUserControl1.Name = "invoiceLineItemUserControl1";
            invoiceLineItemUserControl1.Size = new Size(621, 106);
            invoiceLineItemUserControl1.TabIndex = 0;
            // 
            // dateValueLabel
            // 
            dateValueLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dateValueLabel.Location = new Point(283, 80);
            dateValueLabel.Name = "dateValueLabel";
            dateValueLabel.Size = new Size(395, 28);
            dateValueLabel.TabIndex = 6;
            dateValueLabel.Text = "08/22/2023 13:09:33";
            dateValueLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // InvoiceUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 211, 177);
            Controls.Add(dateValueLabel);
            Controls.Add(totalValueLabel);
            Controls.Add(totalHeadingLabel);
            Controls.Add(lineItemFlowLayoutPanel);
            Controls.Add(dateTimeLabel);
            Controls.Add(saleNumberLabel);
            Controls.Add(shopNameLabel);
            Name = "InvoiceUserControl";
            Size = new Size(678, 579);
            lineItemFlowLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label shopNameLabel;
        private Label saleNumberLabel;
        private Label dateTimeLabel;
        private FlowLayoutPanel lineItemFlowLayoutPanel;
        private Label totalValueLabel;
        private Label totalHeadingLabel;
        private InvoiceLineItemUserControl invoiceLineItemUserControl1;
        private Label dateValueLabel;
    }
}
