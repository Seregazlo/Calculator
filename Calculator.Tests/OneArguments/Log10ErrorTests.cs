using System;
using Calculator.OneArguments;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
{
    [TestFixture]
    public class Log10ErrorTests
    {
        [Test]
        public void CalculatorTest()
        {
            var calculator = new Log10();
            Assert.Throws<Exception>(() => calculator.Calculate(-5));
        }
    }
}