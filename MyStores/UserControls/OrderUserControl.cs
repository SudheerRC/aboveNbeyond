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
            mainPanel.Visible = false;
            listPanel.Visible = true;
            finalListPanelButton.Text = "Receive Order";
            panelHeadingLabel.Text = "Please select an Order from the list below";

        }

        private void receiveOrderButton_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = false;
            listPanel.Visible = true;
            finalListPanelButton.Text = "Receive Order";
            panelHeadingLabel.Text = "Please select an Order from the list below";
        }
    }
}
