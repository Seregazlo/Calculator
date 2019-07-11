using System;
using Calculator.OneArguments;
using NUnit.Framework;

namespace Calculator.Tests.OneArguments
{
    [TestFixture]
    public class AcrCosErrorTests
    {
        [Test]
        public void CalculatorTest()
        {
            var calculator = new Acrcos();
            Assert.Throws<Exception>(() => calculator.Calculate(6));
        }
    }
}