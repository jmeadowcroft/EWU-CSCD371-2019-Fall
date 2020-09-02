using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Logger.Tests
{
    [TestClass]
    public class FileLoggerTests
    {
        [TestMethod]
        public void Log_WithValidPath_Success()
        {
            // Arrange
            string path = @"C:\Users\Jenny Meadowcroft\Documents\Visual Studio 2019\Logs";
            FileLogger logger = new FileLogger(path);

            // Act
            logger.Log(LogLevel.Error, "There's an error");
            string logMade = logger.LastLog;
            string current = DateTime.Now.ToString("g");
            string expectedLog = $"Error|There's an error|From FileLoggerTests|at {current}";
            Console.WriteLine($"Expected: {expectedLog}");
            Console.WriteLine($"Log Made: {logMade}");
           
            // Assert
            Assert.AreEqual(expectedLog, logMade);
           
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_WithInvalidPath_ThrowsException()
        {
            // Arrange
            FileLogger logger = new FileLogger("Not a path");

            // Act
            
            // Assert
            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_WithNullPath_ThrowsException()
        {
            // Arrange
            FileLogger logger = new FileLogger(null);

            // Act

            // Assert

        }

        

    }
}
