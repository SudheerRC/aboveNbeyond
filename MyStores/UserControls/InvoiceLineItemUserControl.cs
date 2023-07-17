namespace MyStores.UserControls
{
    public partial class InvoiceLineItemUserControl : UserControl
    {
        private int _saleId;
        private int _inventoryId;

        public InvoiceLineItemUserControl()
        {
            InitializeComponent();
        }

        public void setSaleId(int saleId)
        {
            this._saleId = saleId;
        }

        public void setInventoryId(int inventoryId)
        {
            this._inventoryId = inventoryId;
        }


    }
}
