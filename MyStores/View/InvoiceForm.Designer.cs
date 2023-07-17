namespace MyStores.View
{
    partial class InvoiceForm
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
            invoiceUserControl1 = new UserControls.InvoiceUserControl();
            SuspendLayout();
            // 
            // invoiceUserControl1
            // 
            invoiceUserControl1.BackColor = Color.FromArgb(227, 211, 177);
            invoiceUserControl1.Location = new Point(3, 3);
            invoiceUserControl1.Name = "invoiceUserControl1";
            invoiceUserControl1.Size = new Size(848, 724);
            invoiceUserControl1.TabIndex = 0;
            // 
            // InvoiceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 211, 177);
            ClientSize = new Size(689, 579);
            Controls.Add(invoiceUserControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InvoiceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Invoice";
            ResumeLayout(false);
        }

        #endregion

        private UserControls.InvoiceUserControl invoiceUserControl1;
    }
}