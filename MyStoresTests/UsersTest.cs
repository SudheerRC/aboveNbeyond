using MyStores.Model;

namespace MyStoresTests
{
    public class UsersTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestShouldCreateEmptyUserObject()
        {
            var testUser = new Users();
            Assert.That(testUser.UserId, Is.Zero);
            Assert.That(testUser.Email, Is.Null);
            Assert.That(testUser.Password, Is.Null);
            Assert.That(testUser.FirstName, Is.Null);
            Assert.That(testUser.LastName, Is.Null);
            Assert.That(testUser.City, Is.Null);
            Assert.That(testUser.Country, Is.Null);
            Assert.That(testUser.DOB, Is.EqualTo(DateTime.MinValue));
            Assert.That(testUser.Gender, Is.Null);
            Assert.That(testUser.PhoneNumber, Is.Null);
            Assert.That(testUser.State, Is.Null);
            Assert.That(testUser.StreetAddress, Is.Null);
            Assert.Null(testUser.ZipCode);
        }

        [Test]
        public void TestShouldValidUserObject()
        {
            var testUser = new Users()
            {
                UserId = 1,
                Email = "abc@gmail.com",
                Password = "abc123",
                FirstName = "Abc",
                LastName = "Xyz",
                City = "Carrollton",
                Country = "USSR",
                DOB = Convert.ToDateTime("1999-07-21"),
                Gender = "AGender",
                PhoneNumber = "8912345670",
                State = "Georgia",
                StreetAddress = "Maple Street",
                ZipCode = "30117"
            };

            Assert.That(testUser.UserId, Is.EqualTo(1));
            Assert.That(testUser.Email, Is.EqualTo("abc@gmail.com"));
            Assert.That(testUser.Password, Is.EqualTo("abc123"));
            Assert.That(testUser.FirstName, Is.EqualTo("Abc"));
            Assert.That(testUser.LastName, Is.EqualTo("Xyz"));
            Assert.That(testUser.City, Is.EqualTo("Carrollton"));
            Assert.That(testUser.Country, Is.EqualTo("USSR"));
            Assert.That(testUser.DOB, Is.EqualTo(Convert.ToDateTime("1999-07-21")));
            Assert.That(testUser.Gender, Is.EqualTo("AGender"));
            Assert.That(testUser.PhoneNumber, Is.EqualTo("8912345670"));
            Assert.That(testUser.State, Is.EqualTo("Georgia"));
            Assert.That(testUser.StreetAddress, Is.EqualTo("Maple Street"));
            Assert.That(testUser.ZipCode, Is.EqualTo("30117"));
        }

        [Test]
        public void TestShouldThrowErrorWhenEmailIsNull()
        {
            var testUser = new Users()
            {
                UserId = 1,
                Password = "abc123",
                FirstName = "Abc",
                LastName = "Xyz",
                City = "Carrollton",
                Country = "USSR",
                DOB = Convert.ToDateTime("1999-07-21"),
                Gender = "AGender",
                PhoneNumber = "8912345670",
                State = "Georgia",
                StreetAddress = "Maple Street",
                ZipCode = "30117"
            };

            Assert.That(testUser.UserId, Is.EqualTo(1));
            Assert.That(testUser.Password, Is.EqualTo("abc123"));
            Assert.That(testUser.FirstName, Is.EqualTo("Abc"));
            Assert.That(testUser.LastName, Is.EqualTo("Xyz"));
            Assert.That(testUser.City, Is.EqualTo("Carrollton"));
            Assert.That(testUser.Country, Is.EqualTo("USSR"));
            Assert.That(testUser.DOB, Is.EqualTo(Convert.ToDateTime("1999-07-21")));
            Assert.That(testUser.Gender, Is.EqualTo("AGender"));
            Assert.That(testUser.PhoneNumber, Is.EqualTo("8912345670"));
            Assert.That(testUser.State, Is.EqualTo("Georgia"));
            Assert.That(testUser.StreetAddress, Is.EqualTo("Maple Street"));
            Assert.That(testUser.ZipCode, Is.EqualTo("30117"));

            Assert.Throws<ArgumentNullException>(() =>
            {
                testUser.Email = "";
            });
        }

