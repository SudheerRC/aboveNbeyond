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
            fromDateTimePicker.Enabled = false;
            fromDateTimePicker.Format = DateTimePickerFormat.Short;
            fromDateTimePicker.Location = new Point(109, 48);
            fromDateTimePicker.Name = "fromDateTimePicker";
            fromDateTimePicker.Size = new Size(125, 27);
            fromDateTimePicker.TabIndex = 0;
            fromDateTimePicker.ValueChanged += FromDateTimePicker_ValueChanged;
            // 
            // rangeComboBox
            // 
            rangeComboBox.Enabled = false;
            rangeComboBox.FormattingEnabled = true;
            rangeComboBox.Location = new Point(310, 47);
            rangeComboBox.Name = "rangeComboBox";
            rangeComboBox.Size = new Size(151, 28);
            rangeComboBox.TabIndex = 2;
            // 
            // mainDataGridView
            // 
            mainDataGridView.AllowUserToAddRows = false;
            mainDataGridView.AllowUserToDeleteRows = false;
            mainDataGridView.BackgroundColor = SystemColors.ControlLightLight;
            mainDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mainDataGridView.Columns.AddRange(new DataGridViewColumn[] { saleId, saleDateTime, saleTotal, saleTax, paymentType });
            mainDataGridView.Location = new Point(25, 174);
            mainDataGridView.MultiSelect = false;
            mainDataGridView.Name = "mainDataGridView";
            mainDataGridView.ReadOnly = true;
            mainDataGridView.RowHeadersWidth = 51;
            mainDataGridView.RowTemplate.Height = 29;
            mainDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            mainDataGridView.Size = new Size(610, 306);
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
            toDateTimePicker.Enabled = false;
            toDateTimePicker.Format = DateTimePickerFormat.Short;
            toDateTimePicker.Location = new Point(109, 91);
            toDateTimePicker.Name = "toDateTimePicker";
            toDateTimePicker.Size = new Size(125, 27);
            toDateTimePicker.TabIndex = 4;
            // 
            // fromLabel
            // 
            fromLabel.AutoSize = true;
            fromLabel.Location = new Point(42, 53);
            fromLabel.Name = "fromLabel";
            fromLabel.Size = new Size(43, 20);
            fromLabel.TabIndex = 5;
            fromLabel.Text = "From";
            // 
            // dateRadioButton
            // 
            dateRadioButton.AutoSize = true;
            dateRadioButton.Location = new Point(109, 9);
            dateRadioButton.Name = "dateRadioButton";
            dateRadioButton.Size = new Size(130, 24);
            dateRadioButton.TabIndex = 6;
            dateRadioButton.TabStop = true;
            dateRadioButton.Text = "Search by Date";
            dateRadioButton.UseVisualStyleBackColor = true;
            dateRadioButton.CheckedChanged += dateRadioButton_CheckedChanged;
            // 
            // rangeRadioButton
            // 
            rangeRadioButton.AutoSize = true;
            rangeRadioButton.Location = new Point(310, 9);
            rangeRadioButton.Name = "rangeRadioButton";
            rangeRadioButton.Size = new Size(140, 24);
            rangeRadioButton.TabIndex = 7;
            rangeRadioButton.TabStop = true;
            rangeRadioButton.Text = "Search by Range";
            rangeRadioButton.UseVisualStyleBackColor = true;
            rangeRadioButton.CheckedChanged += rangeRadioButton_CheckedChanged;
            // 
            // toLabel
            // 
            toLabel.AutoSize = true;
            toLabel.Location = new Point(42, 98);
            toLabel.Name = "toLabel";
            toLabel.Size = new Size(25, 20);
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
            searchButton.Location = new Point(555, 48);
            searchButton.Margin = new Padding(3, 4, 3, 4);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(80, 71);
            searchButton.TabIndex = 9;
            searchButton.Text = "Search";
            searchButton.TextAlign = ContentAlignment.BottomCenter;
            searchButton.TextImageRelation = TextImageRelation.ImageAboveText;
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // viewSaleButton
            // 
            viewSaleButton.BackColor = Color.FromArgb(28, 44, 78);
            viewSaleButton.Enabled = false;
            viewSaleButton.FlatAppearance.BorderSize = 0;
            viewSaleButton.FlatStyle = FlatStyle.Flat;
            viewSaleButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            viewSaleButton.ForeColor = Color.FromArgb(243, 239, 245);
            viewSaleButton.Location = new Point(223, 496);
            viewSaleButton.Margin = new Padding(3, 4, 3, 4);
            viewSaleButton.Name = "viewSaleButton";
            viewSaleButton.Size = new Size(197, 44);
            viewSaleButton.TabIndex = 10;
            viewSaleButton.Text = "View Sale Details";
            viewSaleButton.TextImageRelation = TextImageRelation.ImageAboveText;
            viewSaleButton.UseVisualStyleBackColor = false;
            viewSaleButton.Click += viewSaleButton_Click;
            // 
            // listOfSalesLabel
            // 
            listOfSalesLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            listOfSalesLabel.Location = new Point(0, 131);
            listOfSalesLabel.Name = "listOfSalesLabel";
            listOfSalesLabel.Size = new Size(657, 30);
            listOfSalesLabel.TabIndex = 11;
            listOfSalesLabel.Text = "List of Sales";
            listOfSalesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // noSalesMessageLabel
            // 
            noSalesMessageLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            noSalesMessageLabel.Location = new Point(3, 183);
            noSalesMessageLabel.Name = "noSalesMessageLabel";
            noSalesMessageLabel.Size = new Size(654, 30);
            noSalesMessageLabel.TabIndex = 12;
            noSalesMessageLabel.Text = "There are no sales yet for this store!";
            noSalesMessageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SalesUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
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
            Name = "SalesUserControl";
            Size = new Size(657, 564);
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
