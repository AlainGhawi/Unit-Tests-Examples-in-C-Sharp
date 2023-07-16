using Moq;
using NUnit.Framework;
using System.Net;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class InstallerHelperTests
    {
        private Mock<IFileDownloader> _fileDownloader;
        private InstallerHelper _installerHelper;
        [SetUp]
        public void SetUp()
        {
            _fileDownloader = new Mock<IFileDownloader>();
            _installerHelper = new InstallerHelper(_fileDownloader.Object);
        }

        [Test]
        public void DownloadInstaller_DownloadFails_ReturnsFalse()
        {
            _fileDownloader
                .Setup(fd => fd.DownloadFile(It.IsAny<string>(), It.IsAny<string>()))
                .Throws<WebException>();

            var result = _installerHelper.DownloadInstaller("customer", "installer");

            Assert.IsFalse(result);
        }

        [Test]
        public void DownloadInstaller_DownloadComplete_ReturnsTrue()
        {
            _fileDownloader
                .Setup(fd => fd.DownloadFile(It.IsAny<string>(), It.IsAny<string>()));

            var result = _installerHelper.DownloadInstaller("customer", "installer");

            Assert.IsTrue(result);
        }
    }
}
