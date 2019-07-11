using System;

namespace Calculator.TwoArguments
{
    /// <summary>
    /// Logarithm of the first number base on the second number
    /// </summary>
    public class logxy:ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            if (firstValue <= 0||secondValue<=1) throw new Exception("Не входит в область допустимых значений");
            return Math.Log(firstValue, secondValue);
        }
    }
}
