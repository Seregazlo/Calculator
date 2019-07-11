using System;

namespace Calculator.OneArguments
{
    public class Sqrt:IOneArgumentsCalculator
    {
        public double Calculate(double firstValue)
        {
            if(firstValue<=0)throw new Exception("Корень из 0");
            return Math.Sqrt(firstValue);
        }
    }
}
