using System.ComponentModel.DataAnnotations;

namespace MyStores.Model
{
    public class Users
    {
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _password;
        private string _phoneNumber;

        public int UserId { get; set; }

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Email cannot be empty");
                }
                _email = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Password cannot be empty");
                }
                _password = value;
            }
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name cannot be empty");
                }
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name cannot be empty");
                }
                _lastName = value;
            }
        }

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

        public DateTime DOB { get; set; }

        public string Gender { get; set; }

        public string StreetAddress { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public string Country { get; set; }

    }
}
