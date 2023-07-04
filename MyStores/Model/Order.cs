namespace MyStores.Model
{
    public class Order
    {
        public int OrderId { get; set; }

        public int VendorId { get; set; }

        public int StoreId { get; set; }

        public int UserId { get; set; }

        public string VendorName { get; set; }

        public DateOnly OrderDate { get; set; }

        public DateOnly ExpectedDeliveryDate { get; set; }
        public DateOnly DeliveredDate { get; set; }

        public List<InventoryItem>? InventoryItems { get; set; }

        public override string ToString()
        {
            return OrderDate.ToShortDateString() + " | " + VendorName + " | " + OrderId.ToString();
        }
    }
}
