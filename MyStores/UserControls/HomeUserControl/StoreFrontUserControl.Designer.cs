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
            highlightTableLayoutPanel = new TableLayoutPanel();
            AddVendorButton = new Button();
            addProductButton = new Button();
            inventoryButton = new Button();
            orderButton = new Button();
            exitStoreButton = new Button();
            storeExpandedPanel = new Panel();
            mainAddManagerUserControl = new AddManagerUserControl();
            mainAddVendorUserControl = new AddVendorUserControl();
            backButtonPanel = new Panel();
            backButton = new Button();
            mainAddProductUserControl = new AddProductUserControl();
            mainInventoryUserControl = new InventoryUserControl();
            addManagerButton = new Button();
            storeExpandedPanel.SuspendLayout();
            backButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // highlightTableLayoutPanel
            // 
            highlightTableLayoutPanel.ColumnCount = 5;
            highlightTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            highlightTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            highlightTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 321F));
            highlightTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 213F));
            highlightTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 217F));
            highlightTableLayoutPanel.Dock = DockStyle.Top;
            highlightTableLayoutPanel.Location = new Point(0, 0);
            highlightTableLayoutPanel.Name = "highlightTableLayoutPanel";
            highlightTableLayoutPanel.RowCount = 1;
            highlightTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            highlightTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            highlightTableLayoutPanel.Size = new Size(1390, 107);
            highlightTableLayoutPanel.TabIndex = 1;
            // 
            // AddVendorButton
            // 
            AddVendorButton.BackColor = Color.FromArgb(28, 44, 78);
            AddVendorButton.FlatAppearance.BorderSize = 0;
            AddVendorButton.FlatStyle = FlatStyle.Flat;
            AddVendorButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            AddVendorButton.ForeColor = Color.White;
            AddVendorButton.Image = (Image)resources.GetObject("AddVendorButton.Image");
            AddVendorButton.Location = new Point(183, 256);
            AddVendorButton.Name = "AddVendorButton";
            AddVendorButton.Size = new Size(160, 159);
            AddVendorButton.TabIndex = 2;
            AddVendorButton.Text = "Add Vendor";
            AddVendorButton.TextAlign = ContentAlignment.BottomCenter;
            AddVendorButton.TextImageRelation = TextImageRelation.ImageAboveText;
            AddVendorButton.UseVisualStyleBackColor = false;
            AddVendorButton.Click += AddVendorButton_Click;
            // 
            // addProductButton
            // 
            addProductButton.BackColor = Color.FromArgb(28, 44, 78);
            addProductButton.FlatAppearance.BorderSize = 0;
            addProductButton.FlatStyle = FlatStyle.Flat;
            addProductButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            addProductButton.ForeColor = Color.White;
            addProductButton.Image = (Image)resources.GetObject("addProductButton.Image");
            addProductButton.Location = new Point(372, 525);
            addProductButton.Name = "addProductButton";
            addProductButton.Size = new Size(160, 159);
            addProductButton.TabIndex = 4;
            addProductButton.Text = "Add Product";
            addProductButton.TextAlign = ContentAlignment.BottomCenter;
            addProductButton.TextImageRelation = TextImageRelation.ImageAboveText;
            addProductButton.UseVisualStyleBackColor = false;
            addProductButton.Click += addProductButton_Click;
            // 
            // inventoryButton
            // 
            inventoryButton.BackColor = Color.FromArgb(28, 44, 78);
            inventoryButton.FlatAppearance.BorderSize = 0;
            inventoryButton.FlatStyle = FlatStyle.Flat;
            inventoryButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            inventoryButton.ForeColor = Color.White;
            inventoryButton.Image = (Image)resources.GetObject("inventoryButton.Image");
            inventoryButton.Location = new Point(555, 256);
            inventoryButton.Name = "inventoryButton";
            inventoryButton.Size = new Size(160, 159);
            inventoryButton.TabIndex = 5;
            inventoryButton.Text = "Inventory";
            inventoryButton.TextAlign = ContentAlignment.BottomCenter;
            inventoryButton.TextImageRelation = TextImageRelation.ImageAboveText;
            inventoryButton.UseVisualStyleBackColor = false;
            inventoryButton.Click += inventoryButton_Click;
            // 
            // orderButton
            // 
            orderButton.BackColor = Color.FromArgb(28, 44, 78);
            orderButton.Enabled = false;
            orderButton.FlatAppearance.BorderSize = 0;
            orderButton.FlatStyle = FlatStyle.Flat;
            orderButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            orderButton.ForeColor = Color.White;
            orderButton.Image = (Image)resources.GetObject("orderButton.Image");
            orderButton.Location = new Point(952, 256);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(160, 159);
            orderButton.TabIndex = 6;
            orderButton.Text = "Order";
            orderButton.TextAlign = ContentAlignment.BottomCenter;
            orderButton.TextImageRelation = TextImageRelation.ImageAboveText;
            orderButton.UseVisualStyleBackColor = false;
            // 
            // exitStoreButton
            // 
            exitStoreButton.BackColor = Color.FromArgb(28, 44, 78);
            exitStoreButton.FlatAppearance.BorderSize = 0;
            exitStoreButton.FlatStyle = FlatStyle.Flat;
            exitStoreButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            exitStoreButton.ForeColor = Color.White;
            exitStoreButton.Image = (Image)resources.GetObject("exitStoreButton.Image");
            exitStoreButton.Location = new Point(1215, 729);
            exitStoreButton.Name = "exitStoreButton";
            exitStoreButton.Size = new Size(160, 159);
            exitStoreButton.TabIndex = 7;
            exitStoreButton.Text = "Exit Store";
            exitStoreButton.TextAlign = ContentAlignment.BottomCenter;
            exitStoreButton.TextImageRelation = TextImageRelation.ImageAboveText;
            exitStoreButton.UseVisualStyleBackColor = false;
            exitStoreButton.Click += exitStoreButton_Click;
            // 
            // storeExpandedPanel
            // 
            storeExpandedPanel.BackColor = Color.White;
            storeExpandedPanel.Controls.Add(mainAddManagerUserControl);
            storeExpandedPanel.Controls.Add(mainAddVendorUserControl);
            storeExpandedPanel.Controls.Add(backButtonPanel);
            storeExpandedPanel.Controls.Add(mainAddProductUserControl);
            storeExpandedPanel.Controls.Add(mainInventoryUserControl);
            storeExpandedPanel.Location = new Point(3, 113);
            storeExpandedPanel.Name = "storeExpandedPanel";
            storeExpandedPanel.Size = new Size(1384, 784);
            storeExpandedPanel.TabIndex = 8;
            storeExpandedPanel.Visible = false;
            // 
            // mainAddManagerUserControl
            // 
            mainAddManagerUserControl.BackColor = Color.BlanchedAlmond;
            mainAddManagerUserControl.Location = new Point(535, 255);
            mainAddManagerUserControl.Name = "mainAddManagerUserControl";
            mainAddManagerUserControl.Size = new Size(367, 169);
            mainAddManagerUserControl.TabIndex = 8;
            // 
            // mainAddVendorUserControl
            // 
            mainAddVendorUserControl.BackColor = Color.BlanchedAlmond;
            mainAddVendorUserControl.Location = new Point(535, 143);
            mainAddVendorUserControl.Name = "mainAddVendorUserControl";
            mainAddVendorUserControl.Size = new Size(354, 481);
            mainAddVendorUserControl.TabIndex = 7;
            // 
            // backButtonPanel
            // 
            backButtonPanel.Controls.Add(backButton);
            backButtonPanel.Location = new Point(26, 25);
            backButtonPanel.Name = "backButtonPanel";
            backButtonPanel.Size = new Size(43, 45);
            backButtonPanel.TabIndex = 5;
            // 
            // backButton
            // 
            backButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            backButton.BackColor = Color.White;
            backButton.Dock = DockStyle.Right;
            backButton.FlatAppearance.BorderColor = Color.FromArgb(28, 44, 78);
            backButton.FlatAppearance.BorderSize = 0;
            backButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(227, 211, 177);
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            backButton.ForeColor = Color.FromArgb(252, 251, 255);
            backButton.Image = (Image)resources.GetObject("backButton.Image");
            backButton.ImageAlign = ContentAlignment.MiddleLeft;
            backButton.Location = new Point(-7, 0);
            backButton.Name = "backButton";
            backButton.Size = new Size(50, 45);
            backButton.TabIndex = 3;
            backButton.TextAlign = ContentAlignment.BottomCenter;
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // mainAddProductUserControl
            // 
            mainAddProductUserControl.BackColor = Color.Bisque;
            mainAddProductUserControl.Location = new Point(535, 76);
            mainAddProductUserControl.Name = "mainAddProductUserControl";
            mainAddProductUserControl.Size = new Size(359, 627);
            mainAddProductUserControl.TabIndex = 0;
            // 
            // mainInventoryUserControl
            // 
            mainInventoryUserControl.Location = new Point(2, 0);
            mainInventoryUserControl.Name = "mainInventoryUserControl";
            mainInventoryUserControl.Size = new Size(1384, 784);
            mainInventoryUserControl.TabIndex = 6;
            // 
            // addManagerButton
            // 
            addManagerButton.BackColor = Color.FromArgb(28, 44, 78);
            addManagerButton.FlatAppearance.BorderSize = 0;
            addManagerButton.FlatStyle = FlatStyle.Flat;
            addManagerButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            addManagerButton.ForeColor = Color.White;
            addManagerButton.Image = (Image)resources.GetObject("addManagerButton.Image");
            addManagerButton.Location = new Point(783, 525);
            addManagerButton.Name = "addManagerButton";
            addManagerButton.Size = new Size(160, 159);
            addManagerButton.TabIndex = 9;
            addManagerButton.Text = "Add Manager";
            addManagerButton.TextAlign = ContentAlignment.BottomCenter;
            addManagerButton.TextImageRelation = TextImageRelation.ImageAboveText;
            addManagerButton.UseVisualStyleBackColor = false;
            addManagerButton.Click += MainAddManagerButton_Click;
            // 
            // StoreFrontUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 211, 177);
            Controls.Add(storeExpandedPanel);
            Controls.Add(exitStoreButton);
            Controls.Add(orderButton);
            Controls.Add(inventoryButton);
            Controls.Add(addProductButton);
            Controls.Add(AddVendorButton);
            Controls.Add(highlightTableLayoutPanel);
            Controls.Add(addManagerButton);
            Name = "StoreFrontUserControl";
            Size = new Size(1390, 900);
            storeExpandedPanel.ResumeLayout(false);
            backButtonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel highlightTableLayoutPanel;
        private Button AddVendorButton;
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
        private AddManagerUserControl mainAddManagerUserControl;
        private Button addManagerButton;
    }
}
