﻿namespace MyStores.UserControls
{
    partial class AddVendorToStoreUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddVendorToStoreUserControl));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.closeVendorFormPictureBox = new System.Windows.Forms.PictureBox();
            this.addVendorToStoreButton = new System.Windows.Forms.Button();
            this.vendorInfoPanel = new System.Windows.Forms.Panel();
            this.addVendorButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.infoGraphicPictureBox = new System.Windows.Forms.PictureBox();
            this.selectVendorLabel = new System.Windows.Forms.Label();
            this.vendorComboBox = new System.Windows.Forms.ComboBox();
            this.mainAddVendorUserControl = new MyStores.UserControls.AddVendorUserControl();
            this.infoLabel = new System.Windows.Forms.Label();
            this.storeVendorListView = new System.Windows.Forms.ListView();
            this.vendorName = new System.Windows.Forms.ColumnHeader();
            this.city = new System.Windows.Forms.ColumnHeader();
            this.phoneNumber = new System.Windows.Forms.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeVendorFormPictureBox)).BeginInit();
            this.vendorInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoGraphicPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.closeVendorFormPictureBox);
            this.splitContainer1.Panel1.Controls.Add(this.addVendorToStoreButton);
            this.splitContainer1.Panel1.Controls.Add(this.vendorInfoPanel);
            this.splitContainer1.Panel1.Controls.Add(this.selectVendorLabel);
            this.splitContainer1.Panel1.Controls.Add(this.vendorComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.mainAddVendorUserControl);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.infoLabel);
            this.splitContainer1.Panel2.Controls.Add(this.storeVendorListView);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Size = new System.Drawing.Size(810, 617);
            this.splitContainer1.SplitterDistance = 386;
            this.splitContainer1.TabIndex = 0;
            // 
            // closeVendorFormPictureBox
            // 
            this.closeVendorFormPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("closeVendorFormPictureBox.Image")));
            this.closeVendorFormPictureBox.Location = new System.Drawing.Point(168, 562);
            this.closeVendorFormPictureBox.Name = "closeVendorFormPictureBox";
            this.closeVendorFormPictureBox.Size = new System.Drawing.Size(48, 48);
            this.closeVendorFormPictureBox.TabIndex = 108;
            this.closeVendorFormPictureBox.TabStop = false;
            this.closeVendorFormPictureBox.Visible = false;
            this.closeVendorFormPictureBox.Click += new System.EventHandler(this.closeVendorFormPictureBox_Click);
            // 
            // addVendorToStoreButton
            // 
            this.addVendorToStoreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addVendorToStoreButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.addVendorToStoreButton.FlatAppearance.BorderSize = 0;
            this.addVendorToStoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addVendorToStoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addVendorToStoreButton.ForeColor = System.Drawing.Color.White;
            this.addVendorToStoreButton.Location = new System.Drawing.Point(133, 91);
            this.addVendorToStoreButton.Name = "addVendorToStoreButton";
            this.addVendorToStoreButton.Size = new System.Drawing.Size(166, 44);
            this.addVendorToStoreButton.TabIndex = 107;
            this.addVendorToStoreButton.Text = "Add Vendor to Store";
            this.addVendorToStoreButton.UseVisualStyleBackColor = false;
            this.addVendorToStoreButton.Click += new System.EventHandler(this.addVendorToStoreButton_Click);
            // 
            // vendorInfoPanel
            // 
            this.vendorInfoPanel.Controls.Add(this.addVendorButton);
            this.vendorInfoPanel.Controls.Add(this.messageLabel);
            this.vendorInfoPanel.Controls.Add(this.infoGraphicPictureBox);
            this.vendorInfoPanel.Location = new System.Drawing.Point(17, 397);
            this.vendorInfoPanel.Name = "vendorInfoPanel";
            this.vendorInfoPanel.Padding = new System.Windows.Forms.Padding(8);
            this.vendorInfoPanel.Size = new System.Drawing.Size(351, 162);
            this.vendorInfoPanel.TabIndex = 106;
            // 
            // addVendorButton
            // 
            this.addVendorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addVendorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.addVendorButton.FlatAppearance.BorderSize = 0;
            this.addVendorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addVendorButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addVendorButton.ForeColor = System.Drawing.Color.White;
            this.addVendorButton.Location = new System.Drawing.Point(114, 107);
            this.addVendorButton.Name = "addVendorButton";
            this.addVendorButton.Size = new System.Drawing.Size(166, 44);
            this.addVendorButton.TabIndex = 15;
            this.addVendorButton.Text = "Add New Vendor";
            this.addVendorButton.UseVisualStyleBackColor = false;
            this.addVendorButton.Click += new System.EventHandler(this.addVendorButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.messageLabel.Location = new System.Drawing.Point(65, 11);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(275, 93);
            this.messageLabel.TabIndex = 13;
            this.messageLabel.Text = "Info Message";
            // 
            // infoGraphicPictureBox
            // 
            this.infoGraphicPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("infoGraphicPictureBox.Image")));
            this.infoGraphicPictureBox.Location = new System.Drawing.Point(11, 11);
            this.infoGraphicPictureBox.Name = "infoGraphicPictureBox";
            this.infoGraphicPictureBox.Size = new System.Drawing.Size(48, 48);
            this.infoGraphicPictureBox.TabIndex = 0;
            this.infoGraphicPictureBox.TabStop = false;
            // 
            // selectVendorLabel
            // 
            this.selectVendorLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectVendorLabel.Location = new System.Drawing.Point(15, 35);
            this.selectVendorLabel.Name = "selectVendorLabel";
            this.selectVendorLabel.Size = new System.Drawing.Size(137, 35);
            this.selectVendorLabel.TabIndex = 13;
            this.selectVendorLabel.Text = "Select Vendor:";
            this.selectVendorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // vendorComboBox
            // 
            this.vendorComboBox.DropDownHeight = 110;
            this.vendorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vendorComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vendorComboBox.FormattingEnabled = true;
            this.vendorComboBox.IntegralHeight = false;
            this.vendorComboBox.Location = new System.Drawing.Point(171, 40);
            this.vendorComboBox.MaxDropDownItems = 99;
            this.vendorComboBox.Name = "vendorComboBox";
            this.vendorComboBox.Size = new System.Drawing.Size(170, 29);
            this.vendorComboBox.TabIndex = 12;
            // 
            // mainAddVendorUserControl
            // 
            this.mainAddVendorUserControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainAddVendorUserControl.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.mainAddVendorUserControl.Location = new System.Drawing.Point(19, 140);
            this.mainAddVendorUserControl.Name = "mainAddVendorUserControl";
            this.mainAddVendorUserControl.Size = new System.Drawing.Size(346, 473);
            this.mainAddVendorUserControl.TabIndex = 0;
            this.mainAddVendorUserControl.Visible = false;
            // 
            // infoLabel
            // 
            this.infoLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.infoLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.infoLabel.Location = new System.Drawing.Point(2, 21);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(416, 31);
            this.infoLabel.TabIndex = 90;
            this.infoLabel.Text = "List of Vendors for this store";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.infoLabel.UseCompatibleTextRendering = true;
            // 
            // storeVendorListView
            // 
            this.storeVendorListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.storeVendorListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.vendorName,
            this.city,
            this.phoneNumber});
            this.storeVendorListView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.storeVendorListView.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.storeVendorListView.FullRowSelect = true;
            this.storeVendorListView.GridLines = true;
            this.storeVendorListView.Location = new System.Drawing.Point(4, 65);
            this.storeVendorListView.Name = "storeVendorListView";
            this.storeVendorListView.Size = new System.Drawing.Size(412, 548);
            this.storeVendorListView.TabIndex = 0;
            this.storeVendorListView.UseCompatibleStateImageBehavior = false;
            this.storeVendorListView.View = System.Windows.Forms.View.Details;
            // 
            // vendorName
            // 
            this.vendorName.Text = "Vendor Name";
            this.vendorName.Width = 140;
            // 
            // city
            // 
            this.city.Text = "City";
            this.city.Width = 140;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Text = "Phone Number";
            this.phoneNumber.Width = 130;
            // 
            // AddVendorToStoreUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Controls.Add(this.splitContainer1);
            this.Name = "AddVendorToStoreUserControl";
            this.Size = new System.Drawing.Size(810, 617);
            this.Load += new System.EventHandler(this.AddVendorToStoreUserControl_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeVendorFormPictureBox)).EndInit();
            this.vendorInfoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoGraphicPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private AddVendorUserControl addVendorUserControl1;
        private AddVendorUserControl mainAddVendorUserControl;
        private ListView storeVendorListView;
        private ColumnHeader vendorName;
        private ColumnHeader city;
        private ColumnHeader phoneNumber;
        private Label infoLabel;
        private Label selectVendorLabel;
        private ComboBox vendorComboBox;
        private Button addVendorToStoreButton;
        private Panel vendorInfoPanel;
        private Button addVendorButton;
        private Label messageLabel;
        private PictureBox infoGraphicPictureBox;
        private PictureBox closeVendorFormPictureBox;
    }
}
