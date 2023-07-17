using System.ComponentModel.DataAnnotations;

namespace MyStores.Model
{
    public class Vendor
    {
        private string _phoneNumber;
        private string _name;
        public int Id { get; set; }

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
                    throw new ArgumentNullException("Vendor name cannot be empty");
                }
                _name = value;
            }
        }

        public string StreetAddress { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public string Country { get; set; }

        [Phone]
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Phone number cannot be empty");
                }

                if (value.Length != 10)
                {
                    throw new ArgumentException("Phone number must be of 10 digits");
                }
                _phoneNumber = value;
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
