using System;

namespace Calculator.OneArguments
{
    public class Acrcos:IOneArgumentsCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Acos(firstValue);
        }
    }
}
