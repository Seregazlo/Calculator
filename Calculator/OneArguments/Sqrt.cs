using System;

namespace Calculator.OneArguments
{
    public class Sqrt:IOneArgumentsCalculator
    {
        /// <summary>
        /// One arguments function
        /// </summary>
        /// <param name="firstValue">
        /// This function defines sqrt of the first value
        /// </param>
        /// <returns></returns>
        public double Calculate(double firstValue)
        {
            if(firstValue<=0)throw new Exception("Корень из 0");
            return Math.Sqrt(firstValue);
        }
    }
}
