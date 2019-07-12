using System;

namespace Calculator.OneArguments
{
    public class ArcTan:IOneArgumentsCalculator
    {
        /// <summary>
        /// One arguments function
        /// </summary>
        /// <param name="firstValue">
        /// This function defines arctan of the first value
        /// </param>
        /// <returns></returns>
        public double Calculate(double firstValue)
        {
            return Math.Atan(firstValue);
        }
    }
}
