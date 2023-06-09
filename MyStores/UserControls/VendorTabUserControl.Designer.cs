﻿namespace MyStores.UserControls
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
            this.searchVendorPanel = new System.Windows.Forms.Panel();
            this.refreshListButton = new System.Windows.Forms.Button();
            this.mainVendorListView = new System.Windows.Forms.ListView();
            this.vendorName = new System.Windows.Forms.ColumnHeader();
            this.city = new System.Windows.Forms.ColumnHeader();
            this.phoneNumber = new System.Windows.Forms.ColumnHeader();
            this.stateName = new System.Windows.Forms.ColumnHeader();
            this.zipCode = new System.Windows.Forms.ColumnHeader();
            this.country = new System.Windows.Forms.ColumnHeader();
            this.searchInputPanel = new System.Windows.Forms.Panel();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButtonPanel = new System.Windows.Forms.Panel();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchVendorPanel.SuspendLayout();
            this.searchInputPanel.SuspendLayout();
            this.searchButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchVendorPanel
            // 
            this.searchVendorPanel.Controls.Add(this.refreshListButton);
            this.searchVendorPanel.Controls.Add(this.mainVendorListView);
            this.searchVendorPanel.Controls.Add(this.searchInputPanel);
            this.searchVendorPanel.Location = new System.Drawing.Point(4, 3);
            this.searchVendorPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.searchVendorPanel.Name = "searchVendorPanel";
            this.searchVendorPanel.Size = new System.Drawing.Size(744, 416);
            this.searchVendorPanel.TabIndex = 1;
            // 
            // refreshListButton
            // 
            this.refreshListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.refreshListButton.FlatAppearance.BorderSize = 0;
            this.refreshListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshListButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.refreshListButton.ForeColor = System.Drawing.Color.White;
            this.refreshListButton.Location = new System.Drawing.Point(627, 2);
            this.refreshListButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.refreshListButton.Name = "refreshListButton";
            this.refreshListButton.Size = new System.Drawing.Size(113, 34);
            this.refreshListButton.TabIndex = 108;
            this.refreshListButton.Text = "Refresh List";
            this.refreshListButton.UseVisualStyleBackColor = false;
            this.refreshListButton.Click += new System.EventHandler(this.RefreshListButton_Click);
            // 
            // mainVendorListView
            // 
            this.mainVendorListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainVendorListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.vendorName,
            this.city,
            this.phoneNumber,
            this.stateName,
            this.zipCode,
            this.country});
            this.mainVendorListView.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mainVendorListView.GridLines = true;
            this.mainVendorListView.Location = new System.Drawing.Point(0, 44);
            this.mainVendorListView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mainVendorListView.Name = "mainVendorListView";
            this.mainVendorListView.Size = new System.Drawing.Size(744, 372);
            this.mainVendorListView.TabIndex = 3;
            this.mainVendorListView.UseCompatibleStateImageBehavior = false;
            this.mainVendorListView.View = System.Windows.Forms.View.Details;
            // 
            // vendorName
            // 
            this.vendorName.Text = "Vendor Name";
            this.vendorName.Width = 180;
            // 
            // city
            // 
            this.city.Text = "City";
            this.city.Width = 110;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Text = "Phone Number";
            this.phoneNumber.Width = 110;
            // 
            // stateName
            // 
            this.stateName.Text = "State Name";
            this.stateName.Width = 110;
            // 
            // zipCode
            // 
            this.zipCode.Text = "Zip Code";
            this.zipCode.Width = 110;
            // 
            // country
            // 
            this.country.Text = "Country";
            this.country.Width = 120;
            // 
            // searchInputPanel
            // 
            this.searchInputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchInputPanel.Controls.Add(this.searchTextBox);
            this.searchInputPanel.Controls.Add(this.searchButtonPanel);
            this.searchInputPanel.Location = new System.Drawing.Point(4, 3);
            this.searchInputPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.searchInputPanel.Name = "searchInputPanel";
            this.searchInputPanel.Size = new System.Drawing.Size(297, 35);
            this.searchInputPanel.TabIndex = 2;
            // 
            // searchTextBox
            // 
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchTextBox.Location = new System.Drawing.Point(-1, 0);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PlaceholderText = "Search for vendors";
            this.searchTextBox.Size = new System.Drawing.Size(261, 33);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchTextBox.GotFocus += new System.EventHandler(this.SearchTextBox_GotFocus);
            // 
            // searchButtonPanel
            // 
            this.searchButtonPanel.Controls.Add(this.searchButton);
            this.searchButtonPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchButtonPanel.Location = new System.Drawing.Point(260, 0);
            this.searchButtonPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.searchButtonPanel.Name = "searchButtonPanel";
            this.searchButtonPanel.Size = new System.Drawing.Size(35, 33);
            this.searchButtonPanel.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.AutoSize = true;
            this.searchButton.BackColor = System.Drawing.Color.White;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(0, -1);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(36, 35);
            this.searchButton.TabIndex = 2;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // VendorTabUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.Controls.Add(this.searchVendorPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "VendorTabUserControl";
            this.Size = new System.Drawing.Size(751, 422);
            this.Load += new System.EventHandler(this.VendorTabUserControl_Load);
            this.searchVendorPanel.ResumeLayout(false);
            this.searchInputPanel.ResumeLayout(false);
            this.searchInputPanel.PerformLayout();
            this.searchButtonPanel.ResumeLayout(false);
            this.searchButtonPanel.PerformLayout();
            this.ResumeLayout(false);

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
