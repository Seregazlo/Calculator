using System;
using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class xoneyErrorTests
    {
        [Test]
        public void CalculatorTest()
        {
            var calculator = new xoney();
            Assert.Throws<Exception>(() => calculator.Calculate(2, 0));
        }
    }
}