using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class logxyTests
    {
        [TestCase(2, 2, 1)]
        [TestCase(50, 50, 1)]
        [TestCase(6, 6, 1)]
        public void CalculatorTest(
            double firstValue,
            double secondValue,
            double expected)
        {
            var calculator = new logxy();
            var actualResult = calculator.Calculate(firstValue,secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}