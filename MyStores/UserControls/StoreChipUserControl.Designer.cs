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
            this.openButton = new System.Windows.Forms.Button();
            this.storeImagePictureBox = new System.Windows.Forms.PictureBox();
            this.storeNameLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.managerPanel = new System.Windows.Forms.Panel();
            this.managerNameLabel = new System.Windows.Forms.Label();
            this.managerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.storeImagePictureBox)).BeginInit();
            this.managerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // openButton
            // 
            this.openButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openButton.BackColor = System.Drawing.Color.White;
            this.openButton.Location = new System.Drawing.Point(0, 0);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(160, 200);
            this.openButton.TabIndex = 9;
            this.openButton.UseVisualStyleBackColor = false;
            this.openButton.Visible = false;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // storeImagePictureBox
            // 
            this.storeImagePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("storeImagePictureBox.Image")));
            this.storeImagePictureBox.Location = new System.Drawing.Point(29, 11);
            this.storeImagePictureBox.Name = "storeImagePictureBox";
            this.storeImagePictureBox.Size = new System.Drawing.Size(99, 100);
            this.storeImagePictureBox.TabIndex = 10;
            this.storeImagePictureBox.TabStop = false;
            // 
            // storeNameLabel
            // 
            this.storeNameLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.storeNameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.storeNameLabel.ForeColor = System.Drawing.Color.White;
            this.storeNameLabel.Location = new System.Drawing.Point(0, 118);
            this.storeNameLabel.Name = "storeNameLabel";
            this.storeNameLabel.Size = new System.Drawing.Size(160, 36);
            this.storeNameLabel.TabIndex = 8;
            this.storeNameLabel.Text = "Store Name";
            this.storeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cityLabel
            // 
            this.cityLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cityLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cityLabel.ForeColor = System.Drawing.Color.White;
            this.cityLabel.Location = new System.Drawing.Point(0, 154);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(160, 24);
            this.cityLabel.TabIndex = 7;
            this.cityLabel.Text = "city";
            this.cityLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // managerPanel
            // 
            this.managerPanel.Controls.Add(this.managerNameLabel);
            this.managerPanel.Controls.Add(this.managerLabel);
            this.managerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.managerPanel.Location = new System.Drawing.Point(0, 178);
            this.managerPanel.Name = "managerPanel";
            this.managerPanel.Size = new System.Drawing.Size(160, 22);
            this.managerPanel.TabIndex = 11;
            // 
            // managerNameLabel
            // 
            this.managerNameLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.managerNameLabel.ForeColor = System.Drawing.Color.White;
            this.managerNameLabel.Location = new System.Drawing.Point(57, 0);
            this.managerNameLabel.Name = "managerNameLabel";
            this.managerNameLabel.Size = new System.Drawing.Size(103, 22);
            this.managerNameLabel.TabIndex = 8;
            this.managerNameLabel.Text = "Name";
            this.managerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // managerLabel
            // 
            this.managerLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.managerLabel.ForeColor = System.Drawing.Color.White;
            this.managerLabel.Location = new System.Drawing.Point(0, 0);
            this.managerLabel.Name = "managerLabel";
            this.managerLabel.Size = new System.Drawing.Size(63, 22);
            this.managerLabel.TabIndex = 7;
            this.managerLabel.Text = "Manager : ";
            this.managerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StoreChipUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.storeImagePictureBox);
            this.Controls.Add(this.storeNameLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.managerPanel);
            this.Name = "StoreChipUserControl";
            this.Size = new System.Drawing.Size(160, 200);
            ((System.ComponentModel.ISupportInitialize)(this.storeImagePictureBox)).EndInit();
            this.managerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button openButton;
        private PictureBox storeImagePictureBox;
        private Label storeNameLabel;
        private Label cityLabel;
        private Panel managerPanel;
        private Label managerNameLabel;
        private Label managerLabel;
    }
}
