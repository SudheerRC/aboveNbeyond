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
            navigationPanel = new Panel();
            logoutButton = new Button();
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
            mainAddVendorUserControl = new UserControls.AddVendorUserControl();
            mainVendorTabUserControl = new UserControls.VendorTabUserControl();
            mainProductsTabUserControl = new UserControls.ProductsTabUserControl();
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
            mainContainer.Dock = DockStyle.Fill;
            mainContainer.Location = new Point(0, 0);
            mainContainer.Margin = new Padding(4);
            mainContainer.Name = "mainContainer";
            // 
            // mainContainer.Panel1
            // 
            mainContainer.Panel1.AutoScroll = true;
            mainContainer.Panel1.BackColor = Color.FromArgb(28, 44, 78);
            mainContainer.Panel1.Controls.Add(navigationPanel);
            mainContainer.Panel1.Controls.Add(logoPanel);
            mainContainer.Panel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // mainContainer.Panel2
            // 
            mainContainer.Panel2.Controls.Add(workspaceContainer);
            mainContainer.Size = new Size(1195, 689);
            mainContainer.SplitterDistance = 129;
            mainContainer.SplitterWidth = 1;
            mainContainer.TabIndex = 0;
            // 
            // navigationPanel
            // 
            navigationPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            navigationPanel.AutoScroll = true;
            navigationPanel.Controls.Add(logoutButton);
            navigationPanel.Controls.Add(addVendorSubMenuButton);
            navigationPanel.Controls.Add(searchVendorSubMenuButton);
            navigationPanel.Controls.Add(vendorsMenuButton);
            navigationPanel.Controls.Add(addProductSubMenuButton);
            navigationPanel.Controls.Add(productsMenuButton);
            navigationPanel.Controls.Add(homeMenuButton);
            navigationPanel.Location = new Point(4, 181);
            navigationPanel.Margin = new Padding(2, 1, 2, 1);
            navigationPanel.Name = "navigationPanel";
            navigationPanel.Size = new Size(120, 436);
            navigationPanel.TabIndex = 2;
            // 
            // logoutButton
            // 
            logoutButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            logoutButton.BackColor = Color.FromArgb(28, 44, 78);
            logoutButton.Dock = DockStyle.Bottom;
            logoutButton.FlatAppearance.BorderColor = Color.FromArgb(28, 44, 78);
            logoutButton.FlatAppearance.BorderSize = 0;
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            logoutButton.ForeColor = Color.FromArgb(252, 251, 255);
            logoutButton.Image = (Image)resources.GetObject("logoutButton.Image");
            logoutButton.ImageAlign = ContentAlignment.MiddleLeft;
            logoutButton.Location = new Point(0, 381);
            logoutButton.Margin = new Padding(2, 1, 2, 1);
            logoutButton.Name = "logoutButton";
            logoutButton.Padding = new Padding(1, 0, 0, 0);
            logoutButton.Size = new Size(120, 55);
            logoutButton.TabIndex = 7;
            logoutButton.Text = "Logout";
            logoutButton.TextAlign = ContentAlignment.MiddleRight;
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += LogoutButton_Click;
            logoutButton.MouseEnter += logoutButton_MouseEnter;
            logoutButton.MouseLeave += logoutButton_MouseLeave;
            // 
            // addVendorSubMenuButton
            // 
            addVendorSubMenuButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addVendorSubMenuButton.BackColor = Color.FromArgb(28, 44, 78);
            addVendorSubMenuButton.Dock = DockStyle.Top;
            addVendorSubMenuButton.FlatAppearance.BorderColor = Color.FromArgb(28, 44, 78);
            addVendorSubMenuButton.FlatAppearance.BorderSize = 0;
            addVendorSubMenuButton.FlatStyle = FlatStyle.Flat;
            addVendorSubMenuButton.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            addVendorSubMenuButton.ForeColor = Color.FromArgb(252, 251, 255);
            addVendorSubMenuButton.ImageAlign = ContentAlignment.MiddleLeft;
            addVendorSubMenuButton.Location = new Point(0, 231);
            addVendorSubMenuButton.Margin = new Padding(2, 1, 2, 1);
            addVendorSubMenuButton.Name = "addVendorSubMenuButton";
            addVendorSubMenuButton.Padding = new Padding(1, 0, 0, 0);
            addVendorSubMenuButton.Size = new Size(120, 33);
            addVendorSubMenuButton.TabIndex = 9;
            addVendorSubMenuButton.Text = "Add Vendor";
            addVendorSubMenuButton.TextAlign = ContentAlignment.MiddleRight;
            addVendorSubMenuButton.UseVisualStyleBackColor = false;
            addVendorSubMenuButton.Click += addVendorSubMenuButton_Click;
            addVendorSubMenuButton.MouseEnter += addVendorSubMenuButton_MouseEnter;
            addVendorSubMenuButton.MouseLeave += addVendorSubMenuButton_MouseLeave;
            // 
            // searchVendorSubMenuButton
            // 
            searchVendorSubMenuButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            searchVendorSubMenuButton.BackColor = Color.FromArgb(28, 44, 78);
            searchVendorSubMenuButton.Dock = DockStyle.Top;
            searchVendorSubMenuButton.FlatAppearance.BorderColor = Color.FromArgb(28, 44, 78);
            searchVendorSubMenuButton.FlatAppearance.BorderSize = 0;
            searchVendorSubMenuButton.FlatStyle = FlatStyle.Flat;
            searchVendorSubMenuButton.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            searchVendorSubMenuButton.ForeColor = Color.FromArgb(252, 251, 255);
            searchVendorSubMenuButton.ImageAlign = ContentAlignment.MiddleLeft;
            searchVendorSubMenuButton.Location = new Point(0, 198);
            searchVendorSubMenuButton.Margin = new Padding(2, 1, 2, 1);
            searchVendorSubMenuButton.Name = "searchVendorSubMenuButton";
            searchVendorSubMenuButton.Padding = new Padding(1, 0, 0, 0);
            searchVendorSubMenuButton.Size = new Size(120, 33);
            searchVendorSubMenuButton.TabIndex = 8;
            searchVendorSubMenuButton.Text = "Search Vendor";
            searchVendorSubMenuButton.TextAlign = ContentAlignment.MiddleRight;
            searchVendorSubMenuButton.UseVisualStyleBackColor = false;
            searchVendorSubMenuButton.Click += searchVendorSubMenuButton_Click;
            searchVendorSubMenuButton.MouseEnter += searchVendorSubMenuButton_MouseEnter;
            searchVendorSubMenuButton.MouseLeave += searchVendorSubMenuButton_MouseLeave;
            // 
            // vendorsMenuButton
            // 
            vendorsMenuButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            vendorsMenuButton.BackColor = Color.FromArgb(28, 44, 78);
            vendorsMenuButton.Dock = DockStyle.Top;
            vendorsMenuButton.FlatAppearance.BorderColor = Color.FromArgb(28, 44, 78);
            vendorsMenuButton.FlatAppearance.BorderSize = 0;
            vendorsMenuButton.FlatStyle = FlatStyle.Flat;
            vendorsMenuButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            vendorsMenuButton.ForeColor = Color.FromArgb(252, 251, 255);
            vendorsMenuButton.Image = (Image)resources.GetObject("vendorsMenuButton.Image");
            vendorsMenuButton.ImageAlign = ContentAlignment.MiddleLeft;
            vendorsMenuButton.Location = new Point(0, 143);
            vendorsMenuButton.Margin = new Padding(2, 1, 2, 1);
            vendorsMenuButton.Name = "vendorsMenuButton";
            vendorsMenuButton.Padding = new Padding(1, 0, 0, 0);
            vendorsMenuButton.Size = new Size(120, 55);
            vendorsMenuButton.TabIndex = 7;
            vendorsMenuButton.Text = "Vendors";
            vendorsMenuButton.TextAlign = ContentAlignment.MiddleRight;
            vendorsMenuButton.UseVisualStyleBackColor = false;
            vendorsMenuButton.Click += vendorsMenuButton_Click;
            vendorsMenuButton.MouseEnter += vendorsMenuButton_MouseEnter;
            vendorsMenuButton.MouseLeave += vendorsMenuButton_MouseLeave;
            // 
            // addProductSubMenuButton
            // 
            addProductSubMenuButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addProductSubMenuButton.BackColor = Color.FromArgb(28, 44, 78);
            addProductSubMenuButton.Dock = DockStyle.Top;
            addProductSubMenuButton.FlatAppearance.BorderColor = Color.FromArgb(28, 44, 78);
            addProductSubMenuButton.FlatAppearance.BorderSize = 0;
            addProductSubMenuButton.FlatStyle = FlatStyle.Flat;
            addProductSubMenuButton.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            addProductSubMenuButton.ForeColor = Color.FromArgb(252, 251, 255);
            addProductSubMenuButton.ImageAlign = ContentAlignment.MiddleLeft;
            addProductSubMenuButton.Location = new Point(0, 110);
            addProductSubMenuButton.Margin = new Padding(2, 1, 2, 1);
            addProductSubMenuButton.Name = "addProductSubMenuButton";
            addProductSubMenuButton.Padding = new Padding(1, 0, 0, 0);
            addProductSubMenuButton.Size = new Size(120, 33);
            addProductSubMenuButton.TabIndex = 4;
            addProductSubMenuButton.Text = "Add Product";
            addProductSubMenuButton.TextAlign = ContentAlignment.MiddleRight;
            addProductSubMenuButton.UseVisualStyleBackColor = false;
            addProductSubMenuButton.Click += addProductSubMenuButton_Click;
            addProductSubMenuButton.MouseEnter += addProductSubMenuButton_MouseEnter;
            addProductSubMenuButton.MouseLeave += addProductSubMenuButton_MouseLeave;
            // 
            // productsMenuButton
            // 
            productsMenuButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            productsMenuButton.BackColor = Color.FromArgb(28, 44, 78);
            productsMenuButton.Dock = DockStyle.Top;
            productsMenuButton.FlatAppearance.BorderColor = Color.FromArgb(28, 44, 78);
            productsMenuButton.FlatAppearance.BorderSize = 0;
            productsMenuButton.FlatStyle = FlatStyle.Flat;
            productsMenuButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            productsMenuButton.ForeColor = Color.FromArgb(252, 251, 255);
            productsMenuButton.Image = (Image)resources.GetObject("productsMenuButton.Image");
            productsMenuButton.ImageAlign = ContentAlignment.MiddleLeft;
            productsMenuButton.Location = new Point(0, 55);
            productsMenuButton.Margin = new Padding(2, 1, 2, 1);
            productsMenuButton.Name = "productsMenuButton";
            productsMenuButton.Padding = new Padding(1, 0, 0, 0);
            productsMenuButton.Size = new Size(120, 55);
            productsMenuButton.TabIndex = 3;
            productsMenuButton.Text = "Products";
            productsMenuButton.TextAlign = ContentAlignment.MiddleRight;
            productsMenuButton.UseVisualStyleBackColor = false;
            productsMenuButton.Click += productsMenuButton_Click;
            productsMenuButton.MouseEnter += productsMenuButton_MouseEnter;
            productsMenuButton.MouseLeave += productsMenuButton_MouseLeave;
            // 
            // homeMenuButton
            // 
            homeMenuButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            homeMenuButton.BackColor = Color.FromArgb(28, 44, 78);
            homeMenuButton.Dock = DockStyle.Top;
            homeMenuButton.FlatAppearance.BorderColor = Color.FromArgb(28, 44, 78);
            homeMenuButton.FlatAppearance.BorderSize = 0;
            homeMenuButton.FlatStyle = FlatStyle.Flat;
            homeMenuButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            homeMenuButton.ForeColor = Color.FromArgb(252, 251, 255);
            homeMenuButton.Image = (Image)resources.GetObject("homeMenuButton.Image");
            homeMenuButton.ImageAlign = ContentAlignment.MiddleLeft;
            homeMenuButton.Location = new Point(0, 0);
            homeMenuButton.Margin = new Padding(2, 1, 2, 1);
            homeMenuButton.Name = "homeMenuButton";
            homeMenuButton.Padding = new Padding(1, 0, 0, 0);
            homeMenuButton.Size = new Size(120, 55);
            homeMenuButton.TabIndex = 2;
            homeMenuButton.Text = "Store";
            homeMenuButton.TextAlign = ContentAlignment.MiddleRight;
            homeMenuButton.UseVisualStyleBackColor = false;
            homeMenuButton.Click += homeMenuButton_Click;
            homeMenuButton.MouseEnter += homeMenuButton_MouseEnter;
            homeMenuButton.MouseLeave += homeMenuButton_MouseLeave;
            // 
            // logoPanel
            // 
            logoPanel.Location = new Point(4, 4);
            logoPanel.Margin = new Padding(4);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(122, 83);
            logoPanel.TabIndex = 0;
            // 
            // workspaceContainer
            // 
            workspaceContainer.Dock = DockStyle.Fill;
            workspaceContainer.Location = new Point(0, 0);
            workspaceContainer.Margin = new Padding(4);
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
            workspaceContainer.Size = new Size(1065, 689);
            workspaceContainer.SplitterDistance = 874;
            workspaceContainer.SplitterWidth = 1;
            workspaceContainer.TabIndex = 0;
            // 
            // storeContainer
            // 
            storeContainer.Dock = DockStyle.Fill;
            storeContainer.Location = new Point(0, 0);
            storeContainer.Margin = new Padding(4);
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
            storeContainer.Panel2.AllowDrop = true;
            storeContainer.Panel2.AutoScroll = true;
            storeContainer.Panel2.BackColor = Color.FromArgb(227, 211, 177);
            storeContainer.Panel2.Controls.Add(mainHomeTabUserControl);
            storeContainer.Panel2.Controls.Add(mainAddVendorUserControl);
            storeContainer.Panel2.Controls.Add(mainVendorTabUserControl);
            storeContainer.Panel2.Controls.Add(mainProductsTabUserControl);
            storeContainer.Size = new Size(874, 689);
            storeContainer.SplitterDistance = 91;
            storeContainer.SplitterWidth = 1;
            storeContainer.TabIndex = 0;
            // 
            // storeNameLabel
            // 
            storeNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            storeNameLabel.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            storeNameLabel.ForeColor = SystemColors.ButtonHighlight;
            storeNameLabel.Location = new Point(4, 4);
            storeNameLabel.Margin = new Padding(4, 0, 4, 0);
            storeNameLabel.Name = "storeNameLabel";
            storeNameLabel.Size = new Size(865, 83);
            storeNameLabel.TabIndex = 0;
            storeNameLabel.Text = "MyStores";
            storeNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mainHomeTabUserControl
            // 
            mainHomeTabUserControl.BackColor = Color.FromArgb(227, 211, 177);
            mainHomeTabUserControl.Location = new Point(2, 0);
            mainHomeTabUserControl.Margin = new Padding(2, 1, 2, 1);
            mainHomeTabUserControl.Name = "mainHomeTabUserControl";
            mainHomeTabUserControl.Size = new Size(869, 1222);
            mainHomeTabUserControl.TabIndex = 0;
            // 
            // mainAddVendorUserControl
            // 
            mainAddVendorUserControl.AutoScroll = true;
            mainAddVendorUserControl.BackColor = Color.BlanchedAlmond;
            mainAddVendorUserControl.Location = new Point(216, 10);
            mainAddVendorUserControl.Margin = new Padding(3, 4, 3, 4);
            mainAddVendorUserControl.Name = "mainAddVendorUserControl";
            mainAddVendorUserControl.Size = new Size(416, 801);
            mainAddVendorUserControl.TabIndex = 3;
            // 
            // mainVendorTabUserControl
            // 
            mainVendorTabUserControl.AutoScroll = true;
            mainVendorTabUserControl.BackColor = Color.FromArgb(227, 211, 177);
            mainVendorTabUserControl.Location = new Point(9, 20);
            mainVendorTabUserControl.Margin = new Padding(7, 8, 7, 8);
            mainVendorTabUserControl.Name = "mainVendorTabUserControl";
            mainVendorTabUserControl.Size = new Size(835, 6149);
            mainVendorTabUserControl.TabIndex = 2;
            // 
            // mainProductsTabUserControl
            // 
            mainProductsTabUserControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainProductsTabUserControl.AutoScroll = true;
            mainProductsTabUserControl.BackColor = Color.FromArgb(227, 211, 177);
            mainProductsTabUserControl.Location = new Point(238, 20);
            mainProductsTabUserControl.Margin = new Padding(7, 8, 7, 8);
            mainProductsTabUserControl.Name = "mainProductsTabUserControl";
            mainProductsTabUserControl.Size = new Size(371, 22252);
            mainProductsTabUserControl.TabIndex = 1;
            // 
            // searchPanel
            // 
            searchPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchPanel.Controls.Add(searchInputPanel);
            searchPanel.Location = new Point(6, 181);
            searchPanel.Margin = new Padding(2, 1, 2, 1);
            searchPanel.Name = "searchPanel";
            searchPanel.Size = new Size(206, 309);
            searchPanel.TabIndex = 7;
            // 
            // searchInputPanel
            // 
            searchInputPanel.Controls.Add(searchTextBox);
            searchInputPanel.Controls.Add(searchButtonPanel);
            searchInputPanel.Dock = DockStyle.Top;
            searchInputPanel.Location = new Point(0, 0);
            searchInputPanel.Margin = new Padding(2, 1, 2, 1);
            searchInputPanel.Name = "searchInputPanel";
            searchInputPanel.Size = new Size(206, 32);
            searchInputPanel.TabIndex = 0;
            // 
            // searchTextBox
            // 
            searchTextBox.BorderStyle = BorderStyle.FixedSingle;
            searchTextBox.Enabled = false;
            searchTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchTextBox.Location = new Point(0, 3);
            searchTextBox.Margin = new Padding(2, 1, 2, 1);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "Coming soon";
            searchTextBox.Size = new Size(142, 27);
            searchTextBox.TabIndex = 6;
            // 
            // searchButtonPanel
            // 
            searchButtonPanel.Controls.Add(searchButton);
            searchButtonPanel.Location = new Point(152, 1);
            searchButtonPanel.Margin = new Padding(2, 1, 2, 1);
            searchButtonPanel.Name = "searchButtonPanel";
            searchButtonPanel.Size = new Size(30, 30);
            searchButtonPanel.TabIndex = 0;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.White;
            searchButton.Enabled = false;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Image = (Image)resources.GetObject("searchButton.Image");
            searchButton.Location = new Point(-4, 1);
            searchButton.Margin = new Padding(4);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(30, 30);
            searchButton.TabIndex = 0;
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // windowOpPanel
            // 
            windowOpPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            windowOpPanel.Controls.Add(minPanel);
            windowOpPanel.Controls.Add(maxPanel);
            windowOpPanel.Controls.Add(closePanel);
            windowOpPanel.Dock = DockStyle.Top;
            windowOpPanel.Location = new Point(0, 0);
            windowOpPanel.Margin = new Padding(4);
            windowOpPanel.Name = "windowOpPanel";
            windowOpPanel.Size = new Size(190, 43);
            windowOpPanel.TabIndex = 5;
            // 
            // minPanel
            // 
            minPanel.Controls.Add(minButton);
            minPanel.Dock = DockStyle.Right;
            minPanel.Location = new Point(92, 0);
            minPanel.Margin = new Padding(4);
            minPanel.Name = "minPanel";
            minPanel.Size = new Size(49, 43);
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
            minButton.Location = new Point(-8, 0);
            minButton.Margin = new Padding(4);
            minButton.Name = "minButton";
            minButton.Size = new Size(57, 43);
            minButton.TabIndex = 3;
            minButton.TextAlign = ContentAlignment.BottomCenter;
            minButton.UseVisualStyleBackColor = false;
            minButton.Click += minButton_Click;
            // 
            // maxPanel
            // 
            maxPanel.Controls.Add(restoreButton);
            maxPanel.Controls.Add(maxButton);
            maxPanel.Location = new Point(252, 0);
            maxPanel.Margin = new Padding(4);
            maxPanel.Name = "maxPanel";
            maxPanel.Size = new Size(47, 60);
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
            restoreButton.Location = new Point(-67, 0);
            restoreButton.Margin = new Padding(4);
            restoreButton.Name = "restoreButton";
            restoreButton.Size = new Size(57, 60);
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
            maxButton.Location = new Point(-10, 0);
            maxButton.Margin = new Padding(4);
            maxButton.Name = "maxButton";
            maxButton.Size = new Size(57, 60);
            maxButton.TabIndex = 3;
            maxButton.TextAlign = ContentAlignment.BottomCenter;
            maxButton.UseVisualStyleBackColor = false;
            maxButton.Click += maxButton_Click;
            // 
            // closePanel
            // 
            closePanel.Controls.Add(closeButton);
            closePanel.Dock = DockStyle.Right;
            closePanel.Location = new Point(141, 0);
            closePanel.Margin = new Padding(4);
            closePanel.Name = "closePanel";
            closePanel.Size = new Size(49, 43);
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
            closeButton.Location = new Point(-8, 0);
            closeButton.Margin = new Padding(4);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(57, 43);
            closeButton.TabIndex = 3;
            closeButton.TextAlign = ContentAlignment.BottomCenter;
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += CloseButton_Click;
            // 
            // MainDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1195, 689);
            Controls.Add(mainContainer);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
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
        private UserControls.VendorTabUserControl mainVendorTabUserControl;
        private UserControls.ProductsTabUserControl mainProductsTabUserControl;
        private UserControls.AddVendorUserControl mainAddVendorUserControl;
    }
}