        [Test]
        public void TestShouldThrowErrorWhenPasswordIsNull()
        {
            var testUser = new Users()
            {
                UserId = 1,
                Email = "abc@gmail.com",
                FirstName = "Abc",
                LastName = "Xyz",
                City = "Carrollton",
                Country = "USSR",
                DOB = Convert.ToDateTime("1999-07-21"),
                Gender = "AGender",
                PhoneNumber = "8912345670",
                State = "Georgia",
                StreetAddress = "Maple Street",
                ZipCode = "30117"
            };

            Assert.That(testUser.UserId, Is.EqualTo(1));
            Assert.That(testUser.Email, Is.EqualTo("abc@gmail.com"));
            Assert.That(testUser.FirstName, Is.EqualTo("Abc"));
            Assert.That(testUser.LastName, Is.EqualTo("Xyz"));
            Assert.That(testUser.City, Is.EqualTo("Carrollton"));
            Assert.That(testUser.Country, Is.EqualTo("USSR"));
            Assert.That(testUser.DOB, Is.EqualTo(Convert.ToDateTime("1999-07-21")));
            Assert.That(testUser.Gender, Is.EqualTo("AGender"));
            Assert.That(testUser.PhoneNumber, Is.EqualTo("8912345670"));
            Assert.That(testUser.State, Is.EqualTo("Georgia"));
            Assert.That(testUser.StreetAddress, Is.EqualTo("Maple Street"));
            Assert.That(testUser.ZipCode, Is.EqualTo("30117"));

            Assert.Throws<ArgumentNullException>(() =>
            {
                testUser.Password = "";
            });
        }

        [Test]
        public void TestShouldThrowErrorWhenFirstNameIsNull()
        {
            var testUser = new Users()
            {
                UserId = 1,
                Email = "abc@gmail.com",
                Password = "abc123",
                LastName = "Xyz",
                City = "Carrollton",
                Country = "USSR",
                DOB = Convert.ToDateTime("1999-07-21"),
                Gender = "AGender",
                PhoneNumber = "8912345670",
                State = "Georgia",
                StreetAddress = "Maple Street",
                ZipCode = "30117"
            };

            Assert.That(testUser.UserId, Is.EqualTo(1));
            Assert.That(testUser.Email, Is.EqualTo("abc@gmail.com"));
            Assert.That(testUser.Password, Is.EqualTo("abc123"));
            Assert.That(testUser.LastName, Is.EqualTo("Xyz"));
            Assert.That(testUser.City, Is.EqualTo("Carrollton"));
            Assert.That(testUser.Country, Is.EqualTo("USSR"));
            Assert.That(testUser.DOB, Is.EqualTo(Convert.ToDateTime("1999-07-21")));
            Assert.That(testUser.Gender, Is.EqualTo("AGender"));
            Assert.That(testUser.PhoneNumber, Is.EqualTo("8912345670"));
            Assert.That(testUser.State, Is.EqualTo("Georgia"));
            Assert.That(testUser.StreetAddress, Is.EqualTo("Maple Street"));
            Assert.That(testUser.ZipCode, Is.EqualTo("30117"));

            Assert.Throws<ArgumentNullException>(() =>
            {
                testUser.FirstName = "";
            });
        }

