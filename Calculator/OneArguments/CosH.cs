using System;

namespace Calculator.OneArguments
{
    public class CosH:IOneArgumentsCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Cosh(firstValue);
        }
    }
}
