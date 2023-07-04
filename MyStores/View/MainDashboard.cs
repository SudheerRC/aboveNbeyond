using MyStores.Controller;
using MyStores.Model;

namespace MyStores.View
{
    public partial class MainDashboard : Form
    {
        private Users _owner;
        private MyStoresController _controller;
        public MainDashboard()
        {
            InitializeComponent();
            _controller = new MyStoresController();
            _owner = new Users();
        }

        public void SetOwner(Users setUser)
        {
            _owner = setUser;
            mainHomeTabUserControl.SetOwner(_owner);
        }

        private void hideAllUserControls()
        {
            mainHomeTabUserControl.Visible = false;
            mainProductsTabUserControl.Visible = false;
            mainVendorTabUserControl.Visible = false;
            mainAddVendorUserControl.Visible = false;

            mainHomeTabUserControl.Dock = DockStyle.None;
            mainProductsTabUserControl.Dock = DockStyle.None;
            mainVendorTabUserControl.Dock = DockStyle.None;
            mainAddVendorUserControl.Dock = DockStyle.None;
        }

        private void ClearUserControls()
        {
            mainProductsTabUserControl.ClearFields();
            mainAddVendorUserControl.ClearFields();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            int id = _owner.UserId;
            _owner = _controller.GetUserDetails(id);
            userNameLabel.Text = "Welcome, " + Environment.NewLine + _owner.FirstName + " " + _owner.LastName;

            mainHomeTabUserControl.SetOwner(_owner);
            globalSearchUserControl.SetUser(_owner);

            ClearUserControls();
            hideAllUserControls();
            anchorUserControls();

            mainHomeTabUserControl.Dock = DockStyle.Fill;
            mainHomeTabUserControl.Visible = true;
        }

        private void GlobalSearchUserControl_OnUpdateStatus(object sender, EventArgs e)
        {
            var categoryName = globalSearchUserControl.CategoryName;
            int categoryId = globalSearchUserControl.CategoryId;

            if (categoryName.Equals("Product"))
            {
                mainProductsTabUserControl.SetProductId(categoryId);
                mainProductsTabUserControl.SetProductDetails();
                addProductSubMenuButton_Click(sender, e);
            }
            else if (categoryName.Equals("Vendor"))
            {
                mainAddVendorUserControl.SetVendorId(categoryId);
                mainAddVendorUserControl.SetVendorDetails();
                addVendorSubMenuButton_Click(sender, e);
            }
            else if (categoryName.Equals("Store"))
            {
                homeMenuButton_Click(sender, e);
                mainHomeTabUserControl.ShowStoreFrontUserControl(categoryId);
            }
        }

        private void anchorUserControls()
        {
            mainHomeTabUserControl.Parent = mainPanel;
            mainHomeTabUserControl.Anchor = AnchorStyles.Bottom;
            mainHomeTabUserControl.Anchor = AnchorStyles.Top;
            mainHomeTabUserControl.Anchor = AnchorStyles.Right;

            mainProductsTabUserControl.Parent = mainPanel;
            mainProductsTabUserControl.Anchor = AnchorStyles.Bottom;
            mainProductsTabUserControl.Anchor = AnchorStyles.Top;
            mainProductsTabUserControl.Anchor = AnchorStyles.Right;

            mainVendorTabUserControl.Parent = mainPanel;
            mainVendorTabUserControl.Anchor = AnchorStyles.Bottom;
            mainVendorTabUserControl.Anchor = AnchorStyles.Top;
            mainVendorTabUserControl.Anchor = AnchorStyles.Right;

            mainAddVendorUserControl.Parent = mainPanel;
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void homeMenuButton_Click(object sender, EventArgs e)
        {
            ClearUserControls();
            hideAllUserControls();
            anchorUserControls();

            mainHomeTabUserControl.Dock = DockStyle.Fill;
            mainHomeTabUserControl.Visible = true;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        #region MenuButtonHover

        private void homeMenuButton_MouseEnter(object sender, EventArgs e)
        {
            homeMenuButton.ForeColor = Color.FromArgb(227, 211, 177);
        }

        private void homeMenuButton_MouseLeave(object sender, EventArgs e)
        {
            homeMenuButton.ForeColor = Color.FromArgb(252, 251, 255);
        }

        private void productsMenuButton_MouseEnter(object sender, EventArgs e)
        {
            productsMenuButton.ForeColor = Color.FromArgb(227, 211, 177);
        }

        private void productsMenuButton_MouseLeave(object sender, EventArgs e)
        {
            productsMenuButton.ForeColor = Color.FromArgb(252, 251, 255);
        }

        private void addProductSubMenuButton_MouseEnter(object sender, EventArgs e)
        {
            addProductSubMenuButton.ForeColor = Color.FromArgb(227, 211, 177);
        }

        private void addProductSubMenuButton_MouseLeave(object sender, EventArgs e)
        {
            addProductSubMenuButton.ForeColor = Color.FromArgb(252, 251, 255);
        }

        private void vendorsMenuButton_MouseEnter(object sender, EventArgs e)
        {
            vendorsMenuButton.ForeColor = Color.FromArgb(227, 211, 177);
        }

        private void vendorsMenuButton_MouseLeave(object sender, EventArgs e)
        {
            vendorsMenuButton.ForeColor = Color.FromArgb(252, 251, 255);
        }

        private void searchVendorSubMenuButton_MouseEnter(object sender, EventArgs e)
        {
            searchVendorSubMenuButton.ForeColor = Color.FromArgb(227, 211, 177);
        }

        private void searchVendorSubMenuButton_MouseLeave(object sender, EventArgs e)
        {
            searchVendorSubMenuButton.ForeColor = Color.FromArgb(252, 251, 255);
        }

        private void addVendorSubMenuButton_MouseEnter(object sender, EventArgs e)
        {
            addVendorSubMenuButton.ForeColor = Color.FromArgb(227, 211, 177);
        }

        private void addVendorSubMenuButton_MouseLeave(object sender, EventArgs e)
        {
            addVendorSubMenuButton.ForeColor = Color.FromArgb(252, 251, 255);
        }

        private void logoutButton_MouseEnter(object sender, EventArgs e)
        {
            logoutButton.ForeColor = Color.FromArgb(227, 211, 177);
        }

        private void logoutButton_MouseLeave(object sender, EventArgs e)
        {
            logoutButton.ForeColor = Color.FromArgb(252, 251, 255);
        }

        #endregion

        private void addProductSubMenuButton_Click(object sender, EventArgs e)
        {
            hideAllUserControls();
            anchorUserControls();
            mainProductsTabUserControl.Dock = DockStyle.Fill;
            mainProductsTabUserControl.Visible = true;
        }

        private void searchVendorSubMenuButton_Click(object sender, EventArgs e)
        {
            ClearUserControls();
            hideAllUserControls();
            anchorUserControls();
            mainVendorTabUserControl.Dock = DockStyle.Fill;
            mainVendorTabUserControl.Visible = true;
        }

        private void addVendorSubMenuButton_Click(object sender, EventArgs e)
        {
            hideAllUserControls();
            anchorUserControls();
            mainAddVendorUserControl.Dock = DockStyle.Fill;
            mainAddVendorUserControl.Visible = true;
        }

        private void productsMenuButton_Click(object sender, EventArgs e)
        {
            ClearUserControls();
            MessageBox.Show("Collapsable Menu Coming soon!!!");
        }

        private void vendorsMenuButton_Click(object sender, EventArgs e)
        {
            ClearUserControls();
            MessageBox.Show("Collapsable Menu Coming soon!!!");
        }
    }
}
