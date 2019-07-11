using System;

namespace Calculator.TwoArguments
{
    /// <summary>
    /// Specifies the smaller of the two numbers
    /// </summary>
    public class minxy:ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Min(firstValue, secondValue);
        }
    }
}
