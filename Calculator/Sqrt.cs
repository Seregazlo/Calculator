﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Sqrt:IOneArgumentsCalculator
    {
        public double Calculates(double firstValue)
        {
            return Math.Sqrt(firstValue);
        }
    }
}
