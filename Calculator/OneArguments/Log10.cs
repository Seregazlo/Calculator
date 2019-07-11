using System;

namespace Calculator.OneArguments
{
    public class Log10:IOneArgumentsCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Log10(firstValue);
        }
    }
}
