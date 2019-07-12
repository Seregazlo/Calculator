using System;

namespace Calculator.OneArguments
{
    public class Tan:IOneArgumentsCalculator
    {
        /// <summary>
        /// One arguments function
        /// </summary>
        /// <param name="firstValue">
        /// This function defines tan of the first value
        /// </param>
        /// <returns></returns>
        public double Calculate(double firstValue)
        {
            return Math.Atan(firstValue);
        }
    }
}
