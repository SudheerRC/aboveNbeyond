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
            dataGridView1 = new DataGridView();
            toDateTimePicker = new DateTimePicker();
            fromLabel = new Label();
            dateRadioButton = new RadioButton();
            rangeRadioButton = new RadioButton();
            toLabel = new Label();
            searchButton = new Button();
            button1 = new Button();
            listOfSalesLabel = new Label();
            noSalesMessageLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // fromDateTimePicker
            // 
            fromDateTimePicker.Format = DateTimePickerFormat.Short;
            fromDateTimePicker.Location = new Point(109, 59);
            fromDateTimePicker.Name = "fromDateTimePicker";
            fromDateTimePicker.Size = new Size(125, 27);
            fromDateTimePicker.TabIndex = 0;
            // 
            // rangeComboBox
            // 
            rangeComboBox.FormattingEnabled = true;
            rangeComboBox.Location = new Point(280, 58);
            rangeComboBox.Name = "rangeComboBox";
            rangeComboBox.Size = new Size(151, 28);
            rangeComboBox.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 204);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(550, 306);
            dataGridView1.TabIndex = 3;
            // 
            // toDateTimePicker
            // 
            toDateTimePicker.Format = DateTimePickerFormat.Short;
            toDateTimePicker.Location = new Point(109, 102);
            toDateTimePicker.Name = "toDateTimePicker";
            toDateTimePicker.Size = new Size(125, 27);
            toDateTimePicker.TabIndex = 4;
            // 
            // fromLabel
            // 
            fromLabel.AutoSize = true;
            fromLabel.Location = new Point(42, 64);
            fromLabel.Name = "fromLabel";
            fromLabel.Size = new Size(43, 20);
            fromLabel.TabIndex = 5;
            fromLabel.Text = "From";
            // 
            // dateRadioButton
            // 
            dateRadioButton.AutoSize = true;
            dateRadioButton.Location = new Point(109, 20);
            dateRadioButton.Name = "dateRadioButton";
            dateRadioButton.Size = new Size(130, 24);
            dateRadioButton.TabIndex = 6;
            dateRadioButton.TabStop = true;
            dateRadioButton.Text = "Search by Date";
            dateRadioButton.UseVisualStyleBackColor = true;
            // 
            // rangeRadioButton
            // 
            rangeRadioButton.AutoSize = true;
            rangeRadioButton.Location = new Point(280, 20);
            rangeRadioButton.Name = "rangeRadioButton";
            rangeRadioButton.Size = new Size(140, 24);
            rangeRadioButton.TabIndex = 7;
            rangeRadioButton.TabStop = true;
            rangeRadioButton.Text = "Search by Range";
            rangeRadioButton.UseVisualStyleBackColor = true;
            // 
            // toLabel
            // 
            toLabel.AutoSize = true;
            toLabel.Location = new Point(42, 109);
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
            searchButton.Location = new Point(491, 58);
            searchButton.Margin = new Padding(3, 4, 3, 4);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(80, 71);
            searchButton.TabIndex = 9;
            searchButton.Text = "Search";
            searchButton.TextAlign = ContentAlignment.BottomCenter;
            searchButton.TextImageRelation = TextImageRelation.ImageAboveText;
            searchButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(28, 44, 78);
            button1.Enabled = false;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(243, 239, 245);
            button1.Location = new Point(201, 526);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(197, 44);
            button1.TabIndex = 10;
            button1.Text = "View Sale Details";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            // 
            // listOfSalesLabel
            // 
            listOfSalesLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            listOfSalesLabel.Location = new Point(0, 161);
            listOfSalesLabel.Name = "listOfSalesLabel";
            listOfSalesLabel.Size = new Size(615, 30);
            listOfSalesLabel.TabIndex = 11;
            listOfSalesLabel.Text = "List of Sales";
            listOfSalesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // noSalesMessageLabel
            // 
            noSalesMessageLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            noSalesMessageLabel.Location = new Point(3, 213);
            noSalesMessageLabel.Name = "noSalesMessageLabel";
            noSalesMessageLabel.Size = new Size(612, 30);
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
            Controls.Add(button1);
            Controls.Add(searchButton);
            Controls.Add(toLabel);
            Controls.Add(rangeRadioButton);
            Controls.Add(dateRadioButton);
            Controls.Add(fromLabel);
            Controls.Add(toDateTimePicker);
            Controls.Add(dataGridView1);
            Controls.Add(rangeComboBox);
            Controls.Add(fromDateTimePicker);
            Name = "SalesUserControl";
            Size = new Size(615, 593);
            Load += SalesUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker fromDateTimePicker;
        private ComboBox rangeComboBox;
        private DataGridView dataGridView1;
        private DateTimePicker toDateTimePicker;
        private Label fromLabel;
        private RadioButton dateRadioButton;
        private RadioButton rangeRadioButton;
        private Label toLabel;
        private Button searchButton;
        private Button button1;
        private Label listOfSalesLabel;
        private Label noSalesMessageLabel;
    }
}
