namespace MyStores.UserControls
{
    partial class StoreChipUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreChipUserControl));
            storeImagePictureBox = new PictureBox();
            storeNameLabel = new Label();
            cityLabel = new Label();
            managerPanel = new Panel();
            managerNameLabel = new Label();
            managerLabel = new Label();
            idLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)storeImagePictureBox).BeginInit();
            managerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // storeImagePictureBox
            // 
            storeImagePictureBox.Image = (Image)resources.GetObject("storeImagePictureBox.Image");
            storeImagePictureBox.Location = new Point(29, 11);
            storeImagePictureBox.Name = "storeImagePictureBox";
            storeImagePictureBox.Size = new Size(99, 100);
            storeImagePictureBox.TabIndex = 10;
            storeImagePictureBox.TabStop = false;
            storeImagePictureBox.Click += storeImagePictureBox_Click;
            // 
            // storeNameLabel
            // 
            storeNameLabel.Dock = DockStyle.Bottom;
            storeNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            storeNameLabel.ForeColor = Color.White;
            storeNameLabel.Location = new Point(0, 118);
            storeNameLabel.Name = "storeNameLabel";
            storeNameLabel.Size = new Size(160, 36);
            storeNameLabel.TabIndex = 8;
            storeNameLabel.Text = "Store Name";
            storeNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            storeNameLabel.Click += storeNameLabel_Click;
            // 
            // cityLabel
            // 
            cityLabel.Dock = DockStyle.Bottom;
            cityLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cityLabel.ForeColor = Color.White;
            cityLabel.Location = new Point(0, 154);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(160, 24);
            cityLabel.TabIndex = 7;
            cityLabel.Text = "city";
            cityLabel.TextAlign = ContentAlignment.TopCenter;
            cityLabel.Click += cityLabel_Click;
            // 
            // managerPanel
            // 
            managerPanel.Controls.Add(managerNameLabel);
            managerPanel.Controls.Add(managerLabel);
            managerPanel.Dock = DockStyle.Bottom;
            managerPanel.Location = new Point(0, 178);
            managerPanel.Name = "managerPanel";
            managerPanel.Size = new Size(160, 22);
            managerPanel.TabIndex = 11;
            // 
            // managerNameLabel
            // 
            managerNameLabel.Dock = DockStyle.Right;
            managerNameLabel.ForeColor = Color.White;
            managerNameLabel.Location = new Point(57, 0);
            managerNameLabel.Name = "managerNameLabel";
            managerNameLabel.Size = new Size(103, 22);
            managerNameLabel.TabIndex = 8;
            managerNameLabel.Text = "Name";
            managerNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            managerNameLabel.Click += managerNameLabel_Click;
            // 
            // managerLabel
            // 
            managerLabel.Dock = DockStyle.Left;
            managerLabel.ForeColor = Color.White;
            managerLabel.Location = new Point(0, 0);
            managerLabel.Name = "managerLabel";
            managerLabel.Size = new Size(63, 22);
            managerLabel.TabIndex = 7;
            managerLabel.Text = "Manager : ";
            managerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // idLabel
            // 
            idLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            idLabel.ForeColor = Color.White;
            idLabel.Location = new Point(134, 99);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(26, 19);
            idLabel.TabIndex = 12;
            idLabel.TextAlign = ContentAlignment.TopCenter;
            idLabel.Visible = false;
            // 
            // StoreChipUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 44, 78);
            Controls.Add(idLabel);
            Controls.Add(storeImagePictureBox);
            Controls.Add(storeNameLabel);
            Controls.Add(cityLabel);
            Controls.Add(managerPanel);
            Name = "StoreChipUserControl";
            Size = new Size(160, 200);
            Load += StoreChipUserControl_Load;
            Click += StoreChipUserControl_Click;
            MouseEnter += StoreChipUserControl_MouseEnter;
            MouseLeave += StoreChipUserControl_MouseLeave;
            ((System.ComponentModel.ISupportInitialize)storeImagePictureBox).EndInit();
            managerPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox storeImagePictureBox;
        private Label storeNameLabel;
        private Label cityLabel;
        private Panel managerPanel;
        private Label managerNameLabel;
        private Label managerLabel;
        private Label idLabel;
    }
}
