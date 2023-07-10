using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        //Name your test using the following convention:
        //[MethodName]_[Scenario]_[ExpectedBehavior]

        //In NUnit we have 2 options:
        //SetUp attribute called before each test is run
        //TearDown for integration test to cleanup
        private Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        [Test]
        [Ignore("Description of why we disabled the test. This will show a yellow warning in the test explorer")]
        public void Add_WhenCalled_ReturnsSumOfArguments()
        {
            //Act
            var result = _math.Add(1, 2);
            //Assert
            Assert.That(result, Is.EqualTo(3));
        }

        //The test cases are only available in NUnit and not in MSTest
        //This is one of the advantages of NUnit
        [Test]
        [TestCase(1, 2, 2)]
        [TestCase(2, 1, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {
            //Act
            var result = _math.Max(a, b);
            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

    }
}
