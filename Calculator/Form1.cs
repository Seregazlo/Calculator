using System;
using System.Windows.Forms;
using Calculator.OneArguments;
using Calculator.TwoArguments;

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

        private void CheckButton_Click(object sender, EventArgs e)
        {
            try
            {
                double firstNumber = Convert.ToDouble(FirstField.Text);
                double secondNumber = Convert.ToDouble(SecondField.Text);
                ITwoArgumentCalculators calculator = TwoArgumentCalculatorsFactory.CreateCalculator(((Button)sender).Name);
                double result = calculator.Calculate(firstNumber, secondNumber);
                Result.Text = result.ToString();
            }
            catch (Exception ty)
            {
                MessageBox.Show("Ошибка: " + ty.Message);
            }
        }
        private void CheckButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                double firstNumber = Convert.ToDouble(FirstField.Text);
                IOneArgumentCalculators calc = OneArgumentCalculatorsFactory.CreateCalculator(((Button)sender).Name);
                double resultation = calc.Calculate(firstNumber);
                Result.Text = resultation.ToString();
            }
            catch (Exception ty)
            {
                MessageBox.Show("Ошибка: " + ty.Message);
            }
        }
    }
}
