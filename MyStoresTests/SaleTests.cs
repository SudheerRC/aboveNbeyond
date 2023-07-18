using MyStores.Model;

namespace MyStoresTests
{
    public class SaleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestShouldCreateEmptySaleObject()
        {
            var testSale = new Sale();
            
            Assert.That(testSale.SaleId, Is.Zero);
            Assert.That(testSale.StoreId, Is.Zero);
            Assert.That(testSale.SaleDateTime, Is.EqualTo(DateTime.MinValue));
            Assert.That(testSale.PaymentType, Is.Null);
            Assert.That(testSale.Total, Is.Zero);
            Assert.That(testSale.Tax, Is.Zero);
            Assert.That(testSale.Items, Is.Null);
        }

        [Test]
        public void TestShouldCreateValidSaleObject()
        {
            var testSale = new Sale()
            {
                SaleId = 1,
                StoreId = 2,
                SaleDateTime = DateTime.Today,
                PaymentType = "Credit card",
                Total = 12.43,
                Tax = 2.23,
                Items = new List<InventoryItem>()
            };

            Assert.That(testSale.SaleId, Is.EqualTo(1));
            Assert.That(testSale.StoreId, Is.EqualTo(2));
            Assert.That(testSale.SaleDateTime, Is.EqualTo(DateTime.Today));
            Assert.That(testSale.PaymentType, Is.EqualTo("Credit card"));
            Assert.That(testSale.Total, Is.EqualTo(12.43));
            Assert.That(testSale.Tax, Is.EqualTo(2.23));
            Assert.That(testSale.Items.Count, Is.Zero);
        }

        [Test]
        public void TestShouldThrowErrorForTotalNegative()
        {
            var testSale = new Sale()
            {
                SaleId = 1,
                StoreId = 2,
                SaleDateTime = DateTime.Today,
                PaymentType = "Credit card",
                Tax = 2.23,
                Items = new List<InventoryItem>()
            };

            Assert.That(testSale.SaleId, Is.EqualTo(1));
            Assert.That(testSale.StoreId, Is.EqualTo(2));
            Assert.That(testSale.SaleDateTime, Is.EqualTo(DateTime.Today));
            Assert.That(testSale.PaymentType, Is.EqualTo("Credit card"));
            Assert.That(testSale.Tax, Is.EqualTo(2.23));
            Assert.That(testSale.Items.Count, Is.Zero);

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                testSale.Total = -10.2;
            });
        }

        [Test]
        public void TestShouldThrowErrorForTaxNegative()
        {
            var testSale = new Sale()
            {
                SaleId = 1,
                StoreId = 2,
                SaleDateTime = DateTime.Today,
                PaymentType = "Credit card",
                Total = 12.43,
                Items = new List<InventoryItem>()
            };

            Assert.That(testSale.SaleId, Is.EqualTo(1));
            Assert.That(testSale.StoreId, Is.EqualTo(2));
            Assert.That(testSale.SaleDateTime, Is.EqualTo(DateTime.Today));
            Assert.That(testSale.PaymentType, Is.EqualTo("Credit card"));
            Assert.That(testSale.Total, Is.EqualTo(12.43));
            Assert.That(testSale.Items.Count, Is.Zero);

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                testSale.Tax = -1.4;
            });
        }
    }
}
