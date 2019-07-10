using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Acrcos:IOneArgumentsCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Acos(firstValue);
        }
    }
}
