using MyStores.Model;

namespace MyStores.View
{
    public partial class MainDashboard : Form
    {
        private Users _owner;
        public MainDashboard()
        {
            InitializeComponent();
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
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            mainHomeTabUserControl.SetOwner(_owner);

            anchorUserControls();

            hideAllUserControls();
            mainHomeTabUserControl.Visible = true;

            FormScaling();
        }

        private void anchorUserControls()
        {
            mainHomeTabUserControl.Parent = storeContainer.Panel2;
            mainHomeTabUserControl.Anchor = AnchorStyles.Bottom;
            mainHomeTabUserControl.Anchor = AnchorStyles.Top;
            mainHomeTabUserControl.Anchor = AnchorStyles.Left;
            mainHomeTabUserControl.Anchor = AnchorStyles.Right;

            mainProductsTabUserControl.Parent = storeContainer.Panel2;
            mainProductsTabUserControl.Anchor = AnchorStyles.Bottom;
            mainProductsTabUserControl.Anchor = AnchorStyles.Top;
            mainProductsTabUserControl.Anchor = AnchorStyles.Left;
            mainProductsTabUserControl.Anchor = AnchorStyles.Right;

            mainVendorTabUserControl.Parent = storeContainer.Panel2;
            mainVendorTabUserControl.Anchor = AnchorStyles.Bottom;
            mainVendorTabUserControl.Anchor = AnchorStyles.Top;
            mainVendorTabUserControl.Anchor = AnchorStyles.Left;
            mainVendorTabUserControl.Anchor = AnchorStyles.Right;
        }

        private void maxButton_Click(object sender, EventArgs e)
        {
            Rectangle screenRectangle = Screen.GetWorkingArea(this);
            this.MaximizedBounds = screenRectangle;
            this.maxButton.Visible = false;
            this.Location = new System.Drawing.Point(0, 0);
            this.WindowState = FormWindowState.Maximized;
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FormScaling()
        {
            System.Drawing.Rectangle screenRectangle = Screen.GetWorkingArea(this);
            //var oldWidth = screenRectangle.Width;
            //var oldHeight = screenRectangle.Height;

            //var scalingPercentage = 0.75;
            //var newWidth = Convert.ToInt32(oldWidth * scalingPercentage);
            //var newHeight = Convert.ToInt32(oldHeight * scalingPercentage);

            //screenRectangle.Size = new Size(newWidth, newHeight);
            //screenRectangle.Location = new System.Drawing.Point((oldWidth - newWidth) / 2, (oldHeight - newHeight) / 2);

            this.MaximizedBounds = screenRectangle;
            this.WindowState = FormWindowState.Maximized;
        }

        private void restoreButton_Click(object sender, EventArgs e)
        {
            this.maxButton.Visible = true;
            FormScaling();
        }

        private void homeMenuButton_Click(object sender, EventArgs e)
        {
            hideAllUserControls();
            mainHomeTabUserControl.Visible = true;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        #region Hover

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
            mainProductsTabUserControl.Visible = true;
        }

        private void searchVendorSubMenuButton_Click(object sender, EventArgs e)
        {
            hideAllUserControls();
            mainVendorTabUserControl.Visible = true;
        }

        private void addVendorSubMenuButton_Click(object sender, EventArgs e)
        {
            hideAllUserControls();
            mainVendorTabUserControl.Visible = true;
        }

        private void productsMenuButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon!!!");
        }

        private void vendorsMenuButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon!!!");
        }
    }
}
