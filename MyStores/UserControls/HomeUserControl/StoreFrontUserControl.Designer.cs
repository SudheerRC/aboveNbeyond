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
            mainOrderUserControl = new OrderUserControl();
            mainAddProductToStoreUserControl = new AddProductToStoreUserControl();
            mainAddManagerUserControl = new AddManagerUserControl();
            mainInventoryUserControl = new InventoryUserControl();
            mainAddVendorToStoreUserControl = new AddVendorToStoreUserControl();
            backButtonPanel = new Panel();
            backButton = new Button();
            addManagerButton = new Button();
            storeButtonsPanel = new Panel();
            salesPanel = new Panel();
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
            AddVendorButton.Location = new Point(42, 18);
            AddVendorButton.Margin = new Padding(5, 6, 5, 6);
            AddVendorButton.Name = "AddVendorButton";
            AddVendorButton.Size = new Size(260, 320);
            AddVendorButton.TabIndex = 2;
            AddVendorButton.Text = "Add Vendor";
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
            addProductButton.Location = new Point(291, 405);
            addProductButton.Margin = new Padding(5, 6, 5, 6);
            addProductButton.Name = "addProductButton";
            addProductButton.Size = new Size(260, 320);
            addProductButton.TabIndex = 4;
            addProductButton.Text = "Add Product";
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
            inventoryButton.Location = new Point(549, 21);
            inventoryButton.Margin = new Padding(5, 6, 5, 6);
            inventoryButton.Name = "inventoryButton";
            inventoryButton.Size = new Size(260, 320);
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
            orderButton.Location = new Point(1074, 18);
            orderButton.Margin = new Padding(5, 6, 5, 6);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(260, 320);
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
            exitStoreButton.Image = (Image)resources.GetObject("exitStoreButton.Image");
            exitStoreButton.Location = new Point(1194, 683);
            exitStoreButton.Margin = new Padding(5, 6, 5, 6);
            exitStoreButton.Name = "exitStoreButton";
            exitStoreButton.Size = new Size(172, 147);
            exitStoreButton.TabIndex = 7;
            exitStoreButton.Text = "Exit Store";
            exitStoreButton.TextAlign = ContentAlignment.BottomCenter;
            exitStoreButton.TextImageRelation = TextImageRelation.ImageAboveText;
            exitStoreButton.UseVisualStyleBackColor = false;
            exitStoreButton.Click += exitStoreButton_Click;
            // 
            // storeExpandedPanel
            // 
            storeExpandedPanel.BackColor = Color.FromArgb(227, 211, 177);
            storeExpandedPanel.Controls.Add(mainOrderUserControl);
            storeExpandedPanel.Controls.Add(mainAddProductToStoreUserControl);
            storeExpandedPanel.Controls.Add(mainAddManagerUserControl);
            storeExpandedPanel.Controls.Add(mainInventoryUserControl);
            storeExpandedPanel.Controls.Add(mainAddVendorToStoreUserControl);
            storeExpandedPanel.Location = new Point(114, 94);
            storeExpandedPanel.Margin = new Padding(5, 6, 5, 6);
            storeExpandedPanel.Name = "storeExpandedPanel";
            storeExpandedPanel.Size = new Size(3757, 1242);
            storeExpandedPanel.TabIndex = 8;
            storeExpandedPanel.Visible = false;
            // 
            // mainOrderUserControl
            // 
            mainOrderUserControl.BackColor = Color.FromArgb(227, 211, 177);
            mainOrderUserControl.Location = new Point(0, 2);
            mainOrderUserControl.Margin = new Padding(8);
            mainOrderUserControl.Name = "mainOrderUserControl";
            mainOrderUserControl.Size = new Size(1264, 1002);
            mainOrderUserControl.TabIndex = 11;
            // 
            // mainAddProductToStoreUserControl
            // 
            mainAddProductToStoreUserControl.BackColor = Color.BlanchedAlmond;
            mainAddProductToStoreUserControl.Location = new Point(0, 0);
            mainAddProductToStoreUserControl.Margin = new Padding(5, 8, 5, 8);
            mainAddProductToStoreUserControl.Name = "mainAddProductToStoreUserControl";
            mainAddProductToStoreUserControl.Size = new Size(1186, 891);
            mainAddProductToStoreUserControl.TabIndex = 10;
            // 
            // mainAddManagerUserControl
            // 
            mainAddManagerUserControl.BackColor = Color.BlanchedAlmond;
            mainAddManagerUserControl.Location = new Point(245, 2);
            mainAddManagerUserControl.Margin = new Padding(5, 8, 5, 8);
            mainAddManagerUserControl.Name = "mainAddManagerUserControl";
            mainAddManagerUserControl.Size = new Size(850, 403);
            mainAddManagerUserControl.TabIndex = 8;
            // 
            // mainInventoryUserControl
            // 
            mainInventoryUserControl.AutoScroll = true;
            mainInventoryUserControl.BackColor = Color.FromArgb(227, 211, 177);
            mainInventoryUserControl.Location = new Point(0, 2);
            mainInventoryUserControl.Margin = new Padding(5, 8, 5, 8);
            mainInventoryUserControl.Name = "mainInventoryUserControl";
            mainInventoryUserControl.Size = new Size(3682, 1235);
            mainInventoryUserControl.TabIndex = 6;
            // 
            // mainAddVendorToStoreUserControl
            // 
            mainAddVendorToStoreUserControl.AutoScroll = true;
            mainAddVendorToStoreUserControl.BackColor = Color.BlanchedAlmond;
            mainAddVendorToStoreUserControl.Location = new Point(0, 0);
            mainAddVendorToStoreUserControl.Margin = new Padding(5, 8, 5, 8);
            mainAddVendorToStoreUserControl.Name = "mainAddVendorToStoreUserControl";
            mainAddVendorToStoreUserControl.Size = new Size(1264, 1317);
            mainAddVendorToStoreUserControl.TabIndex = 9;
            // 
            // backButtonPanel
            // 
            backButtonPanel.Controls.Add(backButton);
            backButtonPanel.Location = new Point(23, 94);
            backButtonPanel.Margin = new Padding(5, 6, 5, 6);
            backButtonPanel.Name = "backButtonPanel";
            backButtonPanel.Size = new Size(81, 77);
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
            backButton.Location = new Point(27, 0);
            backButton.Margin = new Padding(5, 6, 5, 6);
            backButton.Name = "backButton";
            backButton.Size = new Size(54, 77);
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
            addManagerButton.Location = new Point(814, 405);
            addManagerButton.Margin = new Padding(5, 6, 5, 6);
            addManagerButton.Name = "addManagerButton";
            addManagerButton.Size = new Size(260, 320);
            addManagerButton.TabIndex = 9;
            addManagerButton.Text = "Add Manager";
            addManagerButton.TextAlign = ContentAlignment.BottomCenter;
            addManagerButton.TextImageRelation = TextImageRelation.ImageAboveText;
            addManagerButton.UseVisualStyleBackColor = false;
            addManagerButton.Click += MainAddManagerButton_Click;
            // 
            // storeButtonsPanel
            // 
            storeButtonsPanel.Controls.Add(AddVendorButton);
            storeButtonsPanel.Controls.Add(orderButton);
            storeButtonsPanel.Controls.Add(addManagerButton);
            storeButtonsPanel.Controls.Add(inventoryButton);
            storeButtonsPanel.Controls.Add(exitStoreButton);
            storeButtonsPanel.Controls.Add(addProductButton);
            storeButtonsPanel.Location = new Point(5, 77);
            storeButtonsPanel.Margin = new Padding(5);
            storeButtonsPanel.Name = "storeButtonsPanel";
            storeButtonsPanel.Size = new Size(1373, 837);
            storeButtonsPanel.TabIndex = 10;
            // 
            // salesPanel
            // 
            salesPanel.Controls.Add(salesLabel);
            salesPanel.Controls.Add(salesPictureBox);
            salesPanel.Location = new Point(41, 3);
            salesPanel.Name = "salesPanel";
            salesPanel.Size = new Size(266, 64);
            salesPanel.TabIndex = 11;
            // 
            // salesLabel
            // 
            salesLabel.AutoSize = true;
            salesLabel.Location = new Point(54, 15);
            salesLabel.Name = "salesLabel";
            salesLabel.Size = new Size(207, 32);
            salesLabel.TabIndex = 1;
            salesLabel.Text = "Total Sales: Soon!!";
            // 
            // salesPictureBox
            // 
            salesPictureBox.Dock = DockStyle.Left;
            salesPictureBox.Image = (Image)resources.GetObject("salesPictureBox.Image");
            salesPictureBox.Location = new Point(0, 0);
            salesPictureBox.Name = "salesPictureBox";
            salesPictureBox.Size = new Size(48, 64);
            salesPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            salesPictureBox.TabIndex = 0;
            salesPictureBox.TabStop = false;
            // 
            // managersPanel
            // 
            managersPanel.Controls.Add(managerNamesLabel);
            managersPanel.Controls.Add(managerLabel);
            managersPanel.Controls.Add(managerPictureBox);
            managersPanel.Location = new Point(384, 5);
            managersPanel.Name = "managersPanel";
            managersPanel.Size = new Size(674, 64);
            managersPanel.TabIndex = 12;
            // 
            // managerNamesLabel
            // 
            managerNamesLabel.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            managerNamesLabel.Location = new Point(248, 0);
            managerNamesLabel.Name = "managerNamesLabel";
            managerNamesLabel.Size = new Size(426, 62);
            managerNamesLabel.TabIndex = 2;
            managerNamesLabel.Text = "names";
            managerNamesLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // managerLabel
            // 
            managerLabel.AutoSize = true;
            managerLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            managerLabel.Location = new Point(54, 13);
            managerLabel.Name = "managerLabel";
            managerLabel.Size = new Size(200, 32);
            managerLabel.TabIndex = 1;
            managerLabel.Text = "Store Managers:";
            // 
            // managerPictureBox
            // 
            managerPictureBox.Dock = DockStyle.Left;
            managerPictureBox.Image = (Image)resources.GetObject("managerPictureBox.Image");
            managerPictureBox.Location = new Point(0, 0);
            managerPictureBox.Name = "managerPictureBox";
            managerPictureBox.Size = new Size(48, 64);
            managerPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            managerPictureBox.TabIndex = 0;
            managerPictureBox.TabStop = false;
            // 
            // closePanel
            // 
            closePanel.Controls.Add(statusLabel);
            closePanel.Controls.Add(closeButton);
            closePanel.Location = new Point(1163, 5);
            closePanel.Name = "closePanel";
            closePanel.Size = new Size(215, 62);
            closePanel.TabIndex = 13;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            statusLabel.Location = new Point(52, 13);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(150, 37);
            statusLabel.TabIndex = 3;
            statusLabel.Text = "Store Open";
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.FromArgb(0, 192, 0);
            closeButton.Dock = DockStyle.Left;
            closeButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            closeButton.ForeColor = SystemColors.ControlText;
            closeButton.Location = new Point(0, 0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(46, 62);
            closeButton.TabIndex = 0;
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // StoreFrontUserControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(227, 211, 177);
            Controls.Add(closePanel);
            Controls.Add(managersPanel);
            Controls.Add(salesPanel);
            Controls.Add(storeExpandedPanel);
            Controls.Add(storeButtonsPanel);
            Controls.Add(backButtonPanel);
            Margin = new Padding(5, 6, 5, 6);
            Name = "StoreFrontUserControl";
            Size = new Size(1386, 1346);
            Load += StoreFrontUserControl_Load;
            storeExpandedPanel.ResumeLayout(false);
            backButtonPanel.ResumeLayout(false);
            backButtonPanel.PerformLayout();
            storeButtonsPanel.ResumeLayout(false);
            salesPanel.ResumeLayout(false);
            salesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)salesPictureBox).EndInit();
            managersPanel.ResumeLayout(false);
            managersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)managerPictureBox).EndInit();
            closePanel.ResumeLayout(false);
            closePanel.PerformLayout();
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
    }
}
