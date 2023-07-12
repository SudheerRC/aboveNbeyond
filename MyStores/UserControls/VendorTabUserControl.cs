using MyStores.Controller;
using MyStores.Model;

namespace MyStores.UserControls
{
    public partial class VendorTabUserControl : UserControl
    {
        private Users _owner;
        private readonly MyStoresController _controller;

        public VendorTabUserControl()
        {
            InitializeComponent();
            _controller = new MyStoresController();
            _owner = new Users();
        }

        public void SetOwner(Users setUser)
        {
            _owner = setUser;
        }

        private void RefreshListButton_Click(object sender, EventArgs e)
        {
            RefreshListView();
        }

        private void RefreshListView()
        {
            searchTextBox.Clear();
            List<Vendor> allVendors = _controller.GetAllVendors();
            mainVendorListView.Items.Clear();
            foreach (var vendor in allVendors)
            {
                string[] row =
                {
                    vendor.Name, vendor.City, vendor.PhoneNumber, vendor.State, vendor.ZipCode, vendor.Country
                };
                var listItem = new ListViewItem(row);
                mainVendorListView.Items.Add(listItem);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var input = searchTextBox.Text;
            if (!string.IsNullOrEmpty(input))
            {
                List<Vendor> searchVendors = _controller.SearchVendorsWithName(input);
                mainVendorListView.Items.Clear();
                foreach (var vendor in searchVendors)
                {
                    string[] row =
                    {
                        vendor.Name, vendor.City, vendor.PhoneNumber, vendor.State, vendor.ZipCode, vendor.Country
                    };
                    var listItem = new ListViewItem(row);
                    mainVendorListView.Items.Add(listItem);
                }
            }
        }

        private void VendorTabUserControl_Load(object sender, EventArgs e)
        {
            RefreshListView();
            mainVendorListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void SearchTextBox_GotFocus(object sender, EventArgs e)
        {
            RefreshListView();
        }
    }
}
