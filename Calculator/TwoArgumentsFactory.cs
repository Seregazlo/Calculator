using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{

    public class TwoArgumentsFactory

    {
        public static ITwoArgumentsCalculator CreateCalculator(string Name)
        {
            switch (Name)
            {
                case "Addition":
                    return new Adder();
                case "Difference":
                    return new Discripter();
                case "Multiplication":
                    return new Mulitipleer();
                case "Division":
                    return new Divider();
                case "Pow":
                    return new Pow();
                case "RemainDivision":
                    return new RemainDivision();
                case "ArithmeticMean":
                    return new ArithmeticMean();
                default:
                    throw new Exception("Error");
            }
        }
    }
}
