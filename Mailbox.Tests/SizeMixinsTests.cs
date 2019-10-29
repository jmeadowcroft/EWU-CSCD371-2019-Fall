using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mailbox.Tests
{
    [TestClass]
    public class SizeMixinsTests
    {
        [DataRow(Sizes.SmallPremium)]
        [DataRow(Sizes.MediumPremium)]
        [DataRow(Sizes.LargePremium)]
        [DataTestMethod]
        public void GetSizeDisplay_PremiumSize_AppendsPremium(Sizes premiumSize)
        {
            Assert.IsTrue(premiumSize.GetSizeDisplay().EndsWith(" Premium"));
        }

        [TestMethod]
        public void GetSizeDisplay_Unknown_IsEmptyString()
        {
            Assert.AreEqual("", Sizes.Unknown.GetSizeDisplay());
        }

        [DataRow(Sizes.Small)]
        [DataRow(Sizes.Medium)]
        [DataRow(Sizes.Large)]
        [DataTestMethod]
        public void GetSizeDisplay_ReturnsSizeName(Sizes size)
        {
            Assert.AreEqual(size.ToString(), size.GetSizeDisplay());
        }
    }
}
