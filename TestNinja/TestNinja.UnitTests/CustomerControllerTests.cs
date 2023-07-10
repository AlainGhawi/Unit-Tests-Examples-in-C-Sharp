using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        //Name your test using the following convention:
        //[MethodName]_[Scenario]_[ExpectedBehavior]

        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            //Arrange
            var controller = new CustomerController();

            //Act
            var result = controller.GetCustomer(0);

            //Assert
            //NotFound exact type
            Assert.That(result, Is.TypeOf<NotFound>());

            //NotFound or one of its derivatives (e.g. DocumentNotFound inheriting NotFound)
            Assert.That(result, Is.InstanceOf<NotFound>());
        }

        [Test]
        public void GetCustomer_IdIsNotZero_ReturnOk()
        {
            //Arrange
            var controller = new CustomerController();

            //Act
            var result = controller.GetCustomer(1);

            //Assert
            Assert.That(result, Is.TypeOf<Ok>());
        }
    }
}
