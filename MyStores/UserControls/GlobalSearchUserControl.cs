using MyStores.Controller;
using MyStores.Model;

namespace MyStores.UserControls
{
    public partial class GlobalSearchUserControl : UserControl
    {
        private readonly MyStoresController _controller;
        public GlobalSearchUserControl()
        {
            InitializeComponent();
            _controller = new MyStoresController();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            resultFlowLayoutPanel.Controls.Clear();
            if (!string.IsNullOrEmpty(searchTextBox.Text))
            {
                var inputText = searchTextBox.Text;

                List<Product> products = _controller.SearchProductWithProductName(inputText);
                List<Vendor> vendors = _controller.SearchVendorWithVendorName(inputText);
                List<Store> stores = _controller.SearchStoreWithStoreName(inputText);

                foreach (var currentStore in stores)
                {
                    var groupBox = CreateNewStoreGroupBox(currentStore);
                    groupBox.Text = "Store";

                    resultFlowLayoutPanel.Controls.Add(groupBox);
                }

                foreach (var currentProduct in products)
                {
                    var groupBox = CreateNewProductGroupBox(currentProduct);
                    groupBox.Text = "Product";

                    resultFlowLayoutPanel.Controls.Add(groupBox);
                }

                foreach (var currentVendor in vendors)
                {
                    var groupBox = CreateNewVendorGroupBox(currentVendor);
                    groupBox.Text = "Vendor";

                    resultFlowLayoutPanel.Controls.Add(groupBox);
                }
            }
        }

        private GroupBox CreateNewProductGroupBox(Product currentProduct)
        {
            var groupBox = new GroupBox();
            var linkLabel = new LinkLabel();
            var label = new Label();
            groupBox.ForeColor = invisibleGroupBox.ForeColor;
            groupBox.Size = invisibleGroupBox.Size;
            groupBox.Font = invisibleGroupBox.Font;

            linkLabel.ForeColor = invisibleLinkLabel.ForeColor;
            linkLabel.Font = invisibleLinkLabel.Font;
            linkLabel.VisitedLinkColor = invisibleLinkLabel.VisitedLinkColor;
            linkLabel.Location = invisibleLinkLabel.Location;
            linkLabel.AutoSize = true;
            linkLabel.LinkColor = invisibleLinkLabel.LinkColor;

            label.AutoSize = true;
            label.Location = invisibleLabel.Location;
            label.ForeColor = invisibleLabel.ForeColor;

            linkLabel.Name = Convert.ToString(currentProduct.Id);
            linkLabel.Text = currentProduct.Name;
            label.Text = currentProduct.DepartmentName;

            groupBox.Controls.Add(linkLabel);
            groupBox.Controls.Add(label);
            return groupBox;
        }

        private GroupBox CreateNewVendorGroupBox(Vendor currentVendor)
        {
            var groupBox = new GroupBox();
            var linkLabel = new LinkLabel();
            var label = new Label();
            groupBox.ForeColor = invisibleGroupBox.ForeColor;
            groupBox.Size = invisibleGroupBox.Size;
            groupBox.Font = invisibleGroupBox.Font;

            linkLabel.ForeColor = invisibleLinkLabel.ForeColor;
            linkLabel.Font = invisibleLinkLabel.Font;
            linkLabel.VisitedLinkColor = invisibleLinkLabel.VisitedLinkColor;
            linkLabel.Location = invisibleLinkLabel.Location;
            linkLabel.AutoSize = true;
            linkLabel.LinkColor = invisibleLinkLabel.LinkColor;

            label.AutoSize = true;
            label.Location = invisibleLabel.Location;
            label.ForeColor = invisibleLabel.ForeColor;

            linkLabel.Name = Convert.ToString(currentVendor.Id);
            linkLabel.Text = currentVendor.Name;
            label.Text = currentVendor.PhoneNumber;

            groupBox.Controls.Add(linkLabel);
            groupBox.Controls.Add(label);
            return groupBox;
        }

        private GroupBox CreateNewStoreGroupBox(Store currentStore)
        {
            var groupBox = new GroupBox();
            var linkLabel = new LinkLabel();
            var label = new Label();
            groupBox.ForeColor = invisibleGroupBox.ForeColor;
            groupBox.Size = invisibleGroupBox.Size;
            groupBox.Font = invisibleGroupBox.Font;

            linkLabel.ForeColor = invisibleLinkLabel.ForeColor;
            linkLabel.Font = invisibleLinkLabel.Font;
            linkLabel.VisitedLinkColor = invisibleLinkLabel.VisitedLinkColor;
            linkLabel.Location = invisibleLinkLabel.Location;
            linkLabel.AutoSize = true;
            linkLabel.LinkColor = invisibleLinkLabel.LinkColor;

            label.AutoSize = true;
            label.Location = invisibleLabel.Location;
            label.ForeColor = invisibleLabel.ForeColor;

            linkLabel.Name = Convert.ToString(currentStore.Id);
            linkLabel.Text = currentStore.Name;
            label.Text = currentStore.City;

            groupBox.Controls.Add(linkLabel);
            groupBox.Controls.Add(label);
            return groupBox;
        }

        private void GlobalSearchUserControl_Load(object sender, EventArgs e)
        {
            resultFlowLayoutPanel.Controls.Clear();
        }
    }
}
