namespace Calculator.TwoArguments
{
    public class Discripter : ITwoArgumentCalculators
    {
        /// <summary>
        /// Two argument function
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// This function subtracts two numbers
        /// <returns></returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }
    }
}
