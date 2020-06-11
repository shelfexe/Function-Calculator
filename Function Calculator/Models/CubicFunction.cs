using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Calculator.Models
{
    class CubicFunction : Function
    {
        public CubicFunction() : base()
        {
            c_array = new double[] { 100, 200, 300, 400, 500 };
            Name = "Кубическая";
        }

        public override string Name { get; set; }
        public override void CalculateFxy()
        {
            Fxy = a * Math.Pow(x, 3) + b * Math.Pow(y, 2) + c;
        }
    }
}
