namespace MyStores.UserControls
{
    partial class NewStoreChipUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewStoreChipUserControl));
            this.storeButton = new System.Windows.Forms.Button();
            this.cityButton = new System.Windows.Forms.Button();
            this.storeIdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // storeButton
            // 
            this.storeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.storeButton.FlatAppearance.BorderSize = 0;
            this.storeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.storeButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.storeButton.ForeColor = System.Drawing.Color.White;
            this.storeButton.Image = ((System.Drawing.Image)(resources.GetObject("storeButton.Image")));
            this.storeButton.Location = new System.Drawing.Point(0, 0);
            this.storeButton.Name = "storeButton";
            this.storeButton.Size = new System.Drawing.Size(160, 200);
            this.storeButton.TabIndex = 2;
            this.storeButton.Text = "Store Name";
            this.storeButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.storeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.storeButton.UseVisualStyleBackColor = false;
            // 
            // cityButton
            // 
            this.cityButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.cityButton.FlatAppearance.BorderSize = 0;
            this.cityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cityButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cityButton.ForeColor = System.Drawing.Color.White;
            this.cityButton.Location = new System.Drawing.Point(0, 168);
            this.cityButton.Name = "cityButton";
            this.cityButton.Size = new System.Drawing.Size(160, 32);
            this.cityButton.TabIndex = 3;
            this.cityButton.Text = "City";
            this.cityButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cityButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cityButton.UseVisualStyleBackColor = false;
            // 
            // storeIdLabel
            // 
            this.storeIdLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(78)))));
            this.storeIdLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.storeIdLabel.ForeColor = System.Drawing.Color.White;
            this.storeIdLabel.Location = new System.Drawing.Point(115, 0);
            this.storeIdLabel.Name = "storeIdLabel";
            this.storeIdLabel.Size = new System.Drawing.Size(45, 31);
            this.storeIdLabel.TabIndex = 4;
            this.storeIdLabel.Text = "23";
            this.storeIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewStoreChipUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.storeIdLabel);
            this.Controls.Add(this.cityButton);
            this.Controls.Add(this.storeButton);
            this.Name = "NewStoreChipUserControl";
            this.Size = new System.Drawing.Size(160, 200);
            this.ResumeLayout(false);

        }

        #endregion

        private Button storeButton;
        private Button cityButton;
        private Label storeIdLabel;
    }
}
