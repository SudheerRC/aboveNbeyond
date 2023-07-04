namespace MyStores.UserControls
{
    partial class AddVendorUserControl
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
            nameErrorLabel = new Label();
            errorLabel = new Label();
            clearButton = new Button();
            addButton = new Button();
            openFileDialog = new OpenFileDialog();
            nameTextBox = new TextBox();
            vendorNameLabel = new Label();
            titleLabel = new Label();
            phoneErrorLabel = new Label();
            countryTextBox = new TextBox();
            zipcodeTextBox = new TextBox();
            zipcodeLabel = new Label();
            stateTextBox = new TextBox();
            stateLabel = new Label();
            cityTextBox = new TextBox();
            cityLabel = new Label();
            streetAddressTextBox = new TextBox();
            streetAddLabel = new Label();
            phoneNumTextBox = new TextBox();
            phoneNumLabel = new Label();
            countryLabel = new Label();
            editButton = new Button();
            SuspendLayout();
            // 
            // nameErrorLabel
            // 
            nameErrorLabel.AutoSize = true;
            nameErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nameErrorLabel.ForeColor = Color.Red;
            nameErrorLabel.Location = new Point(119, 130);
            nameErrorLabel.Name = "nameErrorLabel";
            nameErrorLabel.Size = new Size(111, 32);
            nameErrorLabel.TabIndex = 107;
            nameErrorLabel.Text = "Error text";
            nameErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            nameErrorLabel.UseWaitCursor = true;
            nameErrorLabel.Visible = false;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            errorLabel.Location = new Point(93, 739);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(125, 37);
            errorLabel.TabIndex = 106;
            errorLabel.Text = "Error text";
            errorLabel.TextAlign = ContentAlignment.MiddleCenter;
            errorLabel.UseWaitCursor = true;
            errorLabel.Visible = false;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.White;
            clearButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            clearButton.Location = new Point(398, 795);
            clearButton.Margin = new Padding(3, 2, 3, 2);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(151, 62);
            clearButton.TabIndex = 105;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += ClearButton_Click;
            // 
            // addButton
            // 
            addButton.BackColor = Color.White;
            addButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.Location = new Point(93, 795);
            addButton.Margin = new Padding(3, 2, 3, 2);
            addButton.Name = "addButton";
            addButton.Size = new Size(151, 62);
            addButton.TabIndex = 104;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            openFileDialog.Title = "Choose a image for product";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(294, 75);
            nameTextBox.Margin = new Padding(3, 2, 3, 2);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(290, 39);
            nameTextBox.TabIndex = 90;
            nameTextBox.GotFocus += NameTextBox_GotFocus;
            // 
            // vendorNameLabel
            // 
            vendorNameLabel.AutoSize = true;
            vendorNameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            vendorNameLabel.Location = new Point(76, 75);
            vendorNameLabel.Name = "vendorNameLabel";
            vendorNameLabel.Size = new Size(186, 37);
            vendorNameLabel.TabIndex = 91;
            vendorNameLabel.Text = "Vendor name*";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.ForeColor = SystemColors.ControlText;
            titleLabel.Location = new Point(190, 8);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(231, 58);
            titleLabel.TabIndex = 89;
            titleLabel.Text = "Add Vendor";
            titleLabel.UseCompatibleTextRendering = true;
            // 
            // phoneErrorLabel
            // 
            phoneErrorLabel.AutoSize = true;
            phoneErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            phoneErrorLabel.ForeColor = Color.Red;
            phoneErrorLabel.Location = new Point(119, 686);
            phoneErrorLabel.Name = "phoneErrorLabel";
            phoneErrorLabel.Size = new Size(111, 32);
            phoneErrorLabel.TabIndex = 120;
            phoneErrorLabel.Text = "Error text";
            phoneErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            phoneErrorLabel.UseWaitCursor = true;
            phoneErrorLabel.Visible = false;
            // 
            // countryTextBox
            // 
            countryTextBox.Location = new Point(294, 544);
            countryTextBox.Margin = new Padding(3, 2, 3, 2);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.Size = new Size(290, 39);
            countryTextBox.TabIndex = 112;
            // 
            // zipcodeTextBox
            // 
            zipcodeTextBox.Location = new Point(294, 456);
            zipcodeTextBox.Margin = new Padding(3, 2, 3, 2);
            zipcodeTextBox.Name = "zipcodeTextBox";
            zipcodeTextBox.Size = new Size(290, 39);
            zipcodeTextBox.TabIndex = 111;
            zipcodeTextBox.TextChanged += ZipcodeTextBox_TextChanged;
            zipcodeTextBox.KeyPress += ZipcodeTextBox_KeyPress;
            // 
            // zipcodeLabel
            // 
            zipcodeLabel.AutoSize = true;
            zipcodeLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            zipcodeLabel.Location = new Point(76, 454);
            zipcodeLabel.Name = "zipcodeLabel";
            zipcodeLabel.Size = new Size(125, 37);
            zipcodeLabel.TabIndex = 119;
            zipcodeLabel.Text = "Zip Code";
            // 
            // stateTextBox
            // 
            stateTextBox.Location = new Point(294, 366);
            stateTextBox.Margin = new Padding(3, 2, 3, 2);
            stateTextBox.Name = "stateTextBox";
            stateTextBox.Size = new Size(290, 39);
            stateTextBox.TabIndex = 110;
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            stateLabel.Location = new Point(76, 366);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new Size(76, 37);
            stateLabel.TabIndex = 118;
            stateLabel.Text = "State";
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(294, 270);
            cityTextBox.Margin = new Padding(3, 2, 3, 2);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(290, 39);
            cityTextBox.TabIndex = 109;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cityLabel.Location = new Point(76, 269);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(63, 37);
            cityLabel.TabIndex = 117;
            cityLabel.Text = "City";
            // 
            // streetAddressTextBox
            // 
            streetAddressTextBox.Location = new Point(294, 176);
            streetAddressTextBox.Margin = new Padding(3, 2, 3, 2);
            streetAddressTextBox.Name = "streetAddressTextBox";
            streetAddressTextBox.Size = new Size(290, 39);
            streetAddressTextBox.TabIndex = 108;
            // 
            // streetAddLabel
            // 
            streetAddLabel.AutoSize = true;
            streetAddLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            streetAddLabel.Location = new Point(76, 176);
            streetAddLabel.Name = "streetAddLabel";
            streetAddLabel.Size = new Size(186, 37);
            streetAddLabel.TabIndex = 116;
            streetAddLabel.Text = "Street Address";
            // 
            // phoneNumTextBox
            // 
            phoneNumTextBox.Location = new Point(294, 630);
            phoneNumTextBox.Margin = new Padding(3, 2, 3, 2);
            phoneNumTextBox.Name = "phoneNumTextBox";
            phoneNumTextBox.Size = new Size(290, 39);
            phoneNumTextBox.TabIndex = 113;
            phoneNumTextBox.TextChanged += PhoneNumTextBox_TextChanged;
            phoneNumTextBox.GotFocus += PhoneNumTextBox_GotFocus;
            phoneNumTextBox.KeyPress += PhoneNumTextBox_KeyPress;
            // 
            // phoneNumLabel
            // 
            phoneNumLabel.AutoSize = true;
            phoneNumLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            phoneNumLabel.Location = new Point(76, 629);
            phoneNumLabel.Name = "phoneNumLabel";
            phoneNumLabel.Size = new Size(202, 37);
            phoneNumLabel.TabIndex = 115;
            phoneNumLabel.Text = "Phone number*";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            countryLabel.Location = new Point(76, 546);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(111, 37);
            countryLabel.TabIndex = 114;
            countryLabel.Text = "Country";
            // 
            // editButton
            // 
            editButton.BackColor = Color.White;
            editButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            editButton.Location = new Point(93, 795);
            editButton.Margin = new Padding(3, 2, 3, 2);
            editButton.Name = "editButton";
            editButton.Size = new Size(151, 62);
            editButton.TabIndex = 121;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = false;
            editButton.Visible = false;
            // 
            // AddVendorUserControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(227, 211, 177);
            Controls.Add(phoneErrorLabel);
            Controls.Add(countryTextBox);
            Controls.Add(zipcodeTextBox);
            Controls.Add(zipcodeLabel);
            Controls.Add(stateTextBox);
            Controls.Add(stateLabel);
            Controls.Add(cityTextBox);
            Controls.Add(cityLabel);
            Controls.Add(streetAddressTextBox);
            Controls.Add(streetAddLabel);
            Controls.Add(phoneNumTextBox);
            Controls.Add(phoneNumLabel);
            Controls.Add(countryLabel);
            Controls.Add(nameErrorLabel);
            Controls.Add(errorLabel);
            Controls.Add(clearButton);
            Controls.Add(addButton);
            Controls.Add(nameTextBox);
            Controls.Add(vendorNameLabel);
            Controls.Add(titleLabel);
            Controls.Add(editButton);
            Margin = new Padding(5, 6, 5, 6);
            Name = "AddVendorUserControl";
            Size = new Size(658, 880);
            Load += AddVendorUserControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameErrorLabel;
        private Label errorLabel;
        private Button clearButton;
        private Button addButton;
        private OpenFileDialog openFileDialog;
        private TextBox nameTextBox;
        private Label vendorNameLabel;
        private Label titleLabel;
        private Label phoneErrorLabel;
        private TextBox countryTextBox;
        private TextBox zipcodeTextBox;
        private Label zipcodeLabel;
        private TextBox stateTextBox;
        private Label stateLabel;
        private TextBox cityTextBox;
        private Label cityLabel;
        private TextBox streetAddressTextBox;
        private Label streetAddLabel;
        private TextBox phoneNumTextBox;
        private Label phoneNumLabel;
        private Label countryLabel;
        private Button editButton;
    }
}
