namespace MyStores.UserControls
{
    public partial class ProductsTabUserControl : UserControl
    {
        private int _productId;
        public ProductsTabUserControl()
        {
            InitializeComponent();
        }

        public void SetProductId(int productId)
        {
            _productId = productId;
        }

        private void ProductsTabUserControl_Load(object sender, EventArgs e)
        {
            mainAddProductUserControl.SetProductId(_productId);
        }

        public void SetProductDetails()
        {
            mainAddProductUserControl.SetProductId(_productId);
            mainAddProductUserControl.SetProductDetails();
        }

        public void ClearFields()
        {
            mainAddProductUserControl.ClearFields();
        }
    }
}
