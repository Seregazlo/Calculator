using System;

namespace Calculator.OneArguments
{/// <summary>
/// Logarithm of the number base ten
/// </summary>
    public class Log10:IOneArgumentsCalculator
    {
        public double Calculate(double firstValue)
        {
            if(firstValue<=0)throw new Exception("Не входит в область допустимых значений");
            return Math.Log10(firstValue);
        }
    }
}
