namespace MyStores.UserControls
{
    partial class InvoiceLineItemUserControl
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
            productNameLabel = new Label();
            discountHeadingabel = new Label();
            discountValueLabel = new Label();
            sizeValueLabel = new Label();
            quantityValueLabel = new Label();
            unitPriceValueLabel = new Label();
            sizeLabel = new Label();
            quantityHeadingLabel = new Label();
            unitPriceHeadingLabel = new Label();
            productIdLabel = new Label();
            dividerPanel = new Panel();
            SuspendLayout();
            // 
            // productNameLabel
            // 
            productNameLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            productNameLabel.Location = new Point(3, 0);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(354, 36);
            productNameLabel.TabIndex = 2;
            productNameLabel.Text = "Product Name";
            productNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // discountHeadingabel
            // 
            discountHeadingabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            discountHeadingabel.ForeColor = Color.Red;
            discountHeadingabel.Location = new Point(172, 37);
            discountHeadingabel.Name = "discountHeadingabel";
            discountHeadingabel.Size = new Size(92, 35);
            discountHeadingabel.TabIndex = 3;
            discountHeadingabel.Text = "Discount:";
            discountHeadingabel.TextAlign = ContentAlignment.MiddleRight;
            discountHeadingabel.Visible = false;
            // 
            // discountValueLabel
            // 
            discountValueLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            discountValueLabel.ForeColor = Color.Red;
            discountValueLabel.Location = new Point(270, 37);
            discountValueLabel.Name = "discountValueLabel";
            discountValueLabel.Size = new Size(87, 35);
            discountValueLabel.TabIndex = 4;
            discountValueLabel.Text = "$ 1.99";
            discountValueLabel.TextAlign = ContentAlignment.MiddleRight;
            discountValueLabel.Visible = false;
            // 
            // sizeValueLabel
            // 
            sizeValueLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            sizeValueLabel.Location = new Point(363, 37);
            sizeValueLabel.Name = "sizeValueLabel";
            sizeValueLabel.Size = new Size(76, 35);
            sizeValueLabel.TabIndex = 5;
            sizeValueLabel.Text = "20Oz";
            sizeValueLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // quantityValueLabel
            // 
            quantityValueLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            quantityValueLabel.Location = new Point(445, 37);
            quantityValueLabel.Name = "quantityValueLabel";
            quantityValueLabel.Size = new Size(79, 35);
            quantityValueLabel.TabIndex = 6;
            quantityValueLabel.Text = "8";
            quantityValueLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // unitPriceValueLabel
            // 
            unitPriceValueLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            unitPriceValueLabel.Location = new Point(530, 37);
            unitPriceValueLabel.Name = "unitPriceValueLabel";
            unitPriceValueLabel.Size = new Size(89, 35);
            unitPriceValueLabel.TabIndex = 7;
            unitPriceValueLabel.Text = "$ 2.99";
            unitPriceValueLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sizeLabel
            // 
            sizeLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            sizeLabel.Location = new Point(363, 0);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new Size(76, 36);
            sizeLabel.TabIndex = 8;
            sizeLabel.Text = "Size";
            sizeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // quantityHeadingLabel
            // 
            quantityHeadingLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            quantityHeadingLabel.Location = new Point(445, 0);
            quantityHeadingLabel.Name = "quantityHeadingLabel";
            quantityHeadingLabel.Size = new Size(79, 36);
            quantityHeadingLabel.TabIndex = 9;
            quantityHeadingLabel.Text = "Quantity";
            quantityHeadingLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // unitPriceHeadingLabel
            // 
            unitPriceHeadingLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            unitPriceHeadingLabel.Location = new Point(530, 0);
            unitPriceHeadingLabel.Name = "unitPriceHeadingLabel";
            unitPriceHeadingLabel.Size = new Size(89, 36);
            unitPriceHeadingLabel.TabIndex = 10;
            unitPriceHeadingLabel.Text = "Unit Price";
            unitPriceHeadingLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // productIdLabel
            // 
            productIdLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            productIdLabel.Location = new Point(3, 37);
            productIdLabel.Name = "productIdLabel";
            productIdLabel.Size = new Size(163, 36);
            productIdLabel.TabIndex = 11;
            productIdLabel.Text = "#22222";
            productIdLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dividerPanel
            // 
            dividerPanel.BackColor = Color.FromArgb(28, 44, 78);
            dividerPanel.Location = new Point(0, 80);
            dividerPanel.Name = "dividerPanel";
            dividerPanel.Size = new Size(622, 10);
            dividerPanel.TabIndex = 12;
            // 
            // InvoiceLineItemUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 211, 177);
            Controls.Add(dividerPanel);
            Controls.Add(productIdLabel);
            Controls.Add(unitPriceHeadingLabel);
            Controls.Add(quantityHeadingLabel);
            Controls.Add(sizeLabel);
            Controls.Add(unitPriceValueLabel);
            Controls.Add(quantityValueLabel);
            Controls.Add(sizeValueLabel);
            Controls.Add(discountValueLabel);
            Controls.Add(discountHeadingabel);
            Controls.Add(productNameLabel);
            Name = "InvoiceLineItemUserControl";
            Size = new Size(622, 85);
            Load += InvoiceLineItemUserControl_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label productNameLabel;
        private Label discountHeadingabel;
        private Label discountValueLabel;
        private Label sizeValueLabel;
        private Label quantityValueLabel;
        private Label unitPriceValueLabel;
        private Label sizeLabel;
        private Label quantityHeadingLabel;
        private Label unitPriceHeadingLabel;
        private Label productIdLabel;
        private Panel dividerPanel;
    }
}
