namespace MyStores.UserControls.HomeUserControl
{
    partial class StoreFrontUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreFrontUserControl));
            this.highlightTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AddVendorButton = new System.Windows.Forms.Button();
            this.salesButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.inventoryButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.exitStoreButton = new System.Windows.Forms.Button();
            this.storeExpandedPanel = new System.Windows.Forms.Panel();
            this.backButtonPanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.mainAddProductUserControl = new MyStores.UserControls.AddProductUserControl();
            this.mainInventoryUserControl = new MyStores.UserControls.InventoryUserControl();
            this.mainAddVendorUserControl = new MyStores.UserControls.AddVendorUserControl();
            this.storeExpandedPanel.SuspendLayout();
            this.backButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // highlightTableLayoutPanel
            // 
            this.highlightTableLayoutPanel.ColumnCount = 5;
            this.highlightTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.highlightTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.highlightTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 321F));
            this.highlightTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.highlightTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 217F));
            this.highlightTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.highlightTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.highlightTableLayoutPanel.Name = "highlightTableLayoutPanel";
            this.highlightTableLayoutPanel.RowCount = 1;
            this.highlightTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.highlightTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.highlightTableLayoutPanel.Size = new System.Drawing.Size(1390, 107);
            this.highlightTableLayoutPanel.TabIndex = 1;
            // 
            // AddVendorButton
            // 
            this.AddVendorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.AddVendorButton.FlatAppearance.BorderSize = 0;
            this.AddVendorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddVendorButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddVendorButton.ForeColor = System.Drawing.Color.White;
            this.AddVendorButton.Image = ((System.Drawing.Image)(resources.GetObject("AddVendorButton.Image")));
            this.AddVendorButton.Location = new System.Drawing.Point(183, 256);
            this.AddVendorButton.Name = "AddVendorButton";
            this.AddVendorButton.Size = new System.Drawing.Size(160, 159);
            this.AddVendorButton.TabIndex = 2;
            this.AddVendorButton.Text = "Add Vendor";
            this.AddVendorButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddVendorButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AddVendorButton.UseVisualStyleBackColor = false;
            this.AddVendorButton.Click += new System.EventHandler(this.AddVendorButton_Click);
            // 
            // salesButton
            // 
            this.salesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.salesButton.Enabled = false;
            this.salesButton.FlatAppearance.BorderSize = 0;
            this.salesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.salesButton.ForeColor = System.Drawing.Color.White;
            this.salesButton.Image = ((System.Drawing.Image)(resources.GetObject("salesButton.Image")));
            this.salesButton.Location = new System.Drawing.Point(754, 525);
            this.salesButton.Name = "salesButton";
            this.salesButton.Size = new System.Drawing.Size(160, 159);
            this.salesButton.TabIndex = 3;
            this.salesButton.Text = "Sales";
            this.salesButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.salesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.salesButton.UseVisualStyleBackColor = false;
            // 
            // addProductButton
            // 
            this.addProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.addProductButton.FlatAppearance.BorderSize = 0;
            this.addProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addProductButton.ForeColor = System.Drawing.Color.White;
            this.addProductButton.Image = ((System.Drawing.Image)(resources.GetObject("addProductButton.Image")));
            this.addProductButton.Location = new System.Drawing.Point(372, 525);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(160, 159);
            this.addProductButton.TabIndex = 4;
            this.addProductButton.Text = "Add Product";
            this.addProductButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addProductButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addProductButton.UseVisualStyleBackColor = false;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // inventoryButton
            // 
            this.inventoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.inventoryButton.FlatAppearance.BorderSize = 0;
            this.inventoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventoryButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inventoryButton.ForeColor = System.Drawing.Color.White;
            this.inventoryButton.Image = ((System.Drawing.Image)(resources.GetObject("inventoryButton.Image")));
            this.inventoryButton.Location = new System.Drawing.Point(555, 256);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Size = new System.Drawing.Size(160, 159);
            this.inventoryButton.TabIndex = 5;
            this.inventoryButton.Text = "Inventory";
            this.inventoryButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.inventoryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.inventoryButton.UseVisualStyleBackColor = false;
            this.inventoryButton.Click += new System.EventHandler(this.inventoryButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.orderButton.Enabled = false;
            this.orderButton.FlatAppearance.BorderSize = 0;
            this.orderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.orderButton.ForeColor = System.Drawing.Color.White;
            this.orderButton.Image = ((System.Drawing.Image)(resources.GetObject("orderButton.Image")));
            this.orderButton.Location = new System.Drawing.Point(952, 256);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(160, 159);
            this.orderButton.TabIndex = 6;
            this.orderButton.Text = "Order";
            this.orderButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.orderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.orderButton.UseVisualStyleBackColor = false;
            // 
            // exitStoreButton
            // 
            this.exitStoreButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.exitStoreButton.FlatAppearance.BorderSize = 0;
            this.exitStoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitStoreButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitStoreButton.ForeColor = System.Drawing.Color.White;
            this.exitStoreButton.Image = ((System.Drawing.Image)(resources.GetObject("exitStoreButton.Image")));
            this.exitStoreButton.Location = new System.Drawing.Point(1215, 729);
            this.exitStoreButton.Name = "exitStoreButton";
            this.exitStoreButton.Size = new System.Drawing.Size(160, 159);
            this.exitStoreButton.TabIndex = 7;
            this.exitStoreButton.Text = "Exit Store";
            this.exitStoreButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exitStoreButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.exitStoreButton.UseVisualStyleBackColor = false;
            this.exitStoreButton.Click += new System.EventHandler(this.exitStoreButton_Click);
            // 
            // storeExpandedPanel
            // 
            this.storeExpandedPanel.BackColor = System.Drawing.Color.White;
            this.storeExpandedPanel.Controls.Add(this.mainAddVendorUserControl);
            this.storeExpandedPanel.Controls.Add(this.backButtonPanel);
            this.storeExpandedPanel.Controls.Add(this.mainAddProductUserControl);
            this.storeExpandedPanel.Controls.Add(this.mainInventoryUserControl);
            this.storeExpandedPanel.Location = new System.Drawing.Point(3, 113);
            this.storeExpandedPanel.Name = "storeExpandedPanel";
            this.storeExpandedPanel.Size = new System.Drawing.Size(1384, 784);
            this.storeExpandedPanel.TabIndex = 8;
            this.storeExpandedPanel.Visible = false;
            // 
            // backButtonPanel
            // 
            this.backButtonPanel.Controls.Add(this.backButton);
            this.backButtonPanel.Location = new System.Drawing.Point(26, 25);
            this.backButtonPanel.Name = "backButtonPanel";
            this.backButtonPanel.Size = new System.Drawing.Size(43, 45);
            this.backButtonPanel.TabIndex = 5;
            // 
            // backButton
            // 
            this.backButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backButton.BackColor = System.Drawing.Color.White;
            this.backButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backButton.Location = new System.Drawing.Point(-7, 0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(50, 45);
            this.backButton.TabIndex = 3;
            this.backButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // mainAddProductUserControl
            // 
            this.mainAddProductUserControl.BackColor = System.Drawing.Color.Bisque;
            this.mainAddProductUserControl.Location = new System.Drawing.Point(535, 76);
            this.mainAddProductUserControl.Name = "mainAddProductUserControl";
            this.mainAddProductUserControl.Size = new System.Drawing.Size(359, 627);
            this.mainAddProductUserControl.TabIndex = 0;
            // 
            // mainInventoryUserControl
            // 
            this.mainInventoryUserControl.Location = new System.Drawing.Point(2, 0);
            this.mainInventoryUserControl.Name = "mainInventoryUserControl";
            this.mainInventoryUserControl.Size = new System.Drawing.Size(1384, 784);
            this.mainInventoryUserControl.TabIndex = 6;
            // 
            // mainAddVendorUserControl
            // 
            this.mainAddVendorUserControl.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.mainAddVendorUserControl.Location = new System.Drawing.Point(535, 143);
            this.mainAddVendorUserControl.Name = "mainAddVendorUserControl";
            this.mainAddVendorUserControl.Size = new System.Drawing.Size(354, 481);
            this.mainAddVendorUserControl.TabIndex = 7;
            // 
            // StoreFrontUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.Controls.Add(this.exitStoreButton);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.inventoryButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.salesButton);
            this.Controls.Add(this.AddVendorButton);
            this.Controls.Add(this.highlightTableLayoutPanel);
            this.Controls.Add(this.storeExpandedPanel);
            this.Name = "StoreFrontUserControl";
            this.Size = new System.Drawing.Size(1390, 900);
            this.storeExpandedPanel.ResumeLayout(false);
            this.backButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel highlightTableLayoutPanel;
        private Button AddVendorButton;
        private Button salesButton;
        private Button addProductButton;
        private Button inventoryButton;
        private Button orderButton;
        private Button exitStoreButton;
        private Panel storeExpandedPanel;
        private Panel backButtonPanel;
        private Button backButton;
        private AddProductUserControl mainAddProductUserControl;
        private InventoryUserControl mainInventoryUserControl;
        private AddVendorUserControl mainAddVendorUserControl;
    }
}
