using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class Sin : IOneArgumentsCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Sin(firstValue);
        }
    }
}
