using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Calculator;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FirstField_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SecondField_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResultField_Click(object sender, EventArgs e)
        {

        }

    /*    private void AdditionButton_Click(object sender, EventArgs e)
        {

        }

        private void DifferenceButton_Click(object sender, EventArgs e)
        {

        }

        private void MultiplicationButton_Click(object sender, EventArgs e)
        {

        }

        private void DivisionButton_Click(object sender, EventArgs e)
        {

        }
        */
        private void CheckButton_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(FirstField.Text);
            double secondNumber = Convert.ToDouble(SecondField.Text);
            ITwoArgumentsCalculator calculator= TwoArgumentsFactory.CreateCalculator(((Button)sender).Name);
            double result = calculator.Calculate(firstNumber, secondNumber);
            Result.Text = result.ToString();
        }
        private void CheckButton_Click_2(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(FirstField.Text);
            IOneArgumentsCalculator calc = OneArgumentsFactory.CreateCalculator(((Button)sender).Name);
            double resultation = calc.Calculate(firstNumber);
            Result.Text = resultation.ToString();
        }
    }
}
