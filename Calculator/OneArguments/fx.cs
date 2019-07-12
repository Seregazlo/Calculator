namespace Calculator.OneArguments
{
    public class fx:IOneArgumentsCalculator
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
