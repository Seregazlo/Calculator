using Calculator.OneArguments;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
{
    [TestFixture]
    public class ExponentationTests
    {
        [TestCase(4,16)]
        [TestCase(2, 4)]
        [TestCase(3, 9)]
        public void CalculatorTests(double firstValue,double expected)
        {
            var calculator = new Exponentation();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}