using Math = System.Math;

namespace Calculator.OneArguments
{
    public class stx:IOneArgumentsCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Pow(2, firstValue);
        }
    }
}
