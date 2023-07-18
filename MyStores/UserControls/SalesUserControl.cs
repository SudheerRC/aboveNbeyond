using MyStores.Controller;
using MyStores.Model;
using MyStores.View;

namespace MyStores.UserControls
{
    public partial class SalesUserControl : UserControl
    {
        private int _storeId;
        private readonly MyStoresController _controller;

        public SalesUserControl()
        {
            InitializeComponent();
            _controller = new MyStoresController();
        }

        public void setStoreId(int storeId)
        {
            this._storeId = storeId;
        }

        public void ResetUserControl()
        {

            LoadRangeComboBox();

            List<Sale> saleList = _controller.GetRecentSalesByStoreId(_storeId);

            CheckAndLoadGridView(saleList, "There are no sales yet for this store!");
        }

        private void CheckAndLoadGridView(List<Sale> saleList, string errorMessage)
        {
            if (saleList.Count > 0)
            {
                mainDataGridView.Visible = true;
                listOfSalesLabel.Visible = true;
                viewSaleButton.Visible = true;
                noSalesMessageLabel.Visible = false;

                LoadDataGridView(saleList);
            }
            else
            {
                noSalesMessageLabel.Visible = true;
                mainDataGridView.Visible = false;
                listOfSalesLabel.Visible = false;
                viewSaleButton.Visible = false;

                noSalesMessageLabel.Text = errorMessage;
            }
        }

        private void LoadDataGridView(List<Sale> saleList)
        {
            mainDataGridView.Rows.Clear();

            foreach (Sale currentSale in saleList)
            {
                DataGridViewRow currentRow = mainDataGridView.Rows[mainDataGridView.Rows.Add()];
                currentRow.Cells[saleId.Index].Value = currentSale.SaleId;
                currentRow.Cells[saleDateTime.Index].Value = currentSale.SaleDateTime.ToShortDateString();
                currentRow.Cells[saleTotal.Index].Value = currentSale.Total;
                currentRow.Cells[saleTax.Index].Value = currentSale.Tax;
                currentRow.Cells[paymentType.Index].Value = currentSale.PaymentType;
            }
        }

        private void SalesUserControl_Load(object sender, EventArgs e)
        {
            ResetUserControl();
        }

        private void LoadRangeComboBox()
        {
            rangeComboBox.DataSource = null;

            var rangeList = new List<string>
            {
                "This Week",
                "This Month",
                "This Year"
            };

            rangeComboBox.DataSource = rangeList;
        }

        private void viewSaleButton_Click(object sender, EventArgs e)
        {
            if (mainDataGridView.SelectedRows[0] != null)
            {
                var saleId = Convert.ToInt32(mainDataGridView.SelectedRows[0].Cells[0].Value.ToString());

                var invoiceForm = new InvoiceForm();
                invoiceForm.setSaleId(saleId);
                invoiceForm.ShowDialog();
            }

        }

        private void mainDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            viewSaleButton.Enabled = true;
        }

        private void dateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            fromDateTimePicker.Enabled = true;

            rangeComboBox.Enabled = false;

            searchButton.Enabled = true;
        }

        private void rangeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            rangeComboBox.Enabled = true;

            fromDateTimePicker.Enabled = false;
            toDateTimePicker.Enabled = false;

            searchButton.Enabled = true;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var fromDate = new DateTime();
            var toDate = new DateTime();

            if (dateRadioButton.Checked)
            {
                SetDates(out fromDate, out toDate);
            }
            else if (rangeRadioButton.Checked)
            {
                SetDateRange(out toDate, out fromDate);
            }

            List<Sale> saleList = _controller.GetSalesByStoreIdBetweenDates(_storeId, fromDate, toDate);

            CheckAndLoadGridView(saleList, "There are no sales in the given date range!");
        }

        private void SetDates(out DateTime fromDate, out DateTime toDate)
        {
            fromDate = fromDateTimePicker.Value.AddDays(-1);

            if (toDateTimePicker.Enabled)
            {
                toDate = toDateTimePicker.Value.AddDays(1);
            }
            else
            {
                toDate = DateTime.Today.AddDays(1);
            }
        }

        private void SetDateRange(out DateTime toDate, out DateTime fromDate)
        {
            var range = rangeComboBox.SelectedItem as string;
            if (range != null)
            {
                if (range.Equals("This Week"))
                {
                    toDate = DateTime.Today.AddDays(1);
                    fromDate = toDate.AddDays(-8);
                }
                else if (range.Equals("This Month"))
                {
                    toDate = DateTime.Today.AddDays(1);
                    fromDate = toDate.AddMonths(-1);
                }
                else if (range.Equals("This Year"))
                {
                    toDate = DateTime.Today.AddDays(1);
                    fromDate = toDate.AddYears(-1);
                }
            }
        }

        private void FromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            toDateTimePicker.Enabled = true;
            toDateTimePicker.MinDate = fromDateTimePicker.Value;
        }
    }
}
