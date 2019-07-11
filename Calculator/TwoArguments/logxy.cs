using System;

namespace Calculator.TwoArguments
{
    public class logxy:ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            if (firstValue <= 0||secondValue<=1) throw new Exception("Не входит в область допустимых значений");
            return Math.Log(firstValue, secondValue);
        }
    }
}
