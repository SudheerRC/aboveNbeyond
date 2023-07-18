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
            mainSplitContainer = new SplitContainer();
            closeVendorFormPictureBox = new PictureBox();
            addVendorToStoreButton = new Button();
            vendorInfoPanel = new Panel();
            addVendorButton = new Button();
            messageLabel = new Label();
            infoGraphicPictureBox = new PictureBox();
            selectVendorLabel = new Label();
            vendorComboBox = new ComboBox();
            mainAddVendorUserControl = new AddVendorUserControl();
            infoLabel = new Label();
            storeVendorListView = new ListView();
            vendorName = new ColumnHeader();
            city = new ColumnHeader();
            phoneNumber = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)mainSplitContainer).BeginInit();
            mainSplitContainer.Panel1.SuspendLayout();
            mainSplitContainer.Panel2.SuspendLayout();
            mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)closeVendorFormPictureBox).BeginInit();
            vendorInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)infoGraphicPictureBox).BeginInit();
            SuspendLayout();
            // 
            // mainSplitContainer
            // 
            mainSplitContainer.Dock = DockStyle.Fill;
            mainSplitContainer.Location = new Point(0, 0);
            mainSplitContainer.Margin = new Padding(5, 6, 5, 6);
            mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            mainSplitContainer.Panel1.Controls.Add(closeVendorFormPictureBox);
            mainSplitContainer.Panel1.Controls.Add(addVendorToStoreButton);
            mainSplitContainer.Panel1.Controls.Add(vendorInfoPanel);
            mainSplitContainer.Panel1.Controls.Add(selectVendorLabel);
            mainSplitContainer.Panel1.Controls.Add(vendorComboBox);
            mainSplitContainer.Panel1.Controls.Add(mainAddVendorUserControl);
            mainSplitContainer.Panel1.Padding = new Padding(8, 8, 8, 8);
            // 
            // mainSplitContainer.Panel2
            // 
            mainSplitContainer.Panel2.Controls.Add(infoLabel);
            mainSplitContainer.Panel2.Controls.Add(storeVendorListView);
            mainSplitContainer.Panel2.Padding = new Padding(8, 8, 8, 8);
            mainSplitContainer.Size = new Size(1380, 1018);
            mainSplitContainer.SplitterDistance = 658;
            mainSplitContainer.SplitterWidth = 8;
            mainSplitContainer.TabIndex = 0;
            // 
            // closeVendorFormPictureBox
            // 
            closeVendorFormPictureBox.Image = (Image)resources.GetObject("closeVendorFormPictureBox.Image");
            closeVendorFormPictureBox.Location = new Point(284, 776);
            closeVendorFormPictureBox.Margin = new Padding(5, 6, 5, 6);
            closeVendorFormPictureBox.Name = "closeVendorFormPictureBox";
            closeVendorFormPictureBox.Size = new Size(89, 102);
            closeVendorFormPictureBox.TabIndex = 108;
            closeVendorFormPictureBox.TabStop = false;
            closeVendorFormPictureBox.Visible = false;
            closeVendorFormPictureBox.Click += closeVendorFormPictureBox_Click;
            // 
            // addVendorToStoreButton
            // 
            addVendorToStoreButton.BackColor = Color.FromArgb(28, 44, 78);
            addVendorToStoreButton.FlatAppearance.BorderSize = 0;
            addVendorToStoreButton.FlatStyle = FlatStyle.Flat;
            addVendorToStoreButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            addVendorToStoreButton.ForeColor = Color.White;
            addVendorToStoreButton.Location = new Point(224, 194);
            addVendorToStoreButton.Margin = new Padding(5, 6, 5, 6);
            addVendorToStoreButton.Name = "addVendorToStoreButton";
            addVendorToStoreButton.Size = new Size(249, 117);
            addVendorToStoreButton.TabIndex = 107;
            addVendorToStoreButton.Text = "Add Vendor to Store";
            addVendorToStoreButton.UseVisualStyleBackColor = false;
            addVendorToStoreButton.Click += addVendorToStoreButton_Click;
            // 
            // vendorInfoPanel
            // 
            vendorInfoPanel.Controls.Add(addVendorButton);
            vendorInfoPanel.Controls.Add(messageLabel);
            vendorInfoPanel.Controls.Add(infoGraphicPictureBox);
            vendorInfoPanel.Location = new Point(23, 405);
            vendorInfoPanel.Margin = new Padding(5, 6, 5, 6);
            vendorInfoPanel.Name = "vendorInfoPanel";
            vendorInfoPanel.Padding = new Padding(15, 18, 15, 18);
            vendorInfoPanel.Size = new Size(580, 363);
            vendorInfoPanel.TabIndex = 106;
            // 
            // addVendorButton
            // 
            addVendorButton.BackColor = Color.FromArgb(28, 44, 78);
            addVendorButton.FlatAppearance.BorderSize = 0;
            addVendorButton.FlatStyle = FlatStyle.Flat;
            addVendorButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            addVendorButton.ForeColor = Color.White;
            addVendorButton.Location = new Point(169, 267);
            addVendorButton.Margin = new Padding(5, 6, 5, 6);
            addVendorButton.Name = "addVendorButton";
            addVendorButton.Size = new Size(296, 85);
            addVendorButton.TabIndex = 15;
            addVendorButton.Text = "Add New Vendor";
            addVendorButton.UseVisualStyleBackColor = false;
            addVendorButton.Click += addVendorButton_Click;
            // 
            // messageLabel
            // 
            messageLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            messageLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            messageLabel.Location = new Point(120, 24);
            messageLabel.Margin = new Padding(5, 0, 5, 0);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(439, 230);
            messageLabel.TabIndex = 13;
            messageLabel.Text = "Info Message";
            // 
            // infoGraphicPictureBox
            // 
            infoGraphicPictureBox.Image = (Image)resources.GetObject("infoGraphicPictureBox.Image");
            infoGraphicPictureBox.Location = new Point(21, 24);
            infoGraphicPictureBox.Margin = new Padding(5, 6, 5, 6);
            infoGraphicPictureBox.Name = "infoGraphicPictureBox";
            infoGraphicPictureBox.Size = new Size(89, 102);
            infoGraphicPictureBox.TabIndex = 0;
            infoGraphicPictureBox.TabStop = false;
            // 
            // selectVendorLabel
            // 
            selectVendorLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            selectVendorLabel.Location = new Point(5, 75);
            selectVendorLabel.Margin = new Padding(5, 0, 5, 0);
            selectVendorLabel.Name = "selectVendorLabel";
            selectVendorLabel.Size = new Size(255, 75);
            selectVendorLabel.TabIndex = 13;
            selectVendorLabel.Text = "Select Vendor:";
            selectVendorLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // vendorComboBox
            // 
            vendorComboBox.DropDownHeight = 110;
            vendorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            vendorComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            vendorComboBox.FormattingEnabled = true;
            vendorComboBox.IntegralHeight = false;
            vendorComboBox.Location = new Point(284, 85);
            vendorComboBox.Margin = new Padding(5, 6, 5, 6);
            vendorComboBox.MaxDropDownItems = 99;
            vendorComboBox.Name = "vendorComboBox";
            vendorComboBox.Size = new Size(313, 53);
            vendorComboBox.TabIndex = 12;
            // 
            // mainAddVendorUserControl
            // 
            mainAddVendorUserControl.AutoScroll = true;
            mainAddVendorUserControl.BackColor = Color.BlanchedAlmond;
            mainAddVendorUserControl.Location = new Point(8, 0);
            mainAddVendorUserControl.Margin = new Padding(5, 8, 5, 8);
            mainAddVendorUserControl.Name = "mainAddVendorUserControl";
            mainAddVendorUserControl.Size = new Size(596, 1010);
            mainAddVendorUserControl.TabIndex = 0;
            mainAddVendorUserControl.Visible = false;
            // 
            // infoLabel
            // 
            infoLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            infoLabel.ForeColor = SystemColors.ControlText;
            infoLabel.Location = new Point(23, 45);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(661, 66);
            infoLabel.TabIndex = 90;
            infoLabel.Text = "List of Vendors for this store";
            infoLabel.TextAlign = ContentAlignment.MiddleCenter;
            infoLabel.UseCompatibleTextRendering = true;
            // 
            // storeVendorListView
            // 
            storeVendorListView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            storeVendorListView.BorderStyle = BorderStyle.None;
            storeVendorListView.Columns.AddRange(new ColumnHeader[] { vendorName, city, phoneNumber });
            storeVendorListView.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            storeVendorListView.FullRowSelect = true;
            storeVendorListView.GridLines = true;
            storeVendorListView.Location = new Point(8, 139);
            storeVendorListView.Margin = new Padding(5, 6, 5, 6);
            storeVendorListView.MultiSelect = false;
            storeVendorListView.Name = "storeVendorListView";
            storeVendorListView.Size = new Size(693, 773);
            storeVendorListView.TabIndex = 0;
            storeVendorListView.UseCompatibleStateImageBehavior = false;
            storeVendorListView.View = System.Windows.Forms.View.Details;
            // 
            // vendorName
            // 
            vendorName.Text = "Vendor Name";
            vendorName.Width = 250;
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
            // AddVendorToStoreUserControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(227, 211, 177);
            Controls.Add(mainSplitContainer);
            Margin = new Padding(5, 6, 5, 6);
            Name = "AddVendorToStoreUserControl";
            Size = new Size(1380, 1018);
            Load += AddVendorToStoreUserControl_Load;
            mainSplitContainer.Panel1.ResumeLayout(false);
            mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainSplitContainer).EndInit();
            mainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)closeVendorFormPictureBox).EndInit();
            vendorInfoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)infoGraphicPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer mainSplitContainer;
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
