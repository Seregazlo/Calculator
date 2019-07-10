using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using static System.Math;

namespace Calculator
{

    class Cos: IOneArgumentsCalculator
    {
        public double Calculates(double firstValue)
        {
            return Math.Cos(firstValue);
        }
    }
}
