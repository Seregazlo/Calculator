﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Mulitipleer: ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue * secondValue;
        }
    }
}