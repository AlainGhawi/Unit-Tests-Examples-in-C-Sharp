using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        //Name your test using the following convention:
        //[MethodName]_[Scenario]_[ExpectedBehavior]

        private FizzBuzz fizzBuzz;

        [SetUp] 
        public void SetUp() 
        { 
            fizzBuzz = new FizzBuzz();
        }

        [Test]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(7, "7")]
        public void GetOutput_WhenCalled_ReturnsStringFizz(int number, string expectedValue)
        {
            //Act
            var result = fizzBuzz.GetOutput(number);
            //Assert
            Assert.That(result, Is.EqualTo(expectedValue));
        }
    }
}
