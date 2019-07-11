namespace Calculator.TwoArguments
{
    /// <summary>
    /// Gives the remainder of the division of two numbers
    /// </summary>
    public class RemainDivision:ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue % secondValue;
        }
    }
}
