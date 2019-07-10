using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class maxxy:ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Max(firstValue, secondValue);
        }
    }
}
