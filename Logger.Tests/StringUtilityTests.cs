using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logger;
using System;
namespace Logger.Tests
{
    [TestClass]
    public class StringUtilityTests
    {
        
        [TestMethod]
        public void ToTitleCase_UpperAndLower_Success()
        {
            string myString = "Intellitect Is A Company In Spokane";
            string actual = StringUtility.ToTitleCase(myString);
            Assert.AreEqual<string>("Intellitect Is A Company In Spokane", actual);
        }
        [TestMethod]
        public void ToTitleCase_UpperAndLower2_Success()
        {
            string myString = "Intellitect is a company in Spokane";
            string actual = StringUtility.ToTitleCase(myString);
            Assert.AreEqual<string>("Intellitect Is A Company In Spokane", actual);
        }

        [TestMethod]
        public void ToTitleCase_ExtraSpace_Success()
        {
            string myString = "Intellitect is a company  in Spokane, WA";
            string actual = StringUtility.ToTitleCase(myString);
            Assert.AreEqual<string>("Intellitect Is A Company In Spokane, WA", actual);
        }

        [TestMethod]
        public void ToTitleCase_GivenNull_ReturnsBlank()
        {
            string mystring = null;
            string actual = StringUtility.ToTitleCase(mystring);
            Assert.AreEqual<string>("",actual);
        }

        [TestMethod]
        public void ToTitleCase_GivenNumbers_Success()
        {
            string mystring = "the mysterious number 13";
            string actual = StringUtility.ToTitleCase(mystring);
            Assert.AreEqual<string>("The Mysterious Number 13", actual);
        }

        [TestMethod]
        public void ToTitleCase_GivenTab_Success()
        {
            string mystring = "Intellitect      Is A Company In Spokane";
            string actual = StringUtility.ToTitleCase(mystring);
            Assert.AreEqual<string>("Intellitect Is A Company In Spokane", actual);
        }

        [TestMethod]
        public void ToTitleCase_GivenSpecialChar_Success()
        {
            string mystring = "Intellitect *Is A Company In Spokane";
            string actual = StringUtility.ToTitleCase(mystring);
            Assert.AreEqual<string>("Intellitect *Is A Company In Spokane", actual);
        }




    }
}