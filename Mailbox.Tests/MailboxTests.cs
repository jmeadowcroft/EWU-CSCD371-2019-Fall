using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mailbox.Tests
{
    [TestClass]
    public class MailboxTests
    {
        [TestMethod]
        public void Constructor_SetsProperties()
        {
            var location = (1, 2);
            var owner = new Person { FirstName = "Kevin", LastName = "Bost" };
            var mailbox = new Mailbox(location, Sizes.Large, owner);

            Assert.AreEqual(location, mailbox.Location);
            Assert.AreEqual(Sizes.Large, mailbox.Size);
            Assert.AreEqual(owner, mailbox.Owner);
        }

        [TestMethod]
        public void ToString_ReturnsDisplay()
        {
            var mailbox = new Mailbox((1, 2), Sizes.Large, new Person { FirstName = "Kevin", LastName = "Bost" });
            Assert.AreEqual($"(1, 2) Large Kevin Bost", mailbox.ToString());
        }
    }
}
