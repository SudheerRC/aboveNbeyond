namespace MyStores.UserControls
{
    partial class OrderUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderUserControl));
            placeOrderButton = new Button();
            receiveOrderButton = new Button();
            mainPanel = new Panel();
            listPanel = new Panel();
            vendorComboBox = new ComboBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            listPanel.SuspendLayout();
            SuspendLayout();
            // 
            // placeOrderButton
            // 
            placeOrderButton.BackColor = Color.FromArgb(28, 44, 78);
            placeOrderButton.FlatAppearance.BorderSize = 0;
            placeOrderButton.FlatStyle = FlatStyle.Flat;
            placeOrderButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            placeOrderButton.ForeColor = Color.White;
            placeOrderButton.Image = (Image)resources.GetObject("placeOrderButton.Image");
            placeOrderButton.Location = new Point(210, 160);
            placeOrderButton.Margin = new Padding(3, 4, 3, 4);
            placeOrderButton.Name = "placeOrderButton";
            placeOrderButton.Padding = new Padding(7, 8, 7, 8);
            placeOrderButton.Size = new Size(171, 227);
            placeOrderButton.TabIndex = 3;
            placeOrderButton.Text = "Place new Order";
            placeOrderButton.TextAlign = ContentAlignment.BottomCenter;
            placeOrderButton.TextImageRelation = TextImageRelation.ImageAboveText;
            placeOrderButton.UseVisualStyleBackColor = false;
            placeOrderButton.Visible = false;
            // 
            // receiveOrderButton
            // 
            receiveOrderButton.BackColor = Color.FromArgb(28, 44, 78);
            receiveOrderButton.FlatAppearance.BorderSize = 0;
            receiveOrderButton.FlatStyle = FlatStyle.Flat;
            receiveOrderButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            receiveOrderButton.ForeColor = Color.White;
            receiveOrderButton.Image = (Image)resources.GetObject("receiveOrderButton.Image");
            receiveOrderButton.Location = new Point(569, 160);
            receiveOrderButton.Margin = new Padding(3, 4, 3, 4);
            receiveOrderButton.Name = "receiveOrderButton";
            receiveOrderButton.Padding = new Padding(7, 8, 7, 8);
            receiveOrderButton.Size = new Size(171, 227);
            receiveOrderButton.TabIndex = 4;
            receiveOrderButton.Text = "Receive an Order";
            receiveOrderButton.TextAlign = ContentAlignment.BottomCenter;
            receiveOrderButton.TextImageRelation = TextImageRelation.ImageAboveText;
            receiveOrderButton.UseVisualStyleBackColor = false;
            receiveOrderButton.Visible = false;
            // 
            // mainPanel
            // 
            mainPanel.Location = new Point(66, 66);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(860, 465);
            mainPanel.TabIndex = 5;
            // 
            // listPanel
            // 
            listPanel.Controls.Add(flowLayoutPanel1);
            listPanel.Controls.Add(vendorComboBox);
            listPanel.Location = new Point(80, 6);
            listPanel.Name = "listPanel";
            listPanel.Size = new Size(833, 602);
            listPanel.TabIndex = 6;
            // 
            // vendorComboBox
            // 
            vendorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            vendorComboBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            vendorComboBox.FormattingEnabled = true;
            vendorComboBox.Location = new Point(255, 43);
            vendorComboBox.Name = "vendorComboBox";
            vendorComboBox.Size = new Size(311, 33);
            vendorComboBox.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(25, 98);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(786, 445);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // OrderUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 211, 177);
            Controls.Add(listPanel);
            Controls.Add(receiveOrderButton);
            Controls.Add(placeOrderButton);
            Controls.Add(mainPanel);
            Name = "OrderUserControl";
            Size = new Size(999, 611);
            listPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button placeOrderButton;
        private Button receiveOrderButton;
        private Panel mainPanel;
        private Panel listPanel;
        private FlowLayoutPanel flowLayoutPanel1;
        private ComboBox vendorComboBox;
    }
}
