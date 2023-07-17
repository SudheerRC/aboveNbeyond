using MyStores.Model;

namespace MyStoresTests
{
    public class ProductTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestShouldCreateValidEmptyProductObject()
        {
            var testProduct = new Product();
            Assert.That(testProduct.Id, Is.Zero);
            Assert.That(testProduct.Name, Is.Null);
            Assert.That(testProduct.Description, Is.Null);
            Assert.That(testProduct.ProductSize, Is.Null);
            Assert.That(testProduct.DepartmentName, Is.Null);
            Assert.That(testProduct.SellingPrice, Is.Zero);
            Assert.That(testProduct.Barcode, Is.Null);
            Assert.That(testProduct.Image, Is.Null);
        }

        [Test]
        public void TestShouldCreateValidProductObject()
        {
            var testProduct = new Product()
            {
                Id = 1,
                Name = "Sock",
                Description = "The piece of cloth we wear on our legs",
                ProductSize = "2",
                Barcode = "051237822211",
                DepartmentName = "General",
                SellingPrice = 9.99
            };

            Assert.That(testProduct.Id, Is.EqualTo(1));
            Assert.That(testProduct.Name, Is.EqualTo("Sock"));
            Assert.That(testProduct.Description, Is.EqualTo("The piece of cloth we wear on our legs"));
            Assert.That(testProduct.ProductSize, Is.EqualTo("2"));
            Assert.That(testProduct.DepartmentName, Is.EqualTo("General"));
            Assert.That(testProduct.SellingPrice, Is.EqualTo(9.99));
            Assert.That(testProduct.Barcode, Is.EqualTo("051237822211"));
            Assert.That(testProduct.Image, Is.Null);
        }

        [Test]
        public void TestShouldThrowErrorForNegativeSellingPrice()
        {
            var testProduct = new Product();
            Assert.Throws<ArgumentOutOfRangeException>(() =>
                testProduct.SellingPrice = -2);
        }

        [Test]
        public void TestShouldCreateValidObjectForZeroSellingPrice()
        {
            var testProduct = new Product()
            {
                SellingPrice = 0
            };
            Assert.That(testProduct.SellingPrice, Is.Zero);

            Assert.That(testProduct.Id, Is.Zero);
            Assert.That(testProduct.Name, Is.Null);
            Assert.That(testProduct.Description, Is.Null);
            Assert.That(testProduct.ProductSize, Is.Null);
            Assert.That(testProduct.DepartmentName, Is.Null);
            Assert.That(testProduct.Barcode, Is.Null);
            Assert.That(testProduct.Image, Is.Null);
        }

        [Test]
        public void TestShouldCreateValidObjectWithPositiveSellingPrice()
        {
            var testProduct = new Product()
            {
                SellingPrice = 9.99
            };
            Assert.That(testProduct.SellingPrice, Is.EqualTo(9.99));

            Assert.That(testProduct.Id, Is.Zero);
            Assert.That(testProduct.Name, Is.Null);
            Assert.That(testProduct.Description, Is.Null);
            Assert.That(testProduct.ProductSize, Is.Null);
            Assert.That(testProduct.DepartmentName, Is.Null);
            Assert.That(testProduct.Barcode, Is.Null);
            Assert.That(testProduct.Image, Is.Null);
        }

        [Test]
        public void TestShouldThrowErrorForEmptyBarcode()
        {
            var testProduct = new Product();
            Assert.Throws<ArgumentNullException>(() =>
                testProduct.Barcode = "");
        }

        [Test]
        public void TestShouldCreateValidObjectWithValidBarcode()
        {
            var testProduct = new Product()
            {
                Barcode = "07812245"
            };
            Assert.That(testProduct.Barcode, Is.EqualTo("07812245"));

            Assert.That(testProduct.Id, Is.Zero);
            Assert.That(testProduct.Name, Is.Null);
            Assert.That(testProduct.Description, Is.Null);
            Assert.That(testProduct.ProductSize, Is.Null);
            Assert.That(testProduct.SellingPrice, Is.Zero);
            Assert.That(testProduct.DepartmentName, Is.Null);
            Assert.That(testProduct.Image, Is.Null);
        }
    }
}