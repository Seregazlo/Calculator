using System;

namespace Calculator.OneArguments
{
    public class exp: IOneArgumentsCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Exp(firstValue);
        }
    }
}
