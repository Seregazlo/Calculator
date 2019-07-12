﻿using System;

namespace Calculator.OneArguments
{
    public class Arcsin : IOneArgumentCalculators
    {
        /// <summary>
        /// One arguments function
        /// </summary>
        /// <param name="firstValue">
        /// This function defines arcsin of the first value
        /// </param>
        /// <returns></returns>
        public double Calculate(double firstValue)
        {
            if (firstValue < -1 || firstValue > 1)
            {
                throw new Exception("Выход за границы допустимых значений");
            }
            return Math.Asin(firstValue);
        }
    }
}
