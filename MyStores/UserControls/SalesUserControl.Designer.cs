namespace MyStores.UserControls
{
    partial class SalesUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesUserControl));
            fromDateTimePicker = new DateTimePicker();
            rangeComboBox = new ComboBox();
            mainDataGridView = new DataGridView();
            saleId = new DataGridViewTextBoxColumn();
            saleDateTime = new DataGridViewTextBoxColumn();
            saleTotal = new DataGridViewTextBoxColumn();
            saleTax = new DataGridViewTextBoxColumn();
            paymentType = new DataGridViewTextBoxColumn();
            toDateTimePicker = new DateTimePicker();
            fromLabel = new Label();
            dateRadioButton = new RadioButton();
            rangeRadioButton = new RadioButton();
            toLabel = new Label();
            searchButton = new Button();
            viewSaleButton = new Button();
            listOfSalesLabel = new Label();
            noSalesMessageLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)mainDataGridView).BeginInit();
            SuspendLayout();
            // 
            // fromDateTimePicker
            // 
            fromDateTimePicker.Format = DateTimePickerFormat.Short;
            fromDateTimePicker.Location = new Point(177, 77);
            fromDateTimePicker.Margin = new Padding(5);
            fromDateTimePicker.Name = "fromDateTimePicker";
            fromDateTimePicker.Size = new Size(201, 39);
            fromDateTimePicker.TabIndex = 0;
            fromDateTimePicker.ValueChanged += FromDateTimePicker_ValueChanged;
            // 
            // rangeComboBox
            // 
            rangeComboBox.FormattingEnabled = true;
            rangeComboBox.Location = new Point(504, 75);
            rangeComboBox.Margin = new Padding(5);
            rangeComboBox.Name = "rangeComboBox";
            rangeComboBox.Size = new Size(243, 40);
            rangeComboBox.TabIndex = 2;
            // 
            // mainDataGridView
            // 
            mainDataGridView.AllowUserToAddRows = false;
            mainDataGridView.AllowUserToDeleteRows = false;
            mainDataGridView.BackgroundColor = SystemColors.ControlLightLight;
            mainDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mainDataGridView.Columns.AddRange(new DataGridViewColumn[] { saleId, saleDateTime, saleTotal, saleTax, paymentType });
            mainDataGridView.Location = new Point(41, 278);
            mainDataGridView.Margin = new Padding(5);
            mainDataGridView.MultiSelect = false;
            mainDataGridView.Name = "mainDataGridView";
            mainDataGridView.ReadOnly = true;
            mainDataGridView.RowHeadersWidth = 51;
            mainDataGridView.RowTemplate.Height = 29;
            mainDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            mainDataGridView.Size = new Size(991, 490);
            mainDataGridView.TabIndex = 3;
            mainDataGridView.SelectionChanged += mainDataGridView_SelectionChanged;
            // 
            // saleId
            // 
            saleId.HeaderText = "Sale Id";
            saleId.MinimumWidth = 6;
            saleId.Name = "saleId";
            saleId.ReadOnly = true;
            saleId.Visible = false;
            saleId.Width = 180;
            // 
            // saleDateTime
            // 
            saleDateTime.HeaderText = "Sale Date";
            saleDateTime.MinimumWidth = 6;
            saleDateTime.Name = "saleDateTime";
            saleDateTime.ReadOnly = true;
            saleDateTime.Width = 250;
            // 
            // saleTotal
            // 
            saleTotal.HeaderText = "Total";
            saleTotal.MinimumWidth = 6;
            saleTotal.Name = "saleTotal";
            saleTotal.ReadOnly = true;
            saleTotal.Width = 200;
            // 
            // saleTax
            // 
            saleTax.HeaderText = "Tax";
            saleTax.MinimumWidth = 6;
            saleTax.Name = "saleTax";
            saleTax.ReadOnly = true;
            saleTax.Width = 200;
            // 
            // paymentType
            // 
            paymentType.HeaderText = "Payment Type";
            paymentType.MinimumWidth = 6;
            paymentType.Name = "paymentType";
            paymentType.ReadOnly = true;
            paymentType.Width = 250;
            // 
            // toDateTimePicker
            // 
            toDateTimePicker.Format = DateTimePickerFormat.Short;
            toDateTimePicker.Location = new Point(177, 146);
            toDateTimePicker.Margin = new Padding(5);
            toDateTimePicker.Name = "toDateTimePicker";
            toDateTimePicker.Size = new Size(201, 39);
            toDateTimePicker.TabIndex = 4;
            // 
            // fromLabel
            // 
            fromLabel.AutoSize = true;
            fromLabel.Location = new Point(68, 85);
            fromLabel.Margin = new Padding(5, 0, 5, 0);
            fromLabel.Name = "fromLabel";
            fromLabel.Size = new Size(69, 32);
            fromLabel.TabIndex = 5;
            fromLabel.Text = "From";
            // 
            // dateRadioButton
            // 
            dateRadioButton.AutoSize = true;
            dateRadioButton.Location = new Point(177, 14);
            dateRadioButton.Margin = new Padding(5);
            dateRadioButton.Name = "dateRadioButton";
            dateRadioButton.Size = new Size(206, 36);
            dateRadioButton.TabIndex = 6;
            dateRadioButton.TabStop = true;
            dateRadioButton.Text = "Search by Date";
            dateRadioButton.UseVisualStyleBackColor = true;
            // 
            // rangeRadioButton
            // 
            rangeRadioButton.AutoSize = true;
            rangeRadioButton.Location = new Point(504, 14);
            rangeRadioButton.Margin = new Padding(5);
            rangeRadioButton.Name = "rangeRadioButton";
            rangeRadioButton.Size = new Size(223, 36);
            rangeRadioButton.TabIndex = 7;
            rangeRadioButton.TabStop = true;
            rangeRadioButton.Text = "Search by Range";
            rangeRadioButton.UseVisualStyleBackColor = true;
            // 
            // toLabel
            // 
            toLabel.AutoSize = true;
            toLabel.Location = new Point(68, 157);
            toLabel.Margin = new Padding(5, 0, 5, 0);
            toLabel.Name = "toLabel";
            toLabel.Size = new Size(39, 32);
            toLabel.TabIndex = 8;
            toLabel.Text = "To";
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.FromArgb(28, 44, 78);
            searchButton.Enabled = false;
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            searchButton.ForeColor = Color.FromArgb(243, 239, 245);
            searchButton.Image = (Image)resources.GetObject("searchButton.Image");
            searchButton.Location = new Point(902, 77);
            searchButton.Margin = new Padding(5, 6, 5, 6);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(130, 114);
            searchButton.TabIndex = 9;
            searchButton.Text = "Search";
            searchButton.TextAlign = ContentAlignment.BottomCenter;
            searchButton.TextImageRelation = TextImageRelation.ImageAboveText;
            searchButton.UseVisualStyleBackColor = false;
            // 
            // viewSaleButton
            // 
            viewSaleButton.BackColor = Color.FromArgb(28, 44, 78);
            viewSaleButton.Enabled = false;
            viewSaleButton.FlatAppearance.BorderSize = 0;
            viewSaleButton.FlatStyle = FlatStyle.Flat;
            viewSaleButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            viewSaleButton.ForeColor = Color.FromArgb(243, 239, 245);
            viewSaleButton.Location = new Point(362, 794);
            viewSaleButton.Margin = new Padding(5, 6, 5, 6);
            viewSaleButton.Name = "viewSaleButton";
            viewSaleButton.Size = new Size(320, 70);
            viewSaleButton.TabIndex = 10;
            viewSaleButton.Text = "View Sale Details";
            viewSaleButton.TextImageRelation = TextImageRelation.ImageAboveText;
            viewSaleButton.UseVisualStyleBackColor = false;
            viewSaleButton.Click += viewSaleButton_Click;
            // 
            // listOfSalesLabel
            // 
            listOfSalesLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            listOfSalesLabel.Location = new Point(0, 210);
            listOfSalesLabel.Margin = new Padding(5, 0, 5, 0);
            listOfSalesLabel.Name = "listOfSalesLabel";
            listOfSalesLabel.Size = new Size(1068, 48);
            listOfSalesLabel.TabIndex = 11;
            listOfSalesLabel.Text = "List of Sales";
            listOfSalesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // noSalesMessageLabel
            // 
            noSalesMessageLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            noSalesMessageLabel.Location = new Point(5, 293);
            noSalesMessageLabel.Margin = new Padding(5, 0, 5, 0);
            noSalesMessageLabel.Name = "noSalesMessageLabel";
            noSalesMessageLabel.Size = new Size(1063, 48);
            noSalesMessageLabel.TabIndex = 12;
            noSalesMessageLabel.Text = "There are no sales yet for this store!";
            noSalesMessageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SalesUserControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 211, 177);
            Controls.Add(noSalesMessageLabel);
            Controls.Add(listOfSalesLabel);
            Controls.Add(viewSaleButton);
            Controls.Add(searchButton);
            Controls.Add(toLabel);
            Controls.Add(rangeRadioButton);
            Controls.Add(dateRadioButton);
            Controls.Add(fromLabel);
            Controls.Add(toDateTimePicker);
            Controls.Add(mainDataGridView);
            Controls.Add(rangeComboBox);
            Controls.Add(fromDateTimePicker);
            Margin = new Padding(5);
            Name = "SalesUserControl";
            Size = new Size(1068, 902);
            Load += SalesUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)mainDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker fromDateTimePicker;
        private ComboBox rangeComboBox;
        private DataGridView mainDataGridView;
        private DateTimePicker toDateTimePicker;
        private Label fromLabel;
        private RadioButton dateRadioButton;
        private RadioButton rangeRadioButton;
        private Label toLabel;
        private Button searchButton;
        private Button viewSaleButton;
        private Label listOfSalesLabel;
        private Label noSalesMessageLabel;
        private DataGridViewTextBoxColumn saleId;
        private DataGridViewTextBoxColumn saleDateTime;
        private DataGridViewTextBoxColumn saleTotal;
        private DataGridViewTextBoxColumn saleTax;
        private DataGridViewTextBoxColumn paymentType;
    }
}
