using Calculator.OneArguments;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
{
    [TestFixture]
    public class stxTests
    {
        [TestCase(1, 2)]
        public void CalculatorTest(
            double firstValue,
            double expected)
        {
            var calculator = new stx();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}