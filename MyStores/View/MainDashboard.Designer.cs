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
            mainContainer.Dock = DockStyle.Fill;
            mainContainer.Location = new Point(0, 0);
            mainContainer.Margin = new Padding(6);
            mainContainer.Name = "mainContainer";
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
            mainContainer.Panel2.Controls.Add(workspaceContainer);
            mainContainer.Size = new Size(3536, 2221);
            mainContainer.SplitterDistance = 388;
            mainContainer.SplitterWidth = 2;
            mainContainer.TabIndex = 0;
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.logoutButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.logoutButton.Image = ((System.Drawing.Image)(resources.GetObject("logoutButton.Image")));
            this.logoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.Location = new System.Drawing.Point(3, 960);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.logoutButton.Size = new System.Drawing.Size(201, 69);
            this.logoutButton.TabIndex = 7;
            this.logoutButton.Text = "Logout";
            this.logoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            this.logoutButton.MouseEnter += new System.EventHandler(this.logoutButton_MouseEnter);
            this.logoutButton.MouseLeave += new System.EventHandler(this.logoutButton_MouseLeave);
            // 
            // navigationPanel
            // 
            this.navigationPanel.AutoScroll = true;
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
            this.addVendorSubMenuButton.Location = new System.Drawing.Point(0, 295);
            this.addVendorSubMenuButton.Name = "addVendorSubMenuButton";
            this.addVendorSubMenuButton.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.addVendorSubMenuButton.Size = new System.Drawing.Size(201, 44);
            this.addVendorSubMenuButton.TabIndex = 9;
            this.addVendorSubMenuButton.Text = "Add Vendor";
            this.addVendorSubMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addVendorSubMenuButton.UseVisualStyleBackColor = false;
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
            this.searchVendorSubMenuButton.Location = new System.Drawing.Point(0, 251);
            this.searchVendorSubMenuButton.Name = "searchVendorSubMenuButton";
            this.searchVendorSubMenuButton.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.searchVendorSubMenuButton.Size = new System.Drawing.Size(201, 44);
            this.searchVendorSubMenuButton.TabIndex = 8;
            this.searchVendorSubMenuButton.Text = "Search Vendor";
            this.searchVendorSubMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchVendorSubMenuButton.UseVisualStyleBackColor = false;
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
            this.vendorsMenuButton.Location = new System.Drawing.Point(0, 182);
            this.vendorsMenuButton.Name = "vendorsMenuButton";
            this.vendorsMenuButton.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.vendorsMenuButton.Size = new System.Drawing.Size(201, 69);
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
            this.addProductSubMenuButton.Name = "addProductSubMenuButton";
            this.addProductSubMenuButton.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.addProductSubMenuButton.Size = new System.Drawing.Size(201, 44);
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
            this.productsMenuButton.Name = "productsMenuButton";
            this.productsMenuButton.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
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
            this.homeMenuButton.Name = "homeMenuButton";
            this.homeMenuButton.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
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
            logoPanel.Location = new Point(6, 6);
            logoPanel.Margin = new Padding(6);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(373, 292);
            logoPanel.TabIndex = 0;
            // 
            // workspaceContainer
            // 
            workspaceContainer.Dock = DockStyle.Fill;
            workspaceContainer.Location = new Point(0, 0);
            workspaceContainer.Margin = new Padding(6);
            workspaceContainer.Name = "workspaceContainer";
            // 
            // workspaceContainer.Panel1
            // 
            workspaceContainer.Panel1.Controls.Add(storeContainer);
            // 
            // workspaceContainer.Panel2
            // 
            workspaceContainer.Panel2.BackColor = Color.FromArgb(28, 44, 78);
            workspaceContainer.Panel2.Controls.Add(searchPanel);
            workspaceContainer.Panel2.Controls.Add(windowOpPanel);
            workspaceContainer.Panel2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            workspaceContainer.Size = new Size(3146, 2221);
            workspaceContainer.SplitterDistance = 2587;
            workspaceContainer.SplitterWidth = 2;
            workspaceContainer.TabIndex = 0;
            // 
            // storeContainer
            // 
            storeContainer.Dock = DockStyle.Fill;
            storeContainer.Location = new Point(0, 0);
            storeContainer.Margin = new Padding(6);
            storeContainer.Name = "storeContainer";
            storeContainer.Orientation = Orientation.Horizontal;
            // 
            // storeContainer.Panel1
            // 
            storeContainer.Panel1.BackColor = Color.DarkSlateGray;
            storeContainer.Panel1.Controls.Add(storeNameLabel);
            // 
            // storeContainer.Panel2
            // 
            storeContainer.Panel2.BackColor = Color.FromArgb(227, 211, 177);
            storeContainer.Panel2.Controls.Add(mainHomeTabUserControl);
            storeContainer.Size = new Size(2587, 2221);
            storeContainer.SplitterDistance = 298;
            storeContainer.SplitterWidth = 2;
            storeContainer.TabIndex = 0;
            // 
            // storeNameLabel
            // 
            storeNameLabel.Font = new Font("Segoe UI", 33F, FontStyle.Bold, GraphicsUnit.Point);
            storeNameLabel.ForeColor = SystemColors.ButtonHighlight;
            storeNameLabel.Location = new Point(6, 49);
            storeNameLabel.Margin = new Padding(6, 0, 6, 0);
            storeNameLabel.Name = "storeNameLabel";
            storeNameLabel.Size = new Size(2581, 145);
            storeNameLabel.TabIndex = 0;
            storeNameLabel.Text = "Store Name";
            storeNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mainHomeTabUserControl
            // 
            this.mainHomeTabUserControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainHomeTabUserControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.mainHomeTabUserControl.Location = new System.Drawing.Point(0, 0);
            this.mainHomeTabUserControl.Name = "mainHomeTabUserControl";
            this.mainHomeTabUserControl.Size = new System.Drawing.Size(1393, 936);
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
            searchButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            searchButton.BackColor = Color.White;
            searchButton.Enabled = false;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Image = (Image)resources.GetObject("searchButton.Image");
            searchButton.Location = new Point(0, 0);
            searchButton.Margin = new Padding(6);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(65, 75);
            searchButton.TabIndex = 0;
            searchButton.UseVisualStyleBackColor = false;
            // 
            // windowOpPanel
            // 
            windowOpPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            windowOpPanel.Controls.Add(minPanel);
            windowOpPanel.Controls.Add(maxPanel);
            windowOpPanel.Controls.Add(closePanel);
            windowOpPanel.Dock = DockStyle.Top;
            windowOpPanel.Location = new Point(0, 0);
            windowOpPanel.Margin = new Padding(6);
            windowOpPanel.Name = "windowOpPanel";
            windowOpPanel.Size = new Size(557, 96);
            windowOpPanel.TabIndex = 5;
            // 
            // minPanel
            // 
            minPanel.Controls.Add(minButton);
            minPanel.Dock = DockStyle.Right;
            minPanel.Location = new Point(315, 0);
            minPanel.Margin = new Padding(6);
            minPanel.Name = "minPanel";
            minPanel.Size = new Size(80, 96);
            minPanel.TabIndex = 4;
            // 
            // minButton
            // 
            minButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            minButton.BackColor = Color.FromArgb(252, 251, 255);
            minButton.Dock = DockStyle.Right;
            minButton.FlatAppearance.BorderColor = Color.FromArgb(28, 44, 78);
            minButton.FlatAppearance.BorderSize = 0;
            minButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(227, 211, 177);
            minButton.FlatStyle = FlatStyle.Flat;
            minButton.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            minButton.ForeColor = Color.FromArgb(252, 251, 255);
            minButton.Image = (Image)resources.GetObject("minButton.Image");
            minButton.ImageAlign = ContentAlignment.MiddleLeft;
            minButton.Location = new Point(-13, 0);
            minButton.Margin = new Padding(6);
            minButton.Name = "minButton";
            minButton.Size = new Size(93, 96);
            minButton.TabIndex = 3;
            minButton.TextAlign = ContentAlignment.BottomCenter;
            minButton.UseVisualStyleBackColor = false;
            minButton.Click += minButton_Click;
            // 
            // maxPanel
            // 
            maxPanel.Controls.Add(restoreButton);
            maxPanel.Controls.Add(maxButton);
            maxPanel.Dock = DockStyle.Right;
            maxPanel.Location = new Point(395, 0);
            maxPanel.Margin = new Padding(6);
            maxPanel.Name = "maxPanel";
            maxPanel.Size = new Size(82, 96);
            maxPanel.TabIndex = 0;
            // 
            // restoreButton
            // 
            restoreButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            restoreButton.BackColor = Color.FromArgb(252, 251, 255);
            restoreButton.Dock = DockStyle.Right;
            restoreButton.FlatAppearance.BorderColor = Color.FromArgb(28, 44, 78);
            restoreButton.FlatAppearance.BorderSize = 0;
            restoreButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(227, 211, 177);
            restoreButton.FlatStyle = FlatStyle.Flat;
            restoreButton.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            restoreButton.ForeColor = Color.FromArgb(252, 251, 255);
            restoreButton.Image = (Image)resources.GetObject("restoreButton.Image");
            restoreButton.ImageAlign = ContentAlignment.MiddleLeft;
            restoreButton.Location = new Point(-104, 0);
            restoreButton.Margin = new Padding(6);
            restoreButton.Name = "restoreButton";
            restoreButton.Size = new Size(93, 96);
            restoreButton.TabIndex = 4;
            restoreButton.TextAlign = ContentAlignment.BottomCenter;
            restoreButton.UseVisualStyleBackColor = false;
            restoreButton.Click += restoreButton_Click;
            // 
            // maxButton
            // 
            maxButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            maxButton.BackColor = Color.FromArgb(252, 251, 255);
            maxButton.Dock = DockStyle.Right;
            maxButton.FlatAppearance.BorderColor = Color.FromArgb(28, 44, 78);
            maxButton.FlatAppearance.BorderSize = 0;
            maxButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(227, 211, 177);
            maxButton.FlatStyle = FlatStyle.Flat;
            maxButton.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            maxButton.ForeColor = Color.FromArgb(252, 251, 255);
            maxButton.Image = (Image)resources.GetObject("maxButton.Image");
            maxButton.ImageAlign = ContentAlignment.MiddleLeft;
            maxButton.Location = new Point(-11, 0);
            maxButton.Margin = new Padding(6);
            maxButton.Name = "maxButton";
            maxButton.Size = new Size(93, 96);
            maxButton.TabIndex = 3;
            maxButton.TextAlign = ContentAlignment.BottomCenter;
            maxButton.UseVisualStyleBackColor = false;
            maxButton.Click += maxButton_Click;
            // 
            // closePanel
            // 
            closePanel.Controls.Add(closeButton);
            closePanel.Dock = DockStyle.Right;
            closePanel.Location = new Point(477, 0);
            closePanel.Margin = new Padding(6);
            closePanel.Name = "closePanel";
            closePanel.Size = new Size(80, 96);
            closePanel.TabIndex = 4;
            // 
            // closeButton
            // 
            closeButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            closeButton.BackColor = Color.FromArgb(252, 251, 255);
            closeButton.Dock = DockStyle.Right;
            closeButton.FlatAppearance.BorderColor = Color.FromArgb(28, 44, 78);
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(227, 211, 177);
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            closeButton.ForeColor = Color.FromArgb(252, 251, 255);
            closeButton.Image = (Image)resources.GetObject("closeButton.Image");
            closeButton.ImageAlign = ContentAlignment.MiddleLeft;
            closeButton.Location = new Point(-13, 0);
            closeButton.Margin = new Padding(6);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(93, 96);
            closeButton.TabIndex = 3;
            closeButton.TextAlign = ContentAlignment.BottomCenter;
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += CloseButton_Click;
            // 
            // MainDashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(3536, 2221);
            Controls.Add(mainContainer);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "MainDashboard";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyStores";
            Load += MainDashboard_Load;
            mainContainer.Panel1.ResumeLayout(false);
            mainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainContainer).EndInit();
            mainContainer.ResumeLayout(false);
            navigationPanel.ResumeLayout(false);
            workspaceContainer.Panel1.ResumeLayout(false);
            workspaceContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)workspaceContainer).EndInit();
            workspaceContainer.ResumeLayout(false);
            storeContainer.Panel1.ResumeLayout(false);
            storeContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)storeContainer).EndInit();
            storeContainer.ResumeLayout(false);
            searchPanel.ResumeLayout(false);
            searchInputPanel.ResumeLayout(false);
            searchInputPanel.PerformLayout();
            searchButtonPanel.ResumeLayout(false);
            windowOpPanel.ResumeLayout(false);
            minPanel.ResumeLayout(false);
            maxPanel.ResumeLayout(false);
            closePanel.ResumeLayout(false);
            ResumeLayout(false);
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
    }
}