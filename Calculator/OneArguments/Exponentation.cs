namespace Calculator.OneArguments
{
    public class Exponentation: IOneArgumentsCalculator
    {
        public double Calculate(double firstValue)
        {
            return firstValue*firstValue;
        }
    }
}
