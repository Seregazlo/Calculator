namespace Calculator.TwoArguments
{
    public class RemainDivision:ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue % secondValue;
        }
    }
}
