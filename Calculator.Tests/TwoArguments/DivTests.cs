using System;
using System.Runtime.Remoting.Messaging;
using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class DivTests
    {
        [Test]
        public void CalculatorTests()
        {
            var calculator = new Divider();
            Assert.Throws<Exception>(() => calculator.Calculate(1, 0));
        }
    }
}