using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using PlaginRadioBC.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace PlaginRadioBC
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private string _title;
        private string _value;
        public TestModel _model;
        public ObservableCollection<TestModel> Data { get; set; }
        public ICommand ToggleAllCommand { get; }

        public MainWindowViewModel()
        {
            Title = "Test";
            Value = "8";
            //_model = new TestModel() { State = 8, System = "BC", Digital = true, Freq_MHz = 100, Lat_Dec = 50.1823, Lon_Dec = 34.9823 };
            Data = new ObservableCollection<TestModel>();
            var random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Data.Add(new TestModel
                {
                    ID = i,
                    //Table = "Table" + i,
                    Name = "Name" + i,
                    FreqMHz = random.NextDouble() * 500,
                    CH = random.Next(1, 10),
                    DistKm = random.Next(100, 1000),
                    EIRdBW = random.NextDouble() * 50,
                    HeffM = random.NextDouble() * 200,
                    State = "State" + i,
                    //Sys = "Sys" + i,
                    Interference = random.NextDouble() * 70,
                    Victim = random.NextDouble() * 70,
                    Lon = random.NextDouble() * 180,
                    Lat = random.NextDouble() * 90
                });
            }
            ToggleAllCommand = new RelayCommand(ToggleAll);
        }
        public bool IsAllSelected
        {
            get { return Data.All(d => d.IsChecked); }
            set
            {
                foreach (var item in Data)
                {
                    item.IsChecked = value;
                }
                OnPropertyChanged(nameof(IsAllSelected));
            }
        }

        private void ToggleAll()
        {
            bool newValue = !Data.All(d => d.IsChecked);
            foreach (var item in Data)
            {
                item.IsChecked = newValue;
            }
        }
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        public string Value
        {
            get { return _value; }
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    public class RelayCommand : ICommand
    {
        private readonly Action _execute;
        private readonly Func<bool> _canExecute;

        public RelayCommand(Action execute, Func<bool> canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute();
        }

        public void Execute(object parameter)
        {
            _execute();
        }
    }

}
