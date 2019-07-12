using Calculator.OneArguments;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
{
    [TestFixture]
    public class SinTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 0.84)]
        [TestCase(2, 0.90)]
        public void CalculatorTest(
            double firstValue,
            double expected)
        {
            var calculator = new Sin();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}