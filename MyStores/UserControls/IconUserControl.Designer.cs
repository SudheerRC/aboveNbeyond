namespace MyStores.UserControls
{
    partial class IconUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IconUserControl));
            this.iconLabel = new System.Windows.Forms.Label();
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // iconLabel
            // 
            this.iconLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.iconLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.iconLabel.Location = new System.Drawing.Point(0, 85);
            this.iconLabel.Name = "iconLabel";
            this.iconLabel.Size = new System.Drawing.Size(97, 24);
            this.iconLabel.TabIndex = 1;
            this.iconLabel.Text = "Name";
            this.iconLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconPictureBox
            // 
            this.iconPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.iconPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("iconPictureBox.Image")));
            this.iconPictureBox.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox.Name = "iconPictureBox";
            this.iconPictureBox.Size = new System.Drawing.Size(97, 82);
            this.iconPictureBox.TabIndex = 2;
            this.iconPictureBox.TabStop = false;
            this.iconPictureBox.MouseEnter += new System.EventHandler(this.iconPictureBox_MouseEnter);
            this.iconPictureBox.MouseLeave += new System.EventHandler(this.iconPictureBox_MouseLeave);
            // 
            // IconUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iconPictureBox);
            this.Controls.Add(this.iconLabel);
            this.Name = "IconUserControl";
            this.Size = new System.Drawing.Size(97, 109);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Label iconLabel;
        private PictureBox iconPictureBox;
    }
}
