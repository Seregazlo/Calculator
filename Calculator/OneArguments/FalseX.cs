namespace Calculator.OneArguments
{
    public class FalseX : IOneArgumentCalculators
    {
        /// <summary>
        /// One arguments function
        /// </summary>
        /// <param name="firstValue">
        ///
        /// This function change value to negative
        /// </param>
        /// <returns></returns>
        public double Calculate(double firstValue)
        {
            return (-firstValue);
        }
    }
}
