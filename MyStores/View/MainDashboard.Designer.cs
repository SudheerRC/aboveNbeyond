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
            button5 = new Button();
            navigationPanel = new Panel();
            addVendorSubMenuButton = new Button();
            searchVendorSubMenuButton = new Button();
            searchProductSubMenuButton = new Button();
            vendorsMenuButton = new Button();
            ordersMenuButton = new Button();
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
            mainContainer.Name = "mainContainer";
            // 
            // mainContainer.Panel1
            // 
            mainContainer.Panel1.AutoScroll = true;
            mainContainer.Panel1.BackColor = Color.FromArgb(28, 44, 78);
            mainContainer.Panel1.Controls.Add(button5);
            mainContainer.Panel1.Controls.Add(navigationPanel);
            mainContainer.Panel1.Controls.Add(logoPanel);
            mainContainer.Panel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // mainContainer.Panel2
            // 
            mainContainer.Panel2.Controls.Add(workspaceContainer);
            mainContainer.Size = new Size(1904, 1041);
            mainContainer.SplitterDistance = 209;
            mainContainer.SplitterWidth = 1;
            mainContainer.TabIndex = 0;
            // 
            // button5
            // 
            button5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button5.BackColor = Color.FromArgb(28, 44, 78);
            button5.FlatAppearance.BorderColor = Color.FromArgb(28, 44, 78);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(227, 211, 177);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.FromArgb(252, 251, 255);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 971);
            button5.Name = "button5";
            button5.Padding = new Padding(2, 0, 0, 0);
            button5.Size = new Size(196, 50);
            button5.TabIndex = 7;
            button5.Text = "Logout";
            button5.TextAlign = ContentAlignment.BottomRight;
            button5.UseVisualStyleBackColor = false;
            // 
            // navigationPanel
            // 
            navigationPanel.AutoScroll = true;
            navigationPanel.Controls.Add(addVendorSubMenuButton);
            navigationPanel.Controls.Add(searchVendorSubMenuButton);
            navigationPanel.Controls.Add(searchProductSubMenuButton);
            navigationPanel.Controls.Add(vendorsMenuButton);
            navigationPanel.Controls.Add(ordersMenuButton);
            navigationPanel.Controls.Add(addProductSubMenuButton);
            navigationPanel.Controls.Add(productsMenuButton);
            navigationPanel.Controls.Add(homeMenuButton);
            navigationPanel.Location = new Point(0, 168);
            navigationPanel.Name = "navigationPanel";
            navigationPanel.Size = new Size(196, 576);
            navigationPanel.TabIndex = 2;
            // 
            // addVendorSubMenuButton
            // 
            addVendorSubMenuButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addVendorSubMenuButton.BackColor = Color.FromArgb(28, 44, 78);
            addVendorSubMenuButton.Dock = DockStyle.Top;
            addVendorSubMenuButton.FlatAppearance.BorderColor = Color.FromArgb(28, 44, 78);
            addVendorSubMenuButton.FlatAppearance.BorderSize = 0;
            addVendorSubMenuButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(227, 211, 177);
            addVendorSubMenuButton.FlatStyle = FlatStyle.Flat;
            addVendorSubMenuButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            addVendorSubMenuButton.ForeColor = Color.FromArgb(252, 251, 255);
            addVendorSubMenuButton.ImageAlign = ContentAlignment.MiddleLeft;
            addVendorSubMenuButton.Location = new Point(0, 312);
            addVendorSubMenuButton.Name = "addVendorSubMenuButton";
            addVendorSubMenuButton.Padding = new Padding(2, 0, 0, 0);
            addVendorSubMenuButton.Size = new Size(196, 37);
            addVendorSubMenuButton.TabIndex = 9;
            addVendorSubMenuButton.Text = "Add Vendor";
            addVendorSubMenuButton.TextAlign = ContentAlignment.BottomRight;
            addVendorSubMenuButton.UseVisualStyleBackColor = false;
            // 
            // searchVendorSubMenuButton
            // 
            searchVendorSubMenuButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            searchVendorSubMenuButton.BackColor = Color.FromArgb(28, 44, 78);
            searchVendorSubMenuButton.Dock = DockStyle.Top;
            searchVendorSubMenuButton.FlatAppearance.BorderColor = Color.FromArgb(28, 44, 78);
            searchVendorSubMenuButton.FlatAppearance.BorderSize = 0;
            searchVendorSubMenuButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(227, 211, 177);
            searchVendorSubMenuButton.FlatStyle = FlatStyle.Flat;
            searchVendorSubMenuButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            searchVendorSubMenuButton.ForeColor = Color.FromArgb(252, 251, 255);
            searchVendorSubMenuButton.ImageAlign = ContentAlignment.MiddleLeft;
            searchVendorSubMenuButton.Location = new Point(0, 274);
            searchVendorSubMenuButton.Name = "searchVendorSubMenuButton";
            searchVendorSubMenuButton.Padding = new Padding(2, 0, 0, 0);
            searchVendorSubMenuButton.Size = new Size(196, 38);
            searchVendorSubMenuButton.TabIndex = 8;
            searchVendorSubMenuButton.Text = "Search Vendor";
            searchVendorSubMenuButton.TextAlign = ContentAlignment.BottomRight;
            searchVendorSubMenuButton.UseVisualStyleBackColor = false;
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
            searchProductSubMenuButton.Location = new Point(0, 238);
            searchProductSubMenuButton.Name = "searchProductSubMenuButton";
            searchProductSubMenuButton.Padding = new Padding(2, 0, 0, 0);
            searchProductSubMenuButton.Size = new Size(196, 36);
            searchProductSubMenuButton.TabIndex = 7;
            searchProductSubMenuButton.Text = "Search Product";
            searchProductSubMenuButton.TextAlign = ContentAlignment.BottomRight;
            searchProductSubMenuButton.UseVisualStyleBackColor = false;
            // 
            // vendorsMenuButton
            // 
            vendorsMenuButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            vendorsMenuButton.BackColor = Color.FromArgb(28, 44, 78);
            vendorsMenuButton.Dock = DockStyle.Top;
            vendorsMenuButton.FlatAppearance.BorderColor = Color.FromArgb(28, 44, 78);
            vendorsMenuButton.FlatAppearance.BorderSize = 0;
            vendorsMenuButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(227, 211, 177);
            vendorsMenuButton.FlatStyle = FlatStyle.Flat;
            vendorsMenuButton.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            vendorsMenuButton.ForeColor = Color.FromArgb(252, 251, 255);
            vendorsMenuButton.Image = (Image)resources.GetObject("vendorsMenuButton.Image");
            vendorsMenuButton.ImageAlign = ContentAlignment.MiddleLeft;
            vendorsMenuButton.Location = new Point(0, 188);
            vendorsMenuButton.Name = "vendorsMenuButton";
            vendorsMenuButton.Padding = new Padding(2, 0, 0, 0);
            vendorsMenuButton.Size = new Size(196, 50);
            vendorsMenuButton.TabIndex = 6;
            vendorsMenuButton.Text = "Vendors";
            vendorsMenuButton.TextAlign = ContentAlignment.BottomRight;
            vendorsMenuButton.UseVisualStyleBackColor = false;
            // 
            // ordersMenuButton
            // 
            ordersMenuButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ordersMenuButton.BackColor = Color.FromArgb(28, 44, 78);
            ordersMenuButton.Dock = DockStyle.Top;
            ordersMenuButton.FlatAppearance.BorderColor = Color.FromArgb(28, 44, 78);
            ordersMenuButton.FlatAppearance.BorderSize = 0;
            ordersMenuButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(227, 211, 177);
            ordersMenuButton.FlatStyle = FlatStyle.Flat;
            ordersMenuButton.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            ordersMenuButton.ForeColor = Color.FromArgb(252, 251, 255);
            ordersMenuButton.Image = (Image)resources.GetObject("ordersMenuButton.Image");
            ordersMenuButton.ImageAlign = ContentAlignment.MiddleLeft;
            ordersMenuButton.Location = new Point(0, 138);
            ordersMenuButton.Name = "ordersMenuButton";
            ordersMenuButton.Padding = new Padding(2, 0, 0, 0);
            ordersMenuButton.Size = new Size(196, 50);
            ordersMenuButton.TabIndex = 5;
            ordersMenuButton.Text = "Orders";
            ordersMenuButton.TextAlign = ContentAlignment.BottomRight;
            ordersMenuButton.UseVisualStyleBackColor = false;
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
            addProductSubMenuButton.Size = new Size(196, 44);
            addProductSubMenuButton.TabIndex = 4;
            addProductSubMenuButton.Text = "Add product";
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
            productsMenuButton.Size = new Size(196, 44);
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
            homeMenuButton.Size = new Size(196, 50);
            homeMenuButton.TabIndex = 2;
            homeMenuButton.Text = "Home";
            homeMenuButton.TextAlign = ContentAlignment.BottomRight;
            homeMenuButton.UseVisualStyleBackColor = false;
            homeMenuButton.Click += homeMenuButton_Click;
            // 
            // logoPanel
            // 
            logoPanel.Location = new Point(3, 3);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(208, 137);
            logoPanel.TabIndex = 0;
            // 
            // workspaceContainer
            // 
            workspaceContainer.Dock = DockStyle.Fill;
            workspaceContainer.Location = new Point(0, 0);
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
            workspaceContainer.Size = new Size(1694, 1041);
            workspaceContainer.SplitterDistance = 1393;
            workspaceContainer.SplitterWidth = 1;
            workspaceContainer.TabIndex = 0;
            // 
            // storeContainer
            // 
            storeContainer.Dock = DockStyle.Fill;
            storeContainer.Location = new Point(0, 0);
            storeContainer.Name = "storeContainer";
            storeContainer.Orientation = Orientation.Horizontal;
            // 
            // storeContainer.Panel1
            // 
            storeContainer.Panel1.BackColor = Color.FromArgb(155, 123, 213);
            storeContainer.Panel1.Controls.Add(storeNameLabel);
            // 
            // storeContainer.Panel2
            // 
            storeContainer.Panel2.BackColor = Color.FromArgb(227, 211, 177);
            storeContainer.Panel2.Controls.Add(mainHomeTabUserControl);
            storeContainer.Size = new Size(1393, 1041);
            storeContainer.SplitterDistance = 140;
            storeContainer.SplitterWidth = 1;
            storeContainer.TabIndex = 0;
            // 
            // storeNameLabel
            // 
            storeNameLabel.Font = new Font("Segoe UI", 33F, FontStyle.Bold, GraphicsUnit.Point);
            storeNameLabel.ForeColor = Color.FromArgb(28, 44, 78);
            storeNameLabel.Location = new Point(3, 23);
            storeNameLabel.Name = "storeNameLabel";
            storeNameLabel.Size = new Size(1390, 68);
            storeNameLabel.TabIndex = 0;
            storeNameLabel.Text = "Store Name";
            storeNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mainHomeTabUserControl
            // 
            mainHomeTabUserControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainHomeTabUserControl.BackColor = Color.FromArgb(227, 211, 177);
            mainHomeTabUserControl.Location = new Point(0, 0);
            mainHomeTabUserControl.Name = "mainHomeTabUserControl";
            mainHomeTabUserControl.Size = new Size(1393, 918);
            mainHomeTabUserControl.TabIndex = 0;
            // 
            // searchPanel
            // 
            searchPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchPanel.Controls.Add(searchInputPanel);
            searchPanel.Location = new Point(3, 106);
            searchPanel.Name = "searchPanel";
            searchPanel.Size = new Size(312, 299);
            searchPanel.TabIndex = 7;
            // 
            // searchInputPanel
            // 
            searchInputPanel.Controls.Add(searchTextBox);
            searchInputPanel.Controls.Add(searchButtonPanel);
            searchInputPanel.Dock = DockStyle.Top;
            searchInputPanel.Location = new Point(0, 0);
            searchInputPanel.Name = "searchInputPanel";
            searchInputPanel.Size = new Size(312, 35);
            searchInputPanel.TabIndex = 0;
            // 
            // searchTextBox
            // 
            searchTextBox.BorderStyle = BorderStyle.FixedSingle;
            searchTextBox.Dock = DockStyle.Fill;
            searchTextBox.Location = new Point(0, 0);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(277, 35);
            searchTextBox.TabIndex = 6;
            // 
            // searchButtonPanel
            // 
            searchButtonPanel.Controls.Add(searchButton);
            searchButtonPanel.Dock = DockStyle.Right;
            searchButtonPanel.Location = new Point(277, 0);
            searchButtonPanel.Name = "searchButtonPanel";
            searchButtonPanel.Size = new Size(35, 35);
            searchButtonPanel.TabIndex = 0;
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            searchButton.BackColor = Color.White;
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
            windowOpPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            windowOpPanel.Controls.Add(minPanel);
            windowOpPanel.Controls.Add(maxPanel);
            windowOpPanel.Controls.Add(closePanel);
            windowOpPanel.Dock = DockStyle.Top;
            windowOpPanel.Location = new Point(0, 0);
            windowOpPanel.Name = "windowOpPanel";
            windowOpPanel.Size = new Size(300, 45);
            windowOpPanel.TabIndex = 5;
            // 
            // minPanel
            // 
            minPanel.Controls.Add(minButton);
            minPanel.Dock = DockStyle.Right;
            minPanel.Location = new Point(169, 0);
            minPanel.Name = "minPanel";
            minPanel.Size = new Size(43, 45);
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
            minButton.Location = new Point(-7, 0);
            minButton.Name = "minButton";
            minButton.Size = new Size(50, 45);
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
            maxPanel.Location = new Point(212, 0);
            maxPanel.Name = "maxPanel";
            maxPanel.Size = new Size(45, 45);
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
            restoreButton.Location = new Point(-55, 0);
            restoreButton.Name = "restoreButton";
            restoreButton.Size = new Size(50, 45);
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
            maxButton.Location = new Point(-5, 0);
            maxButton.Name = "maxButton";
            maxButton.Size = new Size(50, 45);
            maxButton.TabIndex = 3;
            maxButton.TextAlign = ContentAlignment.BottomCenter;
            maxButton.UseVisualStyleBackColor = false;
            maxButton.Click += maxButton_Click;
            // 
            // closePanel
            // 
            closePanel.Controls.Add(closeButton);
            closePanel.Dock = DockStyle.Right;
            closePanel.Location = new Point(257, 0);
            closePanel.Name = "closePanel";
            closePanel.Size = new Size(43, 45);
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
            closeButton.Location = new Point(-7, 0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(50, 45);
            closeButton.TabIndex = 3;
            closeButton.TextAlign = ContentAlignment.BottomCenter;
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += CloseButton_Click;
            // 
            // MainDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1904, 1041);
            Controls.Add(mainContainer);
            FormBorderStyle = FormBorderStyle.None;
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
        private Button button5;
        private Button addVendorSubMenuButton;
        private Button searchVendorSubMenuButton;
        private Button searchProductSubMenuButton;
        private Button vendorsMenuButton;
        private Button ordersMenuButton;
        private Button addProductSubMenuButton;
        private Button productsMenuButton;
        private Button restoreButton;
        private UserControls.HomeUserControl.HomeTabUserControl mainHomeTabUserControl;
    }
}