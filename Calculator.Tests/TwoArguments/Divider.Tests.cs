using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class DividerTests
    {
        [Test]
        public void CalculatorTests()
        {
            var calculator = new Divider();
            double actual = calculator.Calculate(4, 2);
            Assert.AreEqual(2, actual: actual);
        }
    }
}
