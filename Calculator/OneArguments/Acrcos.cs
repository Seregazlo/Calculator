using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class Acrcos:IOneArgumentsCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Acos(firstValue);
        }
    }
}
