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
            mainContainer = new SplitContainer();
            logoutButton = new Button();
            navigationPanel = new Panel();
            addVendorSubMenuButton = new Button();
            searchVendorSubMenuButton = new Button();
            vendorsMenuButton = new Button();
            addProductSubMenuButton = new Button();
            productsMenuButton = new Button();
            homeMenuButton = new Button();
            logoPanel = new Panel();
            workspaceContainer = new SplitContainer();
            storeContainer = new SplitContainer();
            storeNameLabel = new Label();
            mainHomeTabUserControl = new UserControls.HomeUserControl.HomeTabUserControl();
            searchPanel = new Panel();
            searchInputPanel = new Panel();
            searchTextBox = new TextBox();
            searchButtonPanel = new Panel();
            searchButton = new Button();
            windowOpPanel = new Panel();
            minPanel = new Panel();
            minButton = new Button();
            maxPanel = new Panel();
            restoreButton = new Button();
            maxButton = new Button();
            closePanel = new Panel();
            closeButton = new Button();
            searchProductSubMenuButton = new Button();
            ((System.ComponentModel.ISupportInitialize)mainContainer).BeginInit();
            mainContainer.Panel1.SuspendLayout();
            mainContainer.Panel2.SuspendLayout();
            mainContainer.SuspendLayout();
            navigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)workspaceContainer).BeginInit();
            workspaceContainer.Panel1.SuspendLayout();
            workspaceContainer.Panel2.SuspendLayout();
            workspaceContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)storeContainer).BeginInit();
            storeContainer.Panel1.SuspendLayout();
            storeContainer.Panel2.SuspendLayout();
            storeContainer.SuspendLayout();
            searchPanel.SuspendLayout();
            searchInputPanel.SuspendLayout();
            searchButtonPanel.SuspendLayout();
            windowOpPanel.SuspendLayout();
            minPanel.SuspendLayout();
            maxPanel.SuspendLayout();
            closePanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Name = "mainContainer";
            // 
            // mainContainer.Panel1
            // 
            mainContainer.Panel1.AutoScroll = true;
            mainContainer.Panel1.BackColor = Color.FromArgb(28, 44, 78);
            mainContainer.Panel1.Controls.Add(logoutButton);
            mainContainer.Panel1.Controls.Add(navigationPanel);
            mainContainer.Panel1.Controls.Add(logoPanel);
            mainContainer.Panel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
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
            logoutButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            logoutButton.BackColor = Color.FromArgb(28, 44, 78);
            logoutButton.FlatAppearance.BorderColor = Color.FromArgb(28, 44, 78);
            logoutButton.FlatAppearance.BorderSize = 0;
            logoutButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(227, 211, 177);
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            logoutButton.ForeColor = Color.FromArgb(252, 251, 255);
            logoutButton.Image = (Image)resources.GetObject("logoutButton.Image");
            logoutButton.ImageAlign = ContentAlignment.MiddleLeft;
            logoutButton.Location = new Point(0, 971);
            logoutButton.Name = "logoutButton";
            logoutButton.Padding = new Padding(2, 0, 0, 0);
            logoutButton.Size = new Size(196, 50);
            logoutButton.TabIndex = 7;
            logoutButton.Text = "Logout";
            logoutButton.TextAlign = ContentAlignment.BottomRight;
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += LogoutButton_Click;
            // 
            // navigationPanel
            // 
            navigationPanel.AutoScroll = true;
            navigationPanel.Controls.Add(searchProductSubMenuButton);
            navigationPanel.Controls.Add(addVendorSubMenuButton);
            navigationPanel.Controls.Add(searchVendorSubMenuButton);
            navigationPanel.Controls.Add(vendorsMenuButton);
            navigationPanel.Controls.Add(addProductSubMenuButton);
            navigationPanel.Controls.Add(productsMenuButton);
            navigationPanel.Controls.Add(homeMenuButton);
            navigationPanel.Location = new Point(3, 168);
            navigationPanel.Name = "navigationPanel";
            navigationPanel.Size = new Size(201, 576);
            navigationPanel.TabIndex = 2;
            // 
            // addVendorSubMenuButton
            // 
            addVendorSubMenuButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addVendorSubMenuButton.BackColor = Color.FromArgb(28, 44, 78);
            addVendorSubMenuButton.FlatAppearance.BorderColor = Color.FromArgb(28, 44, 78);
            addVendorSubMenuButton.FlatAppearance.BorderSize = 0;
            addVendorSubMenuButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(227, 211, 177);
            addVendorSubMenuButton.FlatStyle = FlatStyle.Flat;
            addVendorSubMenuButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            addVendorSubMenuButton.ForeColor = Color.FromArgb(252, 251, 255);
            addVendorSubMenuButton.ImageAlign = ContentAlignment.MiddleLeft;
            addVendorSubMenuButton.Location = new Point(12, 250);
            addVendorSubMenuButton.Name = "addVendorSubMenuButton";
            addVendorSubMenuButton.Padding = new Padding(2, 0, 0, 0);
            addVendorSubMenuButton.Size = new Size(173, 37);
            addVendorSubMenuButton.TabIndex = 9;
            addVendorSubMenuButton.Text = "Add Vendor";
            addVendorSubMenuButton.TextAlign = ContentAlignment.BottomRight;
            addVendorSubMenuButton.UseVisualStyleBackColor = false;
            // 
            // searchVendorSubMenuButton
            // 
            searchVendorSubMenuButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            searchVendorSubMenuButton.BackColor = Color.FromArgb(28, 44, 78);
            searchVendorSubMenuButton.FlatAppearance.BorderColor = Color.FromArgb(28, 44, 78);
            searchVendorSubMenuButton.FlatAppearance.BorderSize = 0;
            searchVendorSubMenuButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(227, 211, 177);
            searchVendorSubMenuButton.FlatStyle = FlatStyle.Flat;
            searchVendorSubMenuButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            searchVendorSubMenuButton.ForeColor = Color.FromArgb(252, 251, 255);
            searchVendorSubMenuButton.ImageAlign = ContentAlignment.MiddleLeft;
            searchVendorSubMenuButton.Location = new Point(12, 215);
            searchVendorSubMenuButton.Name = "searchVendorSubMenuButton";
            searchVendorSubMenuButton.Padding = new Padding(2, 0, 0, 0);
            searchVendorSubMenuButton.Size = new Size(184, 38);
            searchVendorSubMenuButton.TabIndex = 8;
            searchVendorSubMenuButton.Text = "Search Vendor";
            searchVendorSubMenuButton.TextAlign = ContentAlignment.BottomRight;
            searchVendorSubMenuButton.UseVisualStyleBackColor = false;
            // 
            // vendorsMenuButton
            // 
            vendorsMenuButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            vendorsMenuButton.BackColor = Color.FromArgb(28, 44, 78);
            vendorsMenuButton.FlatAppearance.BorderColor = Color.FromArgb(28, 44, 78);
            vendorsMenuButton.FlatAppearance.BorderSize = 0;
            vendorsMenuButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(227, 211, 177);
            vendorsMenuButton.FlatStyle = FlatStyle.Flat;
            vendorsMenuButton.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            vendorsMenuButton.ForeColor = Color.FromArgb(252, 251, 255);
            vendorsMenuButton.Image = (Image)resources.GetObject("vendorsMenuButton.Image");
            vendorsMenuButton.ImageAlign = ContentAlignment.MiddleLeft;
            vendorsMenuButton.Location = new Point(3, 176);
            vendorsMenuButton.Name = "vendorsMenuButton";
            vendorsMenuButton.Padding = new Padding(2, 0, 0, 0);
            vendorsMenuButton.Size = new Size(196, 42);
            vendorsMenuButton.TabIndex = 7;
            vendorsMenuButton.Text = "Vendors";
            vendorsMenuButton.TextAlign = ContentAlignment.BottomRight;
            vendorsMenuButton.UseVisualStyleBackColor = false;
            // 
            // addProductSubMenuButton
            // 
            addProductSubMenuButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addProductSubMenuButton.BackColor = Color.FromArgb(28, 44, 78);
            addProductSubMenuButton.Dock = DockStyle.Top;
            addProductSubMenuButton.FlatAppearance.BorderColor = Color.FromArgb(28, 44, 78);
            addProductSubMenuButton.FlatAppearance.BorderSize = 0;
            addProductSubMenuButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(227, 211, 177);
            addProductSubMenuButton.FlatStyle = FlatStyle.Flat;
            addProductSubMenuButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            addProductSubMenuButton.ForeColor = Color.FromArgb(252, 251, 255);
            addProductSubMenuButton.ImageAlign = ContentAlignment.MiddleLeft;
            addProductSubMenuButton.Location = new Point(0, 94);
            addProductSubMenuButton.Name = "addProductSubMenuButton";
            addProductSubMenuButton.Padding = new Padding(2, 0, 0, 0);
            addProductSubMenuButton.Size = new Size(201, 44);
            addProductSubMenuButton.TabIndex = 4;
            addProductSubMenuButton.Text = "Add Product";
            addProductSubMenuButton.TextAlign = ContentAlignment.BottomRight;
            addProductSubMenuButton.UseVisualStyleBackColor = false;
            // 
            // productsMenuButton
            // 
            productsMenuButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            productsMenuButton.BackColor = Color.FromArgb(28, 44, 78);
            productsMenuButton.Dock = DockStyle.Top;
            productsMenuButton.FlatAppearance.BorderColor = Color.FromArgb(28, 44, 78);
            productsMenuButton.FlatAppearance.BorderSize = 0;
            productsMenuButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(227, 211, 177);
            productsMenuButton.FlatStyle = FlatStyle.Flat;
            productsMenuButton.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            productsMenuButton.ForeColor = Color.FromArgb(252, 251, 255);
            productsMenuButton.Image = (Image)resources.GetObject("productsMenuButton.Image");
            productsMenuButton.ImageAlign = ContentAlignment.MiddleLeft;
            productsMenuButton.Location = new Point(0, 50);
            productsMenuButton.Name = "productsMenuButton";
            productsMenuButton.Padding = new Padding(2, 0, 0, 0);
            productsMenuButton.Size = new Size(201, 44);
            productsMenuButton.TabIndex = 3;
            productsMenuButton.Text = "Products";
            productsMenuButton.TextAlign = ContentAlignment.BottomRight;
            productsMenuButton.UseVisualStyleBackColor = false;
            // 
            // homeMenuButton
            // 
            homeMenuButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            homeMenuButton.BackColor = Color.FromArgb(28, 44, 78);
            homeMenuButton.Dock = DockStyle.Top;
            homeMenuButton.FlatAppearance.BorderColor = Color.FromArgb(28, 44, 78);
            homeMenuButton.FlatAppearance.BorderSize = 0;
            homeMenuButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(227, 211, 177);
            homeMenuButton.FlatStyle = FlatStyle.Flat;
            homeMenuButton.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            homeMenuButton.ForeColor = Color.FromArgb(252, 251, 255);
            homeMenuButton.Image = (Image)resources.GetObject("homeMenuButton.Image");
            homeMenuButton.ImageAlign = ContentAlignment.MiddleLeft;
            homeMenuButton.Location = new Point(0, 0);
            homeMenuButton.Name = "homeMenuButton";
            homeMenuButton.Padding = new Padding(2, 0, 0, 0);
            homeMenuButton.Size = new Size(201, 50);
            homeMenuButton.TabIndex = 2;
            homeMenuButton.Text = "Home";
            homeMenuButton.TextAlign = ContentAlignment.BottomRight;
            homeMenuButton.UseVisualStyleBackColor = false;
            homeMenuButton.Click += homeMenuButton_Click;
            // 
            // logoPanel
            // 
            this.logoPanel.Location = new System.Drawing.Point(3, 3);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(208, 137);
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
            this.storeContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(123)))), ((int)(((byte)(213)))));
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
            this.storeNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.storeNameLabel.Location = new System.Drawing.Point(3, 23);
            this.storeNameLabel.Name = "storeNameLabel";
            this.storeNameLabel.Size = new System.Drawing.Size(1390, 68);
            this.storeNameLabel.TabIndex = 0;
            this.storeNameLabel.Text = "Store Name";
            this.storeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainHomeTabUserControl
            // 
            mainHomeTabUserControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainHomeTabUserControl.BackColor = Color.FromArgb(227, 211, 177);
            mainHomeTabUserControl.Location = new Point(0, 0);
            mainHomeTabUserControl.Name = "mainHomeTabUserControl";
            mainHomeTabUserControl.Size = new Size(1393, 900);
            mainHomeTabUserControl.TabIndex = 0;
            this.mainHomeTabUserControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainHomeTabUserControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.mainHomeTabUserControl.Location = new System.Drawing.Point(0, 0);
            this.mainHomeTabUserControl.Name = "mainHomeTabUserControl";
            this.mainHomeTabUserControl.Size = new System.Drawing.Size(1393, 918);
            this.mainHomeTabUserControl.TabIndex = 0;
            // 
            // searchPanel
            // 
            searchPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchPanel.Controls.Add(searchInputPanel);
            searchPanel.Location = new Point(3, 106);
            searchPanel.Name = "searchPanel";
            searchPanel.Size = new Size(297, 299);
            searchPanel.TabIndex = 7;
            this.searchPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchPanel.Controls.Add(this.searchInputPanel);
            this.searchPanel.Location = new System.Drawing.Point(3, 106);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(294, 299);
            this.searchPanel.TabIndex = 7;
            // 
            // searchInputPanel
            // 
            searchInputPanel.Controls.Add(searchTextBox);
            searchInputPanel.Controls.Add(searchButtonPanel);
            searchInputPanel.Dock = DockStyle.Top;
            searchInputPanel.Location = new Point(0, 0);
            searchInputPanel.Name = "searchInputPanel";
            searchInputPanel.Size = new Size(297, 35);
            searchInputPanel.TabIndex = 0;
            this.searchInputPanel.Controls.Add(this.searchTextBox);
            this.searchInputPanel.Controls.Add(this.searchButtonPanel);
            this.searchInputPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchInputPanel.Location = new System.Drawing.Point(0, 0);
            this.searchInputPanel.Name = "searchInputPanel";
            this.searchInputPanel.Size = new System.Drawing.Size(294, 35);
            this.searchInputPanel.TabIndex = 0;
            // 
            // searchTextBox
            // 
            searchTextBox.BorderStyle = BorderStyle.FixedSingle;
            searchTextBox.Dock = DockStyle.Fill;
            searchTextBox.Enabled = false;
            searchTextBox.Location = new Point(0, 0);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(262, 35);
            searchTextBox.TabIndex = 6;
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTextBox.Location = new System.Drawing.Point(0, 0);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(259, 35);
            this.searchTextBox.TabIndex = 6;
            // 
            // searchButtonPanel
            // 
            searchButtonPanel.Controls.Add(searchButton);
            searchButtonPanel.Dock = DockStyle.Right;
            searchButtonPanel.Location = new Point(262, 0);
            searchButtonPanel.Name = "searchButtonPanel";
            searchButtonPanel.Size = new Size(35, 35);
            searchButtonPanel.TabIndex = 0;
            this.searchButtonPanel.Controls.Add(this.searchButton);
            this.searchButtonPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchButtonPanel.Location = new System.Drawing.Point(259, 0);
            this.searchButtonPanel.Name = "searchButtonPanel";
            this.searchButtonPanel.Size = new System.Drawing.Size(35, 35);
            this.searchButtonPanel.TabIndex = 0;
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            searchButton.BackColor = Color.White;
            searchButton.Enabled = false;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Image = (Image)resources.GetObject("searchButton.Image");
            searchButton.Location = new Point(0, 0);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(35, 35);
            searchButton.TabIndex = 0;
            searchButton.UseVisualStyleBackColor = false;
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
            // searchProductSubMenuButton
            // 
            searchProductSubMenuButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            searchProductSubMenuButton.BackColor = Color.FromArgb(28, 44, 78);
            searchProductSubMenuButton.Dock = DockStyle.Top;
            searchProductSubMenuButton.FlatAppearance.BorderColor = Color.FromArgb(28, 44, 78);
            searchProductSubMenuButton.FlatAppearance.BorderSize = 0;
            searchProductSubMenuButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(227, 211, 177);
            searchProductSubMenuButton.FlatStyle = FlatStyle.Flat;
            searchProductSubMenuButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            searchProductSubMenuButton.ForeColor = Color.FromArgb(252, 251, 255);
            searchProductSubMenuButton.ImageAlign = ContentAlignment.MiddleLeft;
            searchProductSubMenuButton.Location = new Point(0, 138);
            searchProductSubMenuButton.Name = "searchProductSubMenuButton";
            searchProductSubMenuButton.Padding = new Padding(2, 0, 0, 0);
            searchProductSubMenuButton.Size = new Size(201, 44);
            searchProductSubMenuButton.TabIndex = 5;
            searchProductSubMenuButton.Text = "Search Product";
            searchProductSubMenuButton.TextAlign = ContentAlignment.BottomRight;
            searchProductSubMenuButton.UseVisualStyleBackColor = false;
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