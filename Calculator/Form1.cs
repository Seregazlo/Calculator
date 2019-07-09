﻿using System;
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
            double NumbersFromFirstField = Convert.ToDouble(FirstField.Text);
            double NumbersFromSecondField = Convert.ToDouble(SecondField.Text);
            double result = NumbersFromFirstField + NumbersFromSecondField;
            Result.Text = result.ToString();
        }

        private void DifferenceButton_Click(object sender, EventArgs e)
        {
            double NumbersFromFirstField = Convert.ToDouble(FirstField.Text);
            double NumbersFromSecondField = Convert.ToDouble(SecondField.Text);
            double result = NumbersFromFirstField - NumbersFromSecondField;
            Result.Text = result.ToString();
        }

        private void MultiplicationButton_Click(object sender, EventArgs e)
        {
            double NumbersFromFirstField = Convert.ToDouble(FirstField.Text);
            double NumbersFromSecondField = Convert.ToDouble(SecondField.Text);
            double result = NumbersFromFirstField * NumbersFromSecondField;
            Result.Text = result.ToString();
        }

        private void DivisionButton_Click(object sender, EventArgs e)
        {
            double NumbersFromFirstField = Convert.ToDouble(FirstField.Text);
            double NumbersFromSecondField = Convert.ToDouble(SecondField.Text);
            double result = NumbersFromFirstField / NumbersFromSecondField;
            Result.Text = result.ToString();
        }
    }
}
