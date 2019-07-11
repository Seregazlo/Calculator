using System;
using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class logxyErrorTests
    {
        [Test]
        public void CalculatorTest()
        {
            var calculator = new logxy();
            Assert.Throws<Exception>(() => calculator.Calculate(-5,-1));
        }
    }
}