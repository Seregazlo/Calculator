using System;

namespace Calculator.OneArguments
{
    public class xten:IOneArgumentsCalculator
    {
        /// <summary>
        /// One argument function
        /// </summary>
        /// <param name="firstValue">
        /// Value of 10 to the power of number
        /// </param>
        /// <returns></returns>
        public double Calculate(double firstValue)
        {
            return Math.Pow(10,firstValue);
        }
    }
}
