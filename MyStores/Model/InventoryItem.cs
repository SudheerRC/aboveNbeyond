namespace MyStores.Model
{
    public class InventoryItem
    {
        private int _quantity;
        private double _sellingPrice;
        private double _purchasePrice;
        private int _minQuantity;

        public int InventoryId { get; set; }

        public int VendorId { get; set; }

        public int Quantity
        {
            get
            {
                return _quantity;

            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Quantity should be a valid positive number");
                }
                _quantity = value;
            }
        }

        public int MinQuantity
        {
            get
            {
                return _minQuantity;

            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Min Preferred Quantity should be a valid positive number");
                }
                _minQuantity = value;
            }
        }

        public double SellingPrice
        {
            get
            {
                return _sellingPrice;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Selling price should be a valid positive number");
                }
                _sellingPrice = value;
            }
        }

        public double PurchasePrice
        {
            get
            {
                return _purchasePrice;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Purchase price should be a valid positive number");
                }
                _purchasePrice = value;
            }
        }

        public bool Status { get; set; }

        public Product? Item { get; set; }
    }
}
