using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Calculator.Models
{
    class LinearFunction : Function
    {
        public LinearFunction() : base() 
        { 
            c_array = new double[] { 1, 2, 3, 4, 5};
            Name = "Линейная";
        }

        public override string Name { get; set; }
        public override void CalculateFxy()
        {
            Fxy = a * x + b * y + c;
        }
    }
}
