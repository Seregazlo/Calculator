using System;

namespace Calculator.OneArguments
{
    public class xten:IOneArgumentsCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Pow(10,firstValue);
        }
    }
}
