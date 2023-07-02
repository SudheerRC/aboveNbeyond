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
            navigationPanel = new Panel();
            logoutButton = new Button();
            addVendorSubMenuButton = new Button();
            searchVendorSubMenuButton = new Button();
            vendorsMenuButton = new Button();
            addProductSubMenuButton = new Button();
            productsMenuButton = new Button();
            homeMenuButton = new Button();
            logoPanel = new Panel();
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
            closePanel = new Panel();
            closeButton = new Button();
            mainPanel = new Panel();
            rightPanel = new Panel();
            leftPanel = new Panel();
            headerPanel = new Panel();
            navigationPanel.SuspendLayout();
            searchPanel.SuspendLayout();
            searchInputPanel.SuspendLayout();
            searchButtonPanel.SuspendLayout();
            windowOpPanel.SuspendLayout();
            minPanel.SuspendLayout();
            closePanel.SuspendLayout();
            mainPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            leftPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // navigationPanel
            // 
            navigationPanel.AutoScroll = true;
            navigationPanel.Controls.Add(logoutButton);
            navigationPanel.Controls.Add(addVendorSubMenuButton);
            navigationPanel.Controls.Add(searchVendorSubMenuButton);
            navigationPanel.Controls.Add(vendorsMenuButton);
            navigationPanel.Controls.Add(addProductSubMenuButton);
            navigationPanel.Controls.Add(productsMenuButton);
            navigationPanel.Controls.Add(homeMenuButton);
            navigationPanel.Location = new Point(8, 211);
            navigationPanel.Margin = new Padding(3, 2, 3, 2);
            navigationPanel.Name = "navigationPanel";
            navigationPanel.Size = new Size(242, 952);
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
            logoutButton.Location = new Point(0, 864);
            logoutButton.Margin = new Padding(3, 2, 3, 2);
            logoutButton.Name = "logoutButton";
            logoutButton.Padding = new Padding(2, 0, 0, 0);
            logoutButton.Size = new Size(242, 88);
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
            addVendorSubMenuButton.Location = new Point(0, 370);
            addVendorSubMenuButton.Margin = new Padding(3, 2, 3, 2);
            addVendorSubMenuButton.Name = "addVendorSubMenuButton";
            addVendorSubMenuButton.Padding = new Padding(2, 0, 0, 0);
            addVendorSubMenuButton.Size = new Size(242, 53);
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
            searchVendorSubMenuButton.Location = new Point(0, 317);
            searchVendorSubMenuButton.Margin = new Padding(3, 2, 3, 2);
            searchVendorSubMenuButton.Name = "searchVendorSubMenuButton";
            searchVendorSubMenuButton.Padding = new Padding(2, 0, 0, 0);
            searchVendorSubMenuButton.Size = new Size(242, 53);
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
            vendorsMenuButton.Location = new Point(0, 229);
            vendorsMenuButton.Margin = new Padding(3, 2, 3, 2);
            vendorsMenuButton.Name = "vendorsMenuButton";
            vendorsMenuButton.Padding = new Padding(2, 0, 0, 0);
            vendorsMenuButton.Size = new Size(242, 88);
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
            addProductSubMenuButton.Location = new Point(0, 176);
            addProductSubMenuButton.Margin = new Padding(3, 2, 3, 2);
            addProductSubMenuButton.Name = "addProductSubMenuButton";
            addProductSubMenuButton.Padding = new Padding(2, 0, 0, 0);
            addProductSubMenuButton.Size = new Size(242, 53);
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
            productsMenuButton.Location = new Point(0, 88);
            productsMenuButton.Margin = new Padding(3, 2, 3, 2);
            productsMenuButton.Name = "productsMenuButton";
            productsMenuButton.Padding = new Padding(2, 0, 0, 0);
            productsMenuButton.Size = new Size(242, 88);
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
            homeMenuButton.Margin = new Padding(3, 2, 3, 2);
            homeMenuButton.Name = "homeMenuButton";
            homeMenuButton.Padding = new Padding(2, 0, 0, 0);
            homeMenuButton.Size = new Size(242, 88);
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
            logoPanel.Location = new Point(8, 6);
            logoPanel.Margin = new Padding(8, 6, 8, 6);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(242, 197);
            logoPanel.TabIndex = 0;
            // 
            // storeNameLabel
            // 
            storeNameLabel.BackColor = Color.DarkSlateGray;
            storeNameLabel.Dock = DockStyle.Fill;
            storeNameLabel.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            storeNameLabel.ForeColor = SystemColors.ButtonHighlight;
            storeNameLabel.Location = new Point(0, 0);
            storeNameLabel.Margin = new Padding(8, 0, 8, 0);
            storeNameLabel.Name = "storeNameLabel";
            storeNameLabel.Size = new Size(1498, 136);
            storeNameLabel.TabIndex = 0;
            storeNameLabel.Text = "MyStores";
            storeNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mainHomeTabUserControl
            // 
            mainHomeTabUserControl.BackColor = Color.FromArgb(227, 211, 177);
            mainHomeTabUserControl.Location = new Point(3, 2);
            mainHomeTabUserControl.Margin = new Padding(3, 2, 3, 2);
            mainHomeTabUserControl.Name = "mainHomeTabUserControl";
            mainHomeTabUserControl.Size = new Size(1412, 1954);
            mainHomeTabUserControl.TabIndex = 0;
            // 
            // mainAddVendorUserControl
            // 
            mainAddVendorUserControl.AutoScroll = true;
            mainAddVendorUserControl.BackColor = Color.BlanchedAlmond;
            mainAddVendorUserControl.Location = new Point(385, 8);
            mainAddVendorUserControl.Margin = new Padding(5, 8, 5, 8);
            mainAddVendorUserControl.Name = "mainAddVendorUserControl";
            mainAddVendorUserControl.Size = new Size(676, 1282);
            mainAddVendorUserControl.TabIndex = 3;
            // 
            // mainVendorTabUserControl
            // 
            mainVendorTabUserControl.AutoScroll = true;
            mainVendorTabUserControl.BackColor = Color.FromArgb(227, 211, 177);
            mainVendorTabUserControl.Location = new Point(3, 2);
            mainVendorTabUserControl.Margin = new Padding(11, 13, 11, 13);
            mainVendorTabUserControl.Name = "mainVendorTabUserControl";
            mainVendorTabUserControl.Size = new Size(1412, 9838);
            mainVendorTabUserControl.TabIndex = 2;
            // 
            // mainProductsTabUserControl
            // 
            mainProductsTabUserControl.AutoScroll = true;
            mainProductsTabUserControl.BackColor = Color.FromArgb(227, 211, 177);
            mainProductsTabUserControl.Location = new Point(263, 8);
            mainProductsTabUserControl.Margin = new Padding(11, 13, 11, 13);
            mainProductsTabUserControl.Name = "mainProductsTabUserControl";
            mainProductsTabUserControl.Size = new Size(1235, 61674);
            mainProductsTabUserControl.TabIndex = 1;
            // 
            // searchPanel
            // 
            searchPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchPanel.Controls.Add(searchInputPanel);
            searchPanel.Location = new Point(8, 208);
            searchPanel.Margin = new Padding(3, 2, 3, 2);
            searchPanel.Name = "searchPanel";
            searchPanel.Size = new Size(325, 736);
            searchPanel.TabIndex = 7;
            // 
            // searchInputPanel
            // 
            searchInputPanel.Controls.Add(searchTextBox);
            searchInputPanel.Controls.Add(searchButtonPanel);
            searchInputPanel.Dock = DockStyle.Top;
            searchInputPanel.Location = new Point(0, 0);
            searchInputPanel.Margin = new Padding(3, 2, 3, 2);
            searchInputPanel.Name = "searchInputPanel";
            searchInputPanel.Size = new Size(325, 51);
            searchInputPanel.TabIndex = 0;
            // 
            // searchTextBox
            // 
            searchTextBox.BorderStyle = BorderStyle.FixedSingle;
            searchTextBox.Enabled = false;
            searchTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchTextBox.Location = new Point(0, 5);
            searchTextBox.Margin = new Padding(3, 2, 3, 2);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "Coming soon";
            searchTextBox.Size = new Size(264, 39);
            searchTextBox.TabIndex = 6;
            // 
            // searchButtonPanel
            // 
            searchButtonPanel.Controls.Add(searchButton);
            searchButtonPanel.Location = new Point(271, 2);
            searchButtonPanel.Margin = new Padding(3, 2, 3, 2);
            searchButtonPanel.Name = "searchButtonPanel";
            searchButtonPanel.Size = new Size(55, 46);
            searchButtonPanel.TabIndex = 0;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.White;
            searchButton.Dock = DockStyle.Right;
            searchButton.Enabled = false;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Image = (Image)resources.GetObject("searchButton.Image");
            searchButton.Location = new Point(0, 0);
            searchButton.Margin = new Padding(8, 6, 8, 6);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(55, 46);
            searchButton.TabIndex = 0;
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // windowOpPanel
            // 
            windowOpPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            windowOpPanel.Controls.Add(minPanel);
            windowOpPanel.Controls.Add(closePanel);
            windowOpPanel.Location = new Point(70, 5);
            windowOpPanel.Margin = new Padding(8, 6, 8, 6);
            windowOpPanel.Name = "windowOpPanel";
            windowOpPanel.Size = new Size(260, 69);
            windowOpPanel.TabIndex = 5;
            // 
            // minPanel
            // 
            minPanel.Controls.Add(minButton);
            minPanel.Dock = DockStyle.Right;
            minPanel.Location = new Point(100, 0);
            minPanel.Margin = new Padding(8, 6, 8, 6);
            minPanel.Name = "minPanel";
            minPanel.Size = new Size(80, 69);
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
            minButton.Margin = new Padding(8, 6, 8, 6);
            minButton.Name = "minButton";
            minButton.Size = new Size(93, 69);
            minButton.TabIndex = 3;
            minButton.TextAlign = ContentAlignment.BottomCenter;
            minButton.UseVisualStyleBackColor = false;
            minButton.Click += minButton_Click;
            // 
            // closePanel
            // 
            closePanel.Controls.Add(closeButton);
            closePanel.Dock = DockStyle.Right;
            closePanel.Location = new Point(180, 0);
            closePanel.Margin = new Padding(8, 6, 8, 6);
            closePanel.Name = "closePanel";
            closePanel.Size = new Size(80, 69);
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
            closeButton.Margin = new Padding(8, 6, 8, 6);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(93, 69);
            closeButton.TabIndex = 3;
            closeButton.TextAlign = ContentAlignment.BottomCenter;
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += CloseButton_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(227, 211, 177);
            mainPanel.Controls.Add(mainProductsTabUserControl);
            mainPanel.Controls.Add(mainVendorTabUserControl);
            mainPanel.Controls.Add(mainAddVendorUserControl);
            mainPanel.Controls.Add(mainHomeTabUserControl);
            mainPanel.Location = new Point(257, 136);
            mainPanel.Margin = new Padding(5);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1498, 1085);
            mainPanel.TabIndex = 4;
            // 
            // rightPanel
            // 
            rightPanel.BackColor = Color.FromArgb(28, 44, 78);
            rightPanel.Controls.Add(windowOpPanel);
            rightPanel.Controls.Add(searchPanel);
            rightPanel.Location = new Point(1755, 0);
            rightPanel.Margin = new Padding(5);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(333, 1221);
            rightPanel.TabIndex = 8;
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.FromArgb(28, 44, 78);
            leftPanel.Controls.Add(navigationPanel);
            leftPanel.Controls.Add(logoPanel);
            leftPanel.Location = new Point(0, -3);
            leftPanel.Margin = new Padding(5);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(257, 1224);
            leftPanel.TabIndex = 9;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(28, 44, 78);
            headerPanel.Controls.Add(storeNameLabel);
            headerPanel.Location = new Point(257, 0);
            headerPanel.Margin = new Padding(5);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1498, 136);
            headerPanel.TabIndex = 9;
            // 
            // MainDashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(2088, 1218);
            Controls.Add(headerPanel);
            Controls.Add(leftPanel);
            Controls.Add(rightPanel);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(8, 6, 8, 6);
            Name = "MainDashboard";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyStores";
            Load += MainDashboard_Load;
            navigationPanel.ResumeLayout(false);
            searchPanel.ResumeLayout(false);
            searchInputPanel.ResumeLayout(false);
            searchInputPanel.PerformLayout();
            searchButtonPanel.ResumeLayout(false);
            windowOpPanel.ResumeLayout(false);
            minPanel.ResumeLayout(false);
            closePanel.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            leftPanel.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label storeNameLabel;
        private Panel logoPanel;
        private Button homeMenuButton;
        private Panel navigationPanel;
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
        private UserControls.HomeUserControl.HomeTabUserControl mainHomeTabUserControl;
        private UserControls.VendorTabUserControl mainVendorTabUserControl;
        private UserControls.ProductsTabUserControl mainProductsTabUserControl;
        private UserControls.AddVendorUserControl mainAddVendorUserControl;
        private Panel mainPanel;
        private Panel rightPanel;
        private Panel leftPanel;
        private Panel headerPanel;
    }
}