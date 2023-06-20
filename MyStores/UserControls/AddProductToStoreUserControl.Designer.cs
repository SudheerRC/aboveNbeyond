namespace MyStores.UserControls
{
    partial class AddProductToStoreUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductToStoreUserControl));
            this.searchInputPanel = new System.Windows.Forms.Panel();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButtonPanel = new System.Windows.Forms.Panel();
            this.searchButton = new System.Windows.Forms.Button();
            this.headingLabel = new System.Windows.Forms.Label();
            this.inventoryListView = new System.Windows.Forms.ListView();
            this.barcode = new System.Windows.Forms.ColumnHeader();
            this.productName = new System.Windows.Forms.ColumnHeader();
            this.description = new System.Windows.Forms.ColumnHeader();
            this.productSize = new System.Windows.Forms.ColumnHeader();
            this.sellingPrice = new System.Windows.Forms.ColumnHeader();
            this.purchasePrice = new System.Windows.Forms.ColumnHeader();
            this.vendorName = new System.Windows.Forms.ColumnHeader();
            this.quantity = new System.Windows.Forms.ColumnHeader();
            this.edit = new System.Windows.Forms.ColumnHeader();
            this.delete = new System.Windows.Forms.ColumnHeader();
            this.nextButton = new System.Windows.Forms.Button();
            this.productLookUpPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.purchasePriceTextBox = new System.Windows.Forms.TextBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.previousButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.purchasePriceLabel = new System.Windows.Forms.Label();
            this.sellingPriceLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.vendorInfoPanel = new System.Windows.Forms.Panel();
            this.infoGraphicPictureBox = new System.Windows.Forms.PictureBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.addVendorToStoreButton = new System.Windows.Forms.Button();
            this.searchInputPanel.SuspendLayout();
            this.searchButtonPanel.SuspendLayout();
            this.productLookUpPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.vendorInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoGraphicPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // searchInputPanel
            // 
            this.searchInputPanel.Controls.Add(this.searchTextBox);
            this.searchInputPanel.Controls.Add(this.searchButtonPanel);
            this.searchInputPanel.Location = new System.Drawing.Point(160, 91);
            this.searchInputPanel.Name = "searchInputPanel";
            this.searchInputPanel.Size = new System.Drawing.Size(297, 35);
            this.searchInputPanel.TabIndex = 3;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchTextBox.Location = new System.Drawing.Point(0, 0);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PlaceholderText = "Search for a product here";
            this.searchTextBox.Size = new System.Drawing.Size(262, 35);
            this.searchTextBox.TabIndex = 2;
            this.searchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // searchButtonPanel
            // 
            this.searchButtonPanel.Controls.Add(this.searchButton);
            this.searchButtonPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchButtonPanel.Location = new System.Drawing.Point(262, 0);
            this.searchButtonPanel.Name = "searchButtonPanel";
            this.searchButtonPanel.Size = new System.Drawing.Size(35, 35);
            this.searchButtonPanel.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.White;
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(0, 0);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(35, 35);
            this.searchButton.TabIndex = 3;
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // headingLabel
            // 
            this.headingLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.headingLabel.Location = new System.Drawing.Point(126, 19);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(368, 51);
            this.headingLabel.TabIndex = 4;
            this.headingLabel.Text = "Please enter product details to Add";
            this.headingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inventoryListView
            // 
            this.inventoryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.barcode,
            this.productName,
            this.description,
            this.productSize,
            this.sellingPrice,
            this.purchasePrice,
            this.vendorName,
            this.quantity,
            this.edit,
            this.delete});
            this.inventoryListView.Location = new System.Drawing.Point(0, 176);
            this.inventoryListView.Name = "inventoryListView";
            this.inventoryListView.Size = new System.Drawing.Size(633, 172);
            this.inventoryListView.TabIndex = 5;
            this.inventoryListView.UseCompatibleStateImageBehavior = false;
            this.inventoryListView.View = System.Windows.Forms.View.List;
            // 
            // barcode
            // 
            this.barcode.Text = "Barcode";
            this.barcode.Width = 220;
            // 
            // productName
            // 
            this.productName.Text = "Product Name";
            this.productName.Width = 220;
            // 
            // description
            // 
            this.description.Text = "Description";
            this.description.Width = 220;
            // 
            // productSize
            // 
            this.productSize.Text = "Product Size";
            this.productSize.Width = 220;
            // 
            // sellingPrice
            // 
            this.sellingPrice.Text = "Selling Price";
            this.sellingPrice.Width = 220;
            // 
            // purchasePrice
            // 
            this.purchasePrice.Text = "Purchase Price";
            this.purchasePrice.Width = 220;
            // 
            // vendorName
            // 
            this.vendorName.Text = "Vendor Name";
            this.vendorName.Width = 220;
            // 
            // quantity
            // 
            this.quantity.Text = "Quantity";
            this.quantity.Width = 220;
            // 
            // edit
            // 
            this.edit.Text = "";
            // 
            // delete
            // 
            this.delete.Text = "";
            // 
            // nextButton
            // 
            this.nextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.nextButton.FlatAppearance.BorderSize = 0;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nextButton.ForeColor = System.Drawing.Color.White;
            this.nextButton.Location = new System.Drawing.Point(373, 378);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(1238, 390);
            this.nextButton.TabIndex = 6;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = false;
            // 
            // productLookUpPanel
            // 
            this.productLookUpPanel.Controls.Add(this.panel1);
            this.productLookUpPanel.Controls.Add(this.headingLabel);
            this.productLookUpPanel.Controls.Add(this.searchInputPanel);
            this.productLookUpPanel.Controls.Add(this.inventoryListView);
            this.productLookUpPanel.Location = new System.Drawing.Point(3, 3);
            this.productLookUpPanel.Name = "productLookUpPanel";
            this.productLookUpPanel.Size = new System.Drawing.Size(633, 369);
            this.productLookUpPanel.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.quantityLabel);
            this.panel1.Controls.Add(this.sellingPriceLabel);
            this.panel1.Controls.Add(this.purchasePriceLabel);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox);
            this.panel1.Controls.Add(this.purchasePriceTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 369);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(126, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 51);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please enter product details to Add";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // purchasePriceTextBox
            // 
            this.purchasePriceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.purchasePriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.purchasePriceTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.purchasePriceTextBox.Location = new System.Drawing.Point(308, 132);
            this.purchasePriceTextBox.Multiline = true;
            this.purchasePriceTextBox.Name = "purchasePriceTextBox";
            this.purchasePriceTextBox.PlaceholderText = "Enter purchase price";
            this.purchasePriceTextBox.Size = new System.Drawing.Size(262, 35);
            this.purchasePriceTextBox.TabIndex = 6;
            this.purchasePriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox.Location = new System.Drawing.Point(308, 209);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.PlaceholderText = "Enter selling price";
            this.textBox.Size = new System.Drawing.Size(262, 35);
            this.textBox.TabIndex = 7;
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(308, 283);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.PlaceholderText = "Enter quantity";
            this.textBox4.Size = new System.Drawing.Size(262, 35);
            this.textBox4.TabIndex = 8;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // previousButton
            // 
            this.previousButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.previousButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.previousButton.Enabled = false;
            this.previousButton.FlatAppearance.BorderSize = 0;
            this.previousButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.previousButton.ForeColor = System.Drawing.Color.White;
            this.previousButton.Location = new System.Drawing.Point(174, 378);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(1238, 390);
            this.previousButton.TabIndex = 8;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = false;
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.addButton.Enabled = false;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(274, 378);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(1238, 390);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // purchasePriceLabel
            // 
            this.purchasePriceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.purchasePriceLabel.Location = new System.Drawing.Point(21, 132);
            this.purchasePriceLabel.Name = "purchasePriceLabel";
            this.purchasePriceLabel.Size = new System.Drawing.Size(234, 35);
            this.purchasePriceLabel.TabIndex = 10;
            this.purchasePriceLabel.Text = "Purchase price:";
            this.purchasePriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sellingPriceLabel
            // 
            this.sellingPriceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sellingPriceLabel.Location = new System.Drawing.Point(21, 209);
            this.sellingPriceLabel.Name = "sellingPriceLabel";
            this.sellingPriceLabel.Size = new System.Drawing.Size(234, 35);
            this.sellingPriceLabel.TabIndex = 12;
            this.sellingPriceLabel.Text = "Selling price:";
            this.sellingPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // quantityLabel
            // 
            this.quantityLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quantityLabel.Location = new System.Drawing.Point(21, 283);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(234, 35);
            this.quantityLabel.TabIndex = 13;
            this.quantityLabel.Text = "Quantity:";
            this.quantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.vendorInfoPanel);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(705, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(633, 369);
            this.panel2.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 35);
            this.label4.TabIndex = 11;
            this.label4.Text = "Vendor:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownHeight = 110;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Location = new System.Drawing.Point(290, 97);
            this.comboBox1.MaxDropDownItems = 99;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(262, 29);
            this.comboBox1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(126, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(368, 51);
            this.label6.TabIndex = 4;
            this.label6.Text = "Please select the vendor";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vendorInfoPanel
            // 
            this.vendorInfoPanel.Controls.Add(this.addVendorToStoreButton);
            this.vendorInfoPanel.Controls.Add(this.messageLabel);
            this.vendorInfoPanel.Controls.Add(this.infoGraphicPictureBox);
            this.vendorInfoPanel.Location = new System.Drawing.Point(126, 160);
            this.vendorInfoPanel.Name = "vendorInfoPanel";
            this.vendorInfoPanel.Padding = new System.Windows.Forms.Padding(8);
            this.vendorInfoPanel.Size = new System.Drawing.Size(426, 170);
            this.vendorInfoPanel.TabIndex = 12;
            // 
            // infoGraphicPictureBox
            // 
            this.infoGraphicPictureBox.Location = new System.Drawing.Point(11, 11);
            this.infoGraphicPictureBox.Name = "infoGraphicPictureBox";
            this.infoGraphicPictureBox.Size = new System.Drawing.Size(48, 48);
            this.infoGraphicPictureBox.TabIndex = 0;
            this.infoGraphicPictureBox.TabStop = false;
            // 
            // messageLabel
            // 
            this.messageLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.messageLabel.Location = new System.Drawing.Point(65, 11);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(350, 101);
            this.messageLabel.TabIndex = 13;
            this.messageLabel.Text = "Info Message";
            // 
            // addVendorToStoreButton
            // 
            this.addVendorToStoreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addVendorToStoreButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.addVendorToStoreButton.Enabled = false;
            this.addVendorToStoreButton.FlatAppearance.BorderSize = 0;
            this.addVendorToStoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addVendorToStoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addVendorToStoreButton.ForeColor = System.Drawing.Color.White;
            this.addVendorToStoreButton.Location = new System.Drawing.Point(133, 121);
            this.addVendorToStoreButton.Name = "addVendorToStoreButton";
            this.addVendorToStoreButton.Size = new System.Drawing.Size(170, 41);
            this.addVendorToStoreButton.TabIndex = 15;
            this.addVendorToStoreButton.Text = "Add Vendor to Store";
            this.addVendorToStoreButton.UseVisualStyleBackColor = false;
            // 
            // AddProductToStoreUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.productLookUpPanel);
            this.Controls.Add(this.nextButton);
            this.Name = "AddProductToStoreUserControl";
            this.Size = new System.Drawing.Size(1790, 777);
            this.searchInputPanel.ResumeLayout(false);
            this.searchInputPanel.PerformLayout();
            this.searchButtonPanel.ResumeLayout(false);
            this.productLookUpPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.vendorInfoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoGraphicPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel searchInputPanel;
        private Panel searchButtonPanel;
        private Button searchButton;
        private TextBox searchTextBox;
        private Label headingLabel;
        private ListView inventoryListView;
        private ColumnHeader barcode;
        private ColumnHeader productName;
        private ColumnHeader description;
        private ColumnHeader productSize;
        private ColumnHeader sellingPrice;
        private ColumnHeader purchasePrice;
        private ColumnHeader vendorName;
        private ColumnHeader quantity;
        private ColumnHeader edit;
        private ColumnHeader delete;
        private Button nextButton;
        private Panel productLookUpPanel;
        private Panel panel1;
        private Label quantityLabel;
        private Label sellingPriceLabel;
        private Label purchasePriceLabel;
        private TextBox textBox4;
        private TextBox textBox;
        private TextBox purchasePriceTextBox;
        private Label label1;
        private Button previousButton;
        private Button addButton;
        private Panel panel2;
        private Panel vendorInfoPanel;
        private Button addVendorToStoreButton;
        private Label messageLabel;
        private PictureBox infoGraphicPictureBox;
        private Label label4;
        private ComboBox comboBox1;
        private Label label6;
    }
}
