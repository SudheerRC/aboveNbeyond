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
            mainAddProductUserControl = new AddProductUserControl();
            SuspendLayout();
            // 
            // mainAddProductUserControl
            // 
            mainAddProductUserControl.BackColor = Color.BlanchedAlmond;
            mainAddProductUserControl.Location = new Point(0, 0);
            mainAddProductUserControl.Margin = new Padding(5, 8, 5, 8);
            mainAddProductUserControl.Name = "mainAddProductUserControl";
            mainAddProductUserControl.Size = new Size(1336, 1338);
            mainAddProductUserControl.TabIndex = 0;
            // 
            // ProductsTabUserControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 211, 177);
            Controls.Add(mainAddProductUserControl);
            Margin = new Padding(5, 6, 5, 6);
            Name = "ProductsTabUserControl";
            Size = new Size(1429, 1338);
            Load += ProductsTabUserControl_Load;
            ResumeLayout(false);
        }

        #endregion

        private AddProductUserControl mainAddProductUserControl;
    }
}
