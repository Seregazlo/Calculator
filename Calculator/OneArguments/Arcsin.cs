using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class Arcsin:IOneArgumentsCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Asin(firstValue);
        }
    }
}
