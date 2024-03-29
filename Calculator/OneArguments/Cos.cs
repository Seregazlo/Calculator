﻿using System;

namespace Calculator.OneArguments
{
    public class Cos : IOneArgumentCalculators
    {
        /// <summary>
        /// One arguments function
        /// </summary>
        /// <param name="firstValue">
        /// This function defines cos of the first value
        /// </param>
        /// <returns></returns>
        public double Calculate(double firstValue)
        {
            return Math.Cos(firstValue);
        }
    }
}
