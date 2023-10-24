using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaginRadioBC.Model
{
    public class TestModel
    {
        public int ID { get; set; }
        public string Table { get; set; }
        public string Name { get; set; }
        public double FreqMHz { get; set; }
        public int CH { get; set; }
        public int DistKm { get; set; }
        public double EIRdBW { get; set; }
        public double HeffM { get; set; }
        public string State { get; set; }
        public string Sys { get; set; }
        public double Interference { get; set; }
        public double Victim { get; set; }
        public double Lon { get; set; }
        public double Lat { get; set; }
        public bool IsChecked { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }

}
