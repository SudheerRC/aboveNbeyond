using MyStores.Model;

namespace MyStoresTests
{
    public class StoreTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestShouldCreateEmptyStoreObject()
        {
            var testStore = new Store();
            Assert.That(testStore.Id, Is.Zero);
            Assert.That(testStore.OwnerId, Is.Zero);
            Assert.That(testStore.Name, Is.Null);
            Assert.That(testStore.City, Is.Null);
            Assert.That(testStore.StreetAddress, Is.Null);
            Assert.That(testStore.State, Is.Null);
            Assert.That(testStore.ZipCode, Is.Null);
            Assert.That(testStore.Country, Is.Null);
            Assert.That(testStore.Status, Is.False);
            Assert.That(testStore.Managers, Is.Null);
            Assert.That(testStore.Vendors, Is.Null);
            Assert.That(testStore.Inventory, Is.Null);
        }

        [Test]
        public void TestShouldCreateValidStoreObject()
        {
            var testStore = new Store()
            {
                Id = 1,
                OwnerId = 2,
                Name = "Georgia Wings",
                City = "Carrollton",
                StreetAddress = "Maple Street",
                State = "Georgia",
                ZipCode = "30118",
                Country = "USA",
                Status = true,
                Managers = new List<Users>(),
                Vendors = new List<Vendor>(),
                Inventory = new List<InventoryItem>()
            };

            Assert.That(testStore.Id, Is.EqualTo(1));
            Assert.That(testStore.OwnerId, Is.EqualTo(2));
            Assert.That(testStore.Name, Is.EqualTo("Georgia Wings"));
            Assert.That(testStore.City, Is.EqualTo("Carrollton"));
            Assert.That(testStore.StreetAddress, Is.EqualTo("Maple Street"));
            Assert.That(testStore.State, Is.EqualTo("Georgia"));
            Assert.That(testStore.ZipCode, Is.EqualTo("30118"));
            Assert.That(testStore.Country, Is.EqualTo("USA"));
            Assert.That(testStore.Status, Is.True);
            Assert.That(testStore.Managers.Count, Is.Zero);
            Assert.That(testStore.Vendors.Count, Is.Zero);
            Assert.That(testStore.Inventory.Count, Is.Zero);
        }

        [Test]
        public void TestShouldThrowErrorWithNameEmpty()
        {
            var testStore = new Store()
            {
                Id = 1,
                OwnerId = 2,
                City = "Carrollton",
                StreetAddress = "Maple Street",
                State = "Georgia",
                ZipCode = "30118",
                Country = "USA",
                Status = true,
                Managers = new List<Users>(),
                Vendors = new List<Vendor>(),
                Inventory = new List<InventoryItem>()
            };

            Assert.That(testStore.Id, Is.EqualTo(1));
            Assert.That(testStore.OwnerId, Is.EqualTo(2));
            Assert.That(testStore.City, Is.EqualTo("Carrollton"));
            Assert.That(testStore.StreetAddress, Is.EqualTo("Maple Street"));
            Assert.That(testStore.State, Is.EqualTo("Georgia"));
            Assert.That(testStore.ZipCode, Is.EqualTo("30118"));
            Assert.That(testStore.Country, Is.EqualTo("USA"));
            Assert.That(testStore.Status, Is.True);
            Assert.That(testStore.Managers.Count, Is.Zero);
            Assert.That(testStore.Vendors.Count, Is.Zero);
            Assert.That(testStore.Inventory.Count, Is.Zero);

            Assert.Throws<ArgumentNullException>(() =>
            {
                testStore.Name = "";
            });
        }

        [Test]
        public void TestShouldThrowErrorWhenCityEmpty()
        {
            var testStore = new Store()
            {
                Id = 1,
                OwnerId = 2,
                Name = "Georgia Wings",
                StreetAddress = "Maple Street",
                State = "Georgia",
                ZipCode = "30118",
                Country = "USA",
                Status = true,
                Managers = new List<Users>(),
                Vendors = new List<Vendor>(),
                Inventory = new List<InventoryItem>()
            };

            Assert.That(testStore.Id, Is.EqualTo(1));
            Assert.That(testStore.OwnerId, Is.EqualTo(2));
            Assert.That(testStore.Name, Is.EqualTo("Georgia Wings"));
            Assert.That(testStore.StreetAddress, Is.EqualTo("Maple Street"));
            Assert.That(testStore.State, Is.EqualTo("Georgia"));
            Assert.That(testStore.ZipCode, Is.EqualTo("30118"));
            Assert.That(testStore.Country, Is.EqualTo("USA"));
            Assert.That(testStore.Status, Is.True);
            Assert.That(testStore.Managers.Count, Is.Zero);
            Assert.That(testStore.Vendors.Count, Is.Zero);
            Assert.That(testStore.Inventory.Count, Is.Zero);

            Assert.Throws<ArgumentNullException>(() =>
            {
                testStore.City = "";
            });
        }

        [Test]
        public void TestShouldThrowErrorWhenStateEmpty()
        {
            var testStore = new Store()
            {
                Id = 1,
                OwnerId = 2,
                Name = "Georgia Wings",
                City = "Carrollton",
                StreetAddress = "Maple Street",
                ZipCode = "30118",
                Country = "USA",
                Status = true,
                Managers = new List<Users>(),
                Vendors = new List<Vendor>(),
                Inventory = new List<InventoryItem>()
            };

            Assert.That(testStore.Id, Is.EqualTo(1));
            Assert.That(testStore.OwnerId, Is.EqualTo(2));
            Assert.That(testStore.Name, Is.EqualTo("Georgia Wings"));
            Assert.That(testStore.City, Is.EqualTo("Carrollton"));
            Assert.That(testStore.StreetAddress, Is.EqualTo("Maple Street"));
            Assert.That(testStore.ZipCode, Is.EqualTo("30118"));
            Assert.That(testStore.Country, Is.EqualTo("USA"));
            Assert.That(testStore.Status, Is.True);
            Assert.That(testStore.Managers.Count, Is.Zero);
            Assert.That(testStore.Vendors.Count, Is.Zero);
            Assert.That(testStore.Inventory.Count, Is.Zero);

            Assert.Throws<ArgumentNullException>(() =>
            {
                testStore.State = "";
            });
        }

    }
}
