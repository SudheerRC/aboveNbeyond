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
            FormScaling();

            mainHomeTabUserControl.Parent = storeContainer.Panel2;
            mainHomeTabUserControl.Dock = DockStyle.Top;
        }

        public void SetOwner(Users setUser)
        {
            _owner = setUser;
            mainHomeTabUserControl.SetOwner(_owner);
        }

        private void hideAllUserControls()
        {
            mainHomeTabUserControl.Visible = false;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            mainHomeTabUserControl.SetOwner(_owner);
        }

        private void maxButton_Click(object sender, EventArgs e)
        {
            System.Drawing.Rectangle screenRectangle = Screen.GetWorkingArea(this);
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
            var oldWidth = screenRectangle.Width;
            var oldHeight = screenRectangle.Height;

            var scalingPercentage = 0.75;
            var newWidth = Convert.ToInt32(oldWidth * scalingPercentage);
            var newHeight = Convert.ToInt32(oldHeight * scalingPercentage);

            screenRectangle.Size = new Size(newWidth, newHeight);
            screenRectangle.Location = new System.Drawing.Point((oldWidth - newWidth) / 2, (oldHeight - newHeight) / 2);

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
    }
}
