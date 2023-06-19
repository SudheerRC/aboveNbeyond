namespace MyStores.UserControls
{
    partial class AddStoreUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStoreUserControl));
            this.storeNameLabel = new System.Windows.Forms.Label();
            this.storeImagePictureBox = new System.Windows.Forms.PictureBox();
            this.openButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.storeImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // storeNameLabel
            // 
            this.storeNameLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.storeNameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.storeNameLabel.ForeColor = System.Drawing.Color.White;
            this.storeNameLabel.Location = new System.Drawing.Point(0, 126);
            this.storeNameLabel.Name = "storeNameLabel";
            this.storeNameLabel.Size = new System.Drawing.Size(160, 74);
            this.storeNameLabel.TabIndex = 2;
            this.storeNameLabel.Text = "Add Store";
            this.storeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // storeImagePictureBox
            // 
            this.storeImagePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("storeImagePictureBox.Image")));
            this.storeImagePictureBox.Location = new System.Drawing.Point(29, 11);
            this.storeImagePictureBox.Name = "storeImagePictureBox";
            this.storeImagePictureBox.Size = new System.Drawing.Size(99, 100);
            this.storeImagePictureBox.TabIndex = 4;
            this.storeImagePictureBox.TabStop = false;
            // 
            // openButton
            // 
            this.openButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openButton.BackColor = System.Drawing.Color.White;
            this.openButton.Location = new System.Drawing.Point(0, 0);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(160, 200);
            this.openButton.TabIndex = 3;
            this.openButton.UseVisualStyleBackColor = false;
            this.openButton.Visible = false;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // AddStoreUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.storeImagePictureBox);
            this.Controls.Add(this.storeNameLabel);
            this.Name = "AddStoreUserControl";
            this.Size = new System.Drawing.Size(160, 200);
            ((System.ComponentModel.ISupportInitialize)(this.storeImagePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Label storeNameLabel;
        private PictureBox storeImagePictureBox;
        private Button openButton;
    }
}
