﻿using System;

namespace Calculator.OneArguments
{
    public class tanh:IOneArgumentsCalculator
    {
        /// <summary>
        /// One arguments function
        /// </summary>
        /// <param name="firstValue">
        /// This function defines tanh of the first value
        /// </param>
        /// <returns></returns>
        public double Calculate(double firstValue)
        {
            return Math.Tanh(firstValue);
        }
    }
}
