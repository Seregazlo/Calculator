using System;

namespace Calculator.OneArguments
{
    /// <summary>
    /// Value of 10 to the power of number
    /// </summary>
    public class xten:IOneArgumentsCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Pow(10,firstValue);
        }
    }
}
