using System;

namespace Calculator.OneArguments
{
    public class Mod:IOneArgumentsCalculator
    {
        /// <summary>
        /// One arguments function
        /// </summary>
        /// <param name="firstValue">
        /// This function calculates the module of the value
        /// </param>
        /// <returns></returns>
        public double Calculate(double firstValue)
        {
            return Math.Abs(firstValue);
        }
    }
}
