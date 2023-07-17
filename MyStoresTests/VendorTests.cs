using MyStores.Model;

namespace MyStoresTests
{
    public class VendorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestShouldCreateEmptyVendorObject()
        {
            var testVendor = new Vendor();

            Assert.That(testVendor.Id, Is.Zero);
            Assert.That(testVendor.Name, Is.Null);
            Assert.That(testVendor.State, Is.Null);
            Assert.That(testVendor.City, Is.Null);
            Assert.That(testVendor.Country, Is.Null);
            Assert.That(testVendor.PhoneNumber, Is.Null);
            Assert.That(testVendor.StreetAddress, Is.Null);
            Assert.That(testVendor.ZipCode, Is.Null);
            Assert.That(testVendor.ToString(), Is.Null);
        }

        [Test]
        public void TestShouldCreateValidVendorObject()
        {
            var testVendor = new Vendor()
            {
                Id = 1,
                Name = "Test",
                State = "Georgia",
                City = "Carrollton",
                Country = "USA",
                PhoneNumber = "1234567889",
                StreetAddress = "Maple Street",
                ZipCode = "30118",
            };

            Assert.That(testVendor.Id, Is.EqualTo(1));
            Assert.That(testVendor.Name, Is.EqualTo("Test"));
            Assert.That(testVendor.State, Is.EqualTo("Georgia"));
            Assert.That(testVendor.City, Is.EqualTo("Carrollton"));
            Assert.That(testVendor.Country, Is.EqualTo("USA"));
            Assert.That(testVendor.PhoneNumber, Is.EqualTo("1234567889"));
            Assert.That(testVendor.StreetAddress, Is.EqualTo("Maple Street"));
            Assert.That(testVendor.ZipCode, Is.EqualTo("30118"));
            Assert.That(testVendor.ToString(), Is.EqualTo("Test"));
        }

        [Test]
        public void TestShouldThrowErrorForNameEmpty()
        {
            var testVendor = new Vendor()
            {
                Id = 1,
                State = "Georgia",
                City = "Carrollton",
                Country = "USA",
                PhoneNumber = "1234567889",
                StreetAddress = "Maple Street",
                ZipCode = "30118",
            };

            Assert.That(testVendor.Id, Is.EqualTo(1));
            Assert.That(testVendor.State, Is.EqualTo("Georgia"));
            Assert.That(testVendor.City, Is.EqualTo("Carrollton"));
            Assert.That(testVendor.Country, Is.EqualTo("USA"));
            Assert.That(testVendor.PhoneNumber, Is.EqualTo("1234567889"));
            Assert.That(testVendor.StreetAddress, Is.EqualTo("Maple Street"));
            Assert.That(testVendor.ZipCode, Is.EqualTo("30118"));
            Assert.That(testVendor.ToString(), Is.Null);

            Assert.Throws<ArgumentNullException>(() =>
            {
                testVendor.Name = "";
            });
        }

        [Test]
        public void TestShouldThrowErrorForPhoneEmpty()
        {
            var testVendor = new Vendor()
            {
                Id = 1,
                Name = "Test",
                State = "Georgia",
                City = "Carrollton",
                Country = "USA",
                StreetAddress = "Maple Street",
                ZipCode = "30118",
            };

            Assert.That(testVendor.Id, Is.EqualTo(1));
            Assert.That(testVendor.Name, Is.EqualTo("Test"));
            Assert.That(testVendor.State, Is.EqualTo("Georgia"));
            Assert.That(testVendor.City, Is.EqualTo("Carrollton"));
            Assert.That(testVendor.Country, Is.EqualTo("USA"));
            Assert.That(testVendor.StreetAddress, Is.EqualTo("Maple Street"));
            Assert.That(testVendor.ZipCode, Is.EqualTo("30118"));
            Assert.That(testVendor.ToString(), Is.EqualTo("Test"));

            Assert.Throws<ArgumentNullException>(() =>
            {
                testVendor.PhoneNumber = "";
            });
        }

        [Test]
        public void TestShouldThrowErrorForPhoneNotTenDigits()
        {
            var testVendor = new Vendor()
            {
                Id = 1,
                Name = "Test",
                State = "Georgia",
                City = "Carrollton",
                Country = "USA",
                StreetAddress = "Maple Street",
                ZipCode = "30118",
            };

            Assert.That(testVendor.Id, Is.EqualTo(1));
            Assert.That(testVendor.Name, Is.EqualTo("Test"));
            Assert.That(testVendor.State, Is.EqualTo("Georgia"));
            Assert.That(testVendor.City, Is.EqualTo("Carrollton"));
            Assert.That(testVendor.Country, Is.EqualTo("USA"));
            Assert.That(testVendor.StreetAddress, Is.EqualTo("Maple Street"));
            Assert.That(testVendor.ZipCode, Is.EqualTo("30118"));
            Assert.That(testVendor.ToString(), Is.EqualTo("Test"));

            Assert.Throws<ArgumentException>(() =>
            {
                testVendor.PhoneNumber = "12345";
            });
        }
    }
}
