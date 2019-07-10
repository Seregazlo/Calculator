using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Tan:IOneArgumentsCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Atan(firstValue);
        }
    }
}
