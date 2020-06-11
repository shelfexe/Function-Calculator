using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Calculator.Models
{
    class QuarticFunction : Function
    {
        public QuarticFunction() : base()
        {
            c_array = new double[] { 1000, 2000, 3000, 4000, 5000 };
            Name = "4-ой степени";
        }

        public override string Name { get; set; }
        public override void CalculateFxy()
        {
            Fxy = a * Math.Pow(x, 4) + b * Math.Pow(y, 3) + c;
        }
    }
}
