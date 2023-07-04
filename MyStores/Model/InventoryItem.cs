namespace MyStores.Model
{
    public class InventoryItem
    {
        public int InventoryId { get; set; }

        public int VendorId { get; set; }

        public int Quantity { get; set; }

        public double SellingPrice { get; set; }

        public double PurchasePrice { get; set; }

        public Product? Item { get; set; }
    }
}
