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
    }
}
