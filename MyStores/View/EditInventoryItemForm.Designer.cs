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
            groupBox = new GroupBox();
            clearButton = new Button();
            saveButton = new Button();
            purchasePriceErrorLabel = new Label();
            sellingPriceErrorLabel = new Label();
            quantityErrorLabel = new Label();
            defaultQuantityErrorLabel = new Label();
            titleLabel = new Label();
            sellingPriceTextBox = new TextBox();
            sellingPriceLabel = new Label();
            defaultQuantityTextBox = new TextBox();
            defaultQuantityLabel = new Label();
            quantityTextBox = new TextBox();
            quantityLabel = new Label();
            purchasePriceTextBox = new TextBox();
            purchasePriceLabel = new Label();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.BackColor = Color.FromArgb(227, 211, 177);
            groupBox.Controls.Add(clearButton);
            groupBox.Controls.Add(saveButton);
            groupBox.Controls.Add(purchasePriceErrorLabel);
            groupBox.Controls.Add(sellingPriceErrorLabel);
            groupBox.Controls.Add(quantityErrorLabel);
            groupBox.Controls.Add(defaultQuantityErrorLabel);
            groupBox.Controls.Add(titleLabel);
            groupBox.Controls.Add(sellingPriceTextBox);
            groupBox.Controls.Add(sellingPriceLabel);
            groupBox.Controls.Add(defaultQuantityTextBox);
            groupBox.Controls.Add(defaultQuantityLabel);
            groupBox.Controls.Add(quantityTextBox);
            groupBox.Controls.Add(quantityLabel);
            groupBox.Controls.Add(purchasePriceTextBox);
            groupBox.Controls.Add(purchasePriceLabel);
            groupBox.Dock = DockStyle.Fill;
            groupBox.ForeColor = SystemColors.ControlText;
            groupBox.Location = new Point(0, 0);
            groupBox.Margin = new Padding(6);
            groupBox.Name = "groupBox";
            groupBox.Padding = new Padding(6);
            groupBox.Size = new Size(814, 690);
            groupBox.TabIndex = 1;
            groupBox.TabStop = false;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.FromArgb(28, 44, 78);
            clearButton.Enabled = false;
            clearButton.FlatAppearance.BorderSize = 0;
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            clearButton.ForeColor = SystemColors.ControlLightLight;
            clearButton.Location = new Point(508, 582);
            clearButton.Margin = new Padding(8, 6, 8, 6);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(198, 67);
            clearButton.TabIndex = 114;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += ClearButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(28, 44, 78);
            saveButton.Enabled = false;
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            saveButton.ForeColor = SystemColors.ControlLightLight;
            saveButton.Location = new Point(108, 582);
            saveButton.Margin = new Padding(8, 6, 8, 6);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(260, 67);
            saveButton.TabIndex = 113;
            saveButton.Text = "Save Details";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += SaveButton_Click;
            // 
            // purchasePriceErrorLabel
            // 
            purchasePriceErrorLabel.AutoSize = true;
            purchasePriceErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            purchasePriceErrorLabel.ForeColor = Color.Red;
            purchasePriceErrorLabel.Location = new Point(231, 311);
            purchasePriceErrorLabel.Margin = new Padding(4, 0, 4, 0);
            purchasePriceErrorLabel.Name = "purchasePriceErrorLabel";
            purchasePriceErrorLabel.Size = new Size(111, 32);
            purchasePriceErrorLabel.TabIndex = 72;
            purchasePriceErrorLabel.Text = "Error text";
            purchasePriceErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            purchasePriceErrorLabel.UseWaitCursor = true;
            purchasePriceErrorLabel.Visible = false;
            // 
            // sellingPriceErrorLabel
            // 
            sellingPriceErrorLabel.AutoSize = true;
            sellingPriceErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            sellingPriceErrorLabel.ForeColor = Color.Red;
            sellingPriceErrorLabel.Location = new Point(240, 204);
            sellingPriceErrorLabel.Margin = new Padding(4, 0, 4, 0);
            sellingPriceErrorLabel.Name = "sellingPriceErrorLabel";
            sellingPriceErrorLabel.Size = new Size(111, 32);
            sellingPriceErrorLabel.TabIndex = 71;
            sellingPriceErrorLabel.Text = "Error text";
            sellingPriceErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            sellingPriceErrorLabel.UseWaitCursor = true;
            sellingPriceErrorLabel.Visible = false;
            // 
            // quantityErrorLabel
            // 
            quantityErrorLabel.AutoSize = true;
            quantityErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            quantityErrorLabel.ForeColor = Color.Red;
            quantityErrorLabel.Location = new Point(240, 401);
            quantityErrorLabel.Margin = new Padding(4, 0, 4, 0);
            quantityErrorLabel.Name = "quantityErrorLabel";
            quantityErrorLabel.Size = new Size(111, 32);
            quantityErrorLabel.TabIndex = 70;
            quantityErrorLabel.Text = "Error text";
            quantityErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            quantityErrorLabel.UseWaitCursor = true;
            quantityErrorLabel.Visible = false;
            // 
            // defaultQuantityErrorLabel
            // 
            defaultQuantityErrorLabel.AutoSize = true;
            defaultQuantityErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            defaultQuantityErrorLabel.ForeColor = Color.Red;
            defaultQuantityErrorLabel.Location = new Point(240, 500);
            defaultQuantityErrorLabel.Margin = new Padding(4, 0, 4, 0);
            defaultQuantityErrorLabel.Name = "defaultQuantityErrorLabel";
            defaultQuantityErrorLabel.Size = new Size(111, 32);
            defaultQuantityErrorLabel.TabIndex = 69;
            defaultQuantityErrorLabel.Text = "Error text";
            defaultQuantityErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            defaultQuantityErrorLabel.UseWaitCursor = true;
            defaultQuantityErrorLabel.Visible = false;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.ForeColor = SystemColors.ControlText;
            titleLabel.Location = new Point(210, 38);
            titleLabel.Margin = new Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(496, 58);
            titleLabel.TabIndex = 65;
            titleLabel.Text = "Edit Inventory Item Details";
            titleLabel.UseCompatibleTextRendering = true;
            // 
            // sellingPriceTextBox
            // 
            sellingPriceTextBox.BorderStyle = BorderStyle.FixedSingle;
            sellingPriceTextBox.ForeColor = SystemColors.WindowText;
            sellingPriceTextBox.Location = new Point(409, 150);
            sellingPriceTextBox.Margin = new Padding(4, 2, 4, 2);
            sellingPriceTextBox.Name = "sellingPriceTextBox";
            sellingPriceTextBox.Size = new Size(292, 39);
            sellingPriceTextBox.TabIndex = 55;
            sellingPriceTextBox.TextChanged += SellingPriceTextBox_TextChanged;
            sellingPriceTextBox.GotFocus += SellingPriceTextBox_GotFocus;
            // 
            // sellingPriceLabel
            // 
            sellingPriceLabel.AutoSize = true;
            sellingPriceLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            sellingPriceLabel.ForeColor = SystemColors.WindowText;
            sellingPriceLabel.Location = new Point(181, 152);
            sellingPriceLabel.Margin = new Padding(4, 0, 4, 0);
            sellingPriceLabel.Name = "sellingPriceLabel";
            sellingPriceLabel.Size = new Size(161, 37);
            sellingPriceLabel.TabIndex = 63;
            sellingPriceLabel.Text = "Selling Price";
            // 
            // defaultQuantityTextBox
            // 
            defaultQuantityTextBox.ForeColor = SystemColors.WindowText;
            defaultQuantityTextBox.Location = new Point(409, 443);
            defaultQuantityTextBox.Margin = new Padding(4, 2, 4, 2);
            defaultQuantityTextBox.Name = "defaultQuantityTextBox";
            defaultQuantityTextBox.Size = new Size(290, 39);
            defaultQuantityTextBox.TabIndex = 61;
            defaultQuantityTextBox.TextChanged += DefaultQuantityTextBox_TextChanged;
            defaultQuantityTextBox.GotFocus += DefaultQuantityTextBox_GotFocus;
            // 
            // defaultQuantityLabel
            // 
            defaultQuantityLabel.AutoSize = true;
            defaultQuantityLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            defaultQuantityLabel.ForeColor = SystemColors.WindowText;
            defaultQuantityLabel.Location = new Point(0, 445);
            defaultQuantityLabel.Margin = new Padding(4, 0, 4, 0);
            defaultQuantityLabel.Name = "defaultQuantityLabel";
            defaultQuantityLabel.Size = new Size(355, 37);
            defaultQuantityLabel.TabIndex = 58;
            defaultQuantityLabel.Text = "Preferred Minimum Quantity";
            // 
            // quantityTextBox
            // 
            quantityTextBox.ForeColor = SystemColors.WindowText;
            quantityTextBox.Location = new Point(409, 353);
            quantityTextBox.Margin = new Padding(4, 2, 4, 2);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(290, 39);
            quantityTextBox.TabIndex = 59;
            quantityTextBox.TextChanged += QuantityTextBox_TextChanged;
            quantityTextBox.GotFocus += QuantityTextBox_GotFocus;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            quantityLabel.ForeColor = SystemColors.WindowText;
            quantityLabel.Location = new Point(108, 352);
            quantityLabel.Margin = new Padding(4, 0, 4, 0);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(234, 37);
            quantityLabel.TabIndex = 56;
            quantityLabel.Text = "Available Quantity";
            // 
            // purchasePriceTextBox
            // 
            purchasePriceTextBox.ForeColor = SystemColors.WindowText;
            purchasePriceTextBox.Location = new Point(409, 263);
            purchasePriceTextBox.Margin = new Padding(4, 2, 4, 2);
            purchasePriceTextBox.Name = "purchasePriceTextBox";
            purchasePriceTextBox.Size = new Size(290, 39);
            purchasePriceTextBox.TabIndex = 57;
            purchasePriceTextBox.TextChanged += PurchasePriceTextBox_TextChanged;
            purchasePriceTextBox.GotFocus += PurchasePriceTextBox_GotFocus;
            // 
            // purchasePriceLabel
            // 
            purchasePriceLabel.AutoSize = true;
            purchasePriceLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            purchasePriceLabel.ForeColor = SystemColors.WindowText;
            purchasePriceLabel.Location = new Point(156, 264);
            purchasePriceLabel.Margin = new Padding(4, 0, 4, 0);
            purchasePriceLabel.Name = "purchasePriceLabel";
            purchasePriceLabel.Size = new Size(186, 37);
            purchasePriceLabel.TabIndex = 54;
            purchasePriceLabel.Text = "Purchase Price";
            // 
            // EditInventoryItemForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 690);
            Controls.Add(groupBox);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditInventoryItemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Inventory Item Form";
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
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