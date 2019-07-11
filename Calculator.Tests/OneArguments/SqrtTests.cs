using Calculator.OneArguments;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
{
    [TestFixture]
    public class SqrtTests
    {
        [Test]
        public void CalculatorTests()
        {
            var calculator = new Sqrt();
            double actual = calculator.Calculate(4);
            Assert.AreEqual(2, actual: actual);
        }
    }
}