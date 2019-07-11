﻿using System;

namespace Calculator.TwoArguments
{
    public class Divider: ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            if (secondValue == 0)
            {
                throw new Exception("Деление на 0");
            }
            return firstValue / secondValue;
        }
    }
}
