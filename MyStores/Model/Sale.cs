namespace MyStores.Model
{
    public class Sale
    {
        public int SaleId { get; set; }

        public int StoreId { get; set; }

        public DateTime SaleDateTime { get; set; }

        public double Total { get; set;}

        public double Tax { get; set;}

        public string PaymentType { get; set;}

        public List<InventoryItem> Items { get; set; }

    }
}
