using System;
using Calculator.OneArguments;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
{
    [TestFixture]
    public class SqrtErrorTests
    {
        [Test]
        public void CalculatorTests()
        {
            var calculator = new Sqrt();
            Assert.Throws<Exception>(()=>calculator.Calculate(-1));
        }
    }
}