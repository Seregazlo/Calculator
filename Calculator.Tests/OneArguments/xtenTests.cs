using Calculator.OneArguments;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
{
    [TestFixture]
    public class XTenTests
    {
        [TestCase(1, 10)]
        [TestCase(0, 1)]
        [TestCase(2, 100)]
        public void CalculatorTest(
            double firstValue,
            double expected)
        {
            var calculator = new XTen();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}