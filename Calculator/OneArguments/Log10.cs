using System;

namespace Calculator.OneArguments
{
    public class Log10 : IOneArgumentsCalculator
    {
        /// <summary>
        /// One arguments function
        /// </summary>
        /// <param name="firstValue">
        /// Logarithm of the number base ten
        /// </param>
        /// <returns></returns>
        public double Calculate(double firstValue)
        {
            if (firstValue <= 0) throw new Exception("Не входит в область допустимых значений");
            return Math.Log10(firstValue);
        }
    }
}
