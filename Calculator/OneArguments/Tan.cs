using System;

namespace Calculator.OneArguments
{
    public class Tan:IOneArgumentsCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Atan(firstValue);
        }
    }
}
