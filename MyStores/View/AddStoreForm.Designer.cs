namespace MyStores.View
{
    partial class AddStoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStoreForm));
            groupBox = new GroupBox();
            storeNameErrorLabel = new Label();
            cityErrorLabel = new Label();
            stateErrorLabel = new Label();
            errorLabel = new Label();
            clearButton = new Button();
            addStoreButton = new Button();
            titleLabel = new Label();
            storeNametextBox = new TextBox();
            storeNamelabel = new Label();
            countryTextBox = new TextBox();
            zipcodeTextBox = new TextBox();
            zipcodeLabel = new Label();
            stateTextBox = new TextBox();
            stateLabel = new Label();
            cityTextBox = new TextBox();
            cityLabel = new Label();
            streetAddressTextBox = new TextBox();
            streetAddLabel = new Label();
            countryLabel = new Label();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.BackColor = Color.MistyRose;
            groupBox.Controls.Add(storeNameErrorLabel);
            groupBox.Controls.Add(cityErrorLabel);
            groupBox.Controls.Add(stateErrorLabel);
            groupBox.Controls.Add(errorLabel);
            groupBox.Controls.Add(clearButton);
            groupBox.Controls.Add(addStoreButton);
            groupBox.Controls.Add(titleLabel);
            groupBox.Controls.Add(storeNametextBox);
            groupBox.Controls.Add(storeNamelabel);
            groupBox.Controls.Add(countryTextBox);
            groupBox.Controls.Add(zipcodeTextBox);
            groupBox.Controls.Add(zipcodeLabel);
            groupBox.Controls.Add(stateTextBox);
            groupBox.Controls.Add(stateLabel);
            groupBox.Controls.Add(cityTextBox);
            groupBox.Controls.Add(cityLabel);
            groupBox.Controls.Add(streetAddressTextBox);
            groupBox.Controls.Add(streetAddLabel);
            groupBox.Controls.Add(countryLabel);
            groupBox.ForeColor = SystemColors.ControlText;
            groupBox.Location = new Point(25, 12);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(366, 420);
            groupBox.TabIndex = 0;
            groupBox.TabStop = false;
            // 
            // storeNameErrorLabel
            // 
            storeNameErrorLabel.AutoSize = true;
            storeNameErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            storeNameErrorLabel.ForeColor = Color.Red;
            storeNameErrorLabel.Location = new Point(75, 101);
            storeNameErrorLabel.Margin = new Padding(2, 0, 2, 0);
            storeNameErrorLabel.Name = "storeNameErrorLabel";
            storeNameErrorLabel.Size = new Size(55, 15);
            storeNameErrorLabel.TabIndex = 71;
            storeNameErrorLabel.Text = "Error text";
            storeNameErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            storeNameErrorLabel.UseWaitCursor = true;
            storeNameErrorLabel.Visible = false;
            // 
            // cityErrorLabel
            // 
            cityErrorLabel.AutoSize = true;
            cityErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cityErrorLabel.ForeColor = Color.Red;
            cityErrorLabel.Location = new Point(75, 192);
            cityErrorLabel.Margin = new Padding(2, 0, 2, 0);
            cityErrorLabel.Name = "cityErrorLabel";
            cityErrorLabel.Size = new Size(55, 15);
            cityErrorLabel.TabIndex = 70;
            cityErrorLabel.Text = "Error text";
            cityErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            cityErrorLabel.UseWaitCursor = true;
            cityErrorLabel.Visible = false;
            // 
            // stateErrorLabel
            // 
            stateErrorLabel.AutoSize = true;
            stateErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            stateErrorLabel.ForeColor = Color.Red;
            stateErrorLabel.Location = new Point(75, 236);
            stateErrorLabel.Margin = new Padding(2, 0, 2, 0);
            stateErrorLabel.Name = "stateErrorLabel";
            stateErrorLabel.Size = new Size(55, 15);
            stateErrorLabel.TabIndex = 69;
            stateErrorLabel.Text = "Error text";
            stateErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            stateErrorLabel.UseWaitCursor = true;
            stateErrorLabel.Visible = false;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            errorLabel.Location = new Point(53, 334);
            errorLabel.Margin = new Padding(2, 0, 2, 0);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(66, 19);
            errorLabel.TabIndex = 68;
            errorLabel.Text = "Error text";
            errorLabel.TextAlign = ContentAlignment.MiddleCenter;
            errorLabel.UseWaitCursor = true;
            errorLabel.Visible = false;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.White;
            clearButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            clearButton.ForeColor = SystemColors.ControlText;
            clearButton.Location = new Point(226, 366);
            clearButton.Margin = new Padding(2, 1, 2, 1);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(81, 31);
            clearButton.TabIndex = 67;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += ClearButton_Click;
            // 
            // addStoreButton
            // 
            addStoreButton.BackColor = Color.White;
            addStoreButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            addStoreButton.ForeColor = SystemColors.ControlText;
            addStoreButton.Location = new Point(53, 366);
            addStoreButton.Margin = new Padding(2, 1, 2, 1);
            addStoreButton.Name = "addStoreButton";
            addStoreButton.Size = new Size(98, 31);
            addStoreButton.TabIndex = 66;
            addStoreButton.Text = "Add Store";
            addStoreButton.UseVisualStyleBackColor = false;
            addStoreButton.Click += AddStoreButton_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.ForeColor = SystemColors.ControlText;
            titleLabel.Location = new Point(125, 19);
            titleLabel.Margin = new Padding(2, 0, 2, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(97, 31);
            titleLabel.TabIndex = 65;
            titleLabel.Text = "Add Store";
            titleLabel.UseCompatibleTextRendering = true;
            // 
            // storeNametextBox
            // 
            storeNametextBox.BorderStyle = BorderStyle.FixedSingle;
            storeNametextBox.ForeColor = SystemColors.WindowText;
            storeNametextBox.Location = new Point(160, 70);
            storeNametextBox.Margin = new Padding(2, 1, 2, 1);
            storeNametextBox.Name = "storeNametextBox";
            storeNametextBox.Size = new Size(158, 23);
            storeNametextBox.TabIndex = 55;
            storeNametextBox.GotFocus += StoreNameTextBox_GotFocus;
            // 
            // storeNamelabel
            // 
            storeNamelabel.AutoSize = true;
            storeNamelabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            storeNamelabel.ForeColor = SystemColors.WindowText;
            storeNamelabel.Location = new Point(43, 70);
            storeNamelabel.Margin = new Padding(2, 0, 2, 0);
            storeNamelabel.Name = "storeNamelabel";
            storeNamelabel.Size = new Size(87, 19);
            storeNamelabel.TabIndex = 63;
            storeNamelabel.Text = "Store Name*";
            // 
            // countryTextBox
            // 
            countryTextBox.ForeColor = SystemColors.WindowText;
            countryTextBox.Location = new Point(160, 304);
            countryTextBox.Margin = new Padding(2, 1, 2, 1);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.Size = new Size(158, 23);
            countryTextBox.TabIndex = 65;
            // 
            // zipcodeTextBox
            // 
            zipcodeTextBox.ForeColor = SystemColors.WindowText;
            zipcodeTextBox.Location = new Point(160, 260);
            zipcodeTextBox.Margin = new Padding(2, 1, 2, 1);
            zipcodeTextBox.Name = "zipcodeTextBox";
            zipcodeTextBox.Size = new Size(158, 23);
            zipcodeTextBox.TabIndex = 63;
            zipcodeTextBox.TextChanged += ZipcodeTextBox_TextChanged;
            zipcodeTextBox.KeyPress += ZipcodeTextBox_KeyPress;
            // 
            // zipcodeLabel
            // 
            zipcodeLabel.AutoSize = true;
            zipcodeLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            zipcodeLabel.ForeColor = SystemColors.WindowText;
            zipcodeLabel.Location = new Point(43, 259);
            zipcodeLabel.Margin = new Padding(2, 0, 2, 0);
            zipcodeLabel.Name = "zipcodeLabel";
            zipcodeLabel.Size = new Size(64, 19);
            zipcodeLabel.TabIndex = 60;
            zipcodeLabel.Text = "Zip Code";
            // 
            // stateTextBox
            // 
            stateTextBox.ForeColor = SystemColors.WindowText;
            stateTextBox.Location = new Point(160, 207);
            stateTextBox.Margin = new Padding(2, 1, 2, 1);
            stateTextBox.Name = "stateTextBox";
            stateTextBox.Size = new Size(158, 23);
            stateTextBox.TabIndex = 61;
            stateTextBox.GotFocus += StateTextBox_GotFocus;
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            stateLabel.ForeColor = SystemColors.WindowText;
            stateLabel.Location = new Point(43, 207);
            stateLabel.Margin = new Padding(2, 0, 2, 0);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new Size(46, 19);
            stateLabel.TabIndex = 58;
            stateLabel.Text = "State*";
            // 
            // cityTextBox
            // 
            cityTextBox.ForeColor = SystemColors.WindowText;
            cityTextBox.Location = new Point(160, 165);
            cityTextBox.Margin = new Padding(2, 1, 2, 1);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(158, 23);
            cityTextBox.TabIndex = 59;
            cityTextBox.GotFocus += CityTextBox_GotFocus;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cityLabel.ForeColor = SystemColors.WindowText;
            cityLabel.Location = new Point(43, 164);
            cityLabel.Margin = new Padding(2, 0, 2, 0);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(39, 19);
            cityLabel.TabIndex = 56;
            cityLabel.Text = "City*";
            // 
            // streetAddressTextBox
            // 
            streetAddressTextBox.ForeColor = SystemColors.WindowText;
            streetAddressTextBox.Location = new Point(160, 123);
            streetAddressTextBox.Margin = new Padding(2, 1, 2, 1);
            streetAddressTextBox.Name = "streetAddressTextBox";
            streetAddressTextBox.Size = new Size(158, 23);
            streetAddressTextBox.TabIndex = 57;
            // 
            // streetAddLabel
            // 
            streetAddLabel.AutoSize = true;
            streetAddLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            streetAddLabel.ForeColor = SystemColors.WindowText;
            streetAddLabel.Location = new Point(43, 123);
            streetAddLabel.Margin = new Padding(2, 0, 2, 0);
            streetAddLabel.Name = "streetAddLabel";
            streetAddLabel.Size = new Size(98, 19);
            streetAddLabel.TabIndex = 54;
            streetAddLabel.Text = "Street Address";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            countryLabel.ForeColor = SystemColors.WindowText;
            countryLabel.Location = new Point(43, 305);
            countryLabel.Margin = new Padding(2, 0, 2, 0);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(59, 19);
            countryLabel.TabIndex = 53;
            countryLabel.Text = "Country";
            // 
            // AddStoreForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(420, 468);
            Controls.Add(groupBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddStoreForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddStoreForm";
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox;
        private TextBox countryTextBox;
        private TextBox zipcodeTextBox;
        private TextBox stateTextBox;
        private TextBox cityTextBox;
        private TextBox streetAddressTextBox;
        private Label zipcodeLabel;
        private Label stateLabel;
        private Label cityLabel;
        private Label streetAddLabel;
        private Label countryLabel;
        private TextBox storeNametextBox;
        private Label storeNamelabel;
        private Label titleLabel;
        private Button clearButton;
        private Button addStoreButton;
        private Label errorLabel;
        private Label storeNameErrorLabel;
        private Label cityErrorLabel;
        private Label stateErrorLabel;
    }
}