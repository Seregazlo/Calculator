using System;

namespace Calculator.OneArguments
{/// <summary>
/// Number expansion
/// </summary>
    public class exp: IOneArgumentsCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Exp(firstValue);
        }
    }
}
