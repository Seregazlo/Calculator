namespace Calculator.OneArguments
{

    public class Exponentation: IOneArgumentsCalculator
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
            return firstValue*firstValue;
        }
    }
}
