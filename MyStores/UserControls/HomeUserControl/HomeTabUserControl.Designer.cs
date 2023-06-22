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
            this.homeFlowLayoutPanel.Size = new System.Drawing.Size(881, 507);
            this.homeFlowLayoutPanel.TabIndex = 0;
            // 
            // AddStoreButton
            // 
            this.AddStoreButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.AddStoreButton.FlatAppearance.BorderSize = 0;
            this.AddStoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStoreButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddStoreButton.ForeColor = System.Drawing.Color.White;
            this.AddStoreButton.Image = ((System.Drawing.Image)(resources.GetObject("AddStoreButton.Image")));
            this.AddStoreButton.Location = new System.Drawing.Point(21, 21);
            this.AddStoreButton.Name = "AddStoreButton";
            this.AddStoreButton.Padding = new System.Windows.Forms.Padding(6);
            this.AddStoreButton.Size = new System.Drawing.Size(150, 170);
            this.AddStoreButton.TabIndex = 1;
            this.AddStoreButton.Text = "Add Store";
            this.AddStoreButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddStoreButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AddStoreButton.UseVisualStyleBackColor = false;
            this.AddStoreButton.Click += new System.EventHandler(this.AddStoreButton_Click);
            // 
            // mainStoreFrontUserControl
            // 
            this.mainStoreFrontUserControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainStoreFrontUserControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.mainStoreFrontUserControl.Location = new System.Drawing.Point(0, 0);
            this.mainStoreFrontUserControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainStoreFrontUserControl.Name = "mainStoreFrontUserControl";
            this.mainStoreFrontUserControl.Size = new System.Drawing.Size(881, 507);
            this.mainStoreFrontUserControl.TabIndex = 2;
            // 
            // HomeTabUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.Controls.Add(this.homeFlowLayoutPanel);
            this.Controls.Add(this.mainStoreFrontUserControl);
            this.Name = "HomeTabUserControl";
            this.Size = new System.Drawing.Size(885, 510);
            this.Load += new System.EventHandler(this.HomeTabUserControl_Load);
            this.homeFlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel homeFlowLayoutPanel;
        private Button AddStoreButton;
        private StoreFrontUserControl mainStoreFrontUserControl;
    }
}
