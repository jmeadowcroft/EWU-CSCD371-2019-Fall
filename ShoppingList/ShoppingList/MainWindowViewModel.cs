using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace ShoppingList
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Item> Items { get; } = new ObservableCollection<Item>();

        private Item _SelectedItem;
        public Item SelectedItem
        {
            get => _SelectedItem;
            set
            {
                if (_SelectedItem != value)
                {
                    _SelectedItem = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand NewItemCommand { get; }

        public MainWindowViewModel()
        {
            NewItemCommand = new Command(OnNewItem);
        }

        private void OnNewItem()
        {
            SelectedItem = new Item();
            Items.Add(SelectedItem);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}