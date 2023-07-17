namespace MyStores.View
{
    partial class EditInventoryItemForm
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.purchasePriceErrorLabel = new System.Windows.Forms.Label();
            this.sellingPriceErrorLabel = new System.Windows.Forms.Label();
            this.quantityErrorLabel = new System.Windows.Forms.Label();
            this.defaultQuantityErrorLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.sellingPriceTextBox = new System.Windows.Forms.TextBox();
            this.sellingPriceLabel = new System.Windows.Forms.Label();
            this.defaultQuantityTextBox = new System.Windows.Forms.TextBox();
            this.defaultQuantityLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.purchasePriceTextBox = new System.Windows.Forms.TextBox();
            this.purchasePriceLabel = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.groupBox.Controls.Add(this.clearButton);
            this.groupBox.Controls.Add(this.saveButton);
            this.groupBox.Controls.Add(this.purchasePriceErrorLabel);
            this.groupBox.Controls.Add(this.sellingPriceErrorLabel);
            this.groupBox.Controls.Add(this.quantityErrorLabel);
            this.groupBox.Controls.Add(this.defaultQuantityErrorLabel);
            this.groupBox.Controls.Add(this.titleLabel);
            this.groupBox.Controls.Add(this.sellingPriceTextBox);
            this.groupBox.Controls.Add(this.sellingPriceLabel);
            this.groupBox.Controls.Add(this.defaultQuantityTextBox);
            this.groupBox.Controls.Add(this.defaultQuantityLabel);
            this.groupBox.Controls.Add(this.quantityTextBox);
            this.groupBox.Controls.Add(this.quantityLabel);
            this.groupBox.Controls.Add(this.purchasePriceTextBox);
            this.groupBox.Controls.Add(this.purchasePriceLabel);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox.Size = new System.Drawing.Size(814, 690);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.clearButton.Enabled = false;
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clearButton.Location = new System.Drawing.Point(508, 582);
            this.clearButton.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(198, 67);
            this.clearButton.TabIndex = 114;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.saveButton.Enabled = false;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveButton.Location = new System.Drawing.Point(108, 582);
            this.saveButton.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(260, 67);
            this.saveButton.TabIndex = 113;
            this.saveButton.Text = "Save Details";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // purchasePriceErrorLabel
            // 
            this.purchasePriceErrorLabel.AutoSize = true;
            this.purchasePriceErrorLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.purchasePriceErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.purchasePriceErrorLabel.Location = new System.Drawing.Point(231, 311);
            this.purchasePriceErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.purchasePriceErrorLabel.Name = "purchasePriceErrorLabel";
            this.purchasePriceErrorLabel.Size = new System.Drawing.Size(111, 32);
            this.purchasePriceErrorLabel.TabIndex = 72;
            this.purchasePriceErrorLabel.Text = "Error text";
            this.purchasePriceErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.purchasePriceErrorLabel.UseWaitCursor = true;
            this.purchasePriceErrorLabel.Visible = false;
            // 
            // sellingPriceErrorLabel
            // 
            this.sellingPriceErrorLabel.AutoSize = true;
            this.sellingPriceErrorLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sellingPriceErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.sellingPriceErrorLabel.Location = new System.Drawing.Point(240, 204);
            this.sellingPriceErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sellingPriceErrorLabel.Name = "sellingPriceErrorLabel";
            this.sellingPriceErrorLabel.Size = new System.Drawing.Size(111, 32);
            this.sellingPriceErrorLabel.TabIndex = 71;
            this.sellingPriceErrorLabel.Text = "Error text";
            this.sellingPriceErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sellingPriceErrorLabel.UseWaitCursor = true;
            this.sellingPriceErrorLabel.Visible = false;
            // 
            // quantityErrorLabel
            // 
            this.quantityErrorLabel.AutoSize = true;
            this.quantityErrorLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantityErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.quantityErrorLabel.Location = new System.Drawing.Point(240, 401);
            this.quantityErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantityErrorLabel.Name = "quantityErrorLabel";
            this.quantityErrorLabel.Size = new System.Drawing.Size(111, 32);
            this.quantityErrorLabel.TabIndex = 70;
            this.quantityErrorLabel.Text = "Error text";
            this.quantityErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.quantityErrorLabel.UseWaitCursor = true;
            this.quantityErrorLabel.Visible = false;
            // 
            // defaultQuantityErrorLabel
            // 
            this.defaultQuantityErrorLabel.AutoSize = true;
            this.defaultQuantityErrorLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.defaultQuantityErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.defaultQuantityErrorLabel.Location = new System.Drawing.Point(240, 500);
            this.defaultQuantityErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.defaultQuantityErrorLabel.Name = "defaultQuantityErrorLabel";
            this.defaultQuantityErrorLabel.Size = new System.Drawing.Size(111, 32);
            this.defaultQuantityErrorLabel.TabIndex = 69;
            this.defaultQuantityErrorLabel.Text = "Error text";
            this.defaultQuantityErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.defaultQuantityErrorLabel.UseWaitCursor = true;
            this.defaultQuantityErrorLabel.Visible = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.titleLabel.Location = new System.Drawing.Point(210, 38);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(496, 58);
            this.titleLabel.TabIndex = 65;
            this.titleLabel.Text = "Edit Inventory Item Details";
            this.titleLabel.UseCompatibleTextRendering = true;
            // 
            // sellingPriceTextBox
            // 
            this.sellingPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sellingPriceTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sellingPriceTextBox.Location = new System.Drawing.Point(409, 150);
            this.sellingPriceTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.sellingPriceTextBox.Name = "sellingPriceTextBox";
            this.sellingPriceTextBox.Size = new System.Drawing.Size(292, 39);
            this.sellingPriceTextBox.TabIndex = 55;
            this.sellingPriceTextBox.GotFocus += SellingPriceTextBox_GotFocus;
            this.sellingPriceTextBox.TextChanged += SellingPriceTextBox_TextChanged;
            // 
            // sellingPriceLabel
            // 
            this.sellingPriceLabel.AutoSize = true;
            this.sellingPriceLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sellingPriceLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sellingPriceLabel.Location = new System.Drawing.Point(181, 152);
            this.sellingPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sellingPriceLabel.Name = "sellingPriceLabel";
            this.sellingPriceLabel.Size = new System.Drawing.Size(161, 37);
            this.sellingPriceLabel.TabIndex = 63;
            this.sellingPriceLabel.Text = "Selling Price";
            // 
            // defaultQuantityTextBox
            // 
            this.defaultQuantityTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.defaultQuantityTextBox.Location = new System.Drawing.Point(409, 443);
            this.defaultQuantityTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.defaultQuantityTextBox.Name = "defaultQuantityTextBox";
            this.defaultQuantityTextBox.Size = new System.Drawing.Size(290, 39);
            this.defaultQuantityTextBox.TabIndex = 61;
            this.defaultQuantityTextBox.GotFocus += DefaultQuantityTextBox_GotFocus;
            this.defaultQuantityTextBox.TextChanged += DefaultQuantityTextBox_TextChanged;
            // 
            // defaultQuantityLabel
            // 
            this.defaultQuantityLabel.AutoSize = true;
            this.defaultQuantityLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.defaultQuantityLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.defaultQuantityLabel.Location = new System.Drawing.Point(0, 445);
            this.defaultQuantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.defaultQuantityLabel.Name = "defaultQuantityLabel";
            this.defaultQuantityLabel.Size = new System.Drawing.Size(355, 37);
            this.defaultQuantityLabel.TabIndex = 58;
            this.defaultQuantityLabel.Text = "Preferred Minimum Quantity";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.quantityTextBox.Location = new System.Drawing.Point(409, 353);
            this.quantityTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(290, 39);
            this.quantityTextBox.TabIndex = 59;
            this.quantityTextBox.GotFocus += QuantityTextBox_GotFocus;
            this.quantityTextBox.TextChanged += QuantityTextBox_TextChanged;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantityLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.quantityLabel.Location = new System.Drawing.Point(108, 352);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(234, 37);
            this.quantityLabel.TabIndex = 56;
            this.quantityLabel.Text = "Available Quantity";
            // 
            // purchasePriceTextBox
            // 
            this.purchasePriceTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.purchasePriceTextBox.Location = new System.Drawing.Point(409, 263);
            this.purchasePriceTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.purchasePriceTextBox.Name = "purchasePriceTextBox";
            this.purchasePriceTextBox.Size = new System.Drawing.Size(290, 39);
            this.purchasePriceTextBox.TabIndex = 57;
            this.purchasePriceTextBox.GotFocus += PurchasePriceTextBox_GotFocus;
            this.purchasePriceTextBox.TextChanged += PurchasePriceTextBox_TextChanged;
            // 
            // purchasePriceLabel
            // 
            this.purchasePriceLabel.AutoSize = true;
            this.purchasePriceLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.purchasePriceLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.purchasePriceLabel.Location = new System.Drawing.Point(156, 264);
            this.purchasePriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.purchasePriceLabel.Name = "purchasePriceLabel";
            this.purchasePriceLabel.Size = new System.Drawing.Size(186, 37);
            this.purchasePriceLabel.TabIndex = 54;
            this.purchasePriceLabel.Text = "Purchase Price";
            // 
            // EditInventoryItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 690);
            this.Controls.Add(this.groupBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditInventoryItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Inventory Item Form";
            this.Load += new System.EventHandler(this.EditInventoryItemForm_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox;
        private Label sellingPriceErrorLabel;
        private Label quantityErrorLabel;
        private Label defaultQuantityErrorLabel;
        private Label titleLabel;
        private TextBox sellingPriceTextBox;
        private Label sellingPriceLabel;
        private TextBox defaultQuantityTextBox;
        private Label defaultQuantityLabel;
        private TextBox quantityTextBox;
        private Label quantityLabel;
        private TextBox purchasePriceTextBox;
        private Label purchasePriceLabel;
        private Label purchasePriceErrorLabel;
        private Button clearButton;
        private Button saveButton;
    }
}