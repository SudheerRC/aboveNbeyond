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
            this.logoutButton = new System.Windows.Forms.Button();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.searchProductSubMenuButton = new System.Windows.Forms.Button();
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
            this.mainContainer.Panel1.Controls.Add(this.logoutButton);
            this.mainContainer.Panel1.Controls.Add(this.navigationPanel);
            this.mainContainer.Panel1.Controls.Add(this.logoPanel);
            this.mainContainer.Panel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.Controls.Add(this.workspaceContainer);
            this.mainContainer.Size = new System.Drawing.Size(1904, 1041);
            this.mainContainer.SplitterDistance = 209;
            this.mainContainer.SplitterWidth = 1;
            this.mainContainer.TabIndex = 0;
            // 
            // logoutButton
            // 
            this.logoutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.logoutButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.logoutButton.Image = ((System.Drawing.Image)(resources.GetObject("logoutButton.Image")));
            this.logoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.Location = new System.Drawing.Point(0, 971);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.logoutButton.Size = new System.Drawing.Size(196, 50);
            this.logoutButton.TabIndex = 7;
            this.logoutButton.Text = "Logout";
            this.logoutButton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.logoutButton.UseVisualStyleBackColor = false;
            // 
            // navigationPanel
            // 
            this.navigationPanel.AutoScroll = true;
            this.navigationPanel.Controls.Add(this.searchProductSubMenuButton);
            this.navigationPanel.Controls.Add(this.addVendorSubMenuButton);
            this.navigationPanel.Controls.Add(this.searchVendorSubMenuButton);
            this.navigationPanel.Controls.Add(this.vendorsMenuButton);
            this.navigationPanel.Controls.Add(this.addProductSubMenuButton);
            this.navigationPanel.Controls.Add(this.productsMenuButton);
            this.navigationPanel.Controls.Add(this.homeMenuButton);
            this.navigationPanel.Location = new System.Drawing.Point(3, 168);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(201, 576);
            this.navigationPanel.TabIndex = 2;
            // 
            // searchProductSubMenuButton
            // 
            this.searchProductSubMenuButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchProductSubMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.searchProductSubMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchProductSubMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.searchProductSubMenuButton.FlatAppearance.BorderSize = 0;
            this.searchProductSubMenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.searchProductSubMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchProductSubMenuButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchProductSubMenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.searchProductSubMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchProductSubMenuButton.Location = new System.Drawing.Point(0, 138);
            this.searchProductSubMenuButton.Name = "searchProductSubMenuButton";
            this.searchProductSubMenuButton.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.searchProductSubMenuButton.Size = new System.Drawing.Size(201, 44);
            this.searchProductSubMenuButton.TabIndex = 5;
            this.searchProductSubMenuButton.Text = "Search Product";
            this.searchProductSubMenuButton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.searchProductSubMenuButton.UseVisualStyleBackColor = false;
            // 
            // addVendorSubMenuButton
            // 
            this.addVendorSubMenuButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addVendorSubMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.addVendorSubMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.addVendorSubMenuButton.FlatAppearance.BorderSize = 0;
            this.addVendorSubMenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.addVendorSubMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addVendorSubMenuButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addVendorSubMenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.addVendorSubMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addVendorSubMenuButton.Location = new System.Drawing.Point(12, 250);
            this.addVendorSubMenuButton.Name = "addVendorSubMenuButton";
            this.addVendorSubMenuButton.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.addVendorSubMenuButton.Size = new System.Drawing.Size(173, 37);
            this.addVendorSubMenuButton.TabIndex = 9;
            this.addVendorSubMenuButton.Text = "Add Vendor";
            this.addVendorSubMenuButton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.addVendorSubMenuButton.UseVisualStyleBackColor = false;
            // 
            // searchVendorSubMenuButton
            // 
            this.searchVendorSubMenuButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchVendorSubMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.searchVendorSubMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.searchVendorSubMenuButton.FlatAppearance.BorderSize = 0;
            this.searchVendorSubMenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.searchVendorSubMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchVendorSubMenuButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchVendorSubMenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.searchVendorSubMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchVendorSubMenuButton.Location = new System.Drawing.Point(12, 215);
            this.searchVendorSubMenuButton.Name = "searchVendorSubMenuButton";
            this.searchVendorSubMenuButton.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.searchVendorSubMenuButton.Size = new System.Drawing.Size(184, 38);
            this.searchVendorSubMenuButton.TabIndex = 8;
            this.searchVendorSubMenuButton.Text = "Search Vendor";
            this.searchVendorSubMenuButton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.searchVendorSubMenuButton.UseVisualStyleBackColor = false;
            // 
            // vendorsMenuButton
            // 
            this.vendorsMenuButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.vendorsMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.vendorsMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.vendorsMenuButton.FlatAppearance.BorderSize = 0;
            this.vendorsMenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.vendorsMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vendorsMenuButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vendorsMenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.vendorsMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("vendorsMenuButton.Image")));
            this.vendorsMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vendorsMenuButton.Location = new System.Drawing.Point(3, 176);
            this.vendorsMenuButton.Name = "vendorsMenuButton";
            this.vendorsMenuButton.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.vendorsMenuButton.Size = new System.Drawing.Size(196, 42);
            this.vendorsMenuButton.TabIndex = 7;
            this.vendorsMenuButton.Text = "Vendors";
            this.vendorsMenuButton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.vendorsMenuButton.UseVisualStyleBackColor = false;
            // 
            // addProductSubMenuButton
            // 
            this.addProductSubMenuButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addProductSubMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.addProductSubMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addProductSubMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.addProductSubMenuButton.FlatAppearance.BorderSize = 0;
            this.addProductSubMenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.addProductSubMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductSubMenuButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addProductSubMenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.addProductSubMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addProductSubMenuButton.Location = new System.Drawing.Point(0, 94);
            this.addProductSubMenuButton.Name = "addProductSubMenuButton";
            this.addProductSubMenuButton.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.addProductSubMenuButton.Size = new System.Drawing.Size(201, 44);
            this.addProductSubMenuButton.TabIndex = 4;
            this.addProductSubMenuButton.Text = "Add Product";
            this.addProductSubMenuButton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.addProductSubMenuButton.UseVisualStyleBackColor = false;
            // 
            // productsMenuButton
            // 
            this.productsMenuButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.productsMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.productsMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.productsMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.productsMenuButton.FlatAppearance.BorderSize = 0;
            this.productsMenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.productsMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsMenuButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productsMenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.productsMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("productsMenuButton.Image")));
            this.productsMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productsMenuButton.Location = new System.Drawing.Point(0, 50);
            this.productsMenuButton.Name = "productsMenuButton";
            this.productsMenuButton.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.productsMenuButton.Size = new System.Drawing.Size(201, 44);
            this.productsMenuButton.TabIndex = 3;
            this.productsMenuButton.Text = "Products";
            this.productsMenuButton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.productsMenuButton.UseVisualStyleBackColor = false;
            // 
            // homeMenuButton
            // 
            this.homeMenuButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.homeMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.homeMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.homeMenuButton.FlatAppearance.BorderSize = 0;
            this.homeMenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.homeMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeMenuButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.homeMenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.homeMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("homeMenuButton.Image")));
            this.homeMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeMenuButton.Location = new System.Drawing.Point(0, 0);
            this.homeMenuButton.Name = "homeMenuButton";
            this.homeMenuButton.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.homeMenuButton.Size = new System.Drawing.Size(201, 50);
            this.homeMenuButton.TabIndex = 2;
            this.homeMenuButton.Text = "Home";
            this.homeMenuButton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.homeMenuButton.UseVisualStyleBackColor = false;
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
            this.workspaceContainer.Size = new System.Drawing.Size(1694, 1041);
            this.workspaceContainer.SplitterDistance = 1393;
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
            this.storeContainer.Panel2.Controls.Add(this.mainHomeTabUserControl);
            this.storeContainer.Size = new System.Drawing.Size(1393, 1041);
            this.storeContainer.SplitterDistance = 140;
            this.storeContainer.SplitterWidth = 1;
            this.storeContainer.TabIndex = 0;
            // 
            // storeNameLabel
            // 
            this.storeNameLabel.Font = new System.Drawing.Font("Segoe UI", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.storeNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.storeNameLabel.Location = new System.Drawing.Point(3, 23);
            this.storeNameLabel.Name = "storeNameLabel";
            this.storeNameLabel.Size = new System.Drawing.Size(1390, 68);
            this.storeNameLabel.TabIndex = 0;
            this.storeNameLabel.Text = "Store Name";
            this.storeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainHomeTabUserControl
            // 
            this.mainHomeTabUserControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainHomeTabUserControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.mainHomeTabUserControl.Location = new System.Drawing.Point(0, 0);
            this.mainHomeTabUserControl.Name = "mainHomeTabUserControl";
            this.mainHomeTabUserControl.Size = new System.Drawing.Size(1393, 924);
            this.mainHomeTabUserControl.TabIndex = 0;
            // 
            // searchPanel
            // 
            this.searchPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchPanel.Controls.Add(this.searchInputPanel);
            this.searchPanel.Location = new System.Drawing.Point(3, 106);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(300, 299);
            this.searchPanel.TabIndex = 7;
            // 
            // searchInputPanel
            // 
            this.searchInputPanel.Controls.Add(this.searchTextBox);
            this.searchInputPanel.Controls.Add(this.searchButtonPanel);
            this.searchInputPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchInputPanel.Location = new System.Drawing.Point(0, 0);
            this.searchInputPanel.Name = "searchInputPanel";
            this.searchInputPanel.Size = new System.Drawing.Size(300, 35);
            this.searchInputPanel.TabIndex = 0;
            // 
            // searchTextBox
            // 
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTextBox.Enabled = false;
            this.searchTextBox.Location = new System.Drawing.Point(0, 0);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PlaceholderText = "Coming in the next iteration";
            this.searchTextBox.Size = new System.Drawing.Size(265, 35);
            this.searchTextBox.TabIndex = 6;
            // 
            // searchButtonPanel
            // 
            this.searchButtonPanel.Controls.Add(this.searchButton);
            this.searchButtonPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchButtonPanel.Location = new System.Drawing.Point(265, 0);
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
            this.windowOpPanel.Size = new System.Drawing.Size(300, 45);
            this.windowOpPanel.TabIndex = 5;
            // 
            // minPanel
            // 
            this.minPanel.Controls.Add(this.minButton);
            this.minPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.minPanel.Location = new System.Drawing.Point(169, 0);
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
            // 
            // maxPanel
            // 
            this.maxPanel.Controls.Add(this.restoreButton);
            this.maxPanel.Controls.Add(this.maxButton);
            this.maxPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.maxPanel.Location = new System.Drawing.Point(212, 0);
            this.maxPanel.Name = "maxPanel";
            this.maxPanel.Size = new System.Drawing.Size(45, 45);
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
            this.restoreButton.Location = new System.Drawing.Point(-55, 0);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(50, 45);
            this.restoreButton.TabIndex = 4;
            this.restoreButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.restoreButton.UseVisualStyleBackColor = false;
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
            this.maxButton.Location = new System.Drawing.Point(-5, 0);
            this.maxButton.Name = "maxButton";
            this.maxButton.Size = new System.Drawing.Size(50, 45);
            this.maxButton.TabIndex = 3;
            this.maxButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.maxButton.UseVisualStyleBackColor = false;
            // 
            // closePanel
            // 
            this.closePanel.Controls.Add(this.closeButton);
            this.closePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.closePanel.Location = new System.Drawing.Point(257, 0);
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
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.mainContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainDashboard";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyStores";
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
        private Button searchProductSubMenuButton;
    }
}