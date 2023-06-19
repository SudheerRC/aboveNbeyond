using MyStores.View;

namespace MyStores.UserControls
{
    public partial class AddStoreUserControl : UserControl
    {
        public AddStoreUserControl()
        {
            InitializeComponent();
        }

        private void chipClick()
        {
            using var addStore = new AddStoreForm();
            addStore.ShowDialog();
        }

        private void AddStoreUserControl_Click(object sender, EventArgs e)
        {
            chipClick();
        }

        private void storeImagePictureBox_Click(object sender, EventArgs e)
        {
            chipClick();
        }

        private void storeNameLabel_Click(object sender, EventArgs e)
        {
            chipClick();
        }
    }
}
