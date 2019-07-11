using System;

namespace Calculator.OneArguments
{
    public class Cos: IOneArgumentsCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Cos(firstValue);
        }
    }
}
