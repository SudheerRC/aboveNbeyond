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
            VipButton = new Button();
            mainStoreFrontUserControl = new StoreFrontUserControl();
            homeFlowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // homeFlowLayoutPanel
            // 
            homeFlowLayoutPanel.Controls.Add(AddStoreButton);
            homeFlowLayoutPanel.Controls.Add(VipButton);
            homeFlowLayoutPanel.Location = new Point(0, 0);
            homeFlowLayoutPanel.Margin = new Padding(33, 38, 33, 38);
            homeFlowLayoutPanel.Name = "homeFlowLayoutPanel";
            homeFlowLayoutPanel.Padding = new Padding(33, 38, 33, 38);
            homeFlowLayoutPanel.Size = new Size(1636, 1082);
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
            AddStoreButton.Location = new Point(39, 44);
            AddStoreButton.Margin = new Padding(6, 6, 6, 6);
            AddStoreButton.Name = "AddStoreButton";
            AddStoreButton.Padding = new Padding(11, 13, 11, 13);
            AddStoreButton.Size = new Size(279, 363);
            AddStoreButton.TabIndex = 1;
            AddStoreButton.Text = "Add Store";
            AddStoreButton.TextAlign = ContentAlignment.BottomCenter;
            AddStoreButton.TextImageRelation = TextImageRelation.ImageAboveText;
            AddStoreButton.UseVisualStyleBackColor = false;
            AddStoreButton.Click += AddStoreButton_Click;
            // 
            // VipButton
            // 
            VipButton.BackColor = Color.FromArgb(28, 44, 78);
            VipButton.FlatAppearance.BorderSize = 0;
            VipButton.FlatStyle = FlatStyle.Flat;
            VipButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            VipButton.ForeColor = Color.White;
            VipButton.Image = (Image)resources.GetObject("VipButton.Image");
            VipButton.Location = new Point(330, 44);
            VipButton.Margin = new Padding(6, 6, 6, 6);
            VipButton.Name = "VipButton";
            VipButton.Padding = new Padding(11, 13, 11, 13);
            VipButton.Size = new Size(279, 363);
            VipButton.TabIndex = 2;
            VipButton.Text = "Add Store";
            VipButton.TextAlign = ContentAlignment.BottomCenter;
            VipButton.TextImageRelation = TextImageRelation.ImageAboveText;
            VipButton.UseVisualStyleBackColor = false;
            VipButton.Visible = false;
            // 
            // mainStoreFrontUserControl
            // 
            mainStoreFrontUserControl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mainStoreFrontUserControl.BackColor = Color.FromArgb(227, 211, 177);
            mainStoreFrontUserControl.Location = new Point(0, 0);
            mainStoreFrontUserControl.Margin = new Padding(6, 9, 6, 9);
            mainStoreFrontUserControl.Name = "mainStoreFrontUserControl";
            mainStoreFrontUserControl.Size = new Size(1636, 1082);
            mainStoreFrontUserControl.TabIndex = 2;
            mainStoreFrontUserControl.OnUpdateStatus += StoreFrontUserControl_OnUpdateStatus;
            // 
            // HomeTabUserControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 211, 177);
            Controls.Add(homeFlowLayoutPanel);
            Controls.Add(mainStoreFrontUserControl);
            Margin = new Padding(6, 6, 6, 6);
            Name = "HomeTabUserControl";
            Size = new Size(1644, 1088);
            Load += HomeTabUserControl_Load;
            homeFlowLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel homeFlowLayoutPanel;
        private Button AddStoreButton;
        private StoreFrontUserControl mainStoreFrontUserControl;
        private Button VipButton;
    }
}
