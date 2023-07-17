namespace MyStores.UserControls
{
    public partial class InvoiceUserControl : UserControl
    {
        private int _saleId;

        public InvoiceUserControl()
        {
            InitializeComponent();
        }

        public void setSaleId(int saleId)
        {
            this._saleId = saleId;
        }


    }
}
