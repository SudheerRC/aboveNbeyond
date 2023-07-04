namespace MyStores.UserControls
{
    partial class OrderedProductTileUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderedProductTileUserControl));
            productImagePictureBox = new PictureBox();
            productNameLinkLabel = new LinkLabel();
            descriptionLabel = new Label();
            minusButton = new Button();
            addButton = new Button();
            quantityTextBox = new TextBox();
            removeButton = new Button();
            priceTextBox = new TextBox();
            priceLabel = new Label();
            quantityLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)productImagePictureBox).BeginInit();
            SuspendLayout();
            // 
            // productImagePictureBox
            // 
            productImagePictureBox.Location = new Point(3, 4);
            productImagePictureBox.Margin = new Padding(3, 4, 3, 4);
            productImagePictureBox.Name = "productImagePictureBox";
            productImagePictureBox.Size = new Size(95, 141);
            productImagePictureBox.TabIndex = 0;
            productImagePictureBox.TabStop = false;
            // 
            // productNameLinkLabel
            // 
            productNameLinkLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            productNameLinkLabel.Location = new Point(105, 4);
            productNameLinkLabel.Name = "productNameLinkLabel";
            productNameLinkLabel.Size = new Size(241, 49);
            productNameLinkLabel.TabIndex = 1;
            productNameLinkLabel.TabStop = true;
            productNameLinkLabel.Text = "Product Name";
            productNameLinkLabel.LinkClicked += productNameLinkLabel_LinkClicked;
            // 
            // descriptionLabel
            // 
            descriptionLabel.Location = new Point(105, 53);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(241, 88);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description";
            // 
            // minusButton
            // 
            minusButton.FlatStyle = FlatStyle.Flat;
            minusButton.Image = (Image)resources.GetObject("minusButton.Image");
            minusButton.Location = new Point(363, 99);
            minusButton.Margin = new Padding(3, 4, 3, 4);
            minusButton.Name = "minusButton";
            minusButton.Size = new Size(41, 42);
            minusButton.TabIndex = 3;
            minusButton.UseVisualStyleBackColor = true;
            minusButton.Click += minusButton_Click;
            // 
            // addButton
            // 
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Image = (Image)resources.GetObject("addButton.Image");
            addButton.Location = new Point(459, 99);
            addButton.Margin = new Padding(3, 4, 3, 4);
            addButton.Name = "addButton";
            addButton.Size = new Size(41, 42);
            addButton.TabIndex = 4;
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // quantityTextBox
            // 
            quantityTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            quantityTextBox.Location = new Point(411, 99);
            quantityTextBox.Margin = new Padding(3, 4, 3, 4);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(41, 42);
            quantityTextBox.TabIndex = 5;
            quantityTextBox.Text = "4";
            quantityTextBox.TextAlign = HorizontalAlignment.Center;
            quantityTextBox.KeyPress += quantityTextBox_KeyPress;
            // 
            // removeButton
            // 
            removeButton.BackColor = Color.FromArgb(28, 44, 78);
            removeButton.FlatStyle = FlatStyle.Flat;
            removeButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            removeButton.ForeColor = Color.FromArgb(243, 239, 245);
            removeButton.Image = (Image)resources.GetObject("removeButton.Image");
            removeButton.Location = new Point(507, 4);
            removeButton.Margin = new Padding(3, 4, 3, 4);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(102, 141);
            removeButton.TabIndex = 6;
            removeButton.Text = "Remove";
            removeButton.TextAlign = ContentAlignment.BottomCenter;
            removeButton.TextImageRelation = TextImageRelation.ImageAboveText;
            removeButton.UseVisualStyleBackColor = false;
            removeButton.Click += removeButton_Click;
            // 
            // priceTextBox
            // 
            priceTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            priceTextBox.Location = new Point(431, 7);
            priceTextBox.Margin = new Padding(3, 4, 3, 4);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(69, 42);
            priceTextBox.TabIndex = 7;
            priceTextBox.Text = "4";
            priceTextBox.TextAlign = HorizontalAlignment.Center;
            priceTextBox.KeyPress += priceTextBox_KeyPress;
            // 
            // priceLabel
            // 
            priceLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            priceLabel.Location = new Point(363, 7);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(67, 49);
            priceLabel.TabIndex = 8;
            priceLabel.Text = "Price per unit: ";
            priceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // quantityLabel
            // 
            quantityLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            quantityLabel.Location = new Point(363, 56);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(99, 39);
            quantityLabel.TabIndex = 9;
            quantityLabel.Text = "Quantity : ";
            quantityLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // OrderedProductTileUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(quantityLabel);
            Controls.Add(priceLabel);
            Controls.Add(priceTextBox);
            Controls.Add(removeButton);
            Controls.Add(quantityTextBox);
            Controls.Add(addButton);
            Controls.Add(minusButton);
            Controls.Add(descriptionLabel);
            Controls.Add(productNameLinkLabel);
            Controls.Add(productImagePictureBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "OrderedProductTileUserControl";
            Size = new Size(614, 149);
            Load += OrderedProductTileUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)productImagePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox productImagePictureBox;
        private LinkLabel productNameLinkLabel;
        private Label descriptionLabel;
        private Button minusButton;
        private Button addButton;
        private TextBox quantityTextBox;
        private Button removeButton;
        private TextBox priceTextBox;
        private Label priceLabel;
        private Label quantityLabel;
    }
}
