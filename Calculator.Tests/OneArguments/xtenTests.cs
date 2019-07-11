using Calculator.OneArguments;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
{
    [TestFixture]
    public class xtenTests
    {
        [TestCase(1, 10)]
        public void CalculatorTest(
            double firstValue,
            double expected)
        {
            var calculator = new xten();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}