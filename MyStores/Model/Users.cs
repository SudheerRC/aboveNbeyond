using System.ComponentModel.DataAnnotations;

namespace MyStores.Model
{
    public class Users
    {
        public int UserId { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        public DateTime DOB { get; set; }

        public string Gender { get; set; }

        public string StreetAddress { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public string Country { get; set; }

    }
}
