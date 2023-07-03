namespace MyStores.UserControls
{
    partial class GlobalSearchUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlobalSearchUserControl));
            invisibleGroupBox = new GroupBox();
            invisibleLabel = new Label();
            invisibleLinkLabel = new LinkLabel();
            searchInputPanel = new Panel();
            searchButtonPanel = new Panel();
            searchButton = new Button();
            searchTextBox = new TextBox();
            resultFlowLayoutPanel = new FlowLayoutPanel();
            invisibleGroupBox.SuspendLayout();
            searchInputPanel.SuspendLayout();
            searchButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // invisibleGroupBox
            // 
            invisibleGroupBox.BackColor = Color.FromArgb(79, 101, 148);
            invisibleGroupBox.Controls.Add(invisibleLabel);
            invisibleGroupBox.Controls.Add(invisibleLinkLabel);
            invisibleGroupBox.Font = new Font("Segoe UI", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            invisibleGroupBox.ForeColor = SystemColors.ControlLightLight;
            invisibleGroupBox.Location = new Point(3, 58);
            invisibleGroupBox.Name = "invisibleGroupBox";
            invisibleGroupBox.Size = new Size(362, 136);
            invisibleGroupBox.TabIndex = 0;
            invisibleGroupBox.TabStop = false;
            invisibleGroupBox.Text = "groupBox1";
            invisibleGroupBox.Visible = false;
            // 
            // invisibleLabel
            // 
            invisibleLabel.AutoSize = true;
            invisibleLabel.Location = new Point(24, 92);
            invisibleLabel.Name = "invisibleLabel";
            invisibleLabel.Size = new Size(68, 30);
            invisibleLabel.TabIndex = 1;
            invisibleLabel.Text = "label1";
            invisibleLabel.Visible = false;
            // 
            // invisibleLinkLabel
            // 
            invisibleLinkLabel.AutoSize = true;
            invisibleLinkLabel.DisabledLinkColor = Color.White;
            invisibleLinkLabel.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            invisibleLinkLabel.LinkColor = Color.White;
            invisibleLinkLabel.Location = new Point(24, 40);
            invisibleLinkLabel.Name = "invisibleLinkLabel";
            invisibleLinkLabel.Size = new Size(136, 37);
            invisibleLinkLabel.TabIndex = 0;
            invisibleLinkLabel.TabStop = true;
            invisibleLinkLabel.Text = "linkLabel1";
            invisibleLinkLabel.Visible = false;
            invisibleLinkLabel.VisitedLinkColor = Color.Red;
            // 
            // searchInputPanel
            // 
            searchInputPanel.Controls.Add(searchButtonPanel);
            searchInputPanel.Controls.Add(searchTextBox);
            searchInputPanel.Dock = DockStyle.Top;
            searchInputPanel.Location = new Point(0, 0);
            searchInputPanel.Margin = new Padding(3, 2, 3, 2);
            searchInputPanel.Name = "searchInputPanel";
            searchInputPanel.Size = new Size(368, 51);
            searchInputPanel.TabIndex = 0;
            // 
            // searchButtonPanel
            // 
            searchButtonPanel.Controls.Add(searchButton);
            searchButtonPanel.Location = new Point(300, 3);
            searchButtonPanel.Margin = new Padding(3, 2, 3, 2);
            searchButtonPanel.Name = "searchButtonPanel";
            searchButtonPanel.Size = new Size(65, 46);
            searchButtonPanel.TabIndex = 0;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.White;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Image = (Image)resources.GetObject("searchButton.Image");
            searchButton.Location = new Point(-7, 5);
            searchButton.Margin = new Padding(8, 6, 8, 6);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(72, 40);
            searchButton.TabIndex = 0;
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += SearchButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.BorderStyle = BorderStyle.FixedSingle;
            searchTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchTextBox.Location = new Point(3, 8);
            searchTextBox.Margin = new Padding(3, 2, 3, 2);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "Search";
            searchTextBox.Size = new Size(291, 39);
            searchTextBox.TabIndex = 6;
            // 
            // resultFlowLayoutPanel
            // 
            resultFlowLayoutPanel.AutoScroll = true;
            resultFlowLayoutPanel.Dock = DockStyle.Bottom;
            resultFlowLayoutPanel.Location = new Point(0, 57);
            resultFlowLayoutPanel.Name = "resultFlowLayoutPanel";
            resultFlowLayoutPanel.Size = new Size(368, 1023);
            resultFlowLayoutPanel.TabIndex = 1;
            // 
            // GlobalSearchUserControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 44, 78);
            Controls.Add(invisibleGroupBox);
            Controls.Add(searchInputPanel);
            Controls.Add(resultFlowLayoutPanel);
            Name = "GlobalSearchUserControl";
            Size = new Size(368, 1080);
            Load += GlobalSearchUserControl_Load;
            invisibleGroupBox.ResumeLayout(false);
            invisibleGroupBox.PerformLayout();
            searchInputPanel.ResumeLayout(false);
            searchInputPanel.PerformLayout();
            searchButtonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel searchInputPanel;
        private TextBox searchTextBox;
        private Panel searchButtonPanel;
        private Button searchButton;
        private GroupBox invisibleGroupBox;
        private LinkLabel invisibleLinkLabel;
        private Label invisibleLabel;
        private FlowLayoutPanel resultFlowLayoutPanel;
    }
}
