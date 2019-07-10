using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class OneArgumentsFactory
    {
        public static IOneArgumentsCalculator CreateCalculator(string Name)
            {
                switch (Name)
                {
                    case "Sin":
                        return new Sin();
                    case "Cos":
                        return new Cos();
                    case "Exponent":
                        return new Exponentation();
                    case "Sqrt":
                        return new Sqrt();
                    default:
                        throw new Exception("Error");
                }
            }
        
    }
}