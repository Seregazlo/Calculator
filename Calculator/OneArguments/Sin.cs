using System;

namespace Calculator.OneArguments
{
    public class Sin : IOneArgumentsCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Sin(firstValue);
        }
    }
}
