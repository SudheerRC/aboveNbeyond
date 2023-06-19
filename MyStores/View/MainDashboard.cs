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
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
