using System;

namespace Calculator.TwoArguments
{
    /// <summary>
    /// Raises the first number to the power of the second number
    /// </summary>
    public class Pow:ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Pow(firstValue, secondValue);
        }
    }
}
