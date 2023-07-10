using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        //Name your test using the following convention:
        //[MethodName]_[Scenario]_[ExpectedBehavior]

        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            var logger = new ErrorLogger();

            logger.Log("Test error");

            Assert.That(logger.LastError, Is.EqualTo("Test error"));
        }
    }
}
