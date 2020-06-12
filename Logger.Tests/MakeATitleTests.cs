using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MakeATitle.tests
{
    [TestClass]
    class MakeATitleTests
    {
        
        [TestMethod]
        public void ToTitleCase_UpperAndLower_ReturnsCorrectly()
        {
            string myString = "intellitect is a company in Spokane";
            string myTitle = myString.ToTitleCase();
            Assert.AreEqual(myTitle, "intellitect is a company in Spokane");
        }

        
    }
}