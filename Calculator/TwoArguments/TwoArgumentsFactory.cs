using System;
using Calculator.TwoArguments;

namespace Calculator
{

    public class TwoArgumentsFactory

    { 
    /// <summary>
    /// That two arguments function
    /// </summary>
    /// <param name="Name"></param>
    /// <returns></returns>
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
                case "logxy":
                    return new logxy();
                case "minxy":
                    return new minxy();
                case "maxxy":
                    return new maxxy();
                case "xoney":
                    return new xoney();
                default:
                    throw new Exception("Error");
            }
        }
    }
}
