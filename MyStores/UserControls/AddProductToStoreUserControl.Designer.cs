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
            searchInputPanel = new Panel();
            searchTextBox = new TextBox();
            searchButtonPanel = new Panel();
            searchButton = new Button();
            headingLabel = new Label();
            inventoryListView = new ListView();
            productId = new ColumnHeader();
            barcode = new ColumnHeader();
            productName = new ColumnHeader();
            description = new ColumnHeader();
            productSize = new ColumnHeader();
            sellingPrice = new ColumnHeader();
            nextButton = new Button();
            productLookUpPanel = new Panel();
            vendorPanel = new Panel();
            vendorInfoPanel = new Panel();
            messageLabel = new Label();
            infoGraphicPictureBox = new PictureBox();
            vendorHeadingLabel = new Label();
            vendorComboBox = new ComboBox();
            vendorPanelTitleLabel = new Label();
            pricePanel = new Panel();
            purchasePriceErrorLabel = new Label();
            quantityLabel = new Label();
            sellingPriceLabel = new Label();
            purchasePriceLabel = new Label();
            quantityTextBox = new TextBox();
            sellingPriceTextBox = new TextBox();
            purchasePriceTextBox = new TextBox();
            titleLabel = new Label();
            minimumQuantityLabel = new Label();
            minimumQuantityErrorLabel = new Label();
            minimumQuantityTextBox = new TextBox();
            sellingPriceErrorLabel = new Label();
            quantityErrorLabel = new Label();
            previousButton = new Button();
            addButton = new Button();
            searchInputPanel.SuspendLayout();
            searchButtonPanel.SuspendLayout();
            productLookUpPanel.SuspendLayout();
            vendorPanel.SuspendLayout();
            vendorInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)infoGraphicPictureBox).BeginInit();
            pricePanel.SuspendLayout();
            SuspendLayout();
            // 
            // searchInputPanel
            // 
            searchInputPanel.Controls.Add(searchTextBox);
            searchInputPanel.Controls.Add(searchButtonPanel);
            searchInputPanel.Location = new Point(183, 121);
            searchInputPanel.Margin = new Padding(3, 4, 3, 4);
            searchInputPanel.Name = "searchInputPanel";
            searchInputPanel.Size = new Size(339, 47);
            searchInputPanel.TabIndex = 3;
            // 
            // searchTextBox
            // 
            searchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            searchTextBox.BorderStyle = BorderStyle.None;
            searchTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchTextBox.Location = new Point(0, 0);
            searchTextBox.Margin = new Padding(3, 4, 3, 4);
            searchTextBox.Multiline = true;
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "Search for a product here";
            searchTextBox.Size = new Size(299, 47);
            searchTextBox.TabIndex = 2;
            searchTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // searchButtonPanel
            // 
            searchButtonPanel.Controls.Add(searchButton);
            searchButtonPanel.Dock = DockStyle.Right;
            searchButtonPanel.Location = new Point(299, 0);
            searchButtonPanel.Margin = new Padding(3, 4, 3, 4);
            searchButtonPanel.Name = "searchButtonPanel";
            searchButtonPanel.Size = new Size(40, 47);
            searchButtonPanel.TabIndex = 0;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.White;
            searchButton.Dock = DockStyle.Right;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Image = (Image)resources.GetObject("searchButton.Image");
            searchButton.Location = new Point(0, 0);
            searchButton.Margin = new Padding(3, 4, 3, 4);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(40, 47);
            searchButton.TabIndex = 3;
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // headingLabel
            // 
            headingLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            headingLabel.Location = new Point(144, 25);
            headingLabel.Name = "headingLabel";
            headingLabel.Size = new Size(421, 68);
            headingLabel.TabIndex = 4;
            headingLabel.Text = "Please enter product details to Add";
            headingLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // inventoryListView
            // 
            inventoryListView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inventoryListView.BorderStyle = BorderStyle.None;
            inventoryListView.Columns.AddRange(new ColumnHeader[] { productId, barcode, productName, description, productSize, sellingPrice });
            inventoryListView.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            inventoryListView.FullRowSelect = true;
            inventoryListView.GridLines = true;
            inventoryListView.Location = new Point(0, 230);
            inventoryListView.Margin = new Padding(5, 6, 5, 6);
            inventoryListView.MultiSelect = false;
            inventoryListView.Name = "inventoryListView";
            inventoryListView.Size = new Size(720, 375);
            inventoryListView.TabIndex = 5;
            inventoryListView.UseCompatibleStateImageBehavior = false;
            inventoryListView.View = System.Windows.Forms.View.Details;
            inventoryListView.SelectedIndexChanged += inventoryListView_SelectedIndexChanged;
            // 
            // productId
            // 
            productId.DisplayIndex = 5;
            productId.Text = "ID";
            productId.Width = 80;
            // 
            // barcode
            // 
            barcode.DisplayIndex = 0;
            barcode.Text = "Barcode";
            barcode.Width = 200;
            // 
            // productName
            // 
            productName.DisplayIndex = 1;
            productName.Text = "Product Name";
            productName.Width = 300;
            // 
            // description
            // 
            description.DisplayIndex = 2;
            description.Text = "Description";
            description.Width = 300;
            // 
            // productSize
            // 
            productSize.DisplayIndex = 3;
            productSize.Text = "Product Size";
            productSize.Width = 180;
            // 
            // sellingPrice
            // 
            sellingPrice.DisplayIndex = 4;
            sellingPrice.Text = "Selling Price";
            sellingPrice.Width = 160;
            // 
            // nextButton
            // 
            nextButton.BackColor = Color.FromArgb(28, 44, 78);
            nextButton.FlatAppearance.BorderSize = 0;
            nextButton.FlatStyle = FlatStyle.Flat;
            nextButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            nextButton.ForeColor = Color.White;
            nextButton.Location = new Point(376, 488);
            nextButton.Margin = new Padding(3, 4, 3, 4);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(99, 41);
            nextButton.TabIndex = 6;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += nextButton_Click;
            // 
            // productLookUpPanel
            // 
            productLookUpPanel.Controls.Add(headingLabel);
            productLookUpPanel.Controls.Add(searchInputPanel);
            productLookUpPanel.Controls.Add(inventoryListView);
            productLookUpPanel.Location = new Point(4, 4);
            productLookUpPanel.Margin = new Padding(3, 4, 3, 4);
            productLookUpPanel.Name = "productLookUpPanel";
            productLookUpPanel.Size = new Size(723, 464);
            productLookUpPanel.TabIndex = 7;
            // 
            // vendorPanel
            // 
            vendorPanel.Controls.Add(vendorInfoPanel);
            vendorPanel.Controls.Add(vendorHeadingLabel);
            vendorPanel.Controls.Add(vendorComboBox);
            vendorPanel.Controls.Add(vendorPanelTitleLabel);
            vendorPanel.Location = new Point(3, 4);
            vendorPanel.Margin = new Padding(3, 4, 3, 4);
            vendorPanel.Name = "vendorPanel";
            vendorPanel.Size = new Size(723, 468);
            vendorPanel.TabIndex = 14;
            // 
            // vendorInfoPanel
            // 
            vendorInfoPanel.Controls.Add(messageLabel);
            vendorInfoPanel.Controls.Add(infoGraphicPictureBox);
            vendorInfoPanel.Location = new Point(122, 193);
            vendorInfoPanel.Margin = new Padding(3, 4, 3, 4);
            vendorInfoPanel.Name = "vendorInfoPanel";
            vendorInfoPanel.Padding = new Padding(9, 11, 9, 11);
            vendorInfoPanel.Size = new Size(487, 227);
            vendorInfoPanel.TabIndex = 12;
            // 
            // messageLabel
            // 
            messageLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            messageLabel.Location = new Point(74, 15);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(400, 135);
            messageLabel.TabIndex = 13;
            messageLabel.Text = "Info Message";
            // 
            // infoGraphicPictureBox
            // 
            infoGraphicPictureBox.Image = (Image)resources.GetObject("infoGraphicPictureBox.Image");
            infoGraphicPictureBox.Location = new Point(13, 15);
            infoGraphicPictureBox.Margin = new Padding(3, 4, 3, 4);
            infoGraphicPictureBox.Name = "infoGraphicPictureBox";
            infoGraphicPictureBox.Size = new Size(55, 64);
            infoGraphicPictureBox.TabIndex = 0;
            infoGraphicPictureBox.TabStop = false;
            // 
            // vendorHeadingLabel
            // 
            vendorHeadingLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            vendorHeadingLabel.Location = new Point(122, 103);
            vendorHeadingLabel.Name = "vendorHeadingLabel";
            vendorHeadingLabel.Size = new Size(127, 47);
            vendorHeadingLabel.TabIndex = 11;
            vendorHeadingLabel.Text = "Vendor:";
            vendorHeadingLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // vendorComboBox
            // 
            vendorComboBox.DropDownHeight = 110;
            vendorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            vendorComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            vendorComboBox.FormattingEnabled = true;
            vendorComboBox.IntegralHeight = false;
            vendorComboBox.Location = new Point(310, 109);
            vendorComboBox.Margin = new Padding(3, 4, 3, 4);
            vendorComboBox.MaxDropDownItems = 99;
            vendorComboBox.Name = "vendorComboBox";
            vendorComboBox.Size = new Size(299, 36);
            vendorComboBox.TabIndex = 9;
            // 
            // vendorPanelTitleLabel
            // 
            vendorPanelTitleLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            vendorPanelTitleLabel.Location = new Point(3, 12);
            vendorPanelTitleLabel.Name = "vendorPanelTitleLabel";
            vendorPanelTitleLabel.Size = new Size(717, 68);
            vendorPanelTitleLabel.TabIndex = 4;
            vendorPanelTitleLabel.Text = "Please select the vendor that supplies the product";
            vendorPanelTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pricePanel
            // 
            pricePanel.Controls.Add(productLookUpPanel);
            pricePanel.Controls.Add(purchasePriceErrorLabel);
            pricePanel.Controls.Add(quantityLabel);
            pricePanel.Controls.Add(sellingPriceLabel);
            pricePanel.Controls.Add(purchasePriceLabel);
            pricePanel.Controls.Add(quantityTextBox);
            pricePanel.Controls.Add(sellingPriceTextBox);
            pricePanel.Controls.Add(purchasePriceTextBox);
            pricePanel.Controls.Add(titleLabel);
            pricePanel.Controls.Add(minimumQuantityLabel);
            pricePanel.Controls.Add(minimumQuantityErrorLabel);
            pricePanel.Controls.Add(minimumQuantityTextBox);
            pricePanel.Controls.Add(sellingPriceErrorLabel);
            pricePanel.Controls.Add(quantityErrorLabel);
            pricePanel.Location = new Point(3, 4);
            pricePanel.Margin = new Padding(3, 4, 3, 4);
            pricePanel.Name = "pricePanel";
            pricePanel.Size = new Size(723, 468);
            pricePanel.TabIndex = 8;
            // 
            // purchasePriceErrorLabel
            // 
            purchasePriceErrorLabel.AutoSize = true;
            purchasePriceErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            purchasePriceErrorLabel.ForeColor = Color.Red;
            purchasePriceErrorLabel.Location = new Point(352, 154);
            purchasePriceErrorLabel.Margin = new Padding(2, 0, 2, 0);
            purchasePriceErrorLabel.Name = "purchasePriceErrorLabel";
            purchasePriceErrorLabel.Size = new Size(70, 20);
            purchasePriceErrorLabel.TabIndex = 108;
            purchasePriceErrorLabel.Text = "Error text";
            purchasePriceErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            purchasePriceErrorLabel.UseWaitCursor = true;
            purchasePriceErrorLabel.Visible = false;
            // 
            // quantityLabel
            // 
            quantityLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            quantityLabel.Location = new Point(24, 293);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(267, 47);
            quantityLabel.TabIndex = 13;
            quantityLabel.Text = "Quantity:";
            quantityLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // sellingPriceLabel
            // 
            sellingPriceLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            sellingPriceLabel.Location = new Point(24, 195);
            sellingPriceLabel.Name = "sellingPriceLabel";
            sellingPriceLabel.Size = new Size(267, 47);
            sellingPriceLabel.TabIndex = 12;
            sellingPriceLabel.Text = "Selling price:";
            sellingPriceLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // purchasePriceLabel
            // 
            purchasePriceLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            purchasePriceLabel.Location = new Point(24, 103);
            purchasePriceLabel.Name = "purchasePriceLabel";
            purchasePriceLabel.Size = new Size(267, 47);
            purchasePriceLabel.TabIndex = 10;
            purchasePriceLabel.Text = "Purchase price:";
            purchasePriceLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // quantityTextBox
            // 
            quantityTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            quantityTextBox.BorderStyle = BorderStyle.None;
            quantityTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            quantityTextBox.Location = new Point(352, 293);
            quantityTextBox.Margin = new Padding(3, 4, 3, 4);
            quantityTextBox.Multiline = true;
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.PlaceholderText = "Enter quantity";
            quantityTextBox.Size = new Size(299, 43);
            quantityTextBox.TabIndex = 8;
            quantityTextBox.TextAlign = HorizontalAlignment.Center;
            quantityTextBox.TextChanged += quantityTextBox_TextChanged;
            // 
            // sellingPriceTextBox
            // 
            sellingPriceTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sellingPriceTextBox.BorderStyle = BorderStyle.None;
            sellingPriceTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sellingPriceTextBox.Location = new Point(352, 195);
            sellingPriceTextBox.Margin = new Padding(3, 4, 3, 4);
            sellingPriceTextBox.Multiline = true;
            sellingPriceTextBox.Name = "sellingPriceTextBox";
            sellingPriceTextBox.PlaceholderText = "Enter selling price";
            sellingPriceTextBox.Size = new Size(299, 46);
            sellingPriceTextBox.TabIndex = 7;
            sellingPriceTextBox.TextAlign = HorizontalAlignment.Center;
            sellingPriceTextBox.TextChanged += sellingPriceTextBox_TextChanged;
            // 
            // purchasePriceTextBox
            // 
            purchasePriceTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            purchasePriceTextBox.BorderStyle = BorderStyle.None;
            purchasePriceTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            purchasePriceTextBox.Location = new Point(352, 103);
            purchasePriceTextBox.Margin = new Padding(3, 4, 3, 4);
            purchasePriceTextBox.Multiline = true;
            purchasePriceTextBox.Name = "purchasePriceTextBox";
            purchasePriceTextBox.PlaceholderText = "Enter purchase price";
            purchasePriceTextBox.Size = new Size(299, 47);
            purchasePriceTextBox.TabIndex = 6;
            purchasePriceTextBox.TextAlign = HorizontalAlignment.Center;
            purchasePriceTextBox.TextChanged += purchasePriceTextBox_TextChanged;
            // 
            // titleLabel
            // 
            titleLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.Location = new Point(144, 25);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(421, 68);
            titleLabel.TabIndex = 4;
            titleLabel.Text = "Please enter product details to Add";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minimumQuantityLabel
            // 
            minimumQuantityLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            minimumQuantityLabel.Location = new Point(3, 393);
            minimumQuantityLabel.Name = "minimumQuantityLabel";
            minimumQuantityLabel.Size = new Size(288, 47);
            minimumQuantityLabel.TabIndex = 112;
            minimumQuantityLabel.Text = "Pref. Minimum Quantity:";
            minimumQuantityLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // minimumQuantityErrorLabel
            // 
            minimumQuantityErrorLabel.AutoSize = true;
            minimumQuantityErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            minimumQuantityErrorLabel.ForeColor = Color.Red;
            minimumQuantityErrorLabel.Location = new Point(352, 444);
            minimumQuantityErrorLabel.Margin = new Padding(2, 0, 2, 0);
            minimumQuantityErrorLabel.Name = "minimumQuantityErrorLabel";
            minimumQuantityErrorLabel.Size = new Size(70, 20);
            minimumQuantityErrorLabel.TabIndex = 113;
            minimumQuantityErrorLabel.Text = "Error text";
            minimumQuantityErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            minimumQuantityErrorLabel.UseWaitCursor = true;
            minimumQuantityErrorLabel.Visible = false;
            // 
            // minimumQuantityTextBox
            // 
            minimumQuantityTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            minimumQuantityTextBox.BorderStyle = BorderStyle.None;
            minimumQuantityTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            minimumQuantityTextBox.Location = new Point(352, 393);
            minimumQuantityTextBox.Margin = new Padding(3, 4, 3, 4);
            minimumQuantityTextBox.Multiline = true;
            minimumQuantityTextBox.Name = "minimumQuantityTextBox";
            minimumQuantityTextBox.PlaceholderText = "Enter preferred min quantity";
            minimumQuantityTextBox.Size = new Size(299, 43);
            minimumQuantityTextBox.TabIndex = 111;
            minimumQuantityTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // sellingPriceErrorLabel
            // 
            sellingPriceErrorLabel.AutoSize = true;
            sellingPriceErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            sellingPriceErrorLabel.ForeColor = Color.Red;
            sellingPriceErrorLabel.Location = new Point(352, 245);
            sellingPriceErrorLabel.Margin = new Padding(2, 0, 2, 0);
            sellingPriceErrorLabel.Name = "sellingPriceErrorLabel";
            sellingPriceErrorLabel.Size = new Size(70, 20);
            sellingPriceErrorLabel.TabIndex = 110;
            sellingPriceErrorLabel.Text = "Error text";
            sellingPriceErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            sellingPriceErrorLabel.UseWaitCursor = true;
            sellingPriceErrorLabel.Visible = false;
            // 
            // quantityErrorLabel
            // 
            quantityErrorLabel.AutoSize = true;
            quantityErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            quantityErrorLabel.ForeColor = Color.Red;
            quantityErrorLabel.Location = new Point(352, 344);
            quantityErrorLabel.Margin = new Padding(2, 0, 2, 0);
            quantityErrorLabel.Name = "quantityErrorLabel";
            quantityErrorLabel.Size = new Size(70, 20);
            quantityErrorLabel.TabIndex = 109;
            quantityErrorLabel.Text = "Error text";
            quantityErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            quantityErrorLabel.UseWaitCursor = true;
            quantityErrorLabel.Visible = false;
            // 
            // previousButton
            // 
            previousButton.BackColor = Color.FromArgb(28, 44, 78);
            previousButton.Enabled = false;
            previousButton.FlatAppearance.BorderSize = 0;
            previousButton.FlatStyle = FlatStyle.Flat;
            previousButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            previousButton.ForeColor = Color.White;
            previousButton.Location = new Point(257, 488);
            previousButton.Margin = new Padding(3, 4, 3, 4);
            previousButton.Name = "previousButton";
            previousButton.Size = new Size(99, 41);
            previousButton.TabIndex = 8;
            previousButton.Text = "Previous";
            previousButton.UseVisualStyleBackColor = false;
            previousButton.Click += previousButton_Click;
            // 
            // addButton
            // 
            addButton.BackColor = Color.FromArgb(28, 44, 78);
            addButton.Enabled = false;
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(376, 488);
            addButton.Margin = new Padding(3, 4, 3, 4);
            addButton.Name = "addButton";
            addButton.Size = new Size(99, 41);
            addButton.TabIndex = 9;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // minimumQuantityErrorLabel
            // 
            minimumQuantityErrorLabel.AutoSize = true;
            minimumQuantityErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            minimumQuantityErrorLabel.ForeColor = Color.Red;
            minimumQuantityErrorLabel.Location = new Point(352, 444);
            minimumQuantityErrorLabel.Margin = new Padding(2, 0, 2, 0);
            minimumQuantityErrorLabel.Name = "minimumQuantityErrorLabel";
            minimumQuantityErrorLabel.Size = new Size(70, 20);
            minimumQuantityErrorLabel.TabIndex = 113;
            minimumQuantityErrorLabel.Text = "Error text";
            minimumQuantityErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            minimumQuantityErrorLabel.UseWaitCursor = true;
            minimumQuantityErrorLabel.Visible = false;
            // 
            // minimumQuantityLabel
            // 
            minimumQuantityLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            minimumQuantityLabel.Location = new Point(3, 393);
            minimumQuantityLabel.Name = "minimumQuantityLabel";
            minimumQuantityLabel.Size = new Size(288, 47);
            minimumQuantityLabel.TabIndex = 112;
            minimumQuantityLabel.Text = "Pref. Minimum Quantity:";
            minimumQuantityLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // minimumQuantityTextBox
            // 
            minimumQuantityTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            minimumQuantityTextBox.BorderStyle = BorderStyle.None;
            minimumQuantityTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            minimumQuantityTextBox.Location = new Point(352, 393);
            minimumQuantityTextBox.Margin = new Padding(3, 4, 3, 4);
            minimumQuantityTextBox.Multiline = true;
            minimumQuantityTextBox.Name = "minimumQuantityTextBox";
            minimumQuantityTextBox.PlaceholderText = "Enter preferred min quantity";
            minimumQuantityTextBox.Size = new Size(299, 43);
            minimumQuantityTextBox.TabIndex = 111;
            minimumQuantityTextBox.TextAlign = HorizontalAlignment.Center;
            minimumQuantityTextBox.TextChanged += minimumQuantityTextBox_TextChanged;
            // 
            // AddProductToStoreUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 211, 177);
            Controls.Add(addButton);
            Controls.Add(previousButton);
            Controls.Add(nextButton);
            Controls.Add(pricePanel);
            Controls.Add(vendorPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddProductToStoreUserControl";
            Size = new Size(730, 533);
            Load += AddProductToStoreUserControl_Load;
            searchInputPanel.ResumeLayout(false);
            searchInputPanel.PerformLayout();
            searchButtonPanel.ResumeLayout(false);
            productLookUpPanel.ResumeLayout(false);
            vendorPanel.ResumeLayout(false);
            vendorInfoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)infoGraphicPictureBox).EndInit();
            pricePanel.ResumeLayout(false);
            pricePanel.PerformLayout();
            ResumeLayout(false);
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
        private Label minimumQuantityErrorLabel;
        private Label minimumQuantityLabel;
        private TextBox minimumQuantityTextBox;
    }
}
