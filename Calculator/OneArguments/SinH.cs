using System;

namespace Calculator.OneArguments
{
    public class SinH:IOneArgumentsCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Sinh(firstValue);
        }
    }
}
