﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class exp: IOneArgumentsCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Exp(firstValue);
        }
    }
}
