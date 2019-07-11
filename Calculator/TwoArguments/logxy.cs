using System;

namespace Calculator.TwoArguments
{
    public class logxy:ITwoArgumentsCalculator
    {
        /// <summary>
        /// Two arguments function
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// Logarithm of the first number base on the second number
        /// <returns></returns>
        public double Calculate(double firstValue, double secondValue)
        {
            if (firstValue <= 0||secondValue<=1) throw new Exception("Не входит в область допустимых значений");
            return Math.Log(firstValue, secondValue);
        }
    }
}
