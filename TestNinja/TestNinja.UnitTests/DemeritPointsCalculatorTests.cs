using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        //Name your test using the following convention:
        //[MethodName]_[Scenario]_[ExpectedBehavior]

        private DemeritPointsCalculator _calculator;

        [SetUp]
        public void SetUp()
        {
            _calculator = new DemeritPointsCalculator();
        }

        [Test]
        [TestCase(301)]
        [TestCase(-1)]
        public void CalculateDemeritPoints_SpeedIsOutOfRange_ReturnsArgumentOutOfRangeException(int speed)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _calculator.CalculateDemeritPoints(speed));
        }

        [Test]
        [TestCase(60, 0)]
        [TestCase(65, 0)]
        [TestCase(70, 1)]
        [TestCase(300, 47)]
        [TestCase(69, 0)]
        public void CalculateDemeritPoints_SpeedIsWithinRange_ReturnsDemeritPoints(int speed, int expectedResult)
        {
            Assert.That(() => _calculator.CalculateDemeritPoints(speed), Is.EqualTo(expectedResult));
        }
    }
}
