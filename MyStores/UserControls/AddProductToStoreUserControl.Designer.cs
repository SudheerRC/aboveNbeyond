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
            this.productId = new System.Windows.Forms.ColumnHeader();
            this.barcode = new System.Windows.Forms.ColumnHeader();
            this.productName = new System.Windows.Forms.ColumnHeader();
            this.description = new System.Windows.Forms.ColumnHeader();
            this.productSize = new System.Windows.Forms.ColumnHeader();
            this.sellingPrice = new System.Windows.Forms.ColumnHeader();
            this.nextButton = new System.Windows.Forms.Button();
            this.productLookUpPanel = new System.Windows.Forms.Panel();
            this.vendorPanel = new System.Windows.Forms.Panel();
            this.vendorInfoPanel = new System.Windows.Forms.Panel();
            this.messageLabel = new System.Windows.Forms.Label();
            this.infoGraphicPictureBox = new System.Windows.Forms.PictureBox();
            this.vendorHeadingLabel = new System.Windows.Forms.Label();
            this.vendorComboBox = new System.Windows.Forms.ComboBox();
            this.vendorPanelTitleLabel = new System.Windows.Forms.Label();
            this.pricePanel = new System.Windows.Forms.Panel();
            this.sellingPriceErrorLabel = new System.Windows.Forms.Label();
            this.quantityErrorLabel = new System.Windows.Forms.Label();
            this.purchasePriceErrorLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.sellingPriceLabel = new System.Windows.Forms.Label();
            this.purchasePriceLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.sellingPriceTextBox = new System.Windows.Forms.TextBox();
            this.purchasePriceTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.previousButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.searchInputPanel.SuspendLayout();
            this.searchButtonPanel.SuspendLayout();
            this.productLookUpPanel.SuspendLayout();
            this.vendorPanel.SuspendLayout();
            this.vendorInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoGraphicPictureBox)).BeginInit();
            this.pricePanel.SuspendLayout();
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
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
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
            this.inventoryListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inventoryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productId,
            this.barcode,
            this.productName,
            this.description,
            this.productSize,
            this.sellingPrice});
            this.inventoryListView.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inventoryListView.GridLines = true;
            this.inventoryListView.Location = new System.Drawing.Point(0, 176);
            this.inventoryListView.Name = "inventoryListView";
            this.inventoryListView.Size = new System.Drawing.Size(633, 172);
            this.inventoryListView.TabIndex = 5;
            this.inventoryListView.UseCompatibleStateImageBehavior = false;
            this.inventoryListView.View = System.Windows.Forms.View.Details;
            this.inventoryListView.SelectedIndexChanged += new System.EventHandler(this.inventoryListView_SelectedIndexChanged);
            // 
            // productId
            // 
            this.productId.DisplayIndex = 5;
            this.productId.Text = "ID";
            this.productId.Width = 40;
            // 
            // barcode
            // 
            this.barcode.DisplayIndex = 0;
            this.barcode.Text = "Barcode";
            this.barcode.Width = 80;
            // 
            // productName
            // 
            this.productName.DisplayIndex = 1;
            this.productName.Text = "Product Name";
            this.productName.Width = 180;
            // 
            // description
            // 
            this.description.DisplayIndex = 2;
            this.description.Text = "Description";
            this.description.Width = 140;
            // 
            // productSize
            // 
            this.productSize.DisplayIndex = 3;
            this.productSize.Text = "Product Size";
            this.productSize.Width = 90;
            // 
            // sellingPrice
            // 
            this.sellingPrice.DisplayIndex = 4;
            this.sellingPrice.Text = "Selling Price";
            this.sellingPrice.Width = 90;
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
            this.nextButton.Size = new System.Drawing.Size(87, 31);
            this.nextButton.TabIndex = 6;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // productLookUpPanel
            // 
            this.productLookUpPanel.Controls.Add(this.headingLabel);
            this.productLookUpPanel.Controls.Add(this.searchInputPanel);
            this.productLookUpPanel.Controls.Add(this.inventoryListView);
            this.productLookUpPanel.Location = new System.Drawing.Point(3, 3);
            this.productLookUpPanel.Name = "productLookUpPanel";
            this.productLookUpPanel.Size = new System.Drawing.Size(633, 369);
            this.productLookUpPanel.TabIndex = 7;
            // 
            // vendorPanel
            // 
            this.vendorPanel.Controls.Add(this.vendorInfoPanel);
            this.vendorPanel.Controls.Add(this.vendorHeadingLabel);
            this.vendorPanel.Controls.Add(this.vendorComboBox);
            this.vendorPanel.Controls.Add(this.vendorPanelTitleLabel);
            this.vendorPanel.Location = new System.Drawing.Point(3, 3);
            this.vendorPanel.Name = "vendorPanel";
            this.vendorPanel.Size = new System.Drawing.Size(633, 369);
            this.vendorPanel.TabIndex = 14;
            // 
            // vendorInfoPanel
            // 
            this.vendorInfoPanel.Controls.Add(this.messageLabel);
            this.vendorInfoPanel.Controls.Add(this.infoGraphicPictureBox);
            this.vendorInfoPanel.Location = new System.Drawing.Point(107, 160);
            this.vendorInfoPanel.Name = "vendorInfoPanel";
            this.vendorInfoPanel.Padding = new System.Windows.Forms.Padding(8);
            this.vendorInfoPanel.Size = new System.Drawing.Size(426, 170);
            this.vendorInfoPanel.TabIndex = 12;
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
            // infoGraphicPictureBox
            // 
            this.infoGraphicPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("infoGraphicPictureBox.Image")));
            this.infoGraphicPictureBox.Location = new System.Drawing.Point(11, 11);
            this.infoGraphicPictureBox.Name = "infoGraphicPictureBox";
            this.infoGraphicPictureBox.Size = new System.Drawing.Size(48, 48);
            this.infoGraphicPictureBox.TabIndex = 0;
            this.infoGraphicPictureBox.TabStop = false;
            // 
            // vendorHeadingLabel
            // 
            this.vendorHeadingLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vendorHeadingLabel.Location = new System.Drawing.Point(107, 92);
            this.vendorHeadingLabel.Name = "vendorHeadingLabel";
            this.vendorHeadingLabel.Size = new System.Drawing.Size(111, 35);
            this.vendorHeadingLabel.TabIndex = 11;
            this.vendorHeadingLabel.Text = "Vendor:";
            this.vendorHeadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // vendorComboBox
            // 
            this.vendorComboBox.DropDownHeight = 110;
            this.vendorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vendorComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vendorComboBox.FormattingEnabled = true;
            this.vendorComboBox.IntegralHeight = false;
            this.vendorComboBox.Location = new System.Drawing.Point(271, 97);
            this.vendorComboBox.MaxDropDownItems = 99;
            this.vendorComboBox.Name = "vendorComboBox";
            this.vendorComboBox.Size = new System.Drawing.Size(262, 29);
            this.vendorComboBox.TabIndex = 9;
            // 
            // vendorPanelTitleLabel
            // 
            this.vendorPanelTitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vendorPanelTitleLabel.Location = new System.Drawing.Point(3, 19);
            this.vendorPanelTitleLabel.Name = "vendorPanelTitleLabel";
            this.vendorPanelTitleLabel.Size = new System.Drawing.Size(627, 51);
            this.vendorPanelTitleLabel.TabIndex = 4;
            this.vendorPanelTitleLabel.Text = "Please select the vendor that supplies the product";
            this.vendorPanelTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pricePanel
            // 
            this.pricePanel.Controls.Add(this.productLookUpPanel);
            this.pricePanel.Controls.Add(this.sellingPriceErrorLabel);
            this.pricePanel.Controls.Add(this.quantityErrorLabel);
            this.pricePanel.Controls.Add(this.purchasePriceErrorLabel);
            this.pricePanel.Controls.Add(this.quantityLabel);
            this.pricePanel.Controls.Add(this.sellingPriceLabel);
            this.pricePanel.Controls.Add(this.purchasePriceLabel);
            this.pricePanel.Controls.Add(this.quantityTextBox);
            this.pricePanel.Controls.Add(this.sellingPriceTextBox);
            this.pricePanel.Controls.Add(this.purchasePriceTextBox);
            this.pricePanel.Controls.Add(this.titleLabel);
            this.pricePanel.Location = new System.Drawing.Point(3, 3);
            this.pricePanel.Name = "pricePanel";
            this.pricePanel.Size = new System.Drawing.Size(633, 369);
            this.pricePanel.TabIndex = 8;
            // 
            // sellingPriceErrorLabel
            // 
            this.sellingPriceErrorLabel.AutoSize = true;
            this.sellingPriceErrorLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sellingPriceErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.sellingPriceErrorLabel.Location = new System.Drawing.Point(308, 247);
            this.sellingPriceErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sellingPriceErrorLabel.Name = "sellingPriceErrorLabel";
            this.sellingPriceErrorLabel.Size = new System.Drawing.Size(55, 15);
            this.sellingPriceErrorLabel.TabIndex = 110;
            this.sellingPriceErrorLabel.Text = "Error text";
            this.sellingPriceErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sellingPriceErrorLabel.UseWaitCursor = true;
            this.sellingPriceErrorLabel.Visible = false;
            // 
            // quantityErrorLabel
            // 
            this.quantityErrorLabel.AutoSize = true;
            this.quantityErrorLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantityErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.quantityErrorLabel.Location = new System.Drawing.Point(308, 321);
            this.quantityErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quantityErrorLabel.Name = "quantityErrorLabel";
            this.quantityErrorLabel.Size = new System.Drawing.Size(55, 15);
            this.quantityErrorLabel.TabIndex = 109;
            this.quantityErrorLabel.Text = "Error text";
            this.quantityErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.quantityErrorLabel.UseWaitCursor = true;
            this.quantityErrorLabel.Visible = false;
            // 
            // purchasePriceErrorLabel
            // 
            this.purchasePriceErrorLabel.AutoSize = true;
            this.purchasePriceErrorLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.purchasePriceErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.purchasePriceErrorLabel.Location = new System.Drawing.Point(308, 170);
            this.purchasePriceErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.purchasePriceErrorLabel.Name = "purchasePriceErrorLabel";
            this.purchasePriceErrorLabel.Size = new System.Drawing.Size(55, 15);
            this.purchasePriceErrorLabel.TabIndex = 108;
            this.purchasePriceErrorLabel.Text = "Error text";
            this.purchasePriceErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.purchasePriceErrorLabel.UseWaitCursor = true;
            this.purchasePriceErrorLabel.Visible = false;
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
            // quantityTextBox
            // 
            this.quantityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quantityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantityTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantityTextBox.Location = new System.Drawing.Point(308, 283);
            this.quantityTextBox.Multiline = true;
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.PlaceholderText = "Enter quantity";
            this.quantityTextBox.Size = new System.Drawing.Size(262, 35);
            this.quantityTextBox.TabIndex = 8;
            this.quantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantityTextBox.TextChanged += new System.EventHandler(this.quantityTextBox_TextChanged);
            // 
            // sellingPriceTextBox
            // 
            this.sellingPriceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sellingPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sellingPriceTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sellingPriceTextBox.Location = new System.Drawing.Point(308, 209);
            this.sellingPriceTextBox.Multiline = true;
            this.sellingPriceTextBox.Name = "sellingPriceTextBox";
            this.sellingPriceTextBox.PlaceholderText = "Enter selling price";
            this.sellingPriceTextBox.Size = new System.Drawing.Size(262, 35);
            this.sellingPriceTextBox.TabIndex = 7;
            this.sellingPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sellingPriceTextBox.TextChanged += new System.EventHandler(this.sellingPriceTextBox_TextChanged);
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
            this.purchasePriceTextBox.TextChanged += new System.EventHandler(this.purchasePriceTextBox_TextChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(126, 19);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(368, 51);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Please enter product details to Add";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.previousButton.Size = new System.Drawing.Size(87, 31);
            this.previousButton.TabIndex = 8;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = false;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
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
            this.addButton.Size = new System.Drawing.Size(87, 31);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AddProductToStoreUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Controls.Add(this.vendorPanel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.pricePanel);
            this.Name = "AddProductToStoreUserControl";
            this.Size = new System.Drawing.Size(639, 418);
            this.Load += new System.EventHandler(this.AddProductToStoreUserControl_Load);
            this.searchInputPanel.ResumeLayout(false);
            this.searchInputPanel.PerformLayout();
            this.searchButtonPanel.ResumeLayout(false);
            this.productLookUpPanel.ResumeLayout(false);
            this.vendorPanel.ResumeLayout(false);
            this.vendorInfoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoGraphicPictureBox)).EndInit();
            this.pricePanel.ResumeLayout(false);
            this.pricePanel.PerformLayout();
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
        private Button nextButton;
        private Panel productLookUpPanel;
        private Panel pricePanel;
        private Label quantityLabel;
        private Label sellingPriceLabel;
        private Label purchasePriceLabel;
        private TextBox quantityTextBox;
        private TextBox sellingPriceTextBox;
        private TextBox purchasePriceTextBox;
        private Label titleLabel;
        private Button previousButton;
        private Button addButton;
        private Panel vendorPanel;
        private Panel vendorInfoPanel;
        private Label messageLabel;
        private PictureBox infoGraphicPictureBox;
        private Label vendorHeadingLabel;
        private ComboBox vendorComboBox;
        private Label vendorPanelTitleLabel;
        private ColumnHeader productId;
        private Label sellingPriceErrorLabel;
        private Label quantityErrorLabel;
        private Label purchasePriceErrorLabel;
    }
}
