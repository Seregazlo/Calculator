namespace Calculator.OneArguments
{
    /// <summary>
    /// Construction of the power
    /// </summary>
    public class Exponentation: IOneArgumentsCalculator
    {
        
        public double Calculate(double firstValue)
        {
            return firstValue*firstValue;
        }
    }
}
