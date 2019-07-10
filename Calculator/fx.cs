using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class fx:IOneArgumentsCalculator
    {
        public double Calculate(double firstValue)
        {
            return (-firstValue);
        }
    }
}
