using MyStores.Controller;
using MyStores.Model;
using MyStores.View;

namespace MyStores.UserControls.HomeUserControl
{
    public partial class HomeTabUserControl : UserControl
    {
        private Users _owner;
        private readonly MyStoresController _controller;

        public HomeTabUserControl()
        {
            InitializeComponent();
            _controller = new MyStoresController();
            _owner = new Users();
        }

        public void SetOwner(Users setUser)
        {
            _owner = setUser;
        }

        private void loadHome()
        {
            homeFlowLayoutPanel.Controls.Clear();

            List<Store> storeList = _controller.GetUserStores(_owner.UserId);

            homeFlowLayoutPanel.Controls.Add(AddStoreButton);

            for (int i = 0; i < storeList.Count; i++)
            {
                var storeButton = CreateCustomButton();
                storeButton.Text = storeList[i].Name;
                storeButton.Name = Convert.ToString(storeList[i].Id);

                homeFlowLayoutPanel.Controls.Add(storeButton);

                storeButton.Click += new EventHandler(StoreHomeChip_Click);
            }
        }

        private Button CreateCustomButton()
        {

            var newButton = new Button();

            newButton.Size = AddStoreButton.Size;
            newButton.BackColor = AddStoreButton.BackColor;
            newButton.ForeColor = AddStoreButton.ForeColor;
            newButton.FlatStyle = AddStoreButton.FlatStyle;
            newButton.TextAlign = AddStoreButton.TextAlign;
            newButton.Font = AddStoreButton.Font;
            newButton.TextImageRelation = AddStoreButton.TextImageRelation;
            newButton.FlatAppearance.BorderSize = AddStoreButton.FlatAppearance.BorderSize;
            newButton.Padding = AddStoreButton.Padding;

            newButton.Image = VipButton.Image;
            newButton.ImageAlign = AddStoreButton.ImageAlign;

            return newButton;
        }

        private void StoreHomeChip_Click(object sender, EventArgs e)
        {
            Button current = (Button)sender;
            int id = int.Parse(current.Name);
            string name = _controller.GetStoreName(id);

            mainStoreFrontUserControl.Visible = true;
            mainStoreFrontUserControl.SetStoreId(id);
            mainStoreFrontUserControl.BringToFront();
            mainStoreFrontUserControl.SetOwner(_owner);

        }

        private static string ManagersNames(List<Users>? managers, string managersNames)
        {
            if (managers != null && managers.Count == 1)
            {
                managersNames = managers[0].FirstName + " " + managers[0].LastName;
            }
            else if (managers != null)
            {
                for (int i = 1; i < managers.Count; i++)
                {
                    managersNames += ", " + managers[i].FirstName + " " + managers[i].LastName;
                }
            }

            return managersNames;
        }

        private void HomeTabUserControl_Load(object sender, EventArgs e)
        {
            loadHome();
        }

        private void AddStoreButton_Click(object sender, EventArgs e)
        {
            using var addStore = new AddStoreForm();
            addStore.SetOwner(_owner);
            addStore.ShowDialog();
            loadHome();
        }
    }
}
