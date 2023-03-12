

using MauiApp1.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace MauiApp1.ViewModel
{
    public class NewViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Person> _people;
        public ObservableCollection<Person> People
        {
            get { return _people; }
            set
            {
                _people = value;
                OnPropertyChanged(nameof(People));
            }
        }

        private Person _newPerson;
        public Person NewPerson
        {
            get { return _newPerson; }
            set
            {
                _newPerson = value;
                OnPropertyChanged(nameof(NewPerson));
            }
        }

        public ICommand AddPersonCommand { get; set; }

        public NewViewModel()
        {
            People = new ObservableCollection<Person>();
            NewPerson = new Person();

            AddPersonCommand = new Command(AddPerson);
        }

        private void AddPerson()
        {
            People.Add(NewPerson);
            NewPerson = new Person();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
