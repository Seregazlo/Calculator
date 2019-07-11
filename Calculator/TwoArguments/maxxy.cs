using System;

namespace Calculator.TwoArguments
{
    /// <summary>
    /// Specifies the greater of the two numbers
    /// </summary>
    public class maxxy:ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Max(firstValue, secondValue);
        }
    }
}
