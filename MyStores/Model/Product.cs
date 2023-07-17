namespace MyStores.Model
{
    public class Product
    {
        private double _sellingPrice;
        private string _barcode;
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ProductSize { get; set; }

        public string DepartmentName { get; set; }

        public double SellingPrice
        {
            get
            {
                return _sellingPrice;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Selling price should be a valid positive number");
                }
                _sellingPrice = value;
            }
        }

        public string Barcode
        {
            get
            {
                return _barcode;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Barcode cannot be empty");
                }
                _barcode = value;
            }
        }

        public byte[] Image { get; set; }

    }
}
