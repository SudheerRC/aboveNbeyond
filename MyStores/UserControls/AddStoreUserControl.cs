using MyStores.Model;
using MyStores.View;

namespace MyStores.UserControls
{
    public partial class AddStoreUserControl : UserControl
    {
        private Users _owner;
        public AddStoreUserControl()
        {
            InitializeComponent();
            _owner = new Users();
        }

        public void SetOwner(Users setUser)
        {
            _owner = setUser;
        }

        private void ChipClick()
        {
            using var addStore = new AddStoreForm();
            addStore.SetOwner(_owner);
            addStore.ShowDialog();
        }

        private void addStoreUserControl_Click(object sender, EventArgs e)
        {
            ChipClick();
        }

        private void storeImagePictureBox_Click(object sender, EventArgs e)
        {
            ChipClick();
        }

        private void storeNameLabel_Click(object sender, EventArgs e)
        {
            ChipClick();
        }
    }
}
