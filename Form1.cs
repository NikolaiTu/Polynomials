using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MathNet.Numerics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Polynomials
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //mutliply polynomial with num
            //polynomial additionn
            //graph a polynomial
            Polynomial PolyNums = new Polynomial(1, 2, 3);
            Polynomial PolyNums2 = new Polynomial(0, 1);

            var Multiplication = PolyNums * 3;

            var Addition = PolyNums + PolyNums2;

            for (int i = -20; i <= 20; i++)
            {
                PolynomialChart.Series[0].Points.Add(PolyNums.Evaluate(i));
            }
        }

        public void MultiplyWithNumber(string input, string numBoxText)
        {
            string[] values = input.Split(' ');
            double[] coefficients = new double[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                coefficients[i] = double.Parse(values[i]);
            }
            Polynomial PolyNums = new Polynomial(coefficients);

            var Answer = PolyNums * int.Parse(numBoxText);
            AnswerLabel.Text = Answer.ToString();
        }


        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            MultiplyWithNumber(PolyTextBox1.Text, PolyMultiplyNumBox.Text);
        }

        private void MultiplyButton2_Click(object sender, EventArgs e)
        {
            MultiplyWithNumber(PolyTextBox2.Text, PolyMultiplyNumBox2.Text);
        }

        private void AdditionButton_Click(object sender, EventArgs e)
        {
            string[] values = PolyTextBox1.Text.Split(' ');
            double[] coefficients = new double[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                coefficients[i] = double.Parse(values[i]);
            }

            string[] values2 = PolyTextBox1.Text.Split(' ');
            double[] coefficients2 = new double[values2.Length];
            for (int i = 0; i < values2.Length; i++)
            {
                coefficients2[i] = double.Parse(values2[i]);
            }

            Polynomial PolyNums = new Polynomial(coefficients);
            Polynomial PolyNums2 = new Polynomial(coefficients2);

            var Answer = PolyNums + PolyNums2;
            AnswerLabel.Text = Answer.ToString();
        }

        private void ChartButton_Click(object sender, EventArgs e)
        {
            string[] values = PolyTextBox1.Text.Split(' ');
            double[] coefficients = new double[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                coefficients[i] = double.Parse(values[i]);
            }

            string[] values2 = PolyTextBox1.Text.Split(' ');
            double[] coefficients2 = new double[values2.Length];
            for (int i = 0; i < values2.Length; i++)
            {
                coefficients2[i] = double.Parse(values2[i]);
            }

            Polynomial PolyNums = new Polynomial(coefficients);
            Polynomial PolyNums2 = new Polynomial(coefficients2);

            for (int i = -20; i <= 20; i++)
            {
                PolynomialChart.Series[0].Points.Add(PolyNums.Evaluate(i));
            }
        }
    }
}
