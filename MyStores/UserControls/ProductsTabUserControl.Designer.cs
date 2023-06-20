namespace MyStores.UserControls
{
    partial class ProductsTabUserControl
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
            this.mainAddProductUserControl = new MyStores.UserControls.AddProductUserControl();
            this.SuspendLayout();
            // 
            // mainAddProductUserControl
            // 
            this.mainAddProductUserControl.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.mainAddProductUserControl.Location = new System.Drawing.Point(537, 119);
            this.mainAddProductUserControl.Name = "mainAddProductUserControl";
            this.mainAddProductUserControl.Size = new System.Drawing.Size(359, 627);
            this.mainAddProductUserControl.TabIndex = 0;
            // 
            // ProductsTabUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.Controls.Add(this.mainAddProductUserControl);
            this.Name = "ProductsTabUserControl";
            this.Size = new System.Drawing.Size(1390, 900);
            this.ResumeLayout(false);

        }

        #endregion

        private AddProductUserControl mainAddProductUserControl;
    }
}
