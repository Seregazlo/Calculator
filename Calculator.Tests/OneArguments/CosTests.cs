using Calculator.OneArguments;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
{
    [TestFixture]
    public class CosTests
    {
        [TestCase(0, 1)]
        [TestCase(2, -0.41)]
        [TestCase(1, 0.54)]
        public void CalculatorTest(
            double firstValue,
            double expected)
        {
            var calculator = new Cos();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}