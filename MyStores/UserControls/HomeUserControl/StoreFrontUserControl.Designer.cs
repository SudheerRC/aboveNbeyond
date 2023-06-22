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
            this.AddVendorButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.inventoryButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.exitStoreButton = new System.Windows.Forms.Button();
            this.storeExpandedPanel = new System.Windows.Forms.Panel();
            this.mainAddProductToStoreUserControl = new MyStores.UserControls.AddProductToStoreUserControl();
            this.mainAddManagerUserControl = new MyStores.UserControls.AddManagerUserControl();
            this.mainInventoryUserControl = new MyStores.UserControls.InventoryUserControl();
            this.mainAddVendorToStoreUserControl = new MyStores.UserControls.AddVendorToStoreUserControl();
            this.backButtonPanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.addManagerButton = new System.Windows.Forms.Button();
            this.storeNameLabel = new System.Windows.Forms.Label();
            this.storeButtonsPanel = new System.Windows.Forms.Panel();
            this.storeExpandedPanel.SuspendLayout();
            this.backButtonPanel.SuspendLayout();
            this.storeButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddVendorButton
            // 
            this.AddVendorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.AddVendorButton.FlatAppearance.BorderSize = 0;
            this.AddVendorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddVendorButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddVendorButton.ForeColor = System.Drawing.Color.White;
            this.AddVendorButton.Image = ((System.Drawing.Image)(resources.GetObject("AddVendorButton.Image")));
            this.AddVendorButton.Location = new System.Drawing.Point(23, 8);
            this.AddVendorButton.Name = "AddVendorButton";
            this.AddVendorButton.Size = new System.Drawing.Size(140, 150);
            this.AddVendorButton.TabIndex = 2;
            this.AddVendorButton.Text = "Add Vendor";
            this.AddVendorButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddVendorButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AddVendorButton.UseVisualStyleBackColor = false;
            this.AddVendorButton.Click += new System.EventHandler(this.AddVendorButton_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.addProductButton.FlatAppearance.BorderSize = 0;
            this.addProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addProductButton.ForeColor = System.Drawing.Color.White;
            this.addProductButton.Image = ((System.Drawing.Image)(resources.GetObject("addProductButton.Image")));
            this.addProductButton.Location = new System.Drawing.Point(157, 190);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(140, 150);
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
            this.inventoryButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inventoryButton.ForeColor = System.Drawing.Color.White;
            this.inventoryButton.Image = ((System.Drawing.Image)(resources.GetObject("inventoryButton.Image")));
            this.inventoryButton.Location = new System.Drawing.Point(296, 10);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Size = new System.Drawing.Size(140, 150);
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
            this.orderButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.orderButton.ForeColor = System.Drawing.Color.White;
            this.orderButton.Image = ((System.Drawing.Image)(resources.GetObject("orderButton.Image")));
            this.orderButton.Location = new System.Drawing.Point(578, 8);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(140, 150);
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
            this.exitStoreButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitStoreButton.ForeColor = System.Drawing.Color.White;
            this.exitStoreButton.Image = ((System.Drawing.Image)(resources.GetObject("exitStoreButton.Image")));
            this.exitStoreButton.Location = new System.Drawing.Point(643, 320);
            this.exitStoreButton.Name = "exitStoreButton";
            this.exitStoreButton.Size = new System.Drawing.Size(93, 69);
            this.exitStoreButton.TabIndex = 7;
            this.exitStoreButton.Text = "Exit Store";
            this.exitStoreButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exitStoreButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.exitStoreButton.UseVisualStyleBackColor = false;
            this.exitStoreButton.Click += new System.EventHandler(this.exitStoreButton_Click);
            // 
            // storeExpandedPanel
            // 
            this.storeExpandedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.storeExpandedPanel.Controls.Add(this.mainAddProductToStoreUserControl);
            this.storeExpandedPanel.Controls.Add(this.mainAddManagerUserControl);
            this.storeExpandedPanel.Controls.Add(this.mainInventoryUserControl);
            this.storeExpandedPanel.Controls.Add(this.mainAddVendorToStoreUserControl);
            this.storeExpandedPanel.Location = new System.Drawing.Point(61, 44);
            this.storeExpandedPanel.Name = "storeExpandedPanel";
            this.storeExpandedPanel.Size = new System.Drawing.Size(2023, 582);
            this.storeExpandedPanel.TabIndex = 8;
            this.storeExpandedPanel.Visible = false;
            // 
            // mainAddProductToStoreUserControl
            // 
            this.mainAddProductToStoreUserControl.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.mainAddProductToStoreUserControl.Location = new System.Drawing.Point(0, 0);
            this.mainAddProductToStoreUserControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainAddProductToStoreUserControl.Name = "mainAddProductToStoreUserControl";
            this.mainAddProductToStoreUserControl.Size = new System.Drawing.Size(639, 418);
            this.mainAddProductToStoreUserControl.TabIndex = 10;
            // 
            // mainAddManagerUserControl
            // 
            this.mainAddManagerUserControl.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.mainAddManagerUserControl.Location = new System.Drawing.Point(132, 1);
            this.mainAddManagerUserControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainAddManagerUserControl.Name = "mainAddManagerUserControl";
            this.mainAddManagerUserControl.Size = new System.Drawing.Size(458, 189);
            this.mainAddManagerUserControl.TabIndex = 8;
            // 
            // mainInventoryUserControl
            // 
            this.mainInventoryUserControl.AutoScroll = true;
            this.mainInventoryUserControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.mainInventoryUserControl.Location = new System.Drawing.Point(0, 1);
            this.mainInventoryUserControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainInventoryUserControl.Name = "mainInventoryUserControl";
            this.mainInventoryUserControl.Size = new System.Drawing.Size(1983, 579);
            this.mainInventoryUserControl.TabIndex = 6;
            // 
            // mainAddVendorToStoreUserControl
            // 
            this.mainAddVendorToStoreUserControl.AutoScroll = true;
            this.mainAddVendorToStoreUserControl.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.mainAddVendorToStoreUserControl.Location = new System.Drawing.Point(0, 0);
            this.mainAddVendorToStoreUserControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainAddVendorToStoreUserControl.Name = "mainAddVendorToStoreUserControl";
            this.mainAddVendorToStoreUserControl.Size = new System.Drawing.Size(681, 617);
            this.mainAddVendorToStoreUserControl.TabIndex = 9;
            // 
            // backButtonPanel
            // 
            this.backButtonPanel.Controls.Add(this.backButton);
            this.backButtonPanel.Location = new System.Drawing.Point(12, 44);
            this.backButtonPanel.Name = "backButtonPanel";
            this.backButtonPanel.Size = new System.Drawing.Size(44, 36);
            this.backButtonPanel.TabIndex = 5;
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.backButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backButton.Location = new System.Drawing.Point(-10, 0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(54, 36);
            this.backButton.TabIndex = 3;
            this.backButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // addManagerButton
            // 
            this.addManagerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.addManagerButton.FlatAppearance.BorderSize = 0;
            this.addManagerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addManagerButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addManagerButton.ForeColor = System.Drawing.Color.White;
            this.addManagerButton.Image = ((System.Drawing.Image)(resources.GetObject("addManagerButton.Image")));
            this.addManagerButton.Location = new System.Drawing.Point(438, 190);
            this.addManagerButton.Name = "addManagerButton";
            this.addManagerButton.Size = new System.Drawing.Size(140, 150);
            this.addManagerButton.TabIndex = 9;
            this.addManagerButton.Text = "Add Manager";
            this.addManagerButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addManagerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addManagerButton.UseVisualStyleBackColor = false;
            this.addManagerButton.Click += new System.EventHandler(this.MainAddManagerButton_Click);
            // 
            // storeNameLabel
            // 
            this.storeNameLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.storeNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.storeNameLabel.Location = new System.Drawing.Point(3, 0);
            this.storeNameLabel.Name = "storeNameLabel";
            this.storeNameLabel.Size = new System.Drawing.Size(739, 34);
            this.storeNameLabel.TabIndex = 1;
            this.storeNameLabel.Text = "Name";
            this.storeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // storeButtonsPanel
            // 
            this.storeButtonsPanel.Controls.Add(this.AddVendorButton);
            this.storeButtonsPanel.Controls.Add(this.orderButton);
            this.storeButtonsPanel.Controls.Add(this.addManagerButton);
            this.storeButtonsPanel.Controls.Add(this.inventoryButton);
            this.storeButtonsPanel.Controls.Add(this.exitStoreButton);
            this.storeButtonsPanel.Controls.Add(this.addProductButton);
            this.storeButtonsPanel.Location = new System.Drawing.Point(3, 36);
            this.storeButtonsPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.storeButtonsPanel.Name = "storeButtonsPanel";
            this.storeButtonsPanel.Size = new System.Drawing.Size(739, 392);
            this.storeButtonsPanel.TabIndex = 10;
            // 
            // StoreFrontUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.Controls.Add(this.storeExpandedPanel);
            this.Controls.Add(this.storeButtonsPanel);
            this.Controls.Add(this.storeNameLabel);
            this.Controls.Add(this.backButtonPanel);
            this.Name = "StoreFrontUserControl";
            this.Size = new System.Drawing.Size(746, 631);
            this.Load += new System.EventHandler(this.StoreFrontUserControl_Load);
            this.storeExpandedPanel.ResumeLayout(false);
            this.backButtonPanel.ResumeLayout(false);
            this.backButtonPanel.PerformLayout();
            this.storeButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button AddVendorButton;
        private Button addProductButton;
        private Button inventoryButton;
        private Button orderButton;
        private Button exitStoreButton;
        private Panel storeExpandedPanel;
        private Panel backButtonPanel;
        private Button backButton;
        private InventoryUserControl mainInventoryUserControl;
        private AddManagerUserControl mainAddManagerUserControl;
        private Button addManagerButton;
        private AddVendorToStoreUserControl mainAddVendorToStoreUserControl;
        private AddProductToStoreUserControl mainAddProductToStoreUserControl;
        private Label storeNameLabel;
        private Panel storeButtonsPanel;
    }
}
