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
            chipPanel = new Panel();
            highlightChipPictureBox = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            highlightNameLabel = new Label();
            chipPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)highlightChipPictureBox).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // chipPanel
            // 
            chipPanel.BackColor = Color.FromArgb(28, 44, 78);
            chipPanel.Controls.Add(highlightChipPictureBox);
            chipPanel.Controls.Add(panel2);
            chipPanel.Location = new Point(3, 0);
            chipPanel.Margin = new Padding(3, 4, 3, 4);
            chipPanel.Name = "chipPanel";
            chipPanel.Size = new Size(208, 73);
            chipPanel.TabIndex = 0;
            // 
            // highlightChipPictureBox
            // 
            highlightChipPictureBox.BackColor = Color.White;
            highlightChipPictureBox.Image = (Image)resources.GetObject("highlightChipPictureBox.Image");
            highlightChipPictureBox.Location = new Point(3, 4);
            highlightChipPictureBox.Margin = new Padding(3, 4, 3, 4);
            highlightChipPictureBox.Name = "highlightChipPictureBox";
            highlightChipPictureBox.Size = new Size(55, 64);
            highlightChipPictureBox.TabIndex = 1;
            highlightChipPictureBox.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(highlightNameLabel);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(45, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(163, 73);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 30);
            label1.Name = "label1";
            label1.Size = new Size(163, 43);
            label1.TabIndex = 1;
            label1.Text = "$ 4,082.96";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // highlightNameLabel
            // 
            highlightNameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            highlightNameLabel.ForeColor = Color.White;
            highlightNameLabel.ImageAlign = ContentAlignment.BottomLeft;
            highlightNameLabel.Location = new Point(0, 0);
            highlightNameLabel.Name = "highlightNameLabel";
            highlightNameLabel.Size = new Size(163, 31);
            highlightNameLabel.TabIndex = 0;
            highlightNameLabel.Text = "Total Sales";
            highlightNameLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // HighlightChipUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            Controls.Add(chipPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "HighlightChipUserControl";
            Size = new Size(211, 77);
            Load += HighlightChipUserControl_Load;
            chipPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)highlightChipPictureBox).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel chipPanel;
        private PictureBox highlightChipPictureBox;
        private Panel panel2;
        private Label label1;
        private Label highlightNameLabel;
    }
}
