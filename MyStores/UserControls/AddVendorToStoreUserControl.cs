using MyStores.Controller;
using MyStores.Model;

namespace MyStores.UserControls
{
    public partial class AddVendorToStoreUserControl : UserControl
    {
        private Users _owner;
        private int _storeId;
        private readonly MyStoresController _controller;
        public AddVendorToStoreUserControl()
        {
            InitializeComponent();
            _owner = new Users();
            _controller = new MyStoresController();

            messageLabel.Text = @"If you do not find a vendor in the above list, consider adding them to your list by clicking the link below";

            loadVendorComboBox();
            loadListView();
        }

        public void SetStore(int id)
        {
            _storeId = id;
        }

        public void SetOwner(Users setUser)
        {
            _owner = setUser;
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

        private List<Vendor> getAllVendorList()
        {
            List<Vendor> vendorList = new List<Vendor>();
            List<Store> storeList = _controller.GetUserStores(_owner.UserId);

            foreach (Store store in storeList)
            {
                List<Vendor> currentStoresVendors = _controller.SearchVendorByStoreId(store.Id);
                vendorList.AddRange(currentStoresVendors);
            }

            return vendorList;
        }

        private void loadVendorComboBox()
        {
            vendorComboBox.Items.Clear();
            vendorComboBox.DisplayMember = "Name";
            vendorComboBox.ValueMember = "Id";
            vendorComboBox.DataSource = _controller.GetAllVendors();
            vendorComboBox.SelectedIndex = 0;
        }

        private void addVendorButton_Click(object sender, EventArgs e)
        {
            mainAddVendorUserControl.BringToFront();
            closeVendorFormPictureBox.BringToFront();
            vendorInfoPanel.Visible = false;
            mainAddVendorUserControl.Visible = true;
            closeVendorFormPictureBox.Visible = true;
        }

        private void closeVendorFormPictureBox_Click(object sender, EventArgs e)
        {
            vendorInfoPanel.Visible = true;
            mainAddVendorUserControl.Visible = false;
            closeVendorFormPictureBox.Visible = false;
            loadVendorComboBox();
        }

        private void addVendorToStoreButton_Click(object sender, EventArgs e)
        {
            var selectedVendor = vendorComboBox.SelectedItem as Vendor;
            _controller.AddVendorToStore(selectedVendor.Id, _storeId);
            loadListView();
        }
    }
}
