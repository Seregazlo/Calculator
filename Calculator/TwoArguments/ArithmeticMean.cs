namespace Calculator.TwoArguments
{
    public class ArithmeticMean:ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return ((firstValue + secondValue) / 2);
        }
    }
}
