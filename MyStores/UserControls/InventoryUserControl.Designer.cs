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
            searchButton = new Button();
            searchTextBox = new TextBox();
            refreshListButton = new Button();
            criteriaComboBox = new ComboBox();
            searchInputPanel.SuspendLayout();
            SuspendLayout();
            // 
            // inventoryListView
            // 
            inventoryListView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inventoryListView.BorderStyle = BorderStyle.None;
            inventoryListView.Columns.AddRange(new ColumnHeader[] { barcode, productName, description, quantity, productSize, sellingPrice, purchasePrice, vendorName, edit, delete });
            inventoryListView.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            inventoryListView.GridLines = true;
            inventoryListView.Location = new Point(11, 53);
            inventoryListView.Margin = new Padding(3, 4, 3, 4);
            inventoryListView.MultiSelect = false;
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
            searchInputPanel.Controls.Add(searchButton);
            searchInputPanel.Controls.Add(searchTextBox);
            searchInputPanel.Location = new Point(261, 4);
            searchInputPanel.Margin = new Padding(3, 4, 3, 4);
            searchInputPanel.Name = "searchInputPanel";
            searchInputPanel.Size = new Size(422, 46);
            searchInputPanel.TabIndex = 1;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.FromArgb(28, 44, 78);
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Image = (Image)resources.GetObject("searchButton.Image");
            searchButton.Location = new Point(378, -4);
            searchButton.Margin = new Padding(3, 4, 3, 4);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(42, 48);
            searchButton.TabIndex = 2;
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.BorderStyle = BorderStyle.FixedSingle;
            searchTextBox.Dock = DockStyle.Left;
            searchTextBox.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            searchTextBox.Location = new Point(0, 0);
            searchTextBox.Margin = new Padding(3, 4, 3, 4);
            searchTextBox.Multiline = true;
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "Search for products in inventory";
            searchTextBox.Size = new Size(379, 44);
            searchTextBox.TabIndex = 1;
            // 
            // refreshListButton
            // 
            refreshListButton.BackColor = Color.FromArgb(28, 44, 78);
            refreshListButton.FlatStyle = FlatStyle.Flat;
            refreshListButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            refreshListButton.ForeColor = SystemColors.ControlText;
            refreshListButton.Image = (Image)resources.GetObject("refreshListButton.Image");
            refreshListButton.Location = new Point(708, 4);
            refreshListButton.Margin = new Padding(5, 4, 5, 4);
            refreshListButton.Name = "refreshListButton";
            refreshListButton.Size = new Size(43, 42);
            refreshListButton.TabIndex = 109;
            refreshListButton.UseVisualStyleBackColor = false;
            refreshListButton.Click += refreshListButton_Click;
            // 
            // criteriaComboBox
            // 
            criteriaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            criteriaComboBox.FlatStyle = FlatStyle.Flat;
            criteriaComboBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            criteriaComboBox.FormattingEnabled = true;
            criteriaComboBox.Items.AddRange(new object[] { "Product Name", "Description", "Barcode", "Product Size", "Vendor Name", "Selling Price", "Purchase Price" });
            criteriaComboBox.Location = new Point(14, 12);
            criteriaComboBox.Margin = new Padding(2, 2, 2, 2);
            criteriaComboBox.Name = "criteriaComboBox";
            criteriaComboBox.Size = new Size(235, 36);
            criteriaComboBox.TabIndex = 110;
            criteriaComboBox.SelectedValueChanged += criteriaComboBox_SelectedValueChanged;
            // 
            // InventoryUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(227, 211, 177);
            Controls.Add(criteriaComboBox);
            Controls.Add(refreshListButton);
            Controls.Add(searchInputPanel);
            Controls.Add(inventoryListView);
            Margin = new Padding(3, 4, 3, 4);
            Name = "InventoryUserControl";
            Size = new Size(1512, 492);
            Load += InventoryUserControl_Load;
            searchInputPanel.ResumeLayout(false);
            searchInputPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView inventoryListView;
        private Panel searchInputPanel;
        private TextBox searchTextBox;
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
        private ComboBox criteriaComboBox;
    }
}
