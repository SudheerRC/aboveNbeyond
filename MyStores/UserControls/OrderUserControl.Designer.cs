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
            backButton = new Button();
            panelHeadingLabel = new Label();
            totalLabel = new Label();
            finalListPanelButton = new Button();
            totalAmountLabel = new Label();
            mainFlowLayoutPanel = new FlowLayoutPanel();
            listPanelComboBox = new ComboBox();
            mainPanel.SuspendLayout();
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
            placeOrderButton.Location = new Point(83, 83);
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
            placeOrderButton.Click += placeOrderButton_Click;
            // 
            // receiveOrderButton
            // 
            receiveOrderButton.BackColor = Color.FromArgb(28, 44, 78);
            receiveOrderButton.FlatAppearance.BorderSize = 0;
            receiveOrderButton.FlatStyle = FlatStyle.Flat;
            receiveOrderButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            receiveOrderButton.ForeColor = Color.White;
            receiveOrderButton.Image = (Image)resources.GetObject("receiveOrderButton.Image");
            receiveOrderButton.Location = new Point(451, 83);
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
            receiveOrderButton.Click += receiveOrderButton_Click;
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(receiveOrderButton);
            mainPanel.Controls.Add(placeOrderButton);
            mainPanel.Location = new Point(13, 46);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(732, 403);
            mainPanel.TabIndex = 5;
            // 
            // listPanel
            // 
            listPanel.Controls.Add(backButton);
            listPanel.Controls.Add(panelHeadingLabel);
            listPanel.Controls.Add(totalLabel);
            listPanel.Controls.Add(finalListPanelButton);
            listPanel.Controls.Add(totalAmountLabel);
            listPanel.Controls.Add(mainFlowLayoutPanel);
            listPanel.Controls.Add(listPanelComboBox);
            listPanel.Location = new Point(3, 3);
            listPanel.Name = "listPanel";
            listPanel.Size = new Size(736, 603);
            listPanel.TabIndex = 6;
            // 
            // backButton
            // 
            backButton.BackColor = Color.FromArgb(28, 44, 78);
            backButton.FlatAppearance.BorderSize = 0;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            backButton.ForeColor = Color.White;
            backButton.Location = new Point(37, 549);
            backButton.Margin = new Padding(3, 4, 3, 4);
            backButton.Name = "backButton";
            backButton.Size = new Size(131, 53);
            backButton.TabIndex = 19;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // panelHeadingLabel
            // 
            panelHeadingLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            panelHeadingLabel.Location = new Point(3, 0);
            panelHeadingLabel.Name = "panelHeadingLabel";
            panelHeadingLabel.Size = new Size(741, 40);
            panelHeadingLabel.TabIndex = 18;
            panelHeadingLabel.Text = "Please select a Vendor from this list to place an order";
            panelHeadingLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // totalLabel
            // 
            totalLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            totalLabel.Location = new Point(251, 554);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(74, 49);
            totalLabel.TabIndex = 17;
            totalLabel.Text = "Total:";
            totalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // finalListPanelButton
            // 
            finalListPanelButton.BackColor = Color.FromArgb(28, 44, 78);
            finalListPanelButton.FlatAppearance.BorderSize = 0;
            finalListPanelButton.FlatStyle = FlatStyle.Flat;
            finalListPanelButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            finalListPanelButton.ForeColor = Color.White;
            finalListPanelButton.Location = new Point(508, 549);
            finalListPanelButton.Margin = new Padding(3, 4, 3, 4);
            finalListPanelButton.Name = "finalListPanelButton";
            finalListPanelButton.Size = new Size(182, 53);
            finalListPanelButton.TabIndex = 16;
            finalListPanelButton.Text = "Place Order";
            finalListPanelButton.UseVisualStyleBackColor = false;
            finalListPanelButton.Click += finalListPanelButton_Click;
            // 
            // totalAmountLabel
            // 
            totalAmountLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            totalAmountLabel.Location = new Point(331, 548);
            totalAmountLabel.Name = "totalAmountLabel";
            totalAmountLabel.Size = new Size(107, 53);
            totalAmountLabel.TabIndex = 2;
            totalAmountLabel.Text = "$0.00";
            totalAmountLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // mainFlowLayoutPanel
            // 
            mainFlowLayoutPanel.Location = new Point(25, 99);
            mainFlowLayoutPanel.Name = "mainFlowLayoutPanel";
            mainFlowLayoutPanel.Size = new Size(683, 445);
            mainFlowLayoutPanel.TabIndex = 1;
            // 
            // listPanelComboBox
            // 
            listPanelComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            listPanelComboBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            listPanelComboBox.FormattingEnabled = true;
            listPanelComboBox.Location = new Point(197, 43);
            listPanelComboBox.Name = "listPanelComboBox";
            listPanelComboBox.Size = new Size(311, 33);
            listPanelComboBox.TabIndex = 0;
            // 
            // OrderUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 211, 177);
            Controls.Add(mainPanel);
            Controls.Add(listPanel);
            Name = "OrderUserControl";
            Size = new Size(747, 611);
            mainPanel.ResumeLayout(false);
            listPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button placeOrderButton;
        private Button receiveOrderButton;
        private Panel mainPanel;
        private Panel listPanel;
        private FlowLayoutPanel mainFlowLayoutPanel;
        private ComboBox listPanelComboBox;
        private Label totalAmountLabel;
        private Button finalListPanelButton;
        private Label totalLabel;
        private Label panelHeadingLabel;
        private Button backButton;
    }
}
