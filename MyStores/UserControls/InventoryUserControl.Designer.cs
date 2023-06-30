namespace MyStores.UserControls
{
    partial class InventoryUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryUserControl));
            inventoryListView = new ListView();
            barcode = new ColumnHeader();
            productName = new ColumnHeader();
            description = new ColumnHeader();
            productSize = new ColumnHeader();
            sellingPrice = new ColumnHeader();
            purchasePrice = new ColumnHeader();
            vendorName = new ColumnHeader();
            quantity = new ColumnHeader();
            edit = new ColumnHeader();
            delete = new ColumnHeader();
            searchInputPanel = new Panel();
            searchTextBox = new TextBox();
            searchButtonPanel = new Panel();
            searchButton = new Button();
            refreshListButton = new Button();
            searchInputPanel.SuspendLayout();
            searchButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // inventoryListView
            // 
            inventoryListView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inventoryListView.BorderStyle = BorderStyle.None;
            inventoryListView.Columns.AddRange(new ColumnHeader[] { barcode, productName, description, productSize, sellingPrice, purchasePrice, vendorName, quantity, edit, delete });
            inventoryListView.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            inventoryListView.GridLines = true;
            inventoryListView.Location = new Point(11, 53);
            inventoryListView.Margin = new Padding(3, 4, 3, 4);
            inventoryListView.Name = "inventoryListView";
            inventoryListView.Size = new Size(1497, 437);
            inventoryListView.TabIndex = 0;
            inventoryListView.UseCompatibleStateImageBehavior = false;
            inventoryListView.View = System.Windows.Forms.View.Details;
            // 
            // barcode
            // 
            barcode.Text = "Barcode";
            barcode.Width = 160;
            // 
            // productName
            // 
            productName.Text = "Product Name";
            productName.Width = 280;
            // 
            // description
            // 
            description.Text = "Description";
            description.Width = 220;
            // 
            // productSize
            // 
            productSize.Text = "Size";
            productSize.Width = 90;
            // 
            // sellingPrice
            // 
            sellingPrice.Text = "Selling Price";
            sellingPrice.Width = 110;
            // 
            // purchasePrice
            // 
            purchasePrice.Text = "Purchase Price";
            purchasePrice.Width = 110;
            // 
            // vendorName
            // 
            vendorName.Text = "Vendor Name";
            vendorName.Width = 140;
            // 
            // quantity
            // 
            quantity.Text = "Quantity";
            quantity.Width = 90;
            // 
            // edit
            // 
            edit.Text = "";
            // 
            // delete
            // 
            delete.Text = "";
            // 
            // searchInputPanel
            // 
            searchInputPanel.BorderStyle = BorderStyle.FixedSingle;
            searchInputPanel.Controls.Add(searchTextBox);
            searchInputPanel.Controls.Add(searchButtonPanel);
            searchInputPanel.Location = new Point(11, 0);
            searchInputPanel.Margin = new Padding(3, 4, 3, 4);
            searchInputPanel.Name = "searchInputPanel";
            searchInputPanel.Size = new Size(339, 46);
            searchInputPanel.TabIndex = 1;
            // 
            // searchTextBox
            // 
            searchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            searchTextBox.BorderStyle = BorderStyle.FixedSingle;
            searchTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchTextBox.Location = new Point(0, 0);
            searchTextBox.Margin = new Padding(3, 4, 3, 4);
            searchTextBox.Multiline = true;
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "Search for products in inventory";
            searchTextBox.Size = new Size(297, 43);
            searchTextBox.TabIndex = 1;
            searchTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // searchButtonPanel
            // 
            searchButtonPanel.Controls.Add(searchButton);
            searchButtonPanel.Dock = DockStyle.Right;
            searchButtonPanel.Location = new Point(297, 0);
            searchButtonPanel.Margin = new Padding(3, 4, 3, 4);
            searchButtonPanel.Name = "searchButtonPanel";
            searchButtonPanel.Size = new Size(40, 44);
            searchButtonPanel.TabIndex = 0;
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            searchButton.BackColor = Color.White;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Image = (Image)resources.GetObject("searchButton.Image");
            searchButton.Location = new Point(0, 0);
            searchButton.Margin = new Padding(3, 4, 3, 4);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(40, 44);
            searchButton.TabIndex = 2;
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // refreshListButton
            // 
            refreshListButton.BackColor = Color.FromArgb(28, 44, 78);
            refreshListButton.FlatAppearance.BorderSize = 0;
            refreshListButton.FlatStyle = FlatStyle.Flat;
            refreshListButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            refreshListButton.ForeColor = Color.White;
            refreshListButton.Location = new Point(587, 1);
            refreshListButton.Margin = new Padding(5, 4, 5, 4);
            refreshListButton.Name = "refreshListButton";
            refreshListButton.Size = new Size(129, 45);
            refreshListButton.TabIndex = 109;
            refreshListButton.Text = "Refresh List";
            refreshListButton.UseVisualStyleBackColor = false;
            refreshListButton.Click += refreshListButton_Click;
            // 
            // InventoryUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(227, 211, 177);
            Controls.Add(refreshListButton);
            Controls.Add(searchInputPanel);
            Controls.Add(inventoryListView);
            Margin = new Padding(3, 4, 3, 4);
            Name = "InventoryUserControl";
            Size = new Size(1512, 492);
            Load += InventoryUserControl_Load;
            searchInputPanel.ResumeLayout(false);
            searchInputPanel.PerformLayout();
            searchButtonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView inventoryListView;
        private Panel searchInputPanel;
        private TextBox searchTextBox;
        private Panel searchButtonPanel;
        private Button searchButton;
        private ColumnHeader barcode;
        private ColumnHeader productName;
        private ColumnHeader description;
        private ColumnHeader productSize;
        private ColumnHeader sellingPrice;
        private ColumnHeader edit;
        private ColumnHeader delete;
        private ColumnHeader purchasePrice;
        private ColumnHeader vendorName;
        private ColumnHeader quantity;
        private Button refreshListButton;
    }
}
