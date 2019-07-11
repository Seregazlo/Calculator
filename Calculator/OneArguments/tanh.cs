using System;

namespace Calculator.OneArguments
{
    public class tanh:IOneArgumentsCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Tanh(firstValue);
        }
    }
}
