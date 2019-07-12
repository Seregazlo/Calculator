using System;

namespace Calculator.OneArguments
{
    public class Exp : IOneArgumentCalculators
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
