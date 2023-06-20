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

        private void refreshListButton_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void VendorTabUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
