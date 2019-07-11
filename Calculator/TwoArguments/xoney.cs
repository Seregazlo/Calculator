using System;
using System.Windows.Forms.VisualStyles;

namespace Calculator.TwoArguments
{
    public class xoney: ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {   
            if(secondValue==0)throw new Exception("Первый аргумент возводится в степень 1/0");
            return Math.Pow(firstValue,(1/secondValue));
        }
    }
}
