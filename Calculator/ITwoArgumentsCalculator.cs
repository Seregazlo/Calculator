namespace Calculator
{
    public interface ITwoArgumentsCalculator
    {
        double Calculate(double firstValue, double secondValue);
    }
    public interface ITwoArgumentsCalculatorSingleArgument
    {
        double Calculate(double firstValue);
    }
}