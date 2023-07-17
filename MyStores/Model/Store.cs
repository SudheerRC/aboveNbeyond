namespace MyStores.Model
{
    public class Store
    {
        private string _name;
        private string _city;
        private string _state;

        public int Id { get; set; }

        public int OwnerId { get; set; }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Store name cannot be empty");
                }
                _name = value;
            }
        }

        public List<Users>? Managers { get; set; }

        public List<InventoryItem>? Inventory { get; set; }

        public List<Vendor>? Vendors { get; set; }

        public string StreetAddress { get; set; }

        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("City cannot be empty");
                }
                _city = value;
            }
        }

        public string State
        {
            get
            {
                return _state;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("State cannot be empty");
                }
                _state = value;
            }
        }

        public string ZipCode { get; set; }

        public string Country { get; set; }

        public bool Status { get; set; }
    }
}
