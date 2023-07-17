namespace MyStores.UserControls
{
    partial class ProductsTabUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsTabUserControl));
            mainAddProductUserControl = new AddProductUserControl();
            vendorInfoPanel = new Panel();
            messageLabel = new Label();
            infoGraphicPictureBox = new PictureBox();
            vendorInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)infoGraphicPictureBox).BeginInit();
            SuspendLayout();
            // 
            // mainAddProductUserControl
            // 
            mainAddProductUserControl.BackColor = Color.FromArgb(227, 211, 177);
            mainAddProductUserControl.Location = new Point(0, 0);
            mainAddProductUserControl.Margin = new Padding(5, 8, 5, 8);
            mainAddProductUserControl.Name = "mainAddProductUserControl";
            mainAddProductUserControl.Size = new Size(1336, 1338);
            mainAddProductUserControl.TabIndex = 0;
            // 
            // vendorInfoPanel
            // 
            vendorInfoPanel.Controls.Add(messageLabel);
            vendorInfoPanel.Controls.Add(infoGraphicPictureBox);
            vendorInfoPanel.Location = new Point(682, 274);
            vendorInfoPanel.Margin = new Padding(5, 6, 5, 6);
            vendorInfoPanel.Name = "vendorInfoPanel";
            vendorInfoPanel.Padding = new Padding(15, 18, 15, 18);
            vendorInfoPanel.Size = new Size(580, 363);
            vendorInfoPanel.TabIndex = 107;
            // 
            // messageLabel
            // 
            messageLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            messageLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            messageLabel.Location = new Point(135, 42);
            messageLabel.Margin = new Padding(5, 0, 5, 0);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(425, 303);
            messageLabel.TabIndex = 13;
            messageLabel.Text = "Info Message";
            // 
            // infoGraphicPictureBox
            // 
            infoGraphicPictureBox.Image = (Image)resources.GetObject("infoGraphicPictureBox.Image");
            infoGraphicPictureBox.Location = new Point(21, 24);
            infoGraphicPictureBox.Margin = new Padding(5, 6, 5, 6);
            infoGraphicPictureBox.Name = "infoGraphicPictureBox";
            infoGraphicPictureBox.Size = new Size(89, 102);
            infoGraphicPictureBox.TabIndex = 0;
            infoGraphicPictureBox.TabStop = false;
            // 
            // ProductsTabUserControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 211, 177);
            Controls.Add(vendorInfoPanel);
            Controls.Add(mainAddProductUserControl);
            Margin = new Padding(5, 6, 5, 6);
            Name = "ProductsTabUserControl";
            Size = new Size(1429, 1338);
            Load += ProductsTabUserControl_Load;
            vendorInfoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)infoGraphicPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private AddProductUserControl mainAddProductUserControl;
        private Panel vendorInfoPanel;
        private Label messageLabel;
        private PictureBox infoGraphicPictureBox;
    }
}
