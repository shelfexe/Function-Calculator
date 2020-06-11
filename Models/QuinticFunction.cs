using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Calculator.Models
{
    class QuinticFunction : Function
    {
        public QuinticFunction() : base()
        {
            c_array = new double[] { 10000, 20000, 30000, 40000, 50000 };
            Name = "5-ой степени";
        }

        public override string Name { get; set; }
        public override void CalculateFxy()
        {
            Fxy = a * Math.Pow(x, 5) + b * Math.Pow(y, 4) + c;
        }
    }
}
