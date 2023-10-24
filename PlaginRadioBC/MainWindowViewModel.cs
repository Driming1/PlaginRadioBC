using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaginRadioBC
{
    public class Model
    {
        public int State;
        public string System;
        public bool Digital;
        public double Lon_Dec;
        public double Lat_Dec;
        public double Freq_MHz;
    }

    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private string _title;
        private string _value;
        public Model _model;
        public MainWindowViewModel()
        {
            Title = "Test";
            Value = "8";
            _model = new Model() {State = 8, System = "BC" , Digital = true, Freq_MHz = 100, Lat_Dec = 50.1823, Lon_Dec = 34.9823};
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
}
