using System;

namespace Calculator.OneArguments
{
    public class exp: IOneArgumentsCalculator
    {
        /// <summary>
        /// One Arguments Function
        /// </summary>
        /// <param name="firstValue">
        /// Number expansion
        /// </param>
        /// <returns></returns>
        public double Calculate(double firstValue)
        {
            return Math.Exp(firstValue);
        }
    }
}
