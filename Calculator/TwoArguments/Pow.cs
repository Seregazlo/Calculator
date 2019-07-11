using System;

namespace Calculator.TwoArguments
{
    public class Pow:ITwoArgumentsCalculator
    {
        /// <summary>
        /// Two argument function
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// Raises the first number to the power of the second number
        /// <returns></returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Pow(firstValue, secondValue);
        }
    }
}
