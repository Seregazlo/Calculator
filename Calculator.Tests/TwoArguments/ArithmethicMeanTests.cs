using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class ArithmeticMeanTests
    {
        [TestCase(1, 3, 2)]
        [TestCase(4, 2, 3)]
        [TestCase(4, 8, 6)]
        public void CalculatorTest(
            double firstValue,
            double secondValue,
            double expected)
        {
            var calculator = new ArithmeticMean();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}