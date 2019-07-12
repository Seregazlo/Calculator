using Calculator.OneArguments;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
{
    [TestFixture]
    public class ExpTests
    {
        [TestCase(0, 1)]
        [TestCase(1, 2.71)]
        [TestCase(5, 148.41)]
        public void CalculatorTest(
            double firstValue,
            double expected)
        {
            var calculator = new Exp();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}