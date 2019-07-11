using System;

namespace Calculator.TwoArguments
{
    public class xoney: ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Pow(firstValue,(1/secondValue));
        }
    }
}
