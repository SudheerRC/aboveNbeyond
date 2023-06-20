namespace MyStores.UserControls
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
            this.mainAddVendorUserControl = new MyStores.UserControls.AddVendorUserControl();
            this.storeVendorListView = new System.Windows.Forms.ListView();
            this.vendorName = new System.Windows.Forms.ColumnHeader();
            this.city = new System.Windows.Forms.ColumnHeader();
            this.phoneNumber = new System.Windows.Forms.ColumnHeader();
            this.infoLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.vendorInfoPanel = new System.Windows.Forms.Panel();
            this.addVendorToStoreButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.infoGraphicPictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.errorLabel);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.vendorInfoPanel);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
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
            // mainAddVendorUserControl
            // 
            this.mainAddVendorUserControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainAddVendorUserControl.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.mainAddVendorUserControl.Location = new System.Drawing.Point(15, 140);
            this.mainAddVendorUserControl.Name = "mainAddVendorUserControl";
            this.mainAddVendorUserControl.Size = new System.Drawing.Size(346, 473);
            this.mainAddVendorUserControl.TabIndex = 0;
            // 
            // storeVendorListView
            // 
            this.storeVendorListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.vendorName,
            this.city,
            this.phoneNumber});
            this.storeVendorListView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.storeVendorListView.Location = new System.Drawing.Point(4, 65);
            this.storeVendorListView.Name = "storeVendorListView";
            this.storeVendorListView.Size = new System.Drawing.Size(412, 548);
            this.storeVendorListView.TabIndex = 0;
            this.storeVendorListView.UseCompatibleStateImageBehavior = false;
            // 
            // vendorName
            // 
            this.vendorName.Text = "Vendor Name";
            this.vendorName.Width = 220;
            // 
            // city
            // 
            this.city.Text = "City";
            this.city.Width = 220;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Text = "Phone Number";
            this.phoneNumber.Width = 220;
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
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(15, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 35);
            this.label4.TabIndex = 13;
            this.label4.Text = "Select Vendor:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownHeight = 110;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Location = new System.Drawing.Point(171, 40);
            this.comboBox1.MaxDropDownItems = 99;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 29);
            this.comboBox1.TabIndex = 12;
            // 
            // vendorInfoPanel
            // 
            this.vendorInfoPanel.Controls.Add(this.addVendorToStoreButton);
            this.vendorInfoPanel.Controls.Add(this.messageLabel);
            this.vendorInfoPanel.Controls.Add(this.infoGraphicPictureBox);
            this.vendorInfoPanel.Location = new System.Drawing.Point(17, 397);
            this.vendorInfoPanel.Name = "vendorInfoPanel";
            this.vendorInfoPanel.Padding = new System.Windows.Forms.Padding(8);
            this.vendorInfoPanel.Size = new System.Drawing.Size(351, 162);
            this.vendorInfoPanel.TabIndex = 106;
            // 
            // addVendorToStoreButton
            // 
            this.addVendorToStoreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addVendorToStoreButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.addVendorToStoreButton.Enabled = false;
            this.addVendorToStoreButton.FlatAppearance.BorderSize = 0;
            this.addVendorToStoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addVendorToStoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addVendorToStoreButton.ForeColor = System.Drawing.Color.White;
            this.addVendorToStoreButton.Location = new System.Drawing.Point(114, 107);
            this.addVendorToStoreButton.Name = "addVendorToStoreButton";
            this.addVendorToStoreButton.Size = new System.Drawing.Size(166, 44);
            this.addVendorToStoreButton.TabIndex = 15;
            this.addVendorToStoreButton.Text = "Add New Vendor";
            this.addVendorToStoreButton.UseVisualStyleBackColor = false;
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
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(133, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 44);
            this.button1.TabIndex = 107;
            this.button1.Text = "Add Vendor to Store";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(133, 73);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(55, 15);
            this.errorLabel.TabIndex = 108;
            this.errorLabel.Text = "Error text";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorLabel.UseWaitCursor = true;
            this.errorLabel.Visible = false;
            // 
            // AddVendorToStoreUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Controls.Add(this.splitContainer1);
            this.Name = "AddVendorToStoreUserControl";
            this.Size = new System.Drawing.Size(810, 617);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
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
        private Label label4;
        private ComboBox comboBox1;
        private Button button1;
        private Panel vendorInfoPanel;
        private Button addVendorToStoreButton;
        private Label messageLabel;
        private PictureBox infoGraphicPictureBox;
        private Label errorLabel;
    }
}
