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
            this.homeFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddStoreButton = new System.Windows.Forms.Button();
            this.mainStoreFrontUserControl = new MyStores.UserControls.HomeUserControl.StoreFrontUserControl();
            this.storeFrontPanel = new System.Windows.Forms.Panel();
            this.homeFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // homeFlowLayoutPanel
            // 
            this.homeFlowLayoutPanel.Controls.Add(this.AddStoreButton);
            this.homeFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.homeFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(18);
            this.homeFlowLayoutPanel.Name = "homeFlowLayoutPanel";
            this.homeFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(18);
            this.homeFlowLayoutPanel.Size = new System.Drawing.Size(1390, 900);
            this.homeFlowLayoutPanel.TabIndex = 0;
            // 
            // AddStoreButton
            // 
            this.AddStoreButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.AddStoreButton.FlatAppearance.BorderSize = 0;
            this.AddStoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStoreButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddStoreButton.ForeColor = System.Drawing.Color.White;
            this.AddStoreButton.Image = ((System.Drawing.Image)(resources.GetObject("AddStoreButton.Image")));
            this.AddStoreButton.Location = new System.Drawing.Point(21, 21);
            this.AddStoreButton.Name = "AddStoreButton";
            this.AddStoreButton.Size = new System.Drawing.Size(160, 200);
            this.AddStoreButton.TabIndex = 1;
            this.AddStoreButton.Text = "Add Store";
            this.AddStoreButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddStoreButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AddStoreButton.UseVisualStyleBackColor = false;
            this.AddStoreButton.Click += new System.EventHandler(this.AddStoreButton_Click);
            // 
            // mainStoreFrontUserControl
            // 
            this.mainStoreFrontUserControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.mainStoreFrontUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainStoreFrontUserControl.Location = new System.Drawing.Point(0, 0);
            this.mainStoreFrontUserControl.Name = "mainStoreFrontUserControl";
            this.mainStoreFrontUserControl.Size = new System.Drawing.Size(1390, 900);
            this.mainStoreFrontUserControl.TabIndex = 2;
            // 
            // storeFrontPanel
            // 
            this.storeFrontPanel.Location = new System.Drawing.Point(21, 227);
            this.storeFrontPanel.Name = "storeFrontPanel";
            this.storeFrontPanel.Size = new System.Drawing.Size(1390, 900);
            this.storeFrontPanel.TabIndex = 1;
            // 
            // HomeTabUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.Controls.Add(this.mainStoreFrontUserControl);
            this.Controls.Add(this.storeFrontPanel);
            this.Controls.Add(this.homeFlowLayoutPanel);
            this.Name = "HomeTabUserControl";
            this.Size = new System.Drawing.Size(1390, 900);
            this.Load += new System.EventHandler(this.HomeTabUserControl_Load);
            this.homeFlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel homeFlowLayoutPanel;
        private Button AddStoreButton;
        private StoreFrontUserControl mainStoreFrontUserControl;
        private Panel storeFrontPanel;
    }
}
