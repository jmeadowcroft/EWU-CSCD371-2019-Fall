using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Logger.Tests
{
    [TestClass]
    public class BaseLoggerMixinsTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Error_WithNullLogger_ThrowsException()
        {
            // Arrange
            FileLogger logger = null;
            string[] parameters = { "one", "two", "three" };
            // Act
            logger.Error("", parameters);

            // Assert

        }

        [TestMethod]
        public void Error_WithOneParameter_LogsMessage()
        {
            // Arrange
            LogFactory logFactory = new LogFactory();
            logFactory.ConfigureFileLogger(@"C:\Users\Jenny Meadowcroft\Documents\Visual Studio 2019\Logs");
            BaseLogger logger = logFactory.CreateLogger("Logger1");
            string[] parameters = { "42" };

            // Act
            logger.Error("Thing to say", parameters);
            string current = DateTime.Now.ToString("g");
            string expectedLog = $"Error|Thing to say caused by 42|From BaseLoggerMixins|at {current}";
            string actualLog = ((FileLogger)logger).LastLog;
            // Assert

            Assert.AreEqual(expectedLog, actualLog);
        }

        [TestMethod]
        public void Error_WithMultipleParameters_LogsMessage()
        {
            // Arrange
            LogFactory logFactory = new LogFactory();
            logFactory.ConfigureFileLogger(@"C:\Users\Jenny Meadowcroft\Documents\Visual Studio 2019\Logs");
            BaseLogger logger = logFactory.CreateLogger("Logger1");
            string[] parameters = { "42", "43", "44" };

            // Act
            logger.Error("Thing to say", parameters);
            string current = DateTime.Now.ToString("g");
            string expectedLog = $"Error|Thing to say caused by 42, 43, 44|From BaseLoggerMixins|at {current}";
            string actualLog = ((FileLogger)logger).LastLog;

            // Assert
            Assert.AreEqual(expectedLog, actualLog);
        }

        [TestMethod]
        public void Error_WithNullMessage_LogsMessage()
        {
            // Arrange
            LogFactory logFactory = new LogFactory();
            logFactory.ConfigureFileLogger(@"C:\Users\Jenny Meadowcroft\Documents\Visual Studio 2019\Logs");
            BaseLogger logger = logFactory.CreateLogger("Logger1");
            string[] parameters = { "42" };

            // Act
            logger.Error(null, parameters);
            string current = DateTime.Now.ToString("g");
            string expectedLog = $"Error| caused by 42|From BaseLoggerMixins|at {current}";
            // Assert

            Assert.AreEqual(expectedLog, ((FileLogger)logger).LastLog);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Warning_WithNullLogger_ThrowsException()
        {
            // Arrange
            FileLogger logger = null;
            string[] parameters = { "one", "two", "three" };
            // Act
            logger.Warning("", parameters);

            // Assert

        }

        [TestMethod]
        public void Warning_WithOneParameter_LogsMessage()
        {
            // Arrange
            LogFactory logFactory = new LogFactory();
            logFactory.ConfigureFileLogger(@"C:\Users\Jenny Meadowcroft\Documents\Visual Studio 2019\Logs");
            BaseLogger logger = logFactory.CreateLogger("Logger1");
            string[] parameters = { "42" };

            // Act
            logger.Warning("Thing to say", parameters);
            string current = DateTime.Now.ToString("g");
            string expectedLog = $"Warning|Thing to say caused by 42|From BaseLoggerMixins|at {current}";
            string actualLog = ((FileLogger)logger).LastLog;
            // Assert

            Assert.AreEqual(expectedLog, actualLog);
        }

        [TestMethod]
        public void Warning_WithMultipleParameters_LogsMessage()
        {
            // Arrange
            LogFactory logFactory = new LogFactory();
            logFactory.ConfigureFileLogger(@"C:\Users\Jenny Meadowcroft\Documents\Visual Studio 2019\Logs");
            BaseLogger logger = logFactory.CreateLogger("Logger1");
            string[] parameters = { "42", "43", "44" };

            // Act
            logger.Warning("Thing to say", parameters);
            string current = DateTime.Now.ToString("g");
            string expectedLog = $"Warning|Thing to say caused by 42, 43, 44|From BaseLoggerMixins|at {current}";
            string actualLog = ((FileLogger)logger).LastLog;

            // Assert
            Assert.AreEqual(expectedLog, actualLog);
        }

        [TestMethod]
        public void Warning_WithNullMessage_LogsMessage()
        {
            // Arrange
            LogFactory logFactory = new LogFactory();
            logFactory.ConfigureFileLogger(@"C:\Users\Jenny Meadowcroft\Documents\Visual Studio 2019\Logs");
            BaseLogger logger = logFactory.CreateLogger("Logger1");
            string[] parameters = { "42" };

            // Act
            logger.Warning(null, parameters);
            string current = DateTime.Now.ToString("g");
            string expectedLog = $"Warning| caused by 42|From BaseLoggerMixins|at {current}";
            // Assert

            Assert.AreEqual(expectedLog, ((FileLogger)logger).LastLog);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Information_WithNullLogger_ThrowsException()
        {
            // Arrange
            FileLogger logger = null;
            string[] parameters = { "one", "two", "three" };
            // Act
            logger.Information("", parameters);

            // Assert

        }

        [TestMethod]
        public void Information_WithOneParameter_LogsMessage()
        {
            // Arrange
            LogFactory logFactory = new LogFactory();
            logFactory.ConfigureFileLogger(@"C:\Users\Jenny Meadowcroft\Documents\Visual Studio 2019\Logs");
            BaseLogger logger = logFactory.CreateLogger("Logger1");
            string[] parameters = { "42" };

            // Act
            logger.Information("Thing to say", parameters);
            string current = DateTime.Now.ToString("g");
            string expectedLog = $"Information|Thing to say caused by 42|From BaseLoggerMixins|at {current}";
            string actualLog = ((FileLogger)logger).LastLog;
            // Assert

            Assert.AreEqual(expectedLog, actualLog);
        }

        [TestMethod]
        public void Information_WithMultipleParameters_LogsMessage()
        {
            // Arrange
            LogFactory logFactory = new LogFactory();
            logFactory.ConfigureFileLogger(@"C:\Users\Jenny Meadowcroft\Documents\Visual Studio 2019\Logs");
            BaseLogger logger = logFactory.CreateLogger("Logger1");
            string[] parameters = { "42", "43", "44" };

            // Act
            logger.Information("Thing to say", parameters);
            string current = DateTime.Now.ToString("g");
            string expectedLog = $"Information|Thing to say caused by 42, 43, 44|From BaseLoggerMixins|at {current}";
            string actualLog = ((FileLogger)logger).LastLog;

            // Assert
            Assert.AreEqual(expectedLog, actualLog);
        }

        [TestMethod]
        public void Information_WithNullMessage_LogsMessage()
        {
            // Arrange
            LogFactory logFactory = new LogFactory();
            logFactory.ConfigureFileLogger(@"C:\Users\Jenny Meadowcroft\Documents\Visual Studio 2019\Logs");
            BaseLogger logger = logFactory.CreateLogger("Logger1");
            string[] parameters = { "42" };

            // Act
            logger.Information(null, parameters);
            string current = DateTime.Now.ToString("g");
            string expectedLog = $"Information| caused by 42|From BaseLoggerMixins|at {current}";
            // Assert

            Assert.AreEqual(expectedLog, ((FileLogger)logger).LastLog);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Debug_WithNullLogger_ThrowsException()
        {
            // Arrange
            FileLogger logger = null;
            string[] parameters = { "one", "two", "three" };
            // Act
            logger.Debug("", parameters);

            // Assert

        }

        [TestMethod]
        public void Debug_WithOneParameter_LogsMessage()
        {
            // Arrange
            LogFactory logFactory = new LogFactory();
            logFactory.ConfigureFileLogger(@"C:\Users\Jenny Meadowcroft\Documents\Visual Studio 2019\Logs");
            BaseLogger logger = logFactory.CreateLogger("Logger1");
            string[] parameters = { "42" };

            // Act
            logger.Debug("Thing to say", parameters);
            string current = DateTime.Now.ToString("g");
            string expectedLog = $"Debug|Thing to say caused by 42|From BaseLoggerMixins|at {current}";
            string actualLog = ((FileLogger)logger).LastLog;
            // Assert

            Assert.AreEqual(expectedLog, actualLog);
        }

        [TestMethod]
        public void Debug_WithMultipleParameters_LogsMessage()
        {
            // Arrange
            LogFactory logFactory = new LogFactory();
            logFactory.ConfigureFileLogger(@"C:\Users\Jenny Meadowcroft\Documents\Visual Studio 2019\Logs");
            BaseLogger logger = logFactory.CreateLogger("Logger1");
            string[] parameters = { "42", "43", "44" };

            // Act
            logger.Debug("Thing to say", parameters);
            string current = DateTime.Now.ToString("g");
            string expectedLog = $"Debug|Thing to say caused by 42, 43, 44|From BaseLoggerMixins|at {current}";
            string actualLog = ((FileLogger)logger).LastLog;

            // Assert
            Assert.AreEqual(expectedLog, actualLog);
        }

        [TestMethod]
        public void Debug_WithNullMessage_LogsMessage()
        {
            // Arrange
            LogFactory logFactory = new LogFactory();
            logFactory.ConfigureFileLogger(@"C:\Users\Jenny Meadowcroft\Documents\Visual Studio 2019\Logs");
            BaseLogger logger = logFactory.CreateLogger("Logger1");
            string[] parameters = { "42" };

            // Act
            logger.Debug(null, parameters);
            string current = DateTime.Now.ToString("g");
            string expectedLog = $"Debug| caused by 42|From BaseLoggerMixins|at {current}";
            // Assert

            Assert.AreEqual(expectedLog, ((FileLogger)logger).LastLog);
        }
    }

}
