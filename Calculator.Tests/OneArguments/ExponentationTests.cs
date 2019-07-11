using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class ExponentationTests
    {
        [Test]
        public void CalculatorTests()
        {
            var calculator = new Exponentation();
            double actual = calculator.Calculate(3);
            Assert.AreEqual(9, actual: actual);
        }
    }
}