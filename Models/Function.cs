using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Calculator.Models
{
    abstract class Function : INotifyPropertyChanged
    {
        private double _a;
        private double _b;
        private double _c;
        private double _x;
        private double _y;
        public double a
        {
            get { return _a; } 
            set
            {
                _a = value;
                CalculateFxy();
            }
        }
        public double b
        {
            get { return _b; }
            set
            {
                _b = value;
                CalculateFxy();
            }
        }
        public double x
        {
            get { return _x; }
            set
            {
                _x = value;
                CalculateFxy();
            }
        }
        public double y
        {
            get { return _y; }
            set
            {
                _y = value;
                CalculateFxy();
            }
        }
        public double c
        {
            get { return _c; }
            set
            {
                _c = value;
                CalculateFxy();
            }
        }
        public double[] c_array { get; set; }
        public double _Fxy;
        public double Fxy
        {
            get { return _Fxy; }
            set
            { 
                _Fxy = value;
                OnPropertyChanged("Fxy");
            }
        }
        public abstract string Name { get; set; }
        abstract public void CalculateFxy();

        

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
