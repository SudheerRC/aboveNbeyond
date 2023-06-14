namespace MyStores.Model
{
    public class Store
    {
        public int Id { get; set; }

        public int OwnerId { get; set; }

        public string Name { get; set; }

        public List<Users>? Managers { get; set; }

        public List<InventoryItem>? Inventory { get; set; }

        public List<Vendor>? Vendors { get; set; }

        public string StreetAddress { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public string Country { get; set; }
    }
}
