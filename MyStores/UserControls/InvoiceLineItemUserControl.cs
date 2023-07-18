using MyStores.Model;

namespace MyStores.UserControls
{
    public partial class InvoiceLineItemUserControl : UserControl
    {
        private InventoryItem _inventoryItem;

        public InvoiceLineItemUserControl()
        {
            InitializeComponent();
            _inventoryItem = new InventoryItem();
        }

        public void setInventoryItem(InventoryItem inventoryItem)
        {
            this._inventoryItem = inventoryItem;
        }

        private void loadUserControl()
        {
            productIdLabel.Text = "#" + _inventoryItem.Item.Id.ToString();
            productNameLabel.Text = _inventoryItem.Item.Name;
            sizeValueLabel.Text = _inventoryItem.Item.ProductSize.ToString();
            quantityValueLabel.Text = _inventoryItem.Quantity.ToString();
            unitPriceValueLabel.Text = "$" + _inventoryItem.SellingPrice.ToString();

            if (_inventoryItem.Discount != 0)
            {
                discountHeadingabel.Visible = true;
                discountValueLabel.Visible = true;
                discountValueLabel.Text = "$" + _inventoryItem.Discount.ToString();
            }
            else
            {
                discountHeadingabel.Visible = false;
                discountValueLabel.Visible = false;
            }

        }

        private void InvoiceLineItemUserControl_Load(object sender, EventArgs e)
        {
            loadUserControl();
        }
    }
}
