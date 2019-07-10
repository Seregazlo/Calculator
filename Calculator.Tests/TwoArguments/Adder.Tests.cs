using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{[TestFixture]
    public class AdderTests
    {[Test]
        public void CalculatorTests()
        {   
            var calculator = new Adder();
            double actual = calculator.Calculate(1,2);
            Assert.AreEqual(3,actual:actual);
        }
    }
}
