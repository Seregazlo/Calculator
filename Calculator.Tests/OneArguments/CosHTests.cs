using Calculator.OneArguments;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
{
    [TestFixture]
    public class CosHTests
    {
        [TestCase(0, 1)]
        [TestCase(1, 1.54)]
        [TestCase(0.5, 1.12)]

        public void CalculatorTest(
            double firstValue,
            double expected)
        {
            var calculator = new CosH();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}