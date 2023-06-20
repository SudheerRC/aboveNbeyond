namespace MyStores.UserControls.HomeUserControl
{
    partial class StoreFrontUserControl
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
            this.highlightTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AddVendorIconUserControl = new MyStores.UserControls.IconUserControl();
            this.InventoryIconUserControl = new MyStores.UserControls.IconUserControl();
            this.AddProductIconUserControl = new MyStores.UserControls.IconUserControl();
            this.AddManagerIconUserControl = new MyStores.UserControls.IconUserControl();
            this.OrdersIconUserControl = new MyStores.UserControls.IconUserControl();
            this.ExitStoreIconUserControl = new MyStores.UserControls.IconUserControl();
            this.SuspendLayout();
            // 
            // highlightTableLayoutPanel
            // 
            this.highlightTableLayoutPanel.ColumnCount = 5;
            this.highlightTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.highlightTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.highlightTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 321F));
            this.highlightTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.highlightTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 217F));
            this.highlightTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.highlightTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.highlightTableLayoutPanel.Name = "highlightTableLayoutPanel";
            this.highlightTableLayoutPanel.RowCount = 1;
            this.highlightTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.highlightTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.highlightTableLayoutPanel.Size = new System.Drawing.Size(1390, 107);
            this.highlightTableLayoutPanel.TabIndex = 1;
            // 
            // AddVendorIconUserControl
            // 
            this.AddVendorIconUserControl.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AddVendorIconUserControl.Icon = null;
            this.AddVendorIconUserControl.IconName = "Add Vendor";
            this.AddVendorIconUserControl.Location = new System.Drawing.Point(344, 341);
            this.AddVendorIconUserControl.Name = "AddVendorIconUserControl";
            this.AddVendorIconUserControl.Size = new System.Drawing.Size(100, 112);
            this.AddVendorIconUserControl.TabIndex = 2;
            // 
            // InventoryIconUserControl
            // 
            this.InventoryIconUserControl.BackColor = System.Drawing.SystemColors.ControlDark;
            this.InventoryIconUserControl.Icon = null;
            this.InventoryIconUserControl.IconName = "Inventory";
            this.InventoryIconUserControl.Location = new System.Drawing.Point(634, 341);
            this.InventoryIconUserControl.Name = "InventoryIconUserControl";
            this.InventoryIconUserControl.Size = new System.Drawing.Size(100, 112);
            this.InventoryIconUserControl.TabIndex = 3;
            // 
            // AddProductIconUserControl
            // 
            this.AddProductIconUserControl.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AddProductIconUserControl.Icon = null;
            this.AddProductIconUserControl.IconName = "Add Product";
            this.AddProductIconUserControl.Location = new System.Drawing.Point(476, 527);
            this.AddProductIconUserControl.Name = "AddProductIconUserControl";
            this.AddProductIconUserControl.Size = new System.Drawing.Size(100, 112);
            this.AddProductIconUserControl.TabIndex = 4;
            // 
            // AddManagerIconUserControl
            // 
            this.AddManagerIconUserControl.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AddManagerIconUserControl.Icon = null;
            this.AddManagerIconUserControl.IconName = "Add Manager";
            this.AddManagerIconUserControl.Location = new System.Drawing.Point(809, 527);
            this.AddManagerIconUserControl.Name = "AddManagerIconUserControl";
            this.AddManagerIconUserControl.Size = new System.Drawing.Size(100, 112);
            this.AddManagerIconUserControl.TabIndex = 5;
            // 
            // OrdersIconUserControl
            // 
            this.OrdersIconUserControl.BackColor = System.Drawing.SystemColors.ControlDark;
            this.OrdersIconUserControl.Icon = null;
            this.OrdersIconUserControl.IconName = "Orders";
            this.OrdersIconUserControl.Location = new System.Drawing.Point(946, 341);
            this.OrdersIconUserControl.Name = "OrdersIconUserControl";
            this.OrdersIconUserControl.Size = new System.Drawing.Size(100, 112);
            this.OrdersIconUserControl.TabIndex = 6;
            // 
            // ExitStoreIconUserControl
            // 
            this.ExitStoreIconUserControl.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ExitStoreIconUserControl.Icon = null;
            this.ExitStoreIconUserControl.IconName = "Exit Store";
            this.ExitStoreIconUserControl.Location = new System.Drawing.Point(1290, 788);
            this.ExitStoreIconUserControl.Name = "ExitStoreIconUserControl";
            this.ExitStoreIconUserControl.Size = new System.Drawing.Size(100, 112);
            this.ExitStoreIconUserControl.TabIndex = 7;
            // 
            // StoreFrontUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(211)))), ((int)(((byte)(177)))));
            this.Controls.Add(this.ExitStoreIconUserControl);
            this.Controls.Add(this.OrdersIconUserControl);
            this.Controls.Add(this.AddManagerIconUserControl);
            this.Controls.Add(this.AddProductIconUserControl);
            this.Controls.Add(this.InventoryIconUserControl);
            this.Controls.Add(this.AddVendorIconUserControl);
            this.Controls.Add(this.highlightTableLayoutPanel);
            this.Name = "StoreFrontUserControl";
            this.Size = new System.Drawing.Size(1390, 900);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel highlightTableLayoutPanel;
        private IconUserControl AddVendorIconUserControl;
        private IconUserControl InventoryIconUserControl;
        private IconUserControl AddProductIconUserControl;
        private IconUserControl AddManagerIconUserControl;
        private IconUserControl OrdersIconUserControl;
        private IconUserControl ExitStoreIconUserControl;
    }
}
