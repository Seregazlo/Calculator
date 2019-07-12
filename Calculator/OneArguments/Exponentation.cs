namespace Calculator.OneArguments
{
    public class Exponentation : IOneArgumentCalculators
    {
        /// <summary>
        /// One arguments function
        /// </summary>
        /// <param name="firstValue">
        /// Construction of the power
        /// </param>
        /// <returns></returns>
        public double Calculate(double firstValue)
        {
            return firstValue * firstValue;
        }
    }
}
