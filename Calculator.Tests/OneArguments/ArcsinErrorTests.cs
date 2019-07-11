using System;
using Calculator.OneArguments;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
{
    [TestFixture]
    public class ArcsinErrorTests
    {
        [Test]
        public void CalculatorTest()
        {
            var calculator = new Arcsin();
            Assert.Throws<Exception>(()=>calculator.Calculate(-5));
        }
    }
}