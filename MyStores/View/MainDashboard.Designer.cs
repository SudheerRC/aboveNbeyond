﻿namespace MyStores.View
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
            VendorNavButtonPanel = new Panel();
            vendorSubMenuPanel = new Panel();
            searchVendorSubMenuButton = new Button();
            addVendorSubMenuButton = new Button();
            vendorsMenuButton = new Button();
            productsSubMenuPanel = new Panel();
            addProductSubMenuButton = new Button();
            logoutButton = new Button();
            productsMenuButton = new Button();
            homeMenuButton = new Button();
            logoPanel = new Panel();
            userNameLabel = new Label();
            storeNameLabel = new Label();
            mainHomeTabUserControl = new UserControls.HomeUserControl.HomeTabUserControl();
            mainAddVendorUserControl = new UserControls.AddVendorUserControl();
            mainVendorTabUserControl = new UserControls.VendorTabUserControl();
            mainProductsTabUserControl = new UserControls.ProductsTabUserControl();
            windowOpPanel = new Panel();
            minPanel = new Panel();
            minButton = new Button();
            closePanel = new Panel();
            closeButton = new Button();
            mainPanel = new Panel();
            rightPanel = new Panel();
            globalSearchUserControl = new UserControls.GlobalSearchUserControl();
            leftPanel = new Panel();
            headerPanel = new Panel();
            navigationPanel.SuspendLayout();
            VendorNavButtonPanel.SuspendLayout();
            vendorSubMenuPanel.SuspendLayout();
            productsSubMenuPanel.SuspendLayout();
            logoPanel.SuspendLayout();
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
            navigationPanel.Controls.Add(VendorNavButtonPanel);
            navigationPanel.Controls.Add(productsSubMenuPanel);
            navigationPanel.Controls.Add(logoutButton);
            navigationPanel.Controls.Add(productsMenuButton);
            navigationPanel.Controls.Add(homeMenuButton);
            navigationPanel.Dock = DockStyle.Top;
            navigationPanel.Location = new Point(0, 123);
            navigationPanel.Margin = new Padding(2, 1, 2, 1);
            navigationPanel.Name = "navigationPanel";
            navigationPanel.Size = new Size(158, 633);
            navigationPanel.TabIndex = 2;
            // 
            // VendorNavButtonPanel
            // 
            VendorNavButtonPanel.Controls.Add(vendorSubMenuPanel);
            VendorNavButtonPanel.Controls.Add(vendorsMenuButton);
            VendorNavButtonPanel.Dock = DockStyle.Top;
            VendorNavButtonPanel.Location = new Point(0, 149);
            VendorNavButtonPanel.Margin = new Padding(2, 2, 2, 2);
            VendorNavButtonPanel.Name = "VendorNavButtonPanel";
            VendorNavButtonPanel.Size = new Size(158, 124);
            VendorNavButtonPanel.TabIndex = 11;
            // 
            // vendorSubMenuPanel
            // 
            vendorSubMenuPanel.Controls.Add(searchVendorSubMenuButton);
            vendorSubMenuPanel.Controls.Add(addVendorSubMenuButton);
            vendorSubMenuPanel.Dock = DockStyle.Top;
            vendorSubMenuPanel.Location = new Point(0, 55);
            vendorSubMenuPanel.Margin = new Padding(2, 2, 2, 2);
            vendorSubMenuPanel.Name = "vendorSubMenuPanel";
            vendorSubMenuPanel.Size = new Size(158, 68);
            vendorSubMenuPanel.TabIndex = 3;
            vendorSubMenuPanel.Visible = false;
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
            searchVendorSubMenuButton.Location = new Point(0, 33);
            searchVendorSubMenuButton.Margin = new Padding(2, 1, 2, 1);
            searchVendorSubMenuButton.Name = "searchVendorSubMenuButton";
            searchVendorSubMenuButton.Padding = new Padding(1, 0, 0, 0);
            searchVendorSubMenuButton.Size = new Size(158, 33);
            searchVendorSubMenuButton.TabIndex = 8;
            searchVendorSubMenuButton.Text = "Search Vendor";
            searchVendorSubMenuButton.TextAlign = ContentAlignment.MiddleRight;
            searchVendorSubMenuButton.UseVisualStyleBackColor = false;
            searchVendorSubMenuButton.Click += searchVendorSubMenuButton_Click;
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
            addVendorSubMenuButton.Location = new Point(0, 0);
            addVendorSubMenuButton.Margin = new Padding(2, 1, 2, 1);
            addVendorSubMenuButton.Name = "addVendorSubMenuButton";
            addVendorSubMenuButton.Padding = new Padding(1, 0, 0, 0);
            addVendorSubMenuButton.Size = new Size(158, 33);
            addVendorSubMenuButton.TabIndex = 9;
            addVendorSubMenuButton.Text = "Add Vendor";
            addVendorSubMenuButton.TextAlign = ContentAlignment.MiddleRight;
            addVendorSubMenuButton.UseVisualStyleBackColor = false;
            addVendorSubMenuButton.Click += addVendorSubMenuButton_Click;
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
            vendorsMenuButton.Location = new Point(0, 0);
            vendorsMenuButton.Margin = new Padding(2, 1, 2, 1);
            vendorsMenuButton.Name = "vendorsMenuButton";
            vendorsMenuButton.Padding = new Padding(1, 0, 0, 0);
            vendorsMenuButton.Size = new Size(158, 55);
            vendorsMenuButton.TabIndex = 7;
            vendorsMenuButton.Text = "Vendors";
            vendorsMenuButton.TextAlign = ContentAlignment.MiddleRight;
            vendorsMenuButton.UseVisualStyleBackColor = false;
            vendorsMenuButton.Click += vendorsMenuButton_Click;
            // 
            // productsSubMenuPanel
            // 
            productsSubMenuPanel.Controls.Add(addProductSubMenuButton);
            productsSubMenuPanel.Dock = DockStyle.Top;
            productsSubMenuPanel.Location = new Point(0, 110);
            productsSubMenuPanel.Margin = new Padding(2, 2, 2, 2);
            productsSubMenuPanel.Name = "productsSubMenuPanel";
            productsSubMenuPanel.Size = new Size(158, 39);
            productsSubMenuPanel.TabIndex = 10;
            productsSubMenuPanel.Visible = false;
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
            addProductSubMenuButton.Location = new Point(0, 0);
            addProductSubMenuButton.Margin = new Padding(2, 1, 2, 1);
            addProductSubMenuButton.Name = "addProductSubMenuButton";
            addProductSubMenuButton.Padding = new Padding(1, 0, 0, 0);
            addProductSubMenuButton.Size = new Size(158, 33);
            addProductSubMenuButton.TabIndex = 4;
            addProductSubMenuButton.Text = "Add Product";
            addProductSubMenuButton.TextAlign = ContentAlignment.MiddleRight;
            addProductSubMenuButton.UseVisualStyleBackColor = false;
            addProductSubMenuButton.Click += addProductSubMenuButton_Click;
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
            logoutButton.Location = new Point(0, 578);
            logoutButton.Margin = new Padding(2, 1, 2, 1);
            logoutButton.Name = "logoutButton";
            logoutButton.Padding = new Padding(1, 0, 0, 0);
            logoutButton.Size = new Size(158, 55);
            logoutButton.TabIndex = 7;
            logoutButton.Text = "Logout";
            logoutButton.TextAlign = ContentAlignment.MiddleRight;
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += LogoutButton_Click;
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
            productsMenuButton.Size = new Size(158, 55);
            productsMenuButton.TabIndex = 3;
            productsMenuButton.Text = "Products";
            productsMenuButton.TextAlign = ContentAlignment.MiddleRight;
            productsMenuButton.UseVisualStyleBackColor = false;
            productsMenuButton.Click += productsMenuButton_Click;
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
            homeMenuButton.Size = new Size(158, 55);
            homeMenuButton.TabIndex = 2;
            homeMenuButton.Text = "Store";
            homeMenuButton.TextAlign = ContentAlignment.MiddleRight;
            homeMenuButton.UseVisualStyleBackColor = false;
            homeMenuButton.Click += homeMenuButton_Click;
            // 
            // logoPanel
            // 
            logoPanel.Controls.Add(userNameLabel);
            logoPanel.Dock = DockStyle.Top;
            logoPanel.Location = new Point(0, 0);
            logoPanel.Margin = new Padding(5, 4, 5, 4);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(158, 123);
            logoPanel.TabIndex = 0;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            userNameLabel.ForeColor = SystemColors.ControlLightLight;
            userNameLabel.Location = new Point(29, 41);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(63, 28);
            userNameLabel.TabIndex = 0;
            userNameLabel.Text = "label1";
            // 
            // storeNameLabel
            // 
            storeNameLabel.BackColor = Color.DarkSlateGray;
            storeNameLabel.Dock = DockStyle.Fill;
            storeNameLabel.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            storeNameLabel.ForeColor = SystemColors.ButtonHighlight;
            storeNameLabel.Location = new Point(0, 0);
            storeNameLabel.Margin = new Padding(5, 0, 5, 0);
            storeNameLabel.Name = "storeNameLabel";
            storeNameLabel.Size = new Size(922, 85);
            storeNameLabel.TabIndex = 0;
            storeNameLabel.Text = "MyStores";
            storeNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mainHomeTabUserControl
            // 
            mainHomeTabUserControl.BackColor = Color.FromArgb(227, 211, 177);
            mainHomeTabUserControl.Location = new Point(2, 1);
            mainHomeTabUserControl.Margin = new Padding(2, 1, 2, 1);
            mainHomeTabUserControl.Name = "mainHomeTabUserControl";
            mainHomeTabUserControl.Size = new Size(869, 1221);
            mainHomeTabUserControl.StoreName = null;
            mainHomeTabUserControl.TabIndex = 0;
            mainHomeTabUserControl.OnUpdateStatus += HomeTabUserControl_OnUpdateStatus;
            // 
            // mainAddVendorUserControl
            // 
            mainAddVendorUserControl.AutoScroll = true;
            mainAddVendorUserControl.BackColor = Color.FromArgb(227, 211, 177);
            mainAddVendorUserControl.Location = new Point(237, 5);
            mainAddVendorUserControl.Margin = new Padding(3, 5, 3, 5);
            mainAddVendorUserControl.Name = "mainAddVendorUserControl";
            mainAddVendorUserControl.Size = new Size(416, 801);
            mainAddVendorUserControl.TabIndex = 3;
            // 
            // mainVendorTabUserControl
            // 
            mainVendorTabUserControl.AutoScroll = true;
            mainVendorTabUserControl.BackColor = Color.FromArgb(227, 211, 177);
            mainVendorTabUserControl.Location = new Point(2, 1);
            mainVendorTabUserControl.Margin = new Padding(7, 8, 7, 8);
            mainVendorTabUserControl.Name = "mainVendorTabUserControl";
            mainVendorTabUserControl.Size = new Size(883, 6149);
            mainVendorTabUserControl.TabIndex = 2;
            // 
            // mainProductsTabUserControl
            // 
            mainProductsTabUserControl.AutoScroll = true;
            mainProductsTabUserControl.BackColor = Color.FromArgb(227, 211, 177);
            mainProductsTabUserControl.Location = new Point(162, 5);
            mainProductsTabUserControl.Margin = new Padding(7, 8, 7, 8);
            mainProductsTabUserControl.Name = "mainProductsTabUserControl";
            mainProductsTabUserControl.Size = new Size(760, 38546);
            mainProductsTabUserControl.TabIndex = 1;
            // 
            // windowOpPanel
            // 
            windowOpPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            windowOpPanel.Controls.Add(minPanel);
            windowOpPanel.Controls.Add(closePanel);
            windowOpPanel.Location = new Point(84, 0);
            windowOpPanel.Margin = new Padding(5, 4, 5, 4);
            windowOpPanel.Name = "windowOpPanel";
            windowOpPanel.Size = new Size(160, 43);
            windowOpPanel.TabIndex = 5;
            // 
            // minPanel
            // 
            minPanel.Controls.Add(minButton);
            minPanel.Dock = DockStyle.Right;
            minPanel.Location = new Point(62, 0);
            minPanel.Margin = new Padding(5, 4, 5, 4);
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
            minButton.Location = new Point(-8, 0);
            minButton.Margin = new Padding(5, 4, 5, 4);
            minButton.Name = "minButton";
            minButton.Size = new Size(57, 43);
            minButton.TabIndex = 3;
            minButton.TextAlign = ContentAlignment.BottomCenter;
            minButton.UseVisualStyleBackColor = false;
            minButton.Click += minButton_Click;
            // 
            // closePanel
            // 
            closePanel.Controls.Add(closeButton);
            closePanel.Dock = DockStyle.Right;
            closePanel.Location = new Point(111, 0);
            closePanel.Margin = new Padding(5, 4, 5, 4);
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
            closeButton.Location = new Point(-8, 0);
            closeButton.Margin = new Padding(5, 4, 5, 4);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(57, 43);
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
            mainPanel.Location = new Point(158, 85);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(922, 678);
            mainPanel.TabIndex = 4;
            // 
            // rightPanel
            // 
            rightPanel.BackColor = Color.FromArgb(28, 44, 78);
            rightPanel.Controls.Add(globalSearchUserControl);
            rightPanel.Controls.Add(windowOpPanel);
            rightPanel.Location = new Point(1080, 0);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(247, 763);
            rightPanel.TabIndex = 8;
            // 
            // globalSearchUserControl
            // 
            globalSearchUserControl.BackColor = Color.FromArgb(28, 44, 78);
            globalSearchUserControl.CategoryId = 0;
            globalSearchUserControl.CategoryName = null;
            globalSearchUserControl.Location = new Point(2, 86);
            globalSearchUserControl.Margin = new Padding(1, 1, 1, 1);
            globalSearchUserControl.Name = "globalSearchUserControl";
            globalSearchUserControl.Size = new Size(241, 677);
            globalSearchUserControl.TabIndex = 6;
            globalSearchUserControl.OnUpdateStatus += GlobalSearchUserControl_OnUpdateStatus;
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.FromArgb(28, 44, 78);
            leftPanel.Controls.Add(navigationPanel);
            leftPanel.Controls.Add(logoPanel);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(158, 762);
            leftPanel.TabIndex = 9;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(28, 44, 78);
            headerPanel.Controls.Add(storeNameLabel);
            headerPanel.Location = new Point(158, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(922, 85);
            headerPanel.TabIndex = 9;
            // 
            // MainDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1326, 762);
            Controls.Add(headerPanel);
            Controls.Add(leftPanel);
            Controls.Add(rightPanel);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "MainDashboard";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyStores";
            Load += MainDashboard_Load;
            navigationPanel.ResumeLayout(false);
            VendorNavButtonPanel.ResumeLayout(false);
            vendorSubMenuPanel.ResumeLayout(false);
            productsSubMenuPanel.ResumeLayout(false);
            logoPanel.ResumeLayout(false);
            logoPanel.PerformLayout();
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
        private Panel productsSubMenuPanel;
        private Panel vendorSubMenuPanel;
        private Panel VendorNavButtonPanel;
    }
}