using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Log10:IOneArgumentsCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Log10(firstValue);
        }
    }
}
