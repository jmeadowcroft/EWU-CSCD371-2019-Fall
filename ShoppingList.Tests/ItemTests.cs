using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingList.Tests
{
    [TestClass]
    public class ItemTests
    {
        [TestMethod]
        public void WhenNameDoesntChange_PropertyChangedIsNotRaised()
        {
            //Arrange
            var item = new Item();
            bool eventRaised = false;
            item.PropertyChanged += (sender, args) =>
            {
                if (args.PropertyName == nameof(Item.Name))
                {
                    eventRaised = true;
                }
            };

            //Act
            item.Name = item.Name;

            //Assert
            Assert.IsFalse(eventRaised);
        }

        [TestMethod]
        public void WhenNameChanges_RaisesPropertyChanged()
        {
            //Arrange
            var item = new Item();
            bool eventRaised = false;
            item.PropertyChanged += (sender, args) =>
            {
                if (args.PropertyName == nameof(Item.Name))
                {
                    eventRaised = true;
                }
            };

            //Act
            item.Name = "Name";

            //Assert
            Assert.IsTrue(eventRaised);
            Assert.AreEqual("Name", item.Name);
        }

        [TestMethod]
        public void WhenDescriptionDoesntChange_PropertyChangedIsNotRaised()
        {
            //Arrange
            var item = new Item();
            bool eventRaised = false;
            item.PropertyChanged += (sender, args) =>
            {
                if (args.PropertyName == nameof(Item.Description))
                {
                    eventRaised = true;
                }
            };

            //Act
            item.Description = item.Description;

            //Assert
            Assert.IsFalse(eventRaised);
        }

        [TestMethod]
        public void WhenDescriptionChanges_RaisesPropertyChanged()
        {
            //Arrange
            var item = new Item();
            bool eventRaised = false;
            item.PropertyChanged += (sender, args) =>
            {
                if (args.PropertyName == nameof(Item.Description))
                {
                    eventRaised = true;
                }
            };

            //Act
            item.Description = "Description";

            //Assert
            Assert.IsTrue(eventRaised);
            Assert.AreEqual("Description", item.Description);
        }
    }
}
