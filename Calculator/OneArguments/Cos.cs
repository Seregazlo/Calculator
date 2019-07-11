using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using static System.Math;

namespace Calculator
{
    public class Cos: IOneArgumentsCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Cos(firstValue);
        }
    }
}
