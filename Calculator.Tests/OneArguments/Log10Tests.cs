using Calculator.OneArguments;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
{
    [TestFixture]
    public class Log10Tests
    {
        [TestCase(1, 0)]
        public void CalculatorTest(
            double firstValue,
            double expected)
        {
            var calculator = new Log10();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}