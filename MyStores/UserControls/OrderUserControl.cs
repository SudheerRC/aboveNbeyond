namespace MyStores.UserControls
{
    public partial class OrderUserControl : UserControl
    {
        public OrderUserControl()
        {
            InitializeComponent();
        }

        private void placeOrderButton_Click(object sender, EventArgs e)
        {
            finalListPanelButton.Text = @"Place Order";
            panelHeadingLabel.Text = @"Please select a Vendor from this list to place an order";

            mainPanel.Visible = false;
            listPanel.Visible = true;

        }

        private void receiveOrderButton_Click(object sender, EventArgs e)
        {
            finalListPanelButton.Text = @"Receive Order";
            panelHeadingLabel.Text = @"Please select an Order from the list below";

            mainPanel.Visible = false;
            listPanel.Visible = true;
        }

        private void backButton_Click(object sender, EventArgs e)
        {

        }

        private void finalListPanelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
