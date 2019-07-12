using Calculator.OneArguments;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
{
    [TestFixture]
    public class FalseXTests
    {
        [TestCase(2, -2)]
        [TestCase(1, -1)]
        [TestCase(559, -559)]
        public void CalculatorTest(
            double firstValue,
            double expected)
        {
            var calculator = new FalseX();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}