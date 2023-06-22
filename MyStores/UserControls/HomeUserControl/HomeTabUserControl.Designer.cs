namespace MyStores.UserControls.HomeUserControl
{
    partial class HomeTabUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeTabUserControl));
            homeFlowLayoutPanel = new FlowLayoutPanel();
            AddStoreButton = new Button();
            mainStoreFrontUserControl = new StoreFrontUserControl();
            homeFlowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // homeFlowLayoutPanel
            // 
            homeFlowLayoutPanel.Controls.Add(AddStoreButton);
            homeFlowLayoutPanel.Location = new Point(0, 0);
            homeFlowLayoutPanel.Margin = new Padding(21, 24, 21, 24);
            homeFlowLayoutPanel.Name = "homeFlowLayoutPanel";
            homeFlowLayoutPanel.Padding = new Padding(21, 24, 21, 24);
            homeFlowLayoutPanel.Size = new Size(1007, 676);
            homeFlowLayoutPanel.TabIndex = 0;
            // 
            // AddStoreButton
            // 
            AddStoreButton.BackColor = Color.FromArgb(28, 44, 78);
            AddStoreButton.FlatAppearance.BorderSize = 0;
            AddStoreButton.FlatStyle = FlatStyle.Flat;
            AddStoreButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            AddStoreButton.ForeColor = Color.White;
            AddStoreButton.Image = (Image)resources.GetObject("AddStoreButton.Image");
            AddStoreButton.Location = new Point(24, 28);
            AddStoreButton.Margin = new Padding(3, 4, 3, 4);
            AddStoreButton.Name = "AddStoreButton";
            AddStoreButton.Padding = new Padding(7, 8, 7, 8);
            AddStoreButton.Size = new Size(150, 170);
            AddStoreButton.TabIndex = 1;
            AddStoreButton.Text = "Add Store";
            AddStoreButton.TextAlign = ContentAlignment.BottomCenter;
            AddStoreButton.TextImageRelation = TextImageRelation.ImageAboveText;
            AddStoreButton.UseVisualStyleBackColor = false;
            AddStoreButton.Click += AddStoreButton_Click;
            // 
            // mainStoreFrontUserControl
            // 
            mainStoreFrontUserControl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mainStoreFrontUserControl.BackColor = Color.FromArgb(227, 211, 177);
            mainStoreFrontUserControl.Location = new Point(0, 0);
            mainStoreFrontUserControl.Margin = new Padding(3, 5, 3, 5);
            mainStoreFrontUserControl.Name = "mainStoreFrontUserControl";
            mainStoreFrontUserControl.Size = new Size(1007, 676);
            mainStoreFrontUserControl.TabIndex = 2;
            // 
            // HomeTabUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 211, 177);
            Controls.Add(homeFlowLayoutPanel);
            Controls.Add(mainStoreFrontUserControl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "HomeTabUserControl";
            Size = new Size(1011, 680);
            Load += HomeTabUserControl_Load;
            homeFlowLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel homeFlowLayoutPanel;
        private Button AddStoreButton;
        private StoreFrontUserControl mainStoreFrontUserControl;
    }
}
