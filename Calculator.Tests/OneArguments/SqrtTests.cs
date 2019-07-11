using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class SqrtTests
    {
        [Test]
        public void CalculatorTests()
        {
            var calculator = new Sqrt();
            double actual = calculator.Calculate(4);
            Assert.AreEqual(2, actual: actual);
        }
    }
}