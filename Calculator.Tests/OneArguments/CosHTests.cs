using Calculator.OneArguments;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
{
    [TestFixture]
    public class CosHTests
    {
        [TestCase(0, 1)]

        public void CalculatorTest(
            double firstValue,
            double expected)
        {
            var calculator = new CosH();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}