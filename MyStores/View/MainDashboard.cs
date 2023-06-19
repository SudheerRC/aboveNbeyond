using MyStores.UserControls;

namespace MyStores.View
{
    public partial class MainDashboard : Form
    {
        public MainDashboard()
        {
            InitializeComponent();
            this.populateHomePanel();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void populateHomePanel()
        {
            homeFlowLayoutPanel.Controls.Add(new AddStoreUserControl());
            StoreChipUserControl[] homeChips = new StoreChipUserControl[99];


        }
    }
}
