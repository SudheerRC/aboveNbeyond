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
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.addVendorSubMenuButton = new System.Windows.Forms.Button();
            this.searchVendorSubMenuButton = new System.Windows.Forms.Button();
            this.vendorsMenuButton = new System.Windows.Forms.Button();
            this.addProductSubMenuButton = new System.Windows.Forms.Button();
            this.productsMenuButton = new System.Windows.Forms.Button();
            this.homeMenuButton = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.storeNameLabel = new System.Windows.Forms.Label();
            this.mainHomeTabUserControl = new MyStores.UserControls.HomeUserControl.HomeTabUserControl();
            this.mainAddVendorUserControl = new MyStores.UserControls.AddVendorUserControl();
            this.mainVendorTabUserControl = new MyStores.UserControls.VendorTabUserControl();
            this.mainProductsTabUserControl = new MyStores.UserControls.ProductsTabUserControl();
            this.windowOpPanel = new System.Windows.Forms.Panel();
            this.minPanel = new System.Windows.Forms.Panel();
            this.minButton = new System.Windows.Forms.Button();
            this.closePanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.globalSearchUserControl = new MyStores.UserControls.GlobalSearchUserControl();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.navigationPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.windowOpPanel.SuspendLayout();
            this.minPanel.SuspendLayout();
            this.closePanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPanel
            // 
            this.navigationPanel.AutoScroll = true;
            this.navigationPanel.Controls.Add(this.logoutButton);
            this.navigationPanel.Controls.Add(this.addVendorSubMenuButton);
            this.navigationPanel.Controls.Add(this.searchVendorSubMenuButton);
            this.navigationPanel.Controls.Add(this.vendorsMenuButton);
            this.navigationPanel.Controls.Add(this.addProductSubMenuButton);
            this.navigationPanel.Controls.Add(this.productsMenuButton);
            this.navigationPanel.Controls.Add(this.homeMenuButton);
            this.navigationPanel.Location = new System.Drawing.Point(5, 132);
            this.navigationPanel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(149, 595);
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
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.logoutButton.Image = ((System.Drawing.Image)(resources.GetObject("logoutButton.Image")));
            this.logoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.Location = new System.Drawing.Point(0, 540);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.logoutButton.Size = new System.Drawing.Size(149, 55);
            this.logoutButton.TabIndex = 7;
            this.logoutButton.Text = "Logout";
            this.logoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // addVendorSubMenuButton
            // 
            this.addVendorSubMenuButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addVendorSubMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.addVendorSubMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addVendorSubMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.addVendorSubMenuButton.FlatAppearance.BorderSize = 0;
            this.addVendorSubMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addVendorSubMenuButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addVendorSubMenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.addVendorSubMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addVendorSubMenuButton.Location = new System.Drawing.Point(0, 231);
            this.addVendorSubMenuButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.addVendorSubMenuButton.Name = "addVendorSubMenuButton";
            this.addVendorSubMenuButton.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.addVendorSubMenuButton.Size = new System.Drawing.Size(149, 33);
            this.addVendorSubMenuButton.TabIndex = 9;
            this.addVendorSubMenuButton.Text = "Add Vendor";
            this.addVendorSubMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addVendorSubMenuButton.UseVisualStyleBackColor = false;
            this.addVendorSubMenuButton.Click += new System.EventHandler(this.addVendorSubMenuButton_Click);
            // 
            // searchVendorSubMenuButton
            // 
            this.searchVendorSubMenuButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchVendorSubMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.searchVendorSubMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchVendorSubMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.searchVendorSubMenuButton.FlatAppearance.BorderSize = 0;
            this.searchVendorSubMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchVendorSubMenuButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchVendorSubMenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.searchVendorSubMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchVendorSubMenuButton.Location = new System.Drawing.Point(0, 198);
            this.searchVendorSubMenuButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.searchVendorSubMenuButton.Name = "searchVendorSubMenuButton";
            this.searchVendorSubMenuButton.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.searchVendorSubMenuButton.Size = new System.Drawing.Size(149, 33);
            this.searchVendorSubMenuButton.TabIndex = 8;
            this.searchVendorSubMenuButton.Text = "Search Vendor";
            this.searchVendorSubMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchVendorSubMenuButton.UseVisualStyleBackColor = false;
            this.searchVendorSubMenuButton.Click += new System.EventHandler(this.searchVendorSubMenuButton_Click);
            // 
            // vendorsMenuButton
            // 
            this.vendorsMenuButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.vendorsMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.vendorsMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.vendorsMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.vendorsMenuButton.FlatAppearance.BorderSize = 0;
            this.vendorsMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vendorsMenuButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vendorsMenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.vendorsMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("vendorsMenuButton.Image")));
            this.vendorsMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vendorsMenuButton.Location = new System.Drawing.Point(0, 143);
            this.vendorsMenuButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.vendorsMenuButton.Name = "vendorsMenuButton";
            this.vendorsMenuButton.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.vendorsMenuButton.Size = new System.Drawing.Size(149, 55);
            this.vendorsMenuButton.TabIndex = 7;
            this.vendorsMenuButton.Text = "Vendors";
            this.vendorsMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.vendorsMenuButton.UseVisualStyleBackColor = false;
            this.vendorsMenuButton.Click += new System.EventHandler(this.vendorsMenuButton_Click);
            // 
            // addProductSubMenuButton
            // 
            this.addProductSubMenuButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addProductSubMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.addProductSubMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addProductSubMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.addProductSubMenuButton.FlatAppearance.BorderSize = 0;
            this.addProductSubMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductSubMenuButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addProductSubMenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.addProductSubMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addProductSubMenuButton.Location = new System.Drawing.Point(0, 110);
            this.addProductSubMenuButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.addProductSubMenuButton.Name = "addProductSubMenuButton";
            this.addProductSubMenuButton.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.addProductSubMenuButton.Size = new System.Drawing.Size(149, 33);
            this.addProductSubMenuButton.TabIndex = 4;
            this.addProductSubMenuButton.Text = "Add Product";
            this.addProductSubMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addProductSubMenuButton.UseVisualStyleBackColor = false;
            this.addProductSubMenuButton.Click += new System.EventHandler(this.addProductSubMenuButton_Click);
            // 
            // productsMenuButton
            // 
            this.productsMenuButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.productsMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.productsMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.productsMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.productsMenuButton.FlatAppearance.BorderSize = 0;
            this.productsMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsMenuButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productsMenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.productsMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("productsMenuButton.Image")));
            this.productsMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productsMenuButton.Location = new System.Drawing.Point(0, 55);
            this.productsMenuButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.productsMenuButton.Name = "productsMenuButton";
            this.productsMenuButton.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.productsMenuButton.Size = new System.Drawing.Size(149, 55);
            this.productsMenuButton.TabIndex = 3;
            this.productsMenuButton.Text = "Products";
            this.productsMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.productsMenuButton.UseVisualStyleBackColor = false;
            this.productsMenuButton.Click += new System.EventHandler(this.productsMenuButton_Click);
            // 
            // homeMenuButton
            // 
            this.homeMenuButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.homeMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.homeMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.homeMenuButton.FlatAppearance.BorderSize = 0;
            this.homeMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeMenuButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.homeMenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.homeMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("homeMenuButton.Image")));
            this.homeMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeMenuButton.Location = new System.Drawing.Point(0, 0);
            this.homeMenuButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.homeMenuButton.Name = "homeMenuButton";
            this.homeMenuButton.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.homeMenuButton.Size = new System.Drawing.Size(149, 55);
            this.homeMenuButton.TabIndex = 2;
            this.homeMenuButton.Text = "Store";
            this.homeMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homeMenuButton.UseVisualStyleBackColor = false;
            // 
            // logoPanel
            // 
            this.logoPanel.Controls.Add(this.userNameLabel);
            this.logoPanel.Location = new System.Drawing.Point(5, 4);
            this.logoPanel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(149, 123);
            this.logoPanel.TabIndex = 0;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userNameLabel.Location = new System.Drawing.Point(29, 41);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(63, 28);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "label1";
            // 
            // storeNameLabel
            // 
            this.storeNameLabel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.storeNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.storeNameLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.storeNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.storeNameLabel.Location = new System.Drawing.Point(0, 0);
            this.storeNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.storeNameLabel.Name = "storeNameLabel";
            this.storeNameLabel.Size = new System.Drawing.Size(922, 85);
            this.storeNameLabel.TabIndex = 0;
            this.storeNameLabel.Text = "MyStores";
            this.storeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainHomeTabUserControl
            // 
            this.mainHomeTabUserControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.mainHomeTabUserControl.Location = new System.Drawing.Point(2, 1);
            this.mainHomeTabUserControl.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.mainHomeTabUserControl.Name = "mainHomeTabUserControl";
            this.mainHomeTabUserControl.Size = new System.Drawing.Size(869, 1221);
            this.mainHomeTabUserControl.TabIndex = 0;
            // 
            // mainAddVendorUserControl
            // 
            this.mainAddVendorUserControl.AutoScroll = true;
            this.mainAddVendorUserControl.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.mainAddVendorUserControl.Location = new System.Drawing.Point(237, 5);
            this.mainAddVendorUserControl.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.mainAddVendorUserControl.Name = "mainAddVendorUserControl";
            this.mainAddVendorUserControl.Size = new System.Drawing.Size(416, 801);
            this.mainAddVendorUserControl.TabIndex = 3;
            // 
            // mainVendorTabUserControl
            // 
            this.mainVendorTabUserControl.AutoScroll = true;
            this.mainVendorTabUserControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.mainVendorTabUserControl.Location = new System.Drawing.Point(2, 1);
            this.mainVendorTabUserControl.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.mainVendorTabUserControl.Name = "mainVendorTabUserControl";
            this.mainVendorTabUserControl.Size = new System.Drawing.Size(869, 6149);
            this.mainVendorTabUserControl.TabIndex = 2;
            // 
            // mainProductsTabUserControl
            // 
            this.mainProductsTabUserControl.AutoScroll = true;
            this.mainProductsTabUserControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.mainProductsTabUserControl.Location = new System.Drawing.Point(162, 5);
            this.mainProductsTabUserControl.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.mainProductsTabUserControl.Name = "mainProductsTabUserControl";
            this.mainProductsTabUserControl.Size = new System.Drawing.Size(760, 38546);
            this.mainProductsTabUserControl.TabIndex = 1;
            // 
            // windowOpPanel
            // 
            this.windowOpPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.windowOpPanel.Controls.Add(this.minPanel);
            this.windowOpPanel.Controls.Add(this.closePanel);
            this.windowOpPanel.Location = new System.Drawing.Point(69, 2);
            this.windowOpPanel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.windowOpPanel.Name = "windowOpPanel";
            this.windowOpPanel.Size = new System.Drawing.Size(160, 43);
            this.windowOpPanel.TabIndex = 5;
            // 
            // minPanel
            // 
            this.minPanel.Controls.Add(this.minButton);
            this.minPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.minPanel.Location = new System.Drawing.Point(62, 0);
            this.minPanel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.minPanel.Name = "minPanel";
            this.minPanel.Size = new System.Drawing.Size(49, 43);
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
            this.minButton.Location = new System.Drawing.Point(-8, 0);
            this.minButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(57, 43);
            this.minButton.TabIndex = 3;
            this.minButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.minButton.UseVisualStyleBackColor = false;
            this.minButton.Click += new System.EventHandler(this.minButton_Click);
            // 
            // closePanel
            // 
            this.closePanel.Controls.Add(this.closeButton);
            this.closePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.closePanel.Location = new System.Drawing.Point(111, 0);
            this.closePanel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.closePanel.Name = "closePanel";
            this.closePanel.Size = new System.Drawing.Size(49, 43);
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
            this.closeButton.Location = new System.Drawing.Point(-8, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(57, 43);
            this.closeButton.TabIndex = 3;
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.mainPanel.Controls.Add(this.mainProductsTabUserControl);
            this.mainPanel.Controls.Add(this.mainVendorTabUserControl);
            this.mainPanel.Controls.Add(this.mainAddVendorUserControl);
            this.mainPanel.Controls.Add(this.mainHomeTabUserControl);
            this.mainPanel.Location = new System.Drawing.Point(158, 85);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(922, 678);
            this.mainPanel.TabIndex = 4;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.rightPanel.Controls.Add(this.globalSearchUserControl);
            this.rightPanel.Controls.Add(this.windowOpPanel);
            this.rightPanel.Location = new System.Drawing.Point(1080, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(229, 763);
            this.rightPanel.TabIndex = 8;
            // 
            // globalSearchUserControl
            // 
            this.globalSearchUserControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.globalSearchUserControl.CategoryId = 0;
            this.globalSearchUserControl.CategoryName = null;
            this.globalSearchUserControl.Location = new System.Drawing.Point(2, 86);
            this.globalSearchUserControl.Margin = new System.Windows.Forms.Padding(1);
            this.globalSearchUserControl.Name = "globalSearchUserControl";
            this.globalSearchUserControl.Size = new System.Drawing.Size(229, 677);
            this.globalSearchUserControl.TabIndex = 6;
            globalSearchUserControl.OnUpdateStatus += GlobalSearchUserControl_OnUpdateStatus;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.leftPanel.Controls.Add(this.navigationPanel);
            this.leftPanel.Controls.Add(this.logoPanel);
            this.leftPanel.Location = new System.Drawing.Point(0, -2);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(158, 765);
            this.leftPanel.TabIndex = 9;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.headerPanel.Controls.Add(this.storeNameLabel);
            this.headerPanel.Location = new System.Drawing.Point(158, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(922, 85);
            this.headerPanel.TabIndex = 9;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1309, 762);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MainDashboard";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyStores";
            this.Load += new System.EventHandler(this.MainDashboard_Load);
            this.navigationPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            this.windowOpPanel.ResumeLayout(false);
            this.minPanel.ResumeLayout(false);
            this.closePanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Label storeNameLabel;
        private Panel logoPanel;
        private Button homeMenuButton;
        private Panel navigationPanel;
        private Panel windowOpPanel;
        private Panel minPanel;
        private Button minButton;
        private Panel closePanel;
        private Button closeButton;
        private Button logoutButton;
        private Button addVendorSubMenuButton;
        private Button searchVendorSubMenuButton;
        private Button vendorsMenuButton;
        private Button addProductSubMenuButton;
        private Button productsMenuButton;
        private UserControls.HomeUserControl.HomeTabUserControl mainHomeTabUserControl;
        private UserControls.VendorTabUserControl mainVendorTabUserControl;
        private UserControls.ProductsTabUserControl mainProductsTabUserControl;
        private UserControls.AddVendorUserControl mainAddVendorUserControl;
        private Panel mainPanel;
        private Panel rightPanel;
        private Panel leftPanel;
        private Panel headerPanel;
        private UserControls.GlobalSearchUserControl globalSearchUserControl;
        private Label userNameLabel;
    }
}