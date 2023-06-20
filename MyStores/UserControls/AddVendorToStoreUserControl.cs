using MyStores.Controller;
using MyStores.Model;

namespace MyStores.UserControls
{
    public partial class AddVendorToStoreUserControl : UserControl
    {
        private int _storeId;
        private readonly MyStoresController _controller;
        public AddVendorToStoreUserControl()
        {
            InitializeComponent();
            _controller = new MyStoresController();
            loadListView();
        }

        public void SetStore(int id)
        {
            _storeId = id;
        }

        public void refreshListView()
        {
            storeVendorListView.Items.Clear();
        }

        private void loadListView()
        {
            refreshListView();
            foreach (var vendor in _controller.SearchVendorByStoreId(_storeId))
            {
                FeedListView(vendor);
            }
        }

        private void FeedListView(Vendor vendor)
        {
            string[] row =
            {
                vendor.Name, vendor.City, vendor.PhoneNumber
            };
            var listItem = new ListViewItem(row);
            storeVendorListView.Items.Add(listItem);
        }
    }
}
