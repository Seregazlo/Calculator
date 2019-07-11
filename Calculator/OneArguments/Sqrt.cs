using System;

namespace Calculator.OneArguments
{
    public class Sqrt:IOneArgumentsCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Sqrt(firstValue);
        }
    }
}
