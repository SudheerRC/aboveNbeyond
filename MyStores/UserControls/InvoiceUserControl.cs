using MyStores.Controller;
using MyStores.Model;

namespace MyStores.UserControls
{
    public partial class InvoiceUserControl : UserControl
    {
        private int _saleId;
        private readonly MyStoresController _controller;

        public InvoiceUserControl()
        {
            InitializeComponent();
            _controller = new MyStoresController();
        }

        public void setSaleId(int saleId)
        {
            this._saleId = saleId;
        }

        private void setInvoice()
        {
            var sale = _controller.GetSaleDetailsBySaleId(_saleId);

            if (sale != null)
            {
                storeNameLabel.Text = sale.StoreName;
                saleNumberLabel.Text = "Sale #" + _saleId.ToString();
                dateValueLabel.Text = sale.SaleDateTime.ToString();
                totalValueLabel.Text = "$" + sale.Total.ToString();

                LoadFlowPanel(sale.Items);
            }
        }

        private void LoadFlowPanel(List<InventoryItem> itemList)
        {
            foreach (var t in itemList)
            {
                var invoiceLineItem = new InvoiceLineItemUserControl();
                invoiceLineItem.setInventoryItem(t);

                lineItemFlowLayoutPanel.Controls.Add(invoiceLineItem);
            }
        }

        private void InvoiceUserControl_Load(object sender, EventArgs e)
        {
            setInvoice();
        }
    }
}
