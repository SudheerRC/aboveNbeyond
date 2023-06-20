namespace MyStores.View
{
    partial class MainDashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDashboard));
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.addVendorSubMenuButton = new System.Windows.Forms.Button();
            this.searchVendorSubMenuButton = new System.Windows.Forms.Button();
            this.vendorsMenuButton = new System.Windows.Forms.Button();
            this.addProductSubMenuButton = new System.Windows.Forms.Button();
            this.productsMenuButton = new System.Windows.Forms.Button();
            this.homeMenuButton = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.workspaceContainer = new System.Windows.Forms.SplitContainer();
            this.storeContainer = new System.Windows.Forms.SplitContainer();
            this.storeNameLabel = new System.Windows.Forms.Label();
            this.mainVendorTabUserControl = new MyStores.UserControls.VendorTabUserControl();
            this.mainProductsTabUserControl = new MyStores.UserControls.ProductsTabUserControl();
            this.mainHomeTabUserControl = new MyStores.UserControls.HomeUserControl.HomeTabUserControl();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchInputPanel = new System.Windows.Forms.Panel();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButtonPanel = new System.Windows.Forms.Panel();
            this.searchButton = new System.Windows.Forms.Button();
            this.windowOpPanel = new System.Windows.Forms.Panel();
            this.minPanel = new System.Windows.Forms.Panel();
            this.minButton = new System.Windows.Forms.Button();
            this.maxPanel = new System.Windows.Forms.Panel();
            this.restoreButton = new System.Windows.Forms.Button();
            this.maxButton = new System.Windows.Forms.Button();
            this.closePanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.Panel1.SuspendLayout();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.navigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workspaceContainer)).BeginInit();
            this.workspaceContainer.Panel1.SuspendLayout();
            this.workspaceContainer.Panel2.SuspendLayout();
            this.workspaceContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeContainer)).BeginInit();
            this.storeContainer.Panel1.SuspendLayout();
            this.storeContainer.Panel2.SuspendLayout();
            this.storeContainer.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.searchInputPanel.SuspendLayout();
            this.searchButtonPanel.SuspendLayout();
            this.windowOpPanel.SuspendLayout();
            this.minPanel.SuspendLayout();
            this.maxPanel.SuspendLayout();
            this.closePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Name = "mainContainer";
            // 
            // mainContainer.Panel1
            // 
            this.mainContainer.Panel1.AutoScroll = true;
            this.mainContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.mainContainer.Panel1.Controls.Add(this.navigationPanel);
            this.mainContainer.Panel1.Controls.Add(this.logoPanel);
            this.mainContainer.Panel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.Controls.Add(this.workspaceContainer);
            this.mainContainer.Size = new System.Drawing.Size(1920, 1080);
            this.mainContainer.SplitterDistance = 209;
            this.mainContainer.SplitterWidth = 1;
            this.mainContainer.TabIndex = 0;
            // 
            // navigationPanel
            // 
            this.navigationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navigationPanel.AutoScroll = true;
            this.navigationPanel.Controls.Add(this.logoutButton);
            this.navigationPanel.Controls.Add(this.addVendorSubMenuButton);
            this.navigationPanel.Controls.Add(this.searchVendorSubMenuButton);
            this.navigationPanel.Controls.Add(this.vendorsMenuButton);
            this.navigationPanel.Controls.Add(this.addProductSubMenuButton);
            this.navigationPanel.Controls.Add(this.productsMenuButton);
            this.navigationPanel.Controls.Add(this.homeMenuButton);
            this.navigationPanel.Location = new System.Drawing.Point(3, 178);
            this.navigationPanel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(201, 848);
            this.navigationPanel.TabIndex = 2;
            // 
            // logoutButton
            // 
            this.logoutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.logoutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.logoutButton.Image = ((System.Drawing.Image)(resources.GetObject("logoutButton.Image")));
            this.logoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.Location = new System.Drawing.Point(0, 799);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.logoutButton.Size = new System.Drawing.Size(201, 49);
            this.logoutButton.TabIndex = 7;
            this.logoutButton.Text = "Logout";
            this.logoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            this.logoutButton.MouseEnter += new System.EventHandler(this.logoutButton_MouseEnter);
            this.logoutButton.MouseLeave += new System.EventHandler(this.logoutButton_MouseLeave);
            // 
            // addVendorSubMenuButton
            // 
            this.addVendorSubMenuButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addVendorSubMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.addVendorSubMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addVendorSubMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.addVendorSubMenuButton.FlatAppearance.BorderSize = 0;
            this.addVendorSubMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addVendorSubMenuButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addVendorSubMenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.addVendorSubMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addVendorSubMenuButton.Location = new System.Drawing.Point(0, 299);
            this.addVendorSubMenuButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.addVendorSubMenuButton.Name = "addVendorSubMenuButton";
            this.addVendorSubMenuButton.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.addVendorSubMenuButton.Size = new System.Drawing.Size(201, 49);
            this.addVendorSubMenuButton.TabIndex = 9;
            this.addVendorSubMenuButton.Text = "Add Vendor";
            this.addVendorSubMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addVendorSubMenuButton.UseVisualStyleBackColor = false;
            this.addVendorSubMenuButton.Click += new System.EventHandler(this.addVendorSubMenuButton_Click);
            this.addVendorSubMenuButton.MouseEnter += new System.EventHandler(this.addVendorSubMenuButton_MouseEnter);
            this.addVendorSubMenuButton.MouseLeave += new System.EventHandler(this.addVendorSubMenuButton_MouseLeave);
            // 
            // searchVendorSubMenuButton
            // 
            this.searchVendorSubMenuButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchVendorSubMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.searchVendorSubMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchVendorSubMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.searchVendorSubMenuButton.FlatAppearance.BorderSize = 0;
            this.searchVendorSubMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchVendorSubMenuButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchVendorSubMenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.searchVendorSubMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchVendorSubMenuButton.Location = new System.Drawing.Point(0, 250);
            this.searchVendorSubMenuButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.searchVendorSubMenuButton.Name = "searchVendorSubMenuButton";
            this.searchVendorSubMenuButton.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.searchVendorSubMenuButton.Size = new System.Drawing.Size(201, 49);
            this.searchVendorSubMenuButton.TabIndex = 8;
            this.searchVendorSubMenuButton.Text = "Search Vendor";
            this.searchVendorSubMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchVendorSubMenuButton.UseVisualStyleBackColor = false;
            this.searchVendorSubMenuButton.Click += new System.EventHandler(this.searchVendorSubMenuButton_Click);
            this.searchVendorSubMenuButton.MouseEnter += new System.EventHandler(this.searchVendorSubMenuButton_MouseEnter);
            this.searchVendorSubMenuButton.MouseLeave += new System.EventHandler(this.searchVendorSubMenuButton_MouseLeave);
            // 
            // vendorsMenuButton
            // 
            this.vendorsMenuButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.vendorsMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.vendorsMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.vendorsMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.vendorsMenuButton.FlatAppearance.BorderSize = 0;
            this.vendorsMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vendorsMenuButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vendorsMenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.vendorsMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("vendorsMenuButton.Image")));
            this.vendorsMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vendorsMenuButton.Location = new System.Drawing.Point(0, 187);
            this.vendorsMenuButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.vendorsMenuButton.Name = "vendorsMenuButton";
            this.vendorsMenuButton.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.vendorsMenuButton.Size = new System.Drawing.Size(201, 63);
            this.vendorsMenuButton.TabIndex = 7;
            this.vendorsMenuButton.Text = "Vendors";
            this.vendorsMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.vendorsMenuButton.UseVisualStyleBackColor = false;
            this.vendorsMenuButton.MouseEnter += new System.EventHandler(this.vendorsMenuButton_MouseEnter);
            this.vendorsMenuButton.MouseLeave += new System.EventHandler(this.vendorsMenuButton_MouseLeave);
            // 
            // addProductSubMenuButton
            // 
            this.addProductSubMenuButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addProductSubMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.addProductSubMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addProductSubMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.addProductSubMenuButton.FlatAppearance.BorderSize = 0;
            this.addProductSubMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductSubMenuButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addProductSubMenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.addProductSubMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addProductSubMenuButton.Location = new System.Drawing.Point(0, 138);
            this.addProductSubMenuButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.addProductSubMenuButton.Name = "addProductSubMenuButton";
            this.addProductSubMenuButton.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.addProductSubMenuButton.Size = new System.Drawing.Size(201, 49);
            this.addProductSubMenuButton.TabIndex = 4;
            this.addProductSubMenuButton.Text = "Add Product";
            this.addProductSubMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addProductSubMenuButton.UseVisualStyleBackColor = false;
            this.addProductSubMenuButton.Click += new System.EventHandler(this.addProductSubMenuButton_Click);
            this.addProductSubMenuButton.MouseEnter += new System.EventHandler(this.addProductSubMenuButton_MouseEnter);
            this.addProductSubMenuButton.MouseLeave += new System.EventHandler(this.addProductSubMenuButton_MouseLeave);
            // 
            // productsMenuButton
            // 
            this.productsMenuButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.productsMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.productsMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.productsMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.productsMenuButton.FlatAppearance.BorderSize = 0;
            this.productsMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsMenuButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productsMenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.productsMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("productsMenuButton.Image")));
            this.productsMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productsMenuButton.Location = new System.Drawing.Point(0, 69);
            this.productsMenuButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.productsMenuButton.Name = "productsMenuButton";
            this.productsMenuButton.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.productsMenuButton.Size = new System.Drawing.Size(201, 69);
            this.productsMenuButton.TabIndex = 3;
            this.productsMenuButton.Text = "Products";
            this.productsMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.productsMenuButton.UseVisualStyleBackColor = false;
            this.productsMenuButton.MouseEnter += new System.EventHandler(this.productsMenuButton_MouseEnter);
            this.productsMenuButton.MouseLeave += new System.EventHandler(this.productsMenuButton_MouseLeave);
            // 
            // homeMenuButton
            // 
            this.homeMenuButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.homeMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.homeMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.homeMenuButton.FlatAppearance.BorderSize = 0;
            this.homeMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeMenuButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.homeMenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.homeMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("homeMenuButton.Image")));
            this.homeMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeMenuButton.Location = new System.Drawing.Point(0, 0);
            this.homeMenuButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.homeMenuButton.Name = "homeMenuButton";
            this.homeMenuButton.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.homeMenuButton.Size = new System.Drawing.Size(201, 69);
            this.homeMenuButton.TabIndex = 2;
            this.homeMenuButton.Text = "Home";
            this.homeMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homeMenuButton.UseVisualStyleBackColor = false;
            this.homeMenuButton.Click += new System.EventHandler(this.homeMenuButton_Click);
            this.homeMenuButton.MouseEnter += new System.EventHandler(this.homeMenuButton_MouseEnter);
            this.homeMenuButton.MouseLeave += new System.EventHandler(this.homeMenuButton_MouseLeave);
            // 
            // logoPanel
            // 
            this.logoPanel.Location = new System.Drawing.Point(3, 3);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(201, 137);
            this.logoPanel.TabIndex = 0;
            // 
            // workspaceContainer
            // 
            this.workspaceContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workspaceContainer.Location = new System.Drawing.Point(0, 0);
            this.workspaceContainer.Name = "workspaceContainer";
            // 
            // workspaceContainer.Panel1
            // 
            this.workspaceContainer.Panel1.Controls.Add(this.storeContainer);
            // 
            // workspaceContainer.Panel2
            // 
            this.workspaceContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.workspaceContainer.Panel2.Controls.Add(this.searchPanel);
            this.workspaceContainer.Panel2.Controls.Add(this.windowOpPanel);
            this.workspaceContainer.Panel2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.workspaceContainer.Size = new System.Drawing.Size(1710, 1080);
            this.workspaceContainer.SplitterDistance = 1405;
            this.workspaceContainer.SplitterWidth = 1;
            this.workspaceContainer.TabIndex = 0;
            // 
            // storeContainer
            // 
            this.storeContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.storeContainer.Location = new System.Drawing.Point(0, 0);
            this.storeContainer.Name = "storeContainer";
            this.storeContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // storeContainer.Panel1
            // 
            this.storeContainer.Panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.storeContainer.Panel1.Controls.Add(this.storeNameLabel);
            // 
            // storeContainer.Panel2
            // 
            this.storeContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.storeContainer.Panel2.Controls.Add(this.mainVendorTabUserControl);
            this.storeContainer.Panel2.Controls.Add(this.mainProductsTabUserControl);
            this.storeContainer.Panel2.Controls.Add(this.mainHomeTabUserControl);
            this.storeContainer.Size = new System.Drawing.Size(1405, 1080);
            this.storeContainer.SplitterDistance = 143;
            this.storeContainer.SplitterWidth = 1;
            this.storeContainer.TabIndex = 0;
            // 
            // storeNameLabel
            // 
            this.storeNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.storeNameLabel.Font = new System.Drawing.Font("Segoe UI", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.storeNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.storeNameLabel.Location = new System.Drawing.Point(3, 23);
            this.storeNameLabel.Name = "storeNameLabel";
            this.storeNameLabel.Size = new System.Drawing.Size(1397, 68);
            this.storeNameLabel.TabIndex = 0;
            this.storeNameLabel.Text = "MyStores";
            this.storeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainVendorTabUserControl
            // 
            this.mainVendorTabUserControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainVendorTabUserControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.mainVendorTabUserControl.Location = new System.Drawing.Point(8, 11);
            this.mainVendorTabUserControl.Name = "mainVendorTabUserControl";
            this.mainVendorTabUserControl.Size = new System.Drawing.Size(1390, 909);
            this.mainVendorTabUserControl.TabIndex = 2;
            // 
            // mainProductsTabUserControl
            // 
            this.mainProductsTabUserControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainProductsTabUserControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.mainProductsTabUserControl.Location = new System.Drawing.Point(10, 15);
            this.mainProductsTabUserControl.Name = "mainProductsTabUserControl";
            this.mainProductsTabUserControl.Size = new System.Drawing.Size(1390, 909);
            this.mainProductsTabUserControl.TabIndex = 1;
            // 
            // mainHomeTabUserControl
            // 
            this.mainHomeTabUserControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainHomeTabUserControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.mainHomeTabUserControl.Location = new System.Drawing.Point(0, 0);
            this.mainHomeTabUserControl.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.mainHomeTabUserControl.Name = "mainHomeTabUserControl";
            this.mainHomeTabUserControl.Size = new System.Drawing.Size(1405, 944);
            this.mainHomeTabUserControl.TabIndex = 0;
            // 
            // searchPanel
            // 
            this.searchPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchPanel.Controls.Add(this.searchInputPanel);
            this.searchPanel.Location = new System.Drawing.Point(4, 144);
            this.searchPanel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(301, 349);
            this.searchPanel.TabIndex = 7;
            // 
            // searchInputPanel
            // 
            this.searchInputPanel.Controls.Add(this.searchTextBox);
            this.searchInputPanel.Controls.Add(this.searchButtonPanel);
            this.searchInputPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchInputPanel.Location = new System.Drawing.Point(0, 0);
            this.searchInputPanel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.searchInputPanel.Name = "searchInputPanel";
            this.searchInputPanel.Size = new System.Drawing.Size(301, 35);
            this.searchInputPanel.TabIndex = 0;
            // 
            // searchTextBox
            // 
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchTextBox.Enabled = false;
            this.searchTextBox.Location = new System.Drawing.Point(5, 0);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PlaceholderText = "Coming in the next iteration";
            this.searchTextBox.Size = new System.Drawing.Size(261, 35);
            this.searchTextBox.TabIndex = 6;
            // 
            // searchButtonPanel
            // 
            this.searchButtonPanel.Controls.Add(this.searchButton);
            this.searchButtonPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchButtonPanel.Location = new System.Drawing.Point(266, 0);
            this.searchButtonPanel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.searchButtonPanel.Name = "searchButtonPanel";
            this.searchButtonPanel.Size = new System.Drawing.Size(35, 35);
            this.searchButtonPanel.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.White;
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchButton.Enabled = false;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(0, 0);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(35, 35);
            this.searchButton.TabIndex = 0;
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // windowOpPanel
            // 
            this.windowOpPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.windowOpPanel.Controls.Add(this.minPanel);
            this.windowOpPanel.Controls.Add(this.maxPanel);
            this.windowOpPanel.Controls.Add(this.closePanel);
            this.windowOpPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.windowOpPanel.Location = new System.Drawing.Point(0, 0);
            this.windowOpPanel.Name = "windowOpPanel";
            this.windowOpPanel.Size = new System.Drawing.Size(304, 45);
            this.windowOpPanel.TabIndex = 5;
            // 
            // minPanel
            // 
            this.minPanel.Controls.Add(this.minButton);
            this.minPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.minPanel.Location = new System.Drawing.Point(218, 0);
            this.minPanel.Name = "minPanel";
            this.minPanel.Size = new System.Drawing.Size(43, 45);
            this.minPanel.TabIndex = 4;
            // 
            // minButton
            // 
            this.minButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.minButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.minButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.minButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.minButton.FlatAppearance.BorderSize = 0;
            this.minButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.minButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.minButton.Image = ((System.Drawing.Image)(resources.GetObject("minButton.Image")));
            this.minButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.minButton.Location = new System.Drawing.Point(-7, 0);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(50, 45);
            this.minButton.TabIndex = 3;
            this.minButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.minButton.UseVisualStyleBackColor = false;
            this.minButton.Click += new System.EventHandler(this.minButton_Click);
            // 
            // maxPanel
            // 
            this.maxPanel.Controls.Add(this.restoreButton);
            this.maxPanel.Controls.Add(this.maxButton);
            this.maxPanel.Location = new System.Drawing.Point(220, 0);
            this.maxPanel.Name = "maxPanel";
            this.maxPanel.Size = new System.Drawing.Size(41, 45);
            this.maxPanel.TabIndex = 0;
            // 
            // restoreButton
            // 
            this.restoreButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.restoreButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.restoreButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.restoreButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.restoreButton.FlatAppearance.BorderSize = 0;
            this.restoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.restoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restoreButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.restoreButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.restoreButton.Image = ((System.Drawing.Image)(resources.GetObject("restoreButton.Image")));
            this.restoreButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.restoreButton.Location = new System.Drawing.Point(-59, 0);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(50, 45);
            this.restoreButton.TabIndex = 4;
            this.restoreButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.restoreButton.UseVisualStyleBackColor = false;
            this.restoreButton.Click += new System.EventHandler(this.restoreButton_Click);
            // 
            // maxButton
            // 
            this.maxButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.maxButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.maxButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.maxButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.maxButton.FlatAppearance.BorderSize = 0;
            this.maxButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.maxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maxButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.maxButton.Image = ((System.Drawing.Image)(resources.GetObject("maxButton.Image")));
            this.maxButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.maxButton.Location = new System.Drawing.Point(-9, 0);
            this.maxButton.Name = "maxButton";
            this.maxButton.Size = new System.Drawing.Size(50, 45);
            this.maxButton.TabIndex = 3;
            this.maxButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.maxButton.UseVisualStyleBackColor = false;
            this.maxButton.Click += new System.EventHandler(this.maxButton_Click);
            // 
            // closePanel
            // 
            this.closePanel.Controls.Add(this.closeButton);
            this.closePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.closePanel.Location = new System.Drawing.Point(261, 0);
            this.closePanel.Name = "closePanel";
            this.closePanel.Size = new System.Drawing.Size(43, 45);
            this.closePanel.TabIndex = 4;
            // 
            // closeButton
            // 
            this.closeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeButton.Location = new System.Drawing.Point(-7, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(50, 45);
            this.closeButton.TabIndex = 3;
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.mainContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainDashboard";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyStores";
            this.Load += new System.EventHandler(this.MainDashboard_Load);
            this.mainContainer.Panel1.ResumeLayout(false);
            this.mainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.navigationPanel.ResumeLayout(false);
            this.workspaceContainer.Panel1.ResumeLayout(false);
            this.workspaceContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.workspaceContainer)).EndInit();
            this.workspaceContainer.ResumeLayout(false);
            this.storeContainer.Panel1.ResumeLayout(false);
            this.storeContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.storeContainer)).EndInit();
            this.storeContainer.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.searchInputPanel.ResumeLayout(false);
            this.searchInputPanel.PerformLayout();
            this.searchButtonPanel.ResumeLayout(false);
            this.windowOpPanel.ResumeLayout(false);
            this.minPanel.ResumeLayout(false);
            this.maxPanel.ResumeLayout(false);
            this.closePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer mainContainer;
        private SplitContainer workspaceContainer;
        private SplitContainer storeContainer;
        private Label storeNameLabel;
        private Panel logoPanel;
        private Button homeMenuButton;
        private Panel navigationPanel;
        private Button maxButton;
        private Panel maxPanel;
        private TextBox searchTextBox;
        private Panel windowOpPanel;
        private Panel minPanel;
        private Button minButton;
        private Panel closePanel;
        private Button closeButton;
        private Panel searchPanel;
        private Panel searchInputPanel;
        private Panel searchButtonPanel;
        private Button searchButton;
        private Button logoutButton;
        private Button addVendorSubMenuButton;
        private Button searchVendorSubMenuButton;
        private Button vendorsMenuButton;
        private Button addProductSubMenuButton;
        private Button productsMenuButton;
        private Button restoreButton;
        private UserControls.HomeUserControl.HomeTabUserControl mainHomeTabUserControl;
        private UserControls.VendorTabUserControl mainVendorTabUserControl;
        private UserControls.ProductsTabUserControl mainProductsTabUserControl;
    }
}