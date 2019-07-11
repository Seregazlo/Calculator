using System;

namespace Calculator.TwoArguments
{
    public class minxy:ITwoArgumentsCalculator
    {
        /// <summary>
        /// Two argument function
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// Specifies the smaller of the two numbers
        /// <returns></returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Min(firstValue, secondValue);
        }
    }
}
