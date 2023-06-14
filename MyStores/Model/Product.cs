namespace MyStores.Model
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ProductSize { get; set; }

        public string DepartmentName { get; set; }

        public double SellingPrice { get; set; }

        public string Barcode { get; set; }

        public Image Image { get; set; }

    }
}
