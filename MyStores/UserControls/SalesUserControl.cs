using MyStores.Controller;
using MyStores.Model;
using MyStores.View;
using System.Windows.Forms;

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

        private void loadDataGridView(List<Sale> saleList)
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
            List<Sale> saleList = _controller.GetRecentSalesByStoreId(_storeId);

            if (saleList != null && saleList.Count > 0)
            {
                noSalesMessageLabel.Visible = false;

                loadDataGridView(saleList);
            }
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
    }
}
