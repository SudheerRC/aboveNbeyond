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
            this.inventoryListView = new System.Windows.Forms.ListView();
            this.searchInputPanel = new System.Windows.Forms.Panel();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButtonPanel = new System.Windows.Forms.Panel();
            this.searchButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.productName = new System.Windows.Forms.ColumnHeader();
            this.productSize = new System.Windows.Forms.ColumnHeader();
            this.description = new System.Windows.Forms.ColumnHeader();
            this.barcode = new System.Windows.Forms.ColumnHeader();
            this.sellingPrice = new System.Windows.Forms.ColumnHeader();
            this.edit = new System.Windows.Forms.ColumnHeader();
            this.delete = new System.Windows.Forms.ColumnHeader();
            this.searchInputPanel.SuspendLayout();
            this.searchButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // inventoryListView
            // 
            this.inventoryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.barcode,
            this.productName,
            this.description,
            this.productSize,
            this.sellingPrice,
            this.edit,
            this.delete});
            this.inventoryListView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.inventoryListView.Location = new System.Drawing.Point(0, 80);
            this.inventoryListView.Name = "inventoryListView";
            this.inventoryListView.Size = new System.Drawing.Size(1384, 704);
            this.inventoryListView.TabIndex = 0;
            this.inventoryListView.UseCompatibleStateImageBehavior = false;
            this.inventoryListView.View = System.Windows.Forms.View.List;
            // 
            // searchInputPanel
            // 
            this.searchInputPanel.Controls.Add(this.searchTextBox);
            this.searchInputPanel.Controls.Add(this.searchButtonPanel);
            this.searchInputPanel.Location = new System.Drawing.Point(111, 21);
            this.searchInputPanel.Name = "searchInputPanel";
            this.searchInputPanel.Size = new System.Drawing.Size(297, 35);
            this.searchInputPanel.TabIndex = 1;
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
            this.searchTextBox.PlaceholderText = "Search for products in inventory";
            this.searchTextBox.Size = new System.Drawing.Size(262, 35);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // searchButtonPanel
            // 
            this.searchButtonPanel.Controls.Add(this.button1);
            this.searchButtonPanel.Controls.Add(this.searchButton);
            this.searchButtonPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchButtonPanel.Location = new System.Drawing.Point(262, 0);
            this.searchButtonPanel.Name = "searchButtonPanel";
            this.searchButtonPanel.Size = new System.Drawing.Size(35, 35);
            this.searchButtonPanel.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.BackColor = System.Drawing.Color.White;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(0, 0);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(0, 0);
            this.searchButton.TabIndex = 0;
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // productName
            // 
            this.productName.DisplayIndex = 0;
            this.productName.Text = "Product Name";
            this.productName.Width = 220;
            // 
            // productSize
            // 
            this.productSize.DisplayIndex = 1;
            this.productSize.Text = "Product Size";
            this.productSize.Width = 220;
            // 
            // description
            // 
            this.description.Text = "Description";
            this.description.Width = 220;
            // 
            // barcode
            // 
            this.barcode.DisplayIndex = 3;
            this.barcode.Text = "Barcode";
            this.barcode.Width = 220;
            // 
            // sellingPrice
            // 
            this.sellingPrice.Text = "Selling Price";
            this.sellingPrice.Width = 220;
            // 
            // edit
            // 
            this.edit.Text = "";
            // 
            // delete
            // 
            this.delete.Text = "";
            // 
            // InventoryUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchInputPanel);
            this.Controls.Add(this.inventoryListView);
            this.Name = "InventoryUserControl";
            this.Size = new System.Drawing.Size(1384, 784);
            this.searchInputPanel.ResumeLayout(false);
            this.searchInputPanel.PerformLayout();
            this.searchButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView inventoryListView;
        private Panel searchInputPanel;
        private TextBox searchTextBox;
        private Panel searchButtonPanel;
        private Button button1;
        private Button searchButton;
        private ColumnHeader barcode;
        private ColumnHeader productName;
        private ColumnHeader description;
        private ColumnHeader productSize;
        private ColumnHeader sellingPrice;
        private ColumnHeader edit;
        private ColumnHeader delete;
    }
}
