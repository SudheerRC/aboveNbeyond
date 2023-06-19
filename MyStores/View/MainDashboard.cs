using MyStores.Model;
using MyStores.UserControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyStores.View
{
    public partial class MainDashboard : Form
    {
        private Users _owner;
        public MainDashboard()
        {
            InitializeComponent();
            _owner = new Users();
            formScaling();
        }

        public void SetOwner(Users setUser)
        {
            _owner = setUser;
            this.populateHomePanel();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void populateHomePanel()
        {
            StoreChipUserControl[] homeChips = new StoreChipUserControl[99];

            for (int i = 0; i < homeChips.Length; i++)
            {
                homeChips[i] = new StoreChipUserControl();

            }
        }

        private void addStoreUserControl1_Click(object sender, EventArgs e)
        {
            this.populateHomePanel();
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            addStoreUserControl.SetOwner(_owner);
        }

        private void maxButton_Click(object sender, EventArgs e)
        {
            System.Drawing.Rectangle screenRectangle = Screen.GetWorkingArea(this);
            this.MaximizedBounds = screenRectangle;
            this.maxButton.Visible = false;
            this.Location = new System.Drawing.Point(0,0);
            this.WindowState = FormWindowState.Maximized;
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void formScaling()
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
            formScaling();
        }
    }
}
