using System;

namespace Calculator.OneArguments
{
    public class Arcsin:IOneArgumentsCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Asin(firstValue);
        }
    }
}
