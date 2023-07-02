namespace MyStores.UserControls
{
    partial class OrderedProducTileUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderedProducTileUserControl));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.productNameLinkLabel = new System.Windows.Forms.LinkLabel();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.minusButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 106);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // productNameLinkLabel
            // 
            this.productNameLinkLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productNameLinkLabel.Location = new System.Drawing.Point(92, 3);
            this.productNameLinkLabel.Name = "productNameLinkLabel";
            this.productNameLinkLabel.Size = new System.Drawing.Size(211, 37);
            this.productNameLinkLabel.TabIndex = 1;
            this.productNameLinkLabel.TabStop = true;
            this.productNameLinkLabel.Text = "Product Name";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Location = new System.Drawing.Point(92, 40);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(211, 69);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Description";
            // 
            // minusButton
            // 
            this.minusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusButton.Image = ((System.Drawing.Image)(resources.GetObject("minusButton.Image")));
            this.minusButton.Location = new System.Drawing.Point(318, 73);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(36, 36);
            this.minusButton.TabIndex = 3;
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // addButton
            // 
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Image = ((System.Drawing.Image)(resources.GetObject("addButton.Image")));
            this.addButton.Location = new System.Drawing.Point(402, 73);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(36, 36);
            this.addButton.TabIndex = 4;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantityTextBox.Location = new System.Drawing.Point(360, 74);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(36, 35);
            this.quantityTextBox.TabIndex = 5;
            this.quantityTextBox.Text = "4";
            this.quantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.removeButton.Image = ((System.Drawing.Image)(resources.GetObject("removeButton.Image")));
            this.removeButton.Location = new System.Drawing.Point(444, 3);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(89, 106);
            this.removeButton.TabIndex = 6;
            this.removeButton.Text = "Remove";
            this.removeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(377, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(61, 35);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "4";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // priceLabel
            // 
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceLabel.Location = new System.Drawing.Point(318, 5);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(59, 37);
            this.priceLabel.TabIndex = 8;
            this.priceLabel.Text = "Price per unit: ";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(318, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Quantity : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrderedProducTileUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.productNameLinkLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "OrderedProducTileUserControl";
            this.Size = new System.Drawing.Size(539, 121);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private LinkLabel productNameLinkLabel;
        private Label descriptionLabel;
        private Button minusButton;
        private Button addButton;
        private TextBox quantityTextBox;
        private Button removeButton;
        private TextBox textBox1;
        private Label priceLabel;
        private Label label1;
    }
}
