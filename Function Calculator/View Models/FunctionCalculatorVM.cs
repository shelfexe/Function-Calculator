using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Function_Calculator.Models;
namespace Function_Calculator.View_Models
{
    class FunctionCalculatorVM : INotifyPropertyChanged
    {
        public FunctionCalculatorVM() 
        {
            functions = new ObservableCollection<Function> { new LinearFunction(),
                                                             new QuadraticFunction(),
                                                             new CubicFunction(),
                                                             new QuarticFunction(),
                                                             new QuinticFunction() };
            SelectedFunctionForTable = new ObservableCollection<Function>();

        }


        
        public ObservableCollection<Function> functions {get; set;}
        private Function _selectedFunction;
        public ObservableCollection<Function> SelectedFunctionForTable { get; set; }   // Т.к. по ТЗ требуется сделать именно таблицу (не по смыслу, а именно элемент),
                                                                                       // для работы всего с одним экземпляром, но таблицы работают с коллециями.
        public Function SelectedFunction
        {
            get { return _selectedFunction; }
            set
            {
                _selectedFunction = value;
                SelectedFunctionForTable.Clear();
                SelectedFunctionForTable.Add(_selectedFunction);
                OnPropertyChanged("SelectedFunction");
                
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
