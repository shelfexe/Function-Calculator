using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Calculator.Models
{
    class QuadraticFunction : Function
    {
        public QuadraticFunction() : base()
        {
            c_array = new double[] { 10, 20, 30, 40, 50 };
            Name = "Квадратичная";
        }

        public override string Name { get; set; }
        public override void CalculateFxy()
        {
            Fxy = a * Math.Pow(x, 2) + b * y + c;
        }
    }
}
