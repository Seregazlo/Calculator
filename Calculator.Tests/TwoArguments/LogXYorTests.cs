using System;
using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class LogXYorTests
    {
        [Test]
        public void CalculatorTest()
        {
            var calculator = new LogXY();
            Assert.Throws<Exception>(() => calculator.Calculate(-5, -1));
        }
    }
}