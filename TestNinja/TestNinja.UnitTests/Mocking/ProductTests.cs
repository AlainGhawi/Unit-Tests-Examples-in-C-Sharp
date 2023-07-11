using NUnit.Framework;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    internal class ProductTests
    {
        [Test]
        public void GetPrice_ForGoldCustomer_ShouldApply30PercentDiscount()
        {
            var product = new Product { ListPrice = 100 };

            var result  = product.GetPrice(new Customer { IsGold = true });

            Assert.That(result, Is.EqualTo(70));
        }
    }
}
