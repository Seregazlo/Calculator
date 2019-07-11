using Calculator.OneArguments;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
{
    [TestFixture]
    public class ExponentationTests
    {
        [Test]
        public void CalculatorTests()
        {
            var calculator = new Exponentation();
            double actual = calculator.Calculate(3);
            Assert.AreEqual(9, actual: actual);
        }
    }
}