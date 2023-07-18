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
            storeVendorListView.Refresh();

            //storeVendorListView.Columns[0].Width = 140;
            //storeVendorListView.Columns[1].Width = 130;
            //storeVendorListView.Columns[2].Width = 120;
        }

        private void loadListView()
        {
            refreshListView();
            var vendors = _controller.SearchVendorByStoreId(_storeId);
            if (vendors.Count != 0)
            {
                foreach (var vendor in vendors)
                {
                    FeedListView(vendor);
                }
            }
            else
            {
                storeVendorListView.Items.Clear();
            }
        }

        private void FeedListView(Vendor vendor)
        {
            storeVendorListView.Scrollable = true;
            //storeVendorListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            string[] row =
            {
                vendor.Name, vendor.City, vendor.PhoneNumber
            };
            var listItem = new ListViewItem(row);
            storeVendorListView.Items.Add(listItem);
        }

        private void loadVendorComboBox()
        {
            vendorComboBox.DataSource = null;
            vendorComboBox.Items.Clear();
            List<Vendor> vendorList = _controller.GetAllVendors();
            vendorComboBox.DataSource = vendorList;
            vendorComboBox.SelectedIndex = 0;
        }

        private void addVendorButton_Click(object sender, EventArgs e)
        {
            vendorInfoPanel.Visible = false;
            mainAddVendorUserControl.BringToFront();
            mainAddVendorUserControl.Visible = true;
            closeVendorFormPictureBox.BringToFront();
            closeVendorFormPictureBox.Visible = true;
            loadListView();
        }

        private void closeVendorFormPictureBox_Click(object sender, EventArgs e)
        {
            vendorInfoPanel.Visible = true;
            mainAddVendorUserControl.Visible = false;
            closeVendorFormPictureBox.Visible = false;
            loadVendorComboBox();
            loadListView();
        }

        private void addVendorToStoreButton_Click(object sender, EventArgs e)
        {
            var selectedVendor = vendorComboBox.SelectedItem as Vendor;
            if (!_controller.CheckStoreVendorExists(_storeId, selectedVendor.Id))
            {
                _controller.AddVendorToStore(selectedVendor.Id, _storeId);
                loadListView();
            }
            else
            {
                MessageBox.Show("You cannot add this Vendor as they are already added for this store");
            }
        }

        public void AddVendorToStoreUserControl_Load(object sender, EventArgs e)
        {
            messageLabel.Text = @"If you do not find a vendor in the above list, " +
                                @"consider adding them to your list by clicking the link below";

            loadVendorComboBox();
            loadListView();
        }

    }
}
