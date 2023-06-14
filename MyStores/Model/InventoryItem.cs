namespace MyStores.Model
{
    public class InventoryItem
    {
        public int VendorId { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }

        public Product? Item { get; set; }
    }
}
