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
            mainSplitContainer.Margin = new Padding(3, 4, 3, 4);
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
            mainSplitContainer.Panel1.Padding = new Padding(5);
            // 
            // mainSplitContainer.Panel2
            // 
            mainSplitContainer.Panel2.Controls.Add(infoLabel);
            mainSplitContainer.Panel2.Controls.Add(storeVendorListView);
            mainSplitContainer.Panel2.Padding = new Padding(5);
            mainSplitContainer.Size = new Size(788, 823);
            mainSplitContainer.SplitterDistance = 379;
            mainSplitContainer.SplitterWidth = 5;
            mainSplitContainer.TabIndex = 0;
            // 
            // closeVendorFormPictureBox
            // 
            closeVendorFormPictureBox.Image = (Image)resources.GetObject("closeVendorFormPictureBox.Image");
            closeVendorFormPictureBox.Location = new Point(175, 509);
            closeVendorFormPictureBox.Margin = new Padding(3, 4, 3, 4);
            closeVendorFormPictureBox.Name = "closeVendorFormPictureBox";
            closeVendorFormPictureBox.Size = new Size(55, 64);
            closeVendorFormPictureBox.TabIndex = 108;
            closeVendorFormPictureBox.TabStop = false;
            closeVendorFormPictureBox.Visible = false;
            closeVendorFormPictureBox.Click += closeVendorFormPictureBox_Click;
            // 
            // addVendorToStoreButton
            // 
            addVendorToStoreButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            addVendorToStoreButton.BackColor = Color.FromArgb(28, 44, 78);
            addVendorToStoreButton.FlatAppearance.BorderSize = 0;
            addVendorToStoreButton.FlatStyle = FlatStyle.Flat;
            addVendorToStoreButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            addVendorToStoreButton.ForeColor = Color.White;
            addVendorToStoreButton.Location = new Point(138, 121);
            addVendorToStoreButton.Margin = new Padding(3, 4, 3, 4);
            addVendorToStoreButton.Name = "addVendorToStoreButton";
            addVendorToStoreButton.Size = new Size(128, 59);
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
            vendorInfoPanel.Location = new Point(14, 254);
            vendorInfoPanel.Margin = new Padding(3, 4, 3, 4);
            vendorInfoPanel.Name = "vendorInfoPanel";
            vendorInfoPanel.Padding = new Padding(9, 11, 9, 11);
            vendorInfoPanel.Size = new Size(356, 226);
            vendorInfoPanel.TabIndex = 106;
            // 
            // addVendorButton
            // 
            addVendorButton.BackColor = Color.FromArgb(28, 44, 78);
            addVendorButton.FlatAppearance.BorderSize = 0;
            addVendorButton.FlatStyle = FlatStyle.Flat;
            addVendorButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            addVendorButton.ForeColor = Color.White;
            addVendorButton.Location = new Point(104, 162);
            addVendorButton.Margin = new Padding(3, 4, 3, 4);
            addVendorButton.Name = "addVendorButton";
            addVendorButton.Size = new Size(182, 54);
            addVendorButton.TabIndex = 15;
            addVendorButton.Text = "Add New Vendor";
            addVendorButton.UseVisualStyleBackColor = false;
            addVendorButton.Click += addVendorButton_Click;
            // 
            // messageLabel
            // 
            messageLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            messageLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            messageLabel.Location = new Point(74, 15);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(248, 105);
            messageLabel.TabIndex = 13;
            messageLabel.Text = "Info Message";
            // 
            // infoGraphicPictureBox
            // 
            infoGraphicPictureBox.Image = (Image)resources.GetObject("infoGraphicPictureBox.Image");
            infoGraphicPictureBox.Location = new Point(13, 15);
            infoGraphicPictureBox.Margin = new Padding(3, 4, 3, 4);
            infoGraphicPictureBox.Name = "infoGraphicPictureBox";
            infoGraphicPictureBox.Size = new Size(55, 64);
            infoGraphicPictureBox.TabIndex = 0;
            infoGraphicPictureBox.TabStop = false;
            // 
            // selectVendorLabel
            // 
            selectVendorLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            selectVendorLabel.Location = new Point(3, 47);
            selectVendorLabel.Name = "selectVendorLabel";
            selectVendorLabel.Size = new Size(157, 47);
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
            vendorComboBox.Location = new Point(175, 53);
            vendorComboBox.Margin = new Padding(3, 4, 3, 4);
            vendorComboBox.MaxDropDownItems = 99;
            vendorComboBox.Name = "vendorComboBox";
            vendorComboBox.Size = new Size(194, 36);
            vendorComboBox.TabIndex = 12;
            // 
            // mainAddVendorUserControl
            // 
            mainAddVendorUserControl.AutoScroll = true;
            mainAddVendorUserControl.BackColor = Color.BlanchedAlmond;
            mainAddVendorUserControl.Location = new Point(4, 0);
            mainAddVendorUserControl.Margin = new Padding(3, 5, 3, 5);
            mainAddVendorUserControl.Name = "mainAddVendorUserControl";
            mainAddVendorUserControl.Size = new Size(367, 631);
            mainAddVendorUserControl.TabIndex = 0;
            mainAddVendorUserControl.Visible = false;
            // 
            // infoLabel
            // 
            infoLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            infoLabel.ForeColor = SystemColors.ControlText;
            infoLabel.Location = new Point(2, 28);
            infoLabel.Margin = new Padding(2, 0, 2, 0);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(407, 41);
            infoLabel.TabIndex = 90;
            infoLabel.Text = "List of Vendors for this store";
            infoLabel.TextAlign = ContentAlignment.MiddleCenter;
            infoLabel.UseCompatibleTextRendering = true;
            // 
            // storeVendorListView
            // 
            storeVendorListView.BorderStyle = BorderStyle.None;
            storeVendorListView.Columns.AddRange(new ColumnHeader[] { vendorName, city, phoneNumber });
            storeVendorListView.Dock = DockStyle.Bottom;
            storeVendorListView.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            storeVendorListView.FullRowSelect = true;
            storeVendorListView.GridLines = true;
            storeVendorListView.Location = new Point(5, 87);
            storeVendorListView.Margin = new Padding(3, 4, 3, 4);
            storeVendorListView.Name = "storeVendorListView";
            storeVendorListView.Size = new Size(394, 731);
            storeVendorListView.TabIndex = 0;
            storeVendorListView.UseCompatibleStateImageBehavior = false;
            storeVendorListView.View = System.Windows.Forms.View.Details;
            // 
            // vendorName
            // 
            vendorName.Text = "Vendor Name";
            vendorName.Width = 140;
            // 
            // city
            // 
            city.Text = "City";
            city.Width = 130;
            // 
            // phoneNumber
            // 
            phoneNumber.Text = "Phone Number";
            phoneNumber.Width = 120;
            // 
            // AddVendorToStoreUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(227, 211, 177);
            Controls.Add(mainSplitContainer);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddVendorToStoreUserControl";
            Size = new Size(788, 823);
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
