namespace MyStores.UserControls
{
    partial class VendorTabUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendorTabUserControl));
            searchVendorPanel = new Panel();
            refreshListButton = new Button();
            mainVendorListView = new ListView();
            vendorName = new ColumnHeader();
            city = new ColumnHeader();
            phoneNumber = new ColumnHeader();
            stateName = new ColumnHeader();
            zipCode = new ColumnHeader();
            country = new ColumnHeader();
            searchInputPanel = new Panel();
            searchTextBox = new TextBox();
            searchButtonPanel = new Panel();
            searchButton = new Button();
            searchVendorPanel.SuspendLayout();
            searchInputPanel.SuspendLayout();
            searchButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // searchVendorPanel
            // 
            searchVendorPanel.Controls.Add(refreshListButton);
            searchVendorPanel.Controls.Add(mainVendorListView);
            searchVendorPanel.Controls.Add(searchInputPanel);
            searchVendorPanel.Location = new Point(7, 6);
            searchVendorPanel.Margin = new Padding(7, 6, 7, 6);
            searchVendorPanel.Name = "searchVendorPanel";
            searchVendorPanel.Size = new Size(1180, 887);
            searchVendorPanel.TabIndex = 1;
            // 
            // refreshListButton
            // 
            refreshListButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            refreshListButton.BackColor = Color.FromArgb(28, 44, 78);
            refreshListButton.FlatAppearance.BorderSize = 0;
            refreshListButton.FlatStyle = FlatStyle.Flat;
            refreshListButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            refreshListButton.ForeColor = Color.White;
            refreshListButton.Location = new Point(904, 4);
            refreshListButton.Margin = new Padding(7, 6, 7, 6);
            refreshListButton.Name = "refreshListButton";
            refreshListButton.Size = new Size(262, 73);
            refreshListButton.TabIndex = 108;
            refreshListButton.Text = "Refresh List";
            refreshListButton.UseVisualStyleBackColor = false;
            refreshListButton.Click += RefreshListButton_Click;
            // 
            // mainVendorListView
            // 
            mainVendorListView.BorderStyle = BorderStyle.None;
            mainVendorListView.Columns.AddRange(new ColumnHeader[] { vendorName, city, phoneNumber, stateName, zipCode, country });
            mainVendorListView.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            mainVendorListView.GridLines = true;
            mainVendorListView.Location = new Point(0, 94);
            mainVendorListView.Margin = new Padding(7, 6, 7, 6);
            mainVendorListView.Name = "mainVendorListView";
            mainVendorListView.Size = new Size(1166, 794);
            mainVendorListView.TabIndex = 3;
            mainVendorListView.UseCompatibleStateImageBehavior = false;
            mainVendorListView.View = System.Windows.Forms.View.Details;
            // 
            // vendorName
            // 
            vendorName.Text = "Vendor Name";
            vendorName.Width = 240;
            // 
            // city
            // 
            city.Text = "City";
            city.Width = 180;
            // 
            // phoneNumber
            // 
            phoneNumber.Text = "Phone Number";
            phoneNumber.Width = 220;
            // 
            // stateName
            // 
            stateName.Text = "State Name";
            stateName.Width = 200;
            // 
            // zipCode
            // 
            zipCode.Text = "Zip Code";
            zipCode.Width = 130;
            // 
            // country
            // 
            country.Text = "Country";
            country.Width = 180;
            // 
            // searchInputPanel
            // 
            searchInputPanel.BorderStyle = BorderStyle.FixedSingle;
            searchInputPanel.Controls.Add(searchTextBox);
            searchInputPanel.Controls.Add(searchButtonPanel);
            searchInputPanel.Location = new Point(7, 6);
            searchInputPanel.Margin = new Padding(7, 6, 7, 6);
            searchInputPanel.Name = "searchInputPanel";
            searchInputPanel.Size = new Size(550, 72);
            searchInputPanel.TabIndex = 2;
            // 
            // searchTextBox
            // 
            searchTextBox.BorderStyle = BorderStyle.FixedSingle;
            searchTextBox.Dock = DockStyle.Right;
            searchTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchTextBox.Location = new Point(0, 0);
            searchTextBox.Margin = new Padding(7, 6, 7, 6);
            searchTextBox.Multiline = true;
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "Search for vendors";
            searchTextBox.Size = new Size(483, 70);
            searchTextBox.TabIndex = 1;
            searchTextBox.TextAlign = HorizontalAlignment.Center;
            searchTextBox.GotFocus += SearchTextBox_GotFocus;
            // 
            // searchButtonPanel
            // 
            searchButtonPanel.Controls.Add(searchButton);
            searchButtonPanel.Dock = DockStyle.Right;
            searchButtonPanel.Location = new Point(483, 0);
            searchButtonPanel.Margin = new Padding(7, 6, 7, 6);
            searchButtonPanel.Name = "searchButtonPanel";
            searchButtonPanel.Size = new Size(65, 70);
            searchButtonPanel.TabIndex = 0;
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            searchButton.AutoSize = true;
            searchButton.BackColor = Color.White;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Image = (Image)resources.GetObject("searchButton.Image");
            searchButton.Location = new Point(0, -2);
            searchButton.Margin = new Padding(7, 6, 7, 6);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(67, 75);
            searchButton.TabIndex = 2;
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += SearchButton_Click;
            // 
            // VendorTabUserControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 211, 177);
            Controls.Add(searchVendorPanel);
            Margin = new Padding(7, 6, 7, 6);
            Name = "VendorTabUserControl";
            Size = new Size(1187, 900);
            Load += VendorTabUserControl_Load;
            searchVendorPanel.ResumeLayout(false);
            searchInputPanel.ResumeLayout(false);
            searchInputPanel.PerformLayout();
            searchButtonPanel.ResumeLayout(false);
            searchButtonPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel searchVendorPanel;
        private Panel searchInputPanel;
        private TextBox searchTextBox;
        private Panel searchButtonPanel;
        private Button searchButton;
        private ListView mainVendorListView;
        private ColumnHeader vendorName;
        private ColumnHeader city;
        private ColumnHeader phoneNumber;
        private ColumnHeader stateName;
        private ColumnHeader zipCode;
        private ColumnHeader country;
        private Button refreshListButton;
    }
}
