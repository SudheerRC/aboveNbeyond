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
            this.placeOrderButton = new System.Windows.Forms.Button();
            this.receiveOrderButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.listPanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.panelHeadingLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.finalListPanelButton = new System.Windows.Forms.Button();
            this.totalAmountLabel = new System.Windows.Forms.Label();
            this.mainFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.listPanelComboBox = new System.Windows.Forms.ComboBox();
            this.mainPanel.SuspendLayout();
            this.listPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // placeOrderButton
            // 
            this.placeOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.placeOrderButton.FlatAppearance.BorderSize = 0;
            this.placeOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.placeOrderButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.placeOrderButton.ForeColor = System.Drawing.Color.White;
            this.placeOrderButton.Image = ((System.Drawing.Image)(resources.GetObject("placeOrderButton.Image")));
            this.placeOrderButton.Location = new System.Drawing.Point(73, 62);
            this.placeOrderButton.Name = "placeOrderButton";
            this.placeOrderButton.Padding = new System.Windows.Forms.Padding(6);
            this.placeOrderButton.Size = new System.Drawing.Size(150, 170);
            this.placeOrderButton.TabIndex = 3;
            this.placeOrderButton.Text = "Place new Order";
            this.placeOrderButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.placeOrderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.placeOrderButton.UseVisualStyleBackColor = false;
            this.placeOrderButton.Visible = false;
            this.placeOrderButton.Click += new System.EventHandler(this.placeOrderButton_Click);
            // 
            // receiveOrderButton
            // 
            this.receiveOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.receiveOrderButton.FlatAppearance.BorderSize = 0;
            this.receiveOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receiveOrderButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.receiveOrderButton.ForeColor = System.Drawing.Color.White;
            this.receiveOrderButton.Image = ((System.Drawing.Image)(resources.GetObject("receiveOrderButton.Image")));
            this.receiveOrderButton.Location = new System.Drawing.Point(395, 62);
            this.receiveOrderButton.Name = "receiveOrderButton";
            this.receiveOrderButton.Padding = new System.Windows.Forms.Padding(6);
            this.receiveOrderButton.Size = new System.Drawing.Size(150, 170);
            this.receiveOrderButton.TabIndex = 4;
            this.receiveOrderButton.Text = "Receive an Order";
            this.receiveOrderButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.receiveOrderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.receiveOrderButton.UseVisualStyleBackColor = false;
            this.receiveOrderButton.Visible = false;
            this.receiveOrderButton.Click += new System.EventHandler(this.receiveOrderButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.receiveOrderButton);
            this.mainPanel.Controls.Add(this.placeOrderButton);
            this.mainPanel.Location = new System.Drawing.Point(11, 34);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(640, 302);
            this.mainPanel.TabIndex = 5;
            // 
            // listPanel
            // 
            this.listPanel.Controls.Add(this.backButton);
            this.listPanel.Controls.Add(this.panelHeadingLabel);
            this.listPanel.Controls.Add(this.totalLabel);
            this.listPanel.Controls.Add(this.finalListPanelButton);
            this.listPanel.Controls.Add(this.totalAmountLabel);
            this.listPanel.Controls.Add(this.mainFlowLayoutPanel);
            this.listPanel.Controls.Add(this.listPanelComboBox);
            this.listPanel.Location = new System.Drawing.Point(3, 2);
            this.listPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(644, 452);
            this.listPanel.TabIndex = 6;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(32, 412);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(115, 40);
            this.backButton.TabIndex = 19;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // panelHeadingLabel
            // 
            this.panelHeadingLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panelHeadingLabel.Location = new System.Drawing.Point(3, 0);
            this.panelHeadingLabel.Name = "panelHeadingLabel";
            this.panelHeadingLabel.Size = new System.Drawing.Size(648, 30);
            this.panelHeadingLabel.TabIndex = 18;
            this.panelHeadingLabel.Text = "Please select a Vendor from this list to place an order";
            this.panelHeadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalLabel
            // 
            this.totalLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalLabel.Location = new System.Drawing.Point(220, 416);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(65, 37);
            this.totalLabel.TabIndex = 17;
            this.totalLabel.Text = "Total:";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // finalListPanelButton
            // 
            this.finalListPanelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.finalListPanelButton.FlatAppearance.BorderSize = 0;
            this.finalListPanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finalListPanelButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.finalListPanelButton.ForeColor = System.Drawing.Color.White;
            this.finalListPanelButton.Location = new System.Drawing.Point(444, 412);
            this.finalListPanelButton.Name = "finalListPanelButton";
            this.finalListPanelButton.Size = new System.Drawing.Size(159, 40);
            this.finalListPanelButton.TabIndex = 16;
            this.finalListPanelButton.Text = "Place Order";
            this.finalListPanelButton.UseVisualStyleBackColor = false;
            this.finalListPanelButton.Click += new System.EventHandler(this.finalListPanelButton_Click);
            // 
            // totalAmountLabel
            // 
            this.totalAmountLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalAmountLabel.Location = new System.Drawing.Point(290, 411);
            this.totalAmountLabel.Name = "totalAmountLabel";
            this.totalAmountLabel.Size = new System.Drawing.Size(94, 40);
            this.totalAmountLabel.TabIndex = 2;
            this.totalAmountLabel.Text = "$0.00";
            this.totalAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainFlowLayoutPanel
            // 
            this.mainFlowLayoutPanel.Location = new System.Drawing.Point(22, 74);
            this.mainFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainFlowLayoutPanel.Name = "mainFlowLayoutPanel";
            this.mainFlowLayoutPanel.Size = new System.Drawing.Size(598, 334);
            this.mainFlowLayoutPanel.TabIndex = 1;
            // 
            // listPanelComboBox
            // 
            this.listPanelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listPanelComboBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listPanelComboBox.FormattingEnabled = true;
            this.listPanelComboBox.Location = new System.Drawing.Point(172, 32);
            this.listPanelComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listPanelComboBox.Name = "listPanelComboBox";
            this.listPanelComboBox.Size = new System.Drawing.Size(273, 27);
            this.listPanelComboBox.TabIndex = 0;
            // 
            // OrderUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.listPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OrderUserControl";
            this.Size = new System.Drawing.Size(654, 458);
            this.Load += new System.EventHandler(this.OrderUserControl_Load);
            this.mainPanel.ResumeLayout(false);
            this.listPanel.ResumeLayout(false);
            this.ResumeLayout(false);

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
