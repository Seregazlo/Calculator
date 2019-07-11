namespace Calculator.TwoArguments
{
     public class Mulitipleer: ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue * secondValue;
        }
    }
}
