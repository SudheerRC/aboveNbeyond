namespace MyStores.UserControls
{
    partial class AddProductUserControl
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
            titleLabel = new Label();
            nameTextBox = new TextBox();
            productNameLabel = new Label();
            descriptionLabel = new Label();
            descriptionTextBox = new RichTextBox();
            sizeTextBox = new TextBox();
            sizeLabel = new Label();
            departmentTextBox = new TextBox();
            departmentLabel = new Label();
            priceTextBox = new TextBox();
            sellingPriceLabel = new Label();
            barcodeTextBox = new TextBox();
            barcodeLabel = new Label();
            imageLabel = new Label();
            pictureBox = new PictureBox();
            imageGroupBox = new GroupBox();
            openFileDialog = new OpenFileDialog();
            clearButton = new Button();
            addButton = new Button();
            errorLabel = new Label();
            nameErrorLabel = new Label();
            priceErrorLabel = new Label();
            barcodeErrorLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            imageGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.ForeColor = SystemColors.ControlText;
            titleLabel.Location = new Point(95, 17);
            titleLabel.Margin = new Padding(2, 0, 2, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(121, 31);
            titleLabel.TabIndex = 66;
            titleLabel.Text = "Add Product";
            titleLabel.UseCompatibleTextRendering = true;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(152, 66);
            nameTextBox.Margin = new Padding(2, 1, 2, 1);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(158, 23);
            nameTextBox.TabIndex = 67;
            nameTextBox.GotFocus += NameTextBox_GotFocus;
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            productNameLabel.Location = new Point(35, 66);
            productNameLabel.Margin = new Padding(2, 0, 2, 0);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(101, 19);
            productNameLabel.TabIndex = 68;
            productNameLabel.Text = "Product name*";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionLabel.Location = new Point(35, 140);
            descriptionLabel.Margin = new Padding(2, 0, 2, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(78, 19);
            descriptionLabel.TabIndex = 70;
            descriptionLabel.Text = "Description";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(152, 122);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(158, 51);
            descriptionTextBox.TabIndex = 71;
            descriptionTextBox.Text = "";
            // 
            // sizeTextBox
            // 
            sizeTextBox.Location = new Point(159, 218);
            sizeTextBox.Margin = new Padding(2, 1, 2, 1);
            sizeTextBox.Name = "sizeTextBox";
            sizeTextBox.Size = new Size(151, 23);
            sizeTextBox.TabIndex = 72;
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            sizeLabel.Location = new Point(42, 218);
            sizeLabel.Margin = new Padding(2, 0, 2, 0);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new Size(83, 19);
            sizeLabel.TabIndex = 73;
            sizeLabel.Text = "Product size";
            // 
            // departmentTextBox
            // 
            departmentTextBox.Location = new Point(159, 272);
            departmentTextBox.Margin = new Padding(2, 1, 2, 1);
            departmentTextBox.Name = "departmentTextBox";
            departmentTextBox.Size = new Size(151, 23);
            departmentTextBox.TabIndex = 74;
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            departmentLabel.Location = new Point(42, 272);
            departmentLabel.Margin = new Padding(2, 0, 2, 0);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new Size(83, 19);
            departmentLabel.TabIndex = 75;
            departmentLabel.Text = "Department";
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(159, 320);
            priceTextBox.Margin = new Padding(2, 1, 2, 1);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(151, 23);
            priceTextBox.TabIndex = 76;
            priceTextBox.GotFocus += PriceTextBox_GotFocus;
            priceTextBox.KeyPress += priceTextBox_KeyPress;
            // 
            // sellingPriceLabel
            // 
            sellingPriceLabel.AutoSize = true;
            sellingPriceLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            sellingPriceLabel.Location = new Point(42, 320);
            sellingPriceLabel.Margin = new Padding(2, 0, 2, 0);
            sellingPriceLabel.Name = "sellingPriceLabel";
            sellingPriceLabel.Size = new Size(87, 19);
            sellingPriceLabel.TabIndex = 77;
            sellingPriceLabel.Text = "Selling Price*";
            // 
            // barcodeTextBox
            // 
            barcodeTextBox.Location = new Point(159, 373);
            barcodeTextBox.Margin = new Padding(2, 1, 2, 1);
            barcodeTextBox.Name = "barcodeTextBox";
            barcodeTextBox.Size = new Size(151, 23);
            barcodeTextBox.TabIndex = 78;
            barcodeTextBox.GotFocus += BarcodeTextBox_GotFocus;
            barcodeTextBox.KeyPress += BarcodeTextBox_KeyPress;
            // 
            // barcodeLabel
            // 
            barcodeLabel.AutoSize = true;
            barcodeLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            barcodeLabel.Location = new Point(42, 373);
            barcodeLabel.Margin = new Padding(2, 0, 2, 0);
            barcodeLabel.Name = "barcodeLabel";
            barcodeLabel.Size = new Size(64, 19);
            barcodeLabel.TabIndex = 79;
            barcodeLabel.Text = "Barcode*";
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            imageLabel.Location = new Point(42, 457);
            imageLabel.Margin = new Padding(2, 0, 2, 0);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new Size(47, 19);
            imageLabel.TabIndex = 80;
            imageLabel.Text = "Image";
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(3, 19);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(161, 78);
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox.TabIndex = 81;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox_Click;
            // 
            // imageGroupBox
            // 
            imageGroupBox.Controls.Add(pictureBox);
            imageGroupBox.Location = new Point(159, 420);
            imageGroupBox.Name = "imageGroupBox";
            imageGroupBox.Size = new Size(167, 100);
            imageGroupBox.TabIndex = 82;
            imageGroupBox.TabStop = false;
            imageGroupBox.Text = "Open Image";
            // 
            // openFileDialog
            // 
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            openFileDialog.Title = "Choose a image for product";
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.White;
            clearButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            clearButton.Location = new Point(213, 571);
            clearButton.Margin = new Padding(2, 1, 2, 1);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(81, 29);
            clearButton.TabIndex = 84;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += ClearButton_Click;
            // 
            // addButton
            // 
            addButton.BackColor = Color.White;
            addButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.Location = new Point(53, 571);
            addButton.Margin = new Padding(2, 1, 2, 1);
            addButton.Name = "addButton";
            addButton.Size = new Size(81, 29);
            addButton.TabIndex = 83;
            addButton.Text = "Add Product";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += AddButton_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            errorLabel.Location = new Point(42, 540);
            errorLabel.Margin = new Padding(2, 0, 2, 0);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(66, 19);
            errorLabel.TabIndex = 85;
            errorLabel.Text = "Error text";
            errorLabel.TextAlign = ContentAlignment.MiddleCenter;
            errorLabel.UseWaitCursor = true;
            errorLabel.Visible = false;
            // 
            // nameErrorLabel
            // 
            nameErrorLabel.AutoSize = true;
            nameErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nameErrorLabel.ForeColor = Color.Red;
            nameErrorLabel.Location = new Point(58, 97);
            nameErrorLabel.Margin = new Padding(2, 0, 2, 0);
            nameErrorLabel.Name = "nameErrorLabel";
            nameErrorLabel.Size = new Size(55, 15);
            nameErrorLabel.TabIndex = 86;
            nameErrorLabel.Text = "Error text";
            nameErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            nameErrorLabel.UseWaitCursor = true;
            nameErrorLabel.Visible = false;
            // 
            // priceErrorLabel
            // 
            priceErrorLabel.AutoSize = true;
            priceErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            priceErrorLabel.ForeColor = Color.Red;
            priceErrorLabel.Location = new Point(58, 348);
            priceErrorLabel.Margin = new Padding(2, 0, 2, 0);
            priceErrorLabel.Name = "priceErrorLabel";
            priceErrorLabel.Size = new Size(55, 15);
            priceErrorLabel.TabIndex = 87;
            priceErrorLabel.Text = "Error text";
            priceErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            priceErrorLabel.UseWaitCursor = true;
            priceErrorLabel.Visible = false;
            // 
            // barcodeErrorLabel
            // 
            barcodeErrorLabel.AutoSize = true;
            barcodeErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            barcodeErrorLabel.ForeColor = Color.Red;
            barcodeErrorLabel.Location = new Point(58, 407);
            barcodeErrorLabel.Margin = new Padding(2, 0, 2, 0);
            barcodeErrorLabel.Name = "barcodeErrorLabel";
            barcodeErrorLabel.Size = new Size(55, 15);
            barcodeErrorLabel.TabIndex = 88;
            barcodeErrorLabel.Text = "Error text";
            barcodeErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            barcodeErrorLabel.UseWaitCursor = true;
            barcodeErrorLabel.Visible = false;
            // 
            // AddProductUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            Controls.Add(barcodeErrorLabel);
            Controls.Add(priceErrorLabel);
            Controls.Add(nameErrorLabel);
            Controls.Add(errorLabel);
            Controls.Add(clearButton);
            Controls.Add(addButton);
            Controls.Add(imageGroupBox);
            Controls.Add(imageLabel);
            Controls.Add(barcodeTextBox);
            Controls.Add(barcodeLabel);
            Controls.Add(priceTextBox);
            Controls.Add(sellingPriceLabel);
            Controls.Add(departmentTextBox);
            Controls.Add(departmentLabel);
            Controls.Add(sizeTextBox);
            Controls.Add(sizeLabel);
            Controls.Add(descriptionTextBox);
            Controls.Add(descriptionLabel);
            Controls.Add(nameTextBox);
            Controls.Add(productNameLabel);
            Controls.Add(titleLabel);
            Name = "AddProductUserControl";
            Size = new Size(359, 627);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            imageGroupBox.ResumeLayout(false);
            imageGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private TextBox nameTextBox;
        private Label productNameLabel;
        private Label descriptionLabel;
        private RichTextBox descriptionTextBox;
        private TextBox sizeTextBox;
        private Label sizeLabel;
        private TextBox departmentTextBox;
        private Label departmentLabel;
        private TextBox priceTextBox;
        private Label sellingPriceLabel;
        private TextBox barcodeTextBox;
        private Label barcodeLabel;
        private Label imageLabel;
        private PictureBox pictureBox;
        private GroupBox imageGroupBox;
        private OpenFileDialog openFileDialog;
        private Button clearButton;
        private Button addButton;
        private Label errorLabel;
        private Label nameErrorLabel;
        private Label priceErrorLabel;
        private Label barcodeErrorLabel;
    }
}