        [Test]
        public void TestShouldThrowErrorWhenLastNameIsNull()
        {
            var testUser = new Users()
            {
                UserId = 1,
                Email = "abc@gmail.com",
                Password = "abc123",
                FirstName = "Abc",
                City = "Carrollton",
                Country = "USSR",
                DOB = Convert.ToDateTime("1999-07-21"),
                Gender = "AGender",
                PhoneNumber = "8912345670",
                State = "Georgia",
                StreetAddress = "Maple Street",
                ZipCode = "30117"
            };

            Assert.That(testUser.UserId, Is.EqualTo(1));
            Assert.That(testUser.Email, Is.EqualTo("abc@gmail.com"));
            Assert.That(testUser.Password, Is.EqualTo("abc123"));
            Assert.That(testUser.FirstName, Is.EqualTo("Abc"));
            Assert.That(testUser.City, Is.EqualTo("Carrollton"));
            Assert.That(testUser.Country, Is.EqualTo("USSR"));
            Assert.That(testUser.DOB, Is.EqualTo(Convert.ToDateTime("1999-07-21")));
            Assert.That(testUser.Gender, Is.EqualTo("AGender"));
            Assert.That(testUser.PhoneNumber, Is.EqualTo("8912345670"));
            Assert.That(testUser.State, Is.EqualTo("Georgia"));
            Assert.That(testUser.StreetAddress, Is.EqualTo("Maple Street"));
            Assert.That(testUser.ZipCode, Is.EqualTo("30117"));

            Assert.Throws<ArgumentNullException>(() =>
            {
                testUser.LastName = "";
            });
        }

        [Test]
        public void TestShouldThrowErrorWhenPhoneIsNull()
        {
            var testUser = new Users()
            {
                UserId = 1,
                Email = "abc@gmail.com",
                Password = "abc123",
                FirstName = "Abc",
                LastName = "Xyz",
                City = "Carrollton",
                Country = "USSR",
                DOB = Convert.ToDateTime("1999-07-21"),
                Gender = "AGender",
                State = "Georgia",
                StreetAddress = "Maple Street",
                ZipCode = "30117"
            };

            Assert.That(testUser.UserId, Is.EqualTo(1));
            Assert.That(testUser.Email, Is.EqualTo("abc@gmail.com"));
            Assert.That(testUser.Password, Is.EqualTo("abc123"));
            Assert.That(testUser.FirstName, Is.EqualTo("Abc"));
            Assert.That(testUser.LastName, Is.EqualTo("Xyz"));
            Assert.That(testUser.City, Is.EqualTo("Carrollton"));
            Assert.That(testUser.Country, Is.EqualTo("USSR"));
            Assert.That(testUser.DOB, Is.EqualTo(Convert.ToDateTime("1999-07-21")));
            Assert.That(testUser.Gender, Is.EqualTo("AGender"));
            Assert.That(testUser.State, Is.EqualTo("Georgia"));
            Assert.That(testUser.StreetAddress, Is.EqualTo("Maple Street"));
            Assert.That(testUser.ZipCode, Is.EqualTo("30117"));

            Assert.Throws<ArgumentNullException>(() =>
            {
                testUser.PhoneNumber = "";
            });
        }

        [Test]
        public void TestShouldThrowErrorWhenPhoneLengthIsNotTen()
        {
            var testUser = new Users()
            {
                UserId = 1,
                Email = "abc@gmail.com",
                Password = "abc123",
                FirstName = "Abc",
                LastName = "Xyz",
                City = "Carrollton",
                Country = "USSR",
                DOB = Convert.ToDateTime("1999-07-21"),
                Gender = "AGender",
                State = "Georgia",
                StreetAddress = "Maple Street",
                ZipCode = "30117"
            };

            Assert.That(testUser.UserId, Is.EqualTo(1));
            Assert.That(testUser.Email, Is.EqualTo("abc@gmail.com"));
            Assert.That(testUser.Password, Is.EqualTo("abc123"));
            Assert.That(testUser.FirstName, Is.EqualTo("Abc"));
            Assert.That(testUser.LastName, Is.EqualTo("Xyz"));
            Assert.That(testUser.City, Is.EqualTo("Carrollton"));
            Assert.That(testUser.Country, Is.EqualTo("USSR"));
            Assert.That(testUser.DOB, Is.EqualTo(Convert.ToDateTime("1999-07-21")));
            Assert.That(testUser.Gender, Is.EqualTo("AGender"));
            Assert.That(testUser.State, Is.EqualTo("Georgia"));
            Assert.That(testUser.StreetAddress, Is.EqualTo("Maple Street"));
            Assert.That(testUser.ZipCode, Is.EqualTo("30117"));

            Assert.Throws<ArgumentException>(() =>
            {
                testUser.PhoneNumber = "1234";
            });
        }
    }
}
