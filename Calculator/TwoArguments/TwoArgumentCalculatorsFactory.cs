using System;

namespace Calculator.TwoArguments
{
    public static class TwoArgumentCalculatorsFactory
    {
        /// <summary>
        /// That two arguments function
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public static ITwoArgumentCalculators CreateCalculator(string Name)
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
                    return new LogXY();
                case "minxy":
                    return new MinXY();
                case "maxxy":
                    return new MaxXY();
                case "xoney":
                    return new XoneY();
                default:
                    throw new Exception("Error");
            }
        }
    }
}
