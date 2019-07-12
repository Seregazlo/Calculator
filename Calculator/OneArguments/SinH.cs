using System;

namespace Calculator.OneArguments
{
    public class SinH:IOneArgumentsCalculator
    {
        /// <summary>
        /// One arguments function
        /// </summary>
        /// <param name="firstValue">
        /// This function defines sinh of the first value
        /// </param>
        /// <returns></returns>
        public double Calculate(double firstValue)
        {
            return Math.Sinh(firstValue);
        }
    }
}
