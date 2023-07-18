using MyStores.Model;

namespace MyStoresTests
{
    public class OrderTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestShouldCreateEmptyOrderObject()
        {
            var testOrder = new Order();

            Assert.That(testOrder.OrderId, Is.Zero);
            Assert.That(testOrder.StoreId, Is.Zero);
            Assert.That(testOrder.UserId, Is.Zero);
            Assert.That(testOrder.VendorId, Is.Zero);
            Assert.That(testOrder.VendorName, Is.Null);
            Assert.That(testOrder.DeliveredDate, Is.EqualTo(DateOnly.FromDateTime(DateTime.MinValue)));
            Assert.That(testOrder.ExpectedDeliveryDate, Is.EqualTo(DateOnly.FromDateTime(DateTime.MinValue)));
            Assert.That(testOrder.OrderDate, Is.EqualTo(DateOnly.FromDateTime(DateTime.MinValue)));
            Assert.That(testOrder.InventoryItems, Is.Null);
        }

        [Test]
        public void TestShouldCreateValidOrderObject()
        {
            var testOrder = new Order()
            {
                OrderId= 1,
                StoreId = 2,
                UserId = 3,
                VendorId = 4,
                VendorName = "Coca-Cola",
                DeliveredDate = DateOnly.FromDateTime(Convert.ToDateTime("2023-07-21")),
                ExpectedDeliveryDate = DateOnly.FromDateTime(Convert.ToDateTime("2023-07-20")),
                OrderDate = DateOnly.FromDateTime(Convert.ToDateTime("2023-07-15")),
                InventoryItems = new List<InventoryItem>() 
            };

            Assert.That(testOrder.OrderId, Is.EqualTo(1));
            Assert.That(testOrder.StoreId, Is.EqualTo(2));
            Assert.That(testOrder.UserId, Is.EqualTo(3));
            Assert.That(testOrder.VendorId, Is.EqualTo(4));
            Assert.That(testOrder.VendorName, Is.EqualTo("Coca-Cola"));
            Assert.That(testOrder.DeliveredDate, Is.EqualTo(DateOnly.FromDateTime(Convert.ToDateTime("2023-07-21"))));
            Assert.That(testOrder.ExpectedDeliveryDate, Is.EqualTo(DateOnly.FromDateTime(Convert.ToDateTime("2023-07-20"))));
            Assert.That(testOrder.OrderDate, Is.EqualTo(DateOnly.FromDateTime(Convert.ToDateTime("2023-07-15"))));
            Assert.That(testOrder.InventoryItems.Count, Is.Zero);
        }

        [Test]
        public void TestShouldCreateValidOrderObjectWithSomeVariables()
        {
            var testOrder = new Order()
            {
                OrderId= 1,
                StoreId = 2,
                VendorId = 4,
                VendorName = "Coca-Cola",
                DeliveredDate = DateOnly.FromDateTime(Convert.ToDateTime("2023-07-21")),
                InventoryItems = new List<InventoryItem>()
            };

            Assert.That(testOrder.OrderId, Is.EqualTo(1));
            Assert.That(testOrder.StoreId, Is.EqualTo(2));
            Assert.That(testOrder.UserId, Is.Zero);
            Assert.That(testOrder.VendorId, Is.EqualTo(4));
            Assert.That(testOrder.VendorName, Is.EqualTo("Coca-Cola"));
            Assert.That(testOrder.DeliveredDate, Is.EqualTo(DateOnly.FromDateTime(Convert.ToDateTime("2023-07-21"))));
            Assert.That(testOrder.ExpectedDeliveryDate, Is.EqualTo(DateOnly.FromDateTime(DateTime.MinValue)));
            Assert.That(testOrder.OrderDate, Is.EqualTo(DateOnly.FromDateTime(DateTime.MinValue)));
            Assert.That(testOrder.InventoryItems.Count, Is.Zero);
        }
    }
}
