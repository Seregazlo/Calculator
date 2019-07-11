using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class xten:IOneArgumentsCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Pow(10,firstValue);
        }
    }
}
