using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Exponentation: IOneArgumentsCalculator
    {
        public double Calculates(double firstValue)
        {
            return firstValue*firstValue;
        }
    }
}
