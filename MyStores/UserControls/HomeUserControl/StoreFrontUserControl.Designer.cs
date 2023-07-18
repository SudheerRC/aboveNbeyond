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
            mainSalesUserControl = new SalesUserControl();
            mainAddProductToStoreUserControl = new AddProductToStoreUserControl();
            mainAddManagerUserControl = new AddManagerUserControl();
            mainInventoryUserControl = new InventoryUserControl();
            mainAddVendorToStoreUserControl = new AddVendorToStoreUserControl();
            mainOrderUserControl = new OrderUserControl();
            backButtonPanel = new Panel();
            backButton = new Button();
            addManagerButton = new Button();
            storeButtonsPanel = new Panel();
            deleteStoreButton = new Button();
            salesButton = new Button();
            salesPanel = new Panel();
            salesValueLabel = new Label();
            salesLabel = new Label();
            salesPictureBox = new PictureBox();
            managersPanel = new Panel();
            managerNamesLabel = new Label();
            managerLabel = new Label();
            managerPictureBox = new PictureBox();
            closePanel = new Panel();
            statusLabel = new Label();
            closeButton = new Button();
            storeExpandedPanel.SuspendLayout();
            backButtonPanel.SuspendLayout();
            storeButtonsPanel.SuspendLayout();
            salesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)salesPictureBox).BeginInit();
            managersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)managerPictureBox).BeginInit();
            closePanel.SuspendLayout();
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
            AddVendorButton.Size = new Size(160, 180);
            AddVendorButton.TabIndex = 2;
            AddVendorButton.Text = "Add Vendor To Store";
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
            addProductButton.Location = new Point(338, 15);
            addProductButton.Margin = new Padding(3, 4, 3, 4);
            addProductButton.Name = "addProductButton";
            addProductButton.Size = new Size(160, 180);
            addProductButton.TabIndex = 4;
            addProductButton.Text = "Add Product To Store";
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
            inventoryButton.Location = new Point(661, 15);
            inventoryButton.Margin = new Padding(3, 4, 3, 4);
            inventoryButton.Name = "inventoryButton";
            inventoryButton.Size = new Size(160, 180);
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
            orderButton.FlatAppearance.BorderSize = 0;
            orderButton.FlatStyle = FlatStyle.Flat;
            orderButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            orderButton.ForeColor = Color.White;
            orderButton.Image = (Image)resources.GetObject("orderButton.Image");
            orderButton.Location = new Point(26, 253);
            orderButton.Margin = new Padding(3, 4, 3, 4);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(160, 180);
            orderButton.TabIndex = 6;
            orderButton.Text = "Order";
            orderButton.TextAlign = ContentAlignment.BottomCenter;
            orderButton.TextImageRelation = TextImageRelation.ImageAboveText;
            orderButton.UseVisualStyleBackColor = false;
            orderButton.Click += orderButton_Click;
            // 
            // exitStoreButton
            // 
            exitStoreButton.BackColor = Color.FromArgb(28, 44, 78);
            exitStoreButton.FlatAppearance.BorderSize = 0;
            exitStoreButton.FlatStyle = FlatStyle.Flat;
            exitStoreButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            exitStoreButton.ForeColor = Color.White;
            exitStoreButton.Location = new Point(530, 468);
            exitStoreButton.Margin = new Padding(3, 4, 3, 4);
            exitStoreButton.Name = "exitStoreButton";
            exitStoreButton.Size = new Size(105, 75);
            exitStoreButton.TabIndex = 7;
            exitStoreButton.Text = "Exit Store";
            exitStoreButton.TextImageRelation = TextImageRelation.ImageAboveText;
            exitStoreButton.UseVisualStyleBackColor = false;
            exitStoreButton.Click += exitStoreButton_Click;
            // 
            // storeExpandedPanel
            // 
            storeExpandedPanel.BackColor = Color.FromArgb(227, 211, 177);
            storeExpandedPanel.Controls.Add(mainSalesUserControl);
            storeExpandedPanel.Controls.Add(mainAddProductToStoreUserControl);
            storeExpandedPanel.Controls.Add(mainAddManagerUserControl);
            storeExpandedPanel.Controls.Add(mainInventoryUserControl);
            storeExpandedPanel.Controls.Add(mainAddVendorToStoreUserControl);
            storeExpandedPanel.Controls.Add(mainOrderUserControl);
            storeExpandedPanel.Location = new Point(70, 69);
            storeExpandedPanel.Margin = new Padding(3, 4, 3, 4);
            storeExpandedPanel.Name = "storeExpandedPanel";
            storeExpandedPanel.Size = new Size(2312, 776);
            storeExpandedPanel.TabIndex = 8;
            storeExpandedPanel.Visible = false;
            // 
            // mainSalesUserControl
            // 
            mainSalesUserControl.BackColor = Color.FromArgb(227, 211, 177);
            mainSalesUserControl.Location = new Point(0, 3);
            mainSalesUserControl.Margin = new Padding(5, 5, 5, 5);
            mainSalesUserControl.Name = "mainSalesUserControl";
            mainSalesUserControl.Size = new Size(769, 705);
            mainSalesUserControl.TabIndex = 12;
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
            mainAddManagerUserControl.BackColor = Color.FromArgb(227, 211, 177);
            mainAddManagerUserControl.Location = new Point(151, 1);
            mainAddManagerUserControl.Margin = new Padding(3, 5, 3, 5);
            mainAddManagerUserControl.Name = "mainAddManagerUserControl";
            mainAddManagerUserControl.Size = new Size(523, 252);
            mainAddManagerUserControl.TabIndex = 8;
            // 
            // mainInventoryUserControl
            // 
            mainInventoryUserControl.AutoScroll = true;
            mainInventoryUserControl.BackColor = Color.FromArgb(227, 211, 177);
            mainInventoryUserControl.Location = new Point(0, 1);
            mainInventoryUserControl.Margin = new Padding(3, 5, 3, 5);
            mainInventoryUserControl.Name = "mainInventoryUserControl";
            mainInventoryUserControl.Size = new Size(2266, 772);
            mainInventoryUserControl.TabIndex = 6;
            // 
            // mainAddVendorToStoreUserControl
            // 
            mainAddVendorToStoreUserControl.AutoScroll = true;
            mainAddVendorToStoreUserControl.BackColor = Color.BlanchedAlmond;
            mainAddVendorToStoreUserControl.Location = new Point(0, 0);
            mainAddVendorToStoreUserControl.Margin = new Padding(3, 5, 3, 5);
            mainAddVendorToStoreUserControl.Name = "mainAddVendorToStoreUserControl";
            mainAddVendorToStoreUserControl.Size = new Size(778, 823);
            mainAddVendorToStoreUserControl.TabIndex = 9;
            // 
            // mainOrderUserControl
            // 
            mainOrderUserControl.BackColor = Color.FromArgb(227, 211, 177);
            mainOrderUserControl.Location = new Point(0, 1);
            mainOrderUserControl.Margin = new Padding(5, 5, 5, 5);
            mainOrderUserControl.Name = "mainOrderUserControl";
            mainOrderUserControl.Size = new Size(778, 626);
            mainOrderUserControl.TabIndex = 11;
            // 
            // backButtonPanel
            // 
            backButtonPanel.Controls.Add(backButton);
            backButtonPanel.Location = new Point(14, 69);
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
            addManagerButton.Location = new Point(661, 253);
            addManagerButton.Margin = new Padding(3, 4, 3, 4);
            addManagerButton.Name = "addManagerButton";
            addManagerButton.Size = new Size(160, 180);
            addManagerButton.TabIndex = 9;
            addManagerButton.Text = "Add Manager";
            addManagerButton.TextAlign = ContentAlignment.BottomCenter;
            addManagerButton.TextImageRelation = TextImageRelation.ImageAboveText;
            addManagerButton.UseVisualStyleBackColor = false;
            addManagerButton.Click += MainAddManagerButton_Click;
            // 
            // storeButtonsPanel
            // 
            storeButtonsPanel.Controls.Add(deleteStoreButton);
            storeButtonsPanel.Controls.Add(salesButton);
            storeButtonsPanel.Controls.Add(AddVendorButton);
            storeButtonsPanel.Controls.Add(orderButton);
            storeButtonsPanel.Controls.Add(addManagerButton);
            storeButtonsPanel.Controls.Add(inventoryButton);
            storeButtonsPanel.Controls.Add(exitStoreButton);
            storeButtonsPanel.Controls.Add(addProductButton);
            storeButtonsPanel.Location = new Point(3, 58);
            storeButtonsPanel.Name = "storeButtonsPanel";
            storeButtonsPanel.Size = new Size(845, 556);
            storeButtonsPanel.TabIndex = 10;
            // 
            // deleteStoreButton
            // 
            deleteStoreButton.BackColor = Color.FromArgb(28, 44, 78);
            deleteStoreButton.FlatAppearance.BorderSize = 0;
            deleteStoreButton.FlatStyle = FlatStyle.Flat;
            deleteStoreButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            deleteStoreButton.ForeColor = Color.White;
            deleteStoreButton.Location = new Point(204, 468);
            deleteStoreButton.Margin = new Padding(3, 4, 3, 4);
            deleteStoreButton.Name = "deleteStoreButton";
            deleteStoreButton.Size = new Size(105, 75);
            deleteStoreButton.TabIndex = 11;
            deleteStoreButton.Text = "Delete Store";
            deleteStoreButton.TextImageRelation = TextImageRelation.ImageAboveText;
            deleteStoreButton.UseVisualStyleBackColor = false;
            deleteStoreButton.Click += deleteStoreButton_Click;
            // 
            // salesButton
            // 
            salesButton.BackColor = Color.FromArgb(28, 44, 78);
            salesButton.FlatAppearance.BorderSize = 0;
            salesButton.FlatStyle = FlatStyle.Flat;
            salesButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            salesButton.ForeColor = Color.White;
            salesButton.Image = (Image)resources.GetObject("salesButton.Image");
            salesButton.Location = new Point(338, 253);
            salesButton.Margin = new Padding(3, 4, 3, 4);
            salesButton.Name = "salesButton";
            salesButton.Size = new Size(160, 180);
            salesButton.TabIndex = 10;
            salesButton.Text = "Sales";
            salesButton.TextAlign = ContentAlignment.BottomCenter;
            salesButton.TextImageRelation = TextImageRelation.ImageAboveText;
            salesButton.UseVisualStyleBackColor = false;
            salesButton.Click += salesButton_Click;
            // 
            // salesPanel
            // 
            salesPanel.Controls.Add(salesValueLabel);
            salesPanel.Controls.Add(salesLabel);
            salesPanel.Controls.Add(salesPictureBox);
            salesPanel.Location = new Point(14, 2);
            salesPanel.Margin = new Padding(2, 2, 2, 2);
            salesPanel.Name = "salesPanel";
            salesPanel.Size = new Size(192, 51);
            salesPanel.TabIndex = 11;
            // 
            // salesValueLabel
            // 
            salesValueLabel.AutoSize = true;
            salesValueLabel.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            salesValueLabel.Location = new Point(116, 15);
            salesValueLabel.Margin = new Padding(2, 0, 2, 0);
            salesValueLabel.Name = "salesValueLabel";
            salesValueLabel.Size = new Size(55, 23);
            salesValueLabel.TabIndex = 2;
            salesValueLabel.Text = "label1";
            // 
            // salesLabel
            // 
            salesLabel.Dock = DockStyle.Left;
            salesLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            salesLabel.Location = new Point(50, 0);
            salesLabel.Margin = new Padding(2, 0, 2, 0);
            salesLabel.Name = "salesLabel";
            salesLabel.Size = new Size(82, 51);
            salesLabel.TabIndex = 1;
            salesLabel.Text = "Total Sales: ";
            salesLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // salesPictureBox
            // 
            salesPictureBox.Dock = DockStyle.Left;
            salesPictureBox.Image = (Image)resources.GetObject("salesPictureBox.Image");
            salesPictureBox.Location = new Point(0, 0);
            salesPictureBox.Margin = new Padding(2, 2, 2, 2);
            salesPictureBox.Name = "salesPictureBox";
            salesPictureBox.Size = new Size(50, 51);
            salesPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            salesPictureBox.TabIndex = 0;
            salesPictureBox.TabStop = false;
            // 
            // managersPanel
            // 
            managersPanel.Controls.Add(managerNamesLabel);
            managersPanel.Controls.Add(managerLabel);
            managersPanel.Controls.Add(managerPictureBox);
            managersPanel.Location = new Point(221, 3);
            managersPanel.Margin = new Padding(2, 2, 2, 2);
            managersPanel.Name = "managersPanel";
            managersPanel.Size = new Size(430, 50);
            managersPanel.TabIndex = 12;
            // 
            // managerNamesLabel
            // 
            managerNamesLabel.Dock = DockStyle.Right;
            managerNamesLabel.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            managerNamesLabel.Location = new Point(176, 0);
            managerNamesLabel.Margin = new Padding(2, 0, 2, 0);
            managerNamesLabel.Name = "managerNamesLabel";
            managerNamesLabel.Size = new Size(254, 50);
            managerNamesLabel.TabIndex = 2;
            managerNamesLabel.Text = "Not Assigned";
            managerNamesLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // managerLabel
            // 
            managerLabel.Dock = DockStyle.Left;
            managerLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            managerLabel.Location = new Point(49, 0);
            managerLabel.Margin = new Padding(2, 0, 2, 0);
            managerLabel.Name = "managerLabel";
            managerLabel.Size = new Size(123, 50);
            managerLabel.TabIndex = 1;
            managerLabel.Text = "Store Managers:";
            managerLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // managerPictureBox
            // 
            managerPictureBox.Dock = DockStyle.Left;
            managerPictureBox.Image = (Image)resources.GetObject("managerPictureBox.Image");
            managerPictureBox.Location = new Point(0, 0);
            managerPictureBox.Margin = new Padding(2, 2, 2, 2);
            managerPictureBox.Name = "managerPictureBox";
            managerPictureBox.Size = new Size(49, 50);
            managerPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            managerPictureBox.TabIndex = 0;
            managerPictureBox.TabStop = false;
            // 
            // closePanel
            // 
            closePanel.Controls.Add(statusLabel);
            closePanel.Controls.Add(closeButton);
            closePanel.Location = new Point(664, 3);
            closePanel.Margin = new Padding(2, 2, 2, 2);
            closePanel.Name = "closePanel";
            closePanel.Size = new Size(184, 50);
            closePanel.TabIndex = 13;
            // 
            // statusLabel
            // 
            statusLabel.Dock = DockStyle.Right;
            statusLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            statusLabel.Location = new Point(55, 0);
            statusLabel.Margin = new Padding(2, 0, 2, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(129, 50);
            statusLabel.TabIndex = 3;
            statusLabel.Text = "Store Open";
            statusLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.FromArgb(0, 192, 0);
            closeButton.Dock = DockStyle.Left;
            closeButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            closeButton.ForeColor = SystemColors.ControlText;
            closeButton.Location = new Point(0, 0);
            closeButton.Margin = new Padding(2, 2, 2, 2);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(51, 50);
            closeButton.TabIndex = 0;
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // StoreFrontUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(227, 211, 177);
            Controls.Add(closePanel);
            Controls.Add(managersPanel);
            Controls.Add(salesPanel);
            Controls.Add(storeExpandedPanel);
            Controls.Add(backButtonPanel);
            Controls.Add(storeButtonsPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "StoreFrontUserControl";
            Size = new Size(853, 841);
            Load += StoreFrontUserControl_Load;
            storeExpandedPanel.ResumeLayout(false);
            backButtonPanel.ResumeLayout(false);
            backButtonPanel.PerformLayout();
            storeButtonsPanel.ResumeLayout(false);
            salesPanel.ResumeLayout(false);
            salesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)salesPictureBox).EndInit();
            managersPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)managerPictureBox).EndInit();
            closePanel.ResumeLayout(false);
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
        private Panel storeButtonsPanel;
        private OrderUserControl mainOrderUserControl;
        private Panel salesPanel;
        private PictureBox salesPictureBox;
        private Panel managersPanel;
        private Label managerLabel;
        private PictureBox managerPictureBox;
        private Label salesLabel;
        private Panel closePanel;
        private Button closeButton;
        private Label managerNamesLabel;
        private Label statusLabel;
        private Button deleteStoreButton;
        private Button salesButton;
        private SalesUserControl mainSalesUserControl;
        private Label salesValueLabel;
    }
}
