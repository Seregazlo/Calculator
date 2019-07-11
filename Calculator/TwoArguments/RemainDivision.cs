namespace Calculator.TwoArguments
{
    public class RemainDivision:ITwoArgumentsCalculator
    {
        /// <summary>
        /// Two argument function
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// Gives the remainder of the division of two numbers
        /// <returns></returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue % secondValue;
        }
    }
}
