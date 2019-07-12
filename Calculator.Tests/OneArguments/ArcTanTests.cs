using Calculator.OneArguments;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
{
    [TestFixture]
    public class ArcTanTests
    {
        [TestCase(0, 0)]
        [TestCase(2, 1.10)]
        [TestCase(5, 1.37)]
        public void CalculatorTest(
            double firstValue,
            double expected)
        {
            var calculator = new ArcTan();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}