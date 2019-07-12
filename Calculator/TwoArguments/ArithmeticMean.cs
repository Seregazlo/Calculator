namespace Calculator.TwoArguments
{
    public class ArithmeticMean : ITwoArgumentCalculators
    {
        /// <summary>
        /// Two arguments function
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        ///  Average arithmetic of two numbers
        /// <returns></returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return ((firstValue + secondValue) / 2);
        }
    }
}
