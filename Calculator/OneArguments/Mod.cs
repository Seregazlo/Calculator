using System;

namespace Calculator.OneArguments
{
    public class Mod:IOneArgumentsCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Abs(firstValue);
        }
    }
}
