using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mailbox.Tests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void ToString_IncludesFirstAndLastName()
        {
            var person = new Person
            {
                FirstName = "Kevin",
                LastName = "Bost"
            };
            Assert.AreEqual("Kevin Bost", person.ToString());
        }

        [TestMethod]
        public void GetHashCode_ReturnsHashCode()
        {
            var person = new Person
            {
                FirstName = "Kevin",
                LastName = "Bost"
            };
            Assert.AreEqual(("Kevin", "Bost").GetHashCode(), person.GetHashCode());
        }

        [TestMethod]
        public void Equals_WithNull_ReturnsFalse()
        {
            var person = new Person
            {
                FirstName = "Kevin",
                LastName = "Bost"
            };

            Assert.IsFalse(person.Equals(null));
        }

        [TestMethod]
        public void Equals_WithMatchingPerson_ReturnsTrue()
        {
            var person1 = new Person
            {
                FirstName = "Kevin",
                LastName = "Bost"
            };
            var person2 = new Person
            {
                FirstName = "Kevin",
                LastName = "Bost"
            };

            Assert.IsTrue(person1.Equals(person2));
        }

        [TestMethod]
        public void Equals_WithNonMatchingPerson_ReturnsFalse()
        {
            var person1 = new Person
            {
                FirstName = "John",
                LastName = "Do"
            };
            var person2 = new Person
            {
                FirstName = "Kevin",
                LastName = "Bost"
            };

            Assert.IsFalse(person1.Equals(person2));
        }

        [TestMethod]
        public void EqualsOperator_WithMatchingPerson_ReturnsTrue()
        {
            var person1 = new Person
            {
                FirstName = "Kevin",
                LastName = "Bost"
            };
            var person2 = new Person
            {
                FirstName = "Kevin",
                LastName = "Bost"
            };

            Assert.IsTrue(person1 == person2);
        }

        [TestMethod]
        public void EqualsOperator_WithNonMatchingPerson_ReturnsFalse()
        {
            var person1 = new Person
            {
                FirstName = "John",
                LastName = "Do"
            };
            var person2 = new Person
            {
                FirstName = "Kevin",
                LastName = "Bost"
            };

            Assert.IsFalse(person1 == person2);
        }

        [TestMethod]
        public void NotEqualOperator_WithMatchingPerson_ReturnsFalse()
        {
            var person1 = new Person
            {
                FirstName = "Kevin",
                LastName = "Bost"
            };
            var person2 = new Person
            {
                FirstName = "Kevin",
                LastName = "Bost"
            };

            Assert.IsFalse(person1 != person2);
        }

        [TestMethod]
        public void NotEqualOperator_WithNonMatchingPerson_ReturnsTrue()
        {
            var person1 = new Person
            {
                FirstName = "John",
                LastName = "Do"
            };
            var person2 = new Person
            {
                FirstName = "Kevin",
                LastName = "Bost"
            };

            Assert.IsTrue(person1 != person2);
        }
    }
}
