using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class MulitipleerTests
    {
        [Test]
        public void CalculatorTests()
        {
            var calculator = new Mulitipleer();
            double actual = calculator.Calculate(3, 2);
            Assert.AreEqual(6, actual: actual);
        }
    }
}
