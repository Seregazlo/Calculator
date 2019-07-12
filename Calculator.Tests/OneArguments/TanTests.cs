using Calculator.OneArguments;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
{
    [TestFixture]
    public class TanTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 0.78)]
        [TestCase(2, 1.10)]
        public void CalculatorTest(
            double firstValue,
            double expected)
        {
            var calculator = new Tan();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}