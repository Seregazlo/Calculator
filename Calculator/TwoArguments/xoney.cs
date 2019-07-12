using System;

namespace Calculator.TwoArguments
{
    public class XoneY : ITwoArgumentCalculators
    {
        /// <summary>
        /// Two argument function
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// Raises the first number to the power of 1/second number
        /// <returns></returns>
        public double Calculate(double firstValue, double secondValue)
        {
            if (secondValue == 0)
            {
                throw new Exception("Первый аргумент возводится в степень 1/0");
            }
            return Math.Pow(firstValue, (1 / secondValue));
        }
    }
}
