using System;

namespace Calculator.OneArguments
{
    public class ArcTan:IOneArgumentsCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Atan(firstValue);
        }
    }
}
