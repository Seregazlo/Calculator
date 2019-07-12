using Calculator.OneArguments;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
{
    [TestFixture]
    public class TanHTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 0.76)]
        [TestCase(2, 0.96)]
        public void CalculatorTest(
            double firstValue,
            double expected)
        {
            var calculator = new TanH();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}