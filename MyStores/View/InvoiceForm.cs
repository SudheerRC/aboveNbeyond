namespace MyStores.View
{
    public partial class InvoiceForm : Form
    {
        private int _saleId;

        public InvoiceForm()
        {
            InitializeComponent();
        }

        public void setSaleId(int saleId)
        {
            this._saleId = saleId;
            mainInvoiceUserControl.setSaleId(saleId);
        }
    }
}
