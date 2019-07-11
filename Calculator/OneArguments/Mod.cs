using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class Mod:IOneArgumentsCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Abs(firstValue);
        }
    }
}
