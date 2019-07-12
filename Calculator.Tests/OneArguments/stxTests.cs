using Calculator.OneArguments;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
{
    [TestFixture]
    public class StXTests
    {
        [TestCase(1, 2)]
        [TestCase(5, 32)]
        [TestCase(4, 16)]
        public void CalculatorTest(
            double firstValue,
            double expected)
        {
            var calculator = new StX();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}