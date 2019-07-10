using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Math = System.Math;

namespace Calculator
{
    class stx:IOneArgumentsCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Pow(2, firstValue);
        }
    }
}
