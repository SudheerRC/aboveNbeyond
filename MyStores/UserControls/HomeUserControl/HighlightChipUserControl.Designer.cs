namespace MyStores.UserControls.HomeUserControl
{
    partial class HighlightChipUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HighlightChipUserControl));
            this.chipPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.highlightNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.highlightChipPictureBox = new System.Windows.Forms.PictureBox();
            this.chipPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.highlightChipPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // chipPanel
            // 
            this.chipPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.chipPanel.Controls.Add(this.highlightChipPictureBox);
            this.chipPanel.Controls.Add(this.panel2);
            this.chipPanel.Location = new System.Drawing.Point(3, 0);
            this.chipPanel.Name = "chipPanel";
            this.chipPanel.Size = new System.Drawing.Size(182, 55);
            this.chipPanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.highlightNameLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(39, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(143, 55);
            this.panel2.TabIndex = 0;
            // 
            // highlightNameLabel
            // 
            this.highlightNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.highlightNameLabel.ForeColor = System.Drawing.Color.White;
            this.highlightNameLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.highlightNameLabel.Location = new System.Drawing.Point(0, 0);
            this.highlightNameLabel.Name = "highlightNameLabel";
            this.highlightNameLabel.Size = new System.Drawing.Size(143, 23);
            this.highlightNameLabel.TabIndex = 0;
            this.highlightNameLabel.Text = "Total Sales";
            this.highlightNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "$ 4,082.96";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // highlightChipPictureBox
            // 
            this.highlightChipPictureBox.BackColor = System.Drawing.Color.White;
            this.highlightChipPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("highlightChipPictureBox.Image")));
            this.highlightChipPictureBox.Location = new System.Drawing.Point(3, 3);
            this.highlightChipPictureBox.Name = "highlightChipPictureBox";
            this.highlightChipPictureBox.Size = new System.Drawing.Size(48, 48);
            this.highlightChipPictureBox.TabIndex = 1;
            this.highlightChipPictureBox.TabStop = false;
            // 
            // HighlightChipUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.chipPanel);
            this.Name = "HighlightChipUserControl";
            this.Size = new System.Drawing.Size(185, 58);
            this.Load += new System.EventHandler(this.HighlightChipUserControl_Load);
            this.chipPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.highlightChipPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel chipPanel;
        private PictureBox highlightChipPictureBox;
        private Panel panel2;
        private Label label1;
        private Label highlightNameLabel;
    }
}
