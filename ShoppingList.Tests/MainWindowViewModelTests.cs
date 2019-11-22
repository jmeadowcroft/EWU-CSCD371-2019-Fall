using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingList.Tests
{
    [TestClass]
    public class MainWindowViewModelTests
    {
        [TestMethod]
        public void NewItemCommand_AddsNewItem()
        {
            //Arrange
            var viewModel = new MainWindowViewModel();
            
            //Act
            viewModel.NewItemCommand.Execute(null);

            //Assert
            Assert.IsTrue(viewModel.SelectedItem is { });
            Assert.AreEqual(1, viewModel.Items.Count);
            Assert.AreEqual(viewModel.SelectedItem, viewModel.Items.Last());
        }

        [TestMethod]
        public void WhenSelectItemChanges_RaisesPropertyChanged()
        {
            //Arrange
            var viewModel = new MainWindowViewModel();
            bool eventRaised = false;
            viewModel.PropertyChanged += (sender, args) =>
            {
                if (args.PropertyName == nameof(MainWindowViewModel.SelectedItem))
                {
                    eventRaised = true;
                }
            };

            //Act
            viewModel.SelectedItem = new Item();

            //Assert
            Assert.IsTrue(eventRaised);
        }

        [TestMethod]
        public void WhenSelectItemDoesntChange_PropertyChangedIsNotRaised()
        {
            //Arrange
            var viewModel = new MainWindowViewModel();
            bool eventRaised = false;
            viewModel.PropertyChanged += (sender, args) =>
            {
                if (args.PropertyName == nameof(MainWindowViewModel.SelectedItem))
                {
                    eventRaised = true;
                }
            };

            //Act
            viewModel.SelectedItem = viewModel.SelectedItem;

            //Assert
            Assert.IsFalse(eventRaised);
        }
    }
}
