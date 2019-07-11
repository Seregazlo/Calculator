using System;

namespace Calculator.OneArguments
{
    public class Log10:IOneArgumentsCalculator
    {
        public double Calculate(double firstValue)
        {
            if(firstValue<=0)throw new Exception("Не входит в область допустимых значений");
            return Math.Log10(firstValue);
        }
    }
}
