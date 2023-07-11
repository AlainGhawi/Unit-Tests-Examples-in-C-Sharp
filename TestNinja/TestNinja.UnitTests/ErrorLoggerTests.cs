using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        //Name your test using the following convention:
        //[MethodName]_[Scenario]_[ExpectedBehavior]

        //SetUp
        private ErrorLogger _logger;

        [SetUp]
        public void SetUp()
        {
            _logger = new ErrorLogger();
        }

        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            _logger.Log("Test error");

            Assert.That(_logger.LastError, Is.EqualTo("Test error"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string error)
        {
            Assert.That(() => _logger.Log(error), Throws.ArgumentNullException);
        }
    }
}
