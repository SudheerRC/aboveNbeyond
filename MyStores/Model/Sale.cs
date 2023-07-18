namespace MyStores.Model
{
    public class Sale
    {
        private double _total;
        private double _tax;

        public int SaleId { get; set; }

        public int StoreId { get; set; }

        public DateTime SaleDateTime { get; set; }

        public double Total
        {
            get
            {
                return _total;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Total price cannot be less than 0");
                }
                _total = value;
            }
        }

        public double Tax
        {
            get
            {
                return _tax;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Tax amount cannot be less than 0");
                }
                _tax = value;
            }
        }

        public string PaymentType { get; set;}

        public List<InventoryItem> Items { get; set; }

        public string StoreName { get; set; }

    }
}
