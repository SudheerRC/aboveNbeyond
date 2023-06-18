namespace MyStores.View
{
    partial class MainDashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.workspaceContainer = new System.Windows.Forms.SplitContainer();
            this.storeContainer = new System.Windows.Forms.SplitContainer();
            this.storeNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workspaceContainer)).BeginInit();
            this.workspaceContainer.Panel1.SuspendLayout();
            this.workspaceContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeContainer)).BeginInit();
            this.storeContainer.Panel1.SuspendLayout();
            this.storeContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Name = "mainContainer";
            // 
            // mainContainer.Panel1
            // 
            this.mainContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.mainContainer.Panel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.Controls.Add(this.workspaceContainer);
            this.mainContainer.Size = new System.Drawing.Size(1904, 1041);
            this.mainContainer.SplitterDistance = 263;
            this.mainContainer.SplitterWidth = 1;
            this.mainContainer.TabIndex = 0;
            // 
            // workspaceContainer
            // 
            this.workspaceContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workspaceContainer.Location = new System.Drawing.Point(0, 0);
            this.workspaceContainer.Name = "workspaceContainer";
            // 
            // workspaceContainer.Panel1
            // 
            this.workspaceContainer.Panel1.Controls.Add(this.storeContainer);
            // 
            // workspaceContainer.Panel2
            // 
            this.workspaceContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.workspaceContainer.Size = new System.Drawing.Size(1640, 1041);
            this.workspaceContainer.SplitterDistance = 1352;
            this.workspaceContainer.SplitterWidth = 1;
            this.workspaceContainer.TabIndex = 0;
            // 
            // storeContainer
            // 
            this.storeContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.storeContainer.Location = new System.Drawing.Point(0, 0);
            this.storeContainer.Name = "storeContainer";
            this.storeContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // storeContainer.Panel1
            // 
            this.storeContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(123)))), ((int)(((byte)(213)))));
            this.storeContainer.Panel1.Controls.Add(this.storeNameLabel);
            // 
            // storeContainer.Panel2
            // 
            this.storeContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(205)))), ((int)(((byte)(232)))));
            this.storeContainer.Size = new System.Drawing.Size(1352, 1041);
            this.storeContainer.SplitterDistance = 140;
            this.storeContainer.SplitterWidth = 1;
            this.storeContainer.TabIndex = 0;
            // 
            // storeNameLabel
            // 
            this.storeNameLabel.Font = new System.Drawing.Font("Segoe UI", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.storeNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.storeNameLabel.Location = new System.Drawing.Point(3, 23);
            this.storeNameLabel.Name = "storeNameLabel";
            this.storeNameLabel.Size = new System.Drawing.Size(1346, 68);
            this.storeNameLabel.TabIndex = 0;
            this.storeNameLabel.Text = "Store Name";
            this.storeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.mainContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainDashboard";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyStores";
            this.mainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.workspaceContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.workspaceContainer)).EndInit();
            this.workspaceContainer.ResumeLayout(false);
            this.storeContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.storeContainer)).EndInit();
            this.storeContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer mainContainer;
        private SplitContainer workspaceContainer;
        private SplitContainer storeContainer;
        private Label storeNameLabel;
    }
}