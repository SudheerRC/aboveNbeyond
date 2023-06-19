using MyStores.Model;
using MyStores.UserControls;

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
    }
}
