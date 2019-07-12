using Math = System.Math;

namespace Calculator.OneArguments
{
    public class StX : IOneArgumentCalculators
    {
        /// <summary>
        /// One arguments function
        /// </summary>
        /// <param name="firstValue">
        /// This function calculates 2 of the power a first value
        /// </param>
        /// <returns></returns>
        public double Calculate(double firstValue)
        {
            return Math.Pow(2, firstValue);
        }
    }
}
