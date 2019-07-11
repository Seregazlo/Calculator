using System;

namespace Calculator.TwoArguments
{
    public class maxxy:ITwoArgumentsCalculator
    {
        /// <summary>
        /// Two argument function
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// Specifies the greater of the two numbers
        /// <returns></returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Max(firstValue, secondValue);
        }
    }
}
