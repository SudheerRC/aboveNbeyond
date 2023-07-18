using MyStores.Controller;
using MyStores.Model;
using MyStores.View;

namespace MyStores.UserControls.HomeUserControl
{
    public partial class HomeTabUserControl : UserControl
    {
        private string _storeName;
        private Users _owner;
        private readonly MyStoresController _controller;

        public delegate void StatusUpdateHandler(object sender, EventArgs e);
        public event StatusUpdateHandler OnUpdateStatus;

        public HomeTabUserControl()
        {
            InitializeComponent();
            _controller = new MyStoresController();
            _owner = new Users();
        }

        public string StoreName { get; set; }

        public void SetOwner(Users setUser)
        {
            _owner = setUser;
        }

        private void UpdateStatus()
        {
            EventArgs args = EventArgs.Empty;

            OnUpdateStatus?.Invoke(this, args);
        }

        private void StoreFrontUserControl_OnUpdateStatus(object sender, EventArgs e)
        {
            StoreName = "My Stores";

            loadHome();
            UpdateStatus();
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
            mainStoreFrontUserControl.SetStoreHighlights(id);
            ShowStoreFrontUserControl(id);
            StoreName = name;
            UpdateStatus();
        }

        public void ShowStoreFrontUserControl(int id)
        {
            mainStoreFrontUserControl.SetStoreId(id);
            mainStoreFrontUserControl.BringToFront();
            mainStoreFrontUserControl.SetOwner(_owner);
            mainStoreFrontUserControl.Visible = true;
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
