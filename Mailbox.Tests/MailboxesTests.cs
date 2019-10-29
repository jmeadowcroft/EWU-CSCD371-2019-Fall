using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mailbox.Tests
{
    [TestClass]
    public class MailboxesTests
    {
        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void Constructor_RequiresMailboxes()
        {
            new Mailboxes(null, 1, 1);
        }

        [DataRow(1, -1)]
        [DataRow(-1, 1)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [DataTestMethod]
        public void Constructor_RequiresSize(int width, int height)
        {
            new Mailboxes(Array.Empty<Mailbox>(), width, height);
        }

        [TestMethod]
        public void Constructor_SetsProperties()
        {
            var mailbox = new Mailbox((1, 1), Sizes.Medium, new Person());
            var mailboxes = new Mailboxes(new[] { mailbox }, 10, 5);

            CollectionAssert.AreEquivalent(new[] { mailbox }, mailboxes);
            Assert.AreEqual(10, mailboxes.Width);
            Assert.AreEqual(5, mailboxes.Height);
        }

        [TestMethod]
        public void GetAdjacentPeople_ProvidesAdjacentPeople()
        {
            var person1 = new Person { FirstName = "1", LastName = "One" };
            var person2 = new Person { FirstName = "2", LastName = "Two" };
            var person3 = new Person { FirstName = "3", LastName = "Three" };
            var person4 = new Person { FirstName = "4", LastName = "Four" };


            var mailboxLeft = new Mailbox((1, 2), Sizes.Small, person1);
            var mailboxTop = new Mailbox((2, 1), Sizes.Small, person2);
            var mailboxRight = new Mailbox((3, 2), Sizes.Small, person3);
            var mailboxBottom = new Mailbox((2, 3), Sizes.Small, person4);

            var mailboxes = new Mailboxes(new[]
            {
                mailboxLeft,
                mailboxTop,
                mailboxRight,
                mailboxBottom
            }, 5, 5);

            bool isOccupied = mailboxes.GetAdjacentPeople(2, 2, out HashSet<Person> adjacentPeople);

            Assert.IsFalse(isOccupied);
            CollectionAssert.AreEquivalent(new[]
            {
                person1,
                person2,
                person3,
                person4
            }, adjacentPeople.ToArray());
        }

        [TestMethod]
        public void GetAdjacentPeople_ReturnsTrue_IfLocationInUse()
        {
            var person = new Person { FirstName = "1", LastName = "One" };

            var mailbox = new Mailbox((2, 2), Sizes.Small, person);

            var mailboxes = new Mailboxes(new[]
            {
                mailbox
            }, 5, 5);

            bool isOccupied = mailboxes.GetAdjacentPeople(2, 2, out HashSet<Person> adjacentPeople);

            Assert.IsTrue(isOccupied);
            Assert.AreEqual(0, adjacentPeople.Count);
        }

        [TestMethod]
        public void GetAdjacentPeople_ProvidesDistinctPeople()
        {
            var person1 = new Person { FirstName = "1", LastName = "One" };
            var person2 = new Person { FirstName = "2", LastName = "Two" };


            var mailboxLeft = new Mailbox((1, 2), Sizes.Small, person1);
            var mailboxTop = new Mailbox((2, 1), Sizes.Small, person2);
            var mailboxRight = new Mailbox((3, 2), Sizes.Small, person2);
            var mailboxBottom = new Mailbox((2, 3), Sizes.Small, person2);

            var mailboxes = new Mailboxes(new[]
            {
                mailboxLeft,
                mailboxTop,
                mailboxRight,
                mailboxBottom
            }, 5, 5);

            bool isOccupied = mailboxes.GetAdjacentPeople(2, 2, out HashSet<Person> adjacentPeople);

            Assert.IsFalse(isOccupied);
            CollectionAssert.AreEquivalent(new[]
            {
                person1,
                person2
            }, adjacentPeople.ToArray());
        }
    }
}
