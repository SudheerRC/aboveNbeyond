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
            this.button5 = new System.Windows.Forms.Button();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.homeMenuButton = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.workspaceContainer = new System.Windows.Forms.SplitContainer();
            this.storeContainer = new System.Windows.Forms.SplitContainer();
            this.storeNameLabel = new System.Windows.Forms.Label();
            this.mainStoreFrontUserControl = new MyStores.UserControls.HomeUserControl.StoreFrontUserControl();
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
            button5.Location = new Point(0, 955);
            button5.Name = "button5";
            button5.Padding = new Padding(2, 0, 0, 0);
            button5.Size = new Size(208, 50);
            button5.TabIndex = 7;
            button5.Text = "Logout";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.UseVisualStyleBackColor = false;
            // 
            // navigationPanel
            // 
            this.navigationPanel.AutoScroll = true;
            this.navigationPanel.Controls.Add(this.button8);
            this.navigationPanel.Controls.Add(this.button7);
            this.navigationPanel.Controls.Add(this.button6);
            this.navigationPanel.Controls.Add(this.button4);
            this.navigationPanel.Controls.Add(this.button3);
            this.navigationPanel.Controls.Add(this.button2);
            this.navigationPanel.Controls.Add(this.button1);
            this.navigationPanel.Controls.Add(this.homeMenuButton);
            this.navigationPanel.Location = new System.Drawing.Point(3, 159);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(208, 576);
            this.navigationPanel.TabIndex = 2;
            // 
            // button8
            // 
            this.button8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(0, 350);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(208, 50);
            this.button8.TabIndex = 9;
            this.button8.Text = "Add Vendor";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(0, 300);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(208, 50);
            this.button7.TabIndex = 8;
            this.button7.Text = "Search Vendor";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 250);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(208, 50);
            this.button6.TabIndex = 7;
            this.button6.Text = "Search product";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 200);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(208, 50);
            this.button4.TabIndex = 6;
            this.button4.Text = "Vendors";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 150);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(208, 50);
            this.button3.TabIndex = 5;
            this.button3.Text = "Orders";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 100);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(208, 50);
            this.button2.TabIndex = 4;
            this.button2.Text = "Add product";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 50);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(208, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Products";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
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
            this.homeMenuButton.Size = new System.Drawing.Size(208, 50);
            this.homeMenuButton.TabIndex = 2;
            this.homeMenuButton.Text = "Home";
            this.homeMenuButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.homeMenuButton.UseVisualStyleBackColor = false;
            this.homeMenuButton.Click += new System.EventHandler(this.homeMenuButton_Click);
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
            this.storeContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.storeContainer.Panel2.Controls.Add(this.mainStoreFrontUserControl);
            this.storeContainer.Panel2.Controls.Add(this.mainHomeTabUserControl);
            this.storeContainer.Size = new System.Drawing.Size(1393, 1041);
            this.storeContainer.SplitterDistance = 140;
            this.storeContainer.SplitterWidth = 1;
            this.storeContainer.TabIndex = 0;
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
            // mainStoreFrontUserControl
            // 
            this.mainStoreFrontUserControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainStoreFrontUserControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.mainStoreFrontUserControl.Location = new System.Drawing.Point(1, 0);
            this.mainStoreFrontUserControl.Name = "mainStoreFrontUserControl";
            this.mainStoreFrontUserControl.Size = new System.Drawing.Size(1390, 900);
            this.mainStoreFrontUserControl.TabIndex = 1;
            // 
            // mainHomeTabUserControl
            // 
            this.mainHomeTabUserControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainHomeTabUserControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.mainHomeTabUserControl.Location = new System.Drawing.Point(0, 0);
            this.mainHomeTabUserControl.Name = "mainHomeTabUserControl";
            this.mainHomeTabUserControl.Size = new System.Drawing.Size(1393, 909);
            this.mainHomeTabUserControl.TabIndex = 0;
            // 
            // searchPanel
            // 
            this.searchPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchPanel.Controls.Add(this.searchInputPanel);
            this.searchPanel.Location = new System.Drawing.Point(3, 106);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(303, 299);
            this.searchPanel.TabIndex = 7;
            // 
            // searchInputPanel
            // 
            this.searchInputPanel.Controls.Add(this.searchTextBox);
            this.searchInputPanel.Controls.Add(this.searchButtonPanel);
            this.searchInputPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchInputPanel.Location = new System.Drawing.Point(0, 0);
            this.searchInputPanel.Name = "searchInputPanel";
            this.searchInputPanel.Size = new System.Drawing.Size(303, 35);
            this.searchInputPanel.TabIndex = 0;
            // 
            // searchTextBox
            // 
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTextBox.Location = new System.Drawing.Point(0, 0);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(268, 35);
            this.searchTextBox.TabIndex = 6;
            // 
            // searchButtonPanel
            // 
            this.searchButtonPanel.Controls.Add(this.searchButton);
            this.searchButtonPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchButtonPanel.Location = new System.Drawing.Point(268, 0);
            this.searchButtonPanel.Name = "searchButtonPanel";
            this.searchButtonPanel.Size = new System.Drawing.Size(35, 35);
            this.searchButtonPanel.TabIndex = 0;
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
            // addStoreUserControl
            // 
            addStoreUserControl.BackColor = Color.FromArgb(28, 44, 78);
            addStoreUserControl.Location = new Point(362, 3);
            addStoreUserControl.Name = "addStoreUserControl";
            addStoreUserControl.Size = new Size(160, 200);
            addStoreUserControl.TabIndex = 0;
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
            this.Load += new System.EventHandler(this.MainDashboard_Load);
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
        private Button button5;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button restoreButton;
        private UserControls.HomeUserControl.HomeTabUserControl mainHomeTabUserControl;
        private UserControls.HomeUserControl.StoreFrontUserControl mainStoreFrontUserControl;
    }
}