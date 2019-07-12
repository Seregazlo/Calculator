using System;

namespace Calculator.TwoArguments
{
    public class Divider: ITwoArgumentsCalculator
    {
        /// <summary>
        /// Two argument function
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// This function divide two numbers
        /// <returns></returns>
        public double Calculate(double firstValue, double secondValue)
        {
            if (secondValue == 0)
            {
                throw new Exception("Деление на 0");
            }
            return firstValue / secondValue;
        }
    }
}
