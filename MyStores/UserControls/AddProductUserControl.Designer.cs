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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductUserControl));
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
            savedPicture = new PictureBox();
            savedImage = new Label();
            editButton = new Button();
            defaultProductPicture = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            imageGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)savedPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)defaultProductPicture).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.ForeColor = SystemColors.ControlText;
            titleLabel.Location = new Point(176, 36);
            titleLabel.Margin = new Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(290, 58);
            titleLabel.TabIndex = 66;
            titleLabel.Text = "Product Details";
            titleLabel.UseCompatibleTextRendering = true;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(282, 141);
            nameTextBox.Margin = new Padding(4, 2, 4, 2);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(290, 39);
            nameTextBox.TabIndex = 67;
            nameTextBox.GotFocus += NameTextBox_GotFocus;
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            productNameLabel.Location = new Point(65, 141);
            productNameLabel.Margin = new Padding(4, 0, 4, 0);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(193, 37);
            productNameLabel.TabIndex = 68;
            productNameLabel.Text = "Product name*";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionLabel.Location = new Point(65, 299);
            descriptionLabel.Margin = new Padding(4, 0, 4, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(152, 37);
            descriptionLabel.TabIndex = 70;
            descriptionLabel.Text = "Description";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(282, 260);
            descriptionTextBox.Margin = new Padding(6);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(290, 104);
            descriptionTextBox.TabIndex = 71;
            descriptionTextBox.Text = "";
            // 
            // sizeTextBox
            // 
            sizeTextBox.Location = new Point(295, 465);
            sizeTextBox.Margin = new Padding(4, 2, 4, 2);
            sizeTextBox.Name = "sizeTextBox";
            sizeTextBox.Size = new Size(277, 39);
            sizeTextBox.TabIndex = 72;
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            sizeLabel.Location = new Point(78, 465);
            sizeLabel.Margin = new Padding(4, 0, 4, 0);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new Size(160, 37);
            sizeLabel.TabIndex = 73;
            sizeLabel.Text = "Product size";
            // 
            // departmentTextBox
            // 
            departmentTextBox.Location = new Point(295, 580);
            departmentTextBox.Margin = new Padding(4, 2, 4, 2);
            departmentTextBox.Name = "departmentTextBox";
            departmentTextBox.Size = new Size(277, 39);
            departmentTextBox.TabIndex = 74;
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            departmentLabel.Location = new Point(78, 580);
            departmentLabel.Margin = new Padding(4, 0, 4, 0);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new Size(159, 37);
            departmentLabel.TabIndex = 75;
            departmentLabel.Text = "Department";
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(295, 683);
            priceTextBox.Margin = new Padding(4, 2, 4, 2);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(277, 39);
            priceTextBox.TabIndex = 76;
            priceTextBox.GotFocus += PriceTextBox_GotFocus;
            // 
            // sellingPriceLabel
            // 
            sellingPriceLabel.AutoSize = true;
            sellingPriceLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            sellingPriceLabel.Location = new Point(78, 683);
            sellingPriceLabel.Margin = new Padding(4, 0, 4, 0);
            sellingPriceLabel.Name = "sellingPriceLabel";
            sellingPriceLabel.Size = new Size(172, 37);
            sellingPriceLabel.TabIndex = 77;
            sellingPriceLabel.Text = "Selling Price*";
            // 
            // barcodeTextBox
            // 
            barcodeTextBox.Location = new Point(295, 796);
            barcodeTextBox.Margin = new Padding(4, 2, 4, 2);
            barcodeTextBox.Name = "barcodeTextBox";
            barcodeTextBox.Size = new Size(277, 39);
            barcodeTextBox.TabIndex = 78;
            barcodeTextBox.GotFocus += BarcodeTextBox_GotFocus;
            barcodeTextBox.KeyPress += BarcodeTextBox_KeyPress;
            // 
            // barcodeLabel
            // 
            barcodeLabel.AutoSize = true;
            barcodeLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            barcodeLabel.Location = new Point(78, 796);
            barcodeLabel.Margin = new Padding(4, 0, 4, 0);
            barcodeLabel.Name = "barcodeLabel";
            barcodeLabel.Size = new Size(124, 37);
            barcodeLabel.TabIndex = 79;
            barcodeLabel.Text = "Barcode*";
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            imageLabel.Location = new Point(78, 975);
            imageLabel.Margin = new Padding(4, 0, 4, 0);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new Size(91, 37);
            imageLabel.TabIndex = 80;
            imageLabel.Text = "Image";
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(6, 38);
            pictureBox.Margin = new Padding(6);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(298, 169);
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox.TabIndex = 81;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox_Click;
            // 
            // imageGroupBox
            // 
            imageGroupBox.Controls.Add(pictureBox);
            imageGroupBox.Location = new Point(295, 896);
            imageGroupBox.Margin = new Padding(6);
            imageGroupBox.Name = "imageGroupBox";
            imageGroupBox.Padding = new Padding(6);
            imageGroupBox.Size = new Size(310, 213);
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
            clearButton.Location = new Point(396, 1218);
            clearButton.Margin = new Padding(4, 2, 4, 2);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(150, 62);
            clearButton.TabIndex = 84;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += ClearButton_Click;
            // 
            // addButton
            // 
            addButton.BackColor = Color.White;
            addButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.Location = new Point(98, 1218);
            addButton.Margin = new Padding(4, 2, 4, 2);
            addButton.Name = "addButton";
            addButton.Size = new Size(206, 62);
            addButton.TabIndex = 83;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += AddButton_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            errorLabel.Location = new Point(78, 1152);
            errorLabel.Margin = new Padding(4, 0, 4, 0);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(125, 37);
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
            nameErrorLabel.Location = new Point(108, 207);
            nameErrorLabel.Margin = new Padding(4, 0, 4, 0);
            nameErrorLabel.Name = "nameErrorLabel";
            nameErrorLabel.Size = new Size(111, 32);
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
            priceErrorLabel.Location = new Point(108, 742);
            priceErrorLabel.Margin = new Padding(4, 0, 4, 0);
            priceErrorLabel.Name = "priceErrorLabel";
            priceErrorLabel.Size = new Size(111, 32);
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
            barcodeErrorLabel.Location = new Point(108, 868);
            barcodeErrorLabel.Margin = new Padding(4, 0, 4, 0);
            barcodeErrorLabel.Name = "barcodeErrorLabel";
            barcodeErrorLabel.Size = new Size(111, 32);
            barcodeErrorLabel.TabIndex = 88;
            barcodeErrorLabel.Text = "Error text";
            barcodeErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            barcodeErrorLabel.UseWaitCursor = true;
            barcodeErrorLabel.Visible = false;
            // 
            // savedPicture
            // 
            savedPicture.Location = new Point(710, 488);
            savedPicture.Name = "savedPicture";
            savedPicture.Size = new Size(366, 328);
            savedPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            savedPicture.TabIndex = 89;
            savedPicture.TabStop = false;
            // 
            // savedImage
            // 
            savedImage.AutoSize = true;
            savedImage.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            savedImage.Location = new Point(720, 389);
            savedImage.Margin = new Padding(4, 0, 4, 0);
            savedImage.Name = "savedImage";
            savedImage.Size = new Size(169, 37);
            savedImage.TabIndex = 90;
            savedImage.Text = "Saved Image";
            // 
            // editButton
            // 
            editButton.BackColor = Color.White;
            editButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            editButton.Location = new Point(98, 1218);
            editButton.Margin = new Padding(4, 2, 4, 2);
            editButton.Name = "editButton";
            editButton.Size = new Size(206, 62);
            editButton.TabIndex = 91;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = false;
            editButton.Visible = false;
            // 
            // defaultProductPicture
            // 
            defaultProductPicture.Image = (Image)resources.GetObject("defaultProductPicture.Image");
            defaultProductPicture.Location = new Point(824, 1077);
            defaultProductPicture.Name = "defaultProductPicture";
            defaultProductPicture.Size = new Size(96, 96);
            defaultProductPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            defaultProductPicture.TabIndex = 92;
            defaultProductPicture.TabStop = false;
            defaultProductPicture.Visible = false;
            // 
            // AddProductUserControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            Controls.Add(defaultProductPicture);
            Controls.Add(savedImage);
            Controls.Add(savedPicture);
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
            Controls.Add(editButton);
            Margin = new Padding(6);
            Name = "AddProductUserControl";
            Size = new Size(1191, 1338);
            Load += AddProductUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            imageGroupBox.ResumeLayout(false);
            imageGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)savedPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)defaultProductPicture).EndInit();
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
        private PictureBox savedPicture;
        private Label savedImage;
        private Button editButton;
        private PictureBox defaultProductPicture;
    }
}
