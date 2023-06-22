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
            AddVendorButton = new Button();
            addProductButton = new Button();
            inventoryButton = new Button();
            orderButton = new Button();
            exitStoreButton = new Button();
            storeExpandedPanel = new Panel();
            mainAddVendorToStoreUserControl = new AddVendorToStoreUserControl();
            mainAddProductToStoreUserControl = new AddProductToStoreUserControl();
            mainAddManagerUserControl = new AddManagerUserControl();
            mainInventoryUserControl = new InventoryUserControl();
            backButtonPanel = new Panel();
            backButton = new Button();
            addManagerButton = new Button();
            storeNameLabel = new Label();
            storeButtonsPanel = new Panel();
            storeExpandedPanel.SuspendLayout();
            backButtonPanel.SuspendLayout();
            storeButtonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // AddVendorButton
            // 
            AddVendorButton.BackColor = Color.FromArgb(28, 44, 78);
            AddVendorButton.FlatAppearance.BorderSize = 0;
            AddVendorButton.FlatStyle = FlatStyle.Flat;
            AddVendorButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            AddVendorButton.ForeColor = Color.White;
            AddVendorButton.Image = (Image)resources.GetObject("AddVendorButton.Image");
            AddVendorButton.Location = new Point(26, 11);
            AddVendorButton.Margin = new Padding(3, 4, 3, 4);
            AddVendorButton.Name = "AddVendorButton";
            AddVendorButton.Size = new Size(130, 150);
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
            addProductButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            addProductButton.ForeColor = Color.White;
            addProductButton.Image = (Image)resources.GetObject("addProductButton.Image");
            addProductButton.Location = new Point(178, 182);
            addProductButton.Margin = new Padding(3, 4, 3, 4);
            addProductButton.Name = "addProductButton";
            addProductButton.Size = new Size(140, 150);
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
            inventoryButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            inventoryButton.ForeColor = Color.White;
            inventoryButton.Image = (Image)resources.GetObject("inventoryButton.Image");
            inventoryButton.Location = new Point(338, 14);
            inventoryButton.Margin = new Padding(3, 4, 3, 4);
            inventoryButton.Name = "inventoryButton";
            inventoryButton.Size = new Size(140, 150);
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
            orderButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            orderButton.ForeColor = Color.White;
            orderButton.Image = (Image)resources.GetObject("orderButton.Image");
            orderButton.Location = new Point(660, 11);
            orderButton.Margin = new Padding(3, 4, 3, 4);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(140, 150);
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
            exitStoreButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            exitStoreButton.ForeColor = Color.White;
            exitStoreButton.Image = (Image)resources.GetObject("exitStoreButton.Image");
            exitStoreButton.Location = new Point(338, 353);
            exitStoreButton.Margin = new Padding(3, 4, 3, 4);
            exitStoreButton.Name = "exitStoreButton";
            exitStoreButton.Size = new Size(140, 150);
            exitStoreButton.TabIndex = 7;
            exitStoreButton.Text = "Exit Store";
            exitStoreButton.TextAlign = ContentAlignment.BottomCenter;
            exitStoreButton.TextImageRelation = TextImageRelation.ImageAboveText;
            exitStoreButton.UseVisualStyleBackColor = false;
            exitStoreButton.Click += exitStoreButton_Click;
            // 
            // storeExpandedPanel
            // 
            storeExpandedPanel.BackColor = Color.FromArgb(227, 211, 177);
            storeExpandedPanel.Controls.Add(mainAddProductToStoreUserControl);
            storeExpandedPanel.Controls.Add(mainAddManagerUserControl);
            storeExpandedPanel.Controls.Add(mainInventoryUserControl);
            storeExpandedPanel.Controls.Add(mainAddVendorToStoreUserControl);
            storeExpandedPanel.Location = new Point(70, 58);
            storeExpandedPanel.Margin = new Padding(3, 4, 3, 4);
            storeExpandedPanel.Name = "storeExpandedPanel";
            storeExpandedPanel.Size = new Size(778, 776);
            storeExpandedPanel.TabIndex = 8;
            storeExpandedPanel.Visible = false;
            // 
            // mainAddVendorToStoreUserControl
            // 
            mainAddVendorToStoreUserControl.BackColor = Color.BlanchedAlmond;
            mainAddVendorToStoreUserControl.Location = new Point(0, 0);
            mainAddVendorToStoreUserControl.Margin = new Padding(3, 5, 3, 5);
            mainAddVendorToStoreUserControl.Name = "mainAddVendorToStoreUserControl";
            mainAddVendorToStoreUserControl.Size = new Size(778, 823);
            mainAddVendorToStoreUserControl.TabIndex = 9;
            // 
            // mainAddProductToStoreUserControl
            // 
            mainAddProductToStoreUserControl.BackColor = Color.BlanchedAlmond;
            mainAddProductToStoreUserControl.Location = new Point(0, 0);
            mainAddProductToStoreUserControl.Margin = new Padding(3, 5, 3, 5);
            mainAddProductToStoreUserControl.Name = "mainAddProductToStoreUserControl";
            mainAddProductToStoreUserControl.Size = new Size(730, 557);
            mainAddProductToStoreUserControl.TabIndex = 10;
            // 
            // mainAddManagerUserControl
            // 
            mainAddManagerUserControl.BackColor = Color.BlanchedAlmond;
            mainAddManagerUserControl.Location = new Point(151, 1);
            mainAddManagerUserControl.Margin = new Padding(3, 5, 3, 5);
            mainAddManagerUserControl.Name = "mainAddManagerUserControl";
            mainAddManagerUserControl.Size = new Size(524, 167);
            mainAddManagerUserControl.TabIndex = 8;
            // 
            // mainInventoryUserControl
            // 
            mainInventoryUserControl.Location = new Point(0, 1);
            mainInventoryUserControl.Margin = new Padding(3, 5, 3, 5);
            mainInventoryUserControl.Name = "mainInventoryUserControl";
            mainInventoryUserControl.Size = new Size(778, 772);
            mainInventoryUserControl.TabIndex = 6;
            // 
            // backButtonPanel
            // 
            backButtonPanel.Controls.Add(backButton);
            backButtonPanel.Location = new Point(14, 58);
            backButtonPanel.Margin = new Padding(3, 4, 3, 4);
            backButtonPanel.Name = "backButtonPanel";
            backButtonPanel.Size = new Size(50, 48);
            backButtonPanel.TabIndex = 5;
            // 
            // backButton
            // 
            backButton.AutoSize = true;
            backButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            backButton.BackColor = Color.FromArgb(227, 211, 177);
            backButton.Dock = DockStyle.Right;
            backButton.FlatAppearance.BorderColor = Color.FromArgb(28, 44, 78);
            backButton.FlatAppearance.BorderSize = 0;
            backButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(252, 251, 255);
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            backButton.ForeColor = Color.FromArgb(252, 251, 255);
            backButton.Image = (Image)resources.GetObject("backButton.Image");
            backButton.ImageAlign = ContentAlignment.MiddleLeft;
            backButton.Location = new Point(-4, 0);
            backButton.Margin = new Padding(3, 4, 3, 4);
            backButton.Name = "backButton";
            backButton.Size = new Size(54, 48);
            backButton.TabIndex = 3;
            backButton.TextAlign = ContentAlignment.BottomCenter;
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // addManagerButton
            // 
            addManagerButton.BackColor = Color.FromArgb(28, 44, 78);
            addManagerButton.FlatAppearance.BorderSize = 0;
            addManagerButton.FlatStyle = FlatStyle.Flat;
            addManagerButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            addManagerButton.ForeColor = Color.White;
            addManagerButton.Image = (Image)resources.GetObject("addManagerButton.Image");
            addManagerButton.Location = new Point(505, 182);
            addManagerButton.Margin = new Padding(3, 4, 3, 4);
            addManagerButton.Name = "addManagerButton";
            addManagerButton.Size = new Size(140, 150);
            addManagerButton.TabIndex = 9;
            addManagerButton.Text = "Add Manager";
            addManagerButton.TextAlign = ContentAlignment.BottomCenter;
            addManagerButton.TextImageRelation = TextImageRelation.ImageAboveText;
            addManagerButton.UseVisualStyleBackColor = false;
            addManagerButton.Click += MainAddManagerButton_Click;
            // 
            // storeNameLabel
            // 
            storeNameLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            storeNameLabel.ForeColor = Color.FromArgb(28, 44, 78);
            storeNameLabel.Location = new Point(3, 0);
            storeNameLabel.Name = "storeNameLabel";
            storeNameLabel.Size = new Size(845, 45);
            storeNameLabel.TabIndex = 1;
            storeNameLabel.Text = "Name";
            storeNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // storeButtonsPanel
            // 
            storeButtonsPanel.Controls.Add(AddVendorButton);
            storeButtonsPanel.Controls.Add(orderButton);
            storeButtonsPanel.Controls.Add(addManagerButton);
            storeButtonsPanel.Controls.Add(inventoryButton);
            storeButtonsPanel.Controls.Add(exitStoreButton);
            storeButtonsPanel.Controls.Add(addProductButton);
            storeButtonsPanel.Location = new Point(3, 48);
            storeButtonsPanel.Name = "storeButtonsPanel";
            storeButtonsPanel.Size = new Size(845, 522);
            storeButtonsPanel.TabIndex = 10;
            // 
            // StoreFrontUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(227, 211, 177);
            Controls.Add(storeNameLabel);
            Controls.Add(backButtonPanel);
            Controls.Add(storeExpandedPanel);
            Controls.Add(storeButtonsPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "StoreFrontUserControl";
            Size = new Size(852, 841);
            Load += StoreFrontUserControl_Load;
            storeExpandedPanel.ResumeLayout(false);
            backButtonPanel.ResumeLayout(false);
            backButtonPanel.PerformLayout();
            storeButtonsPanel.ResumeLayout(false);
            ResumeLayout(false);
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
