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
            SuspendLayout();
            // 
            // nameErrorLabel
            // 
            nameErrorLabel.AutoSize = true;
            nameErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nameErrorLabel.ForeColor = Color.Red;
            nameErrorLabel.Location = new Point(73, 81);
            nameErrorLabel.Margin = new Padding(2, 0, 2, 0);
            nameErrorLabel.Name = "nameErrorLabel";
            nameErrorLabel.Size = new Size(70, 20);
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
            errorLabel.Location = new Point(57, 462);
            errorLabel.Margin = new Padding(2, 0, 2, 0);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(81, 23);
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
            clearButton.Location = new Point(245, 497);
            clearButton.Margin = new Padding(2, 1, 2, 1);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(93, 39);
            clearButton.TabIndex = 105;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += ClearButton_Click;
            // 
            // addButton
            // 
            addButton.BackColor = Color.White;
            addButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.Location = new Point(57, 497);
            addButton.Margin = new Padding(2, 1, 2, 1);
            addButton.Name = "addButton";
            addButton.Size = new Size(93, 39);
            addButton.TabIndex = 104;
            addButton.Text = "Add Product";
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
            nameTextBox.Location = new Point(181, 47);
            nameTextBox.Margin = new Padding(2, 1, 2, 1);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(180, 27);
            nameTextBox.TabIndex = 90;
            nameTextBox.GotFocus += NameTextBox_GotFocus;
            // 
            // vendorNameLabel
            // 
            vendorNameLabel.AutoSize = true;
            vendorNameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            vendorNameLabel.Location = new Point(47, 47);
            vendorNameLabel.Margin = new Padding(2, 0, 2, 0);
            vendorNameLabel.Name = "vendorNameLabel";
            vendorNameLabel.Size = new Size(120, 23);
            vendorNameLabel.TabIndex = 91;
            vendorNameLabel.Text = "Vendor name*";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.ForeColor = SystemColors.ControlText;
            titleLabel.Location = new Point(117, 5);
            titleLabel.Margin = new Padding(2, 0, 2, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(144, 37);
            titleLabel.TabIndex = 89;
            titleLabel.Text = "Add Vendor";
            titleLabel.UseCompatibleTextRendering = true;
            // 
            // phoneErrorLabel
            // 
            phoneErrorLabel.AutoSize = true;
            phoneErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            phoneErrorLabel.ForeColor = Color.Red;
            phoneErrorLabel.Location = new Point(73, 429);
            phoneErrorLabel.Margin = new Padding(2, 0, 2, 0);
            phoneErrorLabel.Name = "phoneErrorLabel";
            phoneErrorLabel.Size = new Size(70, 20);
            phoneErrorLabel.TabIndex = 120;
            phoneErrorLabel.Text = "Error text";
            phoneErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            phoneErrorLabel.UseWaitCursor = true;
            phoneErrorLabel.Visible = false;
            // 
            // countryTextBox
            // 
            countryTextBox.Location = new Point(181, 340);
            countryTextBox.Margin = new Padding(2, 1, 2, 1);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.Size = new Size(180, 27);
            countryTextBox.TabIndex = 112;
            // 
            // zipcodeTextBox
            // 
            zipcodeTextBox.Location = new Point(181, 285);
            zipcodeTextBox.Margin = new Padding(2, 1, 2, 1);
            zipcodeTextBox.Name = "zipcodeTextBox";
            zipcodeTextBox.Size = new Size(180, 27);
            zipcodeTextBox.TabIndex = 111;
            zipcodeTextBox.TextChanged += ZipcodeTextBox_TextChanged;
            zipcodeTextBox.KeyPress += ZipcodeTextBox_KeyPress;
            // 
            // zipcodeLabel
            // 
            zipcodeLabel.AutoSize = true;
            zipcodeLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            zipcodeLabel.Location = new Point(47, 284);
            zipcodeLabel.Margin = new Padding(2, 0, 2, 0);
            zipcodeLabel.Name = "zipcodeLabel";
            zipcodeLabel.Size = new Size(79, 23);
            zipcodeLabel.TabIndex = 119;
            zipcodeLabel.Text = "Zip Code";
            // 
            // stateTextBox
            // 
            stateTextBox.Location = new Point(181, 229);
            stateTextBox.Margin = new Padding(2, 1, 2, 1);
            stateTextBox.Name = "stateTextBox";
            stateTextBox.Size = new Size(180, 27);
            stateTextBox.TabIndex = 110;
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            stateLabel.Location = new Point(47, 229);
            stateLabel.Margin = new Padding(2, 0, 2, 0);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new Size(48, 23);
            stateLabel.TabIndex = 118;
            stateLabel.Text = "State";
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(181, 169);
            cityTextBox.Margin = new Padding(2, 1, 2, 1);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(180, 27);
            cityTextBox.TabIndex = 109;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cityLabel.Location = new Point(47, 168);
            cityLabel.Margin = new Padding(2, 0, 2, 0);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(39, 23);
            cityLabel.TabIndex = 117;
            cityLabel.Text = "City";
            // 
            // streetAddressTextBox
            // 
            streetAddressTextBox.Location = new Point(181, 110);
            streetAddressTextBox.Margin = new Padding(2, 1, 2, 1);
            streetAddressTextBox.Name = "streetAddressTextBox";
            streetAddressTextBox.Size = new Size(180, 27);
            streetAddressTextBox.TabIndex = 108;
            // 
            // streetAddLabel
            // 
            streetAddLabel.AutoSize = true;
            streetAddLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            streetAddLabel.Location = new Point(47, 110);
            streetAddLabel.Margin = new Padding(2, 0, 2, 0);
            streetAddLabel.Name = "streetAddLabel";
            streetAddLabel.Size = new Size(119, 23);
            streetAddLabel.TabIndex = 116;
            streetAddLabel.Text = "Street Address";
            // 
            // phoneNumTextBox
            // 
            phoneNumTextBox.Location = new Point(181, 394);
            phoneNumTextBox.Margin = new Padding(2, 1, 2, 1);
            phoneNumTextBox.Name = "phoneNumTextBox";
            phoneNumTextBox.Size = new Size(180, 27);
            phoneNumTextBox.TabIndex = 113;
            phoneNumTextBox.TextChanged += PhoneNumTextBox_TextChanged;
            phoneNumTextBox.GotFocus += PhoneNumTextBox_GotFocus;
            phoneNumTextBox.KeyPress += PhoneNumTextBox_KeyPress;
            // 
            // phoneNumLabel
            // 
            phoneNumLabel.AutoSize = true;
            phoneNumLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            phoneNumLabel.Location = new Point(47, 393);
            phoneNumLabel.Margin = new Padding(2, 0, 2, 0);
            phoneNumLabel.Name = "phoneNumLabel";
            phoneNumLabel.Size = new Size(131, 23);
            phoneNumLabel.TabIndex = 115;
            phoneNumLabel.Text = "Phone number*";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            countryLabel.Location = new Point(47, 341);
            countryLabel.Margin = new Padding(2, 0, 2, 0);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(71, 23);
            countryLabel.TabIndex = 114;
            countryLabel.Text = "Country";
            // 
            // AddVendorUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddVendorUserControl";
            Size = new Size(405, 550);
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
    }
}
