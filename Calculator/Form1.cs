using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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

        private void AdditionButton_Click(object sender, EventArgs e)
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

        private void CheckButton_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(FirstField.Text);
            double secondNumber = Convert.ToDouble(SecondField.Text);
            double result;
            switch (((Button) sender).Name)
            {
                case "Addition":
                    result = firstNumber + secondNumber;
                    Result.Text = result.ToString();
                    break;
                case "Difference":
                     result = firstNumber - secondNumber;
                     Result.Text = result.ToString();
                    break;
                case "Multiplication":
                    result = firstNumber * secondNumber;
                    Result.Text = result.ToString();
                    break;
                case "Division":
                    result = firstNumber / secondNumber;
                    Result.Text = result.ToString();
                    break;
            }
        }
    }
    
    
}
