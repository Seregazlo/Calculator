using System;

namespace Calculator.OneArguments
{
    public class CosH : IOneArgumentCalculators
    {
        /// <summary>
        /// One arguments function
        /// </summary>
        /// <param name="firstValue">
        /// This function defines cosh of the first value
        /// </param>
        /// <returns></returns>
        public double Calculate(double firstValue)
        {
            return Math.Cosh(firstValue);
        }
    }
}
