using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Logger.Tests
{
    [TestClass]
    public class LogFactoryTests
    {
        [TestMethod]
        public void CreateLogger_ValidNameConfigured_Success()
        {
            // Arrange
            LogFactory logFactory = new LogFactory();
            logFactory.ConfigureFileLogger(@"C:\Users\Jenny Meadowcroft\Documents\Visual Studio 2019\Logs");
            BaseLogger logger = logFactory.CreateLogger("Logger1");

            // Act
            string expectedLoggerName = "Logger1";
            string actualLoggerName = logger.Name;

            // Assert
            Assert.AreEqual(expectedLoggerName, actualLoggerName);
        }


        [TestMethod]
        public void CreateLogger_NullNameConfigured_Success()
        {
            // Arrange
            LogFactory logFactory = new LogFactory();
            logFactory.ConfigureFileLogger(@"C:\Users\Jenny Meadowcroft\Documents\Visual Studio 2019\Logs");
            BaseLogger logger = logFactory.CreateLogger(null);

            // Act
            string expectedLoggerName = "";
            string actualLoggerName = logger.Name;

            // Assert
            Assert.AreEqual(expectedLoggerName, actualLoggerName);
        }

        [TestMethod]
        public void CreateLogger_ValidNameUnconfigured_Failure()
        {
            // Arrange
            LogFactory logFactory = new LogFactory();
            BaseLogger logger = logFactory.CreateLogger("Logger1");

            // Act

            // Assert
            Assert.IsNull(logger);
        }

        




    }
}
