using Calculator.OneArguments;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
{
    [TestFixture]
    public class SinHTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 1.17)]
        [TestCase(2, 3.62)]
        public void CalculatorTest(
            double firstValue,
            double expected)
        {
            var calculator = new SinH();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}