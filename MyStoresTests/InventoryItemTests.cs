using MyStores.Model;

namespace MyStoresTests
{
    public class InventoryItemTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestShouldCreateEmptyItemObject()
        {
            var itemTest = new InventoryItem();

            Assert.That(itemTest.InventoryId, Is.Zero);
            Assert.That(itemTest.VendorId, Is.Zero);
            Assert.That(itemTest.SellingPrice, Is.Zero);
            Assert.That(itemTest.PurchasePrice, Is.Zero);
            Assert.That(itemTest.Quantity, Is.Zero);
            Assert.That(itemTest.MinQuantity, Is.Zero);
            Assert.That(itemTest.Discount, Is.Zero);
            Assert.That(itemTest.Status, Is.False);
            Assert.That(itemTest.Item, Is.Null);
        }

        [Test]
        public void TestShouldCreateValidInventoryItem()
        {
            var itemTest = new InventoryItem()
            {
                InventoryId = 1,
                VendorId = 2,
                SellingPrice = 3.8,
                PurchasePrice = 5.3,
                Quantity = 4,
                MinQuantity = 10,
                Discount = 3.2,
                Status = true,
                Item = new Product()
            };

            Assert.That(itemTest.InventoryId, Is.EqualTo(1));
            Assert.That(itemTest.VendorId, Is.EqualTo(2));
            Assert.That(itemTest.SellingPrice, Is.EqualTo(3.8));
            Assert.That(itemTest.PurchasePrice, Is.EqualTo(5.3));
            Assert.That(itemTest.Quantity, Is.EqualTo(4));
            Assert.That(itemTest.MinQuantity, Is.EqualTo(10));
            Assert.That(itemTest.Discount, Is.EqualTo(3.2));
            Assert.That(itemTest.Status, Is.True);
        }

        [Test]
        public void TestShouldThrowErrorForQuantityNegative()
        {
            var itemTest = new InventoryItem()
            {
                InventoryId = 1,
                VendorId = 2,
                SellingPrice = 3.8,
                PurchasePrice = 5.3,
                MinQuantity = 10,
                Discount = 3.2,
                Status = true,
                Item = new Product()
            };

            Assert.That(itemTest.InventoryId, Is.EqualTo(1));
            Assert.That(itemTest.VendorId, Is.EqualTo(2));
            Assert.That(itemTest.SellingPrice, Is.EqualTo(3.8));
            Assert.That(itemTest.PurchasePrice, Is.EqualTo(5.3));
            Assert.That(itemTest.MinQuantity, Is.EqualTo(10));
            Assert.That(itemTest.Discount, Is.EqualTo(3.2));
            Assert.That(itemTest.Status, Is.True);

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                itemTest.Quantity = -2;
            });
        }

        [Test]
        public void TestShouldThrowErrorForNegativeSellingPrice()
        {
            var itemTest = new InventoryItem()
            {
                InventoryId = 1,
                VendorId = 2,
                PurchasePrice = 5.3,
                Quantity = 4,
                MinQuantity = 10,
                Discount = 3.2,
                Status = true,
                Item = new Product()
            };

            Assert.That(itemTest.InventoryId, Is.EqualTo(1));
            Assert.That(itemTest.VendorId, Is.EqualTo(2));
            Assert.That(itemTest.PurchasePrice, Is.EqualTo(5.3));
            Assert.That(itemTest.Quantity, Is.EqualTo(4));
            Assert.That(itemTest.MinQuantity, Is.EqualTo(10));
            Assert.That(itemTest.Discount, Is.EqualTo(3.2));
            Assert.That(itemTest.Status, Is.True);

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                itemTest.SellingPrice = -3;
            });
        }

        [Test]
        public void TestShouldThrowErrorForNegativePurchasePrice()
        {
            var itemTest = new InventoryItem()
            {
                InventoryId = 1,
                VendorId = 2,
                SellingPrice = 3.8,
                Quantity = 4,
                MinQuantity = 10,
                Discount = 3.2,
                Status = true,
                Item = new Product()
            };

            Assert.That(itemTest.InventoryId, Is.EqualTo(1));
            Assert.That(itemTest.VendorId, Is.EqualTo(2));
            Assert.That(itemTest.SellingPrice, Is.EqualTo(3.8));
            Assert.That(itemTest.Quantity, Is.EqualTo(4));
            Assert.That(itemTest.MinQuantity, Is.EqualTo(10));
            Assert.That(itemTest.Discount, Is.EqualTo(3.2));
            Assert.That(itemTest.Status, Is.True);

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                itemTest.PurchasePrice = -2;
            });
        }

        [Test]
        public void TestShouldThrowErrorForNegativeDiscount()
        {
            var itemTest = new InventoryItem()
            {
                InventoryId = 1,
                VendorId = 2,
                SellingPrice = 3.8,
                PurchasePrice = 5.3,
                Quantity = 4,
                MinQuantity = 10,
                Status = true,
                Item = new Product()
            };

            Assert.That(itemTest.InventoryId, Is.EqualTo(1));
            Assert.That(itemTest.VendorId, Is.EqualTo(2));
            Assert.That(itemTest.SellingPrice, Is.EqualTo(3.8));
            Assert.That(itemTest.PurchasePrice, Is.EqualTo(5.3));
            Assert.That(itemTest.Quantity, Is.EqualTo(4));
            Assert.That(itemTest.MinQuantity, Is.EqualTo(10));
            Assert.That(itemTest.Status, Is.True);

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                itemTest.Discount = -0.2;
            });
        }

        [Test]
        public void TestShouldThrowErrorForNegativeMinQuantity()
        {
            var itemTest = new InventoryItem()
            {
                InventoryId = 1,
                VendorId = 2,
                SellingPrice = 3.8,
                PurchasePrice = 5.3,
                Quantity = 4,
                Discount = 3.2,
                Status = false,
                Item = new Product()
            };

            Assert.That(itemTest.InventoryId, Is.EqualTo(1));
            Assert.That(itemTest.VendorId, Is.EqualTo(2));
            Assert.That(itemTest.SellingPrice, Is.EqualTo(3.8));
            Assert.That(itemTest.PurchasePrice, Is.EqualTo(5.3));
            Assert.That(itemTest.Quantity, Is.EqualTo(4));
            Assert.That(itemTest.Discount, Is.EqualTo(3.2));
            Assert.That(itemTest.Status, Is.False);

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                itemTest.MinQuantity = -40;
            });
        }

    }
}
