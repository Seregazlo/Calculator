using System;

namespace Calculator.OneArguments
{
    public class Acrcos:IOneArgumentsCalculator
    {
        public double Calculate(double firstValue)
        {
            if (firstValue < -1 || firstValue > 1) throw new Exception("Выход за границы допустимых значений");
            return Math.Acos(firstValue);
        }
    }
}
